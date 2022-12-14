Imports System.ComponentModel

Public Class Login
    Private user_model As User_model

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        user_model = New User_model
        DataGridView1.DataSource = user_model.GetAllUserAsDataTable

    End Sub


End Class
