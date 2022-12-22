Public Class RentReturn
    Private sewa_model As Rent_model
    Private locker_model As Locker_model

    Private totalBiayadanDenda As Integer

    Private tanggalSewa As DateTime
    Private tanggalKembali As DateTime

    Private rencanaPinjam As Integer
    Private intvSewaToSekarang As Integer
    Private selisihHariDenganRencanaPinjam As Integer

    Private biayaPerUkuran As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sewa_model = New Rent_model()
        locker_model = New Locker_model()
    End Sub

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

    Private Sub RentReturn_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        tanggalSewa = MainMenu.GetTanggalSewa()
        tanggalKembali = MainMenu.GetTanggalPengembalian()

        rencanaPinjam = (tanggalKembali - tanggalSewa).TotalDays
        intvSewaToSekarang = (DateTime.Now.Date - tanggalSewa).TotalDays

        selisihHariDenganRencanaPinjam = intvSewaToSekarang - rencanaPinjam

        If selisihHariDenganRencanaPinjam <= 0 Then
            LblTelatHari.Text = 0
            LblDenda.Text = 0
            LblTotaldanDenda.Text = 0
        Else
            LblTelatHari.Text = selisihHariDenganRencanaPinjam
            LblDenda.Text = selisihHariDenganRencanaPinjam * 10
            LblTotaldanDenda.Text = totalBiayadanDenda + Integer.Parse(LblDenda.Text)
        End If
    End Sub

    Private Sub BtnYesKembali_Click(sender As Object, e As EventArgs) Handles BtnYesKembali.Click
        If sewa_model.UpdateRentDataAfterReturn(LblLockerName.Text, tanggalSewa.ToString("yyyy/MM/dd"),
                                                tanggalKembali.ToString("yyyy/MM/dd"), selisihHariDenganRencanaPinjam,
                                                Integer.Parse(LblTotaldanDenda.Text)) Then
            If locker_model.UpdateLockerStatus(LblLockerName.Text, "Kosong") Then
                MainMenu.ReloadRentData()
                MsgBox("Berhasil dikembalikan", MsgBoxStyle.Information, "Sukses")
                Me.Close()
            End If
        End If
    End Sub

    'Getter Dan Setter

    Private Sub BtnCancelKembali_Click(sender As Object, e As EventArgs) Handles BtnCancelKembali.Click
        MainMenu.Show()
        Me.Close()
    End Sub
End Class