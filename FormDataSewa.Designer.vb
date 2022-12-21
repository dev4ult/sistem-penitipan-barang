<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataSewa
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
        Me.DGV_DataSewa = New System.Windows.Forms.DataGridView()
        Me.BtnTambahDataSewa = New System.Windows.Forms.Button()
        Me.BtnHapusDataSewa = New System.Windows.Forms.Button()
        Me.BtnFormReturn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DGV_DataSewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_DataSewa
        '
        Me.DGV_DataSewa.AllowUserToAddRows = False
        Me.DGV_DataSewa.AllowUserToDeleteRows = False
        Me.DGV_DataSewa.BackgroundColor = System.Drawing.Color.White
        Me.DGV_DataSewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DataSewa.Location = New System.Drawing.Point(25, 100)
        Me.DGV_DataSewa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DGV_DataSewa.Name = "DGV_DataSewa"
        Me.DGV_DataSewa.ReadOnly = True
        Me.DGV_DataSewa.RowHeadersWidth = 51
        Me.DGV_DataSewa.RowTemplate.Height = 24
        Me.DGV_DataSewa.Size = New System.Drawing.Size(826, 345)
        Me.DGV_DataSewa.TabIndex = 0
        '
        'BtnTambahDataSewa
        '
        Me.BtnTambahDataSewa.BackColor = System.Drawing.Color.Black
        Me.BtnTambahDataSewa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnTambahDataSewa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahDataSewa.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnTambahDataSewa.ForeColor = System.Drawing.Color.White
        Me.BtnTambahDataSewa.Location = New System.Drawing.Point(25, 478)
        Me.BtnTambahDataSewa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnTambahDataSewa.Name = "BtnTambahDataSewa"
        Me.BtnTambahDataSewa.Size = New System.Drawing.Size(94, 33)
        Me.BtnTambahDataSewa.TabIndex = 32
        Me.BtnTambahDataSewa.Text = "TAMBAH"
        Me.BtnTambahDataSewa.UseVisualStyleBackColor = False
        '
        'BtnHapusDataSewa
        '
        Me.BtnHapusDataSewa.BackColor = System.Drawing.Color.Black
        Me.BtnHapusDataSewa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnHapusDataSewa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapusDataSewa.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnHapusDataSewa.ForeColor = System.Drawing.Color.White
        Me.BtnHapusDataSewa.Location = New System.Drawing.Point(134, 478)
        Me.BtnHapusDataSewa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnHapusDataSewa.Name = "BtnHapusDataSewa"
        Me.BtnHapusDataSewa.Size = New System.Drawing.Size(94, 33)
        Me.BtnHapusDataSewa.TabIndex = 34
        Me.BtnHapusDataSewa.Text = "HAPUS"
        Me.BtnHapusDataSewa.UseVisualStyleBackColor = False
        '
        'BtnFormReturn
        '
        Me.BtnFormReturn.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnFormReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormReturn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFormReturn.Location = New System.Drawing.Point(757, 478)
        Me.BtnFormReturn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnFormReturn.Name = "BtnFormReturn"
        Me.BtnFormReturn.Size = New System.Drawing.Size(94, 33)
        Me.BtnFormReturn.TabIndex = 35
        Me.BtnFormReturn.Text = "KEMBALI"
        Me.BtnFormReturn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(874, 72)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATA SEWA LOKER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DGV_DataSewa)
        Me.Panel1.Controls.Add(Me.BtnFormReturn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnHapusDataSewa)
        Me.Panel1.Controls.Add(Me.BtnTambahDataSewa)
        Me.Panel1.Location = New System.Drawing.Point(28, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(875, 543)
        Me.Panel1.TabIndex = 36
        '
        'FormDataSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(933, 600)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormDataSewa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDataSewa"
        CType(Me.DGV_DataSewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_DataSewa As DataGridView
    Friend WithEvents BtnTambahDataSewa As Button
    Friend WithEvents BtnHapusDataSewa As Button
    Friend WithEvents BtnFormReturn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
