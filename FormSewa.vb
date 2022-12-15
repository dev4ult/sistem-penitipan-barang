Imports Mysqlx.XDevAPI.Common

Public Class FormSewa
    Private sewa_model As Sewa_Model

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sewa_model = New Sewa_Model()
    End Sub

    Private Sub FormSewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        sewa_model = New Sewa_Model()
        For Each dJT In sewa_model.getDataJenisTempat()
            CBJenisTempat.Items.Add(dJT)
        Next
        sewa_model.getDataJenisTempat.Clear()
    End Sub

    Private Sub CBJenisTempat_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBJenisTempat.SelectedValueChanged
        Dim selectedItem As String = CBJenisTempat.SelectedItem()
        For Each gNT In sewa_model.getNamaTempat(selectedItem)
            CBNamaTempat.Items.Add(gNT)
        Next
        sewa_model.getNamaTempat(selectedItem).Clear()
        'MsgBox("ok")
    End Sub
End Class
