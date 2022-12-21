Public Class RentReturn
    Private sewa_model As Sewa_model
    Private totalBiayadanDenda As Integer
    Private selisihHariDenganTglKembaliAwal As Integer
    Private tanggal_kembali_denda As Date
    Private tanggal_kembali_awal As Date
    Private biayaPerUkuran As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sewa_model = New Sewa_model()
        tanggal_kembali_denda = tanggal_kembali_awal

    End Sub

    Private Sub DTPTanggalKembali_TextChanged(sender As Object, e As EventArgs) Handles DTPTanggalKembali.TextChanged
        tanggal_kembali_denda = DTPTanggalKembali.Value
        selisihHariDenganTglKembaliAwal = Integer.Parse(DateDiff(DateInterval.Day, tanggal_kembali_awal, tanggal_kembali_denda).ToString())
        If tanggal_kembali_denda < Date.Parse(LblTanggalSewa.Text) Then
            MsgBox("Tanggal kembali tidak kurang dari tanggal sewa", MsgBoxStyle.Critical, "Kesalahan")
            DTPTanggalKembali.Select()
        ElseIf selisihHariDenganTglKembaliAwal <= 0 And tanggal_kembali_denda > Date.Parse(LblTanggalSewa.Text) Then
            LblTelatHari.Text = 0
            LblDenda.Text = 0
            LblTotaldanDenda.Text = totalBiayadanDenda + Integer.Parse(selisihHariDenganTglKembaliAwal) * biayaPerUkuran
        ElseIf selisihHariDenganTglKembaliAwal > 0 Then
            LblTelatHari.Text = selisihHariDenganTglKembaliAwal
            LblDenda.Text = selisihHariDenganTglKembaliAwal * 10
            LblTotaldanDenda.Text = totalBiayadanDenda + Integer.Parse(LblDenda.Text)
        End If


    End Sub

    Private Sub BtnYesKembali_Click(sender As Object, e As EventArgs) Handles BtnYesKembali.Click
        Dim tanggalSewa As Date = Convert.ToDateTime(LblTanggalSewa.Text)
        tanggal_kembali_denda = DTPTanggalKembali.Value
        If sewa_model.UpdateRentDataAfterReturn(LblLockerName.Text, tanggalSewa.ToString("yyyy/MM/dd"), tanggal_kembali_denda.ToString("yyyy/MM/dd"), selisihHariDenganTglKembaliAwal, Integer.Parse(LblTotaldanDenda.Text)) Then
            If sewa_model.UpdateStatusLocker(LblLockerName.Text, "Kosong") Then
                'sewa_model.RemoveRentData(LblLockerName.Text)
                MsgBox("Berhasil dikembalikan", MsgBoxStyle.Information, "Sukses")
                Me.Close()
            End If
        End If
    End Sub



    'Getter Dan Setter
    Public Property GSReturnDateBeforeChange() As Date
        Get
            Return tanggal_kembali_awal
        End Get
        Set(value As Date)
            tanggal_kembali_awal = value
        End Set
    End Property


    Public Property GSTotalBiayaDanDenda() As Integer
        Get
            Return totalBiayadanDenda
        End Get
        Set(value As Integer)
            totalBiayadanDenda = value
        End Set
    End Property

    Public Property GSBiayaPerUkuran() As Integer
        Get
            Return biayaPerUkuran
        End Get
        Set(value As Integer)
            biayaPerUkuran = value
        End Set
    End Property

    Private Sub BtnCancelKembali_Click(sender As Object, e As EventArgs) Handles BtnCancelKembali.Click
        Me.Close()
        FormDataSewa.Show()
    End Sub
End Class