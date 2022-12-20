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
        Me.btntambahlocker = New System.Windows.Forms.Button()
        Me.btnupdatestatus = New System.Windows.Forms.Button()
        Me.btnhapuslocker = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridLocker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridLocker
        '
        Me.DataGridLocker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridLocker.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridLocker.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridLocker.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridLocker.Location = New System.Drawing.Point(25, 77)
        Me.DataGridLocker.Name = "DataGridLocker"
        Me.DataGridLocker.RowHeadersWidth = 51
        Me.DataGridLocker.Size = New System.Drawing.Size(353, 406)
        Me.DataGridLocker.TabIndex = 0
        '
        'btntambahlocker
        '
        Me.btntambahlocker.BackColor = System.Drawing.Color.White
        Me.btntambahlocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambahlocker.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambahlocker.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btntambahlocker.Location = New System.Drawing.Point(6, 19)
        Me.btntambahlocker.Name = "btntambahlocker"
        Me.btntambahlocker.Size = New System.Drawing.Size(117, 32)
        Me.btntambahlocker.TabIndex = 1
        Me.btntambahlocker.Text = "Tambah Locker"
        Me.btntambahlocker.UseVisualStyleBackColor = False
        '
        'btnupdatestatus
        '
        Me.btnupdatestatus.BackColor = System.Drawing.Color.White
        Me.btnupdatestatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdatestatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdatestatus.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnupdatestatus.Location = New System.Drawing.Point(6, 57)
        Me.btnupdatestatus.Name = "btnupdatestatus"
        Me.btnupdatestatus.Size = New System.Drawing.Size(117, 32)
        Me.btnupdatestatus.TabIndex = 2
        Me.btnupdatestatus.Text = "Update Status"
        Me.btnupdatestatus.UseVisualStyleBackColor = False
        '
        'btnhapuslocker
        '
        Me.btnhapuslocker.BackColor = System.Drawing.Color.White
        Me.btnhapuslocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapuslocker.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapuslocker.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnhapuslocker.Location = New System.Drawing.Point(6, 95)
        Me.btnhapuslocker.Name = "btnhapuslocker"
        Me.btnhapuslocker.Size = New System.Drawing.Size(117, 32)
        Me.btnhapuslocker.TabIndex = 3
        Me.btnhapuslocker.Text = "Hapus Locker"
        Me.btnhapuslocker.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(4, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "# Data Locker"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(25, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 46)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.DataGridLocker)
        Me.Panel2.Location = New System.Drawing.Point(22, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(536, 504)
        Me.Panel2.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btntambahlocker)
        Me.GroupBox1.Controls.Add(Me.btnupdatestatus)
        Me.GroupBox1.Controls.Add(Me.btnhapuslocker)
        Me.GroupBox1.Location = New System.Drawing.Point(384, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 142)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(390, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MonitorLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(578, 537)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "MonitorLocker"
        Me.Text = "MonitorLocker"
        CType(Me.DataGridLocker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridLocker As DataGridView
    Friend WithEvents btntambahlocker As Button
    Friend WithEvents btnupdatestatus As Button
    Friend WithEvents btnhapuslocker As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
