Public Class Jenis_Locker

    Private ukuran As String
    Private biaya As Integer

    Private db As Database

    Public Sub New()
        db = New Database()
    End Sub

    'Getter & Setter untuk Ukuran dan Biaya
    Public Property UkuranJenisLockerProperty() As String
        Get
            Return ukuran
        End Get
        Set(ByVal value As String)
            ukuran = value
        End Set
    End Property

    Public Property BiayaJenisLockerProperty() As Integer
        Get
            Return biaya
        End Get
        Set(ByVal value As Integer)
            biaya = value
        End Set
    End Property

    'Create Data
    Public Function AddDataJenisLocker(Ukuran As String, Biaya As Integer) As Integer
        db.Query("INSERT INTO jenis_ukuran VALUES ('', @ukuran, @biaya)")

        db.Bind("ukuran", "text", Ukuran)
        db.Bind("biaya", "number", Biaya)

        Return db.Execute()
    End Function

    Public Function GetDataJenisLocker()
        db.Query("SELECT id AS 'ID', ukuran AS 'Ukuran Locker', biaya AS 'Biaya Locker' FROM jenis_ukuran")

        Return db.Fetch()
    End Function

    'Select Data 
    Public Function GetDataJenisLockerByIdDatabase(id As Integer)
        db.Query("SELECT ukuran, biaya FROM jenis_ukuran WHERE id = @id")
        db.Bind("id", "number", id)

        If db.Fetch().Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Update Data
    Public Function UpdateDataJenisLocker(Ukuran As String, Biaya As Integer) As Integer
        db.Query("UPDATE jenis_ukuran SET ukuran= @ukuran, biaya= @biaya")

        db.Bind("ukuran", "text", Ukuran)
        db.Bind("biaya", "number", Biaya)

        Return db.Execute()
    End Function

    'Delete Data
    Public Function DeleteDataJenisLocker(id As Integer)
        db.Query("DELETE FROM jenis_ukuran WHERE id = @id")

        db.Bind("id", "number", id)

        Return db.Execute()
    End Function
End Class