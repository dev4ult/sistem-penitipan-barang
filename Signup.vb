﻿Imports System.ComponentModel

Public Class Signup
    Private user_model As User_model

    Private username As String
    Private email As String
    Private password As String
    Private passwordConfirmation As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        user_model = New User_model
    End Sub

    Public Sub SetFlashMessage(msg As String)
        LBFMError.Text = msg
        LBFMError.Visible = True
    End Sub

    Private Sub BTNSignUp_Click(sender As Object, e As EventArgs)
        username = TXTUsername.Text
        email = TXTEmail.Text
        password = TXTPassword.Text
        passwordConfirmation = TXTPasswordConfirmation.Text

        If username = "" Or email = "" Or password = "" Then
            SetFlashMessage("Input tidak boleh bersifat kosong")
        ElseIf user_model.ValidateSignUp(username, email, password, passwordConfirmation) Then
            MessageBox.Show("Berhasil menambahkan user baru")
        End If
    End Sub

    Private Sub LinkLBLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLBLogin.LinkClicked
        Login.Show()
    End Sub
End Class