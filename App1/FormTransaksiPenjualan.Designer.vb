<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaksiPenjualan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblHargaTotal = New System.Windows.Forms.Label()
        Me.lblHargaBarang = New System.Windows.Forms.Label()
        Me.btn_hitung = New System.Windows.Forms.Button()
        Me.btn_kosongkan = New System.Windows.Forms.Button()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.txt_diskon = New System.Windows.Forms.TextBox()
        Me.txt_jumlahbarang = New System.Windows.Forms.TextBox()
        Me.txt_notransaksi = New System.Windows.Forms.TextBox()
        Me.cb_status = New System.Windows.Forms.ComboBox()
        Me.cb_namabar = New System.Windows.Forms.ComboBox()
        Me.cb_namapel = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_tanggal = New System.Windows.Forms.Label()
        Me.lbl_tgl = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(471, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Transaksi Penjualan"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(2, 0)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(27, 27)
        Me.ID.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 362)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1118, 188)
        Me.DataGridView1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1027, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblHargaTotal
        '
        Me.lblHargaTotal.AutoSize = True
        Me.lblHargaTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHargaTotal.Location = New System.Drawing.Point(989, 133)
        Me.lblHargaTotal.Name = "lblHargaTotal"
        Me.lblHargaTotal.Size = New System.Drawing.Size(22, 25)
        Me.lblHargaTotal.TabIndex = 49
        Me.lblHargaTotal.Text = "0"
        '
        'lblHargaBarang
        '
        Me.lblHargaBarang.AutoSize = True
        Me.lblHargaBarang.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHargaBarang.Location = New System.Drawing.Point(675, 86)
        Me.lblHargaBarang.Name = "lblHargaBarang"
        Me.lblHargaBarang.Size = New System.Drawing.Size(22, 25)
        Me.lblHargaBarang.TabIndex = 48
        Me.lblHargaBarang.Text = "0"
        '
        'btn_hitung
        '
        Me.btn_hitung.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_hitung.Location = New System.Drawing.Point(859, 86)
        Me.btn_hitung.Name = "btn_hitung"
        Me.btn_hitung.Size = New System.Drawing.Size(115, 29)
        Me.btn_hitung.TabIndex = 47
        Me.btn_hitung.Text = "Hitung Total "
        Me.btn_hitung.UseVisualStyleBackColor = False
        '
        'btn_kosongkan
        '
        Me.btn_kosongkan.Location = New System.Drawing.Point(348, 315)
        Me.btn_kosongkan.Name = "btn_kosongkan"
        Me.btn_kosongkan.Size = New System.Drawing.Size(94, 29)
        Me.btn_kosongkan.TabIndex = 46
        Me.btn_kosongkan.Text = "Kosongkan"
        Me.btn_kosongkan.UseVisualStyleBackColor = True
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(183, 315)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(94, 29)
        Me.btn_input.TabIndex = 44
        Me.btn_input.Text = "Input"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'txt_diskon
        '
        Me.txt_diskon.Location = New System.Drawing.Point(662, 138)
        Me.txt_diskon.Name = "txt_diskon"
        Me.txt_diskon.Size = New System.Drawing.Size(151, 27)
        Me.txt_diskon.TabIndex = 43
        Me.txt_diskon.Text = "0"
        '
        'txt_jumlahbarang
        '
        Me.txt_jumlahbarang.Location = New System.Drawing.Point(348, 237)
        Me.txt_jumlahbarang.Name = "txt_jumlahbarang"
        Me.txt_jumlahbarang.Size = New System.Drawing.Size(151, 27)
        Me.txt_jumlahbarang.TabIndex = 42
        '
        'txt_notransaksi
        '
        Me.txt_notransaksi.Location = New System.Drawing.Point(348, 187)
        Me.txt_notransaksi.Name = "txt_notransaksi"
        Me.txt_notransaksi.Size = New System.Drawing.Size(151, 27)
        Me.txt_notransaksi.TabIndex = 40
        '
        'cb_status
        '
        Me.cb_status.FormattingEnabled = True
        Me.cb_status.Items.AddRange(New Object() {"Lunas", "Belum Lunas", "Ngutang"})
        Me.cb_status.Location = New System.Drawing.Point(662, 187)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(151, 28)
        Me.cb_status.TabIndex = 39
        '
        'cb_namabar
        '
        Me.cb_namabar.FormattingEnabled = True
        Me.cb_namabar.Location = New System.Drawing.Point(348, 134)
        Me.cb_namabar.Name = "cb_namabar"
        Me.cb_namabar.Size = New System.Drawing.Size(151, 28)
        Me.cb_namabar.TabIndex = 38
        '
        'cb_namapel
        '
        Me.cb_namapel.FormattingEnabled = True
        Me.cb_namapel.Location = New System.Drawing.Point(348, 81)
        Me.cb_namapel.Name = "cb_namapel"
        Me.cb_namapel.Size = New System.Drawing.Size(151, 28)
        Me.cb_namapel.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(859, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 25)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Harga Total :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(532, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 25)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Status :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(526, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 25)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Diskon :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(526, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 25)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Harga Barang :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(160, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 25)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Jumlah Barang :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(162, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 25)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "No Transaksi :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(162, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 25)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Nama Barang :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(162, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 25)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nama Pelanggan :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(534, 238)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 25)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Tanggal :"
        '
        'lbl_tanggal
        '
        Me.lbl_tanggal.AutoSize = True
        Me.lbl_tanggal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_tanggal.Location = New System.Drawing.Point(662, 238)
        Me.lbl_tanggal.Name = "lbl_tanggal"
        Me.lbl_tanggal.Size = New System.Drawing.Size(0, 25)
        Me.lbl_tanggal.TabIndex = 52
        '
        'lbl_tgl
        '
        Me.lbl_tgl.AutoSize = True
        Me.lbl_tgl.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_tgl.Location = New System.Drawing.Point(662, 239)
        Me.lbl_tgl.Name = "lbl_tgl"
        Me.lbl_tgl.Size = New System.Drawing.Size(19, 25)
        Me.lbl_tgl.TabIndex = 53
        Me.lbl_tgl.Text = "-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FormTransaksiPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(1142, 562)
        Me.Controls.Add(Me.lbl_tgl)
        Me.Controls.Add(Me.lbl_tanggal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblHargaTotal)
        Me.Controls.Add(Me.lblHargaBarang)
        Me.Controls.Add(Me.btn_hitung)
        Me.Controls.Add(Me.btn_kosongkan)
        Me.Controls.Add(Me.btn_input)
        Me.Controls.Add(Me.txt_diskon)
        Me.Controls.Add(Me.txt_jumlahbarang)
        Me.Controls.Add(Me.txt_notransaksi)
        Me.Controls.Add(Me.cb_status)
        Me.Controls.Add(Me.cb_namabar)
        Me.Controls.Add(Me.cb_namapel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTransaksiPenjualan"
        Me.Text = "FormTransaksiPenjualan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents lblHargaTotal As Label
    Friend WithEvents lblHargaBarang As Label
    Friend WithEvents btn_hitung As Button
    Friend WithEvents btn_kosongkan As Button
    Friend WithEvents btn_input As Button
    Friend WithEvents txt_diskon As TextBox
    Friend WithEvents txt_jumlahbarang As TextBox
    Friend WithEvents txt_tanggal As TextBox
    Friend WithEvents txt_notransaksi As TextBox
    Friend WithEvents cb_status As ComboBox
    Friend WithEvents cb_namabar As ComboBox
    Friend WithEvents cb_namapel As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_tanggal As Label
    Friend WithEvents lbl_tgl As Label
End Class
