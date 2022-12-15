Public Class FormSewa
    Private sewa_model As Sewa_Model

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sewa_model = New Sewa_Model()
    End Sub

    Private Sub FormSewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        For Each dJT In sewa_model.getDataJenisTempat()
            CBJenisTempat.Items.Add(dJT)
        Next

    End Sub
End Class
