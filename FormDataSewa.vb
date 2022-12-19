Public Class FormDataSewa
    Private sewa_model As Sewa_model
    Private selectedLocker As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sewa_model = New Sewa_model()
        reloadRentData()
    End Sub

    Public Sub reloadRentData()
        DGV_DataSewa.DataSource = sewa_model.getAllRentData()
    End Sub

    Private Sub FormDataSewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        reloadRentData()
    End Sub

    Private Sub DGV_DataSewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_DataSewa.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGV_DataSewa.Rows(index)

        selectedLocker = selectedRow.Cells(0).Value
    End Sub

    Private Sub BtnHapusDataSewa_Click(sender As Object, e As EventArgs) Handles BtnHapusDataSewa.Click
        RemoveRentData.LblRemoveLockerName.Text = selectedLocker
        RemoveRentData.Show()
    End Sub

    Private Sub BtnTambahDataSewa_Click(sender As Object, e As EventArgs) Handles BtnTambahDataSewa.Click
        SewaLocker.Show()
    End Sub
End Class