<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJenisLocker
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
        Me.DataKoleksiJenisLocker = New System.Windows.Forms.DataGridView()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.LblJenisLocker = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataKoleksiJenisLocker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataKoleksiJenisLocker
        '
        Me.DataKoleksiJenisLocker.AllowUserToAddRows = False
        Me.DataKoleksiJenisLocker.AllowUserToDeleteRows = False
        Me.DataKoleksiJenisLocker.BackgroundColor = System.Drawing.Color.White
        Me.DataKoleksiJenisLocker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataKoleksiJenisLocker.Location = New System.Drawing.Point(29, 95)
        Me.DataKoleksiJenisLocker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataKoleksiJenisLocker.Name = "DataKoleksiJenisLocker"
        Me.DataKoleksiJenisLocker.ReadOnly = True
        Me.DataKoleksiJenisLocker.RowHeadersWidth = 51
        Me.DataKoleksiJenisLocker.Size = New System.Drawing.Size(459, 513)
        Me.DataKoleksiJenisLocker.TabIndex = 0
        '
        'BtnCreate
        '
        Me.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnCreate.Location = New System.Drawing.Point(27, 41)
        Me.BtnCreate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(129, 41)
        Me.BtnCreate.TabIndex = 1
        Me.BtnCreate.Text = "TAMBAH"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnUpdate.Location = New System.Drawing.Point(27, 89)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(129, 41)
        Me.BtnUpdate.TabIndex = 2
        Me.BtnUpdate.Text = "UBAH"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnDelete.Location = New System.Drawing.Point(27, 137)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(129, 41)
        Me.BtnDelete.TabIndex = 3
        Me.BtnDelete.Text = "HAPUS"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'LblJenisLocker
        '
        Me.LblJenisLocker.BackColor = System.Drawing.Color.Black
        Me.LblJenisLocker.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisLocker.ForeColor = System.Drawing.Color.White
        Me.LblJenisLocker.Location = New System.Drawing.Point(29, 18)
        Me.LblJenisLocker.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJenisLocker.Name = "LblJenisLocker"
        Me.LblJenisLocker.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.LblJenisLocker.Size = New System.Drawing.Size(696, 58)
        Me.LblJenisLocker.TabIndex = 4
        Me.LblJenisLocker.Text = "#  JENIS LOKER"
        Me.LblJenisLocker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(536, 321)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 41)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "KEMBALI"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCreate)
        Me.GroupBox1.Controls.Add(Me.BtnUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(536, 95)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(189, 206)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DataKoleksiJenisLocker)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.LblJenisLocker)
        Me.Panel1.Location = New System.Drawing.Point(39, 31)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(762, 631)
        Me.Panel1.TabIndex = 7
        '
        'FormJenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(856, 695)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormJenisLocker"
        Me.Text = "Data Jenis Loker"
        CType(Me.DataKoleksiJenisLocker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataKoleksiJenisLocker As DataGridView
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents LblJenisLocker As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
End Class
