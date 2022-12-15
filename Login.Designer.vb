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
        Me.TXTPassword = New System.Windows.Forms.TextBox()
        Me.BTNLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXTUmail
        '
        Me.TXTUmail.Location = New System.Drawing.Point(273, 116)
        Me.TXTUmail.Name = "TXTUmail"
        Me.TXTUmail.Size = New System.Drawing.Size(100, 20)
        Me.TXTUmail.TabIndex = 0
        '
        'TXTPassword
        '
        Me.TXTPassword.Location = New System.Drawing.Point(273, 157)
        Me.TXTPassword.Name = "TXTPassword"
        Me.TXTPassword.Size = New System.Drawing.Size(100, 20)
        Me.TXTPassword.TabIndex = 1
        '
        'BTNLogin
        '
        Me.BTNLogin.Location = New System.Drawing.Point(288, 194)
        Me.BTNLogin.Name = "BTNLogin"
        Me.BTNLogin.Size = New System.Drawing.Size(75, 23)
        Me.BTNLogin.TabIndex = 2
        Me.BTNLogin.Text = "Login"
        Me.BTNLogin.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTNLogin)
        Me.Controls.Add(Me.TXTPassword)
        Me.Controls.Add(Me.TXTUmail)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTUmail As TextBox
    Friend WithEvents TXTPassword As TextBox
    Friend WithEvents BTNLogin As Button
End Class
