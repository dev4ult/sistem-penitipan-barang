
Public Class SewaLocker
    Private sewa_model As Sewa_model

    Private ukuran As String
    Private lokasiLoker As String
    Private lamaSewa As Integer
    Private totalBiaya As Integer
    Private keteranganIsiLocker As String
    Private waktuBayar As Boolean

    Dim str As String = ""
    Private panjangKarakter As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sewa_model = New Sewa_model()

        ReloadSizeList()
        panjangKarakter = LblJumlahKomentar.Text
    End Sub

    Public Sub ReloadSizeList()
        CBUkuranLocker.Items.Clear()
        For Each dJT In sewa_model.FetchAllLockerSize()
            CBUkuranLocker.Items.Add(dJT)
        Next
    End Sub

    Private Sub CBUkuranLocker_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBUkuranLocker.SelectedValueChanged
        LsbLockerTersedia.Items.Clear()
        ukuran = CBUkuranLocker.SelectedItem()

        LblKetUkuran.Text = "Ket : " & sewa_model.GetLockerDetail(ukuran)

        LblBiayaPerJam.Text = sewa_model.GetLockerCost(ukuran)

        LblLamaSewa.Text = NUDLamaSewa.Value
        totalBiaya = NUDLamaSewa.Value * sewa_model.GetLockerCost(ukuran)
        LblTotalBiaya.Text = totalBiaya

        For Each locker In sewa_model.GetAvailableLocker(ukuran)
            LsbLockerTersedia.Items.Add(locker)
        Next
    End Sub

    Private Sub LsbLockerTersedia_SelectedValueChanged(sender As Object, e As EventArgs) Handles LsbLockerTersedia.SelectedValueChanged
        LblNamaLocker.Text = LsbLockerTersedia.SelectedItem
    End Sub

    Private Sub RTBKetUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RTBKetUser.KeyPress
        If RTBKetUser.Text.Length < 50 Then
            If e.KeyChar = Chr(Keys.Back) And panjangKarakter < 50 Then
                panjangKarakter += 1
            ElseIf Not e.KeyChar = Chr(Keys.Back) And panjangKarakter > 0 Then
                panjangKarakter -= 1
            End If
            LblJumlahKomentar.Text = panjangKarakter
        ElseIf e.KeyChar <> ControlChars.Back And panjangKarakter = 0 Then
            e.Handled = True
            LblJumlahKomentar.Text = 0
            MsgBox("Maaf sudah lebih dari 50 Karakter", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub BtnYesSewa_Click(sender As Object, e As EventArgs) Handles BtnYesSewa.Click
        lokasiLoker = LblNamaLocker.Text
        lamaSewa = Integer.Parse(LblLamaSewa.Text)
        keteranganIsiLocker = RTBKetUser.Text

        If sewa_model.ValidateNewRentData(lokasiLoker, lamaSewa, waktuBayar,
                                          totalBiaya, keteranganIsiLocker) Then
            MessageBox.Show("berhasil menambah data sewa")
        End If
    End Sub

    Private Sub NUDLamaSewa_ValueChanged(sender As Object, e As EventArgs) Handles NUDLamaSewa.ValueChanged
        LblLamaSewa.Text = NUDLamaSewa.Value
        totalBiaya = NUDLamaSewa.Value * sewa_model.GetLockerCost(ukuran)
        LblTotalBiaya.Text = totalBiaya
    End Sub

    Private Sub RBSekarang_CheckedChanged(sender As Object, e As EventArgs) Handles RBSekarang.CheckedChanged
        waktuBayar = True
    End Sub

    Private Sub RBNanti_CheckedChanged(sender As Object, e As EventArgs) Handles RBNanti.CheckedChanged
        waktuBayar = False
    End Sub
End Class
