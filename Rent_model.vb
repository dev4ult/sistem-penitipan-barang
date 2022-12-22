Public Class Rent_model

    Private db As Database
    Private stmt As String

    Private lockerId As Integer

    Private locker_model As Locker_model
    Private user_model As User_model

    Public Sub New()
        db = New Database()
        locker_model = New Locker_model()
        user_model = New User_model()
    End Sub

    Public Function InsertNewRentHistory(lokasi As String, lamaSewa As Integer,
                                         totalBiaya As Integer, keterangan As String) As Integer

        lockerId = locker_model.GetLockerId(lokasi)

        stmt = "INSERT INTO 
                penyewaan (id_user, id_locker, tanggal_sewa, bayar_sebelum_pinjam, 
                           rencana_pinjam, kelebihan_pinjam, total_bayar, ket_user) 
                VALUES (@id_user, @id_locker, @tanggal_sewa, @bayar_sebelum_pinjam, 
                        @rencana_pinjam, @kelebihan_pinjam, @total_bayar, @ket_user)"

        db.Query(stmt)

        db.Bind("id_user", "number", MainMenu.GetUserId)
        db.Bind("id_locker", "number", lockerId)
        db.Bind("tanggal_sewa", "date", DateTime.Now.ToString("yyyy/MM/dd"))
        db.Bind("bayar_sebelum_pinjam", "number", totalBiaya)
        db.Bind("rencana_pinjam", "number", lamaSewa)
        db.Bind("kelebihan_pinjam", "number", 0)
        db.Bind("total_bayar", "number", totalBiaya)
        db.Bind("ket_user", "text", keterangan)

        Return db.Execute()

    End Function

    Public Function ValidateNewRentData(lokasi As String, lamaSewa As Integer,
                                         totalBiaya As String, keterangan As String) As Boolean
        If lokasi = "" Then
            MessageBox.Show("Pilih lokasi loker terlebih dahulu")
            Return False
        End If

        If lamaSewa = 0 Then
            MessageBox.Show("Tentukan berapa hari untuk menyewa loker")
            Return False
        End If

        If InsertNewRentHistory(lokasi, lamaSewa,
                                totalBiaya, keterangan) Then
            Return True
        Else
            MsgBox("Terjadi kesalahan, silahkan input ulang", MsgBoxStyle.Critical, "Kesalahan")
            Return False
        End If
    End Function

    Public Function FetchAllRentData() As DataTable
        stmt = "SELECT penyewaan.id as 'ID', 
                locker.lokasi as 'Nama Loker', 
                users.username as 'Nama Penyewa',
                tanggal_sewa as 'Tanggal Sewa', 
                CASE WHEN tanggal_kembali IS NULL THEN 'Belum diambil' 
                WHEN tanggal_kembali IS NOT NULL THEN tanggal_kembali
                END AS 'Tanggal Kembali', 
                bayar_sebelum_pinjam as 'Bayar Saat Sewa', 
                rencana_pinjam as 'Jumlah Hari Sewa', 
                kelebihan_pinjam as 'Telat Hari', 
                total_bayar AS 'Total Bayar',
                ket_user AS 'Keterangan Customer' 
                FROM penyewaan JOIN locker ON penyewaan.id_locker = locker.id
                JOIN users ON penyewaan.id_user = users.id"
        db.Query(stmt)

        Return db.Fetch()
    End Function

    Public Function FetchAllRentDataByUserId(userId As Integer) As DataTable
        stmt = "SELECT locker.lokasi as 'Nama Loker', 
                tanggal_sewa as 'Tanggal Sewa', 
                CASE WHEN tanggal_kembali IS NULL THEN 'Belum diambil' 
                WHEN tanggal_kembali IS NOT NULL THEN tanggal_kembali
                END AS 'Tanggal Kembali', 
                bayar_sebelum_pinjam as 'Bayar Saat Sewa', 
                rencana_pinjam as 'Jumlah Hari Sewa', 
                kelebihan_pinjam as 'Telat Hari', 
                total_bayar AS 'Total Bayar',
                ket_user AS 'Keterangan Customer' 
                FROM penyewaan 
                JOIN locker ON penyewaan.id_locker = locker.id 
                WHERE penyewaan.tanggal_kembali IS NULL AND penyewaan.id_user = @id_user"
        db.Query(stmt)
        db.Bind("id_user", "number", userId)

        Return db.Fetch()
    End Function

    Public Function RemoveRentData(id As Integer)
        'lockerId = locker_model.GetLockerId(lockerName)
        stmt = "DELETE FROM penyewaan 
                WHERE id = @id"
        db.Query(stmt)
        db.Bind("id", "number", id)
        'db.Bind("locker", "number", lockerId)
        'db.Bind("tglSewa", "text", tglSewa.ToString("yyyy/MM/dd"))
        Return db.Execute()
    End Function

    Public Function GetRentDataByLockerName(lockerName As String, tglSewa As Date) As DataTable
        lockerId = locker_model.GetLockerId(lockerName)
        stmt = "SELECT locker.lokasi, 
                rencana_pinjam, 
                DATE_FORMAT(tanggal_sewa, '%e %M %Y') as 'Tanggal Sewa',
                bayar_sebelum_pinjam,
                kelebihan_pinjam,
                jenis_ukuran.biaya,
                total_bayar
                FROM penyewaan 
                JOIN locker ON penyewaan.id_locker = locker.id 
                JOIN jenis_ukuran ON locker.id_ukuran = jenis_ukuran.id
                WHERE id_locker = @id_locker AND tanggal_sewa = @tglSewa"
        db.Query(stmt)
        db.Bind("id_locker", "number", lockerId)
        db.Bind("tglSewa", "text", tglSewa.ToString("yyyy/MM/dd"))
        Return db.Fetch()
    End Function

    Public Function UpdateRentDataAfterReturn(lockerName As String, tglSewa As String, tglKembali As String, telat As Integer, total As Integer)
        lockerId = locker_model.GetLockerId(lockerName)
        stmt = "UPDATE penyewaan SET 
                tanggal_kembali = @tglKembali, 
                kelebihan_pinjam = @telatHari, 
                total_bayar = @totalBayar 
                WHERE id_locker = @idLoker AND tanggal_sewa = @tglSewa"
        db.Query(stmt)
        db.Bind("tglKembali", "text", tglKembali)
        db.Bind("telatHari", "number", telat)
        db.Bind("totalBayar", "number", total)
        db.Bind("idLoker", "number", lockerId)
        db.Bind("tglSewa", "date", tglSewa)
        Return db.Execute()
    End Function
End Class
