Public Class Sewa_model
    Private stmt As String
    Private result As New List(Of String)
    Private db As Database

    Public Sub New()
        db = New Database()
    End Sub

    Public Function FetchAllLockerSize() As List(Of String)
        result.Clear()
        db.Query("SELECT ukuran FROM jenis_ukuran")

        For Each ukuran In db.Fetch().Rows
            result.Add(ukuran(0))
        Next

        Return result
    End Function

    Public Function GetAvailableLocker(ukuran As String) As List(Of String)
        result.Clear()
        stmt = "SELECT locker.lokasi FROM locker JOIN jenis_ukuran 
                ON locker.id_ukuran = jenis_ukuran.id 
                WHERE jenis_ukuran.ukuran = @ukuran AND locker.status = 'Kosong'"
        db.Query(stmt)
        db.Bind("ukuran", "text", ukuran)

        'Set untuk nama loker
        For Each lokasi In db.Fetch().Rows
            result.Add(lokasi(0))
        Next
        'Set untuk info ket ukuran locker

        Return result
    End Function

    Public Function GetLockerDetail(ukuran As String) As String
        stmt = "SELECT infoKet FROM jenis_ukuran WHERE ukuran = @ukuran"

        db.Query(stmt)
        db.Bind("ukuran", "text", ukuran)

        Return db.Fetch()(0)(0)
    End Function

    Public Function GetLockerCost(ukuran As String) As Integer
        stmt = "SELECT biaya FROM jenis_ukuran WHERE ukuran = @ukuran"

        db.Query(stmt)
        db.Bind("ukuran", "text", ukuran)

        Return db.Fetch().Rows(0)(0)
    End Function

    Public Function GetLockerId(lokasi As String) As Integer
        stmt = "SELECT id FROM locker WHERE lokasi = @lokasi"

        db.Query(stmt)
        db.Bind("lokasi", "text", lokasi)

        Return db.Fetch(0)(0)
    End Function

    Public Function InsertNewRentHistory(lokasi As String, lamaSewa As Integer, waktuBayar As Boolean,
                                         totalBiaya As String, keterangan As String) As Integer
        Dim idLoker = GetLockerId(lokasi)

        stmt = "INSERT INTO 
                penyewaan (id_locker, tanggal_sewa, bayar_sebelum_pinjam, 
                           rencana_pinjam, kelebihan_pinjam, total_bayar) 
                VALUES (@id_locker, @tanggal_sewa, @bayar_sebelum_pinjam, 
                        @rencana_pinjam, @kelebihan_pinjam, @total_bayar)"

        db.Query(stmt)

        db.Bind("id_locker", "text", idLoker)
        db.Bind("tanggal_sewa", "text", String.Format("dd/MM/yyyy", DateTime.Now))
        db.Bind("bayar_sebelum_pinjam", "number", waktuBayar)
        db.Bind("rencana_pinjam", "number", lamaSewa)
        db.Bind("kelebihan_pinjam", "number", 0)
        db.Bind("total_bayar", "number", totalBiaya)

        Return db.Execute()
    End Function

    Public Function ValidateNewRentData(lokasi As String, lamaSewa As Integer, waktuBayar As Boolean,
                                         totalBiaya As String, keterangan As String) As Boolean
        If lokasi = "" Then
            MessageBox.Show("Pilih lokasi loker terlebih dahulu")
            Return False
        End If

        If lamaSewa = 0 Then
            MessageBox.Show("Tentukan berapa hari untuk menyewa loker")
            Return False
        End If

        If InsertNewRentHistory(lokasi, lamaSewa, waktuBayar,
                                totalBiaya, keterangan) Then
            Return True
        Else
            MessageBox.Show("Terjadi kesalaha, silahkan input ulang")
            Return False
        End If
    End Function
End Class
