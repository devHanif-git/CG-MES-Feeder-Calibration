Public Class FrmCalChecker
    Public SQL As New SQLControl
    Private Sub FrmCalChecker_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Show()
    End Sub

    Private Sub ResizeAndCenter()
        LblVer.Left = (LblVer.Parent.Width \ 2) - (LblVer.Width \ 2)
        LblVer.Top = (LblVer.Parent.Height \ 2) - (LblVer.Height \ 2) + 410

        ImgHero.Left = (ImgHero.Parent.Width \ 2) - (ImgHero.Width \ 2)
        'ImgHero.Top = (ImgHero.Parent.Height \ 2) - (ImgHero.Height \ 2) + 10

        txtFeederID.Left = (txtFeederID.Parent.Width \ 2) - (txtFeederID.Width \ 2)
        btnCheck.Left = (btnCheck.Parent.Width \ 2) - (btnCheck.Width \ 2)
        btnBack.Left = (btnBack.Parent.Width \ 2) - (btnBack.Width \ 2)
    End Sub

    Private Sub FrmCalChecker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblVer.Text = String.Format("Ver: {0}", Application.ProductVersion)

        ResizeAndCenter()

        Me.Show()
        txtFeederID.Focus()
    End Sub

    Private Sub PerfomeCheck()
        Dim currentDate As Date = Date.Now
        Dim calibrationDate As Date

        SQL.AddParam("@FID", txtFeederID.Text.Trim)
        SQL.ExecQuery("SELECT TOP 1 FeederType, FGearSize,FColorCode, FStatus, LastCalDate, LatestCalDate FROM FeederManagement INNER JOIN FeederCalHistory ON FeederManagement.FeederNumber = FeederCalHistory.FeederNumber WHERE FeederManagement.FeederNumber = @FID ORDER BY LatestCalDate DESC")
        If SQL.HasException(True) Then Exit Sub

        If SQL.RecordCount > 0 Then
            Dim status As Boolean = SQL.DBDT.Rows(0)("FStatus")

            If status Then
                If SQL.DBDT.Rows(0)("LatestCalDate") Is DBNull.Value Then
                    calibrationDate = Convert.ToDateTime(SQL.DBDT.Rows(0)("LastCalDate"))
                Else
                    calibrationDate = Convert.ToDateTime(SQL.DBDT.Rows(0)("LatestCalDate"))
                End If

                If calibrationDate.AddMonths(3) >= currentDate Then
                    btnCheck.FillColor = Color.FromArgb(21, 131, 81)
                    btnCheck.CustomImages.Image = My.Resources.checked
                    btnCheck.CustomImages.ImageOffset = New Point(0, -35)

                    btnCheck.TextOffset = New Point(0, 28)
                    btnCheck.Text = String.Format("This Feeder has been calibrated at {0}: GOOD", calibrationDate.ToString("d"))
                Else
                    btnCheck.FillColor = Color.FromArgb(186, 25, 27)
                    btnCheck.CustomImages.Image = My.Resources.cancel
                    btnCheck.CustomImages.ImageOffset = New Point(0, -60)

                    btnCheck.TextOffset = New Point(0, 28)
                    btnCheck.Text = String.Format("This Feeder needs to be calibrated. Last calibrated on {0}. Please calibrate before use: NO GOOD", calibrationDate.ToString("d"))
                End If
            Else
                btnCheck.FillColor = Color.FromArgb(186, 25, 27)
                btnCheck.CustomImages.Image = My.Resources.cancel
                btnCheck.CustomImages.ImageOffset = New Point(0, -48)

                btnCheck.TextOffset = New Point(0, 30)
                btnCheck.Text = "This Feeder is inoperable; please take note! This Feeder status is NO GOOD!"
            End If
        Else
            btnCheck.FillColor = Color.FromArgb(186, 25, 27)
            btnCheck.CustomImages.Image = My.Resources.cancel
            btnCheck.CustomImages.ImageOffset = New Point(0, -48)

            btnCheck.TextOffset = New Point(0, 30)
            btnCheck.Text = "This Feeder doesn't have a history or is an invalid Feeder ID."
        End If
    End Sub

    Private Sub txtFeederID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFeederID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Try
                If txtFeederID.Text.Trim = "" Then
                    btnCheck.FillColor = Color.FromArgb(81, 86, 99)
                    btnCheck.CustomImages.Image = My.Resources.standby__1_
                    btnCheck.CustomImages.ImageOffset = New Point(0, -15)

                    btnCheck.TextOffset = New Point(0, 25)
                    btnCheck.Text = "Waiting for input"
                    Exit Sub
                End If

                PerfomeCheck()
                txtFeederID.SelectAll()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FrmMain.Show()
    End Sub

    Private Sub txtFeederID_Enter(sender As Object, e As EventArgs) Handles txtFeederID.Enter
        txtFeederID.SelectAll()
    End Sub

    Private Sub txtFeederID_Click(sender As Object, e As EventArgs) Handles txtFeederID.Click
        txtFeederID.SelectAll()
    End Sub
End Class