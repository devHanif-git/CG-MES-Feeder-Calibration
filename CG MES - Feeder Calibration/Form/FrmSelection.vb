Public Class FrmSelection
    Public SQL As New SQLControl
    Public DATA As New SQLUserLog

    Public Sub New()
        InitializeComponent()
        ResizAndCenter()
    End Sub
    Private Sub FrmSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)

        BtnFeeder.Focus()
        Me.Show()
    End Sub

    Private Sub ResizAndCenter()
        BtnFeeder.Left = (BtnFeeder.Parent.Width \ 2) - (BtnFeeder.Width \ 2)
        BtnPM.Left = (BtnPM.Parent.Width \ 2) - (BtnPM.Width \ 2)
    End Sub

    Private Sub BtnFeeder_Click(sender As Object, e As EventArgs) Handles BtnFeeder.Click
        FrmMain.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPM_Click(sender As Object, e As EventArgs) Handles BtnPM.Click
        FrmPM.Show()
        Me.Hide()
    End Sub

    Private Sub FrmSelection_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not String.IsNullOrEmpty(FrmMain.UserID) Then
            DATA.GetUserData(FrmMain.UserID)

            SQL.AddParam("@name", DATA.UName)
            SQL.AddParam("@uid", DATA.UID)
            SQL.AddParam("@log", "USER LOGGED OUT OF THE SYSTEM")
            SQL.ExecQuery("INSERT INTO UserLog(RecordTime, UserName, UserID, LogDesc) VALUES(GETDATE(), @name, @uid, @log);")
            If SQL.HasException(True) Then Exit Sub
        End If
    End Sub

    Private Sub FrmSelection_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmLogin.Show()
        FrmLogin.txtID.Focus()
    End Sub
End Class