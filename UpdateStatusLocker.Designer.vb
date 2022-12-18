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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBstatus = New System.Windows.Forms.GroupBox()
        Me.RBKosong = New System.Windows.Forms.RadioButton()
        Me.RBTerisi = New System.Windows.Forms.RadioButton()
        Me.BTNSimpan = New System.Windows.Forms.Button()
        Me.GBstatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Locker"
        '
        'GBstatus
        '
        Me.GBstatus.Controls.Add(Me.RBKosong)
        Me.GBstatus.Controls.Add(Me.RBTerisi)
        Me.GBstatus.Location = New System.Drawing.Point(43, 90)
        Me.GBstatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GBstatus.Name = "GBstatus"
        Me.GBstatus.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GBstatus.Size = New System.Drawing.Size(296, 96)
        Me.GBstatus.TabIndex = 1
        Me.GBstatus.TabStop = False
        Me.GBstatus.Text = "Status"
        '
        'RBKosong
        '
        Me.RBKosong.AutoSize = True
        Me.RBKosong.Location = New System.Drawing.Point(63, 59)
        Me.RBKosong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RBKosong.Name = "RBKosong"
        Me.RBKosong.Size = New System.Drawing.Size(74, 20)
        Me.RBKosong.TabIndex = 1
        Me.RBKosong.TabStop = True
        Me.RBKosong.Text = "Kosong"
        Me.RBKosong.UseVisualStyleBackColor = True
        '
        'RBTerisi
        '
        Me.RBTerisi.AutoSize = True
        Me.RBTerisi.Location = New System.Drawing.Point(63, 27)
        Me.RBTerisi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RBTerisi.Name = "RBTerisi"
        Me.RBTerisi.Size = New System.Drawing.Size(62, 20)
        Me.RBTerisi.TabIndex = 0
        Me.RBTerisi.TabStop = True
        Me.RBTerisi.Text = "Terisi"
        Me.RBTerisi.UseVisualStyleBackColor = True
        '
        'BTNSimpan
        '
        Me.BTNSimpan.Location = New System.Drawing.Point(264, 193)
        Me.BTNSimpan.Name = "BTNSimpan"
        Me.BTNSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BTNSimpan.TabIndex = 2
        Me.BTNSimpan.Text = "Simpan"
        Me.BTNSimpan.UseVisualStyleBackColor = True
        '
        'UpdateStatusLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 225)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.GBstatus)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UpdateStatusLocker"
        Me.Text = "UpdateStatusLocker"
        Me.GBstatus.ResumeLayout(False)
        Me.GBstatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GBstatus As GroupBox
    Friend WithEvents RBKosong As RadioButton
    Friend WithEvents RBTerisi As RadioButton
    Friend WithEvents BTNSimpan As Button
End Class
