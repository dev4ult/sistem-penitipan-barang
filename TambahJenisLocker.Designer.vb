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
        Me.TxtBiaya = New System.Windows.Forms.TextBox()
        Me.TxtUkuran = New System.Windows.Forms.TextBox()
        Me.LblBiaya = New System.Windows.Forms.Label()
        Me.LblUkuran = New System.Windows.Forms.Label()
        Me.LblTambahJenisLocker = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(111, 202)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(138, 35)
        Me.BtnAdd.TabIndex = 16
        Me.BtnAdd.Text = "Tambah Jenis Locker"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtBiaya
        '
        Me.TxtBiaya.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBiaya.Location = New System.Drawing.Point(90, 128)
        Me.TxtBiaya.Name = "TxtBiaya"
        Me.TxtBiaya.Size = New System.Drawing.Size(233, 27)
        Me.TxtBiaya.TabIndex = 15
        '
        'TxtUkuran
        '
        Me.TxtUkuran.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUkuran.Location = New System.Drawing.Point(90, 81)
        Me.TxtUkuran.Name = "TxtUkuran"
        Me.TxtUkuran.Size = New System.Drawing.Size(233, 27)
        Me.TxtUkuran.TabIndex = 14
        '
        'LblBiaya
        '
        Me.LblBiaya.AutoSize = True
        Me.LblBiaya.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiaya.Location = New System.Drawing.Point(25, 131)
        Me.LblBiaya.Name = "LblBiaya"
        Me.LblBiaya.Size = New System.Drawing.Size(46, 19)
        Me.LblBiaya.TabIndex = 13
        Me.LblBiaya.Text = "Biaya"
        '
        'LblUkuran
        '
        Me.LblUkuran.AutoSize = True
        Me.LblUkuran.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUkuran.Location = New System.Drawing.Point(25, 84)
        Me.LblUkuran.Name = "LblUkuran"
        Me.LblUkuran.Size = New System.Drawing.Size(59, 19)
        Me.LblUkuran.TabIndex = 12
        Me.LblUkuran.Text = "Ukuran"
        '
        'LblTambahJenisLocker
        '
        Me.LblTambahJenisLocker.AutoSize = True
        Me.LblTambahJenisLocker.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTambahJenisLocker.Location = New System.Drawing.Point(22, 21)
        Me.LblTambahJenisLocker.Name = "LblTambahJenisLocker"
        Me.LblTambahJenisLocker.Size = New System.Drawing.Size(187, 26)
        Me.LblTambahJenisLocker.TabIndex = 11
        Me.LblTambahJenisLocker.Text = "Tambah Jenis Locker"
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(111, 243)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(138, 35)
        Me.BtnClose.TabIndex = 17
        Me.BtnClose.Text = "Kembali"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'TambahJenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 324)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtBiaya)
        Me.Controls.Add(Me.TxtUkuran)
        Me.Controls.Add(Me.LblBiaya)
        Me.Controls.Add(Me.LblUkuran)
        Me.Controls.Add(Me.LblTambahJenisLocker)
        Me.Name = "TambahJenisLocker"
        Me.Text = "Tambah Jenis Locker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtBiaya As TextBox
    Friend WithEvents TxtUkuran As TextBox
    Friend WithEvents LblBiaya As Label
    Friend WithEvents LblUkuran As Label
    Friend WithEvents LblTambahJenisLocker As Label
    Friend WithEvents BtnClose As Button
End Class
