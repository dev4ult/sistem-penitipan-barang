﻿Public Class AdminMenu
    Private Sub BTNFormMonitorLoker_Click(sender As Object, e As EventArgs) Handles BTNFormMonitorLoker.Click
        MonitorLocker.Show()
        Me.Close()
    End Sub

    Private Sub BTNMonitorJenisLoker_Click(sender As Object, e As EventArgs) Handles BTNMonitorJenisLoker.Click
        LockerTypeForm.Show()
        Me.Close()
    End Sub

    Private Sub BTNDataPenyewaan_Click(sender As Object, e As EventArgs) Handles BTNDataPenyewaan.Click
        RentListForm.Show()
        Me.Close()
    End Sub

    Private Sub BTNLogout_Click(sender As Object, e As EventArgs) Handles BTNLogout.Click
        LoginAdmin.Show()
        Me.Close()
    End Sub
End Class