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

    Public Function NextIndexLocation(lokasi As String) As Integer
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

    Public Function DeleteLockerByLocation(lokasi As String) As Integer
        db.Query("DELETE FROM locker WHERE lokasi = @lokasi")
        db.Bind("lokasi", "text", lokasi)

        Return db.Execute()
    End Function

    Public Function InsertNewLocker(ukuran As String, lokasi As String) As Integer
        Dim locationId = NextIndexLocation(lokasi)
        db.Query("INSERT INTO locker(id_ukuran, lokasi) VALUES (@id_ukuran, @lokasi)")

        Dim id_ukuran As Integer

        If ukuran = "Small" Then
            id_ukuran = 1
        ElseIf ukuran = "Medium" Then
            id_ukuran = 2
        ElseIf ukuran = "Large" Then
            id_ukuran = 3
        End If

        db.Bind("id_ukuran", "number", id_ukuran)
        db.Bind("lokasi", "text", lokasi & "-" & locationId)

        Return db.Execute()
    End Function

    Public Function GetLockerStatus(lokasi As String) As String
        db.Query("SELECT status FROM locker WHERE lokasi = @lokasi")
        db.Bind("lokasi", "text", lokasi)

        Return db.Fetch()(0)(0)
    End Function

    Public Function UpdateLockerStatus(lokasi As String, status As String) As Integer
        db.Query("UPDATE locker SET status = @status WHERE lokasi = @lokasi")
        db.Bind("status", "text", status)
        db.Bind("lokasi", "text", lokasi)

        Return db.Execute()
    End Function
End Class
