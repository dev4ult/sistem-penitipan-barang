Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text
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

    Public Function IsNameOrEmailExist(ByVal username As String, ByVal email As String) As Boolean
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

    Public Function EncryptPassword(password As String) As String
        Dim bytes = New SHA256Managed().ComputeHash(UTF8.GetBytes(password))

        Dim stringBuilder As New StringBuilder()

        For Each b In bytes
            stringBuilder.Append(b.ToString("x2").ToLower())
        Next

        Return stringBuilder.ToString()
    End Function

    Public Function ValidateSignUp(username As String, email As String, password As String) As Boolean
        'Cek jika username sudah terpakai
        If IsNameOrEmailExist(username, email) Then
            MessageBox.Show("Gagal! Username atau email sudah teregistrasi")
            Return False
        End If

        'Cek jika email tidak valid
        If Not IsEmail(email) Then
            MessageBox.Show("Gagal! Email tidak valid")
            Return False
        End If

        password = EncryptPassword(password)

        'Cek jika insert berhasil
        If InsertNewUser(username, email, password) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class