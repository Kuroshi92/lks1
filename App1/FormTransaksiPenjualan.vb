Imports System.Data.SqlClient
Imports System.Globalization

Public Class FormTransaksiPenjualan
    Public HargaBarang As Double
    Public HargaTotal As Double
    Public NamaBarang As String


    Sub getBarang()
        Call Koneksi()
        Dim str As String
        str = "SELECT nama_barang From tbl_barang"
        cmd = New SqlCommand(str, Conn)
        Dr = cmd.ExecuteReader
        If Dr.HasRows Then
            Do While Dr.Read() = True
                cb_namabar.Items.Add(Dr.Item("nama_barang"))
            Loop
        End If
    End Sub

    Sub getPelanggan()
        Call Koneksi()
        Dim str As String
        str = "SELECT nama_pelanggan FROM tbl_pelanggan"
        cmd = New SqlCommand(str, Conn)
        Dr = cmd.ExecuteReader
        If Dr.HasRows Then
            Do While Dr.Read() = True
                cb_namapel.Items.Add(Dr.Item("nama_pelanggan"))
            Loop
        End If
    End Sub

    Sub updateStok(stok As Integer)
        Call Koneksi()

        '' update stok
        Dim hasilStok As Integer '' hasil penjumlahan stok
        Dim up As String '' query ke database

        hasilStok = Val(stok) - Val(txt_jumlahbarang.Text)
        up = "UPDATE tbl_barang SET stok='" & hasilStok & "' WHERE nama_barang='" & NamaBarang & "'"
        cmd = New SqlCommand(up, Conn)
        cmd.ExecuteNonQuery()
    End Sub

    Sub KondisiAwal()
        Call Koneksi()

        Da = New SqlDataAdapter("Select id_penjualan As ID, nama_pelanggan As Nama_Pelanggan, nama_barang As Nama_Barang, no_transaksi As No_Transaksi, tanggal As Tanggal, jumlah_barang As Jumlah_Barang, harga As Harga, diskon As Diskon, status As Status, harga_total As Harga_Total FROM tbl_penjualan ", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_penjualan")
        DataGridView1.DataSource = (Ds.Tables("tbl_penjualan"))
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.RowHeadersVisible = True

        HargaBarang = 0
        lblHargaBarang.Text = HargaBarang.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))

        HargaTotal = 0
        lblHargaTotal.Text = HargaTotal.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))

        ID.Hide()

        cb_namapel.Text = ""
        cb_namabar.Text = ""
        txt_notransaksi.Text = "PJL" + Date.Now.ToString("ssdMMyyyy")
        txt_diskon.Text = 0
        txt_jumlahbarang.Text = ""
        cb_status.Text = ""

        cb_namabar.Items.Clear()
        cb_namapel.Items.Clear()
        Call getBarang()
        Call getPelanggan()


    End Sub

    Private Sub FormTransaksiPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        lbl_tgl.Text = Date.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        If cb_namapel.Text = "" Or cb_namabar.Text = "" Or txt_notransaksi.Text = "" Or txt_jumlahbarang.Text = "" Or cb_status.Text = "" Then
            MsgBox("Dimohon Isi Semua!", MsgBoxStyle.Information, "Informasi") 'seperti alert'
        Else
            Call Koneksi()
            Dim commad As String
            commad = "Select * from tbl_penjualan where no_transaksi='" & txt_notransaksi.Text & "'"
        cmd = New SqlCommand(commad, Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                MsgBox("Nomor Transaksi sudah ada, harap input yang lain!", MsgBoxStyle.Information, "Informasi")
            Else
                Call Koneksi()
                Dim str As String
                str = "insert into tbl_penjualan (nama_pelanggan,nama_barang,no_transaksi,tanggal,jumlah_barang,harga,diskon,status,harga_total) values ('" & cb_namapel.Text & "','" & cb_namabar.Text & "','" & txt_notransaksi.Text & "','" & lbl_tgl.Text & "','" & txt_jumlahbarang.Text & "','" & HargaBarang & "','" & txt_diskon.Text & "','" & cb_status.Text & "','" & HargaTotal & "')"
                cmd = New SqlCommand(str, Conn)
                cmd.ExecuteNonQuery()

                '' select barang
                str = "SELECT stok FROM tbl_barang WHERE nama_barang='" & NamaBarang & "'"
                cmd = New SqlCommand(str, Conn)
                Dr = cmd.ExecuteReader
                Dr.Read()

                Call updateStok(Dr.Item("stok"))
                MsgBox("Data Berasih di Input!", MsgBoxStyle.Information, "Informasi")
            End If
        End If
    End Sub


    Private Sub btn_kosongkan_Click(sender As Object, e As EventArgs) Handles btn_kosongkan.Click
        Call KondisiAwal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Beranda.Show()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New SqlCommand("select id_penjualan,nama_pelanggan,nama_barang,no_transaksi,tanggal,jumlah_barang,harga,diskon,status,harga_total from tbl_penjualan where id_penjualan='" & DataGridView1.Item(0, i).Value & "' ", Conn)
        Dr = cmd.ExecuteReader
        Dr.Read()

        lbl_tgl.Text = Dr.Item("tanggal")
        txt_notransaksi.Text = Dr.Item("no_transaksi")
        ID.Text = Dr.Item("id_penjualan")
        cb_namapel.Text = Dr.Item("nama_pelanggan")
        cb_namabar.SelectedText = Dr.Item("nama_barang")
        txt_notransaksi.Text = Dr.Item("no_transaksi")
        txt_jumlahbarang.Text = Dr.Item("jumlah_barang")
        lblHargaBarang.Text = Dr.Item("harga")
        txt_diskon.Text = Dr.Item("diskon")
        cb_status.Text = Dr.Item("status")
        lblHargaTotal.Text = Dr.Item("harga_total")
        cb_namapel.Focus()
    End Sub

    Private Sub cb_namabar_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_namabar.SelectedValueChanged
        Call Koneksi()
        Dim str As String
        str = "SELECT * FROM tbl_barang WHERE nama_barang='" & cb_namabar.Text & "'"
        cmd = New SqlCommand(str, Conn)
        Dr = cmd.ExecuteReader
        Dr.Read()

        NamaBarang = Dr.Item("nama_barang")
        HargaBarang = Dr.Item("harga_beli")
        lblHargaBarang.Text = HargaBarang.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))
    End Sub

    Private Sub btn_hitung_Click(sender As Object, e As EventArgs) Handles btn_hitung.Click
        If txt_jumlahbarang.Text = "" Then
            MsgBox("Harap Isi jumlah terlebih dahulu, minimal 1", MsgBoxStyle.Exclamation, "Informasi")
        Else
            Dim jumlahBrg_hargaBrg As Integer
            jumlahBrg_hargaBrg = HargaBarang * Val(txt_jumlahbarang.Text)

            If Val(txt_diskon.Text) > jumlahBrg_hargaBrg Then
                MsgBox("Diskon melebihi harga total", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                HargaTotal = jumlahBrg_hargaBrg - Val(txt_diskon.Text)
                lblHargaTotal.Text = HargaTotal.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))
            End If
        End If
    End Sub


End Class