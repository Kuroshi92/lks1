Imports System.Data.SqlClient

Public Class Fpelanggan
    Sub Input()
        btn_input.Enabled = True
        btn_edit.Enabled = False
        btn_hapus.Enabled = False
        cb_jk.Text = ""
    End Sub

    Sub editHapus()
        btn_input.Enabled = False
        btn_edit.Enabled = True
        btn_hapus.Enabled = True
        cb_jk.Text = ""
    End Sub

    Sub KondisiAwal()
        Call Koneksi()
        Call Input()
        Da = New SqlDataAdapter("SELECT nama_pelanggan AS Nama, jenis_kelamin AS Jenis_Kelamin, alamat_pelanggan AS Alamat, no_telepon AS No_Telepon FROM tbl_pelanggan ", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_pelanggan")
        DataGridView1.DataSource = (Ds.Tables("tbl_pelanggan"))
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.RowHeadersVisible = False

        ID.Hide()
        txt_nama.Text = ""
        txt_alamat.Text = ""
        txt_notlp.Text = ""
        cb_jk.Text = ""

    End Sub
    Private Sub Fpelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_notlp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New SqlCommand("SELECT * FROM tbl_pelanggan WHERE nama_pelanggan='" & DataGridView1.Item(0, i).Value & "' ", Conn)
        Dr = cmd.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then
            txt_nama.Focus()
        Else
            Call editHapus()
            txt_nama.Text = Dr.Item("nama_pelanggan")
            cb_jk.Text = Dr.Item("jenis_kelamin")
            txt_notlp.Text = Dr.Item("no_telepon")
            txt_alamat.Text = Dr.Item("alamat_pelanggan")
            ID.Text = Dr.Item("id_pelanggan")
            txt_nama.Focus()
        End If
    End Sub

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        If txt_nama.Text = "" Or txt_alamat.Text = "" Or txt_notlp.Text = "" Or cb_jk.Text = "" Then
            MsgBox("DImohon Isi Semua!", MsgBoxStyle.Information, "Informasi") 'seperti alert'
        Else
            Call Koneksi()
            Dim commad As String
            commad = "select * from tbl_pelanggan where nama_pelanggan='" & txt_nama.Text & "'"
            cmd = New SqlCommand(commad, Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                MsgBox("Username yang anda isi sudah ada, harap menggunakan nama lain!", MsgBoxStyle.Information, "Informasi")
            Else
                Call Koneksi()
                Dim str As String
                str = "insert into tbl_pelanggan (nama_pelanggan,jenis_kelamin,alamat_pelanggan,no_telepon) values ('" & txt_nama.Text & "','" & cb_jk.Text & "','" & txt_alamat.Text & "','" & txt_notlp.Text & "')"
                cmd = New SqlCommand(str, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berasih di Input!", MsgBoxStyle.Information, "Informasi")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call Koneksi()
        If txt_nama.Text = "" Then
            MsgBox("Harap pilih data terlebih dahulu", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Dim edit As String
            edit = "UPDATE tbl_pelanggan SET nama_pelanggan='" & txt_nama.Text & "', jenis_kelamin='" & cb_jk.Text & "', alamat_pelanggan='" & txt_alamat.Text & "' , no_telepon='" & txt_notlp.Text & "' where id_pelanggan='" & ID.Text & "'"
            cmd = New SqlCommand(edit, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di Update", MsgBoxStyle.Information, "Informasi")
            KondisiAwal()
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Call Koneksi()
        Dim hapus As String
        hapus = "delete from tbl_pelanggan where id_pelanggan= '" & ID.Text & "'"
        cmd = New SqlCommand(hapus, Conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub btn_kosongkan_Click(sender As Object, e As EventArgs) Handles btn_kosongkan.Click
        Call KondisiAwal()
    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        Me.Close()
        Beranda.Show()
    End Sub


End Class