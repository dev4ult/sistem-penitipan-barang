Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text.Encoding

Public Class User_model
    Private db As Database

    Public Sub New()
        db = New Database()
    End Sub

    Public Function GetAllUserAsDataTable() As DataTable
        db.Query("SELECT * FROM users")

        Dim list_user As New DataTable
        list_user.Load(db.Fetch())

        Return list_user
    End Function
    Public Function InsertNewUser(username As String, email As String, password As String) As Integer
        db.Query("INSERT INTO users VALUES ('',@username, @email, @password)")

        db.Bind("username", "text", username)
        db.Bind("email", "text", email)
        db.Bind("password", "text", password)

        Return db.Execute()
    End Function

    Public Function IsEmail(email As String) As Boolean
        Try
            Dim address = New MailAddress(email)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function IsRowExist(field As String, value As String) As Boolean
        db.Query("SELECT * FROM users WHERE " & field & " = @value")

        db.Bind("value", "text", value)

        If db.Fetch().Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function HashPassword(password As String) As String
        Return New SHA256Managed().ComputeHash(UTF8.GetBytes(password)).ToString()
    End Function

    Public Function ValidateSignUp(username As String, email As String, password As String) As Boolean
        'Cek jika username sudah terpakai
        If IsRowExist("username", username) Then
            MessageBox.Show("Gagal! Username sudah teregistrasi")
            Return False
        End If

        'Cek jika email sudah terpakai
        If IsRowExist("email", email) Then
            MessageBox.Show("Gagal! Email sudah teregistrasi")
            Return False
        End If

        'Cek jika email tidak valid
        If Not IsEmail(email) Then
            MessageBox.Show("Gagal! Email tidak valid")
            Return False
        End If

        password = HashPassword(password)

        'Cek jika insert berhasil
        If InsertNewUser(username, email, password) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class