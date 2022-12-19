Public Class HapusJenisLocker

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ValueUkuran.Text = FormJenisLocker.jenisLocker.UkuranJenisLockerProperty
        ValueBiaya.Text = FormJenisLocker.jenisLocker.BiayaJenisLockerProperty
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FormJenisLocker.Show()
        Me.Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        FormJenisLocker.jenisLocker.DeleteDataJenisLocker(FormJenisLocker.selectedTableKoleksi)
        FormJenisLocker.Show()
        Me.Close()
    End Sub
End Class