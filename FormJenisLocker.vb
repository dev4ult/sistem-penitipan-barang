Imports Org.BouncyCastle.Asn1

Public Class FormJenisLocker

    Private ukuran As String
    Private biaya As Integer
    Private info_ket As String

    Public Shared JLocker_Model As JLocker_Model

    Dim selectedRow As DataGridViewRow
    Public Shared selectedTableKoleksi
    Private Shared selectedTableKoleksiNama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        JLocker_Model = New JLocker_Model
        ReloadDataTableDatabase()
    End Sub

    'Getter & Setter untuk Ukuran dan Biaya
    Public Property GSUkuran() As String
        Get
            Return ukuran
        End Get
        Set(ByVal value As String)
            ukuran = value
        End Set
    End Property

    Public Property GSBiaya() As Integer
        Get
            Return biaya
        End Get
        Set(ByVal value As Integer)
            biaya = value
        End Set
    End Property

    Public Property GSInfo_Ket() As String
        Get
            Return info_ket
        End Get
        Set(ByVal value As String)
            info_ket = value
        End Set
    End Property

    Private Sub ReloadDataTableDatabase()
        DataKoleksiJenisLocker.DataSource = jenisLocker.FetchAllDataLeckerTypes()
    End Sub

    Private Sub DataKoleksiJenisLocker_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataKoleksiJenisLocker.CellClick
        If e.RowIndex > -1 Then
            Dim index As Integer = e.RowIndex
            selectedRow = DataKoleksiJenisLocker.Rows(index)

            selectedTableKoleksi = selectedRow.Cells(0).Value
            selectedTableKoleksiNama = selectedRow.Cells(1).Value
        End If
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        TambahJenisLocker.Show()
        Me.Hide()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        GSUkuran = selectedRow.Cells(1).Value
        GSBBiaya = selectedRow.Cells(2).Value
        GSInfo_Ket = selectedRow.Cells(3).Value

        UpdateJenisLocker.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        GSUkuran = selectedRow.Cells(1).Value
        GSBBiaya = selectedRow.Cells(2).Value
        GSInfo_Ket = selectedRow.Cells(3).Value

        HapusJenisLocker.Show()
        Me.Hide()
    End Sub
End Class
