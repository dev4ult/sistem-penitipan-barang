﻿Imports Google.Protobuf.WellKnownTypes

Public Class RentListForm

    Private selectedLocker As String
    Private rent_model As Rent_model
    Private selectedIdPenyewaan As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        rent_model = New Rent_model()

        ReloadRentData()
    End Sub

    Public Property GSSelectedIdPenyewaan() As Integer
        Get
            Return selectedIdPenyewaan
        End Get
        Set(value As Integer)
            selectedIdPenyewaan = value
        End Set
    End Property

    Public Sub ReloadRentData()
        DGV_DataSewa.DataSource = rent_model.FetchAllRentData()
    End Sub

    Private Sub BTNHapusSewa_Click(sender As Object, e As EventArgs) Handles BTNHapusSewa.Click
        If Not selectedIdPenyewaan = -1 Then
            RemoveRentData.LblRemoveLockerName.Text = selectedLocker
            'RemoveRentData.SetTanggalSewa = selectedTanggalSewa
            RemoveRentData.Show()
        End If
    End Sub

    Private Sub DGV_DataSewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_DataSewa.CellClick
        If Not e.RowIndex = -1 Then
            Dim selectedRow = DGV_DataSewa.Rows(e.RowIndex)
            selectedLocker = selectedRow.Cells(1).Value
            'selectedTanggalSewa = Date.Parse(selectedRow.Cells(2).Value)
            selectedIdPenyewaan = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub BTNKembali_Click(sender As Object, e As EventArgs) Handles BTNKembali.Click
        AdminMenu.Show()
        Me.Close()
    End Sub

End Class