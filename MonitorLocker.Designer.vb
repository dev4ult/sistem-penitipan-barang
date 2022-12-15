<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonitorLocker
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
        Me.DataGridLocker = New System.Windows.Forms.DataGridView()
        Me.IdLocker = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaLocker = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ukuran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Biaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btntambahlocker = New System.Windows.Forms.Button()
        Me.btnupdatestatus = New System.Windows.Forms.Button()
        Me.btnhapuslocker = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridLocker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridLocker
        '
        Me.DataGridLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridLocker.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLocker, Me.NamaLocker, Me.Ukuran, Me.Biaya, Me.Lokasi, Me.Status})
        Me.DataGridLocker.Location = New System.Drawing.Point(17, 74)
        Me.DataGridLocker.Name = "DataGridLocker"
        Me.DataGridLocker.Size = New System.Drawing.Size(811, 280)
        Me.DataGridLocker.TabIndex = 0
        '
        'IdLocker
        '
        Me.IdLocker.HeaderText = "ID Locker"
        Me.IdLocker.Name = "IdLocker"
        Me.IdLocker.Width = 150
        '
        'NamaLocker
        '
        Me.NamaLocker.HeaderText = "NamaLocker"
        Me.NamaLocker.Name = "NamaLocker"
        Me.NamaLocker.Width = 150
        '
        'Ukuran
        '
        Me.Ukuran.HeaderText = "Ukuran"
        Me.Ukuran.Name = "Ukuran"
        Me.Ukuran.Width = 120
        '
        'Biaya
        '
        Me.Biaya.HeaderText = "Biaya"
        Me.Biaya.Name = "Biaya"
        Me.Biaya.Width = 120
        '
        'Lokasi
        '
        Me.Lokasi.HeaderText = "Lokasi"
        Me.Lokasi.Name = "Lokasi"
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.Width = 130
        '
        'btntambahlocker
        '
        Me.btntambahlocker.Location = New System.Drawing.Point(211, 467)
        Me.btntambahlocker.Name = "btntambahlocker"
        Me.btntambahlocker.Size = New System.Drawing.Size(100, 23)
        Me.btntambahlocker.TabIndex = 1
        Me.btntambahlocker.Text = "Tambah Locker"
        Me.btntambahlocker.UseVisualStyleBackColor = True
        '
        'btnupdatestatus
        '
        Me.btnupdatestatus.Location = New System.Drawing.Point(465, 467)
        Me.btnupdatestatus.Name = "btnupdatestatus"
        Me.btnupdatestatus.Size = New System.Drawing.Size(100, 23)
        Me.btnupdatestatus.TabIndex = 2
        Me.btnupdatestatus.Text = "Update Status"
        Me.btnupdatestatus.UseVisualStyleBackColor = True
        '
        'btnhapuslocker
        '
        Me.btnhapuslocker.Location = New System.Drawing.Point(335, 467)
        Me.btnhapuslocker.Name = "btnhapuslocker"
        Me.btnhapuslocker.Size = New System.Drawing.Size(100, 23)
        Me.btnhapuslocker.TabIndex = 3
        Me.btnhapuslocker.Text = "Hapus Locker"
        Me.btnhapuslocker.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Data Locker"
        '
        'MonitorLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 537)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnhapuslocker)
        Me.Controls.Add(Me.btnupdatestatus)
        Me.Controls.Add(Me.btntambahlocker)
        Me.Controls.Add(Me.DataGridLocker)
        Me.Name = "MonitorLocker"
        Me.Text = "MonitorLocker"
        CType(Me.DataGridLocker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridLocker As DataGridView
    Friend WithEvents IdLocker As DataGridViewTextBoxColumn
    Friend WithEvents NamaLocker As DataGridViewTextBoxColumn
    Friend WithEvents Ukuran As DataGridViewTextBoxColumn
    Friend WithEvents Biaya As DataGridViewTextBoxColumn
    Friend WithEvents Lokasi As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents btntambahlocker As Button
    Friend WithEvents btnupdatestatus As Button
    Friend WithEvents btnhapuslocker As Button
    Friend WithEvents Label1 As Label
End Class
