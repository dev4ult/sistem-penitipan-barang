Public Class MonitorLocker


    Public Shared database As Database

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub ReloadDataTableDatabase()

        DataGridLocker.DataSource = database.GetDataBaseLocker()


    End Sub


    Private Sub MonitorLocker_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ReloadDataTableDatabase()
    End Sub
End Class