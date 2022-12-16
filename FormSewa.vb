Imports Mysqlx.XDevAPI.Common

Public Class FormSewa
    Private sewa_model As Sewa_Model
    Private panjangKarakter As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sewa_model = New Sewa_Model()
        panjangKarakter = LblJumlahKomentar.Text
    End Sub

    Private Sub FormSewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        sewa_model = New Sewa_Model()
        CBUkuranLocker.Items.Clear()
        For Each dJT In sewa_model.getDataUkuranLocker()
            CBUkuranLocker.Items.Add(dJT)
        Next
        'Dim table As DataTable = GetTable()

        'Dim str As String = "A-001"
        'Dim arrStr = str.Split("-")
        'Console.WriteLine(arrStr(0))
        'Console.WriteLine(arrStr(1) + 10)
        'Console.WriteLine(Chr(65))
        'Console.WriteLine(Chr(66))
        'Console.WriteLine(Chr(67))
        'Console.WriteLine(Chr(90))
        'Console.WriteLine("ROWS: {0}", "A-" & (table.Rows(table.Rows.Count - 1)(0) + 10).ToString())
    End Sub


    Private Sub CBUkuranLocker_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBUkuranLocker.SelectedValueChanged
        LsbLockerTersedia.Items.Clear()
        Dim selectedItem As String = CBUkuranLocker.SelectedItem()
        LblBiayaPerJam.Text = sewa_model.getBiayaLokerPerUkuran(selectedItem)
        For Each gNT In sewa_model.getLockerTersedia(selectedItem)
            LsbLockerTersedia.Items.Add(gNT)
        Next
        'MsgBox("ok")
    End Sub

    Private Sub LsbLockerTersedia_SelectedValueChanged(sender As Object, e As EventArgs) Handles LsbLockerTersedia.SelectedValueChanged
        LblNamaLocker.Text = LsbLockerTersedia.SelectedItem()

    End Sub

    Private Sub RTBKetUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RTBKetUser.KeyPress

        If RTBKetUser.Text.Length < 50 Then
            If e.KeyChar = Chr(Keys.Back) And panjangKarakter < 50 Then
                panjangKarakter += 1
            ElseIf Not e.KeyChar = Chr(Keys.Back) And panjangKarakter > 0 Then
                panjangKarakter -= 1
            End If
            LblJumlahKomentar.Text = panjangKarakter
        ElseIf e.KeyChar <> ControlChars.Back And panjangKarakter = 0 Then
            e.Handled = True
            LblJumlahKomentar.Text = 0
            MsgBox("Maaf sudah lebih dari 50 Karakter", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub BtnYesSewa_Click(sender As Object, e As EventArgs) Handles BtnYesSewa.Click
        MsgBox(RTBKetUser.Text.Length)
    End Sub


End Class
