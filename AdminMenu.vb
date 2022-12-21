Public Class AdminMenu
    Private Sub BTNFormMonitorLoker_Click(sender As Object, e As EventArgs) Handles BTNFormMonitorLoker.Click
        MonitorLocker.Show()
        Me.Close()
    End Sub

    Private Sub BTNMonitorJenisLoker_Click(sender As Object, e As EventArgs) Handles BTNMonitorJenisLoker.Click
        FormJenisLocker.Show()
        Me.Close()
    End Sub

    Private Sub BTNDataPenyewaan_Click(sender As Object, e As EventArgs) Handles BTNDataPenyewaan.Click
        FormListDataPenyewaan.show()
        Me.Close()
    End Sub
End Class