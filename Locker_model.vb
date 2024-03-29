﻿Public Class Locker_model
    Private db As Database

    Public Sub New()
        db = New Database()
    End Sub

    Public Function FetchAllLocker() As DataTable
        db.Query("SELECT locker.lokasi as Lokasi, jenis_ukuran.ukuran as Ukuran, locker.status as Status FROM locker 
        JOIN jenis_ukuran ON jenis_ukuran.id = locker.id_ukuran")
        Return db.Fetch()
    End Function

    Public Function GetLockerId(lokasi As String) As Integer
        db.Query("SELECT id FROM locker WHERE lokasi = @lokasi")
        db.Bind("lokasi", "text", lokasi)

        Return db.Fetch()(0)(0)
    End Function

    Private Function NextIndexLocation(lokasi As String) As Integer
        db.Query("SELECT lokasi FROM locker WHERE lokasi LIKE @lokasi")
        db.Bind("lokasi", "text", lokasi & "%")

        Dim dataTable As DataTable = db.Fetch()
        Dim indexLocation As Integer = 0

        If dataTable.Rows.Count > 0 Then
            Dim lnList As New ArrayList

            For Each row In dataTable.Rows
                lnList.Add(Integer.Parse(row(0)(2)))
            Next

            For i = 1 To dataTable.Rows.Count
                If Not lnList.Contains(i) Then
                    Return i
                Else
                    indexLocation = i
                End If
            Next
        End If
        Return indexLocation + 1
    End Function

    Public Function InsertNewLocker(ukuran As String, lokasi As String) As Integer
        Dim locationId = NextIndexLocation(lokasi)
        Dim id_ukuran As Integer = GetLockerTypeId(ukuran)

        db.Query("INSERT INTO locker(id_ukuran, lokasi) VALUES (@id_ukuran, @lokasi)")

        db.Bind("id_ukuran", "number", id_ukuran)
        db.Bind("lokasi", "text", lokasi & "-" & locationId)

        Return db.Execute()
    End Function

    Public Function DeleteLockerByLocation(lokasi As String) As Integer
        db.Query("DELETE FROM locker WHERE lokasi = @lokasi")
        db.Bind("lokasi", "text", lokasi)

        Return db.Execute()
    End Function

    Public Function GetLockerStatus(lokasi As String) As String
        db.Query("SELECT status FROM locker WHERE lokasi = @lokasi")
        db.Bind("lokasi", "text", lokasi)

        Return db.Fetch()(0)(0)
    End Function

    Public Function GetLockerDetail(ukuran As String) As String
        db.Query("SELECT info_ket FROM jenis_ukuran WHERE ukuran = @ukuran")
        db.Bind("ukuran", "text", ukuran)

        Return db.Fetch()(0)(0)
    End Function

    Public Function GetAvailableLocker(ukuran As String) As List(Of String)
        Dim result As New List(Of String)

        db.Query("SELECT locker.lokasi FROM locker JOIN jenis_ukuran 
                ON locker.id_ukuran = jenis_ukuran.id 
                WHERE jenis_ukuran.ukuran = @ukuran AND locker.status = 'Kosong'")
        db.Bind("ukuran", "text", ukuran)

        'Set untuk nama loker
        For Each lokasi In db.Fetch().Rows
            result.Add(lokasi(0))
        Next

        Return result
    End Function

    Public Function UpdateLockerStatus(lokasi As String, status As String) As Integer
        db.Query("UPDATE locker SET status = @status WHERE lokasi = @lokasi")
        db.Bind("status", "text", status)
        db.Bind("lokasi", "text", lokasi)

        Return db.Execute()
    End Function

    Public Function GetLockerCost(ukuran As String) As Integer
        db.Query("SELECT biaya FROM jenis_ukuran WHERE ukuran = @ukuran")
        db.Bind("ukuran", "text", ukuran)

        Return db.Fetch()(0)(0)
    End Function

    Private Function GetLockerTypeId(ukuran As String) As Integer
        db.Query("SELECT id FROM jenis_ukuran WHERE ukuran = @ukuran")
        db.Bind("ukuran", "text", ukuran)

        Dim dataId = db.Fetch()
        If dataId.Rows.Count > 0 Then
            Return dataId(0)(0)
        Else
            Return 0
        End If
    End Function

    Private Function InsertNewLockerType(ukuran As String, biaya As Integer, info_ket As String) As Integer
        db.Query("INSERT INTO jenis_ukuran (ukuran, biaya, info_ket) 
                              VALUES (@ukuran, @biaya, @info_ket)")

        db.Bind("ukuran", "text", ukuran)
        db.Bind("biaya", "number", biaya)
        db.Bind("info_ket", "text", info_ket)

        Return db.Execute()
    End Function

    Public Function ValidateFormAddLockerType(ukuran As String, biaya As Integer, infoKet As String) As Boolean
        MessageBox.Show(ukuran)
        If GetLockerTypeId(ukuran) Then
            Return False
        End If

        If InsertNewLockerType(ukuran, biaya, infoKet) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function FetchAllLockerTypes() As DataTable
        db.Query("SELECT ukuran AS 'Ukuran Locker', 
                  biaya AS 'Biaya Loker', info_ket AS 'Info Keterangan' 
                  FROM jenis_ukuran")
        Return db.Fetch()
    End Function

    Private Function UpdateLockerType(ukuran As String, biaya As Integer, infoKet As String, ukuranLama As String) As Integer
        Dim lockerId = GetLockerTypeId(ukuranLama)

        db.Query("UPDATE jenis_ukuran SET ukuran = @ukuran, 
                 biaya = @biaya, info_ket = @info_ket WHERE id = @id")

        db.Bind("id", "number", lockerId)
        db.Bind("ukuran", "text", ukuran)
        db.Bind("biaya", "number", biaya)
        db.Bind("info_ket", "text", infoKet)

        Return db.Execute()
    End Function

    Public Function ValidateFormUpdateLockerType(ukuran As String, biaya As Integer, infoKet As String, ukuranLama As String) As Integer
        If UpdateLockerType(ukuran, biaya, infoKet, ukuranLama) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function DeleteLockerTypeBySize(ukuran As String) As Integer
        db.Query("DELETE FROM jenis_ukuran WHERE ukuran = @ukuran")

        db.Bind("ukuran", "text", ukuran)

        Return db.Execute()
    End Function
End Class