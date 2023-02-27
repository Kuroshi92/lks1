Imports System.Data.SqlClient

Public Class FSupplier
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

    Sub KondisiAwal()
        Call Koneksi()
        Da = New SqlDataAdapter("SELECT nama_supplier As Nama_Supplier,  alamat AS Alamat, no_tlp As No_Telepon, nama_bank AS Nama_Bank, no_rekening AS No_Rekening FROM tbl_supplier", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_supplier")
        DataGridView1.DataSource = (Ds.Tables("tbl_supplier"))
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.RowHeadersVisible = False

        ID.Hide()
        txt_namasup.Text = ""
        txt_alamat.Text = ""
        txt_notlp.Text = ""
        CB_Bank.Text = ""
        txt_norekening.Text = ""

    End Sub

    Private Sub FSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call Input()
    End Sub

    Private Sub txt_notlp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_notlp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        If txt_namasup.Text = "" Or txt_alamat.Text = "" Or txt_notlp.Text = "" Or CB_Bank.Text = "" Or txt_norekening.Text = "" Then
            MsgBox("Dimohon Isi Semua!", MsgBoxStyle.Information, "Informasi") 'seperti alert'
        Else
            Call Koneksi()
            Dim commad As String
            commad = "select * from tbl_supplier where nama_supplier='" & txt_namasup.Text & "'"
            cmd = New SqlCommand(commad, Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                MsgBox("Kode dan Nama Barang yang anda isi sudah ada, harap menggunakan nama lain!", MsgBoxStyle.Information, "Informasi")
            Else
                Call Koneksi()
                Dim str As String
                str = "insert into tbl_supplier (nama_supplier,alamat,no_tlp,nama_bank,no_rekening) values ('" & txt_namasup.Text & "','" & txt_alamat.Text & "','" & txt_notlp.Text & "','" & CB_Bank.Text & "','" & txt_norekening.Text & "')"
                cmd = New SqlCommand(str, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berasih di Input!", MsgBoxStyle.Information, "Informasi")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call Koneksi()
        If txt_namasup.Text = "" Or txt_alamat.Text = "" Or txt_notlp.Text = "" Or CB_Bank.Text = "" Or txt_norekening.Text = "" Then
            MsgBox("Harap data jangan kosong!", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Call editHapus()
            Dim edit As String
            edit = "UPDATE tbl_supplier SET nama_supplier='" & txt_namasup.Text & "', alamat='" & txt_alamat.Text & "', no_tlp='" & txt_notlp.Text & "' , nama_bank='" & CB_Bank.Text & "', no_rekening='" & txt_norekening.Text & "' where id_supplier='" & ID.Text & "'"
            cmd = New SqlCommand(edit, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di Update", MsgBoxStyle.Information, "Informasi")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub txt_norekening_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_norekening.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_kosongkan_Click(sender As Object, e As EventArgs) Handles btn_kosongkan.Click
        Call KondisiAwal()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If MsgBox("Yakin Akan Hapus Data?", vbYesNo, "Informasi") = vbYes Then
            Call Koneksi()
            Call editHapus()

            Dim hps As String
            hps = "delete from tbl_supplier where id_supplier= '" & ID.Text & "'"
            cmd = New SqlCommand(hps, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information, "Informasi")
            Call KondisiAwal()
        Else
            MsgBox("Data Batal di Hapus!")
        End If

        Call Koneksi()
        Dim hapus As String
        hapus = "delete from tbl_supplier where id_supplier= '" & ID.Text & "'"
        cmd = New SqlCommand(hapus, Conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New SqlCommand("SELECT * FROM tbl_supplier WHERE nama_supplier='" & DataGridView1.Item(0, i).Value & "' ", Conn)
        Dr = cmd.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then
            txt_namasup.Focus()
        Else
            Call editHapus()
            txt_namasup.Text = Dr.Item("nama_supplier")
            txt_alamat.Text = Dr.Item("alamat")
            txt_notlp.Text = Dr.Item("no_tlp")
            CB_Bank.Text = Dr.Item("nama_bank")
            txt_norekening.Text = Dr.Item("no_rekening")
            ID.Text = Dr.Item("id_supplier")
            txt_namasup.Focus()
        End If
    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        Call KondisiAwal()
        Me.Close()
        Beranda.Show()
    End Sub
End Class