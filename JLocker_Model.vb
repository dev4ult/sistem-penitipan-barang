Public Class JLocker_Model
    Private db As Database

    Public Sub New()
        db = New Database()
    End Sub

    Public Function IsLockerTypeExist(ukuran As String) As String
        db.Query("SELECT ukuran WHERE ukuran = @ukuran")
        db.Bind("ukuran", "text", ukuran)

        Return db.Fetch()(0)(0)
    End Function

    'Insert Data
    Public Function InsertNewLockerType(Ukuran As String, Biaya As Integer, info_ket As String) As Integer
        db.Query("INSERT INTO jenis_ukuran VALUES ('', @ukuran, @biaya, @info_ket)")

        db.Bind("ukuran", "text", Ukuran)
        db.Bind("biaya", "number", Biaya)
        db.Bind("info_ket", "text", info_ket)

        Return db.Execute()
    End Function

    Public Function ValidateFormAddLockerTypes(Ukuran As String, Biaya As Integer, info_ket As String)
        If IsLockerTypeExist(Ukuran) Then
            Return False
        End If

        If InsertNewLockerType(Ukuran, Biaya, info_ket) Then
            Return True
        End If
    End Function

    Public Function FetchAllDataLeckerTypes()
        db.Query("SELECT id AS 'ID', ukuran AS 'Ukuran Locker', biaya AS 'Biaya Locker' FROM jenis_ukuran")

        Return db.Fetch()
    End Function

    'Select Data 
    Public Function GetDataLockerTypeById(id As Integer)
        db.Query("SELECT ukuran, biaya FROM jenis_ukuran WHERE id = @id")
        db.Bind("id", "number", id)

        Return db.Fetch()
    End Function

    'Update Data
    Public Function UpdateLockerType(Id As Integer, Ukuran As String, Biaya As Integer) As Integer
        db.Query("UPDATE jenis_ukuran SET ukuran= @ukuran, biaya= @biaya WHERE id= @id")

        db.Bind("id", "number", Id)
        db.Bind("ukuran", "text", Ukuran)
        db.Bind("biaya", "number", Biaya)

        Return db.Execute()
    End Function

    'Delete Data
    Public Function DeleteLockerType(id As Integer)
        db.Query("DELETE FROM jenis_ukuran WHERE id = @id")

        db.Bind("id", "number", id)

        Return db.Execute()
    End Function
End Class