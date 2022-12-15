Imports Mysqlx.XDevAPI.Common

Public Class FormSewa
    Private sewa_model As Sewa_Model

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sewa_model = New Sewa_Model()
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
        For Each gNT In sewa_model.getLockerTersedia(selectedItem)
            LsbLockerTersedia.Items.Add(gNT)
        Next
        'MsgBox("ok")
    End Sub
    Public Function GetTable() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create 3 typed columns in the DataTable.
        table.Columns.Add("Dosage", GetType(Integer))
        table.Columns.Add("Drug", GetType(String))
        table.Columns.Add("PatientID", GetType(String))

        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add(25, "Drug A", "10")
        table.Rows.Add(50, "Drug B", "50")
        table.Rows.Add(10, "Drug C", "51")
        table.Rows.Add(21, "Drug D", "52")
        table.Rows.Add(100, "Drug E", "11")
        Return table
    End Function

End Class
