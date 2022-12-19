<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStatusLocker
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
        Me.GBstatus = New System.Windows.Forms.GroupBox()
        Me.RBKosong = New System.Windows.Forms.RadioButton()
        Me.RBTerisi = New System.Windows.Forms.RadioButton()
        Me.BTNSimpan = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBstatus.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBstatus
        '
        Me.GBstatus.Controls.Add(Me.RBKosong)
        Me.GBstatus.Controls.Add(Me.RBTerisi)
        Me.GBstatus.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBstatus.ForeColor = System.Drawing.Color.GhostWhite
        Me.GBstatus.Location = New System.Drawing.Point(48, 77)
        Me.GBstatus.Name = "GBstatus"
        Me.GBstatus.Size = New System.Drawing.Size(222, 97)
        Me.GBstatus.TabIndex = 1
        Me.GBstatus.TabStop = False
        Me.GBstatus.Text = "Status"
        '
        'RBKosong
        '
        Me.RBKosong.AutoSize = True
        Me.RBKosong.Location = New System.Drawing.Point(40, 59)
        Me.RBKosong.Name = "RBKosong"
        Me.RBKosong.Size = New System.Drawing.Size(80, 22)
        Me.RBKosong.TabIndex = 1
        Me.RBKosong.TabStop = True
        Me.RBKosong.Text = "Kosong"
        Me.RBKosong.UseVisualStyleBackColor = True
        '
        'RBTerisi
        '
        Me.RBTerisi.AutoSize = True
        Me.RBTerisi.Location = New System.Drawing.Point(40, 28)
        Me.RBTerisi.Name = "RBTerisi"
        Me.RBTerisi.Size = New System.Drawing.Size(69, 22)
        Me.RBTerisi.TabIndex = 0
        Me.RBTerisi.TabStop = True
        Me.RBTerisi.Text = "Terisi"
        Me.RBTerisi.UseVisualStyleBackColor = True
        '
        'BTNSimpan
        '
        Me.BTNSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BTNSimpan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSimpan.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BTNSimpan.Location = New System.Drawing.Point(198, 195)
        Me.BTNSimpan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BTNSimpan.Name = "BTNSimpan"
        Me.BTNSimpan.Size = New System.Drawing.Size(72, 25)
        Me.BTNSimpan.TabIndex = 2
        Me.BTNSimpan.Text = "Simpan"
        Me.BTNSimpan.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 58)
        Me.Panel1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(84, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Update Locker"
        '
        'UpdateStatusLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(317, 231)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.GBstatus)
        Me.Name = "UpdateStatusLocker"
        Me.Text = "UpdateStatusLocker"
        Me.GBstatus.ResumeLayout(False)
        Me.GBstatus.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBstatus As GroupBox
    Friend WithEvents RBKosong As RadioButton
    Friend WithEvents RBTerisi As RadioButton
    Friend WithEvents BTNSimpan As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
