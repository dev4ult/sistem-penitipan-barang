<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusLocker
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
        Me.LBNamaLoker = New System.Windows.Forms.Label()
        Me.BTNHapus = New System.Windows.Forms.Button()
        Me.BTNKembali = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Inter", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(36, 119)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah anda Ingin menghapus loker ini?"
        '
        'LBNamaLoker
        '
        Me.LBNamaLoker.AutoSize = True
        Me.LBNamaLoker.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNamaLoker.ForeColor = System.Drawing.Color.Black
        Me.LBNamaLoker.Location = New System.Drawing.Point(185, 172)
        Me.LBNamaLoker.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBNamaLoker.Name = "LBNamaLoker"
        Me.LBNamaLoker.Size = New System.Drawing.Size(43, 24)
        Me.LBNamaLoker.TabIndex = 1
        Me.LBNamaLoker.Text = "X-X"
        '
        'BTNHapus
        '
        Me.BTNHapus.BackColor = System.Drawing.Color.Black
        Me.BTNHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNHapus.FlatAppearance.BorderSize = 0
        Me.BTNHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNHapus.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHapus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BTNHapus.Location = New System.Drawing.Point(215, 247)
        Me.BTNHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNHapus.Name = "BTNHapus"
        Me.BTNHapus.Size = New System.Drawing.Size(111, 37)
        Me.BTNHapus.TabIndex = 2
        Me.BTNHapus.Text = "HAPUS"
        Me.BTNHapus.UseVisualStyleBackColor = False
        '
        'BTNKembali
        '
        Me.BTNKembali.BackColor = System.Drawing.Color.White
        Me.BTNKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNKembali.FlatAppearance.BorderSize = 2
        Me.BTNKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNKembali.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKembali.ForeColor = System.Drawing.Color.Black
        Me.BTNKembali.Location = New System.Drawing.Point(86, 247)
        Me.BTNKembali.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNKembali.Name = "BTNKembali"
        Me.BTNKembali.Size = New System.Drawing.Size(111, 37)
        Me.BTNKembali.TabIndex = 3
        Me.BTNKembali.Text = "KEMBALI"
        Me.BTNKembali.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(110, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hapus Loker"
        '
        'HapusLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(423, 314)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTNKembali)
        Me.Controls.Add(Me.BTNHapus)
        Me.Controls.Add(Me.LBNamaLoker)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HapusLocker"
        Me.Text = "HapusLocker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LBNamaLoker As Label
    Friend WithEvents BTNHapus As Button
    Friend WithEvents BTNKembali As Button
    Friend WithEvents Label2 As Label
End Class
