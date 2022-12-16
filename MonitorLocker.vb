Public Class MonitorLocker

    Private locker_model As Locker_model



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        locker_model = New Locker_model
        ReloadDataGridLocker()
    End Sub


    Private Sub btntambahlocker_Click(sender As Object, e As EventArgs) Handles btntambahlocker.Click
        Dim tambah = New TambahLocker
        tambah.Show()
    End Sub

    Private Sub btnhapuslocker_Click(sender As Object, e As EventArgs) Handles btnhapuslocker.Click
        Dim hapus = New HapusLocker
        hapus.Show()

    End Sub

    Public Sub ReloadDataGridLocker()
        DataGridLocker.DataSource = locker_model.FetchAllLocker()

    End Sub


End Class