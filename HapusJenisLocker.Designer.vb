﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusJenisLocker
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
        Me.LblHapusJenisLocker = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblUkuran = New System.Windows.Forms.Label()
        Me.LblBiaya = New System.Windows.Forms.Label()
        Me.LbValueUkuran = New System.Windows.Forms.Label()
        Me.LbValueBiaya = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.LbValueInfoKet = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbValueKeterangan = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblHapusJenisLocker
        '
        Me.LblHapusJenisLocker.BackColor = System.Drawing.Color.Black
        Me.LblHapusJenisLocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblHapusJenisLocker.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LblHapusJenisLocker.ForeColor = System.Drawing.Color.White
        Me.LblHapusJenisLocker.Location = New System.Drawing.Point(-1, 0)
        Me.LblHapusJenisLocker.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblHapusJenisLocker.Name = "LblHapusJenisLocker"
        Me.LblHapusJenisLocker.Size = New System.Drawing.Size(372, 42)
        Me.LblHapusJenisLocker.TabIndex = 12
        Me.LblHapusJenisLocker.Text = "HAPUS JENIS LOKER"
        Me.LblHapusJenisLocker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Black
        Me.BtnClose.Location = New System.Drawing.Point(287, 227)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(68, 28)
        Me.BtnClose.TabIndex = 19
        Me.BtnClose.Text = "BATAL"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'LblUkuran
        '
        Me.LblUkuran.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUkuran.Location = New System.Drawing.Point(14, 9)
        Me.LblUkuran.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUkuran.Name = "LblUkuran"
        Me.LblUkuran.Size = New System.Drawing.Size(76, 21)
        Me.LblUkuran.TabIndex = 20
        Me.LblUkuran.Text = "Ukuran         "
        Me.LblUkuran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblBiaya
        '
        Me.LblBiaya.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiaya.Location = New System.Drawing.Point(14, 38)
        Me.LblBiaya.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblBiaya.Name = "LblBiaya"
        Me.LblBiaya.Size = New System.Drawing.Size(97, 21)
        Me.LblBiaya.TabIndex = 21
        Me.LblBiaya.Text = "Biaya "
        Me.LblBiaya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbValueUkuran
        '
        Me.LbValueUkuran.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValueUkuran.Location = New System.Drawing.Point(115, 9)
        Me.LbValueUkuran.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbValueUkuran.Name = "LbValueUkuran"
        Me.LbValueUkuran.Size = New System.Drawing.Size(210, 21)
        Me.LbValueUkuran.TabIndex = 22
        Me.LbValueUkuran.Text = "XXXXX"
        Me.LbValueUkuran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbValueBiaya
        '
        Me.LbValueBiaya.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValueBiaya.Location = New System.Drawing.Point(115, 40)
        Me.LbValueBiaya.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbValueBiaya.Name = "LbValueBiaya"
        Me.LbValueBiaya.Size = New System.Drawing.Size(210, 21)
        Me.LbValueBiaya.TabIndex = 23
        Me.LbValueBiaya.Text = "Rp. XXXXX"
        Me.LbValueBiaya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(205, 227)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(69, 28)
        Me.BtnDelete.TabIndex = 24
        Me.BtnDelete.Text = "HAPUS"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'LbValueInfoKet
        '
        Me.LbValueInfoKet.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValueInfoKet.Location = New System.Drawing.Point(105, 177)
        Me.LbValueInfoKet.Name = "LbValueInfoKet"
        Me.LbValueInfoKet.Size = New System.Drawing.Size(242, 26)
        Me.LbValueInfoKet.TabIndex = 26
        Me.LbValueInfoKet.Text = "(Value Biaya)"
        Me.LbValueInfoKet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 26)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Info Ket  : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LbValueKeterangan)
        Me.Panel1.Controls.Add(Me.LblUkuran)
        Me.Panel1.Controls.Add(Me.LbValueInfoKet)
        Me.Panel1.Controls.Add(Me.LblBiaya)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LbValueBiaya)
        Me.Panel1.Controls.Add(Me.LbValueUkuran)
        Me.Panel1.Location = New System.Drawing.Point(13, 100)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(342, 109)
        Me.Panel1.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 21)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Keterangan "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbValueKeterangan
        '
        Me.LbValueKeterangan.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValueKeterangan.Location = New System.Drawing.Point(115, 72)
        Me.LbValueKeterangan.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbValueKeterangan.Name = "LbValueKeterangan"
        Me.LbValueKeterangan.Size = New System.Drawing.Size(210, 21)
        Me.LbValueKeterangan.TabIndex = 27
        Me.LbValueKeterangan.Text = "XXXXXX"
        Me.LbValueKeterangan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(10, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Apakah anda yakin ingin menghapus jenis loker ini ?"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.LblHapusJenisLocker)
        Me.Panel2.Controls.Add(Me.BtnDelete)
        Me.Panel2.Controls.Add(Me.BtnClose)
        Me.Panel2.Location = New System.Drawing.Point(26, 25)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(372, 272)
        Me.Panel2.TabIndex = 29
        '
        'HapusJenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(426, 327)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "HapusJenisLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hapus Jenis Loker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblHapusJenisLocker As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblUkuran As Label
    Friend WithEvents LblBiaya As Label
    Friend WithEvents LbValueUkuran As Label
    Friend WithEvents LbValueBiaya As Label
    Friend WithEvents BtnDelete As Button
    Friend WithEvents LbValueInfoKet As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LbValueKeterangan As Label
End Class
