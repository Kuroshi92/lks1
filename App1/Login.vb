Imports System.Data.SqlClient

Public Class Login

    Sub Admin()
        Beranda.MasterToolStripMenuItem.Enabled = True
    End Sub

    Sub User()
        Beranda.MasterToolStripMenuItem.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        BuatAkun.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_userlogin.Text = "" Or txt_passwordlogin.Text = "" Then
            MsgBox("Dimohon Isi Semua!", MsgBoxStyle.Information, "Informasi") 'seperti alert'
        Else
            Call Koneksi()
            Dim command As String
            command = "select nama_user from tbl_user where nama_user='" & txt_userlogin.Text & "'"
            cmd = New SqlCommand(command, Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Call Koneksi()
                Dim str As String
                str = "select * from tbl_user where nama_user='" & txt_userlogin.Text & "' and password_user='" & txt_passwordlogin.Text & "'"
                cmd = New SqlCommand(str, Conn)
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    MsgBox("Login Berhasil!", MsgBoxStyle.Information, "Informasi")
                    Beranda.Show()
                    Beranda.Sid.Text = Dr!id_user
                    Beranda.SNama.Text = Dr!nama_user
                    Beranda.SLevel.Text = Dr!level_user

                    If Beranda.SLevel.Text = "admin" Then
                        Call Admin()
                    Else
                        Call User()
                    End If

                    Me.Hide()
                    txt_userlogin.Text = ""
                    txt_passwordlogin.Text = ""
                    txt_passwordlogin.PasswordChar = "*"
                Else
                    MsgBox("Password Salah!")
                End If
            Else
                MsgBox("Maaf Username tidak tersedia!", MsgBoxStyle.Information, "Informasi")
            End If
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_userlogin.Text = ""
        txt_passwordlogin.Text = ""
        txt_passwordlogin.PasswordChar = "*"
    End Sub

End Class