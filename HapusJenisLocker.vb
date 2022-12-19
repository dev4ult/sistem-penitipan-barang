Public Class HapusJenisLocker

    Private locker_model As Locker_model

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        locker_model = New Locker_model

        LbValueUkuran.Text = FormJenisLocker.GSUkuran()
        LbValueBiaya.Text = "Rp." & FormJenisLocker.GSBiaya()
        LbValueInfoKet.Text = FormJenisLocker.GSInfoKet()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FormJenisLocker.Show()
        Me.Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim ukuran As String = FormJenisLocker.GSUkuran()

        If locker_model.DeleteLockerTypeBySize(ukuran) Then
            FormJenisLocker.ReloadDataTableDatabase()
            FormJenisLocker.Show()
            Me.Close()
        End If
    End Sub

End Class