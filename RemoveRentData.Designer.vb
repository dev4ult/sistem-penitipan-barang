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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblRemoveLockerName = New System.Windows.Forms.Label()
        Me.BtnRemoveLockerName = New System.Windows.Forms.Button()
        Me.BtnCancelRemove = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah Yakin Menghapus Data Ini ?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRemoveLockerName
        '
        Me.LblRemoveLockerName.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LblRemoveLockerName.ForeColor = System.Drawing.Color.Black
        Me.LblRemoveLockerName.Location = New System.Drawing.Point(14, 113)
        Me.LblRemoveLockerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblRemoveLockerName.Name = "LblRemoveLockerName"
        Me.LblRemoveLockerName.Size = New System.Drawing.Size(357, 47)
        Me.LblRemoveLockerName.TabIndex = 1
        Me.LblRemoveLockerName.Text = "Nama Loker"
        Me.LblRemoveLockerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnRemoveLockerName
        '
        Me.BtnRemoveLockerName.BackColor = System.Drawing.Color.Black
        Me.BtnRemoveLockerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemoveLockerName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveLockerName.ForeColor = System.Drawing.Color.White
        Me.BtnRemoveLockerName.Location = New System.Drawing.Point(74, 199)
        Me.BtnRemoveLockerName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnRemoveLockerName.Name = "BtnRemoveLockerName"
        Me.BtnRemoveLockerName.Size = New System.Drawing.Size(108, 36)
        Me.BtnRemoveLockerName.TabIndex = 2
        Me.BtnRemoveLockerName.Text = "HAPUS"
        Me.BtnRemoveLockerName.UseVisualStyleBackColor = False
        '
        'BtnCancelRemove
        '
        Me.BtnCancelRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelRemove.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelRemove.Location = New System.Drawing.Point(202, 199)
        Me.BtnCancelRemove.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnCancelRemove.Name = "BtnCancelRemove"
        Me.BtnCancelRemove.Size = New System.Drawing.Size(108, 36)
        Me.BtnCancelRemove.TabIndex = 3
        Me.BtnCancelRemove.Text = "BATAL"
        Me.BtnCancelRemove.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnRemoveLockerName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnCancelRemove)
        Me.Panel1.Controls.Add(Me.LblRemoveLockerName)
        Me.Panel1.Location = New System.Drawing.Point(22, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 262)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(387, 45)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "HAPUS DATA SEWA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RemoveRentData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(436, 310)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "RemoveRentData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hapus Data Sewa"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents LblRemoveLockerName As Label
    Friend WithEvents BtnRemoveLockerName As Button
    Friend WithEvents BtnCancelRemove As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
