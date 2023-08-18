Public Class FrmUserManage
    Public SQL As New SQLControl
    Public DATA As New SQLUserLog

    Public Shared mode As Integer

    Dim selection As Integer
    Dim oldID As String
    Dim oldEmail As String
    Dim oldName As String
    Dim oldPass As String
    Dim oldGroup As String
    Dim oldLevel As String
    Dim oldStatus As Boolean

    Public Sub New()
        InitializeComponent()
        ResizeAndCenter()
        SetupDGV()
        SetupGroupLvl()
    End Sub

    Private Sub FrmUserManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        LblVer.Text = String.Format("Ver: {0}", Application.ProductVersion)

        LoadDatatoDGV()

        dgvUser_CellClick(Nothing, Nothing)
        Me.Show()
    End Sub

    Private Sub ResizeAndCenter()
        LblVer.Left = (LblVer.Parent.Width \ 2) - (LblVer.Width \ 2)
        LblVer.Top = (LblVer.Parent.Height \ 2) - (LblVer.Height \ 2) + 410

        ImgHero.Left = (ImgHero.Parent.Width \ 2) - (ImgHero.Width \ 2)

        lblDetails.Left = (lblDetails.Parent.Width \ 2) - (lblDetails.Width \ 2)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ctrlClose.PerformClick()
    End Sub

    Private Sub SetupDGV()
        With dgvUser
            .Left = (.Parent.Width \ 2) - (.Width \ 2)
            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False
            .ColumnCount = 6
            .AllowUserToResizeRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            Dim columns As String() = {"No.", "Employee ID", "Employee Name", "User Group", "User Level", "Status"}
            Dim widths As Integer() = {30, 65, 140, 70, 100, 70}

            For i As Integer = 0 To columns.Length - 1
                .Columns(i).Name = columns(i)
            Next

            For i As Integer = 0 To widths.Length - 1
                .Columns(i).Width = widths(i)
            Next
            .Columns("No.").SortMode = DataGridViewColumnSortMode.NotSortable
        End With
    End Sub

    Private Sub SetupGroupLvl()
        cbxGroup.Items.Clear()
        cbxLevel.Items.Clear()

        cbxGroup.Items.Add("Select User Group")
        cbxLevel.Items.Add("Select User Level")
        cbxGroup.SelectedIndex = 0
        cbxLevel.SelectedIndex = 0

        If FrmMain.UserLevel = 3 Then
            cbxGroup.Items.AddRange({"System Admin", "SMT", "SMT Feeder", "Purchasing", "Store", "Q.A."})
            cbxLevel.Items.AddRange({"System Administrator", "Group Administrator", "Section Operator"})
        ElseIf FrmMain.UserLevel = 2 Then
            If FrmMain.UserGroup = "SMT" Or FrmMain.UserGroup = "SMT Feeder" Then
                cbxGroup.Items.AddRange({"SMT", "SMT Feeder"})
            Else
                cbxGroup.Items.Add(FrmMain.UserGroup)
            End If
            cbxLevel.Items.AddRange({"Group Administrator", "Section Operator"})
        End If
    End Sub

    Private Sub LoadDatatoDGV()
        Dim userLevel As Integer = FrmMain.UserLevel
        Dim userGroup As String = FrmMain.UserGroup

        dgvUser.Rows.Clear()
        dgvUser.Enabled = True

        Dim query As String = "SELECT * FROM Users WHERE UserLevel IN (1, 2, @3)"

        If userLevel = 3 Then
            SQL.AddParam("@3", 3)
            query += " ORDER BY UserID;"
        ElseIf userLevel = 2 Then
            If userGroup = "SMT" Or userGroup = "SMT Feeder" Then
                SQL.AddParam("@3", "")
                SQL.AddParam("@group", "%SMT%")
                query += " AND UserGroup LIKE @group ORDER BY UserID;"
            Else
                SQL.AddParam("@3", "")
                SQL.AddParam("@group", "%" & userGroup & "%")
                query += " AND UserGroup LIKE @group ORDER BY UserID;"
            End If
        End If

        SQL.ExecQuery(query)
        If SQL.HasException(True) Then Exit Sub

        If SQL.RecordCount > 0 Then
            For i As Integer = 1 To SQL.DBDT.Rows.Count
                Dim status As Boolean = SQL.DBDT.Rows(i - 1)("Status")
                Dim textstatus As String = If(status, "ACTIVE", "SUSPENDED")

                Dim textlevel As String = ""
                If SQL.DBDT.Rows(i - 1)("UserLevel") = 3 Then
                    textlevel = "System Administrator"
                ElseIf SQL.DBDT.Rows(i - 1)("UserLevel") = 2 Then
                    textlevel = "Group Administrator"
                ElseIf SQL.DBDT.Rows(i - 1)("UserLevel") = 1 Then
                    textlevel = "Section Operator"
                End If

                dgvUser.Rows.Add(New Object() {i.ToString + ".",
                                  SQL.DBDT.Rows(i - 1)("UserID"), SQL.DBDT.Rows(i - 1)("Name"),
                                  SQL.DBDT.Rows(i - 1)("UserGroup"),
                                  textlevel, textstatus})

                If textstatus = "SUSPENDED" Then
                    For j As Integer = 1 To dgvUser.Columns.Count
                        dgvUser.Rows(dgvUser.Rows.Count - 1).Cells(j - 1).Style.BackColor = Color.FromArgb(255, 192, 192)
                    Next
                End If

            Next
        End If
    End Sub

    Private Function GetUserEmail(UID As String) As String
        Dim result As String = ""

        SQL.AddParam("@id", UID)
        SQL.ExecQuery("SELECT Email FROM Users WHERE UserID = @id")
        If SQL.HasException(True) Then Return result ' Return early in case of exception

        If SQL.RecordCount > 0 Then
            result = SQL.DBDT.Rows(0)("Email").ToString
        End If

        Return result
    End Function

    Private Function GetUserPassword(UID As String) As String
        Dim result As String = ""

        SQL.AddParam("@id", UID)
        SQL.ExecQuery("SELECT UserPass FROM Users WHERE UserID = @id")
        If SQL.HasException(True) Then Return result ' Return early in case of exception

        If SQL.RecordCount > 0 Then
            result = SQL.DBDT.Rows(0)("UserPass").ToString
        End If
        Dim decResult As String = Decrypt(result)

        Return decResult
    End Function

    Private Sub dgvUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellClick
        Dim userLevel As Integer = FrmMain.UserLevel

        txtEmployeeID.Text = dgvUser.CurrentRow.Cells(1).Value.ToString
        txtName.Text = dgvUser.CurrentRow.Cells(2).Value.ToString
        txtPass1.Text = GetUserPassword(dgvUser.CurrentRow.Cells(1).Value.ToString)
        txtPass2.Text = txtPass1.Text
        txtEmail.Text = GetUserEmail(dgvUser.CurrentRow.Cells(1).Value.ToString)

        If userLevel = 3 Then
            Select Case dgvUser.CurrentRow.Cells("User Group").Value.ToString()
                Case "System Admin"
                    cbxGroup.SelectedIndex = 1
                Case "SMT"
                    cbxGroup.SelectedIndex = 2
                Case "SMT Feeder"
                    cbxGroup.SelectedIndex = 3
                Case "Purchasing"
                    cbxGroup.SelectedIndex = 4
                Case "Store"
                    cbxGroup.SelectedIndex = 5
                Case "Q.A."
                    cbxGroup.SelectedIndex = 6
            End Select

            Select Case dgvUser.CurrentRow.Cells("User Level").Value.ToString()
                Case "System Administrator"
                    cbxLevel.SelectedIndex = 1
                Case "Group Administrator"
                    cbxLevel.SelectedIndex = 2
                Case "Section Operator"
                    cbxLevel.SelectedIndex = 3
            End Select
        End If

        If userLevel = "2" Then
            Select Case dgvUser.CurrentRow.Cells("User Group").Value.ToString()
                Case "SMT", "Purchasing", "Store", "Q.A."
                    cbxGroup.SelectedIndex = 1
                Case "SMT Feeder"
                    cbxGroup.SelectedIndex = 0
            End Select

            Select Case dgvUser.CurrentRow.Cells("User Level").Value.ToString()
                Case "Group Administrator"
                    cbxLevel.SelectedIndex = 1
                Case "Section Operator"
                    cbxLevel.SelectedIndex = 2
            End Select
        End If

        If dgvUser.CurrentRow.Cells("Status").Value.ToString() = "SUSPENDED" Then
            btnSuspend.Checked = True
        Else
            btnActive.Checked = True
        End If
    End Sub

    Private Sub ClearInput()
        txtName.Clear()
        txtEmployeeID.Clear()
        txtEmail.Clear()
        txtPass1.Clear()
        txtPass2.Clear()
        btnActive.Checked = True
        cbxGroup.SelectedIndex = 0
        cbxLevel.SelectedIndex = 0
    End Sub

    Private Sub EnableInput()
        txtName.Enabled = True
        txtEmployeeID.Enabled = True
        txtEmail.Enabled = True
        txtPass1.Enabled = True
        txtPass2.Enabled = True
        cbxLevel.Enabled = True
        cbxGroup.Enabled = True
        lblStatus.Enabled = True
        btnActive.Enabled = True
        btnSuspend.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Private Sub DisableInput()
        txtName.Enabled = False
        txtEmployeeID.Enabled = False
        txtEmail.Enabled = False
        txtPass1.Enabled = False
        txtPass2.Enabled = False
        cbxLevel.Enabled = False
        cbxGroup.Enabled = False
        lblStatus.Enabled = False
        btnActive.Enabled = False
        btnSuspend.Enabled = False
        btnCancel.Enabled = False
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        selection = 1
        ClearInput()
        dgvUser.Enabled = False
        EnableInput()
        txtEmployeeID.Focus()
        btnCreate.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnConfirm.Enabled = True
    End Sub

    Private Sub Highlight(UserID As String)
        For i As Integer = 1 To dgvUser.Rows.Count
            If dgvUser.Rows(i - 1).Cells(2).Value = UserID Then
                dgvUser.ClearSelection()
                dgvUser.Rows(i - 1).Selected = True
            End If
        Next
    End Sub

    Private Function CheckDupUserID(UID As String) As Boolean
        SQL.AddParam("@id", UID)
        SQL.ExecQuery("SELECT * FROM Users WHERE UserID = @id")
        Dim result As Boolean = False
        If SQL.RecordCount > 0 Then
            result = True
        End If
        Return result
    End Function

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If txtEmployeeID.Text = "" Then
            MessageBox.Show("The Employee ID information is required.", "Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmployeeID.Focus()
        ElseIf txtName.Text = "" Then
            MessageBox.Show("The User Name information is required.", "User Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtName.Focus()
        ElseIf txtPass1.Text = "" Then
            MessageBox.Show("Password is required.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPass1.Focus()
        ElseIf txtPass1.Text.Length < 6 Then
            MessageBox.Show("A password length of at least 6 characters is required.", "Passwords Length", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPass1.Focus()
            txtPass1.Select(0, txtPass1.Text.Length)
        ElseIf txtPass1.Text <> txtPass2.Text Then
            MessageBox.Show("The entered Passwords do not match!", "Passwords Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPass1.Focus()
            txtPass1.Select(0, txtPass1.Text.Length)
        ElseIf cbxGroup.SelectedIndex = 0 Then
            MessageBox.Show("The User Group selection is required.", "User Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbxGroup.DroppedDown = True
        ElseIf cbxLevel.SelectedIndex = 0 Then
            MessageBox.Show("The User Level selection is required.", "User Level", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbxLevel.DroppedDown = True
        Else
            If selection = 1 Then 'create
                Dim chkdup As Boolean = Not CheckDupUserID(txtEmployeeID.Text)
                If chkdup Then
                    'insert
                    SQL.AddParam("@id", txtEmployeeID.Text)
                    SQL.AddParam("@pass", Encrypt(txtPass1.Text))
                    SQL.AddParam("@name", txtName.Text)
                    SQL.AddParam("@email", txtEmail.Text)
                    SQL.AddParam("@group", cbxGroup.Text)
                    If cbxLevel.Text = "System Administrator" Then
                        SQL.AddParam("@lvl", 3)
                    ElseIf cbxLevel.Text = "Group Administrator" Then
                        SQL.AddParam("@lvl", 2)
                    ElseIf cbxLevel.Text = "Section Operator" Then
                        SQL.AddParam("@lvl", 1)
                    End If
                    If btnActive.Checked Then
                        SQL.AddParam("@stts", 1)
                    Else
                        SQL.AddParam("@stts", 0)
                    End If

                    SQL.ExecQuery("INSERT INTO Users(UserID, UserPass, Name, Email, UserGroup, UserLevel, Status) VALUES(@id, @pass, @name, @email, @group, @lvl, @stts);")
                    If SQL.HasException(True) Then Exit Sub

                    If Not String.IsNullOrEmpty(FrmMain.UserID) Then
                        DATA.GetUserData(FrmMain.UserID)

                        SQL.AddParam("@name", DATA.UName)
                        SQL.AddParam("@uid", DATA.UID)
                        SQL.AddParam("@log", $"USER DATA FOR {txtEmployeeID.Text} ADDED")
                        SQL.ExecQuery("INSERT INTO UserLog(RecordTime, UserName, UserID, LogDesc) VALUES(GETDATE(), @name, @uid, @log);")
                        If SQL.HasException(True) Then Exit Sub
                    End If

                    MessageBox.Show("Employee Data '" + txtEmployeeID.Text + "' has been added.", "Employee Data Added", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    'other function
                    LoadDatatoDGV()
                    Highlight(txtEmployeeID.Text)
                    DisableInput()
                    btnConfirm.Enabled = False
                    btnCreate.Enabled = True
                    btnUpdate.Enabled = True
                    btnDelete.Enabled = True
                Else
                    MessageBox.Show("Employee ID '" + txtEmployeeID.Text + "' already exists in the database.", "Duplicate User ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtEmployeeID.Focus()
                    txtEmployeeID.SelectAll()
                End If
            ElseIf selection = 2 Then 'update
                'update
                SQL.AddParam("@oldid", OldID)
                SQL.AddParam("@id", txtEmployeeID.Text)
                SQL.AddParam("@pass", Encrypt(txtPass1.Text))
                SQL.AddParam("@name", txtName.Text)
                SQL.AddParam("@email", txtEmail.Text)
                SQL.AddParam("@group", cbxGroup.Text)
                If cbxLevel.Text = "System Administrator" Then
                    SQL.AddParam("@lvl", 3)
                ElseIf cbxLevel.Text = "Group Administrator" Then
                    SQL.AddParam("@lvl", 2)
                ElseIf cbxLevel.Text = "Section Operator" Then
                    SQL.AddParam("@lvl", 1)
                End If
                If btnActive.Checked Then
                    SQL.AddParam("@stts", 1)
                Else txtEmployeeID.Focus()
                    SQL.AddParam("@stts", 0)
                End If

                SQL.ExecQuery("UPDATE Users SET UserID = @id, UserPass = @pass, Name = @name, Email = @email, UserGroup = @group, UserLevel = @lvl, Status = @stts WHERE UserID = @oldid;")
                If SQL.HasException(True) Then Exit Sub

                If Not String.IsNullOrEmpty(FrmMain.UserID) Then
                    DATA.GetUserData(FrmMain.UserID)

                    SQL.AddParam("@name", DATA.UName)
                    SQL.AddParam("@uid", DATA.UID)
                    SQL.AddParam("@log", $"USER DATA FOR {txtEmployeeID.Text} EDITED")
                    SQL.ExecQuery("INSERT INTO UserLog(RecordTime, UserName, UserID, LogDesc) VALUES(GETDATE(), @name, @uid, @log);")
                    If SQL.HasException(True) Then Exit Sub
                End If

                MessageBox.Show("Employee Data '" + txtEmployeeID.Text + "' has been updated.", "Employee Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)


                'Other function
                LoadDatatoDGV()
                Highlight(txtEmployeeID.Text)
                DisableInput()
                btnConfirm.Enabled = False
                btnCreate.Enabled = True
                btnUpdate.Enabled = True
                btnDelete.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        oldID = txtEmployeeID.Text.Trim
        selection = 2
        oldName = txtName.Text.Trim
        oldEmail = txtEmail.Text.Trim
        oldPass = GetUserPassword(txtEmployeeID.Text)
        oldGroup = cbxGroup.Text.Trim
        oldLevel = cbxLevel.Text.Trim
        oldStatus = If(btnActive.Checked = True, True, False)
        If dgvUser.SelectedRows.Count = 0 Then
            MessageBox.Show("A selection is required.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dgvUser.Focus()
            Exit Sub
        End If
        EnableInput()
        dgvUser.Enabled = False
        txtEmployeeID.Focus()
        btnUpdate.Enabled = False
        btnCreate.Enabled = False
        btnDelete.Enabled = False
        btnConfirm.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvUser.SelectedRows.Count = 0 Then
            MessageBox.Show("A selection is required.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dgvUser.Focus()
        Else
            If MessageBox.Show("Confirm to delete below employee account?" & vbCrLf & vbCrLf & "Employee ID: " & dgvUser.SelectedRows(0).Cells("Employee ID").Value & vbCrLf & "Name: " & dgvUser.SelectedRows(0).Cells("Employee Name").Value & vbCrLf & "User Group: " & dgvUser.SelectedRows(0).Cells("User Group").Value & vbCrLf & "User Level: " & dgvUser.SelectedRows(0).Cells("User Level").Value, "Delete User Login Account", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                SQL.AddParam("@id", txtEmployeeID.Text)
                SQL.ExecQuery("DELETE FROM Users WHERE UserID = @id")
                If SQL.HasException(True) Then Exit Sub

                If Not String.IsNullOrEmpty(FrmMain.UserID) Then
                    DATA.GetUserData(FrmMain.UserID)

                    SQL.AddParam("@name", DATA.UName)
                    SQL.AddParam("@uid", DATA.UID)
                    SQL.AddParam("@log", $"USER DATA FOR {txtEmployeeID.Text} DELETED")
                    SQL.ExecQuery("INSERT INTO UserLog(RecordTime, UserName, UserID, LogDesc) VALUES(GETDATE(), @name, @uid, @log);")
                    If SQL.HasException(True) Then Exit Sub
                End If

                LoadDatatoDGV()
                DisableInput()
                dgvUser_CellClick(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        selection = 0
        oldID = ""
        oldName = ""
        oldEmail = ""
        oldPass = ""
        oldGroup = ""
        oldLevel = ""
        oldStatus = False

        btnCreate.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        If dgvUser.Rows.Count > 0 Then
            dgvUser_CellClick(dgvUser, New DataGridViewCellEventArgs(0, 0))
        End If

        DisableInput()
        dgvUser.Enabled = True
        btnConfirm.Enabled = False
    End Sub

    Private Sub FrmUserManage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If mode = 1 Then
            FrmMain.Show()
        ElseIf mode = 2 Then
            FrmPM.Show()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FrmSearchUser.txtCGID.Focus()
        FrmSearchUser.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadDatatoDGV()
    End Sub

    Private Sub dgvUser_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvUser.KeyDown
        If e.KeyCode = Keys.F AndAlso e.Control Then
            ' Ctrl+F is pressed
            btnSearch.PerformClick()
            e.Handled = True ' Set handled to True to prevent further processing of the key press event
        End If

        If e.KeyCode = Keys.R AndAlso e.Control Then
            ' Ctrl+F is pressed
            btnRefresh.PerformClick()
            e.Handled = True ' Set handled to True to prevent further processing of the key press event
        End If
    End Sub
End Class