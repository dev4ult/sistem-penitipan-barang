Public Class Login
    Private user_model As User_model
    Private userId As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        user_model = New User_model()
    End Sub

    Public ReadOnly Property GetUserId() As Integer
        Get
            Return userId
        End Get
    End Property

    Public Sub SetFlashMessage(msg As String)
        LBFMError.Text = msg
        LBFMError.Visible = True
    End Sub

    Private Sub BTNLogin_Click(sender As Object, e As EventArgs) Handles BTNLogin.Click
        Dim umail = TXTUmail.Text
        Dim password = TXTPassword.Text

        If umail = "" Or password = "" Then
            SetFlashMessage("Input tidak boleh bersifat kosong")
        Else
            If user_model.ValidateLogin(umail, password, "users") Then
                userId = user_model.GetUserId(umail)
                MainMenu.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub LinkLBSignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLBSignup.LinkClicked
        Signup.Show()
        Me.Close()
    End Sub

    Private Sub LinkLBAdmin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLBAdmin.LinkClicked
        LoginAdmin.show()
        Me.Close()
    End Sub

End Class