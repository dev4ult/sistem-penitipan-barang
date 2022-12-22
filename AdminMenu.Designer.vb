<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTNDataPenyewaan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNMonitorJenisLoker = New System.Windows.Forms.Button()
        Me.BTNFormMonitorLoker = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BTNDataPenyewaan)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BTNLogout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BTNMonitorJenisLoker)
        Me.Panel1.Controls.Add(Me.BTNFormMonitorLoker)
        Me.Panel1.Location = New System.Drawing.Point(18, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(875, 535)
        Me.Panel1.TabIndex = 37
        '
        'BTNDataPenyewaan
        '
        Me.BTNDataPenyewaan.BackColor = System.Drawing.Color.White
        Me.BTNDataPenyewaan.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BTNDataPenyewaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNDataPenyewaan.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNDataPenyewaan.ForeColor = System.Drawing.Color.Black
        Me.BTNDataPenyewaan.Location = New System.Drawing.Point(23, 292)
        Me.BTNDataPenyewaan.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNDataPenyewaan.Name = "BTNDataPenyewaan"
        Me.BTNDataPenyewaan.Size = New System.Drawing.Size(498, 121)
        Me.BTNDataPenyewaan.TabIndex = 38
        Me.BTNDataPenyewaan.Text = "DATA PENYEWAAN"
        Me.BTNDataPenyewaan.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(723, 480)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 33)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "DIGILOKER"
        '
        'BTNLogout
        '
        Me.BTNLogout.BackColor = System.Drawing.Color.Black
        Me.BTNLogout.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BTNLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNLogout.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLogout.ForeColor = System.Drawing.Color.White
        Me.BTNLogout.Location = New System.Drawing.Point(30, 477)
        Me.BTNLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNLogout.Name = "BTNLogout"
        Me.BTNLogout.Size = New System.Drawing.Size(108, 36)
        Me.BTNLogout.TabIndex = 35
        Me.BTNLogout.Text = "LOGOUT"
        Me.BTNLogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(822, 72)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "# ADMIN MENU"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTNMonitorJenisLoker
        '
        Me.BTNMonitorJenisLoker.BackColor = System.Drawing.Color.White
        Me.BTNMonitorJenisLoker.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BTNMonitorJenisLoker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNMonitorJenisLoker.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMonitorJenisLoker.ForeColor = System.Drawing.Color.Black
        Me.BTNMonitorJenisLoker.Location = New System.Drawing.Point(286, 143)
        Me.BTNMonitorJenisLoker.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNMonitorJenisLoker.Name = "BTNMonitorJenisLoker"
        Me.BTNMonitorJenisLoker.Size = New System.Drawing.Size(236, 121)
        Me.BTNMonitorJenisLoker.TabIndex = 34
        Me.BTNMonitorJenisLoker.Text = "JENIS LOKER"
        Me.BTNMonitorJenisLoker.UseVisualStyleBackColor = False
        '
        'BTNFormMonitorLoker
        '
        Me.BTNFormMonitorLoker.BackColor = System.Drawing.Color.Black
        Me.BTNFormMonitorLoker.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BTNFormMonitorLoker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNFormMonitorLoker.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNFormMonitorLoker.ForeColor = System.Drawing.Color.White
        Me.BTNFormMonitorLoker.Location = New System.Drawing.Point(23, 143)
        Me.BTNFormMonitorLoker.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNFormMonitorLoker.Name = "BTNFormMonitorLoker"
        Me.BTNFormMonitorLoker.Size = New System.Drawing.Size(236, 121)
        Me.BTNFormMonitorLoker.TabIndex = 32
        Me.BTNFormMonitorLoker.Text = "MONITOR LOKER"
        Me.BTNFormMonitorLoker.UseVisualStyleBackColor = False
        '
        'AdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(909, 590)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AdminMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTNDataPenyewaan As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNMonitorJenisLoker As Button
    Friend WithEvents BTNFormMonitorLoker As Button
End Class
