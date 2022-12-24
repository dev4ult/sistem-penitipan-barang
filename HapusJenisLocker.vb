Public Class HapusJenisLocker

    Private locker_model As Locker_model

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        locker_model = New Locker_model

        LbValueUkuran.Text = LockerTypeForm.GSUkuran()
        LbValueBiaya.Text = "Rp." & LockerTypeForm.GSBiaya()
        LbValueKeterangan.Text = LockerTypeForm.GSInfoKet()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        LockerTypeForm.Show()
        Me.Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim ukuran As String = LockerTypeForm.GSUkuran()

        If locker_model.DeleteLockerTypeBySize(ukuran) Then
            LockerTypeForm.ReloadDataTableDatabase()
            LockerTypeForm.Show()
            Me.Close()
        End If
    End Sub
End Class