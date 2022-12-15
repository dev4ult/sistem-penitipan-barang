Public Class Sewa_Model
    Private stmt As String
    Private result As New List(Of String)
    Dim sqlRead As New DataTable
    Private db As Database
    Public Sub New()
        db = New Database()
    End Sub

    Public Function getDataUkuranLocker() As List(Of String)
        result.Clear()
        stmt = "SELECT DISTINCT jk.ukuran FROM locker l
                JOIN jenis_ukuran jk
                ON l.id_ukuran = jk.id"
        db.Query(stmt)

        sqlRead = db.Fetch()
        For Each ukLocker As DataRow In sqlRead.Rows
            result.Add(ukLocker.Field(Of String)(0))
        Next

        Return result
    End Function

    Public Function getLockerTersedia(ukuranLocker As String) As List(Of String)
        result.Clear()
        stmt = "SELECT l.lokasi FROM locker l
                JOIN jenis_ukuran jk
                ON l.id_ukuran = jk.id
                WHERE jk.ukuran = @ukuran
                AND l.status = 'Kosong'"
        db.Query(stmt)
        db.Bind("ukuran", "text", ukuranLocker)
        sqlRead = db.Fetch()
        For Each locker As DataRow In sqlRead.Rows
            result.Add(locker.Field(Of String)(0))
        Next

        Return result
    End Function
End Class
