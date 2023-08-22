Public Class FrmPM
    Public SQL As New SQLControl
    Public DATA As New SQLUserLog

    Public UserID As String = FrmMain.UserID
    Public UserLevel As Integer = FrmMain.UserLevel
    Public UserGroup As String = FrmMain.UserGroup

    Public Sub New()
        InitializeComponent()
        ResizAndCenter()
    End Sub
    Private Sub FrmPM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        LblVer.Text = String.Format("Ver: {0}", Application.ProductVersion)

        If (UserGroup = "System Admin" Or UserGroup = "SMT" Or UserGroup = "Backend") AndAlso (UserLevel = 3 Or UserLevel = 2) Then
            BtnCheck.Enabled = True
            BtnCalibrate.Enabled = True
            BtnMLog.Enabled = True
            BtnULog.Enabled = True
            BtnManage.Enabled = True
            BtnUserManage.Enabled = True
        ElseIf UserGroup = "Backend PM" AndAlso UserLevel = 2 Then
            BtnCheck.Enabled = True
            BtnCalibrate.Enabled = True
            BtnMLog.Enabled = True
            BtnULog.Enabled = True
            BtnManage.Enabled = True
            BtnUserManage.Enabled = True
        ElseIf (UserGroup = "SMT" Or UserGroup = "Backend" Or UserGroup = "Backend PM") AndAlso UserLevel = 1 Then
            BtnCheck.Enabled = True
            BtnCalibrate.Enabled = True
            BtnMLog.Enabled = False
            BtnULog.Enabled = False
            BtnManage.Enabled = False
            BtnUserManage.Enabled = False
        Else
            BtnCheck.Enabled = False
            BtnCalibrate.Enabled = False
            BtnMLog.Enabled = False
            BtnULog.Enabled = False
            BtnManage.Enabled = False
            BtnUserManage.Enabled = False
        End If

        Me.Show()
    End Sub

    Private Sub FrmPM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not String.IsNullOrEmpty(FrmMain.UserID) Then
            DATA.GetUserData(FrmMain.UserID)

            SQL.AddParam("@name", DATA.UName)
            SQL.AddParam("@uid", DATA.UID)
            SQL.AddParam("@log", "USER LOGGED OUT OF THE SYSTEM")
            SQL.ExecQuery("INSERT INTO UserLog(RecordTime, UserName, UserID, LogDesc) VALUES(GETDATE(), @name, @uid, @log);")
            If SQL.HasException(True) Then Exit Sub
        End If
    End Sub

    Private Sub ResizAndCenter()
        Dim totalWidth As Integer = BtnMLog.Width + BtnULog.Width
        Dim spaceBetween As Integer = 2

        LblVer.Left = (LblVer.Parent.Width \ 2) - (LblVer.Width \ 2)
        LblVer.Top = (LblVer.Parent.Height \ 2) - (LblVer.Height \ 2) + 410

        ImgHero.Left = (ImgHero.Parent.Width \ 2) - (ImgHero.Width \ 2)

        BtnCheck.Left = (BtnCheck.Parent.Width \ 2) - (BtnCheck.Width \ 2)

        BtnCalibrate.Left = (BtnCalibrate.Parent.Width \ 2) - (BtnCalibrate.Width \ 2)
        '
        BtnMLog.Left = (BtnMLog.Parent.Width - totalWidth - spaceBetween) \ 2
        BtnULog.Left = BtnMLog.Left + BtnMLog.Width + spaceBetween
        '
        BtnManage.Left = (BtnManage.Parent.Width \ 2) - (BtnManage.Width \ 2)
        BtnUserManage.Left = (BtnUserManage.Parent.Width \ 2) - (BtnUserManage.Width \ 2)
        '
        BtnExit.Left = (BtnExit.Parent.Width \ 2) - (BtnExit.Width \ 2)
    End Sub

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        Me.Hide()
        FrmPMChecker.Show()
    End Sub

    Private Sub BtnCalibrate_Click(sender As Object, e As EventArgs) Handles BtnCalibrate.Click
        Me.Hide()
        FrmPMCal.Show()
    End Sub

    Private Sub FrmPM_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmLogin.txtID.Focus()
        FrmLogin.Show()
    End Sub

    Private Sub BtnULog_Click(sender As Object, e As EventArgs) Handles BtnULog.Click
        FrmUserLog.mode = 2
        Me.Hide()
        FrmUserLog.Show()
    End Sub

    Private Sub BtnMLog_Click(sender As Object, e As EventArgs) Handles BtnMLog.Click
        Me.Hide()
        FrmMachineLog.Show()
    End Sub

    Private Sub BtnManage_Click(sender As Object, e As EventArgs) Handles BtnManage.Click
        Me.Hide()
        FrmMMange.Show()
    End Sub

    Private Sub BtnUserManage_Click(sender As Object, e As EventArgs) Handles BtnUserManage.Click
        Me.Hide()
        FrmUserManage.mode = 2
        FrmUserManage.Show()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        ctrlClose.PerformClick()
    End Sub
End Class