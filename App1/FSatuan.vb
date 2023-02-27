Imports System.Data.SqlClient

Public Class FSatuan

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
        Call Input()
        Da = New SqlDataAdapter("select nama_satuan as Nama_Satuan from tbl_satuan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_satuan")
        DataGridView1.DataSource = (Ds.Tables("tbl_satuan"))
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.RowHeadersVisible = False


        txt_nama.Text = ""

    End Sub
    Private Sub FSatuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        If txt_nama.Text = "" Then
            MsgBox("DImohon Isi Semua!", MsgBoxStyle.Information, "Informasi") 'seperti alert'
        Else
            Call Koneksi()
            Dim commad As String
            commad = "select * from tbl_satuan where nama_satuan='" & txt_nama.Text & "'"
            cmd = New SqlCommand(commad, Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                MsgBox("nama barang yang anda isi sudah ada, harap menggunakan nama lain!", MsgBoxStyle.Information, "Informasi")
            Else
                Call Koneksi()
                Dim str As String
                str = "insert into tbl_satuan (nama_satuan) values ('" & txt_nama.Text & "')"
                cmd = New SqlCommand(str, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil di Input!", MsgBoxStyle.Information, "Informasi")
                Call KondisiAwal()
            End If


        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New SqlCommand("select * from tbl_satuan where nama_satuan='" & DataGridView1.Item(0, i).Value & "' ", Conn)
        Dr = cmd.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then
            txt_nama.Focus()
        Else
            Call editHapus()
            ID.Text = Dr.Item("id_satuan")
            txt_nama.Text = Dr.Item("nama_satuan")
            txt_nama.Focus()
        End If

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call Koneksi()
        If ID.Text = "" Then
            MsgBox("Harap pilih data terlebih dahulu", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Dim edit As String
            edit = "UPDATE tbl_satuan SET nama_satuan='" & txt_nama.Text & "' where id_satuan='" & ID.Text & "'"
            cmd = New SqlCommand(edit, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di Update", MsgBoxStyle.Information, "Informasi")
            KondisiAwal()
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If MsgBox("Yakin Akan Hapus Data?", vbYesNo, "Informasi") = vbYes Then
            Call Koneksi()
            Dim hapus As String
            hapus = "delete from tbl_satuan where id_satuan= '" & ID.Text & "'"
            cmd = New SqlCommand(hapus, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information, "Informasi")
            Call KondisiAwal()
        Else
            MsgBox("Data Batal di Hapus!")
        End If


    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
        Beranda.Show()
    End Sub
End Class