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
        CType(Me.NUDLamaSewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Sewa Loker"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(256, 173)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Keterangan"
        '
        'CBUkuranLocker
        '
        Me.CBUkuranLocker.FormattingEnabled = True
        Me.CBUkuranLocker.Location = New System.Drawing.Point(98, 122)
        Me.CBUkuranLocker.Margin = New System.Windows.Forms.Padding(2)
        Me.CBUkuranLocker.Name = "CBUkuranLocker"
        Me.CBUkuranLocker.Size = New System.Drawing.Size(133, 21)
        Me.CBUkuranLocker.TabIndex = 6
        Me.CBUkuranLocker.Text = "-- Pilih Ukuran --"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(94, 92)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Ukuran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(94, 173)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Ketersediaan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(329, 124)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Hari"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(256, 92)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Lama Sewa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Bisque
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(273, 320)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Biaya Sewa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(273, 340)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "(Per Hari)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(363, 330)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 20)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Rp."
        '
        'LblBiayaPerJam
        '
        Me.LblBiayaPerJam.AutoSize = True
        Me.LblBiayaPerJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblBiayaPerJam.Location = New System.Drawing.Point(389, 330)
        Me.LblBiayaPerJam.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblBiayaPerJam.Name = "LblBiayaPerJam"
        Me.LblBiayaPerJam.Size = New System.Drawing.Size(18, 20)
        Me.LblBiayaPerJam.TabIndex = 27
        Me.LblBiayaPerJam.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Bisque
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(273, 374)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 20)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Total Biaya"
        '
        'LblTotalBiaya
        '
        Me.LblTotalBiaya.AutoSize = True
        Me.LblTotalBiaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblTotalBiaya.Location = New System.Drawing.Point(389, 374)
        Me.LblTotalBiaya.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTotalBiaya.Name = "LblTotalBiaya"
        Me.LblTotalBiaya.Size = New System.Drawing.Size(18, 20)
        Me.LblTotalBiaya.TabIndex = 30
        Me.LblTotalBiaya.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(363, 374)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 20)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Rp."
        '
        'BtnYesSewa
        '
        Me.BtnYesSewa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnYesSewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnYesSewa.Location = New System.Drawing.Point(262, 467)
        Me.BtnYesSewa.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnYesSewa.Name = "BtnYesSewa"
        Me.BtnYesSewa.Size = New System.Drawing.Size(143, 45)
        Me.BtnYesSewa.TabIndex = 31
        Me.BtnYesSewa.Text = "Sewa"
        Me.BtnYesSewa.UseVisualStyleBackColor = True
        '
        'BtnNoSewa
        '
        Me.BtnNoSewa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnNoSewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnNoSewa.Location = New System.Drawing.Point(98, 467)
        Me.BtnNoSewa.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnNoSewa.Name = "BtnNoSewa"
        Me.BtnNoSewa.Size = New System.Drawing.Size(143, 45)
        Me.BtnNoSewa.TabIndex = 32
        Me.BtnNoSewa.Text = "Cancel"
        Me.BtnNoSewa.UseVisualStyleBackColor = True
        '
        'LsbLockerTersedia
        '
        Me.LsbLockerTersedia.FormattingEnabled = True
        Me.LsbLockerTersedia.Location = New System.Drawing.Point(99, 200)
        Me.LsbLockerTersedia.Margin = New System.Windows.Forms.Padding(2)
        Me.LsbLockerTersedia.Name = "LsbLockerTersedia"
        Me.LsbLockerTersedia.Size = New System.Drawing.Size(102, 82)
        Me.LsbLockerTersedia.TabIndex = 33
        '
        'LblNamaLocker
        '
        Me.LblNamaLocker.AutoSize = True
        Me.LblNamaLocker.BackColor = System.Drawing.SystemColors.Control
        Me.LblNamaLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblNamaLocker.Location = New System.Drawing.Point(213, 320)
        Me.LblNamaLocker.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNamaLocker.Name = "LblNamaLocker"
        Me.LblNamaLocker.Size = New System.Drawing.Size(0, 20)
        Me.LblNamaLocker.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Bisque
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(111, 320)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 20)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Nama Loker"
        '
        'LblLamaSewa
        '
        Me.LblLamaSewa.AutoSize = True
        Me.LblLamaSewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblLamaSewa.Location = New System.Drawing.Point(213, 374)
        Me.LblLamaSewa.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblLamaSewa.Name = "LblLamaSewa"
        Me.LblLamaSewa.Size = New System.Drawing.Size(18, 20)
        Me.LblLamaSewa.TabIndex = 38
        Me.LblLamaSewa.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Bisque
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(111, 374)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 20)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Lama Sewa"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label18.Location = New System.Drawing.Point(112, 395)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 17)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "(Per Hari)"
        '
        'RTBKetUser
        '
        Me.RTBKetUser.Location = New System.Drawing.Point(262, 206)
        Me.RTBKetUser.Margin = New System.Windows.Forms.Padding(2)
        Me.RTBKetUser.Name = "RTBKetUser"
        Me.RTBKetUser.Size = New System.Drawing.Size(129, 55)
        Me.RTBKetUser.TabIndex = 40
        Me.RTBKetUser.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label19.Location = New System.Drawing.Point(262, 263)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(118, 13)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Isi Mengenai Barangmu"
        '
        'LblJumlahKomentar
        '
        Me.LblJumlahKomentar.AutoSize = True
        Me.LblJumlahKomentar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblJumlahKomentar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblJumlahKomentar.Location = New System.Drawing.Point(394, 238)
        Me.LblJumlahKomentar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblJumlahKomentar.Name = "LblJumlahKomentar"
        Me.LblJumlahKomentar.Size = New System.Drawing.Size(27, 20)
        Me.LblJumlahKomentar.TabIndex = 42
        Me.LblJumlahKomentar.Text = "50"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(274, 395)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 17)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "(Belum denda)"
        '
        'NUDLamaSewa
        '
        Me.NUDLamaSewa.Location = New System.Drawing.Point(258, 122)
        Me.NUDLamaSewa.Margin = New System.Windows.Forms.Padding(2)
        Me.NUDLamaSewa.Name = "NUDLamaSewa"
        Me.NUDLamaSewa.Size = New System.Drawing.Size(67, 20)
        Me.NUDLamaSewa.TabIndex = 44
        '
        'LblKetUkuran
        '
        Me.LblKetUkuran.AutoSize = True
        Me.LblKetUkuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LblKetUkuran.Location = New System.Drawing.Point(96, 144)
        Me.LblKetUkuran.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblKetUkuran.Name = "LblKetUkuran"
        Me.LblKetUkuran.Size = New System.Drawing.Size(26, 13)
        Me.LblKetUkuran.TabIndex = 45
        Me.LblKetUkuran.Text = "Ket."
        '
        'SewaLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 574)
        Me.Controls.Add(Me.LblKetUkuran)
        Me.Controls.Add(Me.NUDLamaSewa)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LblJumlahKomentar)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.RTBKetUser)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.LblLamaSewa)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.LblNamaLocker)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LsbLockerTersedia)
        Me.Controls.Add(Me.BtnNoSewa)
        Me.Controls.Add(Me.BtnYesSewa)
        Me.Controls.Add(Me.LblTotalBiaya)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblBiayaPerJam)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBUkuranLocker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SewaLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Sewa Loker"
        CType(Me.NUDLamaSewa, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
