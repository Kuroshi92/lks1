Imports System.Data.SqlClient
Imports Accessibility

Public Class Users

    Sub Input()
        btn_Input.Enabled = True
        btn_edit.Enabled = False
        btn_hapus.Enabled = False
    End Sub

    Sub editHapus()
        btn_Input.Enabled = False
        btn_edit.Enabled = True
        btn_hapus.Enabled = True
    End Sub

    Sub KondisiAwal()
        Call Koneksi()
        Call Input()
        Da = New SqlDataAdapter("select nama_user as Nama_User, password_user as Password, level_user as Level from tbl_user", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_user")
        DataGridView1.DataSource = (Ds.Tables("tbl_user"))
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.RowHeadersVisible = False

        ID.Hide()
        txt_user.Focus()
        txt_user.Text = ""
        txt_password.Text = ""
        cb_level.Text = ""

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New SqlCommand("select * from tbl_user where nama_user='" & DataGridView1.Item(0, i).Value & "' ", Conn)
        Dr = cmd.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then
            txt_user.Focus()
        Else
            Call editHapus()
            txt_user.Text = Dr.Item("nama_user")
            txt_password.Text = Dr.Item("password_user")
            cb_level.Text = Dr.Item("level_user")
            ID.Text = Dr.Item("id_user")
            txt_user.Focus()
        End If

    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub btn_Input_Click(sender As Object, e As EventArgs) Handles btn_Input.Click
        If txt_user.Text = "" Or txt_password.Text = "" Or cb_level.Text = "" Then
            MsgBox("Dimohon Isi Semua!", MsgBoxStyle.Information, "Informasi") 'seperti alert'
        Else
            Call Koneksi()
            Dim commad As String
            commad = "select * from tbl_user where nama_user='" & txt_user.Text & "'"
            cmd = New SqlCommand(commad, Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                MsgBox("Username yang anda isi sudah ada, harap menggunakan nama lain!", MsgBoxStyle.Information, "Informasi")
            Else
                Call Koneksi()
                Dim str As String
                str = "insert into tbl_user (nama_user,password_user,level_user) values ('" & txt_user.Text & "','" & txt_password.Text & "','" & cb_level.Text & "')"
                cmd = New SqlCommand(str, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berasih di Input!", MsgBoxStyle.Information, "Informasi")
                Call KondisiAwal()
            End If


        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call Koneksi()
        If ID.Text = "" Then
            MsgBox("Harap pilih data terlebih dahulu", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Dim edit As String
            edit = "UPDATE tbl_user SET nama_user='" & txt_user.Text & "', password_user='" & txt_password.Text & "' , level_user='" & cb_level.Text & "' where id_user='" & ID.Text & "'"
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
            hapus = "delete from tbl_user where id_user= '" & ID.Text & "'"
            cmd = New SqlCommand(hapus, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information, "Informasi")
            Call KondisiAwal()
        Else
            MsgBox("Data Batal di Hapus!")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call KondisiAwal()
        Me.Close()
        Beranda.Show()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Call KondisiAwal()
        Call Input()
    End Sub


End Class