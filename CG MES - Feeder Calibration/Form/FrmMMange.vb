Public Class FrmMMange
    Public SQL As New SQLControl
    Public DATA As New SQLUserLog

    Dim selection As Integer
    Dim oldID As String
    Dim oldName As String
    Dim oldLocation As String
    Dim oldStts As String
    Public Shared noGoodMsg As String

    Public Sub New()
        InitializeComponent()
        ResizeAndCenter()
        SetupDGV()
    End Sub
    Private Sub FrmMMange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        LblVer.Text = String.Format("Ver: {0}", Application.ProductVersion)

        LoadDatatoDGV()
        LoadModel()

        Me.Show()
        dgvMachine.Focus()
    End Sub

    Private Sub FrmMMange_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmPM.Show()
    End Sub

    Private Sub ResizeAndCenter()
        LblVer.Left = (LblVer.Parent.Width \ 2) - (LblVer.Width \ 2)
        LblVer.Top = (LblVer.Parent.Height \ 2) - (LblVer.Height \ 2) + 410

        ImgHero.Left = (ImgHero.Parent.Width \ 2) - (ImgHero.Width \ 2)
    End Sub

    Private Sub SetupDGV()
        With dgvMachine
            .Left = (.Parent.Width \ 2) - (.Width \ 2)
            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False
            .ColumnCount = 7
            .AllowUserToResizeRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Dim columns As String() = {"No.", "Machine ID", "Machine Name", "Location", "Status", "Update Time", "Updater"}
            Dim widths As Integer() = {40, 100, 185, 85, 90, 100, 82}

            For i As Integer = 0 To columns.Length - 1
                .Columns(i).Name = columns(i)
            Next

            For i As Integer = 0 To widths.Length - 1
                .Columns(i).Width = widths(i)
            Next
        End With
    End Sub

    Private Sub LoadModel()
        'REFRESH COMBOBOX
        cbxLocation.Items.Clear()

        cbxLocation.Items.Add("Select Location")
        cbxLocation.SelectedIndex = 0

        'Query
        SQL.ExecQuery("SELECT * FROM MachineLocation ORDER by ID;")

        If SQL.HasException(True) Then Exit Sub

        'LOOP ROW &  ADD TO COMBOBOX
        For Each r As DataRow In SQL.DBDT.Rows
            cbxLocation.Items.Add(r("Location").ToString)
        Next
    End Sub

    Private Sub ClearInput()
        txtMachineID.Enabled = True
        txtMachineID.Clear()
        txtMachineID.Text = ""
        txtMachineName.Enabled = True
        txtMachineName.Clear()
        txtMachineName.Text = ""
        cbxLocation.SelectedIndex = 0
        cbxStatus.SelectedIndex = 0
        txtMachineID.Enabled = False
        txtMachineName.Enabled = False
    End Sub

    Private Sub LoadDatatoDGV()
        dgvMachine.Rows.Clear()

        SQL.ExecQuery("SELECT * FROM MachineManagement ORDER BY MachineID")
        If SQL.HasException(True) Then Exit Sub

        Dim status As String

        If SQL.RecordCount > 0 Then
            For i As Integer = 1 To SQL.DBDT.Rows.Count
                Dim statusSQL As Boolean = SQL.DBDT.Rows(i - 1)("MStatus")

                If statusSQL Then
                    status = "GOOD"
                Else
                    status = "NO GOOD"
                End If

                dgvMachine.Rows.Add(New Object() {i.ToString + ".", SQL.DBDT.Rows(i - 1)("MachineID"), SQL.DBDT.Rows(i - 1)("MachineName"),
                                          SQL.DBDT.Rows(i - 1)("MLocation"),
                                          status, SQL.DBDT.Rows(i - 1)("UpdateTime"), SQL.DBDT.Rows(i - 1)("Updater")})

                If status = "NO GOOD" Then
                    For j As Integer = 1 To dgvMachine.Columns.Count
                        dgvMachine.Rows(dgvMachine.Rows.Count - 1).Cells(j - 1).Style.BackColor = Color.FromArgb(255, 192, 192)
                    Next
                End If
            Next
        Else
            ClearInput()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ctrlClose.PerformClick()
    End Sub

    Private Function GetSelectedIndex(comboBox As ComboBox, targetValue As String) As Integer
        For i As Integer = 0 To comboBox.Items.Count - 1
            If comboBox.Items(i).ToString() = targetValue Then
                Return i
            End If
        Next

        Return -1
    End Function

    Private Sub dgvMachine_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMachine.CellClick
        txtMachineID.Text = dgvMachine.CurrentRow.Cells(1).Value.ToString()
        txtMachineName.Text = dgvMachine.CurrentRow.Cells(2).Value.ToString()
        cbxLocation.SelectedIndex = GetSelectedIndex(cbxLocation, dgvMachine.CurrentRow.Cells(3).Value.ToString())
        cbxStatus.SelectedIndex = GetSelectedIndex(cbxStatus, dgvMachine.CurrentRow.Cells(4).Value.ToString())
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadDatatoDGV()
    End Sub

    Private Sub EnableInput()
        txtMachineID.Enabled = True
        txtMachineName.Enabled = True
        cbxLocation.Enabled = True
        cbxStatus.Enabled = True
        txtEmployeeID.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Private Sub DisableInput()
        txtMachineID.Enabled = False
        txtMachineName.Enabled = False
        cbxLocation.Enabled = False
        cbxStatus.Enabled = False
        txtEmployeeID.Enabled = False
        btnCancel.Enabled = False
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        selection = 1
        ClearInput()
        dgvMachine.Enabled = False
        EnableInput()
        txtMachineID.Focus()
        btnCreate.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnConfirm.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        selection = 0
        btnCreate.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        If dgvMachine.Rows.Count > 0 Then
            dgvMachine_CellClick(dgvMachine, New DataGridViewCellEventArgs(0, 0))
        End If

        DisableInput()
        dgvMachine.Enabled = True
        btnConfirm.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        selection = 2
        oldName = txtMachineName.Text.Trim
        oldLocation = cbxLocation.Text.Trim
        oldStts = cbxStatus.Text.Trim
        If dgvMachine.SelectedRows.Count = 0 Then
            MessageBox.Show("A selection is required.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dgvMachine.Focus()
            Exit Sub
        End If

        EnableInput()
        txtMachineID.Enabled = False
        dgvMachine.Enabled = False
        txtEmployeeID.Focus()
        btnUpdate.Enabled = False
        btnCreate.Enabled = False
        btnDelete.Enabled = False
        btnConfirm.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvMachine.SelectedRows.Count = 0 Then
            MessageBox.Show("A selection is required.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dgvMachine.Focus()
        Else
            If MessageBox.Show("Confirm to delete below machine details?" & vbCrLf & vbCrLf & "Machine ID: " & dgvMachine.SelectedRows(0).Cells("Machine ID").Value & vbCrLf & "Machine Name: " & dgvMachine.SelectedRows(0).Cells("Machine Name").Value & vbCrLf & "Location: " & dgvMachine.SelectedRows(0).Cells("Location").Value, "Delete Machine Details", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                SQL.AddParam("@id", txtMachineID.Text)
                SQL.ExecQuery("DELETE FROM MachineManagement WHERE MachineID = @id")
                If SQL.HasException(True) Then Exit Sub

                SQL.AddParam("@id", txtMachineID.Text)
                SQL.ExecQuery("DELETE FROM MachineCalibration WHERE MachineID = @id")
                If SQL.HasException(True) Then Exit Sub

                SQL.AddParam("@id", txtMachineID.Text)
                SQL.ExecQuery("DELETE FROM MachineCalHistory WHERE MachineID = @id")
                If SQL.HasException(True) Then Exit Sub

                If Not String.IsNullOrEmpty(FrmMain.UserID) Then
                    DATA.GetUserData(FrmMain.UserID)

                    SQL.AddParam("@name", DATA.UName)
                    SQL.AddParam("@uid", DATA.UID)
                    SQL.AddParam("@MID", txtMachineID.Text.Trim)
                    SQL.AddParam("@log", $"USER DELETED MACHINE DETAIL FOR {txtMachineID.Text.Trim}")
                    SQL.ExecQuery("INSERT INTO UserLog(RecordTime, UserName, UserID, MachineID, LogDesc) VALUES(GETDATE(), @name, @uid, @MID, @log);")
                    If SQL.HasException(True) Then Exit Sub
                End If

                LoadDatatoDGV()
            End If
        End If
    End Sub

    Private Function CheckDupID(FID As String) As Boolean
        Dim result As Boolean = False

        SQL.AddParam("@id", FID)
        SQL.ExecQuery("SELECT * FROM MachineManagement WHERE MachineID = @id")
        If SQL.HasException(True) Then Return False

        If SQL.RecordCount > 0 Then
            result = True
        End If

        Return result
    End Function

    Private Sub Highlight(FID As String)
        For Each row As DataGridViewRow In dgvMachine.Rows
            If row.Cells(1).Value = FID Then
                dgvMachine.ClearSelection()
                row.Selected = True

                txtMachineID.Text = row.Cells(1).Value.ToString()
                txtMachineName.Text = row.Cells(2).Value.ToString()
                cbxLocation.SelectedIndex = GetSelectedIndex(cbxLocation, row.Cells(3).Value.ToString())
                cbxStatus.SelectedIndex = GetSelectedIndex(cbxStatus, row.Cells(4).Value.ToString())

                dgvMachine.FirstDisplayedScrollingRowIndex = row.Index
                Exit For
            End If
        Next
    End Sub

    Private Sub dgvMachine_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMachine.SelectionChanged
        If dgvMachine.Rows.Count > 0 Then
            dgvMachine_CellClick(dgvMachine, New DataGridViewCellEventArgs(0, 0))
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FrmSeachPM.selection = 3
        FrmSeachPM.txtMachineID.Focus()
        FrmSeachPM.ShowDialog()
    End Sub

    Private Sub dgvMachine_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvMachine.KeyDown
        If e.KeyCode = Keys.F AndAlso e.Control Then
            ' Ctrl+F is pressed
            btnSearch.PerformClick()
            e.Handled = True ' Set handled to True to prevent further processing of the key press event
        End If

        If e.KeyCode = Keys.R AndAlso e.Control Then
            ' Ctrl+F is pressed
            btnRefresh.PerformClick()
            e.Handled = True ' Set handled to True to prevent further processing of the key press event
        End If
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
                If Not ((SQL.DBDT.Rows(0)("UserGroup") = "Backend PM" Or SQL.DBDT.Rows(0)("UserGroup") = "SMT" Or SQL.DBDT.Rows(0)("UserGroup") = "System Admin") And (SQL.DBDT.Rows(0)("UserLevel") = 3 Or SQL.DBDT.Rows(0)("UserLevel") = 2)) Then
                    MessageBox.Show("You do not have access to this feature." & vbCrLf & "Please check with your Group Adminisrator for assistance.", "Access Declined", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtEmployeeID.SelectAll()
                    txtEmployeeID.Focus()
                    Exit Sub
                Else
                    If selection = 1 Then
                        If txtMachineID.Text = "" Then
                            MessageBox.Show("The Machine ID information is required.", "Machine ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtMachineID.Focus()
                            txtMachineID.SelectAll()
                        ElseIf txtMachineName.Text = "" Then
                            MessageBox.Show("The Machine Name information is required.", "Machine Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtMachineName.Focus()
                            txtMachineName.SelectAll()
                        ElseIf cbxLocation.SelectedIndex = 0 Then
                            MessageBox.Show("The Machine Location information is required.", "Machine Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            cbxLocation.Focus()
                            cbxLocation.DroppedDown = True
                        ElseIf txtEmployeeID.Text = "" Then
                            MessageBox.Show("Incorrect Empolyee ID. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtEmployeeID.Focus()
                        Else
                            Dim chkdup As Boolean = Not CheckDupID(txtMachineID.Text.Trim)
                            If chkdup Then
                                Dim stts As Boolean = If(cbxStatus.SelectedItem.ToString() = "GOOD", True, False)

                                If Not stts Then
                                    FrmNoGoodMsg.mode = 2
                                    FrmNoGoodMsg.ShowDialog()
                                Else
                                    noGoodMsg = ""
                                End If

                                SQL.AddParam("@id", txtMachineID.Text.Trim)
                                SQL.AddParam("@name", txtMachineName.Text.Trim)
                                SQL.AddParam("@location", cbxLocation.Text.Trim)
                                SQL.AddParam("@status", stts)
                                SQL.AddParam("@uid", txtEmployeeID.Text.Trim)
                                SQL.AddParam("@noGoodMsg", noGoodMsg)

                                SQL.ExecQuery("INSERT INTO MachineManagement (MachineID, MachineName, MLocation, MStatus, UpdateTime, Updater, MsgBox) VALUES(@id, @name, @location, @status, GETDATE(), @uid, @noGoodMsg);")
                                If SQL.HasException(True) Then Exit Sub

                                SQL.AddParam("@id", txtMachineID.Text.Trim)
                                SQL.AddParam("@null", DBNull.Value)
                                SQL.AddParam("@uid", txtEmployeeID.Text.Trim)
                                SQL.ExecQuery("INSERT INTO MachineCalibration (MachineID, CalibrationDate, Updater) VALUES(@id, @null, @uid);")
                                If SQL.HasException(True) Then Exit Sub

                                SQL.AddParam("@id", txtMachineID.Text.Trim)
                                SQL.AddParam("@null", DBNull.Value)
                                SQL.AddParam("@uid", txtEmployeeID.Text.Trim)
                                SQL.ExecQuery("INSERT INTO MachineCalHistory (MachineID, LastCalDate, LatestCalDate, Updater) VALUES(@id, @null, @null, @uid);")
                                If SQL.HasException(True) Then Exit Sub

                                If Not String.IsNullOrEmpty(FrmMain.UserID) Then
                                    DATA.GetUserData(txtEmployeeID.Text.Trim)

                                    SQL.AddParam("@name", DATA.UName)
                                    SQL.AddParam("@uid", DATA.UID)
                                    SQL.AddParam("@MID", txtMachineID.Text.Trim)
                                    SQL.AddParam("@log", $"USER ADDED MACHINE DETAIL FOR {txtMachineID.Text.Trim}")
                                    SQL.ExecQuery("INSERT INTO UserLog(RecordTime, UserName, UserID, MachineID, LogDesc) VALUES(GETDATE(), @name, @uid, @MID, @log);")
                                    If SQL.HasException(True) Then Exit Sub
                                End If

                                MessageBox.Show("Machine ID '" + txtMachineID.Text + "' has been added.", "Machine Added", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                dgvMachine.Enabled = True
                                oldID = txtMachineID.Text.Trim
                                LoadDatatoDGV()

                                DisableInput()
                                btnConfirm.Enabled = False
                                btnCreate.Enabled = True
                                btnUpdate.Enabled = True
                                btnDelete.Enabled = True
                                Highlight(oldID)
                            Else
                                MessageBox.Show("Machine ID '" + txtMachineID.Text + "' already exists in the database.", "Duplicate Machine ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                txtMachineID.Focus()
                                txtMachineID.SelectAll()
                            End If
                        End If
                    ElseIf selection = 2 Then
                        If txtMachineID.Text = "" Then
                            MessageBox.Show("The Machine ID information is required.", "Machine ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtMachineID.Focus()
                            txtMachineID.SelectAll()
                        ElseIf txtMachineName.Text = "" Then
                            MessageBox.Show("The Machine Name information is required.", "Machine Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtMachineName.Focus()
                            txtMachineName.SelectAll()
                        ElseIf cbxLocation.SelectedIndex = 0 Then
                            MessageBox.Show("The Machine Location information is required.", "Machine Location", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            cbxLocation.Focus()
                            cbxLocation.DroppedDown = True
                        ElseIf txtEmployeeID.Text = "" Then
                            MessageBox.Show("Incorrect Empolyee ID. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtEmployeeID.Focus()
                        Else
                            Dim stts As Boolean = If(cbxStatus.SelectedItem.ToString() = "GOOD", True, False)

                            If Not stts Then
                                FrmNoGoodMsg.mode = 2
                                FrmNoGoodMsg.ShowDialog()
                            Else
                                noGoodMsg = ""
                            End If

                            SQL.AddParam("@id", txtMachineID.Text.Trim)
                            SQL.AddParam("@name", txtMachineName.Text.Trim)
                            SQL.AddParam("@location", cbxLocation.Text.Trim)
                            SQL.AddParam("@status", stts)
                            SQL.AddParam("@uid", txtEmployeeID.Text.Trim)
                            SQL.AddParam("@noGoodMsg", noGoodMsg)

                            SQL.ExecQuery("UPDATE MachineManagement SET MachineName = @name, MLocation = @location, MStatus = @status, UpdateTime = GETDATE(), Updater = @uid, MsgBox = @noGoodMsg WHERE MachineID = @id;")
                            If SQL.HasException(True) Then Exit Sub

                            If Not String.IsNullOrEmpty(FrmMain.UserID) Then
                                DATA.GetUserData(txtEmployeeID.Text.Trim)

                                SQL.AddParam("@name", DATA.UName)
                                SQL.AddParam("@uid", DATA.UID)
                                SQL.AddParam("@MID", txtMachineID.Text.Trim)
                                SQL.AddParam("@log", $"USER EDITED MACHINE DETAIL FOR {txtMachineID.Text.Trim}")
                                SQL.ExecQuery("INSERT INTO UserLog(RecordTime, UserName, UserID, MachineID, LogDesc) VALUES(GETDATE(), @name, @uid, @MID, @log);")
                                If SQL.HasException(True) Then Exit Sub
                            End If

                            MessageBox.Show("Machine ID '" + txtMachineID.Text + "' has been updated.", "Machine Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            dgvMachine.Enabled = True
                            oldID = txtMachineID.Text.Trim

                            LoadDatatoDGV()

                            DisableInput()

                            btnConfirm.Enabled = False
                            btnCreate.Enabled = True
                            btnUpdate.Enabled = True
                            btnDelete.Enabled = True
                            Highlight(oldID)
                        End If
                    End If
                End If
            Else
                MessageBox.Show("Incorrect Empolyee ID. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtEmployeeID.Focus()
                txtEmployeeID.SelectAll()
            End If
        End If
    End Sub
End Class