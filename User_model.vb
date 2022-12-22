Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.Encoding

Public Class User_model
    Private db As Database

    Public Sub New()
        db = New Database()
    End Sub

    Private Function InsertNewUser(username As String, email As String, password As String) As Integer
        db.Query("INSERT INTO users VALUES ('',@username, @email, @password)")

        db.Bind("username", "text", username)
        db.Bind("email", "text", email)
        db.Bind("password", "text", password)

        Return db.Execute()
    End Function

    Private Function IsEmail(email As String) As Boolean
        Try
            Dim address = New MailAddress(email)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function IsNameOrEmailExist(username As String, email As String) As Boolean
        db.Query("SELECT * FROM users WHERE username = @username OR email = @email")

        db.Bind("username", "text", username)
        db.Bind("email", "text", email)

        Dim tempDTB = db.Fetch()
        If tempDTB.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function EncryptPassword(password As String) As String
        Dim bytes = New SHA256Managed().ComputeHash(UTF8.GetBytes(password))

        Dim stringBuilder As New StringBuilder()

        For Each b In bytes
            stringBuilder.Append(b.ToString("x2").ToLower())
        Next

        Return stringBuilder.ToString()
    End Function

    Public Function GetUserId(umail As String) As Integer
        db.Query("SELECT id FROM users WHERE username = @username OR email = @email")
        db.Bind("username", "text", umail)
        db.Bind("email", "text", umail)

        Return db.Fetch()(0)(0)
    End Function

    Public Function GetUsername(id As Integer) As String
        db.Query("SELECT username FROM users WHERE id = @id")
        db.Bind("id", "number", id)

        Return db.Fetch()(0)(0)
    End Function

    Public Function ValidateLogin(umail As String, password As String, table As String) As Boolean
        db.Query("SELECT * FROM " & table & " WHERE 
                    username = @username OR 
                    email = @email")

        db.Bind("username", "text", umail)
        db.Bind("email", "text", umail)

        Dim nameDTB = db.Fetch()

        db.Query("SELECT * FROM " & table & " WHERE password = @password")
        db.Bind("password", "text", EncryptPassword(password))

        Dim passDTB = db.Fetch()

        If nameDTB.Rows.Count > 0 And passDTB.Rows.Count > 0 Then
            Return True
        ElseIf table = "users" Then
            Login.SetFlashMessage("Gagal! Username / email atau password salah")
        Else
            LoginAdmin.SetFlashMessage("Gagal! Username / email atau password salah")
        End If
        Return False
    End Function

    Public Function ValidateSignUp(username As String, email As String, password As String, passwordConfirmation As String) As Boolean

        'Cek jika konfirmasi password tidak sama
        If Not password = passwordConfirmation Then
            Signup.SetFlashMessage("Gagal! Password konfirmasi tidak sama")
            Return False
        End If

        If Not IsEmail(email) Then
            Signup.SetFlashMessage("Gagal! Email tidak valid")
            Return False
        End If

        'Cek jika username sudah terpakai
        If IsNameOrEmailExist(username, email) Then
            Signup.SetFlashMessage("Gagal! Username atau email sudah teregistrasi")
            Return False
        End If

        password = EncryptPassword(password)

        'Cek jika insert berhasil
        If InsertNewUser(username, email, password) > 0 Then
            Return True
        Else
            Signup.SetFlashMessage("Gagal! Telah terjadi kesalahan, Silahkan registrasi ulang")
            Return False
        End If
    End Function

End Class