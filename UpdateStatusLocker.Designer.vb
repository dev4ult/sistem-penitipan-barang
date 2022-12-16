<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStatusLocker
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
        Me.GBstatus = New System.Windows.Forms.GroupBox()
        Me.rbterisi = New System.Windows.Forms.RadioButton()
        Me.rbkosong = New System.Windows.Forms.RadioButton()
        Me.GBstatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Locker"
        '
        'GBstatus
        '
        Me.GBstatus.Controls.Add(Me.rbkosong)
        Me.GBstatus.Controls.Add(Me.rbterisi)
        Me.GBstatus.Location = New System.Drawing.Point(32, 73)
        Me.GBstatus.Name = "GBstatus"
        Me.GBstatus.Size = New System.Drawing.Size(222, 78)
        Me.GBstatus.TabIndex = 1
        Me.GBstatus.TabStop = False
        Me.GBstatus.Text = "Status"
        '
        'rbterisi
        '
        Me.rbterisi.AutoSize = True
        Me.rbterisi.Location = New System.Drawing.Point(47, 22)
        Me.rbterisi.Name = "rbterisi"
        Me.rbterisi.Size = New System.Drawing.Size(50, 17)
        Me.rbterisi.TabIndex = 0
        Me.rbterisi.TabStop = True
        Me.rbterisi.Text = "Terisi"
        Me.rbterisi.UseVisualStyleBackColor = True
        '
        'rbkosong
        '
        Me.rbkosong.AutoSize = True
        Me.rbkosong.Location = New System.Drawing.Point(47, 48)
        Me.rbkosong.Name = "rbkosong"
        Me.rbkosong.Size = New System.Drawing.Size(61, 17)
        Me.rbkosong.TabIndex = 1
        Me.rbkosong.TabStop = True
        Me.rbkosong.Text = "Kosong"
        Me.rbkosong.UseVisualStyleBackColor = True
        '
        'UpdateStatusLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 183)
        Me.Controls.Add(Me.GBstatus)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateStatusLocker"
        Me.Text = "UpdateStatusLocker"
        Me.GBstatus.ResumeLayout(False)
        Me.GBstatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GBstatus As GroupBox
    Friend WithEvents rbkosong As RadioButton
    Friend WithEvents rbterisi As RadioButton
End Class
