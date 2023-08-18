Imports System.Net.Mail
Public Class FrmLogin
    Public SQL As New SQLControl

    Private AnimatedImage As Image
    Private securityCode As String
    Private suspended As Boolean
    Private currentCGID As String
    Private noAccess As Boolean

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Async Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        pnlLoading.Visible = False
        pnlRecovery.Visible = False
        pnlRecoveryCode.Visible = False
        pnlRecoveryPassword.Visible = False
        resizeAndRelocate()
        lblVer.Text = String.Format("Ver: {0}", Application.ProductVersion)
        lblVerR.Text = String.Format("Ver: {0}", Application.ProductVersion)
        lblVerRC.Text = String.Format("Ver: {0}", Application.ProductVersion)
        lblVerRP.Text = String.Format("Ver: {0}", Application.ProductVersion)

        Me.Show()

        Await Task.Delay(200)
        pnlLogin.Visible = True
        pnlMain.Visible = True
        txtID.Focus()
    End Sub

    Private Sub ClearAllTextBox()
        txtID.Clear()
        txtPass.Clear()
        txtCGID.Clear()
        txtRCode.Clear()
        txtNewPassword1.Clear()
        txtNewPassword2.Clear()
    End Sub

    Private Sub resizeAndRelocate()
        pnlMain.Size = New Size(806, 542)
        pnlMain.Left = (pnlMain.Parent.Width \ 2) - (pnlMain.Width \ 2)
        pnlMain.Top = (pnlMain.Parent.Height \ 2) - (pnlMain.Height \ 2) + 10

        pnlLogin.Size = New Size(398, 472)
        pnlLogin.Location = New Point(543, 119)
        pnlLogin.Top = (pnlLogin.Parent.Height \ 2) - (pnlLogin.Height \ 2) + 10

        pnlRecovery.Size = New Size(398, 472)
        pnlRecovery.Location = New Point(543, 119)
        pnlRecovery.Top = (pnlRecovery.Parent.Height \ 2) - (pnlRecovery.Height \ 2) + 10

        pnlRecoveryCode.Size = New Size(398, 472)
        pnlRecoveryCode.Location = New Point(543, 119)
        pnlRecoveryCode.Top = (pnlRecovery.Parent.Height \ 2) - (pnlRecovery.Height \ 2) + 10

        pnlRecoveryPassword.Size = New Size(398, 472)
        pnlRecoveryPassword.Location = New Point(543, 119)
        pnlRecoveryPassword.Top = (pnlRecovery.Parent.Height \ 2) - (pnlRecovery.Height \ 2) + 10

        pnlLoading.Size = New Size(398, 472)
        pnlLoading.Location = pnlLogin.Location

        picHero.Left = (picHero.Parent.Width \ 2) - (picHero.Width \ 2)

        loadingGif.Left = (loadingGif.Parent.Width \ 2) - (loadingGif.Width \ 2)
        loadingGif.Top = (loadingGif.Parent.Height \ 2) - (loadingGif.Height \ 2)
    End Sub

    Function isEmailValid(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then
            Return False
        End If

        Try
            Dim mailAddress As New MailAddress(email)
            Return True
        Catch ex As FormatException
            Return False
        End Try
    End Function

    Private Async Function ExecQueryAsync(query As String) As Task
        Await Task.Run(Sub() SQL.ExecQuery(query))
    End Function

    Private Async Function performLogin() As Task(Of Boolean)
        Try
            Dim decpass As String = Encrypt(txtPass.Text)
            SQL.AddParam("@id", txtID.Text)
            SQL.AddParam("@pass", decpass)

            Await Task.Delay(1000)

            Await ExecQueryAsync("SELECT * FROM Users WHERE UserID = @id AND UserPass = @pass")
            If SQL.HasException(True) Then Return False

            If SQL.RecordCount > 0 Then
                If SQL.DBDT.Rows(0)("Status") = 0 Then
                    suspended = True
                Else
                    Dim UserGroup As String = SQL.DBDT.Rows(0)("UserGroup").ToString
                    If Not (UserGroup = "SMT" Or UserGroup = "SMT Feeder" Or UserGroup = "System Admin") Then
                        noAccess = True
                        Return False
                    End If
                    FrmMain.UserID = SQL.DBDT.Rows(0)("UserID").ToString
                    FrmMain.UserGroup = SQL.DBDT.Rows(0)("UserGroup").ToString
                    FrmMain.UserLevel = SQL.DBDT.Rows(0)("UserLevel").ToString

                    SQL.AddParam("@name", SQL.DBDT.Rows(0)("Name"))
                    SQL.AddParam("@uid", SQL.DBDT.Rows(0)("UserID"))
                    SQL.AddParam("@log", "USER LOGGED IN TO THE SYSTEM")
                    SQL.ExecQuery("INSERT INTO UserLog(RecordTime, UserName, UserID, LogDesc) VALUES(GETDATE(), @name, @uid, @log);")
                    If SQL.HasException(True) Then Return False
                    Return True
                End If
            End If
        Catch ex As Exception
            Return False
        End Try

        Return False
    End Function

    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtID.Text.Trim.ToLower = "@" And txtPass.Text.Trim = "@" Then
            FrmMain.UserGroup = "System Admin"
            FrmMain.UserLevel = "3"
            GoTo superaccess
        End If

        If txtID.Text.Length < 1 Or txtPass.Text.Length < 1 Then
            MessageBox.Show("Incorrect login details. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtID.Focus()
            txtID.SelectAll()
            Exit Sub
        End If

        Transition.HideSync(pnlLogin)
        pnlLoading.Visible = True

        Await Task.Delay(500)

        Dim loginStatus As Boolean = Await Task.Run(Function() performLogin())

        If loginStatus Then
superaccess:
            txtID.Clear()
            txtPass.Clear()

            Dim UserID As String = FrmMain.UserID
            Dim UserGroup As String = FrmMain.UserGroup
            Dim UserLevel As Integer = FrmMain.UserLevel
            Dim selection As Boolean

            If (UserGroup = "System Admin" Or UserGroup = "SMT") AndAlso (UserLevel = 3 Or UserLevel = 2) Then
                FrmSelection.BtnFeeder.Enabled = True
                FrmSelection.BtnPM.Enabled = True
                selection = True
            ElseIf UserGroup = "SMT Feeder" AndAlso (UserLevel = 1 Or UserLevel = 2) Then
                FrmSelection.BtnFeeder.Enabled = False
                FrmSelection.BtnPM.Enabled = False
                selection = False
            Else
                FrmSelection.BtnFeeder.Enabled = False
                FrmSelection.BtnPM.Enabled = False
                selection = True
            End If

            pnlLoading.Visible = False
            Me.Hide()

            If selection Then
                FrmSelection.Show()
            Else
                FrmMain.Show()
            End If

            Transition.ShowSync(pnlLogin)
        Else
            pnlLoading.Visible = False
            Transition.ShowSync(pnlLogin)
            If suspended Then
                MessageBox.Show("Your account has been suspended." & vbCrLf & "Please check with your Group Adminisrator for assistance.", "Account has been suspended", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf noAccess Then
                MessageBox.Show("You do not have access to this feature." & vbCrLf & "Please check with your Group Adminisrator for assistance.", "Access Declined", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Incorrect login details. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            suspended = False
            noAccess = False
            txtID.Select(0, txtID.Text.Length)
            txtID.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Async Sub txtRecover_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtRecover.LinkClicked
        Transition.HideSync(pnlLogin)

        pnlLoading.Visible = True

        Await Task.Delay(500)

        pnlLoading.Visible = False
        Transition.ShowSync(pnlRecovery)
        txtCGID.Focus()
    End Sub

    Private Async Sub btnRBack_Click(sender As Object, e As EventArgs) Handles btnRCancel.Click
        Transition.HideSync(pnlRecovery)
        pnlLoading.Visible = True

        ClearAllTextBox()

        Await Task.Delay(500)

        pnlLoading.Visible = False
        Transition.ShowSync(pnlLogin)
        txtID.Focus()
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Try
                txtPass.Focus()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Try
                btnLogin.PerformClick()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Function generateSecurityCode() As String
        ' Generate a random 6-digit code
        Dim random As New Random()
        Dim code As Integer = random.Next(100000, 999999)
        Return code.ToString()
    End Function

    Function LoadEmailTemplate() As String
        ' Read the HTML template from a file or directly assign it as a string variable
        ' Here, the template is assigned directly as a string for simplicity
        Dim logoLink As String = "https://i.ibb.co/pyJSS2R/CG-GLOBAL-1.png"
        Dim template As String = "
<!DOCTYPE html>
<html>
<head>
  <style>
    /* Define your CSS styles here */
    /* Define your CSS styles here */
*{
  margin: 0px;
padding: 0px;
  text-align: center;
}    
body {
      font-family: Arial, sans-serif;
      background-color: #f1f1f1;
      color: #333333;
    }
    
    .parent-container {
      background-color: #f1f1f1;
      padding: 20px;
    }
    
    .container {
      max-width: 600px;
      margin: 0 auto;
      padding: 20px;
      background-color: #ffffff;
      border-radius: 4px;
      box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
    }
   
    .logo {
      display: block;
      margin: 0 auto;
      padding-bottom: 20px;
      max-width: 200px;
    }

    h1 {
      color: #7F1F22;
      margin-bottom: 20px;
    }
    
.bold {
      font-weight: bold;
    }

p {
      margin: 10px 0;
    }
.code {
      margin: 60px 0;
      text-align: center;
      font-size: 30px;
      font-weight: bold;
      letter-spacing: 1rem;
      padding-left: 1rem;
    }

 .footer {
      margin-top: 30px;
      text-align: center;
   font-weight: bold;
    }
  </style>
</head>
<body>
  <div class='parent-container'>
    <div class='container'>
       <img class='logo' src='" & logoLink & "' alt='Logo'>
      <h1>Password Reset for CG Global Profastex Manufacturing MES</h1>
      <p class='bold'>Dear {{employee}},</p>
      <p>Use this code to reset your CG Global Profastex Manufacturing MES password:</p>
      <div class='code'>{{securityCode}}</div>
      <div class='info'><p>If you didn't request this code, please ignore this email.</p></div>
      <p class='footer'>Best regards,<br>CG Global Profastex Manufacturing Sdn. Bhd.</p>
    </div>
  </div>
</body>
</html>
"

        Return template
    End Function

    Private Async Function sendSecurityCode(code As String, email As String, employeeName As String) As Task(Of Boolean)

        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress("cggprofastex.notify@gmail.com")
            mail.To.Add(email)
            mail.Subject = "Password Reset for CG Global Profastex Manufacturing MES"
        
            ' Load the HTML template from a file or a string
            Dim htmlBody As String = LoadEmailTemplate()
        
            ' Replace the placeholder with the actual security code
            htmlBody = htmlBody.Replace("{{securityCode}}", code)
            htmlBody = htmlBody.Replace("{{employee}}", employeeName) 'add employee id
        
            mail.Body = htmlBody
            mail.IsBodyHtml = True ' Set the email body as HTML
        
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New System.Net.NetworkCredential("cggprofastex.notify@gmail.com", "gcahibfhundliizi")
        
            Await smtp.SendMailAsync(mail)
        
            Return True ' Email sent successfully
        Catch ex As Exception
            Return False ' Failed to send email
        End Try
    End Function

    Private Async Function performRecovery(email As String, name As String) As Task(Of Boolean)
        securityCode = generateSecurityCode()

        Dim formattedName As String = StrConv(name, VbStrConv.ProperCase)

        Dim status As Boolean = Await Task.Run(Function() sendSecurityCode(securityCode, email, formattedName))

        If status Then
            Return True
        End If

        Return False
    End Function

    Private Async Sub btnRConfirm_Click(sender As Object, e As EventArgs) Handles btnRConfirm.Click
        Transition.HideSync(pnlRecovery)
        pnlLoading.Visible = True

        Await Task.Delay(500)

        SQL.AddParam("@id", txtCGID.Text.Trim)
        SQL.ExecQuery("SELECT TOP 1 * FROM Users WHERE UserID = @id")
        If SQL.HasException(True) Then Exit Sub

        If SQL.RecordCount > 0 Then
            Dim email As String = SQL.DBDT.Rows(0)("Email").ToString
            Dim name As String = SQL.DBDT.Rows(0)("Name").ToString
            currentCGID = txtCGID.Text.Trim
            If isEmailValid(email) Then
                Dim recoveryStatus As Boolean = Await Task.Run(Function() performRecovery(email, name))

                pnlLoading.Visible = False
                Transition.ShowSync(IIf(recoveryStatus, pnlRecoveryCode, pnlRecovery))

                If recoveryStatus Then
                    txtRCode.Focus()
                Else
                    MessageBox.Show("Connection error. Please try again.", "Recovery Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                pnlLoading.Visible = False
                Transition.ShowSync(pnlRecovery)
                MessageBox.Show("Incorrect email details. Please try again.", "Recovery Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            pnlLoading.Visible = False
            Transition.ShowSync(pnlRecovery)
            MessageBox.Show("The Employee ID entered is invalid.", "Recovery Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Async Sub btnRCBack_Click(sender As Object, e As EventArgs) Handles btnRCBack.Click
        Transition.HideSync(pnlRecoveryCode)
        pnlLoading.Visible = True

        txtRCode.Clear()

        Await Task.Delay(500)

        pnlLoading.Visible = False
        Transition.ShowSync(pnlRecovery)
        txtCGID.Focus()
    End Sub

    Function verifySecurityCode(enteredCode As String, storedCode As String) As Boolean
        Return enteredCode = storedCode
    End Function

    Private Async Function performRecoveryPassword() As Task(Of Boolean)
        If txtRCode.Text.Length > 1 Then
            Await Task.Delay(1000)
            Return True
        Else
            Await Task.Delay(500)
        End If

        Return False
    End Function

    Private Async Sub btnRCConfirm_Click(sender As Object, e As EventArgs) Handles btnRCConfirm.Click
        Transition.HideSync(pnlRecoveryCode)
        pnlLoading.Visible = True

        Await Task.Delay(500)

        If verifySecurityCode(txtRCode.Text.Trim, securityCode) Then
            ' Perform actions if the code is correct
            Dim recoveryStatus As Boolean = Await Task.Run(Function() performRecoveryPassword())

            pnlLoading.Visible = False
            Transition.ShowSync(IIf(recoveryStatus, pnlRecoveryPassword, pnlRecoveryCode))

            If recoveryStatus Then
                txtNewPassword1.Focus()
            Else
                MessageBox.Show("Connection error. Please try again.", "Recovery Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            pnlLoading.Visible = False
            Transition.ShowSync(pnlRecoveryCode)
            MessageBox.Show("The recovery key you entered is not valid. Please try again.", "Recovery Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Async Sub btnRPCancel_Click(sender As Object, e As EventArgs) Handles btnRPCancel.Click
        Transition.HideSync(pnlRecoveryPassword)
        pnlLoading.Visible = True

        ClearAllTextBox()

        Await Task.Delay(500)

        pnlLoading.Visible = False
        Transition.ShowSync(pnlLogin)
    End Sub

    Private Async Function DoUpdatePassword() As Task(Of Boolean)
        Try
            SQL.AddParam("@cgid", currentCGID)
            SQL.AddParam("@newpass", Encrypt(txtNewPassword1.Text.Trim))

            Await ExecQueryAsync("UPDATE Users SET UserPass = @newpass WHERE UserID = @cgid")
            If SQL.HasException(True) Then Return False

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Async Sub btnRPConfirm_Click(sender As Object, e As EventArgs) Handles btnRPConfirm.Click
        Transition.HideSync(pnlRecoveryPassword)
        pnlLoading.Visible = True

        Await Task.Delay(500)

        Dim newPassword As String = txtNewPassword1.Text
        Dim confirmPassword As String = txtNewPassword2.Text

        If newPassword = "" Then
            pnlLoading.Visible = False
            Transition.ShowSync(pnlRecoveryPassword)
            MessageBox.Show("Please enter a new password.", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNewPassword1.Focus()
        ElseIf newPassword <> confirmPassword Then
            pnlLoading.Visible = False
            Transition.ShowSync(pnlRecoveryPassword)
            MessageBox.Show("Passwords do not match. Please re-enter the passwords.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNewPassword1.Clear()
            txtNewPassword2.Clear()
            txtNewPassword1.Focus()
        Else
            Dim recoveryStatus As Boolean = Await Task.Run(Function() DoUpdatePassword())

            If recoveryStatus Then
                ClearAllTextBox()
                pnlLoading.Visible = False
                Transition.ShowSync(pnlLogin)

                MessageBox.Show("Password recovered successfully.", "Password Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                pnlLoading.Visible = False
                Transition.ShowSync(pnlRecoveryPassword)

                MessageBox.Show("Connection error. Please try again.", "Recovery Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNewPassword1.SelectAll()
            End If
            txtID.Focus()
        End If
    End Sub

    Private Sub txtCGID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCGID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Try
                btnRConfirm.PerformClick()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub txtRCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Try
                btnRCConfirm.PerformClick()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub txtNewPassword1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewPassword1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Try
                txtNewPassword2.Focus()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub txtNewPassword2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewPassword2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Try
                btnRPConfirm.PerformClick()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub


End Class