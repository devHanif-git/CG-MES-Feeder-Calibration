Public Class FrmPMCheckAllA
    Public SQL As New SQLControl

    Public Sub New()
        InitializeComponent()
        SetupDGV()
    End Sub

    Private Sub FrmPMCheckAllA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)

        LoadDatatoDGV()
        Me.Show()

        dgvMachine.Focus()
    End Sub

    Private Sub SetupDGV()
        With dgvMachine
            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False
            .ColumnCount = 5
            .AllowUserToResizeRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Dim columns As String() = {"No.", "Machine ID", "Last Calibrated Date", "Latest Calibrated Date", "Updater"}
            Dim widths As Integer() = {40, 108, 170, 185, 79}

            For i As Integer = 0 To columns.Length - 1
                .Columns(i).Name = columns(i)
            Next

            For i As Integer = 0 To widths.Length - 1
                .Columns(i).Width = widths(i)
            Next
        End With
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        ctrlClose.PerformClick()
    End Sub

    Private Sub dgvMachine_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs) Handles dgvMachine.SortCompare
        If e.Column.Name = "Last Calibrated Date" OrElse e.Column.Name = "Latest Calibrated Date" Then
            Dim dateValue1 As Object = e.CellValue1
            Dim dateValue2 As Object = e.CellValue2

            If dateValue1 IsNot DBNull.Value AndAlso dateValue2 IsNot DBNull.Value Then
                If Date.TryParse(dateValue1.ToString(), Nothing) AndAlso Date.TryParse(dateValue2.ToString(), Nothing) Then
                    Dim date1 As DateTime = CDate(dateValue1)
                    Dim date2 As DateTime = CDate(dateValue2)
                    e.SortResult = DateTime.Compare(date1, date2)
                Else
                    ' If conversion to dates fails, compare as strings
                    e.SortResult = String.Compare(e.CellValue1.ToString(), e.CellValue2.ToString())
                End If
            Else
                ' Handle null or DBNull values by comparing as strings
                e.SortResult = String.Compare(e.CellValue1.ToString(), e.CellValue2.ToString())
            End If

            e.Handled = True ' Indicate handled the sorting
        End If
    End Sub

    Private Sub LoadDatatoDGV()
        dgvMachine.Rows.Clear()
        Dim currentDate As Date = Date.Now
        Dim calibrationDate As Date
        Dim lastCalibrationDate As Date

        SQL.ExecQuery("SELECT MachineManagement.MStatus, MachineCalHistory.* 
                       FROM MachineCalHistory JOIN MachineManagement ON 
                       MachineCalHistory.MachineID = MachineManagement.MachineID 
                       ORDER BY MachineCalHistory.MachineID")
        If SQL.HasException(True) Then Exit Sub

        If SQL.RecordCount > 0 Then
            Dim counter As Integer = 0
            For i As Integer = 1 To SQL.DBDT.Rows.Count
                Dim status As Boolean = SQL.DBDT.Rows(i - 1)("MStatus")

                Dim lastCalDateValue = SQL.DBDT.Rows(i - 1)("LastCalDate")
                Dim latestCalDateValue = SQL.DBDT.Rows(i - 1)("LatestCalDate")

                lastCalibrationDate = If(lastCalDateValue IsNot DBNull.Value, CDate(lastCalDateValue), Nothing)
                calibrationDate = If(latestCalDateValue IsNot DBNull.Value, CDate(latestCalDateValue), Nothing)

                'Check for YELLOW/RED
                Dim lastCalibrationNeededDate As Date = lastCalibrationDate.AddMonths(1)
                Dim lastCalibrationWarningDate As Date = lastCalibrationNeededDate.AddDays(-7)
                'Check for YELLOW/RED
                Dim calibrationNeededDate As Date = calibrationDate.AddMonths(1)
                Dim calibrationWarningDate As Date = calibrationNeededDate.AddDays(-7)

                counter += 1
                If calibrationDate = Nothing AndAlso lastCalibrationDate = Nothing Then
                    'BOTH OF THIS N/A OR NO CALIBRATED HISTORY
                    dgvMachine.Rows.Add(New Object() {counter.ToString() + ".", SQL.DBDT.Rows(i - 1)("MachineID"), "N/A", "N/A",
                                       SQL.DBDT.Rows(i - 1)("Updater")})
                    With dgvMachine.Rows(dgvMachine.Rows.Count - 1)
                        .Cells(2).Style.BackColor = Color.Red
                        .Cells(3).Style.BackColor = Color.Red
                    End With
                ElseIf lastCalibrationDate <> Nothing AndAlso calibrationDate = Nothing Then
                    'HAVE LAST CALIBRATED, LATEST N/A
                    dgvMachine.Rows.Add(New Object() {counter.ToString() + ".", SQL.DBDT.Rows(i - 1)("MachineID"),
                                               SQL.DBDT.Rows(i - 1)("LastCalDate"), "N/A", SQL.DBDT.Rows(i - 1)("Updater")})
                    With dgvMachine.Rows(dgvMachine.Rows.Count - 1)
                        If currentDate > lastCalibrationNeededDate Then
                            .Cells(2).Style.BackColor = Color.Red
                            .Cells(3).Style.BackColor = Color.Red
                        ElseIf currentDate >= lastCalibrationWarningDate Then
                            .Cells(2).Style.BackColor = Color.Yellow
                            .Cells(3).Style.BackColor = Color.Yellow
                        End If
                    End With
                ElseIf lastCalibrationDate = Nothing AndAlso calibrationDate <> Nothing Then
                    'LATEST HAVE, LAST N/A
                    dgvMachine.Rows.Add(New Object() {counter.ToString() + ".", SQL.DBDT.Rows(i - 1)("MachineID"),
                                              "N/A", SQL.DBDT.Rows(i - 1)("LatestCalDate"), SQL.DBDT.Rows(i - 1)("Updater")})
                    With dgvMachine.Rows(dgvMachine.Rows.Count - 1)
                        If currentDate > calibrationNeededDate Then
                            .Cells(3).Style.BackColor = Color.Red
                        ElseIf currentDate >= calibrationWarningDate Then
                            .Cells(3).Style.BackColor = Color.Yellow
                        End If
                    End With
                Else
                    'BOTH OF THIS HAS HISTORY
                    dgvMachine.Rows.Add(New Object() {counter.ToString() + ".", SQL.DBDT.Rows(i - 1)("MachineID"),
                                              SQL.DBDT.Rows(i - 1)("LastCalDate"), SQL.DBDT.Rows(i - 1)("LatestCalDate")})
                    With dgvMachine.Rows(dgvMachine.Rows.Count - 1)
                        If currentDate > calibrationNeededDate Then
                            .Cells(3).Style.BackColor = Color.Red
                        ElseIf currentDate >= calibrationWarningDate Then
                            .Cells(3).Style.BackColor = Color.Yellow
                        End If
                    End With
                End If

                If Not status Then
                    dgvMachine.Rows(dgvMachine.Rows.Count - 1).Cells(1).Style.BackColor = Color.Red
                End If
            Next
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FrmSeachPM.selection = 1
        FrmSeachPM.txtMachineID.Focus()
        FrmSeachPM.ShowDialog()
    End Sub

    Private Sub dgvMachine_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvMachine.KeyDown
        If e.KeyCode = Keys.F AndAlso e.Control Then
            ' Ctrl+F is pressed
            btnSearch.PerformClick()
            e.Handled = True ' Set handled to True to prevent further processing of the key press event
        End If
    End Sub

    Private Sub BtnCheckAll_Click(sender As Object, e As EventArgs) Handles BtnCheckAll.Click
        FrmPMCheckAll.ShowDialog()
    End Sub
End Class