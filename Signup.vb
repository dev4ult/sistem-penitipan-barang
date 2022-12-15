Imports System.ComponentModel

Public Class Signup
    Private user_model As User_model

    Private username As String
    Private email As String
    Private password As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        user_model = New User_model
    End Sub

    Private Sub BTNSignUp_Click(sender As Object, e As EventArgs) Handles BTNSignUp.Click
        username = TXTUsername.Text
        email = TXTEmail.Text
        password = TXTPassword.Text

        If username = "" Or email = "" Or password = "" Then
            MessageBox.Show("Input tidak bisa bersifat kosong")
        ElseIf user_model.ValidateSignUp(username, email, password) Then
            MessageBox.Show("Berhasil menambahkan user baru")
        End If
    End Sub
End Class
