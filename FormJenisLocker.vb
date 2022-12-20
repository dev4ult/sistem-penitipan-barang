Public Class FormJenisLocker

<<<<<<< HEAD
    Private locker_model As Locker_model
=======
    Private locker_model As Locker_Model
>>>>>>> origin/form-jenis-locker

    Private ukuran As String
    Private biaya As Integer
    Private infoKet As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
<<<<<<< HEAD
        locker_model = New Locker_model
=======
        locker_model = New Locker_Model
>>>>>>> origin/form-jenis-locker
        ReloadDataTableDatabase()
    End Sub

    Public Property GSUkuran() As String
        Get
            Return ukuran
        End Get
        Set(value As String)
            ukuran = value
        End Set
    End Property

    Public Property GSBiaya() As Integer
        Get
            Return biaya
        End Get
        Set(value As Integer)
            biaya = value
        End Set
    End Property

    Public Property GSInfoKet() As String
        Get
            Return infoKet
        End Get
        Set(value As String)
            infoKet = value
        End Set
    End Property

    Public Sub ReloadDataTableDatabase()
        DataKoleksiJenisLocker.DataSource = locker_model.FetchAllLockerTypes()
    End Sub

    Private Sub DataKoleksiJenisLocker_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataKoleksiJenisLocker.CellClick
        If Not e.RowIndex = -1 Then
            Dim dataRow = DataKoleksiJenisLocker.Rows(e.RowIndex)
            ukuran = dataRow.Cells(0).Value
            biaya = Integer.Parse(dataRow.Cells(1).Value)
            infoKet = dataRow.Cells(2).Value
        End If
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        TambahJenisLocker.Show()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If ukuran = "" Or biaya = 0 Or infoKet = "" Then
            MessageBox.Show("Silahkan pilih jenis loker terlebih dahulu")
        Else
            UpdateJenisLocker.Show()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If ukuran = "" Or biaya = 0 Or infoKet = "" Then
            MessageBox.Show("Silahkan pilih jenis loker terlebih dahulu")
        Else
            HapusJenisLocker.Show()
        End If
    End Sub
End Class