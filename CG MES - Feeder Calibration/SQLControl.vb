﻿Imports System.Data.SqlClient
'Imports MySql.Data.MySqlClient

Public Class SQLControl
    Private DBCon As New SqlConnection("Data Source=192.168.1.32\MESDUMMY,1434;Initial Catalog=CGMES;User ID=sa;password=eLuQr3GghsMgqGj;Connection Timeout=30;")
    Private DBCmd As SqlCommand

    ' DB DATA
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable

    ' QUERY PARAMETERS
    Public Params As New List(Of SqlParameter)

    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String

    Public Sub New()
    End Sub

    ' ALLOW CONNECTION STRING OVERRIDE
    Public Sub New(ConnectionString As String)
        DBCon = New SqlConnection(ConnectionString)
    End Sub

    ' EXECUTE QUERY SUB
    Public Sub ExecQuery(Query As String)
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try
            DBCon.Open()

            ' CREATE DB COMMAND
            DBCmd = New SqlCommand(Query, DBCon)

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' CLEAR PARAM LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATASET
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            ' CAPTURE ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Sub

    ' ADD PARAMS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    ' ERROR CHECKING
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
        Return True
    End Function



    'Private DBCmd As MySqlCommand
    '
    ''DB READER
    'Public DBDR As MySqlDataReader
    '
    '' DB DATA
    'Public DBDA As MySqlDataAdapter
    'Public DBDT As DataTable
    '
    '' QUERY PARAMETERS
    'Public Params As New List(Of MySqlParameter)
    '
    '' QUERY STATISTICS
    'Public RecordCount As Integer
    'Public Exception As String
    '
    'Public Sub New()
    'End Sub
    '
    '
    '' ALLOW CONNECTION STRING OVERRIDE
    'Public Sub New(ConnectionString As String)
    '    DBCon = New MySqlConnection(ConnectionString)
    'End Sub
    '
    '' EXECUTE QUERY SUB
    'Public Sub ExecQuery(Query As String)
    '    ' RESET QUERY STATS
    '    RecordCount = 0
    '    Exception = ""
    '
    '    Try
    '        DBCon.Open()
    '
    '        ' CREATE DB COMMAND
    '        DBCmd = New MySqlCommand(Query, DBCon)
    '
    '        ' LOAD TO DATAREADER
    '        'DBDR = DBCmd.ExecuteReader
    '
    '        ' LOAD PARAMS INTO DB COMMAND
    '        Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))
    '
    '        ' CLEAR PARAM LIST
    '        Params.Clear()
    '
    '        ' EXECUTE COMMAND & FILL DATASET
    '        DBDT = New DataTable
    '        DBDA = New MySqlDataAdapter(DBCmd)
    '        RecordCount = DBDA.Fill(DBDT)
    '    Catch ex As Exception
    '        ' CAPTURE ERROR
    '        Exception = "ExecQuery Error: " & vbNewLine & ex.Message
    '    Finally
    '        ' CLOSE CONNECTION
    '        If DBCon.State = ConnectionState.Open Then DBCon.Close()
    '    End Try
    'End Sub
    '
    '' ADD PARAMS
    'Public Sub AddParam(Name As String, Value As Object)
    '    Dim NewParam As New MySqlParameter(Name, Value)
    '    Params.Add(NewParam)
    'End Sub
    '
    '' ERROR CHECKING
    'Public Function HasException(Optional Report As Boolean = False) As Boolean
    '    If String.IsNullOrEmpty(Exception) Then Return False
    '    If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
    '    Return True
    'End Function
End Class