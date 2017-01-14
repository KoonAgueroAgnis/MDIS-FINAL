Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class DBAccess
    ' DB DATA
    Public DBDA As MySqlDataAdapter

    Public DBDR As MySqlDataReader

    Public DBDT As DataTable

    Public Exception As String

    ' QUERY PARAMETERS
    Public Params As New List(Of MySqlParameter)

    ' QUERY STATISTICS
    Public RecordCount As Integer

    ' PREPARE DB COMMAND
    Private DBCmd As MySqlCommand

    ' CREATE YOUR DB CONNECTION
    Private DBCon As New MySqlConnection("server = localhost;user id = root; database = mdis2")
    ' INCLUDE QUERY & COMMAND PARAMETERS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New MySqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    Public Sub ExecQuery(Query As String)
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try
            ' OPEN A CONNECTION
            DBCon.Open()

            ' CREATE DB COMMAND
            DBCmd = New MySqlCommand(Query, DBCon)

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' CLEAR PARAMS LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATATABLE
            DBDT = New DataTable
            DBDA = New MySqlDataAdapter(DBCmd)

            RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            Exception = ex.Message
        End Try

        ' CLOSE YOUR CONNECTION
        If DBCon.State = ConnectionState.Open Then DBCon.Close()
    End Sub
End Class