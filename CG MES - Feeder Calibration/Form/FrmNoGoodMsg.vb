Public Class FrmNoGoodMsg
    Public Shared mode As Integer

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub FrmNoGoodMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        Me.Show()
        txtMsg.Clear()
        txtMsg.Focus()
    End Sub

    Private Sub FrmNoGoodMsg_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtMsg.Focus()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If txtMsg.Text.Length < 1 Then
            MessageBox.Show("No good message is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMsg.Focus()
            Exit Sub
        Else
            If mode = 1 Then
                FrmManagement.noGoodMsg = txtMsg.Text.Trim
            ElseIf mode = 2 Then
                FrmMMange.noGoodMsg = txtMsg.Text.Trim
            End If
        End If

        Me.Close()
    End Sub

    Private Sub txtMsg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMsg.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Try
                btnConfirm.PerformClick()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub
End Class