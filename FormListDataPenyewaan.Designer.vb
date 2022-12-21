<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListDataPenyewaan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV_DataSewa = New System.Windows.Forms.DataGridView()
        Me.BTNKembali = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNHapusSewa = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_DataSewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DGV_DataSewa)
        Me.Panel1.Controls.Add(Me.BTNKembali)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BTNHapusSewa)
        Me.Panel1.Location = New System.Drawing.Point(24, 48)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1166, 658)
        Me.Panel1.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(964, 591)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 40)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "DIGILOKER"
        '
        'DGV_DataSewa
        '
        Me.DGV_DataSewa.AllowUserToAddRows = False
        Me.DGV_DataSewa.AllowUserToDeleteRows = False
        Me.DGV_DataSewa.BackgroundColor = System.Drawing.Color.White
        Me.DGV_DataSewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DataSewa.Location = New System.Drawing.Point(33, 132)
        Me.DGV_DataSewa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_DataSewa.Name = "DGV_DataSewa"
        Me.DGV_DataSewa.ReadOnly = True
        Me.DGV_DataSewa.RowHeadersWidth = 51
        Me.DGV_DataSewa.RowTemplate.Height = 24
        Me.DGV_DataSewa.Size = New System.Drawing.Size(1101, 425)
        Me.DGV_DataSewa.TabIndex = 0
        '
        'BTNKembali
        '
        Me.BTNKembali.BackColor = System.Drawing.Color.Black
        Me.BTNKembali.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BTNKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNKembali.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKembali.ForeColor = System.Drawing.Color.White
        Me.BTNKembali.Location = New System.Drawing.Point(33, 18)
        Me.BTNKembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNKembali.Name = "BTNKembali"
        Me.BTNKembali.Size = New System.Drawing.Size(144, 44)
        Me.BTNKembali.TabIndex = 35
        Me.BTNKembali.Text = "KEMBALI"
        Me.BTNKembali.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(739, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.Label1.Size = New System.Drawing.Size(395, 89)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LIST DATA PENYEWAAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNHapusSewa
        '
        Me.BTNHapusSewa.BackColor = System.Drawing.Color.Black
        Me.BTNHapusSewa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BTNHapusSewa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNHapusSewa.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BTNHapusSewa.ForeColor = System.Drawing.Color.White
        Me.BTNHapusSewa.Location = New System.Drawing.Point(33, 588)
        Me.BTNHapusSewa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNHapusSewa.Name = "BTNHapusSewa"
        Me.BTNHapusSewa.Size = New System.Drawing.Size(156, 44)
        Me.BTNHapusSewa.TabIndex = 32
        Me.BTNHapusSewa.Text = "HAPUS DATA"
        Me.BTNHapusSewa.UseVisualStyleBackColor = False
        '
        'FormListDataPenyewaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1217, 761)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormListDataPenyewaan"
        Me.Text = "FormListDataPenyewaan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV_DataSewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents DGV_DataSewa As DataGridView
    Friend WithEvents BTNKembali As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNHapusSewa As Button
End Class
