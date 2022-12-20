<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahJenisLocker
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
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtUkuran = New System.Windows.Forms.TextBox()
        Me.LblBiaya = New System.Windows.Forms.Label()
        Me.LblUkuran = New System.Windows.Forms.Label()
        Me.LblTambahJenisLocker = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblInfoKet = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBiaya = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtInfoKet = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Black
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(207, 300)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(88, 35)
        Me.BtnAdd.TabIndex = 16
        Me.BtnAdd.Text = "TAMBAH"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'TxtUkuran
        '
        Me.TxtUkuran.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUkuran.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUkuran.Location = New System.Drawing.Point(11, 7)
        Me.TxtUkuran.Name = "TxtUkuran"
        Me.TxtUkuran.Size = New System.Drawing.Size(341, 20)
        Me.TxtUkuran.TabIndex = 14
        '
        'LblBiaya
        '
        Me.LblBiaya.AutoSize = True
        Me.LblBiaya.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LblBiaya.Location = New System.Drawing.Point(17, 136)
        Me.LblBiaya.Name = "LblBiaya"
        Me.LblBiaya.Size = New System.Drawing.Size(45, 19)
        Me.LblBiaya.TabIndex = 13
        Me.LblBiaya.Text = "Biaya"
        '
        'LblUkuran
        '
        Me.LblUkuran.AutoSize = True
        Me.LblUkuran.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LblUkuran.Location = New System.Drawing.Point(17, 65)
        Me.LblUkuran.Name = "LblUkuran"
        Me.LblUkuran.Size = New System.Drawing.Size(55, 19)
        Me.LblUkuran.TabIndex = 12
        Me.LblUkuran.Text = "Ukuran"
        '
        'LblTambahJenisLocker
        '
        Me.LblTambahJenisLocker.BackColor = System.Drawing.Color.Black
        Me.LblTambahJenisLocker.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblTambahJenisLocker.ForeColor = System.Drawing.Color.White
        Me.LblTambahJenisLocker.Location = New System.Drawing.Point(0, 0)
        Me.LblTambahJenisLocker.Name = "LblTambahJenisLocker"
        Me.LblTambahJenisLocker.Size = New System.Drawing.Size(410, 52)
        Me.LblTambahJenisLocker.TabIndex = 11
        Me.LblTambahJenisLocker.Text = "TAMBAH JENIS LOKER"
        Me.LblTambahJenisLocker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnClose
        '
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnClose.Location = New System.Drawing.Point(301, 300)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(88, 35)
        Me.BtnClose.TabIndex = 17
        Me.BtnClose.Text = "BATAL"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblInfoKet
        '
        Me.LblInfoKet.AutoSize = True
        Me.LblInfoKet.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LblInfoKet.Location = New System.Drawing.Point(17, 213)
        Me.LblInfoKet.Name = "LblInfoKet"
        Me.LblInfoKet.Size = New System.Drawing.Size(83, 19)
        Me.LblInfoKet.TabIndex = 19
        Me.LblInfoKet.Text = "Keterangan"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtUkuran)
        Me.Panel1.Location = New System.Drawing.Point(21, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 35)
        Me.Panel1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxtBiaya)
        Me.Panel2.Location = New System.Drawing.Point(21, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(368, 35)
        Me.Panel2.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 19)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Rp."
        '
        'TxtBiaya
        '
        Me.TxtBiaya.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBiaya.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBiaya.Location = New System.Drawing.Point(37, 6)
        Me.TxtBiaya.Name = "TxtBiaya"
        Me.TxtBiaya.Size = New System.Drawing.Size(317, 20)
        Me.TxtBiaya.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TxtInfoKet)
        Me.Panel3.Location = New System.Drawing.Point(21, 235)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(368, 35)
        Me.Panel3.TabIndex = 21
        '
        'TxtInfoKet
        '
        Me.TxtInfoKet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtInfoKet.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInfoKet.Location = New System.Drawing.Point(13, 6)
        Me.TxtInfoKet.Name = "TxtInfoKet"
        Me.TxtInfoKet.Size = New System.Drawing.Size(341, 20)
        Me.TxtInfoKet.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.LblTambahJenisLocker)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.LblUkuran)
        Me.Panel4.Controls.Add(Me.LblBiaya)
        Me.Panel4.Controls.Add(Me.LblInfoKet)
        Me.Panel4.Controls.Add(Me.BtnAdd)
        Me.Panel4.Controls.Add(Me.BtnClose)
        Me.Panel4.Location = New System.Drawing.Point(26, 25)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(410, 351)
        Me.Panel4.TabIndex = 22
        '
        'TambahJenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(460, 404)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "TambahJenisLocker"
        Me.Text = "Tambah Jenis Loker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtUkuran As TextBox
    Friend WithEvents LblBiaya As Label
    Friend WithEvents LblUkuran As Label
    Friend WithEvents LblTambahJenisLocker As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblInfoKet As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtBiaya As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtInfoKet As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
End Class
