Public Class FormJenisLocker

    Public Shared jenisKoleksi As Jenis_Locker
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        jenisKoleksi = New Jenis_Locker
    End Sub

    Private Sub FormJenisLocker_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataKoleksiJenisLocker.DataSource = jenisKoleksi.GetDataJenisLocker()
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        TambahJenisLocker.Show()
        Me.Hide()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        UpdateJenisLocker.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        HapusJenisLocker.Show()
        Me.Hide()
    End Sub
End Class
