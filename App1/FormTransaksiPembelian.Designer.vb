<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksiPembelian
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cb_namasup = New System.Windows.Forms.ComboBox()
        Me.cb_namabar = New System.Windows.Forms.ComboBox()
        Me.cb_status = New System.Windows.Forms.ComboBox()
        Me.txt_notransaksi = New System.Windows.Forms.TextBox()
        Me.txt_tanggal = New System.Windows.Forms.TextBox()
        Me.txt_jumlahbarang = New System.Windows.Forms.TextBox()
        Me.txt_diskon = New System.Windows.Forms.TextBox()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_kosongkan = New System.Windows.Forms.Button()
        Me.btn_hitung = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.lblHargaBarang = New System.Windows.Forms.Label()
        Me.lblHargaTotal = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(408, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Pembelian"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(56, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Supplier :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(56, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(56, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No Transaksi :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(56, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(390, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah Barang :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(390, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Harga Barang :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(390, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Diskon :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(390, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Status :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(721, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 25)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Harga Total :"
        '
        'cb_namasup
        '
        Me.cb_namasup.FormattingEnabled = True
        Me.cb_namasup.Location = New System.Drawing.Point(212, 91)
        Me.cb_namasup.Name = "cb_namasup"
        Me.cb_namasup.Size = New System.Drawing.Size(151, 28)
        Me.cb_namasup.TabIndex = 10
        '
        'cb_namabar
        '
        Me.cb_namabar.FormattingEnabled = True
        Me.cb_namabar.Location = New System.Drawing.Point(212, 144)
        Me.cb_namabar.Name = "cb_namabar"
        Me.cb_namabar.Size = New System.Drawing.Size(151, 28)
        Me.cb_namabar.TabIndex = 11
        '
        'cb_status
        '
        Me.cb_status.FormattingEnabled = True
        Me.cb_status.Items.AddRange(New Object() {"Lunas", "Belum Lunas", "Ngutang"})
        Me.cb_status.Location = New System.Drawing.Point(539, 243)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(151, 28)
        Me.cb_status.TabIndex = 12
        '
        'txt_notransaksi
        '
        Me.txt_notransaksi.Location = New System.Drawing.Point(212, 197)
        Me.txt_notransaksi.Name = "txt_notransaksi"
        Me.txt_notransaksi.Size = New System.Drawing.Size(151, 27)
        Me.txt_notransaksi.TabIndex = 13
        '
        'txt_tanggal
        '
        Me.txt_tanggal.Location = New System.Drawing.Point(212, 242)
        Me.txt_tanggal.Name = "txt_tanggal"
        Me.txt_tanggal.Size = New System.Drawing.Size(151, 27)
        Me.txt_tanggal.TabIndex = 14
        '
        'txt_jumlahbarang
        '
        Me.txt_jumlahbarang.Location = New System.Drawing.Point(539, 96)
        Me.txt_jumlahbarang.Name = "txt_jumlahbarang"
        Me.txt_jumlahbarang.Size = New System.Drawing.Size(125, 27)
        Me.txt_jumlahbarang.TabIndex = 15
        '
        'txt_diskon
        '
        Me.txt_diskon.Location = New System.Drawing.Point(539, 197)
        Me.txt_diskon.Name = "txt_diskon"
        Me.txt_diskon.Size = New System.Drawing.Size(125, 27)
        Me.txt_diskon.TabIndex = 17
        Me.txt_diskon.Text = "0"
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(145, 304)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(94, 29)
        Me.btn_input.TabIndex = 19
        Me.btn_input.Text = "Input"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(294, 304)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(94, 29)
        Me.btn_edit.TabIndex = 20
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_kosongkan
        '
        Me.btn_kosongkan.Location = New System.Drawing.Point(438, 304)
        Me.btn_kosongkan.Name = "btn_kosongkan"
        Me.btn_kosongkan.Size = New System.Drawing.Size(94, 29)
        Me.btn_kosongkan.TabIndex = 21
        Me.btn_kosongkan.Text = "Kosongkan"
        Me.btn_kosongkan.UseVisualStyleBackColor = True
        '
        'btn_hitung
        '
        Me.btn_hitung.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_hitung.Location = New System.Drawing.Point(721, 96)
        Me.btn_hitung.Name = "btn_hitung"
        Me.btn_hitung.Size = New System.Drawing.Size(115, 29)
        Me.btn_hitung.TabIndex = 22
        Me.btn_hitung.Text = "Hitung Total "
        Me.btn_hitung.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 354)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(981, 188)
        Me.DataGridView1.TabIndex = 23
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(5, 4)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(21, 27)
        Me.ID.TabIndex = 24
        '
        'lblHargaBarang
        '
        Me.lblHargaBarang.AutoSize = True
        Me.lblHargaBarang.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHargaBarang.Location = New System.Drawing.Point(539, 148)
        Me.lblHargaBarang.Name = "lblHargaBarang"
        Me.lblHargaBarang.Size = New System.Drawing.Size(22, 25)
        Me.lblHargaBarang.TabIndex = 25
        Me.lblHargaBarang.Text = "0"
        '
        'lblHargaTotal
        '
        Me.lblHargaTotal.AutoSize = True
        Me.lblHargaTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHargaTotal.Location = New System.Drawing.Point(842, 148)
        Me.lblHargaTotal.Name = "lblHargaTotal"
        Me.lblHargaTotal.Size = New System.Drawing.Size(22, 25)
        Me.lblHargaTotal.TabIndex = 26
        Me.lblHargaTotal.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(899, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormTransaksiPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(1010, 555)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblHargaTotal)
        Me.Controls.Add(Me.lblHargaBarang)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_hitung)
        Me.Controls.Add(Me.btn_kosongkan)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_input)
        Me.Controls.Add(Me.txt_diskon)
        Me.Controls.Add(Me.txt_jumlahbarang)
        Me.Controls.Add(Me.txt_tanggal)
        Me.Controls.Add(Me.txt_notransaksi)
        Me.Controls.Add(Me.cb_status)
        Me.Controls.Add(Me.cb_namabar)
        Me.Controls.Add(Me.cb_namasup)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTransaksiPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTransaksiPembelian"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cb_namasup As ComboBox
    Friend WithEvents cb_namabar As ComboBox
    Friend WithEvents cb_status As ComboBox
    Friend WithEvents txt_notransaksi As TextBox
    Friend WithEvents txt_tanggal As TextBox
    Friend WithEvents txt_jumlahbarang As TextBox
    Friend WithEvents txt_diskon As TextBox
    Friend WithEvents btn_input As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_kosongkan As Button
    Friend WithEvents btn_hitung As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As TextBox
    Friend WithEvents lblHargaBarang As Label
    Friend WithEvents lblHargaTotal As Label
    Friend WithEvents Button1 As Button
End Class
