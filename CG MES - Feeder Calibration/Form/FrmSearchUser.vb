Public Class FrmSearchUser
    Public SQL As New SQLControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmSearchUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        txtCGID.Clear()
        Me.Show()
    End Sub

    Private Sub FrmSearchUser_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtCGID.Focus()
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

    Private Sub txtCGID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCGID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Try
                btnSearch.PerformClick()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Function GetUserPassword(UID As String) As String
        Dim result As String = ""

        SQL.AddParam("@id", UID)
        SQL.ExecQuery("SELECT UserPass FROM Users WHERE UserID = @id")
        If SQL.HasException(True) Then Return result ' Return early in case of exception

        If SQL.RecordCount > 0 Then
            result = SQL.DBDT.Rows(0)("UserPass").ToString
        End If
        Dim decResult As String = Decrypt(result)

        Return decResult
    End Function

    Private Function GetUserEmail(UID As String) As String
        Dim result As String = ""

        SQL.AddParam("@id", UID)
        SQL.ExecQuery("SELECT Email FROM Users WHERE UserID = @id")
        If SQL.HasException(True) Then Return result ' Return early in case of exception

        If SQL.RecordCount > 0 Then
            result = SQL.DBDT.Rows(0)("Email").ToString
        End If

        Return result
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim found As Boolean = False

        If txtCGID.Text.Trim = "" Then
            Me.Close()
            Exit Sub
        End If
        For i As Integer = 1 To FrmUserManage.dgvUser.Rows.Count
            If InStr(FrmUserManage.dgvUser.Rows(i - 1).Cells(1).Value.ToString.ToUpper, txtCGID.Text.ToUpper) Then
                FrmUserManage.dgvUser.ClearSelection()
                FrmUserManage.dgvUser.Rows(i - 1).Selected = True
                FrmUserManage.dgvUser.FirstDisplayedScrollingRowIndex = (i - 1)
                found = True


                FrmUserManage.txtEmployeeID.Text = FrmUserManage.dgvUser.Rows(i - 1).Cells(1).Value.ToString()
                FrmUserManage.txtName.Text = FrmUserManage.dgvUser.Rows(i - 1).Cells(2).Value.ToString()
                FrmUserManage.txtPass1.Text = GetUserPassword(FrmUserManage.dgvUser.Rows(i - 1).Cells(1).Value.ToString())
                FrmUserManage.txtPass2.Text = FrmUserManage.txtPass1.Text
                FrmUserManage.txtEmail.Text = GetUserEmail(FrmUserManage.dgvUser.Rows(i - 1).Cells(1).Value.ToString())
                FrmUserManage.cbxGroup.SelectedIndex = GetSelectedIndex(FrmUserManage.cbxGroup, FrmUserManage.dgvUser.Rows(i - 1).Cells(3).Value.ToString())
                FrmUserManage.cbxLevel.SelectedIndex = GetSelectedIndex(FrmUserManage.cbxLevel, FrmUserManage.dgvUser.Rows(i - 1).Cells(4).Value.ToString())

                If FrmUserManage.dgvUser.Rows(i - 1).Cells(5).Value.ToString() = "SUSPENDED" Then
                    FrmUserManage.btnSuspend.Checked = True
                Else
                    FrmUserManage.btnSuspend.Checked = True
                End If
                Exit For
            End If

            If Not InStr(FrmUserManage.dgvUser.Rows(i - 1).Cells(1).Value.ToString.ToUpper, txtCGID.Text.ToUpper) Then
                found = False
            End If
        Next
        If found = False Then
            MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Me.Close()
    End Sub
End Class