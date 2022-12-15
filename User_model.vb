Public Class User_model
    Private db As Database

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

    Public Sub InsertNewUser(username As String, email As String, password As String)
        db.Query("INSERT INTO users(username, email, password) VALUES (@username, @email, @password)")

        db.Bind("username", "text", username)
        db.Bind("email", "text", email)
        db.Bind("password", "text", password)
        db.closeConn()
        db.Execute()
    End Sub
End Class
