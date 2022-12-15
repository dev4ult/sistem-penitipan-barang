Public Class Login
    Private user_model As New User_model

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Private Sub BTNLogin_Click(sender As Object, e As EventArgs) Handles BTNLogin.Click
        Dim umail = TXTUmail.Text
        Dim password = TXTPassword.Text

        If umail = "" Or password = "" Then
            MessageBox.Show("Input tidak bersifat kosong")
        Else
            If user_model.ValidateLogin(umail, password) Then
                MessageBox.Show("Login berhasil")
            End If
        End If
    End Sub
End Class