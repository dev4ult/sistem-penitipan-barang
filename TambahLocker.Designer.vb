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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblharga = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CBLokasi = New System.Windows.Forms.ComboBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(74, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tambah Locker"
        '
        'CBukuran
        '
        Me.CBukuran.FormattingEnabled = True
        Me.CBukuran.Items.AddRange(New Object() {"Small", "Medium", "Large"})
        Me.CBukuran.Location = New System.Drawing.Point(12, 36)
        Me.CBukuran.Name = "CBukuran"
        Me.CBukuran.Size = New System.Drawing.Size(204, 21)
        Me.CBukuran.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel2.Controls.Add(Me.CBLokasi)
        Me.Panel2.Controls.Add(Me.btntambah)
        Me.Panel2.Controls.Add(Me.lblharga)
        Me.Panel2.Controls.Add(Me.CBukuran)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(41, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(234, 295)
        Me.Panel2.TabIndex = 4
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btntambah.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btntambah.Location = New System.Drawing.Point(51, 236)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(125, 23)
        Me.btntambah.TabIndex = 5
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(15, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ukuran"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(15, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Lokasi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Location = New System.Drawing.Point(35, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Biaya Sewa Perjam"
        '
        'lblharga
        '
        Me.lblharga.AutoSize = True
        Me.lblharga.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblharga.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.lblharga.Location = New System.Drawing.Point(75, 190)
        Me.lblharga.Name = "lblharga"
        Me.lblharga.Size = New System.Drawing.Size(44, 18)
        Me.lblharga.TabIndex = 10
        Me.lblharga.Text = "RP.0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 58)
        Me.Panel1.TabIndex = 11
        '
        'CBLokasi
        '
        Me.CBLokasi.FormattingEnabled = True
        Me.CBLokasi.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CBLokasi.Location = New System.Drawing.Point(12, 97)
        Me.CBLokasi.Name = "CBLokasi"
        Me.CBLokasi.Size = New System.Drawing.Size(204, 21)
        Me.CBLokasi.TabIndex = 3
        '
        'TambahLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(318, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "TambahLocker"
        Me.Text = "TambahLocker"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CBukuran As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btntambah As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblharga As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CBLokasi As ComboBox
End Class
