Public Class Sewa_Model
    Private db As Database
    Public Sub New()
        db = New Database()
    End Sub

    Public Function getDataJenisTempat() As List(Of String)
        Dim stmt = "SELECT jt.namaTempat FROM locker l
                    JOIN jenis_tempat jt
                    ON l.id_tempat = jt.id
                    GROUP BY l.id_tempat"
        db.Query(stmt)
        Dim namaTempat As New List(Of String)
        Dim sqlRead = db.Fetch()
        While sqlRead.Read
            namaTempat.Add(sqlRead.GetString(0).ToString())
        End While

        'MsgBox(namaTempat.Count())
        sqlRead.Close()

        db.closeConn()
        Return namaTempat
    End Function
End Class
