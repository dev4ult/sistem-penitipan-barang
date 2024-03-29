﻿Imports System.Threading

Public Class AddLocker
    Private locker_model As Locker_model

    Private ukuran As String
    Private lokasi As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        locker_model = New Locker_model()
        ukuran = ""
        lokasi = ""

        ReloadSizeList()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If ukuran = "" Or lokasi = "" Then
            MessageBox.Show("Input tidak boleh bersifat kosong!")
        Else
            If locker_model.InsertNewLocker(ukuran, lokasi) Then
                MessageBox.Show("Berhasil menambahkan loker baru")
                MonitorLocker.ReloadDataGridLocker()
            End If
        End If
    End Sub

    Private Sub CBukuran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBukuran.SelectedIndexChanged
        ukuran = CBukuran.SelectedItem
        lblharga.Text = "Rp." & locker_model.GetLockerCost(ukuran)
    End Sub

    Private Sub CBLokasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBLokasi.SelectedIndexChanged
        lokasi = CBLokasi.SelectedItem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub ReloadSizeList()
        CBukuran.Items.Clear()
        For Each dJT In locker_model.FetchAllLockerTypes().Rows
            CBukuran.Items.Add(dJT(0))
        Next
    End Sub
End Class