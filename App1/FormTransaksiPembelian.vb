Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Globalization

Public Class FormTransaksiPembelian
    Public hargaBarang As Double
    Public hargaTotal As Double
    Public namaBarang As String
    Public noTransaksi As Integer

    Sub Input()
        btn_input.Enabled = True
        btn_edit.Enabled = False
    End Sub

    Sub edit()
        btn_input.Enabled = False
        btn_edit.Enabled = True
    End Sub

    Sub KondisiAwal()
        Call Koneksi()
        Call Input()

        Da = New SqlDataAdapter("SELECT nama_supplier As Nama_Supplier, nama_barang As Nama_Barang, no_transaksi As No_Transaksi, tanggal As Tanggal, jumlah_barang As Jumlah_Barang, harga As Harga, diskon As Diskon, status As Status , harga_total As Harga_Total FROM tbl_pembelian", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_pembelian")
        DataGridView1.DataSource = (Ds.Tables("tbl_pembelian"))
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.RowHeadersVisible = False

        hargaBarang = 0
        lblHargaBarang.Text = hargaBarang.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))

        hargaTotal = 0
        lblHargaTotal.Text = hargaTotal.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))

        ID.Hide()
        cb_namasup.Text = ""
        cb_namabar.Text = ""
        txt_diskon.Text = 0
        txt_notransaksi.Text = "PMB" + Date.Now.ToString("ssdMMyyyy")
        txt_jumlahbarang.Text = ""
        cb_status.Text = ""
        txt_tanggal.Text = Date.Now.ToString("dd/MM/yyyy")


        cb_namasup.Items.Clear()
        cb_namabar.Items.Clear()
        Call getBarang()
        Call getSupplier()
    End Sub

    Sub getBarang()
        Call Koneksi()
        Dim str As String
        str = "SELECT nama_barang FROM tbl_barang"
        cmd = New SqlCommand(str, Conn)
        Dr = cmd.ExecuteReader
        If Dr.HasRows Then
            Do While Dr.Read = True
                cb_namabar.Items.Add(Dr.Item("nama_barang"))
            Loop
        End If
    End Sub

    Sub getSupplier()
        Call Koneksi()
        Dim str As String
        str = "SELECT nama_supplier FROM tbl_supplier"
        cmd = New SqlCommand(str, Conn)
        Dr = cmd.ExecuteReader
        If Dr.HasRows Then
            Do While Dr.Read = True
                cb_namasup.Items.Add(Dr.Item("nama_supplier"))
            Loop
        End If
    End Sub

    Private Sub FormTransaksiPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()

    End Sub

    Private Sub btn_hitung_Click(sender As Object, e As EventArgs) Handles btn_hitung.Click
        If txt_jumlahbarang.Text = "" Then
            MsgBox("Harap Isi jumlah terlebih dahulu, minimal 1", MsgBoxStyle.Exclamation, "Informasi")
        Else
            Dim jumlahBrg_hargaBrg As Integer
            jumlahBrg_hargaBrg = hargaBarang * Val(txt_jumlahbarang.Text)

            If Val(txt_diskon.Text) > jumlahBrg_hargaBrg Then
                MsgBox("Diskon melebihi harga total", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                hargaTotal = jumlahBrg_hargaBrg - Val(txt_diskon.Text)
                lblHargaTotal.Text = hargaTotal.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))
            End If
        End If
    End Sub

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        If cb_namasup.Text = "" Or cb_namabar.Text = "" Or txt_notransaksi.Text = "" Or txt_tanggal.Text = "" Or txt_jumlahbarang.Text = "" Or cb_status.Text = "" Then
            MsgBox("Dimohon Isi Semua!", MsgBoxStyle.Information, "Informasi") 'seperti alert'
        Else
            Call Koneksi()
            Dim commad As String
            commad = "select * from tbl_pembelian where no_transaksi='" & txt_notransaksi.Text & "'"
            cmd = New SqlCommand(commad, Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                MsgBox("Nomor Transaksi sudah ada, harap input yang lain!", MsgBoxStyle.Information, "Informasi")
            Else
                Call Koneksi()
                Dim str As String
                str = "insert into tbl_pembelian (nama_supplier,nama_barang,no_transaksi,tanggal,jumlah_barang,harga,diskon,status,harga_total) values ('" & cb_namasup.Text & "','" & cb_namabar.Text & "','" & txt_notransaksi.Text & "','" & txt_tanggal.Text & "','" & txt_jumlahbarang.Text & "','" & hargaBarang & "','" & txt_diskon.Text & "','" & cb_status.Text & "','" & hargaTotal & "')"
                cmd = New SqlCommand(str, Conn)
                cmd.ExecuteNonQuery()

                '' select barang
                str = "SELECT stok FROM tbl_barang WHERE nama_barang='" & namaBarang & "'"
                cmd = New SqlCommand(str, Conn)
                Dr = cmd.ExecuteReader
                Dr.Read()

                Call updateStok(Dr.Item("stok"))
                MsgBox("Data Berasih di Input!", MsgBoxStyle.Information, "Informasi")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Sub updateStok(stok As Integer)
        Call Koneksi()

        '' update stok
        Dim hasilStok As Integer '' hasil penjumlahan stok
        Dim up As String '' query ke database

        hasilStok = Val(stok) + Val(txt_jumlahbarang.Text)
        up = "UPDATE tbl_barang SET stok='" & hasilStok & "'"
        cmd = New SqlCommand(up, Conn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call Koneksi()
        If cb_namasup.Text = "" Then
            MsgBox("Harap pilih data terlebih dahulu", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Dim edit As String
            edit = "UPDATE tbl_pembelian SET nama_supplier='" & cb_namasup.Text & "', nama_barang='" & cb_namabar.Text & "',no_transaksi='" & txt_notransaksi.Text & "' , tanggal='" & txt_tanggal.Text & "', jumlah_barang='" & txt_jumlahbarang.Text & "', harga='" & hargaBarang & "', diskon='" & txt_diskon.Text & "', status='" & cb_status.Text & "', harga_total='" & hargaTotal & "' where id_pembelian='" & ID.Text & "'"
            cmd = New SqlCommand(edit, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di Update", MsgBoxStyle.Information, "Informasi")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub btn_kosongkan_Click(sender As Object, e As EventArgs) Handles btn_kosongkan.Click
        Call KondisiAwal()
    End Sub


    Private Sub cb_namabar_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_namabar.SelectedValueChanged
        Call Koneksi()
        Dim str As String
        str = "SELECT * FROM tbl_barang WHERE nama_barang='" & cb_namabar.Text & "'"
        cmd = New SqlCommand(str, Conn)
        Dr = cmd.ExecuteReader
        Dr.Read()

        namaBarang = Dr.Item("nama_barang")
        hargaBarang = Dr.Item("harga_beli")
        lblHargaBarang.Text = hargaBarang.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New SqlCommand("SELECT * FROM tbl_pembelian WHERE no_transaksi='" & DataGridView1.Item(2, i).Value & "' ", Conn)
        Dr = cmd.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then
            cb_namasup.Focus()
        Else
            Call edit()
            cb_namasup.Text = ""
            cb_namasup.SelectedText = Dr.Item("nama_supplier")
            cb_namabar.Text = ""
            cb_namabar.SelectedText = Dr.Item("nama_barang")
            txt_notransaksi.Text = Dr.Item("no_transaksi")
            txt_tanggal.Text = Dr.Item("tanggal")
            txt_jumlahbarang.Text = Dr.Item("jumlah_barang")
            lblHargaBarang.Text = Dr.Item("harga")
            txt_diskon.Text = Dr.Item("diskon")
            cb_status.Text = Dr.Item("status")
            lblHargaTotal.Text = Dr.Item("harga_total")
            ID.Text = Dr.Item("id_pembelian")
            cb_namasup.Focus()
        End If
    End Sub


End Class