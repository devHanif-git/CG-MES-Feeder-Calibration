Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmCalChecker.Show()
        FrmFeederCal.Show()
        FrmManagement.Show()

        ResizAndCenter()

        LblVer.Text = String.Format("Ver: {0}", Application.ProductVersion)

        FrmCalChecker.Hide()
        FrmFeederCal.Hide()
        FrmManagement.Hide()

        Me.Show()
    End Sub

    Private Sub ResizAndCenter()

        LblVer.Left = (LblVer.Parent.Width \ 2) - (LblVer.Width \ 2)
        LblVer.Top = (LblVer.Parent.Height \ 2) - (LblVer.Height \ 2) + 410

        ImgHero.Left = (ImgHero.Parent.Width \ 2) - (ImgHero.Width \ 2)
        'ImgHero.Top = (ImgHero.Parent.Height \ 2) - (ImgHero.Height \ 2) + 10

        BtnCheck.Left = (BtnCheck.Parent.Width \ 2) - (BtnCheck.Width \ 2)

        BtnCalibrate.Left = (BtnCalibrate.Parent.Width \ 2) - (BtnCalibrate.Width \ 2)

        BtnManage.Left = (BtnManage.Parent.Width \ 2) - (BtnManage.Width \ 2)

        BtnExit.Left = (BtnExit.Parent.Width \ 2) - (BtnExit.Width \ 2)
    End Sub

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        Me.Hide()
        FrmCalChecker.Show()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

    Private Sub BtnCalibrate_Click(sender As Object, e As EventArgs) Handles BtnCalibrate.Click
        Me.Hide()
        FrmFeederCal.Show()
    End Sub

    Private Sub BtnManage_Click(sender As Object, e As EventArgs) Handles BtnManage.Click
        Me.Hide()
        FrmManagement.Show()
    End Sub
End Class
