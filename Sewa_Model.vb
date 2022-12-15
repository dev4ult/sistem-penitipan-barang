Public Class Sewa_Model
    Private stmt As String
    Private result As New List(Of String)
    Dim sqlRead
    Private db As Database
    Public Sub New()
        db = New Database()
    End Sub

    Public Function getDataJenisTempat() As List(Of String)
        stmt = "SELECT jt.namaTempat FROM locker l
                    JOIN jenis_tempat jt
                    ON l.id_tempat = jt.id
                    GROUP BY l.id_tempat"
        db.Query(stmt)

        sqlRead = db.Fetch()
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
        End While

        'MsgBox(namaTempat.Count())
        sqlRead.Close()
        Return result
    End Function

    Public Function getNamaTempat(jenisTempat As String) As List(Of String)
        result.Clear()
        stmt = "SELECT DISTINCT l.lokasi FROM locker l
                JOIN jenis_tempat jt ON l.id_tempat = jt.id
                WHERE jt.namaTempat =@namaTempat"
        db.Query(stmt)
        db.Bind("namaTempat", "text", jenisTempat)
        sqlRead = db.Fetch()
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
        End While
        sqlRead.Close()

        db.closeConn()
        Return result
    End Function
End Class
