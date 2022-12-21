Public Class LoginAdmin
    Private user_model As User_model

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        user_model = New User_model()
    End Sub

    Public Sub SetFlashMessage(msg As String)
        LBFMError.Text = msg
        LBFMError.Visible = True
    End Sub

    Private Sub LinkLBCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLBCustomer.LinkClicked
        Login.Show()
        Me.Close()
    End Sub

    Private Sub BTNLogin_Click(sender As Object, e As EventArgs) Handles BTNLogin.Click
        Dim umail = TXTUmail.Text
        Dim password = TXTPassword.Text

        If umail = "" Or password = "" Then
            SetFlashMessage("Input tidak boleh bersifat kosong")
        Else
            If user_model.ValidateLogin(umail, password, "admins") Then
                AdminMenu.Show()
                Me.Close()
            End If
        End If

    End Sub

End Class