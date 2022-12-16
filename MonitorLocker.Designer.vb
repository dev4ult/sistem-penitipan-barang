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
        CType(Me.DataGridLocker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridLocker
        '
        Me.DataGridLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridLocker.Location = New System.Drawing.Point(23, 91)
        Me.DataGridLocker.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridLocker.Name = "DataGridLocker"
        Me.DataGridLocker.RowHeadersWidth = 51
        Me.DataGridLocker.Size = New System.Drawing.Size(1081, 345)
        Me.DataGridLocker.TabIndex = 0
        '
        'btntambahlocker
        '
        Me.btntambahlocker.Location = New System.Drawing.Point(281, 575)
        Me.btntambahlocker.Margin = New System.Windows.Forms.Padding(4)
        Me.btntambahlocker.Name = "btntambahlocker"
        Me.btntambahlocker.Size = New System.Drawing.Size(133, 28)
        Me.btntambahlocker.TabIndex = 1
        Me.btntambahlocker.Text = "Tambah Locker"
        Me.btntambahlocker.UseVisualStyleBackColor = True
        '
        'btnupdatestatus
        '
        Me.btnupdatestatus.Location = New System.Drawing.Point(620, 575)
        Me.btnupdatestatus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupdatestatus.Name = "btnupdatestatus"
        Me.btnupdatestatus.Size = New System.Drawing.Size(133, 28)
        Me.btnupdatestatus.TabIndex = 2
        Me.btnupdatestatus.Text = "Update Status"
        Me.btnupdatestatus.UseVisualStyleBackColor = True
        '
        'btnhapuslocker
        '
        Me.btnhapuslocker.Location = New System.Drawing.Point(447, 575)
        Me.btnhapuslocker.Margin = New System.Windows.Forms.Padding(4)
        Me.btnhapuslocker.Name = "btnhapuslocker"
        Me.btnhapuslocker.Size = New System.Drawing.Size(133, 28)
        Me.btnhapuslocker.TabIndex = 3
        Me.btnhapuslocker.Text = "Hapus Locker"
        Me.btnhapuslocker.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Data Locker"
        '
        'MonitorLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 661)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnhapuslocker)
        Me.Controls.Add(Me.btnupdatestatus)
        Me.Controls.Add(Me.btntambahlocker)
        Me.Controls.Add(Me.DataGridLocker)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MonitorLocker"
        Me.Text = "MonitorLocker"
        CType(Me.DataGridLocker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridLocker As DataGridView
    Friend WithEvents btntambahlocker As Button
    Friend WithEvents btnupdatestatus As Button
    Friend WithEvents btnhapuslocker As Button
    Friend WithEvents Label1 As Label
End Class
