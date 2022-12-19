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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonitorLocker))
        Me.DataGridLocker = New System.Windows.Forms.DataGridView()
        Me.btntambahlocker = New System.Windows.Forms.Button()
        Me.btnupdatestatus = New System.Windows.Forms.Button()
        Me.btnhapuslocker = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridLocker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridLocker
        '
        Me.DataGridLocker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridLocker.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridLocker.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridLocker.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridLocker.Location = New System.Drawing.Point(-8, 66)
        Me.DataGridLocker.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridLocker.Name = "DataGridLocker"
        Me.DataGridLocker.RowHeadersWidth = 51
        Me.DataGridLocker.Size = New System.Drawing.Size(522, 452)
        Me.DataGridLocker.TabIndex = 0
        '
        'btntambahlocker
        '
        Me.btntambahlocker.BackColor = System.Drawing.Color.White
        Me.btntambahlocker.BackgroundImage = CType(resources.GetObject("btntambahlocker.BackgroundImage"), System.Drawing.Image)
        Me.btntambahlocker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btntambahlocker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntambahlocker.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btntambahlocker.FlatAppearance.BorderSize = 2
        Me.btntambahlocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambahlocker.Font = New System.Drawing.Font("Inter", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambahlocker.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btntambahlocker.Location = New System.Drawing.Point(177, 531)
        Me.btntambahlocker.Margin = New System.Windows.Forms.Padding(4)
        Me.btntambahlocker.Name = "btntambahlocker"
        Me.btntambahlocker.Size = New System.Drawing.Size(156, 39)
        Me.btntambahlocker.TabIndex = 1
        Me.btntambahlocker.UseVisualStyleBackColor = False
        '
        'btnupdatestatus
        '
        Me.btnupdatestatus.BackColor = System.Drawing.Color.White
        Me.btnupdatestatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdatestatus.FlatAppearance.BorderSize = 0
        Me.btnupdatestatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdatestatus.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdatestatus.ForeColor = System.Drawing.Color.Black
        Me.btnupdatestatus.Location = New System.Drawing.Point(341, 531)
        Me.btnupdatestatus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupdatestatus.Name = "btnupdatestatus"
        Me.btnupdatestatus.Size = New System.Drawing.Size(156, 39)
        Me.btnupdatestatus.TabIndex = 2
        Me.btnupdatestatus.Text = "UPDATE STATUS"
        Me.btnupdatestatus.UseVisualStyleBackColor = False
        '
        'btnhapuslocker
        '
        Me.btnhapuslocker.BackColor = System.Drawing.Color.Black
        Me.btnhapuslocker.BackgroundImage = CType(resources.GetObject("btnhapuslocker.BackgroundImage"), System.Drawing.Image)
        Me.btnhapuslocker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnhapuslocker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhapuslocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapuslocker.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapuslocker.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnhapuslocker.Location = New System.Drawing.Point(13, 531)
        Me.btnhapuslocker.Margin = New System.Windows.Forms.Padding(4)
        Me.btnhapuslocker.Name = "btnhapuslocker"
        Me.btnhapuslocker.Size = New System.Drawing.Size(156, 39)
        Me.btnhapuslocker.TabIndex = 3
        Me.btnhapuslocker.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(164, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LIST LOKER"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, -2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 71)
        Me.Panel1.TabIndex = 5
        '
        'MonitorLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(510, 581)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnhapuslocker)
        Me.Controls.Add(Me.btnupdatestatus)
        Me.Controls.Add(Me.btntambahlocker)
        Me.Controls.Add(Me.DataGridLocker)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MonitorLocker"
        Me.Text = "MonitorLocker"
        CType(Me.DataGridLocker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridLocker As DataGridView
    Friend WithEvents btntambahlocker As Button
    Friend WithEvents btnupdatestatus As Button
    Friend WithEvents btnhapuslocker As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
