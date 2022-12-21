<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SewaLocker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBUkuranLocker = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblBiayaPerJam = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblTotalBiaya = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnYesSewa = New System.Windows.Forms.Button()
        Me.BtnNoSewa = New System.Windows.Forms.Button()
        Me.LsbLockerTersedia = New System.Windows.Forms.ListBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LblLamaSewa = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.RTBKetUser = New System.Windows.Forms.RichTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LblJumlahKomentar = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NUDLamaSewa = New System.Windows.Forms.NumericUpDown()
        Me.LblKetUkuran = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LblNamaLocker = New System.Windows.Forms.Label()
        CType(Me.NUDLamaSewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(27, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(699, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM SEWA LOKER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Keterangan"
        '
        'CBUkuranLocker
        '
        Me.CBUkuranLocker.FormattingEnabled = True
        Me.CBUkuranLocker.Location = New System.Drawing.Point(27, 43)
        Me.CBUkuranLocker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBUkuranLocker.Name = "CBUkuranLocker"
        Me.CBUkuranLocker.Size = New System.Drawing.Size(216, 24)
        Me.CBUkuranLocker.TabIndex = 6
        Me.CBUkuranLocker.Text = "-- Pilih Ukuran --"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Ukuran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 24)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Ketersediaan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(305, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Hari"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 24)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Lama Sewa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 24)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Biaya Sewa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(380, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 24)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "/Hari."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(164, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 24)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Rp."
        '
        'LblBiayaPerJam
        '
        Me.LblBiayaPerJam.AutoSize = True
        Me.LblBiayaPerJam.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiayaPerJam.Location = New System.Drawing.Point(199, 107)
        Me.LblBiayaPerJam.Name = "LblBiayaPerJam"
        Me.LblBiayaPerJam.Size = New System.Drawing.Size(20, 24)
        Me.LblBiayaPerJam.TabIndex = 27
        Me.LblBiayaPerJam.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 24)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Total Biaya"
        '
        'LblTotalBiaya
        '
        Me.LblTotalBiaya.AutoSize = True
        Me.LblTotalBiaya.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalBiaya.Location = New System.Drawing.Point(199, 150)
        Me.LblTotalBiaya.Name = "LblTotalBiaya"
        Me.LblTotalBiaya.Size = New System.Drawing.Size(20, 24)
        Me.LblTotalBiaya.TabIndex = 30
        Me.LblTotalBiaya.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(164, 150)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 24)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Rp."
        '
        'BtnYesSewa
        '
        Me.BtnYesSewa.BackColor = System.Drawing.Color.Black
        Me.BtnYesSewa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnYesSewa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnYesSewa.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnYesSewa.ForeColor = System.Drawing.Color.White
        Me.BtnYesSewa.Location = New System.Drawing.Point(491, 741)
        Me.BtnYesSewa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnYesSewa.Name = "BtnYesSewa"
        Me.BtnYesSewa.Size = New System.Drawing.Size(116, 42)
        Me.BtnYesSewa.TabIndex = 31
        Me.BtnYesSewa.Text = "SEWA"
        Me.BtnYesSewa.UseVisualStyleBackColor = False
        '
        'BtnNoSewa
        '
        Me.BtnNoSewa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnNoSewa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNoSewa.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNoSewa.Location = New System.Drawing.Point(616, 741)
        Me.BtnNoSewa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnNoSewa.Name = "BtnNoSewa"
        Me.BtnNoSewa.Size = New System.Drawing.Size(116, 42)
        Me.BtnNoSewa.TabIndex = 32
        Me.BtnNoSewa.Text = "BATAL"
        Me.BtnNoSewa.UseVisualStyleBackColor = True
        '
        'LsbLockerTersedia
        '
        Me.LsbLockerTersedia.FormattingEnabled = True
        Me.LsbLockerTersedia.ItemHeight = 16
        Me.LsbLockerTersedia.Location = New System.Drawing.Point(27, 135)
        Me.LsbLockerTersedia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LsbLockerTersedia.Name = "LsbLockerTersedia"
        Me.LsbLockerTersedia.Size = New System.Drawing.Size(215, 212)
        Me.LsbLockerTersedia.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(24, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 24)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Nama Loker"
        '
        'LblLamaSewa
        '
        Me.LblLamaSewa.AutoSize = True
        Me.LblLamaSewa.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLamaSewa.Location = New System.Drawing.Point(164, 63)
        Me.LblLamaSewa.Name = "LblLamaSewa"
        Me.LblLamaSewa.Size = New System.Drawing.Size(20, 24)
        Me.LblLamaSewa.TabIndex = 38
        Me.LblLamaSewa.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(25, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 24)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Lama Sewa"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(380, 63)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 24)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "/Hari."
        '
        'RTBKetUser
        '
        Me.RTBKetUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTBKetUser.Location = New System.Drawing.Point(11, 10)
        Me.RTBKetUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RTBKetUser.Name = "RTBKetUser"
        Me.RTBKetUser.Size = New System.Drawing.Size(304, 182)
        Me.RTBKetUser.TabIndex = 40
        Me.RTBKetUser.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(152, 112)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(141, 17)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "*isi mengenai barang"
        '
        'LblJumlahKomentar
        '
        Me.LblJumlahKomentar.AutoSize = True
        Me.LblJumlahKomentar.BackColor = System.Drawing.Color.Transparent
        Me.LblJumlahKomentar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJumlahKomentar.Location = New System.Drawing.Point(367, 324)
        Me.LblJumlahKomentar.Name = "LblJumlahKomentar"
        Me.LblJumlahKomentar.Size = New System.Drawing.Size(28, 21)
        Me.LblJumlahKomentar.TabIndex = 42
        Me.LblJumlahKomentar.Text = "50"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(165, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 18)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "*tidak termasuk denda"
        '
        'NUDLamaSewa
        '
        Me.NUDLamaSewa.Location = New System.Drawing.Point(35, 46)
        Me.NUDLamaSewa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NUDLamaSewa.Name = "NUDLamaSewa"
        Me.NUDLamaSewa.Size = New System.Drawing.Size(257, 24)
        Me.NUDLamaSewa.TabIndex = 44
        '
        'LblKetUkuran
        '
        Me.LblKetUkuran.AutoSize = True
        Me.LblKetUkuran.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKetUkuran.ForeColor = System.Drawing.Color.Black
        Me.LblKetUkuran.Location = New System.Drawing.Point(24, 71)
        Me.LblKetUkuran.Name = "LblKetUkuran"
        Me.LblKetUkuran.Size = New System.Drawing.Size(33, 18)
        Me.LblKetUkuran.TabIndex = 45
        Me.LblKetUkuran.Text = "Ket."
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LblKetUkuran)
        Me.Panel1.Controls.Add(Me.CBUkuranLocker)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LsbLockerTersedia)
        Me.Panel1.Location = New System.Drawing.Point(33, 122)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 368)
        Me.Panel1.TabIndex = 47
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.NUDLamaSewa)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.LblJumlahKomentar)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(313, 122)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(418, 368)
        Me.Panel2.TabIndex = 46
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.RTBKetUser)
        Me.Panel3.Location = New System.Drawing.Point(35, 135)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(325, 209)
        Me.Panel3.TabIndex = 42
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.LblNamaLocker)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.LblLamaSewa)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.LblBiayaPerJam)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.LblTotalBiaya)
        Me.Panel4.Location = New System.Drawing.Point(33, 497)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(698, 220)
        Me.Panel4.TabIndex = 48
        '
        'LblNamaLocker
        '
        Me.LblNamaLocker.AutoSize = True
        Me.LblNamaLocker.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaLocker.Location = New System.Drawing.Point(164, 18)
        Me.LblNamaLocker.Name = "LblNamaLocker"
        Me.LblNamaLocker.Size = New System.Drawing.Size(35, 24)
        Me.LblNamaLocker.TabIndex = 44
        Me.LblNamaLocker.Text = "X-X"
        '
        'SewaLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 810)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnNoSewa)
        Me.Controls.Add(Me.BtnYesSewa)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SewaLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Sewa Loker"
        CType(Me.NUDLamaSewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CBUkuranLocker As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblBiayaPerJam As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LblTotalBiaya As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnYesSewa As Button
    Friend WithEvents BtnNoSewa As Button
    Friend WithEvents LsbLockerTersedia As ListBox
    Friend WithEvents Label16 As Label
    Friend WithEvents LblLamaSewa As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents RTBKetUser As RichTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents LblJumlahKomentar As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents NUDLamaSewa As NumericUpDown
    Friend WithEvents LblKetUkuran As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LblNamaLocker As Label
End Class
