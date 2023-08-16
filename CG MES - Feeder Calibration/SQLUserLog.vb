Public Class SQLUserLog
    Public SQL As New SQLControl

    Public UID As String
    Public UName As String

    Public Sub New()
    End Sub

    Public Sub GetUserData(UserID As String)
        UID = UserID
        UName = ""

        SQL.AddParam("@UID", UserID)
        SQL.ExecQuery("SELECT * FROM Users WHERE UserID = @UID")
        If SQL.HasException(True) Then Exit Sub

        If SQL.RecordCount > 0 Then
            UName = SQL.DBDT.Rows(0)("Name")
        End If
    End Sub
End Class
