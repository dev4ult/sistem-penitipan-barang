Public Class Sewa_Model
    Private stmt As String
    Private result As New List(Of String)
    Dim sqlRead
    Public Sub New()
        User_model.db = New Database()
    End Sub

    Public Function getDataJenisTempat() As List(Of String)
        stmt = "SELECT jt.namaTempat FROM locker l
                    JOIN jenis_tempat jt
                    ON l.id_tempat = jt.id
                    GROUP BY l.id_tempat"
        User_model.db.Query(stmt)

        sqlRead = User_model.db.Fetch()
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
        End While

        'MsgBox(namaTempat.Count())
        sqlRead.Close()

        User_model.db.closeConn()
        Return result
    End Function

    Public Function getNamaTempat(jenisTempat As String) As List(Of String)
        result.Clear()
        stmt = "SELECT DISTINCT l.lokasi FROM locker l
                JOIN jenis_tempat jt ON l.id_tempat = jt.id
                WHERE jt.namaTempat =@namaTempat"
        User_model.db.Query(stmt)
        User_model.db.Bind("namaTempat", "text", jenisTempat)
        sqlRead = User_model.db.Fetch()
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
        End While
        sqlRead.Close()

        User_model.db.closeConn()
        Return result
    End Function
End Class
