<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJenisLocker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataKoleksiJenisLocker = New System.Windows.Forms.DataGridView()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.LblJenisLocker = New System.Windows.Forms.Label()
        CType(Me.DataKoleksiJenisLocker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataKoleksiJenisLocker
        '
        Me.DataKoleksiJenisLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataKoleksiJenisLocker.Location = New System.Drawing.Point(26, 58)
        Me.DataKoleksiJenisLocker.Name = "DataKoleksiJenisLocker"
        Me.DataKoleksiJenisLocker.Size = New System.Drawing.Size(705, 363)
        Me.DataKoleksiJenisLocker.TabIndex = 0
        '
        'BtnCreate
        '
        Me.BtnCreate.Location = New System.Drawing.Point(433, 437)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(97, 33)
        Me.BtnCreate.TabIndex = 1
        Me.BtnCreate.Text = "Tambah"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(536, 437)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(97, 33)
        Me.BtnUpdate.TabIndex = 2
        Me.BtnUpdate.Text = "Ubah"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(639, 437)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(92, 33)
        Me.BtnDelete.TabIndex = 3
        Me.BtnDelete.Text = "Hapus"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'LblJenisLocker
        '
        Me.LblJenisLocker.AutoSize = True
        Me.LblJenisLocker.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisLocker.Location = New System.Drawing.Point(21, 18)
        Me.LblJenisLocker.Name = "LblJenisLocker"
        Me.LblJenisLocker.Size = New System.Drawing.Size(194, 26)
        Me.LblJenisLocker.TabIndex = 4
        Me.LblJenisLocker.Text = "Data List Jenis Locker"
        '
        'FormJenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 487)
        Me.Controls.Add(Me.LblJenisLocker)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.DataKoleksiJenisLocker)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormJenisLocker"
        Me.Text = "Data Jenis Locker"
        CType(Me.DataKoleksiJenisLocker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataKoleksiJenisLocker As DataGridView
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents LblJenisLocker As Label
End Class
