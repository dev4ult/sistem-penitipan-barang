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
        Me.TxtInfoKet = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblUpdateJenisLocker
        '
        Me.LblUpdateJenisLocker.AutoSize = True
        Me.LblUpdateJenisLocker.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUpdateJenisLocker.Location = New System.Drawing.Point(29, 26)
        Me.LblUpdateJenisLocker.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUpdateJenisLocker.Name = "LblUpdateJenisLocker"
        Me.LblUpdateJenisLocker.Size = New System.Drawing.Size(237, 33)
        Me.LblUpdateJenisLocker.TabIndex = 5
        Me.LblUpdateJenisLocker.Text = "Update Jenis Locker"
        '
        'LblUkuran
        '
        Me.LblUkuran.AutoSize = True
        Me.LblUkuran.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUkuran.Location = New System.Drawing.Point(33, 103)
        Me.LblUkuran.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUkuran.Name = "LblUkuran"
        Me.LblUkuran.Size = New System.Drawing.Size(72, 24)
        Me.LblUkuran.TabIndex = 6
        Me.LblUkuran.Text = "Ukuran"
        '
        'LblBiaya
        '
        Me.LblBiaya.AutoSize = True
        Me.LblBiaya.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiaya.Location = New System.Drawing.Point(33, 161)
        Me.LblBiaya.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBiaya.Name = "LblBiaya"
        Me.LblBiaya.Size = New System.Drawing.Size(55, 24)
        Me.LblBiaya.TabIndex = 7
        Me.LblBiaya.Text = "Biaya"
        '
        'TxtUkuran
        '
        Me.TxtUkuran.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUkuran.Location = New System.Drawing.Point(120, 100)
        Me.TxtUkuran.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtUkuran.Name = "TxtUkuran"
        Me.TxtUkuran.Size = New System.Drawing.Size(309, 32)
        Me.TxtUkuran.TabIndex = 8
        '
        'TxtBiaya
        '
        Me.TxtBiaya.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBiaya.Location = New System.Drawing.Point(120, 158)
        Me.TxtBiaya.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBiaya.Name = "TxtBiaya"
        Me.TxtBiaya.Size = New System.Drawing.Size(309, 32)
        Me.TxtBiaya.TabIndex = 9
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.Location = New System.Drawing.Point(148, 249)
        Me.BtnSubmit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(184, 43)
        Me.BtnSubmit.TabIndex = 10
        Me.BtnSubmit.Text = "Simpan Perubahan"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(148, 299)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(184, 43)
        Me.BtnClose.TabIndex = 18
        Me.BtnClose.Text = "Kembali"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'TxtInfoKet
        '
        Me.TxtInfoKet.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInfoKet.Location = New System.Drawing.Point(120, 209)
        Me.TxtInfoKet.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtInfoKet.Name = "TxtInfoKet"
        Me.TxtInfoKet.Size = New System.Drawing.Size(309, 32)
        Me.TxtInfoKet.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 212)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Info Ket"
        '
        'UpdateJenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 399)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtInfoKet)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.TxtBiaya)
        Me.Controls.Add(Me.TxtUkuran)
        Me.Controls.Add(Me.LblBiaya)
        Me.Controls.Add(Me.LblUkuran)
        Me.Controls.Add(Me.LblUpdateJenisLocker)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents TxtInfoKet As TextBox
    Friend WithEvents Label1 As Label
End Class
