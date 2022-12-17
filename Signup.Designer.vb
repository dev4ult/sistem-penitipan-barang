<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Signup
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
        Me.TXTUsername = New System.Windows.Forms.TextBox()
        Me.TXTEmail = New System.Windows.Forms.TextBox()
        Me.TXTPassword = New System.Windows.Forms.TextBox()
        Me.BTNSignUp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXTUsername
        '
        Me.TXTUsername.Location = New System.Drawing.Point(323, 118)
        Me.TXTUsername.Name = "TXTUsername"
        Me.TXTUsername.Size = New System.Drawing.Size(100, 22)
        Me.TXTUsername.TabIndex = 0
        '
        'TXTEmail
        '
        Me.TXTEmail.Location = New System.Drawing.Point(323, 164)
        Me.TXTEmail.Name = "TXTEmail"
        Me.TXTEmail.Size = New System.Drawing.Size(100, 22)
        Me.TXTEmail.TabIndex = 1
        '
        'TXTPassword
        '
        Me.TXTPassword.Location = New System.Drawing.Point(323, 207)
        Me.TXTPassword.Name = "TXTPassword"
        Me.TXTPassword.Size = New System.Drawing.Size(100, 22)
        Me.TXTPassword.TabIndex = 2
        '
        'BTNSignUp
        '
        Me.BTNSignUp.Location = New System.Drawing.Point(334, 256)
        Me.BTNSignUp.Name = "BTNSignUp"
        Me.BTNSignUp.Size = New System.Drawing.Size(75, 23)
        Me.BTNSignUp.TabIndex = 3
        Me.BTNSignUp.Text = "Sign Up"
        Me.BTNSignUp.UseVisualStyleBackColor = True
        '
        'Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTNSignUp)
        Me.Controls.Add(Me.TXTPassword)
        Me.Controls.Add(Me.TXTEmail)
        Me.Controls.Add(Me.TXTUsername)
        Me.Name = "Signup"
        Me.Text = "Form User Baru"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTUsername As TextBox
    Friend WithEvents TXTEmail As TextBox
    Friend WithEvents TXTPassword As TextBox
    Friend WithEvents BTNSignUp As Button
End Class
