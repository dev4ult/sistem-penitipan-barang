Public Class Jenis_Locker

    Private ukuran As String
    Private biaya As Integer

    'Getter & Setter 
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
End Class