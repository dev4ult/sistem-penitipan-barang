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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(41, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah anda Ingin menghapus locker ?"
        '
        'LBNamaLoker
        '
        Me.LBNamaLoker.AutoSize = True
        Me.LBNamaLoker.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNamaLoker.ForeColor = System.Drawing.Color.Black
        Me.LBNamaLoker.Location = New System.Drawing.Point(173, 130)
        Me.LBNamaLoker.Name = "LBNamaLoker"
        Me.LBNamaLoker.Size = New System.Drawing.Size(95, 19)
        Me.LBNamaLoker.TabIndex = 1
        Me.LBNamaLoker.Text = "Nama locker"
        '
        'BTNHapus
        '
        Me.BTNHapus.BackColor = System.Drawing.Color.Black
        Me.BTNHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNHapus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHapus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BTNHapus.Location = New System.Drawing.Point(167, 197)
        Me.BTNHapus.Name = "BTNHapus"
        Me.BTNHapus.Size = New System.Drawing.Size(83, 30)
        Me.BTNHapus.TabIndex = 2
        Me.BTNHapus.Text = "Hapus"
        Me.BTNHapus.UseVisualStyleBackColor = False
        '
        'BTNKembali
        '
        Me.BTNKembali.BackColor = System.Drawing.Color.White
        Me.BTNKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNKembali.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKembali.ForeColor = System.Drawing.Color.Black
        Me.BTNKembali.Location = New System.Drawing.Point(256, 197)
        Me.BTNKembali.Name = "BTNKembali"
        Me.BTNKembali.Size = New System.Drawing.Size(83, 30)
        Me.BTNKembali.TabIndex = 3
        Me.BTNKembali.Text = "Batal"
        Me.BTNKembali.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-1, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 58)
        Me.Panel1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(109, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hapus Locker"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.BTNHapus)
        Me.Panel2.Controls.Add(Me.BTNKembali)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.LBNamaLoker)
        Me.Panel2.Location = New System.Drawing.Point(12, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(367, 247)
        Me.Panel2.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Locker"
        '
        'HapusLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(406, 314)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "HapusLocker"
        Me.Text = "HapusLocker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LBNamaLoker As Label
    Friend WithEvents BTNHapus As Button
    Friend WithEvents BTNKembali As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
End Class
