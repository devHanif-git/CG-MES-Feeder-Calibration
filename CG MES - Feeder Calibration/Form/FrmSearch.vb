Public Class FrmSearch
    Private Sub FrmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlMain.Left = (pnlMain.Parent.Width \ 2) - (pnlMain.Width \ 2)
        btnSearch.Left = (btnSearch.Parent.Width \ 2) - (btnSearch.Width \ 2)
        Me.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ctrlClose.PerformClick()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub
End Class