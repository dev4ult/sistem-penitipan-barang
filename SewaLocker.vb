
Public Class SewaLocker
    Private sewa_model As Sewa_model

    Private ukuran As String
    Private lokasiLoker As String
    Private lamaSewa As Integer
    Private totalBiaya As Integer
    Private keteranganIsiLocker As String
    Private waktuBayar As String

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
        LblNamaLocker.Text = ""

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
        lokasiLoker = LsbLockerTersedia.SelectedItem()
        LblNamaLocker.Text = lokasiLoker
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
        keteranganIsiLocker = RTBKetUser.Text
        sewa_model.GS_Status_Locker = "Terisi"
        Dim statusLocker As String = sewa_model.GS_Status_Locker()

        If RBSekarang.Checked() Then
            waktuBayar = "Yes"
        ElseIf RBNanti.Checked() Then
            waktuBayar = "No"
        End If

        'Validasi Form Isiannya

        If validationOfFormFill() IsNot Nothing Then
            MsgBox(validationOfFormFill(), MsgBoxStyle.Critical, "Kesalahan")
        Else
            If sewa_model.ValidateNewRentData(lokasiLoker, lamaSewa, waktuBayar,
                                          totalBiaya, keteranganIsiLocker, statusLocker) Then
                MessageBox.Show("Berhasil menambah data sewa")
            End If
            'Reset Isian Form
            resetFormFill()
        End If


    End Sub

    Private Sub NUDLamaSewa_ValueChanged(sender As Object, e As EventArgs) Handles NUDLamaSewa.ValueChanged
        lamaSewa = NUDLamaSewa.Value
        LblLamaSewa.Text = lamaSewa
        totalBiaya = lamaSewa * sewa_model.GetLockerCost(ukuran)
        LblTotalBiaya.Text = totalBiaya
    End Sub


    Private Sub resetFormFill()
        CBUkuranLocker.Text = "-- Pilih Ukuran --"
        LsbLockerTersedia.Items.Clear()
        RTBKetUser.Clear()
        NUDLamaSewa.Value = 0
        LblNamaLocker.Text = ""
        LblLamaSewa.Text = ""
        LblJumlahKomentar.Text = 50
        LblBiayaPerJam.Text = 0
        LblKetUkuran.Text = "Ket."
        LblTotalBiaya.Text = 0
        RBNanti.Checked = False
        RBSekarang.Checked = True
    End Sub

    Public Function validationOfFormFill()
        Dim infoKesalahan As String

        If ukuran Is Nothing Then
            infoKesalahan = "Harap Isi Ukuran Locker"
            CBUkuranLocker.Select()
        ElseIf lamaSewa = 0 Then
            infoKesalahan = "Harap Isi Jumlah Hari Sewa"
            NUDLamaSewa.Select()
        ElseIf lokasiLoker Is Nothing Then
            infoKesalahan = "Harap Pilih Lokasi Lokernya yaa"
        ElseIf keteranganIsiLocker.Length = 0 Then
            infoKesalahan = "Harap Isi Dekripsi Barang Anda"
            RTBKetUser.Select()
        ElseIf waktuBayar Is Nothing Then
            infoKesalahan = "Harap Pilih Waktu Bayar Loker"
        End If

        Return infoKesalahan
    End Function
End Class
