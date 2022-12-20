Public Class UpdateJenisLocker

    Private locker_model As Locker_model
    Private ukuranLama As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        locker_model = New Locker_model

        ukuranLama = FormJenisLocker.GSUkuran()
        TxtUkuran.Text = ukuranLama

        TxtBiaya.Text = FormJenisLocker.GSBiaya()
        TxtInfoKet.Text = FormJenisLocker.GSInfoKet()

    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim ukuran As String = TxtUkuran.Text
        Dim biaya As Integer = Integer.Parse(TxtBiaya.Text)
        Dim infoKet As String = TxtInfoKet.Text

        If locker_model.ValidateFormUpdateLockerType(ukuran, biaya, infoKet, ukuranLama) Then
            FormJenisLocker.ReloadDataTableDatabase()
            FormJenisLocker.Show()
            Me.Close()
        End If
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