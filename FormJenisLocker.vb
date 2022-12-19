Public Class FormJenisLocker

    Public Shared jenisLocker As Jenis_Locker

    Dim selectedRow As DataGridViewRow
    Public Shared selectedTableKoleksi
    Private Shared selectedTableKoleksiNama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        jenisLocker = New Jenis_Locker
        ReloadDataTableDatabase()
    End Sub

    Private Sub FormJenisLocker_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataKoleksiJenisLocker.DataSource = jenisLocker.GetDataJenisLocker()
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
        HapusJenisLocker.Show()
        Me.Hide()
    End Sub
End Class
