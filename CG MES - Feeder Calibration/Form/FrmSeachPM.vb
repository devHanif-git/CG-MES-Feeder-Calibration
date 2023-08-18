Public Class FrmSeachPM
    Public Shared selection As Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmSeachPM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        txtMachineID.Clear()
        Me.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ctrlClose.PerformClick()
    End Sub

    Private Sub FrmSeachPM_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtMachineID.Focus()
    End Sub

    Private Function GetSelectedIndex(comboBox As ComboBox, targetValue As String) As Integer
        For i As Integer = 0 To comboBox.Items.Count - 1
            If comboBox.Items(i).ToString() = targetValue Then
                Return i
            End If
        Next

        Return -1
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim found As Boolean = False

        If txtMachineID.Text.Trim = "" Then
            Me.Close()
            Exit Sub
        End If

        If selection = 1 Then
            For i As Integer = 1 To FrmPMCheckAllA.dgvMachine.Rows.Count
                If InStr(FrmPMCheckAllA.dgvMachine.Rows(i - 1).Cells(1).Value.ToString.ToUpper, txtMachineID.Text.ToUpper) Then
                    FrmPMCheckAllA.dgvMachine.ClearSelection()
                    FrmPMCheckAllA.dgvMachine.Rows(i - 1).Selected = True
                    FrmPMCheckAllA.dgvMachine.FirstDisplayedScrollingRowIndex = (i - 1)
                    found = True
                    Exit For
                End If

                If Not InStr(FrmPMCheckAllA.dgvMachine.Rows(i - 1).Cells(1).Value.ToString.ToUpper, txtMachineID.Text.ToUpper) Then
                    found = False
                End If
            Next
            If found = False Then
                MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf selection = 2 Then
            For i As Integer = 1 To FrmPMCheckAll.dgvMachine.Rows.Count
                If InStr(FrmPMCheckAll.dgvMachine.Rows(i - 1).Cells(1).Value.ToString.ToUpper, txtMachineID.Text.ToUpper) Then
                    FrmPMCheckAll.dgvMachine.ClearSelection()
                    FrmPMCheckAll.dgvMachine.Rows(i - 1).Selected = True
                    FrmPMCheckAll.dgvMachine.FirstDisplayedScrollingRowIndex = (i - 1)
                    found = True
                    Exit For
                End If

                If Not InStr(FrmPMCheckAll.dgvMachine.Rows(i - 1).Cells(1).Value.ToString.ToUpper, txtMachineID.Text.ToUpper) Then
                    found = False
                End If
            Next
            If found = False Then
                MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf selection = 3 Then
            For i As Integer = 1 To FrmMMange.dgvMachine.Rows.Count
                If InStr(FrmMMange.dgvMachine.Rows(i - 1).Cells(1).Value.ToString.ToUpper, txtMachineID.Text.ToUpper) Then
                    FrmMMange.dgvMachine.ClearSelection()
                    FrmMMange.dgvMachine.Rows(i - 1).Selected = True
                    FrmMMange.dgvMachine.FirstDisplayedScrollingRowIndex = (i - 1)
                    found = True
                    FrmMMange.txtMachineID.Text = FrmMMange.dgvMachine.Rows(i - 1).Cells(1).Value.ToString()
                    FrmMMange.txtMachineName.Text = FrmMMange.dgvMachine.Rows(i - 1).Cells(2).Value.ToString()
                    FrmMMange.cbxLocation.SelectedIndex = GetSelectedIndex(FrmMMange.cbxLocation, FrmMMange.dgvMachine.Rows(i - 1).Cells(3).Value.ToString())
                    FrmMMange.cbxStatus.SelectedIndex = GetSelectedIndex(FrmMMange.cbxStatus, FrmMMange.dgvMachine.Rows(i - 1).Cells(4).Value.ToString())
                    Exit For
                End If

                If Not InStr(FrmMMange.dgvMachine.Rows(i - 1).Cells(1).Value.ToString.ToUpper, txtMachineID.Text.ToUpper) Then
                    found = False
                End If
            Next
            If found = False Then
                MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        Me.Close()
    End Sub

    Private Sub txtMachineID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMachineID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Try
                btnSearch.PerformClick()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub
End Class