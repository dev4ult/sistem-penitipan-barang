Public Class UpdateStatusLocker
    Private locker_model As Locker_model
    Private namaLoker As String
    Private status As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        locker_model = New Locker_model

        namaLoker = MonitorLocker.GSSelectedLocker
        MonitorLocker.GSSelectedLocker = ""
        status = locker_model.GetLockerStatus(namaLoker)

        If status = "Terisi" Then
            RBTerisi.Checked = True
        Else
            RBKosong.Checked = True
        End If
    End Sub

    Private Sub RBTerisi_CheckedChanged(sender As Object, e As EventArgs) Handles RBTerisi.CheckedChanged
        status = "Terisi"
    End Sub

    Private Sub RBKosong_CheckedChanged(sender As Object, e As EventArgs) Handles RBKosong.CheckedChanged
        status = "Kosong"
    End Sub

    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        If locker_model.UpdateLockerStatus(namaLoker, status) Then
            Me.Close()
            MonitorLocker.ReloadDataGridLocker()
        End If
    End Sub

End Class