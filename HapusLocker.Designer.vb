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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah anda Ingin menghapus locker ?"
        '
        'LBNamaLoker
        '
        Me.LBNamaLoker.AutoSize = True
        Me.LBNamaLoker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNamaLoker.Location = New System.Drawing.Point(141, 126)
        Me.LBNamaLoker.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBNamaLoker.Name = "LBNamaLoker"
        Me.LBNamaLoker.Size = New System.Drawing.Size(121, 25)
        Me.LBNamaLoker.TabIndex = 1
        Me.LBNamaLoker.Text = "Nama locker"
        '
        'BTNHapus
        '
        Me.BTNHapus.Location = New System.Drawing.Point(72, 182)
        Me.BTNHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNHapus.Name = "BTNHapus"
        Me.BTNHapus.Size = New System.Drawing.Size(100, 28)
        Me.BTNHapus.TabIndex = 2
        Me.BTNHapus.Text = "Hapus"
        Me.BTNHapus.UseVisualStyleBackColor = True
        '
        'BTNKembali
        '
        Me.BTNKembali.Location = New System.Drawing.Point(245, 182)
        Me.BTNKembali.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNKembali.Name = "BTNKembali"
        Me.BTNKembali.Size = New System.Drawing.Size(100, 28)
        Me.BTNKembali.TabIndex = 3
        Me.BTNKembali.Text = "Kembali"
        Me.BTNKembali.UseVisualStyleBackColor = True
        '
        'HapusLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 302)
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
End Class
