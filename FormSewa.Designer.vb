﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSewa
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
        Me.TxtBoxWaktuSewa = New System.Windows.Forms.TextBox()
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
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(25, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Sewa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(123, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Keterangan"
        '
        'CBUkuranLocker
        '
        Me.CBUkuranLocker.FormattingEnabled = True
        Me.CBUkuranLocker.Location = New System.Drawing.Point(128, 136)
        Me.CBUkuranLocker.Name = "CBUkuranLocker"
        Me.CBUkuranLocker.Size = New System.Drawing.Size(176, 24)
        Me.CBUkuranLocker.TabIndex = 6
        Me.CBUkuranLocker.Text = "-- Pilih Ukuran --"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(123, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Ukuran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(358, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Ketersediaan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(460, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Jam"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(358, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Lama Sewa"
        '
        'TxtBoxWaktuSewa
        '
        Me.TxtBoxWaktuSewa.Location = New System.Drawing.Point(363, 291)
        Me.TxtBoxWaktuSewa.Name = "TxtBoxWaktuSewa"
        Me.TxtBoxWaktuSewa.Size = New System.Drawing.Size(91, 22)
        Me.TxtBoxWaktuSewa.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(339, 419)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 25)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Biaya Sewa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(339, 444)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "(Per Jam)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(459, 432)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 25)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Rp."
        '
        'LblBiayaPerJam
        '
        Me.LblBiayaPerJam.AutoSize = True
        Me.LblBiayaPerJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblBiayaPerJam.Location = New System.Drawing.Point(494, 432)
        Me.LblBiayaPerJam.Name = "LblBiayaPerJam"
        Me.LblBiayaPerJam.Size = New System.Drawing.Size(45, 25)
        Me.LblBiayaPerJam.TabIndex = 27
        Me.LblBiayaPerJam.Text = "100"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(339, 486)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 25)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Total Biaya"
        '
        'LblTotalBiaya
        '
        Me.LblTotalBiaya.AutoSize = True
        Me.LblTotalBiaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblTotalBiaya.Location = New System.Drawing.Point(494, 486)
        Me.LblTotalBiaya.Name = "LblTotalBiaya"
        Me.LblTotalBiaya.Size = New System.Drawing.Size(45, 25)
        Me.LblTotalBiaya.TabIndex = 30
        Me.LblTotalBiaya.Text = "100"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(459, 486)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 25)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Rp."
        '
        'BtnYesSewa
        '
        Me.BtnYesSewa.Cursor = System.Windows.Forms.Cursors.No
        Me.BtnYesSewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnYesSewa.Location = New System.Drawing.Point(348, 581)
        Me.BtnYesSewa.Name = "BtnYesSewa"
        Me.BtnYesSewa.Size = New System.Drawing.Size(191, 55)
        Me.BtnYesSewa.TabIndex = 31
        Me.BtnYesSewa.Text = "Sewa"
        Me.BtnYesSewa.UseVisualStyleBackColor = True
        '
        'BtnNoSewa
        '
        Me.BtnNoSewa.Cursor = System.Windows.Forms.Cursors.No
        Me.BtnNoSewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnNoSewa.Location = New System.Drawing.Point(128, 581)
        Me.BtnNoSewa.Name = "BtnNoSewa"
        Me.BtnNoSewa.Size = New System.Drawing.Size(191, 55)
        Me.BtnNoSewa.TabIndex = 32
        Me.BtnNoSewa.Text = "Cancel"
        Me.BtnNoSewa.UseVisualStyleBackColor = True
        '
        'LsbLockerTersedia
        '
        Me.LsbLockerTersedia.FormattingEnabled = True
        Me.LsbLockerTersedia.ItemHeight = 16
        Me.LsbLockerTersedia.Location = New System.Drawing.Point(364, 131)
        Me.LsbLockerTersedia.Name = "LsbLockerTersedia"
        Me.LsbLockerTersedia.Size = New System.Drawing.Size(135, 100)
        Me.LsbLockerTersedia.TabIndex = 33
        '
        'LblNamaLocker
        '
        Me.LblNamaLocker.AutoSize = True
        Me.LblNamaLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblNamaLocker.Location = New System.Drawing.Point(259, 419)
        Me.LblNamaLocker.Name = "LblNamaLocker"
        Me.LblNamaLocker.Size = New System.Drawing.Size(44, 25)
        Me.LblNamaLocker.TabIndex = 36
        Me.LblNamaLocker.Text = "A-1"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(123, 419)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 25)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Nama Loker"
        '
        'LblLamaSewa
        '
        Me.LblLamaSewa.AutoSize = True
        Me.LblLamaSewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblLamaSewa.Location = New System.Drawing.Point(259, 486)
        Me.LblLamaSewa.Name = "LblLamaSewa"
        Me.LblLamaSewa.Size = New System.Drawing.Size(23, 25)
        Me.LblLamaSewa.TabIndex = 38
        Me.LblLamaSewa.Text = "4"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(123, 486)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(116, 25)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Lama Sewa"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label18.Location = New System.Drawing.Point(124, 511)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 20)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "(Per Jam)"
        '
        'RTBKetUser
        '
        Me.RTBKetUser.Location = New System.Drawing.Point(131, 298)
        Me.RTBKetUser.Name = "RTBKetUser"
        Me.RTBKetUser.Size = New System.Drawing.Size(171, 67)
        Me.RTBKetUser.TabIndex = 40
        Me.RTBKetUser.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label19.Location = New System.Drawing.Point(132, 368)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(156, 17)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Isi Mengenai Barangmu"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label20.Location = New System.Drawing.Point(308, 337)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 25)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "50"
        '
        'FormSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 706)
        Me.Controls.Add(Me.Label20)
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
        Me.Controls.Add(Me.TxtBoxWaktuSewa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBUkuranLocker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormSewa"
        Me.Text = "FormSewa"
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
    Friend WithEvents TxtBoxWaktuSewa As TextBox
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
    Friend WithEvents Label20 As Label
End Class