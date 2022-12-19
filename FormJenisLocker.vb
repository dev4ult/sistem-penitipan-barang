Public Class FormJenisLocker

    Public Shared jenisLocker As JLocker_Model

    Dim selectedRow As DataGridViewRow
    Public Shared selectedTableKoleksi
    Private Shared selectedTableKoleksiNama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        jenisLocker = New JLocker_Model
        ReloadDataTableDatabase()
    End Sub

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
        jenisLocker.UkuranJenisLockerProperty = selectedRow.Cells(1).Value
        jenisLocker.BiayaJenisLockerProperty = selectedRow.Cells(2).Value

        UpdateJenisLocker.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        jenisLocker.UkuranJenisLockerProperty = selectedRow.Cells(1).Value
        jenisLocker.BiayaJenisLockerProperty = selectedRow.Cells(2).Value

        HapusJenisLocker.Show()
        Me.Hide()
    End Sub
End Class
