<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.PanelUmail.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTUmail
        '
        Me.TXTUmail.BackColor = System.Drawing.Color.White
        Me.TXTUmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTUmail.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUmail.Location = New System.Drawing.Point(9, 9)
        Me.TXTUmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTUmail.Name = "TXTUmail"
        Me.TXTUmail.Size = New System.Drawing.Size(287, 25)
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
        Me.BTNLogin.Font = New System.Drawing.Font("Inter", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLogin.ForeColor = System.Drawing.Color.White
        Me.BTNLogin.Location = New System.Drawing.Point(18, 272)
        Me.BTNLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNLogin.Name = "BTNLogin"
        Me.BTNLogin.Size = New System.Drawing.Size(309, 43)
        Me.BTNLogin.TabIndex = 2
        Me.BTNLogin.Text = "LOGIN"
        Me.BTNLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 19)
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
        Me.PanelUmail.Location = New System.Drawing.Point(18, 108)
        Me.PanelUmail.Name = "PanelUmail"
        Me.PanelUmail.Padding = New System.Windows.Forms.Padding(5)
        Me.PanelUmail.Size = New System.Drawing.Size(309, 45)
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
        Me.Panel1.Location = New System.Drawing.Point(18, 188)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(309, 45)
        Me.Panel1.TabIndex = 7
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
        Me.TXTPassword.Size = New System.Drawing.Size(287, 25)
        Me.TXTPassword.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSize = True
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
        Me.Panel2.Location = New System.Drawing.Point(174, 147)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(18)
        Me.Panel2.Size = New System.Drawing.Size(347, 354)
        Me.Panel2.TabIndex = 1
        '
        'LBFMError
        '
        Me.LBFMError.AutoSize = True
        Me.LBFMError.Font = New System.Drawing.Font("Inter", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBFMError.ForeColor = System.Drawing.Color.Red
        Me.LBFMError.Location = New System.Drawing.Point(19, 247)
        Me.LBFMError.Name = "LBFMError"
        Me.LBFMError.Size = New System.Drawing.Size(248, 16)
        Me.LBFMError.TabIndex = 11
        Me.LBFMError.Text = "Username / Email atau Password salah"
        Me.LBFMError.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Inter", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(89, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 34)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Form Login"
        '
        'LinkLBSignup
        '
        Me.LinkLBSignup.AutoSize = True
        Me.LinkLBSignup.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLBSignup.LinkColor = System.Drawing.Color.RoyalBlue
        Me.LinkLBSignup.Location = New System.Drawing.Point(177, 315)
        Me.LinkLBSignup.Name = "LinkLBSignup"
        Me.LinkLBSignup.Size = New System.Drawing.Size(63, 19)
        Me.LinkLBSignup.TabIndex = 9
        Me.LinkLBSignup.TabStop = True
        Me.LinkLBSignup.Text = "Sign up"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Belum memiliki akun?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Inter", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(165, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 49)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Digiloker"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(170, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(351, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Silahkan Login untuk memakai loker"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(687, 540)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Padding = New System.Windows.Forms.Padding(35)
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
End Class
