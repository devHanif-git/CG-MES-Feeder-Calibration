Public Class FrmPMCal
    Public SQL As New SQLControl
    Public DATA As New SQLUserLog

    Dim LastCalDate As Date
    Dim LastCalDateS As String

    Public Sub New()
        InitializeComponent()
        ResizeAndCenter()
    End Sub
    Private Sub FrmPMCal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        LblVer.Text = String.Format("Ver: {0}", Application.ProductVersion)

        btnDate1.Value = Date.Now
        Me.Show()
        txtMachineID.Focus()
    End Sub

    Private Sub ResizeAndCenter()
        LblVer.Left = (LblVer.Parent.Width \ 2) - (LblVer.Width \ 2)
        LblVer.Top = (LblVer.Parent.Height \ 2) - (LblVer.Height \ 2) + 410

        ImgHero.Left = (ImgHero.Parent.Width \ 2) - (ImgHero.Width \ 2)

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
        lblMName.Left = (lblMName.Parent.Width \ 2) - (lblMName.Width \ 2)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ctrlClose.PerformClick()
    End Sub

    Private Sub PerfomeCheck()
        txtMachineID.Enabled = False
        Dim currentDate As Date = Date.Now
        Dim calibrationDate As Date
        Dim calibrationDateS As String

        SQL.AddParam("@MID", txtMachineID.Text.Trim)
        SQL.ExecQuery("SELECT
                  MachineManagement.MachineName,
                  MachineManagement.MLocation,
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
                pnlSection.Enabled = True
                btnCancel.Enabled = True

                If SQL.DBDT.Rows(0)("CalibrationDate") Is DBNull.Value Then
                    calibrationDateS = "N/A"
                    LastCalDateS = calibrationDateS
                Else
                    calibrationDate = Convert.ToDateTime(SQL.DBDT.Rows(0)("CalibrationDate"))
                    LastCalDate = calibrationDate
                End If

                lblDetails.Text = String.Format("Machine Details: {0}", txtMachineID.Text.Trim)
                lblCal.Text = String.Format("Machine PM Calibration: {0}", txtMachineID.Text.Trim)

                lblMName.Text = String.Format("Machine Name: {0}", SQL.DBDT.Rows(0)("MachineName"))
                lblLCalDate.Text = String.Format("Last PM Calibration Date: {0}", If(calibrationDate = Date.MinValue, LastCalDateS, calibrationDate.ToString("d")))
                lblLocation.Text = String.Format("Location: {0}", SQL.DBDT.Rows(0)("MLocation"))

                Dim calibrationNeededDate As Date = calibrationDate.AddMonths(1)
                Dim calibrationWarningDate As Date = calibrationNeededDate.AddDays(-7)

                If calibrationDate = Date.MinValue Then
                    lblLCalDate.BackColor = Color.FromArgb(186, 25, 27) ' Red
                ElseIf currentDate > calibrationNeededDate Then
                    lblLCalDate.BackColor = Color.FromArgb(186, 25, 27) ' Red
                ElseIf currentDate >= calibrationWarningDate Then
                    lblLCalDate.BackColor = Color.FromArgb(241, 202, 32) ' Yellow
                Else
                    lblLCalDate.BackColor = Color.FromArgb(21, 131, 81) ' Green
                End If

                CenterLabel()
                txtEmployeeID.Focus()
            Else
                MessageBox.Show("This machine is defective; please take note!" & vbCrLf & "This machine is awaiting repair!" &
                                vbCrLf &
                                vbCrLf &
                                vbCrLf & "No Good Message: " + SQL.DBDT.Rows(0)("MsgBox"),
                                "NG Machine", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMachineID.Enabled = True
                txtMachineID.Focus()
                txtMachineID.SelectAll()
            End If
        Else
            MessageBox.Show("This machine doesn't have a data or is an invalid Machine ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMachineID.Enabled = True
            txtMachineID.Focus()
            txtMachineID.SelectAll()
        End If
    End Sub

    Private Sub Clear()
        lblDetails.Text = "Machine Details:"
        lblCal.Text = "Machine PM Calibration:"
        lblMName.Text = "Machine Name:"
        lblLCalDate.Text = "Last PM Calibration Date:"
        lblLocation.Text = "Location:"

        CenterLabel()
    End Sub

    Private Sub txtMachineID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMachineID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Try
                If txtMachineID.Text.Trim = "" Then
                    pnlSection.Enabled = False
                    btnCancel.Enabled = False
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
        lblLCalDate.BackColor = Color.Transparent
        Clear()
        txtMachineID.Enabled = True
        txtMachineID.Focus()
        txtMachineID.SelectAll()
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
        Else
            SQL.AddParam("@UID", txtEmployeeID.Text.Trim)
            SQL.ExecQuery("SELECT * FROM Users WHERE UserID = @UID")
            If SQL.HasException(True) Then Exit Sub

            If SQL.RecordCount > 0 Then
                If Not (SQL.DBDT.Rows(0)("UserGroup") = "SMT" Or SQL.DBDT.Rows(0)("UserGroup") = "System Admin") Then
                    MessageBox.Show("You do not have access to this feature." & vbCrLf & "Please check with your Group Adminisrator for assistance.", "Access Declined", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtEmployeeID.SelectAll()
                    txtEmployeeID.Focus()
                    Exit Sub
                Else
                    Dim newCalibrationDate As DateTime = btnDate1.Value
                    Dim currentDate As Date = LastCalDate
                    Dim employeeID As String = txtEmployeeID.Text.Trim()

                    If newCalibrationDate.ToString("d") = currentDate.ToString("d") Then
                        MessageBox.Show("This machine already calibrates on" & vbCrLf & "the same date as the new calibration date.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    ' Press Confirm button to set the new calibration date
                    SQL.AddParam("@MID", txtMachineID.Text.Trim)
                    SQL.AddParam("@CalibrationDate", newCalibrationDate)
                    SQL.AddParam("@EmployeeID", employeeID)
                    SQL.ExecQuery("UPDATE MachineCalibration SET CalibrationDate = @CalibrationDate, Updater = @EmployeeID WHERE MachineID = @MID;")
                    If SQL.HasException(True) Then Exit Sub

                    SQL.AddParam("@MID", txtMachineID.Text.Trim)
                    SQL.ExecQuery("DELETE FROM MachineCalHistory WHERE MachineID = @MID")
                    If SQL.HasException(True) Then Exit Sub

                    SQL.AddParam("@MID", txtMachineID.Text.Trim)
                    SQL.AddParam("@LastCalibrationDate", If(LastCalDate = Date.MinValue, DBNull.Value, LastCalDate))
                    SQL.AddParam("@CalibrationDate", newCalibrationDate)
                    SQL.AddParam("@EmployeeID", employeeID)
                    SQL.ExecQuery("INSERT INTO MachineCalHistory (MachineID, LastCalDate, LatestCalDate, Updater) VALUES (@MID, @LastCalibrationDate, @CalibrationDate, @EmployeeID)")
                    If SQL.HasException(True) Then Exit Sub

                    SQL.AddParam("@MID", txtMachineID.Text.Trim)
                    SQL.AddParam("@CalibrationDate", newCalibrationDate)
                    SQL.AddParam("@EmployeeID", employeeID)
                    SQL.ExecQuery("INSERT INTO MachineCalLog (RecordTime, MachineID, LatestCalDate, Updater) VALUES (GETDATE(), @MID, @CalibrationDate, @EmployeeID)")
                    If SQL.HasException(True) Then Exit Sub

                    If Not String.IsNullOrEmpty(FrmMain.UserID) Then
                        DATA.GetUserData(employeeID)

                        SQL.AddParam("@name", DATA.UName)
                        SQL.AddParam("@uid", DATA.UID)
                        SQL.AddParam("@log", $"USER CALIBRATED MACHINE {txtMachineID.Text.Trim} AND SET THE DATE TO {newCalibrationDate.ToString("d")}")
                        SQL.AddParam("@MID", txtMachineID.Text.Trim)
                        SQL.ExecQuery("INSERT INTO UserLog(RecordTime, UserName, UserID, MachineID, LogDesc) VALUES(GETDATE(), @name, @uid, @MID, @log);")
                        If SQL.HasException(True) Then Exit Sub
                    End If

                    pnlSection.Enabled = False
                    btnCancel.Enabled = False
                    lblLCalDate.BackColor = Color.Transparent
                    Clear()
                    txtMachineID.Enabled = True
                    txtMachineID.Clear()
                    txtMachineID.Focus()
                End If
            Else
                MessageBox.Show("Incorrect Empolyee ID. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtEmployeeID.Focus()
                txtEmployeeID.SelectAll()
            End If
        End If
    End Sub

    Private Sub FrmPMCal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmPM.Show()
    End Sub

    Private Sub FrmPMCal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtMachineID.Focus()
    End Sub
End Class