Public Class Locker_model
    Private db As Database

    Public Sub New()
        db = New Database()
    End Sub

    Public Function FetchAllLocker() As DataTable
        db.Query("SELECT * FROM locker")
        Return db.Fetch()
    End Function

    Public Function IsLockerExist(lokasi As String)
        db.Query("SELECT * FROM locker WHERE lokasi = @lokasi")
        db.Bind("lokasi", "text", lokasi)

        If db.Fetch().Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function InsertNewLocker(ukuran As String, lokasi As String) As Integer
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
        db.Bind("lokasi", "text", lokasi)


        If db.Execute() > 0 Then
            Return True

        Else
            Return False
        End If
    End Function

    Public Function ValidateNewLocker(ukuran As String, lokasi As String, status As Boolean) As Boolean
        If IsLockerExist(lokasi) Then
            MessageBox.Show("Gagal! Lokasi/Nama locker sudah digunakan")
            Return False
        End If


    End Function
End Class
