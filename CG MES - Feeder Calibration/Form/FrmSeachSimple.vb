Public Class FrmSeachSimple
    Public Shared selection As Integer
    Private Sub FrmSeachSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        txtFeederID.Clear()
        Me.Show()
    End Sub

    Private Sub FrmSeachSimple_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtFeederID.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim found As Boolean = False

        If txtFeederID.Text.Trim = "" Then
            Me.Close()
            Exit Sub
        End If
        If selection = 1 Then
            For i As Integer = 1 To FrmManagement.dgvFeeder.Rows.Count
                If InStr(FrmManagement.dgvFeeder.Rows(i - 1).Cells(1).Value.ToString.ToUpper, txtFeederID.Text.ToUpper) Then
                    FrmManagement.dgvFeeder.ClearSelection()
                    FrmManagement.dgvFeeder.Rows(i - 1).Selected = True
                    FrmManagement.dgvFeeder.FirstDisplayedScrollingRowIndex = (i - 1)
                    found = True
                    FrmManagement.txtFeederID.Text = FrmManagement.dgvFeeder.Rows(i - 1).Cells(1).Value.ToString()
                    FrmManagement.cbxType.SelectedIndex = GetSelectedIndex(FrmManagement.cbxType, FrmManagement.dgvFeeder.Rows(i - 1).Cells(2).Value.ToString())
                    FrmManagement.cbxSize.SelectedIndex = GetSelectedIndex(FrmManagement.cbxSize, FrmManagement.dgvFeeder.Rows(i - 1).Cells(3).Value.ToString())
                    FrmManagement.cbxColor.SelectedIndex = GetSelectedIndex(FrmManagement.cbxColor, FrmManagement.dgvFeeder.Rows(i - 1).Cells(4).Value.ToString())
                    FrmManagement.cbxStatus.SelectedIndex = GetSelectedIndex(FrmManagement.cbxStatus, FrmManagement.dgvFeeder.Rows(i - 1).Cells(5).Value.ToString())
                    Exit For
                End If

                If Not InStr(FrmManagement.dgvFeeder.Rows(i - 1).Cells(1).Value.ToString.ToUpper, txtFeederID.Text.ToUpper) Then
                    found = False
                End If
            Next
            If found = False Then
                MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf selection = 2 Then
            For i As Integer = 1 To FrmCheckAll.dgvFeeder.Rows.Count
                If InStr(FrmCheckAll.dgvFeeder.Rows(i - 1).Cells(1).Value.ToString.ToUpper, txtFeederID.Text.ToUpper) Then
                    FrmCheckAll.dgvFeeder.ClearSelection()
                    FrmCheckAll.dgvFeeder.Rows(i - 1).Selected = True
                    FrmCheckAll.dgvFeeder.FirstDisplayedScrollingRowIndex = (i - 1)
                    found = True
                    Exit For
                End If

                If Not InStr(FrmCheckAll.dgvFeeder.Rows(i - 1).Cells(1).Value.ToString.ToUpper, txtFeederID.Text.ToUpper) Then
                    found = False
                End If
            Next
            If found = False Then
                MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        Me.Close()
    End Sub

    Private Sub txtFeederID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFeederID.KeyPress
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