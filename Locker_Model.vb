Public Class Locker_Model
    Private db As Database

    Public Sub New()
        db = New Database()
    End Sub
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