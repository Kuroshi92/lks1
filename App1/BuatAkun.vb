Imports System.Data.SqlClient

Public Class BuatAkun
    Sub kondisiawal()
        Call Koneksi()
        txt_username.Focus()
        txt_username.Text = ""
        txt_password.Text = ""
        txt_password.PasswordChar = "*"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        If txt_username.Text = "" Or txt_password.Text = "" Then
            MsgBox("DImohon Isi Semua!", MsgBoxStyle.Information, "Informasi") 'seperti alert'
        Else
            Call Koneksi()
            Dim commad As String
            commad = "select * from tbl_user where nama_user='" & txt_username.Text & "'"
            cmd = New SqlCommand(commad, Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                MsgBox("Username yang anda isi sudah ada, harap menggunakan nama lain!", MsgBoxStyle.Information, "Informasi")
            Else
                Call Koneksi()
                Dim str As String
                str = "insert into tbl_user (nama_user,password_user,level_user) values ('" & txt_username.Text & "','" & txt_password.Text & "','User')"
                cmd = New SqlCommand(str, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berasih di Input!", MsgBoxStyle.Information, "Informasi")
                Call kondisiawal()
                Me.Close()
                Login.Show()

            End If
        End If
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btn_kosongkan_Click(sender As Object, e As EventArgs) Handles btn_kosongkan.Click
        kondisiawal()
    End Sub
End Class