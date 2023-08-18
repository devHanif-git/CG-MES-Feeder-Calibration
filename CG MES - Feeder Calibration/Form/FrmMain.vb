Public Class FrmMain
    Public SQL As New SQLControl
    Public DATA As New SQLUserLog

    Public Shared UserID As String
    Public Shared UserLevel As Integer
    Public Shared UserGroup As String
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        ResizAndCenter()

        LblVer.Text = String.Format("Ver: {0}", Application.ProductVersion)

        If (UserGroup = "System Admin" Or UserGroup = "SMT Feeder" Or UserGroup = "SMT") AndAlso (UserLevel = 3 Or UserLevel = 2) Then
            BtnCheck.Enabled = True
            BtnCalibrate.Enabled = True
            BtnFLog.Enabled = True
            BtnULog.Enabled = True
            BtnManage.Enabled = True
            BtnUserManage.Enabled = True
        ElseIf UserGroup = "SMT Feeder" AndAlso UserLevel = 1 Then
            BtnCheck.Enabled = True
            BtnCalibrate.Enabled = True
            BtnFLog.Enabled = False
            BtnULog.Enabled = False
            BtnManage.Enabled = False
            BtnUserManage.Enabled = False
        Else
            BtnCheck.Enabled = False
            BtnCalibrate.Enabled = False
            BtnFLog.Enabled = False
            BtnULog.Enabled = False
            BtnManage.Enabled = False
            BtnUserManage.Enabled = False
        End If

        Me.Show()
    End Sub

    Private Sub ResizAndCenter()
        Dim totalWidth As Integer = BtnFLog.Width + BtnULog.Width
        Dim spaceBetween As Integer = 2


        LblVer.Left = (LblVer.Parent.Width \ 2) - (LblVer.Width \ 2)
        LblVer.Top = (LblVer.Parent.Height \ 2) - (LblVer.Height \ 2) + 410

        ImgHero.Left = (ImgHero.Parent.Width \ 2) - (ImgHero.Width \ 2)
        'ImgHero.Top = (ImgHero.Parent.Height \ 2) - (ImgHero.Height \ 2) + 10

        BtnCheck.Left = (BtnCheck.Parent.Width \ 2) - (BtnCheck.Width \ 2)

        BtnCalibrate.Left = (BtnCalibrate.Parent.Width \ 2) - (BtnCalibrate.Width \ 2)

        BtnFLog.Left = (BtnFLog.Parent.Width - totalWidth - spaceBetween) \ 2
        BtnULog.Left = BtnFLog.Left + BtnFLog.Width + spaceBetween

        BtnManage.Left = (BtnManage.Parent.Width \ 2) - (BtnManage.Width \ 2)
        BtnUserManage.Left = (BtnUserManage.Parent.Width \ 2) - (BtnUserManage.Width \ 2)

        BtnExit.Left = (BtnExit.Parent.Width \ 2) - (BtnExit.Width \ 2)
    End Sub

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        Me.Hide()
        FrmCalChecker.Show()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        ctrlClose.PerformClick()
    End Sub

    Private Sub BtnCalibrate_Click(sender As Object, e As EventArgs) Handles BtnCalibrate.Click
        Me.Hide()
        FrmFeederCal.Show()
    End Sub

    Private Sub BtnManage_Click(sender As Object, e As EventArgs) Handles BtnManage.Click
        Me.Hide()
        FrmManagement.Show()
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not String.IsNullOrEmpty(UserID) Then
            DATA.GetUserData(UserID)

            SQL.AddParam("@name", DATA.UName)
            SQL.AddParam("@uid", DATA.UID)
            SQL.AddParam("@log", "USER LOGGED OUT OF THE SYSTEM")
            SQL.ExecQuery("INSERT INTO UserLog(RecordTime, UserName, UserID, LogDesc) VALUES(GETDATE(), @name, @uid, @log);")
            If SQL.HasException(True) Then Exit Sub
        End If
    End Sub

    Private Sub BtnUserManage_Click(sender As Object, e As EventArgs) Handles BtnUserManage.Click
        Me.Hide()
        FrmUserManage.mode = 1
        FrmUserManage.Show()
    End Sub

    Private Sub BtnFLog_Click(sender As Object, e As EventArgs) Handles BtnFLog.Click
        Me.Hide()
        FrmFeederLog.Show()
    End Sub

    Private Sub BtnULog_Click(sender As Object, e As EventArgs) Handles BtnULog.Click
        FrmUserLog.mode = 1
        Me.Hide()
        FrmUserLog.Show()
    End Sub

    Private Sub FrmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmLogin.txtID.Focus()
        FrmLogin.Show()
    End Sub
End Class
