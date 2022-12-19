Imports Google.Protobuf.WellKnownTypes

Public Class HapusJenisLocker

    Public Shared JLocker_Model As JLocker_Model
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        JLocker_Model = New JLocker_Model

        ValueUkuran.Text = FormJenisLocker.GSUkuran
        ValueBiaya.Text = FormJenisLocker.GSBiaya
        ValueInfoKet.Text = FormJenisLocker.GSInfo_Ket
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FormJenisLocker.Show()
        Me.Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        JLocker_Model.DeleteLockerType(FormJenisLocker.selectedTableKoleksi)
        FormJenisLocker.Show()
        Me.Close()
    End Sub
End Class