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
        Me.LblNamaLocker = New System.Windows.Forms.Label()
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
        Me.LblNamaLoker = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.Label1.Location = New System.Drawing.Point(25, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(524, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM SEWA LOKER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 87)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Keterangan"
        '
        'CBUkuranLocker
        '
        Me.CBUkuranLocker.FormattingEnabled = True
        Me.CBUkuranLocker.Location = New System.Drawing.Point(20, 35)
        Me.CBUkuranLocker.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CBUkuranLocker.Name = "CBUkuranLocker"
        Me.CBUkuranLocker.Size = New System.Drawing.Size(163, 21)
        Me.CBUkuranLocker.TabIndex = 6
        Me.CBUkuranLocker.Text = "-- Pilih Ukuran --"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 10)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Ukuran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Ketersediaan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(229, 39)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Hari"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 10)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 19)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Lama Sewa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 87)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 19)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Biaya Sewa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(285, 87)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 19)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "/Hari."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(123, 87)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 19)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Rp."
        '
        'LblBiayaPerJam
        '
        Me.LblBiayaPerJam.AutoSize = True
        Me.LblBiayaPerJam.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiayaPerJam.Location = New System.Drawing.Point(149, 87)
        Me.LblBiayaPerJam.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblBiayaPerJam.Name = "LblBiayaPerJam"
        Me.LblBiayaPerJam.Size = New System.Drawing.Size(17, 19)
        Me.LblBiayaPerJam.TabIndex = 27
        Me.LblBiayaPerJam.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 122)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 19)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Total Biaya"
        '
        'LblTotalBiaya
        '
        Me.LblTotalBiaya.AutoSize = True
        Me.LblTotalBiaya.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalBiaya.Location = New System.Drawing.Point(149, 122)
        Me.LblTotalBiaya.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTotalBiaya.Name = "LblTotalBiaya"
        Me.LblTotalBiaya.Size = New System.Drawing.Size(17, 19)
        Me.LblTotalBiaya.TabIndex = 30
        Me.LblTotalBiaya.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(123, 122)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 19)
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
        Me.BtnYesSewa.Location = New System.Drawing.Point(368, 587)
        Me.BtnYesSewa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnYesSewa.Name = "BtnYesSewa"
        Me.BtnYesSewa.Size = New System.Drawing.Size(87, 34)
        Me.BtnYesSewa.TabIndex = 31
        Me.BtnYesSewa.Text = "SEWA"
        Me.BtnYesSewa.UseVisualStyleBackColor = False
        '
        'BtnNoSewa
        '
        Me.BtnNoSewa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnNoSewa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNoSewa.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNoSewa.Location = New System.Drawing.Point(462, 587)
        Me.BtnNoSewa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnNoSewa.Name = "BtnNoSewa"
        Me.BtnNoSewa.Size = New System.Drawing.Size(87, 34)
        Me.BtnNoSewa.TabIndex = 32
        Me.BtnNoSewa.Text = "BATAL"
        Me.BtnNoSewa.UseVisualStyleBackColor = True
        '
        'LsbLockerTersedia
        '
        Me.LsbLockerTersedia.FormattingEnabled = True
        Me.LsbLockerTersedia.Location = New System.Drawing.Point(20, 110)
        Me.LsbLockerTersedia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LsbLockerTersedia.Name = "LsbLockerTersedia"
        Me.LsbLockerTersedia.Size = New System.Drawing.Size(162, 173)
        Me.LsbLockerTersedia.TabIndex = 33
        '
        'LblNamaLocker
        '
        Me.LblNamaLocker.AutoSize = True
        Me.LblNamaLocker.BackColor = System.Drawing.SystemColors.Control
        Me.LblNamaLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblNamaLocker.Location = New System.Drawing.Point(715, 326)
        Me.LblNamaLocker.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNamaLocker.Name = "LblNamaLocker"
        Me.LblNamaLocker.Size = New System.Drawing.Size(0, 20)
        Me.LblNamaLocker.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 15)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 19)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Nama Loker"
        '
        'LblLamaSewa
        '
        Me.LblLamaSewa.AutoSize = True
        Me.LblLamaSewa.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLamaSewa.Location = New System.Drawing.Point(123, 51)
        Me.LblLamaSewa.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblLamaSewa.Name = "LblLamaSewa"
        Me.LblLamaSewa.Size = New System.Drawing.Size(17, 19)
        Me.LblLamaSewa.TabIndex = 38
        Me.LblLamaSewa.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(19, 51)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 19)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Lama Sewa"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(285, 51)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 19)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Hari."
        '
        'RTBKetUser
        '
        Me.RTBKetUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTBKetUser.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBKetUser.Location = New System.Drawing.Point(8, 8)
        Me.RTBKetUser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RTBKetUser.Name = "RTBKetUser"
        Me.RTBKetUser.Size = New System.Drawing.Size(228, 148)
        Me.RTBKetUser.TabIndex = 40
        Me.RTBKetUser.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(114, 91)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(105, 13)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "*isi mengenai barang"
        '
        'LblJumlahKomentar
        '
        Me.LblJumlahKomentar.AutoSize = True
        Me.LblJumlahKomentar.BackColor = System.Drawing.Color.Transparent
        Me.LblJumlahKomentar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJumlahKomentar.Location = New System.Drawing.Point(275, 263)
        Me.LblJumlahKomentar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblJumlahKomentar.Name = "LblJumlahKomentar"
        Me.LblJumlahKomentar.Size = New System.Drawing.Size(21, 15)
        Me.LblJumlahKomentar.TabIndex = 42
        Me.LblJumlahKomentar.Text = "50"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(124, 150)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 14)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "*tidak termasuk denda"
        '
        'NUDLamaSewa
        '
        Me.NUDLamaSewa.Location = New System.Drawing.Point(26, 37)
        Me.NUDLamaSewa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NUDLamaSewa.Name = "NUDLamaSewa"
        Me.NUDLamaSewa.Size = New System.Drawing.Size(193, 21)
        Me.NUDLamaSewa.TabIndex = 44
        '
        'LblKetUkuran
        '
        Me.LblKetUkuran.AutoSize = True
        Me.LblKetUkuran.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKetUkuran.ForeColor = System.Drawing.Color.Black
        Me.LblKetUkuran.Location = New System.Drawing.Point(18, 58)
        Me.LblKetUkuran.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblKetUkuran.Name = "LblKetUkuran"
        Me.LblKetUkuran.Size = New System.Drawing.Size(27, 14)
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
        Me.Panel1.Location = New System.Drawing.Point(25, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(204, 299)
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
        Me.Panel2.Location = New System.Drawing.Point(235, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(314, 299)
        Me.Panel2.TabIndex = 46
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.RTBKetUser)
        Me.Panel3.Location = New System.Drawing.Point(26, 110)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(244, 170)
        Me.Panel3.TabIndex = 42
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.LblNamaLoker)
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
        Me.Panel4.Location = New System.Drawing.Point(25, 392)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(524, 179)
        Me.Panel4.TabIndex = 48
        '
        'LblNamaLoker
        '
        Me.LblNamaLoker.AutoSize = True
        Me.LblNamaLoker.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaLoker.Location = New System.Drawing.Point(123, 15)
        Me.LblNamaLoker.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNamaLoker.Name = "LblNamaLoker"
        Me.LblNamaLoker.Size = New System.Drawing.Size(85, 19)
        Me.LblNamaLoker.TabIndex = 44
        Me.LblNamaLoker.Text = "Nama Loker"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 584)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 33)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "DIGILOKER"
        '
        'SewaLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(573, 631)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblNamaLocker)
        Me.Controls.Add(Me.BtnNoSewa)
        Me.Controls.Add(Me.BtnYesSewa)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.PerformLayout()

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
    Friend WithEvents LblNamaLocker As Label
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
    Friend WithEvents LblNamaLoker As Label
    Friend WithEvents Label12 As Label
End Class
