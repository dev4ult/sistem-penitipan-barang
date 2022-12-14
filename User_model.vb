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
End Class
