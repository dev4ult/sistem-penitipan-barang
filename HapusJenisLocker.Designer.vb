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
        Me.SuspendLayout()
        '
        'LblHapusJenisLocker
        '
        Me.LblHapusJenisLocker.AutoSize = True
        Me.LblHapusJenisLocker.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHapusJenisLocker.Location = New System.Drawing.Point(91, 21)
        Me.LblHapusJenisLocker.Name = "LblHapusJenisLocker"
        Me.LblHapusJenisLocker.Size = New System.Drawing.Size(173, 26)
        Me.LblHapusJenisLocker.TabIndex = 12
        Me.LblHapusJenisLocker.Text = "Hapus Jenis Locker"
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(109, 225)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(138, 35)
        Me.BtnClose.TabIndex = 19
        Me.BtnClose.Text = "Kembali"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'HapusJenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 361)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LblHapusJenisLocker)
        Me.Name = "HapusJenisLocker"
        Me.Text = "HapusJenisLocker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHapusJenisLocker As Label
    Friend WithEvents BtnClose As Button
End Class
