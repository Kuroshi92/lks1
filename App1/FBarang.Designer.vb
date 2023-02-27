<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBarang
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
        Me.ID = New System.Windows.Forms.TextBox()
        Me.txt_namabarang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_deskripsi = New System.Windows.Forms.TextBox()
        Me.txt_stok = New System.Windows.Forms.TextBox()
        Me.txt_hargajual = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_hargabeli = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_kosongkan = New System.Windows.Forms.Button()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.CB_Kategori = New System.Windows.Forms.ComboBox()
        Me.CB_Satuan = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_kodebarang = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(446, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(63, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang   :"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(1, 0)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(17, 27)
        Me.ID.TabIndex = 3
        '
        'txt_namabarang
        '
        Me.txt_namabarang.Location = New System.Drawing.Point(242, 130)
        Me.txt_namabarang.Name = "txt_namabarang"
        Me.txt_namabarang.Size = New System.Drawing.Size(289, 27)
        Me.txt_namabarang.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(63, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nama Kategori :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(64, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nama Satuan :"
        '
        'txt_deskripsi
        '
        Me.txt_deskripsi.Location = New System.Drawing.Point(241, 436)
        Me.txt_deskripsi.Multiline = True
        Me.txt_deskripsi.Name = "txt_deskripsi"
        Me.txt_deskripsi.Size = New System.Drawing.Size(289, 196)
        Me.txt_deskripsi.TabIndex = 11
        '
        'txt_stok
        '
        Me.txt_stok.Location = New System.Drawing.Point(241, 289)
        Me.txt_stok.Name = "txt_stok"
        Me.txt_stok.Size = New System.Drawing.Size(289, 27)
        Me.txt_stok.TabIndex = 12
        '
        'txt_hargajual
        '
        Me.txt_hargajual.Location = New System.Drawing.Point(241, 339)
        Me.txt_hargajual.Name = "txt_hargajual"
        Me.txt_hargajual.Size = New System.Drawing.Size(289, 27)
        Me.txt_hargajual.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(64, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Stok :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(63, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Harga Jual :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(64, 387)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Harga Beli :"
        '
        'txt_hargabeli
        '
        Me.txt_hargabeli.Location = New System.Drawing.Point(241, 388)
        Me.txt_hargabeli.Name = "txt_hargabeli"
        Me.txt_hargabeli.Size = New System.Drawing.Size(288, 27)
        Me.txt_hargabeli.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(64, 453)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 25)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Deskripsi :"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(691, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(570, 503)
        Me.DataGridView1.TabIndex = 19
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(559, 105)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(94, 29)
        Me.btn_input.TabIndex = 20
        Me.btn_input.Text = "Input"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(559, 187)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(94, 29)
        Me.btn_edit.TabIndex = 21
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(559, 269)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(94, 29)
        Me.btn_hapus.TabIndex = 22
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_kosongkan
        '
        Me.btn_kosongkan.Location = New System.Drawing.Point(559, 361)
        Me.btn_kosongkan.Name = "btn_kosongkan"
        Me.btn_kosongkan.Size = New System.Drawing.Size(94, 29)
        Me.btn_kosongkan.TabIndex = 23
        Me.btn_kosongkan.Text = "Kosongkan"
        Me.btn_kosongkan.UseVisualStyleBackColor = True
        '
        'btn_kembali
        '
        Me.btn_kembali.Location = New System.Drawing.Point(12, 649)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(94, 29)
        Me.btn_kembali.TabIndex = 24
        Me.btn_kembali.Text = "Kembali"
        Me.btn_kembali.UseVisualStyleBackColor = True
        '
        'CB_Kategori
        '
        Me.CB_Kategori.FormattingEnabled = True
        Me.CB_Kategori.Location = New System.Drawing.Point(240, 181)
        Me.CB_Kategori.Name = "CB_Kategori"
        Me.CB_Kategori.Size = New System.Drawing.Size(289, 28)
        Me.CB_Kategori.TabIndex = 25
        '
        'CB_Satuan
        '
        Me.CB_Satuan.FormattingEnabled = True
        Me.CB_Satuan.Location = New System.Drawing.Point(240, 238)
        Me.CB_Satuan.Name = "CB_Satuan"
        Me.CB_Satuan.Size = New System.Drawing.Size(290, 28)
        Me.CB_Satuan.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(64, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 25)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Kode Barang :"
        '
        'txt_kodebarang
        '
        Me.txt_kodebarang.Location = New System.Drawing.Point(242, 87)
        Me.txt_kodebarang.Name = "txt_kodebarang"
        Me.txt_kodebarang.Size = New System.Drawing.Size(288, 27)
        Me.txt_kodebarang.TabIndex = 28
        '
        'FBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1273, 690)
        Me.Controls.Add(Me.txt_kodebarang)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CB_Satuan)
        Me.Controls.Add(Me.CB_Kategori)
        Me.Controls.Add(Me.btn_kembali)
        Me.Controls.Add(Me.btn_kosongkan)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_input)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_hargabeli)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_hargajual)
        Me.Controls.Add(Me.txt_stok)
        Me.Controls.Add(Me.txt_deskripsi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_namabarang)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FBarang"
        Me.Text = "FBarang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents txt_namabarang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_deskripsi As TextBox
    Friend WithEvents txt_stok As TextBox
    Friend WithEvents txt_hargajual As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_hargabeli As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_input As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_kosongkan As Button
    Friend WithEvents btn_kembali As Button
    Friend WithEvents CB_Kategori As ComboBox
    Friend WithEvents CB_Satuan As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_kodebarang As TextBox
End Class
