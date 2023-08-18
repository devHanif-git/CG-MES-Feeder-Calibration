Public Class FrmPMCheckAll
    Public SQL As New SQLControl

    Public Sub New()
        InitializeComponent()
        SetupDGV()
    End Sub
    Private Sub FrmPMCheckAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)

        LoadDatatoDGV()
        Me.Show()

        dgvMachine.Focus()
    End Sub

    Private Sub SetupDGV()
        With dgvMachine
            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False
            .ColumnCount = 3
            .AllowUserToResizeRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Dim columns As String() = {"No.", "Machine ID", "Calibration Date"}
            Dim widths As Integer() = {40, 100, 270}

            For i As Integer = 0 To columns.Length - 1
                .Columns(i).Name = columns(i)
            Next

            For i As Integer = 0 To widths.Length - 1
                .Columns(i).Width = widths(i)
            Next
        End With
    End Sub

    Private Sub LoadDatatoDGV()
        dgvMachine.Rows.Clear()
        Dim currentDate As Date = Date.Now
        Dim calibrationDate As Date

        SQL.ExecQuery("SELECT MachineManagement.MStatus, MachineCalibration.* 
                       FROM MachineCalibration JOIN MachineManagement ON 
                       MachineCalibration.MachineID = MachineManagement.MachineID 
                       ORDER BY MachineCalibration.MachineID")
        If SQL.HasException(True) Then Exit Sub

        If SQL.RecordCount > 0 Then
            Dim counter As Integer = 0
            For i As Integer = 1 To SQL.DBDT.Rows.Count
                Dim status As Boolean = SQL.DBDT.Rows(i - 1)("MStatus")
                If status Then
                    If SQL.DBDT.Rows(i - 1)("CalibrationDate") Is DBNull.Value Then
                        calibrationDate = Date.MinValue
                    Else
                        calibrationDate = SQL.DBDT.Rows(i - 1)("CalibrationDate")
                    End If

                    Dim calibrationNeededDate As Date = calibrationDate.AddMonths(1)
                    Dim calibrationWarningDate As Date = calibrationNeededDate.AddDays(-7)

                    If Not (currentDate >= calibrationNeededDate Or currentDate >= calibrationWarningDate) Then
                        Continue For 'SKIP for no need calibration
                    End If

                    counter += 1
                    If calibrationDate = Date.MinValue Then 'DBNull
                        dgvMachine.Rows.Add(New Object() {counter.ToString() + ".", SQL.DBDT.Rows(i - 1)("MachineID"), "N/A"})
                        dgvMachine.Rows(dgvMachine.Rows.Count - 1).Cells(2).Style.BackColor = Color.Red
                    ElseIf currentDate > calibrationNeededDate Then
                        dgvMachine.Rows.Add(New Object() {counter.ToString() + ".", SQL.DBDT.Rows(i - 1)("MachineID"), calibrationDate.ToString("d")})
                        dgvMachine.Rows(dgvMachine.Rows.Count - 1).Cells(2).Style.BackColor = Color.Red
                    ElseIf currentDate >= calibrationWarningDate Then
                        dgvMachine.Rows.Add(New Object() {counter.ToString() + ".", SQL.DBDT.Rows(i - 1)("MachineID"), calibrationDate.ToString("d")})
                        dgvMachine.Rows(dgvMachine.Rows.Count - 1).Cells(2).Style.BackColor = Color.Yellow
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        ctrlClose.PerformClick()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FrmSeachPM.selection = 2
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
End Class