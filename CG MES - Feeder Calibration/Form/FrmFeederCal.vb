Public Class FrmFeederCal
    Public SQL As New SQLControl
    Dim LastCalDate As Date
    Dim LastCalDateS As String
    Private Sub FrmFeederCal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblVer.Text = String.Format("Ver: {0}", Application.ProductVersion)

        ResizeAndCenter()

        Me.Show()
        txtFeederID.Focus()
    End Sub

    Private Sub FrmFeederCal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Show()
    End Sub

    Private Sub ResizeAndCenter()
        LblVer.Left = (LblVer.Parent.Width \ 2) - (LblVer.Width \ 2)
        LblVer.Top = (LblVer.Parent.Height \ 2) - (LblVer.Height \ 2) + 410

        ImgHero.Left = (ImgHero.Parent.Width \ 2) - (ImgHero.Width \ 2)
        'ImgHero.Top = (ImgHero.Parent.Height \ 2) - (ImgHero.Height \ 2) + 10

        pnlAtas.Left = (pnlAtas.Parent.Width \ 2) - (pnlAtas.Width \ 2)
        pnlSection.Left = (pnlSection.Parent.Width \ 2) - (pnlSection.Width \ 2)
        pnlDetails.Left = (pnlDetails.Parent.Width \ 2) - (pnlDetails.Width \ 2)
        pnlCal.Left = (pnlCal.Parent.Width \ 2) - (pnlCal.Width \ 2)
        btnBack.Left = (btnBack.Parent.Width \ 2) - (btnBack.Width \ 2)
        pnlAll.Left = (pnlAll.Parent.Width \ 2) - (pnlAll.Width \ 2)

        CenterLabel()
    End Sub

    Private Sub CenterLabel()
        lblDetails.Left = (lblDetails.Parent.Width \ 2) - (lblDetails.Width \ 2)
        lblCal.Left = (lblCal.Parent.Width \ 2) - (lblCal.Width \ 2)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FrmMain.Show()
    End Sub

    Private Sub PerfomeCheck()
        txtFeederID.Enabled = False
        Dim currentDate As Date = Date.Now
        Dim calibrationDate As Date
        Dim calibrationDateS As String

        'SQL.AddParam("@FID", txtFeederID.Text.Trim)
        'SQL.ExecQuery("SELECT TOP 1 FeederType, FGearSize,FColorCode, FStatus, LastCalDate, LatestCalDate FROM FeederManagement INNER JOIN FeederCalHistory ON FeederManagement.FeederNumber = FeederCalHistory.FeederNumber WHERE FeederManagement.FeederNumber = @FID ORDER BY LatestCalDate DESC")
        SQL.AddParam("@FID", txtFeederID.Text.Trim)
        SQL.ExecQuery("SELECT TOP 1
                  FeederManagement.FeederType,
                  FeederManagement.FGearSize,
                  FeederManagement.FColorCode,
                  FeederManagement.FStatus,
                  FeederCalHistory.LastCalDate,
                  FeederCalHistory.LatestCalDate
              FROM
                  FeederManagement
              LEFT JOIN
                  FeederCalHistory ON FeederManagement.FeederNumber = FeederCalHistory.FeederNumber
              WHERE
                  FeederManagement.FeederNumber = @FID
              ORDER BY
                  FeederCalHistory.LatestCalDate DESC")
        If SQL.HasException(True) Then Exit Sub

        If SQL.RecordCount > 0 Then
            Dim status As Boolean = SQL.DBDT.Rows(0)("FStatus")

            If status Then
                pnlSection.Enabled = True
                btnCancel.Enabled = True

                If SQL.DBDT.Rows(0)("LatestCalDate") Is DBNull.Value Then
                    If SQL.DBDT.Rows(0)("LastCalDate") Is DBNull.Value Then
                        calibrationDateS = "N/A"
                        LastCalDateS = calibrationDateS
                    Else
                        calibrationDate = Convert.ToDateTime(SQL.DBDT.Rows(0)("LastCalDate"))
                        LastCalDate = calibrationDate
                    End If
                Else
                    calibrationDate = Convert.ToDateTime(SQL.DBDT.Rows(0)("LatestCalDate"))
                    LastCalDate = calibrationDate
                End If

                Dim colorCode As String = SQL.DBDT.Rows(0)("FColorCode").ToString()
                Dim colorFeeder As Color = ColorTranslator.FromHtml(colorCode)

                lblDetails.Text = String.Format("Feeder Details: {0}", txtFeederID.Text.Trim)
                lblCal.Text = String.Format("Feeder Calibration: {0}", txtFeederID.Text.Trim)

                lblFType.Text = String.Format("Feeder Type: {0}", SQL.DBDT.Rows(0)("FeederType"))
                lblLCalDate.Text = String.Format("Last Calibration Date: {0}", If(calibrationDate = Date.MinValue, LastCalDateS, calibrationDate.ToString("d")))
                lblGearSize.Text = String.Format("Gear Size: {0}", SQL.DBDT.Rows(0)("FGearSize"))
                lblColor.Text = String.Format("Colour Code: {0}", colorCode)

                lblColor.BackColor = colorFeeder

                If calibrationDate.AddMonths(3) >= currentDate Then
                    lblLCalDate.BackColor = Color.FromArgb(21, 131, 81)
                ElseIf calibrationDate = Date.MinValue Then
                    lblLCalDate.BackColor = Color.FromArgb(186, 25, 27)
                Else
                    lblLCalDate.BackColor = Color.FromArgb(186, 25, 27)
                End If

                CenterLabel()
                txtEmployeeID.Focus()
            Else
                MessageBox.Show("This Feeder is inoperable; please take note!" & vbCrLf & "This Feeder status is NO GOOD!", "NG Feeder", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtFeederID.Enabled = True
                txtFeederID.Focus()
                txtFeederID.SelectAll()
            End If
        Else
            MessageBox.Show("This Feeder doesn't have a data or is an invalid Feeder ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFeederID.Enabled = True
            txtFeederID.Focus()
            txtFeederID.SelectAll()
        End If
    End Sub

    Private Sub Clear()
        lblDetails.Text = "Feeder Details:"
        lblCal.Text = "Feeder Calibration:"
        lblFType.Text = "Feeder Type:"
        lblLCalDate.Text = "Last Calibration Date:"
        lblGearSize.Text = "Gear Size:"
        lblColor.Text = "Colour Code:"

        CenterLabel()
    End Sub

    Private Sub txtFeederID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFeederID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Try
                If txtFeederID.Text.Trim = "" Then
                    pnlSection.Enabled = False
                    btnCancel.Enabled = False
                    lblColor.BackColor = Color.Transparent
                    lblLCalDate.BackColor = Color.Transparent
                    Clear()
                    Exit Sub
                End If

                PerfomeCheck()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        pnlSection.Enabled = False
        btnCancel.Enabled = False
        lblColor.BackColor = Color.Transparent
        lblLCalDate.BackColor = Color.Transparent
        Clear()
        txtFeederID.Enabled = True
        txtFeederID.Focus()
        txtFeederID.SelectAll()
    End Sub

    Private Sub txtEmployeeID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmployeeID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Try
                btnConfirm.PerformClick()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'checking for employee ID?
        If txtEmployeeID.Text.Length < 6 Then
            MessageBox.Show("Incorrect Empolyee ID. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmployeeID.Focus()
            txtEmployeeID.SelectAll()
            Exit Sub
        End If

        Dim newCalibrationDate As DateTime = btnDate1.Value
        Dim currentDate As Date = LastCalDate
        Dim employeeID As String = txtEmployeeID.Text.Trim()

        If newCalibrationDate.ToString("d") = currentDate.ToString("d") Then
            MessageBox.Show("This Feeder already calibrates on" & vbCrLf & "the same date as the new calibration date.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Press Confirm button to set the new calibration date
        SQL.AddParam("@FeederID", txtFeederID.Text.Trim)
        SQL.AddParam("@LastCalibrationDate", If(LastCalDate = Date.MinValue, DBNull.Value, LastCalDate))
        SQL.AddParam("@CalibrationDate", newCalibrationDate)
        SQL.AddParam("@EmployeeID", employeeID)
        SQL.ExecQuery("INSERT INTO FeederCalHistory (FeederNumber, LastCalDate, LatestCalDate, Updater) VALUES (@FeederID, @LastCalibrationDate, @CalibrationDate, @EmployeeID)")
        If SQL.HasException(True) Then Exit Sub

        pnlSection.Enabled = False
        btnCancel.Enabled = False
        lblColor.BackColor = Color.Transparent
        lblLCalDate.BackColor = Color.Transparent
        Clear()
        txtFeederID.Enabled = True
        txtFeederID.Clear()
        txtFeederID.Focus()
    End Sub
End Class