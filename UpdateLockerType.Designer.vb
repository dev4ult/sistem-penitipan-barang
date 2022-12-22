<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateLockerType
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
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblInfoKet = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtInfoKet = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBiaya = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblUpdateJenisLocker
        '
        Me.LblUpdateJenisLocker.BackColor = System.Drawing.Color.Black
        Me.LblUpdateJenisLocker.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUpdateJenisLocker.ForeColor = System.Drawing.Color.White
        Me.LblUpdateJenisLocker.Location = New System.Drawing.Point(-1, -1)
        Me.LblUpdateJenisLocker.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUpdateJenisLocker.Name = "LblUpdateJenisLocker"
        Me.LblUpdateJenisLocker.Size = New System.Drawing.Size(337, 42)
        Me.LblUpdateJenisLocker.TabIndex = 5
        Me.LblUpdateJenisLocker.Text = "UPDATE JENIS LOKER"
        Me.LblUpdateJenisLocker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblUkuran
        '
        Me.LblUkuran.AutoSize = True
        Me.LblUkuran.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LblUkuran.Location = New System.Drawing.Point(22, 60)
        Me.LblUkuran.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUkuran.Name = "LblUkuran"
        Me.LblUkuran.Size = New System.Drawing.Size(55, 19)
        Me.LblUkuran.TabIndex = 6
        Me.LblUkuran.Text = "Ukuran"
        '
        'LblBiaya
        '
        Me.LblBiaya.AutoSize = True
        Me.LblBiaya.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LblBiaya.Location = New System.Drawing.Point(22, 116)
        Me.LblBiaya.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblBiaya.Name = "LblBiaya"
        Me.LblBiaya.Size = New System.Drawing.Size(45, 19)
        Me.LblBiaya.TabIndex = 7
        Me.LblBiaya.Text = "Biaya"
        '
        'TxtUkuran
        '
        Me.TxtUkuran.BackColor = System.Drawing.Color.White
        Me.TxtUkuran.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUkuran.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUkuran.Location = New System.Drawing.Point(10, 4)
        Me.TxtUkuran.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtUkuran.Name = "TxtUkuran"
        Me.TxtUkuran.Size = New System.Drawing.Size(255, 20)
        Me.TxtUkuran.TabIndex = 8
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.Black
        Me.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubmit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnSubmit.ForeColor = System.Drawing.Color.White
        Me.BtnSubmit.Location = New System.Drawing.Point(155, 269)
        Me.BtnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(66, 28)
        Me.BtnSubmit.TabIndex = 10
        Me.BtnSubmit.Text = "UPDATE"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnClose.Location = New System.Drawing.Point(236, 269)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(66, 28)
        Me.BtnClose.TabIndex = 18
        Me.BtnClose.Text = "BATAL"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblInfoKet
        '
        Me.LblInfoKet.AutoSize = True
        Me.LblInfoKet.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LblInfoKet.Location = New System.Drawing.Point(23, 177)
        Me.LblInfoKet.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInfoKet.Name = "LblInfoKet"
        Me.LblInfoKet.Size = New System.Drawing.Size(83, 19)
        Me.LblInfoKet.TabIndex = 19
        Me.LblInfoKet.Text = "Keterangan"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.BtnSubmit)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.LblUpdateJenisLocker)
        Me.Panel1.Controls.Add(Me.LblInfoKet)
        Me.Panel1.Controls.Add(Me.LblUkuran)
        Me.Panel1.Controls.Add(Me.LblBiaya)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(16, 18)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(337, 315)
        Me.Panel1.TabIndex = 21
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.TxtInfoKet)
        Me.Panel4.Location = New System.Drawing.Point(26, 198)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(276, 29)
        Me.Panel4.TabIndex = 9
        '
        'TxtInfoKet
        '
        Me.TxtInfoKet.BackColor = System.Drawing.Color.White
        Me.TxtInfoKet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtInfoKet.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInfoKet.Location = New System.Drawing.Point(10, 3)
        Me.TxtInfoKet.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtInfoKet.Name = "TxtInfoKet"
        Me.TxtInfoKet.Size = New System.Drawing.Size(255, 20)
        Me.TxtInfoKet.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TxtBiaya)
        Me.Panel3.Location = New System.Drawing.Point(26, 137)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(276, 29)
        Me.Panel3.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Rp."
        '
        'TxtBiaya
        '
        Me.TxtBiaya.BackColor = System.Drawing.Color.White
        Me.TxtBiaya.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBiaya.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBiaya.Location = New System.Drawing.Point(37, 3)
        Me.TxtBiaya.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBiaya.Name = "TxtBiaya"
        Me.TxtBiaya.Size = New System.Drawing.Size(231, 20)
        Me.TxtBiaya.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtUkuran)
        Me.Panel2.Location = New System.Drawing.Point(26, 79)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(276, 29)
        Me.Panel2.TabIndex = 7
        '
        'UpdateJenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(374, 359)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UpdateJenisLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Jenis Loker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblUpdateJenisLocker As Label
    Friend WithEvents LblUkuran As Label
    Friend WithEvents LblBiaya As Label
    Friend WithEvents TxtUkuran As TextBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblInfoKet As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TxtInfoKet As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtBiaya As TextBox
    Friend WithEvents Label1 As Label
End Class
