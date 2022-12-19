Public Class RemoveRentData
    Private sewa_model As Sewa_model
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sewa_model = New Sewa_model()
    End Sub

    Private Sub BtnRemoveLockerName_Click(sender As Object, e As EventArgs) Handles BtnRemoveLockerName.Click
        sewa_model.GS_Status_Locker = "Kosong"
        Dim status_locker As String = sewa_model.GS_Status_Locker()
        If sewa_model.removeRentData(LblRemoveLockerName.Text) And sewa_model.updateStatusLocker(LblRemoveLockerName.Text, status_locker) Then
            MsgBox("Berhasil dihapus", MsgBoxStyle.Information, "Sukses")
            Me.Close()
        Else
            MsgBox("Ada kesalahan", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub BtnCancelRemove_Click(sender As Object, e As EventArgs) Handles BtnCancelRemove.Click
        Me.Close()
        FormDataSewa.Show()
    End Sub
End Class