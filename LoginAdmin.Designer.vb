﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginAdmin
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
        Me.LinkLBCustomer = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LBFMError = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TXTPassword = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BTNLogin = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TXTUmail = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinkLBCustomer
        '
        Me.LinkLBCustomer.AutoSize = True
        Me.LinkLBCustomer.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLBCustomer.LinkColor = System.Drawing.Color.RoyalBlue
        Me.LinkLBCustomer.Location = New System.Drawing.Point(125, 535)
        Me.LinkLBCustomer.Name = "LinkLBCustomer"
        Me.LinkLBCustomer.Size = New System.Drawing.Size(79, 19)
        Me.LinkLBCustomer.TabIndex = 18
        Me.LinkLBCustomer.TabStop = True
        Me.LinkLBCustomer.Text = "Customer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(186, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(290, 24)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Silahkan Login sebagai admin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 535)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Login sebagai"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Inter", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(208, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 49)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "DIGILOKER"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LBFMError)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.BTNLogin)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Location = New System.Drawing.Point(142, 154)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(18)
        Me.Panel3.Size = New System.Drawing.Size(377, 335)
        Me.Panel3.TabIndex = 19
        '
        'LBFMError
        '
        Me.LBFMError.AutoSize = True
        Me.LBFMError.Font = New System.Drawing.Font("Inter", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBFMError.ForeColor = System.Drawing.Color.Red
        Me.LBFMError.Location = New System.Drawing.Point(19, 247)
        Me.LBFMError.Name = "LBFMError"
        Me.LBFMError.Size = New System.Drawing.Size(291, 16)
        Me.LBFMError.TabIndex = 11
        Me.LBFMError.Text = "Gagal! Username / Email atau Password salah"
        Me.LBFMError.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Inter", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(93, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 34)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Admin Login"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.AutoSize = True
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.TXTPassword)
        Me.Panel4.Location = New System.Drawing.Point(18, 188)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel4.Size = New System.Drawing.Size(343, 45)
        Me.Panel4.TabIndex = 7
        '
        'TXTPassword
        '
        Me.TXTPassword.BackColor = System.Drawing.Color.White
        Me.TXTPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTPassword.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPassword.Location = New System.Drawing.Point(9, 9)
        Me.TXTPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTPassword.Name = "TXTPassword"
        Me.TXTPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.TXTPassword.Size = New System.Drawing.Size(311, 25)
        Me.TXTPassword.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 19)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Username / Email"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 19)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Password"
        '
        'BTNLogin
        '
        Me.BTNLogin.BackColor = System.Drawing.Color.Black
        Me.BTNLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTNLogin.FlatAppearance.BorderSize = 0
        Me.BTNLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.BTNLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BTNLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNLogin.Font = New System.Drawing.Font("Inter", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLogin.ForeColor = System.Drawing.Color.White
        Me.BTNLogin.Location = New System.Drawing.Point(18, 272)
        Me.BTNLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNLogin.Name = "BTNLogin"
        Me.BTNLogin.Size = New System.Drawing.Size(343, 43)
        Me.BTNLogin.TabIndex = 2
        Me.BTNLogin.Text = "LOGIN"
        Me.BTNLogin.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.AutoSize = True
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.TXTUmail)
        Me.Panel5.Location = New System.Drawing.Point(18, 108)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel5.Size = New System.Drawing.Size(343, 45)
        Me.Panel5.TabIndex = 5
        '
        'TXTUmail
        '
        Me.TXTUmail.BackColor = System.Drawing.Color.White
        Me.TXTUmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTUmail.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUmail.Location = New System.Drawing.Point(9, 9)
        Me.TXTUmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTUmail.Name = "TXTUmail"
        Me.TXTUmail.Size = New System.Drawing.Size(311, 25)
        Me.TXTUmail.TabIndex = 0
        '
        'LoginAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(661, 584)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.LinkLBCustomer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Name = "LoginAdmin"
        Me.Text = "LoginAdmin"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLBCustomer As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LBFMError As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TXTPassword As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BTNLogin As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TXTUmail As TextBox
End Class
