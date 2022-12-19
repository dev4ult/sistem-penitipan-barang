Public Class TambahJenisLocker

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        FormJenisLocker.jenisLocker.UkuranJenisLockerProperty = TxtUkuran.Text
        FormJenisLocker.jenisLocker.BiayaJenisLockerProperty = TxtBiaya.Text

        FormJenisLocker.jenisLocker.AddDataJenisLocker(FormJenisLocker.jenisLocker.UkuranJenisLockerProperty,
                                                       FormJenisLocker.jenisLocker.BiayaJenisLockerProperty)

        FormJenisLocker.Show()
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FormJenisLocker.Show()
        Me.Close()
    End Sub

    Private Sub TxtBiaya_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBiaya.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Hanya dapat mengisi dengan Angka")
        End If
    End Sub
End Class