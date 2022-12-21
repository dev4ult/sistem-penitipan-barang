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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNKembali = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNTambahLoker = New System.Windows.Forms.Button()
        Me.BTNUbahStatus = New System.Windows.Forms.Button()
        Me.BTNHapusLoker = New System.Windows.Forms.Button()
        CType(Me.DataGridLocker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridLocker
        '
        Me.DataGridLocker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridLocker.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridLocker.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridLocker.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridLocker.Location = New System.Drawing.Point(22, 95)
        Me.DataGridLocker.Name = "DataGridLocker"
        Me.DataGridLocker.RowHeadersWidth = 51
        Me.DataGridLocker.Size = New System.Drawing.Size(353, 406)
        Me.DataGridLocker.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(571, 58)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "# LIST LOKER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BTNKembali)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DataGridLocker)
        Me.Panel2.Location = New System.Drawing.Point(22, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(622, 538)
        Me.Panel2.TabIndex = 6
        '
        'BTNKembali
        '
        Me.BTNKembali.BackColor = System.Drawing.Color.Black
        Me.BTNKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNKembali.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BTNKembali.ForeColor = System.Drawing.Color.White
        Me.BTNKembali.Location = New System.Drawing.Point(404, 318)
        Me.BTNKembali.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNKembali.Name = "BTNKembali"
        Me.BTNKembali.Size = New System.Drawing.Size(189, 41)
        Me.BTNKembali.TabIndex = 8
        Me.BTNKembali.Text = "KEMBALI"
        Me.BTNKembali.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTNTambahLoker)
        Me.GroupBox2.Controls.Add(Me.BTNUbahStatus)
        Me.GroupBox2.Controls.Add(Me.BTNHapusLoker)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(404, 95)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(189, 206)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MENU"
        '
        'BTNTambahLoker
        '
        Me.BTNTambahLoker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNTambahLoker.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BTNTambahLoker.Location = New System.Drawing.Point(27, 41)
        Me.BTNTambahLoker.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNTambahLoker.Name = "BTNTambahLoker"
        Me.BTNTambahLoker.Size = New System.Drawing.Size(129, 41)
        Me.BTNTambahLoker.TabIndex = 1
        Me.BTNTambahLoker.Text = "TAMBAH"
        Me.BTNTambahLoker.UseVisualStyleBackColor = True
        '
        'BTNUbahStatus
        '
        Me.BTNUbahStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNUbahStatus.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BTNUbahStatus.Location = New System.Drawing.Point(27, 89)
        Me.BTNUbahStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNUbahStatus.Name = "BTNUbahStatus"
        Me.BTNUbahStatus.Size = New System.Drawing.Size(129, 41)
        Me.BTNUbahStatus.TabIndex = 2
        Me.BTNUbahStatus.Text = "UBAH STATUS"
        Me.BTNUbahStatus.UseVisualStyleBackColor = True
        '
        'BTNHapusLoker
        '
        Me.BTNHapusLoker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNHapusLoker.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BTNHapusLoker.Location = New System.Drawing.Point(27, 137)
        Me.BTNHapusLoker.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNHapusLoker.Name = "BTNHapusLoker"
        Me.BTNHapusLoker.Size = New System.Drawing.Size(129, 41)
        Me.BTNHapusLoker.TabIndex = 3
        Me.BTNHapusLoker.Text = "HAPUS"
        Me.BTNHapusLoker.UseVisualStyleBackColor = True
        '
        'MonitorLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(671, 571)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "MonitorLocker"
        Me.Text = "MonitorLocker"
        CType(Me.DataGridLocker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridLocker As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTNTambahLoker As Button
    Friend WithEvents BTNUbahStatus As Button
    Friend WithEvents BTNHapusLoker As Button
    Friend WithEvents BTNKembali As Button
End Class
