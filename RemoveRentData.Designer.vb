<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveRentData
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblRemoveLockerName = New System.Windows.Forms.Label()
        Me.BtnRemoveLockerName = New System.Windows.Forms.Button()
        Me.BtnCancelRemove = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-16, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 103)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(817, 103)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah Yakin Menghapus Data Ini ?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRemoveLockerName
        '
        Me.LblRemoveLockerName.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblRemoveLockerName.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.LblRemoveLockerName.Location = New System.Drawing.Point(2, 101)
        Me.LblRemoveLockerName.Name = "LblRemoveLockerName"
        Me.LblRemoveLockerName.Size = New System.Drawing.Size(802, 178)
        Me.LblRemoveLockerName.TabIndex = 1
        Me.LblRemoveLockerName.Text = "Nama Loker"
        Me.LblRemoveLockerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnRemoveLockerName
        '
        Me.BtnRemoveLockerName.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BtnRemoveLockerName.Location = New System.Drawing.Point(416, 355)
        Me.BtnRemoveLockerName.Name = "BtnRemoveLockerName"
        Me.BtnRemoveLockerName.Size = New System.Drawing.Size(160, 47)
        Me.BtnRemoveLockerName.TabIndex = 2
        Me.BtnRemoveLockerName.Text = "Hapus"
        Me.BtnRemoveLockerName.UseVisualStyleBackColor = True
        '
        'BtnCancelRemove
        '
        Me.BtnCancelRemove.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BtnCancelRemove.Location = New System.Drawing.Point(219, 355)
        Me.BtnCancelRemove.Name = "BtnCancelRemove"
        Me.BtnCancelRemove.Size = New System.Drawing.Size(160, 47)
        Me.BtnCancelRemove.TabIndex = 3
        Me.BtnCancelRemove.Text = "Tidak"
        Me.BtnCancelRemove.UseVisualStyleBackColor = True
        '
        'RemoveRentData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCancelRemove)
        Me.Controls.Add(Me.BtnRemoveLockerName)
        Me.Controls.Add(Me.LblRemoveLockerName)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RemoveRentData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RemoveRentData"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblRemoveLockerName As Label
    Friend WithEvents BtnRemoveLockerName As Button
    Friend WithEvents BtnCancelRemove As Button
End Class
