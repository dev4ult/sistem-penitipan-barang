Public Class HapusLocker
    Private locker_model As Locker_model
    Private namaLoker As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        locker_model = New Locker_model
        namaLoker = MonitorLocker.selectedLocker
        MonitorLocker.selectedLocker = ""
        LBNamaLoker.Text = namaLoker
    End Sub

    Private Sub BTNKembali_Click(sender As Object, e As EventArgs) Handles BTNKembali.Click
        MonitorLocker.Show()
        Me.Close()
    End Sub

    Private Sub BTNHapus_Click(sender As Object, e As EventArgs) Handles BTNHapus.Click
        If locker_model.DeleteLockerByLocation(namaLoker) Then
            MonitorLocker.ReloadDataGridLocker()
            Me.Close()
        End If
    End Sub

End Class