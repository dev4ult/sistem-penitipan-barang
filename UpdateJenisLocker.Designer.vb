<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateJenisLocker
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
        Me.LblUpdateJenisLocker = New System.Windows.Forms.Label()
        Me.LblUkuran = New System.Windows.Forms.Label()
        Me.LblBiaya = New System.Windows.Forms.Label()
        Me.TxtUkuran = New System.Windows.Forms.TextBox()
        Me.TxtBiaya = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblUpdateJenisLocker
        '
        Me.LblUpdateJenisLocker.AutoSize = True
        Me.LblUpdateJenisLocker.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUpdateJenisLocker.Location = New System.Drawing.Point(22, 21)
        Me.LblUpdateJenisLocker.Name = "LblUpdateJenisLocker"
        Me.LblUpdateJenisLocker.Size = New System.Drawing.Size(184, 26)
        Me.LblUpdateJenisLocker.TabIndex = 5
        Me.LblUpdateJenisLocker.Text = "Update Jenis Locker"
        '
        'LblUkuran
        '
        Me.LblUkuran.AutoSize = True
        Me.LblUkuran.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUkuran.Location = New System.Drawing.Point(25, 84)
        Me.LblUkuran.Name = "LblUkuran"
        Me.LblUkuran.Size = New System.Drawing.Size(59, 19)
        Me.LblUkuran.TabIndex = 6
        Me.LblUkuran.Text = "Ukuran"
        '
        'LblBiaya
        '
        Me.LblBiaya.AutoSize = True
        Me.LblBiaya.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiaya.Location = New System.Drawing.Point(25, 131)
        Me.LblBiaya.Name = "LblBiaya"
        Me.LblBiaya.Size = New System.Drawing.Size(46, 19)
        Me.LblBiaya.TabIndex = 7
        Me.LblBiaya.Text = "Biaya"
        '
        'TxtUkuran
        '
        Me.TxtUkuran.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUkuran.Location = New System.Drawing.Point(90, 81)
        Me.TxtUkuran.Name = "TxtUkuran"
        Me.TxtUkuran.Size = New System.Drawing.Size(233, 27)
        Me.TxtUkuran.TabIndex = 8
        '
        'TxtBiaya
        '
        Me.TxtBiaya.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBiaya.Location = New System.Drawing.Point(90, 128)
        Me.TxtBiaya.Name = "TxtBiaya"
        Me.TxtBiaya.Size = New System.Drawing.Size(233, 27)
        Me.TxtBiaya.TabIndex = 9
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(111, 202)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(138, 35)
        Me.BtnSubmit.TabIndex = 10
        Me.BtnSubmit.Text = "Simpan Perubahan"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(111, 243)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(138, 35)
        Me.BtnClose.TabIndex = 18
        Me.BtnClose.Text = "Kembali"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'UpdateJenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 324)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.TxtBiaya)
        Me.Controls.Add(Me.TxtUkuran)
        Me.Controls.Add(Me.LblBiaya)
        Me.Controls.Add(Me.LblUkuran)
        Me.Controls.Add(Me.LblUpdateJenisLocker)
        Me.Name = "UpdateJenisLocker"
        Me.Text = "Update Jenis Locker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUpdateJenisLocker As Label
    Friend WithEvents LblUkuran As Label
    Friend WithEvents LblBiaya As Label
    Friend WithEvents TxtUkuran As TextBox
    Friend WithEvents TxtBiaya As TextBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnClose As Button
End Class
