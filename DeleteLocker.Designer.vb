<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteLocker
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(20, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah anda Ingin menghapus loker ini?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBNamaLoker
        '
        Me.LBNamaLoker.AutoSize = True
        Me.LBNamaLoker.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNamaLoker.ForeColor = System.Drawing.Color.Black
        Me.LBNamaLoker.Location = New System.Drawing.Point(186, 104)
        Me.LBNamaLoker.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBNamaLoker.Name = "LBNamaLoker"
        Me.LBNamaLoker.Size = New System.Drawing.Size(35, 23)
        Me.LBNamaLoker.TabIndex = 1
        Me.LBNamaLoker.Text = "X-X"
        '
        'BTNHapus
        '
        Me.BTNHapus.BackColor = System.Drawing.Color.Black
        Me.BTNHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNHapus.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHapus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BTNHapus.Location = New System.Drawing.Point(65, 162)
        Me.BTNHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNHapus.Name = "BTNHapus"
        Me.BTNHapus.Size = New System.Drawing.Size(108, 36)
        Me.BTNHapus.TabIndex = 2
        Me.BTNHapus.Text = "HAPUS"
        Me.BTNHapus.UseVisualStyleBackColor = False
        '
        'BTNKembali
        '
        Me.BTNKembali.BackColor = System.Drawing.Color.White
        Me.BTNKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNKembali.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNKembali.ForeColor = System.Drawing.Color.Black
        Me.BTNKembali.Location = New System.Drawing.Point(190, 162)
        Me.BTNKembali.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNKembali.Name = "BTNKembali"
        Me.BTNKembali.Size = New System.Drawing.Size(108, 36)
        Me.BTNKembali.TabIndex = 3
        Me.BTNKembali.Text = "BATAL"
        Me.BTNKembali.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(109, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hapus Loker"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.BTNKembali)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.BTNHapus)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.LBNamaLoker)
        Me.Panel2.Location = New System.Drawing.Point(9, 20)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(377, 238)
        Me.Panel2.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(-1, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(377, 45)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "HAPUS LOKER"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Loker"
        '
        'HapusLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(397, 269)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "HapusLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HapusLocker"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LBNamaLoker As Label
    Friend WithEvents BTNHapus As Button
    Friend WithEvents BTNKembali As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
