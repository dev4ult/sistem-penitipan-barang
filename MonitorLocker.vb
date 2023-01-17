Public Class MonitorLocker

    Private locker_model As Locker_model
    Private selectedLocker As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        locker_model = New Locker_model

        selectedLocker = ""
        ReloadDataGridLocker()
    End Sub

    Public Property GSSelectedLocker() As String
        Get
            Return selectedLocker
        End Get
        Set(value As String)
            selectedLocker = value
        End Set
    End Property

    Private Sub BTNTambahLoker_Click(sender As Object, e As EventArgs) Handles BTNTambahLoker.Click
        AddLocker.Show()
    End Sub

    Private Sub BTNUbahStatus_Click(sender As Object, e As EventArgs) Handles BTNUbahStatus.Click
        If selectedLocker = "" Then
            MessageBox.Show("Pilih locker terlebih dahulu")
        Else
            UpdateLockerStatus.Show()
        End If
    End Sub

    Private Sub BTNHapusLoker_Click(sender As Object, e As EventArgs) Handles BTNHapusLoker.Click
        If selectedLocker = "" Then
            MessageBox.Show("Pilih locker terlebih dahulu")
        Else
            DeleteLocker.Show()
        End If
    End Sub

    Public Sub ReloadDataGridLocker()
        DataGridLocker.DataSource = locker_model.FetchAllLocker()
    End Sub

    Private Sub DataGridLocker_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridLocker.CellClick
        If Not e.RowIndex = -1 Then
            Dim dataRows = DataGridLocker.Rows(e.RowIndex)
            selectedLocker = dataRows.Cells(0).Value
        End If
    End Sub

    Private Sub BTNKembali_Click(sender As Object, e As EventArgs) Handles BTNKembali.Click
        AdminMenu.Show()
        Me.Close()
    End Sub
End Class