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
        Me.BTNKembali = New System.Windows.Forms.Button()
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
        Me.DataKoleksiJenisLocker.Location = New System.Drawing.Point(22, 77)
        Me.DataKoleksiJenisLocker.Name = "DataKoleksiJenisLocker"
        Me.DataKoleksiJenisLocker.ReadOnly = True
        Me.DataKoleksiJenisLocker.RowHeadersWidth = 51
        Me.DataKoleksiJenisLocker.Size = New System.Drawing.Size(344, 417)
        Me.DataKoleksiJenisLocker.TabIndex = 0
        '
        'BtnCreate
        '
        Me.BtnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnCreate.Location = New System.Drawing.Point(20, 33)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(97, 33)
        Me.BtnCreate.TabIndex = 1
        Me.BtnCreate.Text = "TAMBAH"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnUpdate.Location = New System.Drawing.Point(20, 72)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(97, 33)
        Me.BtnUpdate.TabIndex = 2
        Me.BtnUpdate.Text = "UBAH"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnDelete.Location = New System.Drawing.Point(20, 111)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(97, 33)
        Me.BtnDelete.TabIndex = 3
        Me.BtnDelete.Text = "HAPUS"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'LblJenisLocker
        '
        Me.LblJenisLocker.BackColor = System.Drawing.Color.Black
        Me.LblJenisLocker.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenisLocker.ForeColor = System.Drawing.Color.White
        Me.LblJenisLocker.Location = New System.Drawing.Point(22, 15)
        Me.LblJenisLocker.Name = "LblJenisLocker"
        Me.LblJenisLocker.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.LblJenisLocker.Size = New System.Drawing.Size(522, 47)
        Me.LblJenisLocker.TabIndex = 4
        Me.LblJenisLocker.Text = "#  JENIS LOKER"
        Me.LblJenisLocker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTNKembali
        '
        Me.BTNKembali.BackColor = System.Drawing.Color.Black
        Me.BTNKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNKembali.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BTNKembali.ForeColor = System.Drawing.Color.White
        Me.BTNKembali.Location = New System.Drawing.Point(402, 261)
        Me.BTNKembali.Name = "BTNKembali"
        Me.BTNKembali.Size = New System.Drawing.Size(142, 33)
        Me.BTNKembali.TabIndex = 5
        Me.BTNKembali.Text = "KEMBALI"
        Me.BTNKembali.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCreate)
        Me.GroupBox1.Controls.Add(Me.BtnUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(402, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 167)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DataKoleksiJenisLocker)
        Me.Panel1.Controls.Add(Me.BTNKembali)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.LblJenisLocker)
        Me.Panel1.Location = New System.Drawing.Point(29, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 513)
        Me.Panel1.TabIndex = 7
        '
        'FormJenisLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(642, 565)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormJenisLocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents BTNKembali As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
End Class
