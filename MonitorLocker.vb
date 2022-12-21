﻿Public Class MonitorLocker

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

    Private Sub btntambahlocker_Click(sender As Object, e As EventArgs) Handles btntambahlocker.Click
        TambahLocker.Show()
    End Sub

    Private Sub btnhapuslocker_Click(sender As Object, e As EventArgs) Handles btnhapuslocker.Click
        If selectedLocker = "" Then
            MessageBox.Show("Pilih locker terlebih dahulu")
        Else
            HapusLocker.Show()
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

    Private Sub btnupdatestatus_Click(sender As Object, e As EventArgs) Handles btnupdatestatus.Click
        If selectedLocker = "" Then
            MessageBox.Show("Pilih locker terlebih dahulu")
        Else
            UpdateStatusLocker.Show()
        End If
    End Sub

    Private Sub MonitorLocker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class