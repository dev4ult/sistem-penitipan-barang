Imports MySql.Data.MySqlClient

Public Class Database
    Private conn As New MySqlConnection
    Private cmd As New MySqlCommand

    Public Sub New()
        conn.ConnectionString = "server=localhost; 
                                 user id=root;
                                 password=;
                                 database=vb_sistem_penitipan"
        cmd.Connection = conn
        conn.Open()
    End Sub

    Public Sub Query(query As String)
        cmd.CommandText = query
        If query.Contains("@") Then
            cmd.Prepare()
        End If
    End Sub

    Public Sub Bind(name As String, type As String, value As String)
        If type = "number" Then
            value = Integer.Parse(value)
        End If
        cmd.Parameters.AddWithValue("@" & name, value)
    End Sub

    Public Sub Execute()
        cmd.ExecuteNonQuery()
    End Sub

    Public Function Fetch() As MySqlDataReader
        Return cmd.ExecuteReader()
    End Function

End Class
