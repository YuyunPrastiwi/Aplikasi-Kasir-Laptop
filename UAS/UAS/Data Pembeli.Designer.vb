<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Pembeli
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJenisKelamin = New System.Windows.Forms.TextBox()
        Me.txtNIK = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvpembeli = New System.Windows.Forms.DataGridView()
        Me.nama_pembeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis_kelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvpembeli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(315, 433)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 32)
        Me.Button5.TabIndex = 40
        Me.Button5.Text = "Delete "
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(203, 433)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 32)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(152, 368)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 32)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "New"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(258, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Apply"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(364, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Simpan "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(203, 297)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(250, 26)
        Me.txtAlamat.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Alamat "
        '
        'txtJenisKelamin
        '
        Me.txtJenisKelamin.Location = New System.Drawing.Point(203, 229)
        Me.txtJenisKelamin.Name = "txtJenisKelamin"
        Me.txtJenisKelamin.Size = New System.Drawing.Size(250, 26)
        Me.txtJenisKelamin.TabIndex = 33
        '
        'txtNIK
        '
        Me.txtNIK.Location = New System.Drawing.Point(203, 168)
        Me.txtNIK.Name = "txtNIK"
        Me.txtNIK.Size = New System.Drawing.Size(297, 26)
        Me.txtNIK.TabIndex = 32
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(203, 111)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(250, 26)
        Me.txtNama.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "NIK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nama"
        '
        'dgvpembeli
        '
        Me.dgvpembeli.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvpembeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpembeli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nama_pembeli, Me.NIK, Me.jenis_kelamin, Me.alamat})
        Me.dgvpembeli.Location = New System.Drawing.Point(601, 94)
        Me.dgvpembeli.Name = "dgvpembeli"
        Me.dgvpembeli.RowTemplate.Height = 28
        Me.dgvpembeli.Size = New System.Drawing.Size(585, 434)
        Me.dgvpembeli.TabIndex = 41
        '
        'nama_pembeli
        '
        Me.nama_pembeli.HeaderText = "nama"
        Me.nama_pembeli.Name = "nama_pembeli"
        '
        'NIK
        '
        Me.NIK.HeaderText = "NIK"
        Me.NIK.Name = "NIK"
        '
        'jenis_kelamin
        '
        Me.jenis_kelamin.HeaderText = "jenis kelamin"
        Me.jenis_kelamin.Name = "jenis_kelamin"
        '
        'alamat
        '
        Me.alamat.HeaderText = "alamat"
        Me.alamat.Name = "alamat"
        '
        'Data_Pembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1233, 621)
        Me.Controls.Add(Me.dgvpembeli)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtJenisKelamin)
        Me.Controls.Add(Me.txtNIK)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Data_Pembeli"
        Me.Text = "Data_Pembeli"
        CType(Me.dgvpembeli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtJenisKelamin As System.Windows.Forms.TextBox
    Friend WithEvents txtNIK As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvpembeli As System.Windows.Forms.DataGridView
    Friend WithEvents nama_pembeli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NIK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jenis_kelamin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamat As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
