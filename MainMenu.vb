

Public Class MainMenu
    Private rent_model As Rent_model
    Private user_model As User_model

    Private selectedLocker As String
    Private selectedTanggalSewa As Date
    Private selectedTanggalPengembalian As Date

    Private userId As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        rent_model = New Rent_model()
        user_model = New User_model()

        userId = Login.GetUserId()
        LBUsername.Text = user_model.GetUsername(userId)

        selectedLocker = ""

        ReloadRentData()
    End Sub

    Public ReadOnly Property GetTanggalPengembalian() As Date
        Get
            Return selectedTanggalPengembalian
        End Get
    End Property

    Public ReadOnly Property GetTanggalSewa() As Date
        Get
            Return selectedTanggalSewa
        End Get
    End Property

    Public ReadOnly Property GetUserId() As Integer
        Get
            Return userId
        End Get
    End Property

    Public Sub ReloadRentData()
        DGV_DataSewa.DataSource = rent_model.FetchAllRentDataByUserId(userId)
    End Sub

    Private Sub DGV_DataSewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_DataSewa.CellClick
        If Not e.RowIndex = -1 Then
            Dim selectedRow = DGV_DataSewa.Rows(e.RowIndex)
            selectedLocker = selectedRow.Cells(0).Value
            selectedTanggalSewa = Date.Parse(selectedRow.Cells(1).Value)
        End If
    End Sub

    Private Sub BtnTambahDataSewa_Click(sender As Object, e As EventArgs) Handles BtnTambahDataSewa.Click
        SewaLocker.Show()
    End Sub

    Private Sub BtnFormReturn_Click(sender As Object, e As EventArgs) Handles BtnFormReturn.Click
        If Not selectedLocker = "" Then
            Dim dataLocker As DataTable = rent_model.GetRentDataByLockerName(selectedLocker, selectedTanggalSewa)

            RentReturn.LblLockerName.Text = dataLocker.Rows(0)(0)
            RentReturn.LblJmlHariPinjam.Text = dataLocker.Rows(0)(1)
            RentReturn.LblTanggalSewa.Text = dataLocker.Rows(0)(2)
            RentReturn.GSTotalBiayaDanDenda = dataLocker.Rows(0)(3)
            RentReturn.LblTelatHari.Text = dataLocker.Rows(0)(4)
            Dim denda As Integer = Integer.Parse(dataLocker.Rows(0)(4)) * 10

            If denda < 0 Then
                denda = 0
                RentReturn.LblTelatHari.Text = 0
            End If

            RentReturn.LblDenda.Text = denda
            RentReturn.LblTotaldanDenda.Text = dataLocker.Rows(0)(6)

            selectedTanggalPengembalian = Date.Parse(dataLocker.Rows(0)(2)).AddDays(dataLocker.Rows(0)(1))
            RentReturn.LblTglMaksPengembalian.Text = selectedTanggalPengembalian.ToString("dd MMMM yyyy")

            RentReturn.LBTanggalPengembalian.Text = DateTime.Now.ToString("dd MMMM yyyy")
            RentReturn.GSBiayaPerUkuran = dataLocker.Rows(0)(5)
            RentReturn.Show()
            selectedLocker = ""
        Else
            MsgBox("Pilih data penyewaan loker terlebih dahulu", MsgBoxStyle.Critical, "Kesalahan")
        End If
    End Sub

    Private Sub BTNLogout_Click(sender As Object, e As EventArgs) Handles BTNLogout.Click
        Login.Show()
        Me.Close()
    End Sub
End Class