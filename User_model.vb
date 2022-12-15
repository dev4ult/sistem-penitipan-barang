Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text.Encoding

Public Class User_model
    Public Shared db As Database

    Public Sub New()
        db = New Database()
    End Sub

    Public Function GetAllUserAsDataTable() As DataTable
        db.Query("SELECT * FROM users")

        Dim list_user As New DataTable
        list_user.Load(db.Fetch())
        db.closeConn()
        Return list_user
    End Function
    Public Function InsertNewUser(username As String, email As String, password As String) As Integer
        db.Query("INSERT INTO users VALUES ('',@username, @email, @password)")

        db.Bind("username", "text", username)
        db.Bind("email", "text", email)
        db.Bind("password", "text", password)

        db.Execute()
        End Sub
End Class
