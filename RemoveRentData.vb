Public Class RemoveRentData
    Private sewa_model As Sewa_model
    Private tanggalSewa As Date
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sewa_model = New Sewa_model()
    End Sub

    Private Sub BtnRemoveLockerName_Click(sender As Object, e As EventArgs) Handles BtnRemoveLockerName.Click
        sewa_model.GS_Status_Locker = "Kosong"
        Dim status_locker As String = sewa_model.GS_Status_Locker()
        If sewa_model.RemoveRentData(LblRemoveLockerName.Text, tanggalSewa) And sewa_model.UpdateStatusLocker(LblRemoveLockerName.Text, status_locker) Then
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

    'Getter dan Setter
    Public WriteOnly Property SetTanggalSewa() As Date
        Set(value As Date)
            tanggalSewa = value
        End Set
    End Property
End Class