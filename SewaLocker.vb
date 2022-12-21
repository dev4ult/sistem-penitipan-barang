
Public Class SewaLocker
    Private sewa_model As Sewa_model
    Private locker_model As Locker_model

    Private namaLoker As String
    Private ukuran As String
    Private lokasiLoker As String
    Private lamaSewa As Integer
    Private totalBiaya As Integer
    Private keteranganIsiLocker As String

    Dim str As String = ""
    Private panjangKarakter As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sewa_model = New Sewa_model()
        locker_model = New Locker_model()

        ReloadSizeList()
        panjangKarakter = LblJumlahKomentar.Text
    End Sub

    Public Sub ReloadSizeList()
        CBUkuranLocker.Items.Clear()
        For Each dJT In locker_model.FetchAllLockerTypes().Rows
            CBUkuranLocker.Items.Add(dJT(0))
        Next
    End Sub

    Private Sub CBUkuranLocker_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBUkuranLocker.SelectedValueChanged
        LsbLockerTersedia.Items.Clear()
        ukuran = CBUkuranLocker.SelectedItem()
        LblNamaLocker.Text = ""

        LblKetUkuran.Text = "Ket : " & locker_model.GetLockerDetail(ukuran)

        LblBiayaPerJam.Text = locker_model.GetLockerCost(ukuran)

        LblLamaSewa.Text = NUDLamaSewa.Value
        totalBiaya = NUDLamaSewa.Value * locker_model.GetLockerCost(ukuran)
        LblTotalBiaya.Text = totalBiaya

        For Each locker In locker_model.GetAvailableLocker(ukuran)
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

        If Not validationOfFormFill() = "" Then
            MsgBox(validationOfFormFill(), MsgBoxStyle.Critical, "Kesalahan")
        Else
            If sewa_model.ValidateNewRentData(lokasiLoker, lamaSewa,
                                          totalBiaya, keteranganIsiLocker) Then
                locker_model.UpdateLockerStatus(lokasiLoker, "Terisi")
                MainMenu.ReloadRentData()
            End If
            'Reset Isian Form
            resetFormFill()
        End If
    End Sub

    Private Sub NUDLamaSewa_ValueChanged(sender As Object, e As EventArgs) Handles NUDLamaSewa.ValueChanged
        lamaSewa = NUDLamaSewa.Value
        LblLamaSewa.Text = lamaSewa
        totalBiaya = lamaSewa * locker_model.GetLockerCost(ukuran)
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
    End Sub

    Public Function validationOfFormFill()
        Dim infoKesalahan As String = ""

        If ukuran = "" Then
            infoKesalahan = "Harap Isi Ukuran Locker"
            CBUkuranLocker.Select()
        ElseIf lamaSewa = 0 Then
            infoKesalahan = "Harap Isi Jumlah Hari Sewa"
            NUDLamaSewa.Select()
        ElseIf lokasiLoker = "" Then
            infoKesalahan = "Harap Pilih Lokasi Lokernya yaa"
        ElseIf keteranganIsiLocker.Length = 0 Then
            infoKesalahan = "Harap Isi Dekripsi Barang Anda"
            RTBKetUser.Select()
        End If

        Return infoKesalahan
    End Function

    Private Sub LsbLockerTersedia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsbLockerTersedia.SelectedIndexChanged
        namaLoker = LsbLockerTersedia.SelectedItem
        LblNamaLoker.Text = namaLoker
    End Sub

    Private Sub BtnNoSewa_Click(sender As Object, e As EventArgs) Handles BtnNoSewa.Click
        Me.Close()
    End Sub
End Class
