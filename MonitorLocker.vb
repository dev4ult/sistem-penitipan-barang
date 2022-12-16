Public Class MonitorLocker


    Public Shared database As Database

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub ReloadDataTableDatabase()


    End Sub


    Private Sub MonitorLocker_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ReloadDataTableDatabase()
    End Sub

    Private Sub btntambahlocker_Click(sender As Object, e As EventArgs) Handles btntambahlocker.Click
        Dim tambah = New TambahLocker
        tambah.Show()
    End Sub

    Private Sub btnhapuslocker_Click(sender As Object, e As EventArgs) Handles btnhapuslocker.Click
        Dim hapus = New HapusLocker
        hapus.Show()

    End Sub
End Class