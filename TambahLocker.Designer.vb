<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahLocker
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
        Me.CBukuran = New System.Windows.Forms.ComboBox()
        Me.TBnama = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TBlokasi = New System.Windows.Forms.TextBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblharga = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(94, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tambah Locker"
        '
        'CBukuran
        '
        Me.CBukuran.FormattingEnabled = True
        Me.CBukuran.Items.AddRange(New Object() {"Kecil", "Sedang ", "Besar"})
        Me.CBukuran.Location = New System.Drawing.Point(11, 12)
        Me.CBukuran.Name = "CBukuran"
        Me.CBukuran.Size = New System.Drawing.Size(204, 21)
        Me.CBukuran.TabIndex = 1
        '
        'TBnama
        '
        Me.TBnama.Location = New System.Drawing.Point(11, 12)
        Me.TBnama.Name = "TBnama"
        Me.TBnama.Size = New System.Drawing.Size(204, 20)
        Me.TBnama.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TBnama)
        Me.Panel1.Location = New System.Drawing.Point(46, 190)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 47)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CBukuran)
        Me.Panel2.Location = New System.Drawing.Point(46, 106)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(234, 48)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TBlokasi)
        Me.Panel3.Location = New System.Drawing.Point(46, 286)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(234, 47)
        Me.Panel3.TabIndex = 4
        '
        'TBlokasi
        '
        Me.TBlokasi.Location = New System.Drawing.Point(11, 13)
        Me.TBlokasi.Name = "TBlokasi"
        Me.TBlokasi.Size = New System.Drawing.Size(204, 20)
        Me.TBlokasi.TabIndex = 2
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(98, 398)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(125, 23)
        Me.btntambah.TabIndex = 5
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ukuran"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Lokasi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Biaya Sewa Perjam"
        '
        'lblharga
        '
        Me.lblharga.AutoSize = True
        Me.lblharga.Location = New System.Drawing.Point(163, 362)
        Me.lblharga.Name = "lblharga"
        Me.lblharga.Size = New System.Drawing.Size(31, 13)
        Me.lblharga.TabIndex = 10
        Me.lblharga.Text = "RP.0"
        '
        'TambahLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 450)
        Me.Controls.Add(Me.lblharga)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahLocker"
        Me.Text = "TambahLocker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CBukuran As ComboBox
    Friend WithEvents TBnama As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TBlokasi As TextBox
    Friend WithEvents btntambah As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblharga As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
