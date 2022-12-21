Public Class FormDataSewa
    Private sewa_model As Sewa_model
    Private selectedLocker As String
    Private selectedTanggalSewa As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sewa_model = New Sewa_model()
        ReloadRentData()
    End Sub

    Public Sub ReloadRentData()
        DGV_DataSewa.DataSource = sewa_model.GetAllRentData()
    End Sub

    Private Sub FormDataSewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadRentData()
    End Sub

    Private Sub DGV_DataSewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_DataSewa.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGV_DataSewa.Rows(index)

        selectedLocker = selectedRow.Cells(0).Value
        selectedTanggalSewa = selectedRow.Cells(1).Value
        'MsgBox(selectedTanggalSewa)
    End Sub

    Private Sub BtnHapusDataSewa_Click(sender As Object, e As EventArgs) Handles BtnHapusDataSewa.Click
        If selectedTanggalSewa IsNot Nothing And selectedLocker IsNot Nothing Then
            RemoveRentData.LblRemoveLockerName.Text = selectedLocker
            RemoveRentData.SetTanggalSewa = selectedTanggalSewa
            RemoveRentData.Show()
        Else
            MsgBox("Tolong pilih data loker dengan benar", MsgBoxStyle.Critical, "Kesalahan")
        End If

    End Sub

    Private Sub BtnTambahDataSewa_Click(sender As Object, e As EventArgs) Handles BtnTambahDataSewa.Click
        SewaLocker.Show()
    End Sub

    Private Sub BtnFormReturn_Click(sender As Object, e As EventArgs) Handles BtnFormReturn.Click
        If selectedTanggalSewa Is Nothing And selectedLocker Is Nothing Then
            MsgBox("Tolong pilih data loker dengan benar", MsgBoxStyle.Critical, "Kesalahan")
        Else
            Dim dataLocker As DataTable = sewa_model.GetRentDataByLockerName(selectedLocker, selectedTanggalSewa)
            'MsgBox(dataLocker.Rows(0)(0))
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
            RentReturn.DTPTanggalKembali.Value = Date.Parse(dataLocker.Rows(0)(2)).AddDays(dataLocker.Rows(0)(1) + dataLocker.Rows(0)(4))
            RentReturn.GSReturnDateBeforeChange = Date.Parse(dataLocker.Rows(0)(2)).AddDays(dataLocker.Rows(0)(1))
            RentReturn.GSBiayaPerUkuran = dataLocker.Rows(0)(5)
            RentReturn.Show()
        End If

    End Sub
End Class