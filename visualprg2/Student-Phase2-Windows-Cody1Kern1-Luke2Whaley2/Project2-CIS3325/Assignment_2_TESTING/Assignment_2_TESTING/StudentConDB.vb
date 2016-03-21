Imports System.Data
Imports System.Data.SqlClient
Public Class StudentConDB

    Public Shared Function GetConnection() As SqlConnection
        Dim connectionString As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"
        Return New SqlConnection(connectionString)
    End Function
End Class
