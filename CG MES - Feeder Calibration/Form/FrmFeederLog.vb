Public Class FrmFeederLog
    Public SQL As New SQLControl

    Private currentPage As Integer = 1
    Private pageSize As Integer = 100
    Private totalRecords As Integer = 0
    Private totalPages As Integer = 0
    Private searchMode As Boolean
    Private searchType As String = ""
    Private searchText As String = ""

    Public Sub New()
        InitializeComponent()
        SetupDGV()
    End Sub

    Private Sub FrmFeederLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)

        LoadData()

        cbxType.SelectedIndex = 0
        Me.Show()
        txtSearch.Focus()
    End Sub

    Private Sub LoadData()
        Dim query As String = "SELECT COUNT(*) FROM FeederCalLog"

        If searchMode Then
            SQL.AddParam("@searchText", "%" & searchText & "%")
            query &= " WHERE " & searchType & " LIKE @searchText"
        End If

        SQL.ExecQuery(query)

        If SQL.HasException(True) Then Exit Sub

        totalRecords = SQL.DBDT.Rows(0)(0)

        ' Calculate the number of pages needed
        totalPages = Math.Ceiling(totalRecords / pageSize)

        lblTotalHis.Text = If(totalPages < 1, "0 records overall, 0 pages, and 100 records per page.",
            $"{totalRecords} records overall, {totalPages} pages, and 100 records per page.")

        ' Update the navigation buttons
        UpdateNavButtons()

        ' Load first page of data
        LoadDatatoDGV()
    End Sub

    Private Sub UpdateNavButtons()
        btnFirst.Enabled = (currentPage > 1)
        btnPrev.Enabled = (currentPage > 1)
        btnNext.Enabled = (currentPage < totalPages)
        btnLast.Enabled = (currentPage < totalPages)

        ' Update the page label
        lblPage.Text = If(totalPages < 1, "Page 0 of 0", $"Page {currentPage} of {totalPages}")
    End Sub

    Private Sub SetupDGV()
        With dgvFeederLogs
            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False
            .ColumnCount = 8
            .AllowUserToResizeRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Dim columns As String() = {"No.", "Record Time", "Feeder ID", "Calibrated Date", "Updater"}
            Dim widths As Integer() = {40, 220, 220, 220, 150}

            For i As Integer = 0 To columns.Length - 1
                .Columns(i).Name = columns(i)
            Next

            For i As Integer = 0 To widths.Length - 1
                .Columns(i).Width = widths(i)
            Next
        End With
    End Sub

    Private Sub LoadDatatoDGV()
        dgvFeederLogs.Rows.Clear()

        ' Retrieve the records for the current page
        Dim offset As Integer = (currentPage - 1) * pageSize
        SQL.AddParam("@offset", offset)
        SQL.AddParam("@fetch", pageSize)

        Dim query As String = "SELECT * FROM FeederCalLog"

        If searchMode Then
            SQL.AddParam("@searchText", "%" & searchText & "%")
            query &= " WHERE " & searchType & " LIKE @searchText ORDER BY RecordTime DESC OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY"
        Else
            query &= " ORDER BY RecordTime DESC OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY"
        End If

        SQL.ExecQuery(query)
        If SQL.HasException(True) Then Exit Sub

        If SQL.RecordCount > 0 Then
            For i As Integer = 1 To SQL.DBDT.Rows.Count
                Dim textCalibrate As String

                textCalibrate = If(String.IsNullOrEmpty(SQL.DBDT.Rows(i - 1)("LatestCalDate").ToString()), "-", SQL.DBDT.Rows(i - 1)("LatestCalDate"))

                dgvFeederLogs.Rows.Add(New Object() {i.ToString + ".", SQL.DBDT.Rows(i - 1)("RecordTime"), SQL.DBDT.Rows(i - 1)("FeederNumber"), textCalibrate,
                                SQL.DBDT.Rows(i - 1)("Updater")})
            Next
        End If
    End Sub

    Private Sub cbxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxType.SelectedIndexChanged
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim = "" Then
            dgvFeederLogs.ClearSelection()
            Return
        End If

        Dim text As String = cbxType.Text

        For i As Integer = 1 To dgvFeederLogs.Rows.Count
            If InStr(dgvFeederLogs.Rows(i - 1).Cells(text).Value.ToString.ToUpper, txtSearch.Text.ToUpper) Then
                dgvFeederLogs.ClearSelection()
                dgvFeederLogs.Rows(i - 1).Selected = True
                dgvFeederLogs.FirstDisplayedScrollingRowIndex = (i - 1)
                Return
            End If

            If Not InStr(dgvFeederLogs.Rows(i - 1).Cells(text).Value.ToString.ToUpper, txtSearch.Text.ToUpper) Then
                dgvFeederLogs.ClearSelection()
            End If
        Next
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        'press enter in textbox
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try

                If txtSearch.Text = "" Then
                    searchMode = False
                Else
                    currentPage = 1
                    searchMode = True

                    Dim dataTypes As String() = {"FeederNumber", "RecordTime", "LatestCalDate"}

                    searchType = dataTypes(cbxType.SelectedIndex)

                    searchText = txtSearch.Text.Trim.ToUpper
                End If

                LoadData()
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        ' Set current page to 1 and reload data
        currentPage = 1
        LoadDatatoDGV()
        UpdateNavButtons()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        ' Decrement current page and reload data
        currentPage -= 1
        LoadDatatoDGV()
        UpdateNavButtons()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Increment current page and reload data
        currentPage += 1
        LoadDatatoDGV()
        UpdateNavButtons()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        ' Set current page to last page and reload data
        currentPage = totalPages
        LoadDatatoDGV()
        UpdateNavButtons()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ctrlClose.PerformClick()
    End Sub

    Private Sub FrmFeederLog_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Show()
    End Sub

    Private Sub FrmFeederLog_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtSearch.Focus()
    End Sub
End Class