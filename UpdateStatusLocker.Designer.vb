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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GBstatus.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBstatus
        '
        Me.GBstatus.BackColor = System.Drawing.Color.White
        Me.GBstatus.Controls.Add(Me.RBKosong)
        Me.GBstatus.Controls.Add(Me.RBTerisi)
        Me.GBstatus.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBstatus.ForeColor = System.Drawing.Color.Black
        Me.GBstatus.Location = New System.Drawing.Point(16, 50)
        Me.GBstatus.Margin = New System.Windows.Forms.Padding(2)
        Me.GBstatus.Name = "GBstatus"
        Me.GBstatus.Padding = New System.Windows.Forms.Padding(2)
        Me.GBstatus.Size = New System.Drawing.Size(291, 97)
        Me.GBstatus.TabIndex = 1
        Me.GBstatus.TabStop = False
        Me.GBstatus.Text = "Status"
        '
        'RBKosong
        '
        Me.RBKosong.AutoSize = True
        Me.RBKosong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBKosong.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBKosong.ForeColor = System.Drawing.Color.Black
        Me.RBKosong.Location = New System.Drawing.Point(12, 59)
        Me.RBKosong.Name = "RBKosong"
        Me.RBKosong.Size = New System.Drawing.Size(85, 27)
        Me.RBKosong.TabIndex = 1
        Me.RBKosong.TabStop = True
        Me.RBKosong.Text = "Kosong"
        Me.RBKosong.UseVisualStyleBackColor = True
        '
        'RBTerisi
        '
        Me.RBTerisi.AutoSize = True
        Me.RBTerisi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBTerisi.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTerisi.ForeColor = System.Drawing.Color.Black
        Me.RBTerisi.Location = New System.Drawing.Point(12, 28)
        Me.RBTerisi.Name = "RBTerisi"
        Me.RBTerisi.Size = New System.Drawing.Size(67, 27)
        Me.RBTerisi.TabIndex = 0
        Me.RBTerisi.TabStop = True
        Me.RBTerisi.Text = "Terisi"
        Me.RBTerisi.UseVisualStyleBackColor = True
        '
        'BTNSimpan
        '
        Me.BTNSimpan.BackColor = System.Drawing.Color.White
        Me.BTNSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSimpan.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSimpan.ForeColor = System.Drawing.Color.Black
        Me.BTNSimpan.Location = New System.Drawing.Point(199, 157)
        Me.BTNSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNSimpan.Name = "BTNSimpan"
        Me.BTNSimpan.Size = New System.Drawing.Size(108, 36)
        Me.BTNSimpan.TabIndex = 2
        Me.BTNSimpan.Text = "SIMPAN"
        Me.BTNSimpan.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.BTNSimpan)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.GBstatus)
        Me.Panel2.Location = New System.Drawing.Point(22, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(326, 211)
        Me.Panel2.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(326, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "STATUS LOKER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Location = New System.Drawing.Point(79, 157)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 36)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "KEMBALI"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'UpdateStatusLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(370, 247)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UpdateStatusLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateStatusLocker"
        Me.GBstatus.ResumeLayout(False)
        Me.GBstatus.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBstatus As GroupBox
    Friend WithEvents RBKosong As RadioButton
    Friend WithEvents RBTerisi As RadioButton
    Friend WithEvents BTNSimpan As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
