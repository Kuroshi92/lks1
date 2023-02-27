Imports System.Data.SqlClient
Public Class FBarang

    Sub Input()
        btn_input.Enabled = True
        btn_edit.Enabled = False
        btn_hapus.Enabled = False
    End Sub

    Sub editHapus()
        btn_input.Enabled = False
        btn_edit.Enabled = True
        btn_hapus.Enabled = True
    End Sub

    Sub getSatuan()
        Call Koneksi()
        Dim str As String
        str = "SELECT nama_satuan From tbl_satuan"
        cmd = New SqlCommand(str, Conn)
        Dr = cmd.ExecuteReader
        If Dr.HasRows Then
            Do While Dr.Read = True
                CB_Satuan.Items.Add(Dr.Item("nama_satuan"))
            Loop
        End If
    End Sub

    Sub getKategori()
        Call Koneksi()
        Dim str As String
        str = "SELECT nama_kategori From tbl_kategori"
        cmd = New SqlCommand(str, Conn)
        Dr = cmd.ExecuteReader
        If Dr.HasRows Then
            Do While Dr.Read = True
                CB_Kategori.Items.Add(Dr.Item("nama_kategori"))
            Loop
        End If
    End Sub

    Sub KondisiAwal()
        Call Koneksi()
        Call Input()


        Da = New SqlDataAdapter("SELECT kode_barang As Kode_Barang,  nama_barang AS Nama_Barang, nama_kategori As Nama_Kategori, nama_satuan AS Nama_Satuan, deskripsi AS Deskripsi, stok AS Stok, harga_jual AS Harga_Jual, harga_beli As Harga_Beli FROM tbl_barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_barang")
        DataGridView1.DataSource = (Ds.Tables("tbl_barang"))
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.RowHeadersVisible = False

        ID.Hide()
        txt_kodebarang.Text = ""
        txt_namabarang.Text = ""
        CB_Kategori.Text = ""
        CB_Satuan.Text = ""
        txt_stok.Text = ""
        txt_hargajual.Text = ""
        txt_hargabeli.Text = ""
        txt_deskripsi.Text = ""


    End Sub

    Private Sub FBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call getSatuan()
        Call getKategori()
    End Sub



    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call Koneksi()
        If txt_kodebarang.Text = "" Then
            MsgBox("Harap pilih data terlebih dahulu", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Dim edit As String
            edit = "UPDATE tbl_barang SET kode_barang='" & txt_kodebarang.Text & "', nama_barang='" & txt_namabarang.Text & "', nama_kategori='" & CB_Kategori.Text & "' , nama_satuan='" & CB_Satuan.Text & "', stok='" & txt_stok.Text & "', harga_jual='" & txt_hargajual.Text & "', harga_beli='" & txt_hargabeli.Text & "', deskripsi='" & txt_deskripsi.Text & "' where id_barang='" & ID.Text & "'"
            cmd = New SqlCommand(edit, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di Update", MsgBoxStyle.Information, "Informasi")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click

        If MsgBox("Yakin Akan Hapus Data?", vbYesNo, "Informasi") = vbYes Then
            Call Koneksi()
            Dim hapus As String
            hapus = "delete from tbl_barang where id_barang= '" & ID.Text & "'"
            cmd = New SqlCommand(hapus, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information, "Informasi")
            Call KondisiAwal()
        Else
            MsgBox("Data Batal di Hapus!")
        End If

    End Sub

    Private Sub btn_kosongkan_Click(sender As Object, e As EventArgs) Handles btn_kosongkan.Click
        Call KondisiAwal()
    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        Me.Close()
        Beranda.Show()
    End Sub

    Private Sub btn_input_Click_1(sender As Object, e As EventArgs) Handles btn_input.Click
        If txt_kodebarang.Text = "" Or txt_namabarang.Text = "" Or CB_Kategori.Text = "" Or CB_Satuan.Text = "" Or txt_stok.Text = "" Or txt_hargajual.Text = "" Or txt_hargabeli.Text = "" Then
            MsgBox("DImohon Isi Semua!", MsgBoxStyle.Information, "Informasi") 'seperti alert'
        Else
            Call Koneksi()
            Dim commad As String
            commad = "select * from tbl_barang where kode_barang='" & txt_kodebarang.Text & "'"
            cmd = New SqlCommand(commad, Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                MsgBox("Kode dan Nama Barang yang anda isi sudah ada, harap menggunakan nama lain!", MsgBoxStyle.Information, "Informasi")
            Else
                Call Koneksi()
                Dim str As String
                str = "insert into tbl_barang (kode_barang,nama_barang,nama_kategori,nama_satuan,stok,harga_jual,harga_beli,deskripsi) values ('" & txt_kodebarang.Text & "','" & txt_namabarang.Text & "','" & CB_Kategori.Text & "','" & CB_Satuan.Text & "','" & txt_stok.Text & "','" & txt_hargajual.Text & "','" & txt_hargabeli.Text & "','" & txt_deskripsi.Text & "')"
                cmd = New SqlCommand(str, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berasih di Input!", MsgBoxStyle.Information, "Informasi")
                Call KondisiAwal()
            End If
        End If
    End Sub


    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New SqlCommand("SELECT * FROM tbl_barang WHERE kode_barang='" & DataGridView1.Item(0, i).Value & "' ", Conn)
        Dr = cmd.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then
            txt_kodebarang.Focus()
        Else
            Call editHapus()
            ID.Text = Dr.Item("id_barang")
            txt_kodebarang.Text = Dr.Item("kode_barang")
            txt_namabarang.Text = Dr.Item("nama_barang")
            CB_Kategori.Text = Dr.Item("nama_kategori")
            CB_Satuan.Text = Dr.Item("nama_satuan")
            txt_stok.Text = Dr.Item("stok")
            txt_hargajual.Text = Dr.Item("harga_jual")
            txt_hargabeli.Text = Dr.Item("harga_beli")
            txt_deskripsi.Text = Dr.Item("deskripsi")
            txt_kodebarang.Focus()
        End If
    End Sub


End Class