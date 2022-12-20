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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTambahDataSewa = New System.Windows.Forms.Button()
        Me.BtnHapusDataSewa = New System.Windows.Forms.Button()
        Me.BtnFormReturn = New System.Windows.Forms.Button()
        CType(Me.DGV_DataSewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_DataSewa
        '
        Me.DGV_DataSewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DataSewa.Location = New System.Drawing.Point(12, 118)
        Me.DGV_DataSewa.Name = "DGV_DataSewa"
        Me.DGV_DataSewa.RowHeadersWidth = 51
        Me.DGV_DataSewa.RowTemplate.Height = 24
        Me.DGV_DataSewa.Size = New System.Drawing.Size(1101, 187)
        Me.DGV_DataSewa.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List Data Sewa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnTambahDataSewa
        '
        Me.BtnTambahDataSewa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnTambahDataSewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnTambahDataSewa.Location = New System.Drawing.Point(528, 478)
        Me.BtnTambahDataSewa.Name = "BtnTambahDataSewa"
        Me.BtnTambahDataSewa.Size = New System.Drawing.Size(191, 55)
        Me.BtnTambahDataSewa.TabIndex = 32
        Me.BtnTambahDataSewa.Text = "Tambah Data"
        Me.BtnTambahDataSewa.UseVisualStyleBackColor = True
        '
        'BtnHapusDataSewa
        '
        Me.BtnHapusDataSewa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnHapusDataSewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnHapusDataSewa.Location = New System.Drawing.Point(922, 478)
        Me.BtnHapusDataSewa.Name = "BtnHapusDataSewa"
        Me.BtnHapusDataSewa.Size = New System.Drawing.Size(191, 55)
        Me.BtnHapusDataSewa.TabIndex = 34
        Me.BtnHapusDataSewa.Text = "Hapus Data"
        Me.BtnHapusDataSewa.UseVisualStyleBackColor = True
        '
        'BtnFormReturn
        '
        Me.BtnFormReturn.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnFormReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnFormReturn.Location = New System.Drawing.Point(725, 478)
        Me.BtnFormReturn.Name = "BtnFormReturn"
        Me.BtnFormReturn.Size = New System.Drawing.Size(191, 55)
        Me.BtnFormReturn.TabIndex = 35
        Me.BtnFormReturn.Text = "Kembali Form"
        Me.BtnFormReturn.UseVisualStyleBackColor = True
        '
        'FormDataSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 545)
        Me.Controls.Add(Me.BtnFormReturn)
        Me.Controls.Add(Me.BtnHapusDataSewa)
        Me.Controls.Add(Me.BtnTambahDataSewa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_DataSewa)
        Me.Name = "FormDataSewa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDataSewa"
        CType(Me.DGV_DataSewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_DataSewa As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTambahDataSewa As Button
    Friend WithEvents BtnHapusDataSewa As Button
    Friend WithEvents BtnFormReturn As Button
End Class
