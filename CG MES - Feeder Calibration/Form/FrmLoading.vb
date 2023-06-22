Public Class FrmLoading
    Private Sub FrmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Left = (Label2.Parent.Width \ 2) - (Label2.Width \ 2) 'horizontal centering
    End Sub
End Class