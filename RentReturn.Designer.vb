<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RentReturn
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblLockerName = New System.Windows.Forms.Label()
        Me.LblTanggalSewa = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblJmlHariPinjam = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTPTanggalKembali = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblTotaldanDenda = New System.Windows.Forms.Label()
        Me.BtnYesKembali = New System.Windows.Forms.Button()
        Me.BtnCancelKembali = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblDenda = New System.Windows.Forms.Label()
        Me.LblTelatHari = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(-1, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(728, 104)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Form Pengembalian Barang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(107, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Loker"
        '
        'LblLockerName
        '
        Me.LblLockerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LblLockerName.Location = New System.Drawing.Point(112, 192)
        Me.LblLockerName.Name = "LblLockerName"
        Me.LblLockerName.Size = New System.Drawing.Size(139, 29)
        Me.LblLockerName.TabIndex = 3
        Me.LblLockerName.Text = "X-X"
        Me.LblLockerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTanggalSewa
        '
        Me.LblTanggalSewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblTanggalSewa.Location = New System.Drawing.Point(112, 301)
        Me.LblTanggalSewa.Name = "LblTanggalSewa"
        Me.LblTanggalSewa.Size = New System.Drawing.Size(199, 29)
        Me.LblTanggalSewa.TabIndex = 5
        Me.LblTanggalSewa.Text = "X-X"
        Me.LblTanggalSewa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label5.Location = New System.Drawing.Point(107, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal Sewa"
        '
        'LblJmlHariPinjam
        '
        Me.LblJmlHariPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LblJmlHariPinjam.Location = New System.Drawing.Point(390, 192)
        Me.LblJmlHariPinjam.Name = "LblJmlHariPinjam"
        Me.LblJmlHariPinjam.Size = New System.Drawing.Size(183, 29)
        Me.LblJmlHariPinjam.TabIndex = 7
        Me.LblJmlHariPinjam.Text = "X-X"
        Me.LblJmlHariPinjam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label7.Location = New System.Drawing.Point(385, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 29)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Rencana Pinjam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(385, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 29)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tanggal Kembali"
        '
        'DTPTanggalKembali
        '
        Me.DTPTanggalKembali.CustomFormat = "dd MMMM yyyy"
        Me.DTPTanggalKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DTPTanggalKembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTanggalKembali.Location = New System.Drawing.Point(390, 305)
        Me.DTPTanggalKembali.Name = "DTPTanggalKembali"
        Me.DTPTanggalKembali.Size = New System.Drawing.Size(192, 26)
        Me.DTPTanggalKembali.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightCoral
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(140, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 56)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Denda"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DimGray
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(140, 518)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(424, 56)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total Biaya"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTotaldanDenda
        '
        Me.LblTotaldanDenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LblTotaldanDenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblTotaldanDenda.Location = New System.Drawing.Point(334, 584)
        Me.LblTotaldanDenda.Name = "LblTotaldanDenda"
        Me.LblTotaldanDenda.Size = New System.Drawing.Size(200, 42)
        Me.LblTotaldanDenda.TabIndex = 13
        Me.LblTotaldanDenda.Text = "0"
        Me.LblTotaldanDenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnYesKembali
        '
        Me.BtnYesKembali.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnYesKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnYesKembali.Location = New System.Drawing.Point(364, 671)
        Me.BtnYesKembali.Name = "BtnYesKembali"
        Me.BtnYesKembali.Size = New System.Drawing.Size(200, 55)
        Me.BtnYesKembali.TabIndex = 32
        Me.BtnYesKembali.Text = "Ya"
        Me.BtnYesKembali.UseVisualStyleBackColor = True
        '
        'BtnCancelKembali
        '
        Me.BtnCancelKembali.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnCancelKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnCancelKembali.Location = New System.Drawing.Point(140, 671)
        Me.BtnCancelKembali.Name = "BtnCancelKembali"
        Me.BtnCancelKembali.Size = New System.Drawing.Size(200, 55)
        Me.BtnCancelKembali.TabIndex = 33
        Me.BtnCancelKembali.Text = "Tidak"
        Me.BtnCancelKembali.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label8.Location = New System.Drawing.Point(260, 584)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 42)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Rp."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label9.Location = New System.Drawing.Point(343, 390)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 42)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Rp."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDenda
        '
        Me.LblDenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LblDenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblDenda.Location = New System.Drawing.Point(417, 390)
        Me.LblDenda.Name = "LblDenda"
        Me.LblDenda.Size = New System.Drawing.Size(147, 42)
        Me.LblDenda.TabIndex = 35
        Me.LblDenda.Text = "0"
        Me.LblDenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTelatHari
        '
        Me.LblTelatHari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblTelatHari.Location = New System.Drawing.Point(136, 441)
        Me.LblTelatHari.Name = "LblTelatHari"
        Me.LblTelatHari.Size = New System.Drawing.Size(70, 42)
        Me.LblTelatHari.TabIndex = 37
        Me.LblTelatHari.Text = "0"
        Me.LblTelatHari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(199, 441)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 42)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Hari x 10"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RentReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 758)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LblTelatHari)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblDenda)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnCancelKembali)
        Me.Controls.Add(Me.BtnYesKembali)
        Me.Controls.Add(Me.LblTotaldanDenda)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DTPTanggalKembali)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblJmlHariPinjam)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblTanggalSewa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblLockerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RentReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rent Return Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblLockerName As Label
    Friend WithEvents LblTanggalSewa As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblJmlHariPinjam As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DTPTanggalKembali As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblTotaldanDenda As Label
    Friend WithEvents BtnYesKembali As Button
    Friend WithEvents BtnCancelKembali As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblDenda As Label
    Friend WithEvents LblTelatHari As Label
    Friend WithEvents Label11 As Label
End Class
