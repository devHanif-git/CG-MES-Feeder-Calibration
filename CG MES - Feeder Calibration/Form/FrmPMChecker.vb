Public Class FrmPMChecker
    Public SQL As New SQLControl

    Public Sub New()
        InitializeComponent()
        ResizeAndCenter()
    End Sub

    Private Sub FrmPMChecker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        LblVer.Text = String.Format("Ver: {0}", Application.ProductVersion)

        Me.Show()
        txtMachineID.Focus()
    End Sub

    Private Sub ResizeAndCenter()
        LblVer.Left = (LblVer.Parent.Width \ 2) - (LblVer.Width \ 2)
        LblVer.Top = (LblVer.Parent.Height \ 2) - (LblVer.Height \ 2) + 410

        ImgHero.Left = (ImgHero.Parent.Width \ 2) - (ImgHero.Width \ 2)

        txtMachineID.Left = (txtMachineID.Parent.Width \ 2) - (txtMachineID.Width \ 2)
        btnCheck.Left = (btnCheck.Parent.Width \ 2) - (btnCheck.Width \ 2)
        btnLastCal.Left = (btnLastCal.Parent.Width \ 2) - (btnLastCal.Width \ 2)
        btnBack.Left = (btnBack.Parent.Width \ 2) - (btnBack.Width \ 2)
        btnCheckAll.Left = (btnCheckAll.Parent.Width \ 2) - (btnCheckAll.Width \ 2)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ctrlClose.PerformClick()
    End Sub

    Private Sub txtMachineID_Click(sender As Object, e As EventArgs) Handles txtMachineID.Click
        txtMachineID.SelectAll()
    End Sub

    Private Sub txtMachineID_Enter(sender As Object, e As EventArgs) Handles txtMachineID.Enter
        txtMachineID.SelectAll()
    End Sub

    Private Sub PerfomeCheck()
        Dim currentDate As Date = Date.Now
        Dim calibrationDate As Date

        SQL.AddParam("@MID", txtMachineID.Text.Trim)
        SQL.ExecQuery("SELECT
                  MachineManagement.MStatus,
                  MachineManagement.MsgBox,
                  MachineCalibration.CalibrationDate
              FROM
                  MachineManagement
              LEFT JOIN
                  MachineCalibration ON MachineManagement.MachineID = MachineCalibration.MachineID
              WHERE
                  MachineManagement.MachineID = @MID")
        If SQL.HasException(True) Then Exit Sub

        If SQL.RecordCount > 0 Then
            Dim status As Boolean = SQL.DBDT.Rows(0)("MStatus")

            If status Then
                If SQL.DBDT.Rows(0)("CalibrationDate") Is DBNull.Value Then
                    btnCheck.FillColor = Color.FromArgb(186, 25, 27)
                    btnCheck.CustomImages.Image = My.Resources.cancel
                    btnCheck.CustomImages.ImageOffset = New Point(0, -48)

                    btnCheck.TextOffset = New Point(0, 30)
                    btnCheck.Text = "This machine doesn't have a history or is an invalid Machine ID."

                    btnLastCal.FillColor = Color.FromArgb(186, 25, 27)
                    btnLastCal.Text = "Next Calibration Date: N/A"
                    Return
                Else
                    calibrationDate = Convert.ToDateTime(SQL.DBDT.Rows(0)("CalibrationDate"))
                End If

                Dim calibrationNeededDate As Date = calibrationDate.AddMonths(1)
                Dim calibrationWarningDate As Date = calibrationNeededDate.AddDays(-7)

                If currentDate > calibrationNeededDate Then
                    ' Calibration is overdue or beyond 1 months
                    btnCheck.FillColor = Color.FromArgb(186, 25, 27) ' Red
                    btnCheck.CustomImages.Image = My.Resources.cancel
                    btnCheck.CustomImages.ImageOffset = New Point(0, -60)
                    btnCheck.TextOffset = New Point(0, 28)
                    btnCheck.Text = String.Format("This machine needs to be calibrated. Last calibrated on {0}. Please calibrate before use: NO GOOD", calibrationDate.ToString("d"))

                    btnLastCal.FillColor = Color.FromArgb(186, 25, 27)
                    btnLastCal.Text = String.Format("Next Calibration Date: {0}", calibrationNeededDate.ToString("d"))
                ElseIf currentDate >= calibrationWarningDate Then
                    ' Calibration is near the required date
                    btnCheck.FillColor = Color.FromArgb(241, 202, 32) ' Yellow
                    btnCheck.CustomImages.Image = My.Resources.checked
                    btnCheck.CustomImages.ImageOffset = New Point(0, -60)
                    btnCheck.TextOffset = New Point(0, 28)
                    btnCheck.Text = String.Format("This machine has been calibrated at {0}, but it's near the calibration date. Please calibrate before use.", calibrationDate.ToString("d"))

                    btnLastCal.FillColor = Color.FromArgb(241, 202, 32)
                    btnLastCal.Text = String.Format("Next Calibration Date: {0}", calibrationNeededDate.ToString("d"))
                Else
                    ' Calibration is within the required date
                    btnCheck.FillColor = Color.FromArgb(21, 131, 81) ' Green
                    btnCheck.CustomImages.Image = My.Resources.checked
                    btnCheck.CustomImages.ImageOffset = New Point(0, -35)
                    btnCheck.TextOffset = New Point(0, 28)
                    btnCheck.Text = String.Format("This machine has been calibrated at {0}: GOOD", calibrationDate.ToString("d"))

                    btnLastCal.FillColor = Color.FromArgb(21, 131, 81)
                    btnLastCal.Text = String.Format("Next Calibration Date: {0}", calibrationNeededDate.ToString("d"))
                End If
            Else
                btnCheck.FillColor = Color.FromArgb(186, 25, 27)
                btnCheck.CustomImages.Image = My.Resources.cancel
                btnCheck.CustomImages.ImageOffset = New Point(0, -48)

                btnCheck.TextOffset = New Point(0, 30)
                btnCheck.Text = "This machine is defective; please take note! This machine is awaiting repair!"
                btnLastCal.FillColor = Color.FromArgb(186, 25, 27)
                btnLastCal.Text = "Next Calibration Date: N/A"
                MessageBox.Show(SQL.DBDT.Rows(0)("MsgBox"), "No Good Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            btnCheck.FillColor = Color.FromArgb(186, 25, 27)
            btnCheck.CustomImages.Image = My.Resources.cancel
            btnCheck.CustomImages.ImageOffset = New Point(0, -48)

            btnCheck.TextOffset = New Point(0, 30)
            btnCheck.Text = "This machine doesn't have a history or is an invalid Machine ID."

            btnLastCal.FillColor = Color.FromArgb(186, 25, 27)
            btnLastCal.Text = "Next Calibration Date: N/A"
        End If
    End Sub

    Private Sub txtMachineID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMachineID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Try
                If txtMachineID.Text.Trim = "" Then
                    btnCheck.FillColor = Color.FromArgb(81, 86, 99)
                    btnCheck.CustomImages.Image = My.Resources.standby__1_
                    btnCheck.CustomImages.ImageOffset = New Point(0, -15)

                    btnCheck.TextOffset = New Point(0, 25)
                    btnCheck.Text = "Waiting for input"

                    btnLastCal.FillColor = Color.FromArgb(81, 86, 99)
                    btnLastCal.Text = "Next Calibration Date: N/A"
                    Exit Sub
                End If

                PerfomeCheck()
                txtMachineID.SelectAll()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnCheckAll_Click(sender As Object, e As EventArgs) Handles btnCheckAll.Click
        FrmPMCheckAllA.ShowDialog()
    End Sub

    Private Sub FrmPMChecker_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmPM.Show()
    End Sub
End Class