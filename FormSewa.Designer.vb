<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSewa
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
        Me.TxtBoxHari = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBoxJam = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBJenisTempat = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBNamaTempat = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBLokerTersedia = New System.Windows.Forms.ComboBox()
        Me.LblHargaSewa = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblTotalBiaya = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(258, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rencana Sewa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtBoxHari
        '
        Me.TxtBoxHari.Location = New System.Drawing.Point(242, 134)
        Me.TxtBoxHari.Name = "TxtBoxHari"
        Me.TxtBoxHari.Size = New System.Drawing.Size(91, 22)
        Me.TxtBoxHari.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(339, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hari"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(490, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jam"
        '
        'TxtBoxJam
        '
        Me.TxtBoxJam.Location = New System.Drawing.Point(393, 134)
        Me.TxtBoxJam.Name = "TxtBoxJam"
        Me.TxtBoxJam.Size = New System.Drawing.Size(91, 22)
        Me.TxtBoxJam.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(290, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 39)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Pilih Tempat"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBJenisTempat
        '
        Me.CBJenisTempat.FormattingEnabled = True
        Me.CBJenisTempat.Location = New System.Drawing.Point(191, 274)
        Me.CBJenisTempat.Name = "CBJenisTempat"
        Me.CBJenisTempat.Size = New System.Drawing.Size(176, 24)
        Me.CBJenisTempat.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(186, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Jenis Tempat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(427, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Nama Tempat"
        '
        'CBNamaTempat
        '
        Me.CBNamaTempat.FormattingEnabled = True
        Me.CBNamaTempat.Location = New System.Drawing.Point(432, 274)
        Me.CBNamaTempat.Name = "CBNamaTempat"
        Me.CBNamaTempat.Size = New System.Drawing.Size(176, 24)
        Me.CBNamaTempat.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label6.Location = New System.Drawing.Point(184, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(244, 39)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Loker Tersedia"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBLokerTersedia
        '
        Me.CBLokerTersedia.FormattingEnabled = True
        Me.CBLokerTersedia.Location = New System.Drawing.Point(438, 335)
        Me.CBLokerTersedia.Name = "CBLokerTersedia"
        Me.CBLokerTersedia.Size = New System.Drawing.Size(176, 24)
        Me.CBLokerTersedia.TabIndex = 13
        '
        'LblHargaSewa
        '
        Me.LblHargaSewa.AutoSize = True
        Me.LblHargaSewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblHargaSewa.Location = New System.Drawing.Point(504, 371)
        Me.LblHargaSewa.Name = "LblHargaSewa"
        Me.LblHargaSewa.Size = New System.Drawing.Size(23, 25)
        Me.LblHargaSewa.TabIndex = 14
        Me.LblHargaSewa.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(455, 371)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Rp."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(573, 371)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 25)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "(Per Jam)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label10.Location = New System.Drawing.Point(102, 453)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(283, 39)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Total Biaya Sewa"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTotalBiaya
        '
        Me.LblTotalBiaya.AutoSize = True
        Me.LblTotalBiaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LblTotalBiaya.Location = New System.Drawing.Point(488, 453)
        Me.LblTotalBiaya.Name = "LblTotalBiaya"
        Me.LblTotalBiaya.Size = New System.Drawing.Size(131, 39)
        Me.LblTotalBiaya.TabIndex = 18
        Me.LblTotalBiaya.Text = "100000"
        Me.LblTotalBiaya.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 557)
        Me.Controls.Add(Me.LblTotalBiaya)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LblHargaSewa)
        Me.Controls.Add(Me.CBLokerTersedia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CBNamaTempat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBJenisTempat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtBoxJam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBoxHari)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormSewa"
        Me.Text = "FormSewa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxHari As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBoxJam As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBJenisTempat As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CBNamaTempat As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CBLokerTersedia As ComboBox
    Friend WithEvents LblHargaSewa As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LblTotalBiaya As Label
End Class
