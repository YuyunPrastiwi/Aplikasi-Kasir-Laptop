<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Laptop
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.kodebarang = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgvlaptop = New System.Windows.Forms.DataGridView()
        Me.kode_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_laptop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_laptop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_laptop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.dgvlaptop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 149)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 194)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 4
        '
        'kodebarang
        '
        Me.kodebarang.Location = New System.Drawing.Point(192, 25)
        Me.kodebarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.kodebarang.Name = "kodebarang"
        Me.kodebarang.Size = New System.Drawing.Size(148, 26)
        Me.kodebarang.TabIndex = 5
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(192, 68)
        Me.nama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(544, 26)
        Me.nama.TabIndex = 6
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(192, 109)
        Me.harga.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(544, 26)
        Me.harga.TabIndex = 7
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(192, 145)
        Me.jumlah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(220, 26)
        Me.jumlah.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 242)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Input"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(180, 242)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "New"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(302, 242)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 35)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(423, 242)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 35)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dgvlaptop
        '
        Me.dgvlaptop.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvlaptop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlaptop.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode_barang, Me.nama_laptop, Me.harga_laptop, Me.jumlah_laptop})
        Me.dgvlaptop.Location = New System.Drawing.Point(42, 300)
        Me.dgvlaptop.Name = "dgvlaptop"
        Me.dgvlaptop.RowTemplate.Height = 28
        Me.dgvlaptop.Size = New System.Drawing.Size(792, 277)
        Me.dgvlaptop.TabIndex = 14
        '
        'kode_barang
        '
        Me.kode_barang.HeaderText = "kode barang"
        Me.kode_barang.Name = "kode_barang"
        '
        'nama_laptop
        '
        Me.nama_laptop.HeaderText = "nama"
        Me.nama_laptop.Name = "nama_laptop"
        '
        'harga_laptop
        '
        Me.harga_laptop.HeaderText = "harga"
        Me.harga_laptop.Name = "harga_laptop"
        '
        'jumlah_laptop
        '
        Me.jumlah_laptop.HeaderText = "jumlah"
        Me.jumlah_laptop.Name = "jumlah_laptop"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(241, 184)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 29)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Simpan"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Data_Laptop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(870, 598)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.dgvlaptop)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.kodebarang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Data_Laptop"
        Me.Text = "Data_Laptop"
        CType(Me.dgvlaptop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents kodebarang As System.Windows.Forms.TextBox
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents harga As System.Windows.Forms.TextBox
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents dgvlaptop As System.Windows.Forms.DataGridView
    Friend WithEvents kode_barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_laptop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga_laptop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah_laptop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
