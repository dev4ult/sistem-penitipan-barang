Public Class RemoveRentData
    Private sewa_model As Sewa_model
    Private locker_model As Locker_model
    Private tanggalSewa As Date

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sewa_model = New Sewa_model()
        locker_model = New Locker_model()
    End Sub

    Private Sub BtnRemoveLockerName_Click(sender As Object, e As EventArgs) Handles BtnRemoveLockerName.Click
        If sewa_model.RemoveRentData(FormListDataPenyewaan.GSSelectedIdPenyewaan) And locker_model.UpdateLockerStatus(LblRemoveLockerName.Text, "Kosong") Then
            MsgBox("Berhasil dihapus", MsgBoxStyle.Information, "Sukses")
            'FormListDataPenyewaan.SetSelectedLocker = ""
            FormListDataPenyewaan.ReloadRentData()
            FormListDataPenyewaan.GSSelectedIdPenyewaan = -1
            Me.Close()
        Else
            MsgBox("Ada kesalahan", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub BtnCancelRemove_Click(sender As Object, e As EventArgs) Handles BtnCancelRemove.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    'Getter dan Setter
    Public WriteOnly Property SetTanggalSewa() As Date
        Set(value As Date)
            tanggalSewa = value
        End Set
    End Property
End Class