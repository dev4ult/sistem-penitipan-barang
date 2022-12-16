Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class Database
    Private conn As New MySqlConnection
    Private cmd As New MySqlCommand
    Private queryString As String
    Private dataReader As MySqlDataReader

    Public Sub New()
        conn.ConnectionString = "server=localhost; 
                                 user id=root;
                                 password=;
                                 database=vb_sistem_penitipan"
    End Sub
    Public Sub Open()
        cmd.Connection = conn
        conn.Open()
    End Sub
    Public Sub Query(query As String)
        Open()
        queryString = query
        cmd.CommandText = queryString
    End Sub

    Public Sub Bind(name As String, type As String, value As String)
        If type = "number" Then
            value = Integer.Parse(value)
        End If
        cmd.Parameters.AddWithValue("@" & name, value)
    End Sub

    Public Sub PrepareStmt()
        If queryString.Contains("@") Then
            cmd.Prepare()
        End If
    End Sub

    Public Function Execute() As Integer
        Dim affectedRows As Integer

        PrepareStmt()

        affectedRows = cmd.ExecuteNonQuery()

        cmd.Parameters.Clear()
        conn.Close()

        Return affectedRows
    End Function

    Public Function Fetch() As DataTable
        Dim dataTable As New DataTable

        PrepareStmt()

        dataReader = cmd.ExecuteReader()
        dataTable.Load(dataReader)

        dataReader.Close()

        cmd.Parameters.Clear()
        conn.Close()

        Return dataTable
    End Function

    Public Function GetDataBaseLocker() As DataTable
        Dim result As New DataTable

        conn.ConnectionString = "server=localhost; 
                                 user id=root;
                                 password=;
                                 database=vb_sistem_penitipan"
        conn.Open()
        cmd.Connection = conn
        cmd.CommandText = "SELECT
                                      id As 'ID Locker',
                                      id_ukuran AS 'Ukuran',
                                      lokasi as 'Lokasi',
                                       status as 'Status'
                                       FROM locker
                              "
        dataReader = cmd.ExecuteReader

        result.Load(dataReader)
        dataReader.Close()
        conn.Close()
        Return result

    End Function


    Public Function AddDataLockerDatabase(id_ukuran As Integer, nama As String, lokasi As String)

        conn.ConnectionString = "server=localhost; 
                                 user id=root;
                                 password=;
                                 database=vb_sistem_penitipan"
        conn.Open()
        cmd.Connection = conn
        cmd.CommandText = "INSERT INTO locker (id_ukuran, nama, lokasi, status) VALUES (" &
                                     id_ukuran & ", '" & nama & "', '" & lokasi & "', 'Kosong' )"



    End Function

End Class