﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.TXTUmail = New System.Windows.Forms.TextBox()
        Me.BTNLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelUmail = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TXTPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBFMError = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLBSignup = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLBAdmin = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelUmail.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTUmail
        '
        Me.TXTUmail.BackColor = System.Drawing.Color.White
        Me.TXTUmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTUmail.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUmail.Location = New System.Drawing.Point(7, 7)
        Me.TXTUmail.Name = "TXTUmail"
        Me.TXTUmail.Size = New System.Drawing.Size(232, 20)
        Me.TXTUmail.TabIndex = 0
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
        Me.BTNLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLogin.ForeColor = System.Drawing.Color.White
        Me.BTNLogin.Location = New System.Drawing.Point(14, 221)
        Me.BTNLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNLogin.Name = "BTNLogin"
        Me.BTNLogin.Size = New System.Drawing.Size(256, 35)
        Me.BTNLogin.TabIndex = 2
        Me.BTNLogin.Text = "LOGIN"
        Me.BTNLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username / Email"
        '
        'PanelUmail
        '
        Me.PanelUmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelUmail.AutoSize = True
        Me.PanelUmail.BackColor = System.Drawing.Color.White
        Me.PanelUmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelUmail.Controls.Add(Me.TXTUmail)
        Me.PanelUmail.Location = New System.Drawing.Point(14, 88)
        Me.PanelUmail.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelUmail.Name = "PanelUmail"
        Me.PanelUmail.Padding = New System.Windows.Forms.Padding(4)
        Me.PanelUmail.Size = New System.Drawing.Size(256, 37)
        Me.PanelUmail.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TXTPassword)
        Me.Panel1.Location = New System.Drawing.Point(14, 153)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel1.Size = New System.Drawing.Size(256, 37)
        Me.Panel1.TabIndex = 7
        '
        'TXTPassword
        '
        Me.TXTPassword.BackColor = System.Drawing.Color.White
        Me.TXTPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTPassword.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPassword.Location = New System.Drawing.Point(7, 7)
        Me.TXTPassword.Name = "TXTPassword"
        Me.TXTPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.TXTPassword.Size = New System.Drawing.Size(232, 20)
        Me.TXTPassword.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 135)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LBFMError)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.LinkLBSignup)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.BTNLogin)
        Me.Panel2.Controls.Add(Me.PanelUmail)
        Me.Panel2.Location = New System.Drawing.Point(121, 115)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(14, 15, 14, 15)
        Me.Panel2.Size = New System.Drawing.Size(283, 288)
        Me.Panel2.TabIndex = 1
        '
        'LBFMError
        '
        Me.LBFMError.AutoSize = True
        Me.LBFMError.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBFMError.ForeColor = System.Drawing.Color.Red
        Me.LBFMError.Location = New System.Drawing.Point(14, 201)
        Me.LBFMError.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBFMError.Name = "LBFMError"
        Me.LBFMError.Size = New System.Drawing.Size(192, 13)
        Me.LBFMError.TabIndex = 11
        Me.LBFMError.Text = "Username / Email atau Password salah"
        Me.LBFMError.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Form Login"
        '
        'LinkLBSignup
        '
        Me.LinkLBSignup.AutoSize = True
        Me.LinkLBSignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLBSignup.LinkColor = System.Drawing.Color.RoyalBlue
        Me.LinkLBSignup.Location = New System.Drawing.Point(133, 256)
        Me.LinkLBSignup.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLBSignup.Name = "LinkLBSignup"
        Me.LinkLBSignup.Size = New System.Drawing.Size(49, 15)
        Me.LinkLBSignup.TabIndex = 9
        Me.LinkLBSignup.TabStop = True
        Me.LinkLBSignup.Text = "Sign up"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 256)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Belum memiliki akun?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(168, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 37)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "DIGILOKER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(128, 72)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(263, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Silahkan Login untuk memakai loker"
        '
        'LinkLBAdmin
        '
        Me.LinkLBAdmin.AutoSize = True
        Me.LinkLBAdmin.BackColor = System.Drawing.Color.Transparent
        Me.LinkLBAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLBAdmin.LinkColor = System.Drawing.Color.RoyalBlue
        Me.LinkLBAdmin.Location = New System.Drawing.Point(94, 423)
        Me.LinkLBAdmin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLBAdmin.Name = "LinkLBAdmin"
        Me.LinkLBAdmin.Size = New System.Drawing.Size(42, 15)
        Me.LinkLBAdmin.TabIndex = 13
        Me.LinkLBAdmin.TabStop = True
        Me.LinkLBAdmin.Text = "Admin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 423)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Login sebagai"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(515, 459)
        Me.Controls.Add(Me.LinkLBAdmin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Padding = New System.Windows.Forms.Padding(26, 28, 26, 28)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.PanelUmail.ResumeLayout(False)
        Me.PanelUmail.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTUmail As TextBox
    Friend WithEvents BTNLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelUmail As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TXTPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LinkLBSignup As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LBFMError As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLBAdmin As LinkLabel
    Friend WithEvents Label7 As Label
End Class
