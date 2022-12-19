<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ValueUkuran = New System.Windows.Forms.Label()
        Me.ValueBiaya = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblHapusJenisLocker
        '
        Me.LblHapusJenisLocker.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHapusJenisLocker.Location = New System.Drawing.Point(12, 21)
        Me.LblHapusJenisLocker.Name = "LblHapusJenisLocker"
        Me.LblHapusJenisLocker.Size = New System.Drawing.Size(335, 26)
        Me.LblHapusJenisLocker.TabIndex = 12
        Me.LblHapusJenisLocker.Text = "Hapus Jenis Locker"
        Me.LblHapusJenisLocker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(109, 249)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(138, 35)
        Me.BtnClose.TabIndex = 19
        Me.BtnClose.Text = "Kembali"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblUkuran
        '
        Me.LblUkuran.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUkuran.Location = New System.Drawing.Point(12, 85)
        Me.LblUkuran.Name = "LblUkuran"
        Me.LblUkuran.Size = New System.Drawing.Size(83, 26)
        Me.LblUkuran.TabIndex = 20
        Me.LblUkuran.Text = "Ukuran   : "
        Me.LblUkuran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblBiaya
        '
        Me.LblBiaya.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiaya.Location = New System.Drawing.Point(12, 138)
        Me.LblBiaya.Name = "LblBiaya"
        Me.LblBiaya.Size = New System.Drawing.Size(83, 26)
        Me.LblBiaya.TabIndex = 21
        Me.LblBiaya.Text = "Biaya      : "
        Me.LblBiaya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValueUkuran
        '
        Me.ValueUkuran.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValueUkuran.Location = New System.Drawing.Point(105, 85)
        Me.ValueUkuran.Name = "ValueUkuran"
        Me.ValueUkuran.Size = New System.Drawing.Size(242, 26)
        Me.ValueUkuran.TabIndex = 22
        Me.ValueUkuran.Text = "(Value Ukuran)"
        Me.ValueUkuran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ValueBiaya
        '
        Me.ValueBiaya.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValueBiaya.Location = New System.Drawing.Point(105, 138)
        Me.ValueBiaya.Name = "ValueBiaya"
        Me.ValueBiaya.Size = New System.Drawing.Size(242, 26)
        Me.ValueBiaya.TabIndex = 23
        Me.ValueBiaya.Text = "(Value Biaya)"
        Me.ValueBiaya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(109, 208)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(138, 35)
        Me.BtnDelete.TabIndex = 24
        Me.BtnDelete.Text = "Hapus"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'HapusJenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 325)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.ValueBiaya)
        Me.Controls.Add(Me.ValueUkuran)
        Me.Controls.Add(Me.LblBiaya)
        Me.Controls.Add(Me.LblUkuran)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LblHapusJenisLocker)
        Me.Name = "HapusJenisLocker"
        Me.Text = "HapusJenisLocker"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblHapusJenisLocker As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblUkuran As Label
    Friend WithEvents LblBiaya As Label
    Friend WithEvents ValueUkuran As Label
    Friend WithEvents ValueBiaya As Label
    Friend WithEvents BtnDelete As Button
End Class
