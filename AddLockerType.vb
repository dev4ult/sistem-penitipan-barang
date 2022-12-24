Public Class AddLockerType

    Private locker_model As Locker_model

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        locker_model = New Locker_model
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim ukuran As String = TxtUkuran.Text
        Dim biaya As Integer = Integer.Parse(TxtBiaya.Text)
        Dim info_ket As String = TxtInfoKet.Text

        MessageBox.Show(ukuran)

        If locker_model.ValidateFormAddLockerType(ukuran, biaya, info_ket) Then
            LockerTypeForm.ReloadDataTableDatabase()
            LockerTypeForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        LockerTypeForm.Show()
        Me.Close()
    End Sub

    Private Sub TxtBiaya_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Hanya dapat mengisi dengan Angka")
        End If
    End Sub
End Class