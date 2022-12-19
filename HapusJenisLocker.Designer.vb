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
        Me.LbValueUkuran = New System.Windows.Forms.Label()
        Me.LbValueBiaya = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.LbValueInfoKet = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblHapusJenisLocker
        '
        Me.LblHapusJenisLocker.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHapusJenisLocker.Location = New System.Drawing.Point(16, 26)
        Me.LblHapusJenisLocker.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblHapusJenisLocker.Name = "LblHapusJenisLocker"
        Me.LblHapusJenisLocker.Size = New System.Drawing.Size(447, 32)
        Me.LblHapusJenisLocker.TabIndex = 12
        Me.LblHapusJenisLocker.Text = "Hapus Jenis Locker"
        Me.LblHapusJenisLocker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(144, 344)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(184, 43)
        Me.BtnClose.TabIndex = 19
        Me.BtnClose.Text = "Kembali"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblUkuran
        '
        Me.LblUkuran.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUkuran.Location = New System.Drawing.Point(16, 105)
        Me.LblUkuran.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUkuran.Name = "LblUkuran"
        Me.LblUkuran.Size = New System.Drawing.Size(111, 32)
        Me.LblUkuran.TabIndex = 20
        Me.LblUkuran.Text = "Ukuran   : "
        Me.LblUkuran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblBiaya
        '
        Me.LblBiaya.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBiaya.Location = New System.Drawing.Point(16, 170)
        Me.LblBiaya.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBiaya.Name = "LblBiaya"
        Me.LblBiaya.Size = New System.Drawing.Size(111, 32)
        Me.LblBiaya.TabIndex = 21
        Me.LblBiaya.Text = "Biaya      : "
        Me.LblBiaya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbValueUkuran
        '
        Me.LbValueUkuran.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValueUkuran.Location = New System.Drawing.Point(140, 105)
        Me.LbValueUkuran.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbValueUkuran.Name = "LbValueUkuran"
        Me.LbValueUkuran.Size = New System.Drawing.Size(323, 32)
        Me.LbValueUkuran.TabIndex = 22
        Me.LbValueUkuran.Text = "(Value Ukuran)"
        Me.LbValueUkuran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbValueBiaya
        '
        Me.LbValueBiaya.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValueBiaya.Location = New System.Drawing.Point(140, 170)
        Me.LbValueBiaya.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbValueBiaya.Name = "LbValueBiaya"
        Me.LbValueBiaya.Size = New System.Drawing.Size(323, 32)
        Me.LbValueBiaya.TabIndex = 23
        Me.LbValueBiaya.Text = "(Value Biaya)"
        Me.LbValueBiaya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(144, 293)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(184, 43)
        Me.BtnDelete.TabIndex = 24
        Me.BtnDelete.Text = "Hapus"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'LbValueInfoKet
        '
        Me.LbValueInfoKet.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValueInfoKet.Location = New System.Drawing.Point(140, 218)
        Me.LbValueInfoKet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbValueInfoKet.Name = "LbValueInfoKet"
        Me.LbValueInfoKet.Size = New System.Drawing.Size(323, 32)
        Me.LbValueInfoKet.TabIndex = 26
        Me.LbValueInfoKet.Text = "(Value Biaya)"
        Me.LbValueInfoKet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 218)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 32)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Info Ket  : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HapusJenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 400)
        Me.Controls.Add(Me.LbValueInfoKet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.LbValueBiaya)
        Me.Controls.Add(Me.LbValueUkuran)
        Me.Controls.Add(Me.LblBiaya)
        Me.Controls.Add(Me.LblUkuran)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LblHapusJenisLocker)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HapusJenisLocker"
        Me.Text = "HapusJenisLocker"
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
End Class
