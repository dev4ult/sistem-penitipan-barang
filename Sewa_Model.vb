Public Class Sewa_model
    Private stmt As String
    Private result As New List(Of String)
    Private db As Database
    Private statusLocker As String = "Terisi"

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
        Return db.Fetch().Rows(0)(0)
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

        Return db.Fetch.Rows(0)(0)
    End Function

    Public Function InsertNewRentHistory(lokasi As String, lamaSewa As Integer, waktuBayar As String,
                                         totalBiaya As Integer, keterangan As String) As Integer
        Dim idLoker = GetLockerId(lokasi)

        stmt = "INSERT INTO 
                penyewaan (id_locker, tanggal_sewa, bayar_sebelum_pinjam, 
                           rencana_pinjam, kelebihan_pinjam, total_bayar, ketUser) 
                VALUES (@id_locker, @tanggal_sewa, @bayar_sebelum_pinjam, 
                        @rencana_pinjam, @kelebihan_pinjam, @total_bayar, @ket_User)"

        db.Query(stmt)


        Console.WriteLine(waktuBayar)
        db.Bind("id_locker", "number", idLoker)
        db.Bind("tanggal_sewa", "date", DateTime.Now.ToString("yyyy/MM/dd"))
        db.Bind("bayar_sebelum_pinjam", "text", waktuBayar)
        db.Bind("rencana_pinjam", "number", lamaSewa)
        db.Bind("kelebihan_pinjam", "number", 0)
        db.Bind("total_bayar", "number", totalBiaya)
        db.Bind("ket_User", "text", keterangan)

        Return db.Execute()
    End Function

    Public Function ValidateNewRentData(lokasi As String, lamaSewa As Integer, waktuBayar As String,
                                         totalBiaya As String, keterangan As String, statusLocker As String) As Boolean
        If lokasi = "" Then
            MessageBox.Show("Pilih lokasi loker terlebih dahulu")
            Return False
        End If

        If lamaSewa = 0 Then
            MessageBox.Show("Tentukan berapa hari untuk menyewa loker")
            Return False
        End If

        If InsertNewRentHistory(lokasi, lamaSewa, waktuBayar,
                                totalBiaya, keterangan) And updateStatusLocker(lokasi, statusLocker) Then
            Return True
        Else
            MessageBox.Show("Terjadi kesalahan, silahkan input ulang")
            Return False
        End If
    End Function

    Public Function updateStatusLocker(lokasi As String, status As String) As Integer
        Dim idLocker = GetLockerId(lokasi)
        Console.WriteLine(idLocker)

        stmt = "UPDATE locker SET status = @status
                WHERE id=@idloker"
        db.Query(stmt)
        db.Bind("idloker", "number", idLocker)
        db.Bind("status", "text", status)

        Return db.Execute()
    End Function


    Public Function getAllRentData()
        stmt = "SELECT locker.lokasi as 'Nama Loker', 
                tanggal_sewa as 'Tanggal Sewa', 
                CASE WHEN tanggal_kembali IS NULL THEN 'Belum diambil' 
                WHEN tanggal_kembali IS NOT NULL THEN tanggal_kembali
                END AS 'Tanggal Kembali', 
                bayar_sebelum_pinjam as 'Bayar Saat Sewa', 
                rencana_pinjam as 'Jumlah Hari Sewa', 
                kelebihan_pinjam as 'Telat Hari', 
                CASE WHEN kelebihan_pinjam > 0 THEN total_bayar + 10 * kelebihan_pinjam 
                ELSE total_bayar 
                END AS 'Total Bayar', 
                ketUser AS 'Keterangan Pengguna' 
                FROM penyewaan 
                JOIN locker ON penyewaan.id_locker = locker.id;"
        db.Query(stmt)

        Return db.Fetch()
    End Function


    Public Function removeRentData(lockerName As String)
        Dim idLocker = GetLockerId(lockerName)
        stmt = "DELETE FROM penyewaan 
                WHERE id_locker = @locker"
        db.Query(stmt)
        db.Bind("locker", "number", idLocker)
        Return db.Execute()
    End Function


    'GETTER DAN SETTER
    Public Property GS_Status_Locker() As String
        Get
            Return statusLocker
        End Get
        Set(value As String)
            statusLocker = value
        End Set
    End Property
End Class
