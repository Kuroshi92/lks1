Imports System.Data.SqlClient

Public Class FormLaporanPembelian
    Public kategori As String

    Sub KondisiAwal()
        Call Koneksi()

        Da = New SqlDataAdapter("SELECT * FROM tbl_pembelian ORDER BY id_pembelian DESC  ", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_pembelian")
        DataGridView1.DataSource = (Ds.Tables("tbl_pembelian"))
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.RowHeadersVisible = False

        tanggal.Hide()
        ComboBox1.SelectedItem = "ID"

    End Sub

    Private Sub FormLaporanPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub


    Private Sub txt_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_search.KeyPress
        Call Koneksi()
        Da = New SqlDataAdapter("SELECT * FROM tbl_pembelian WHERE " & kategori & " LIKE '%" & txt_search.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_pembelian")
        DataGridView1.DataSource = (Ds.Tables("tbl_pembelian"))
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.RowHeadersVisible = False

    End Sub


    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged


        Select Case ComboBox1.Text
            Case "Tanggal"
                kategori = "tanggal"
                tanggal.Show()
                txt_search.Hide()
            Case "Nama Supplier"
                kategori = "nama_supplier"
                tanggal.Hide()
                txt_search.Show()
            Case "Nama Barang"
                kategori = "nama_barang"
                tanggal.Hide()
                txt_search.Show()
            Case "ID"
                kategori = "id_pembelian"
                tanggal.Hide()
                txt_search.Show()
        End Select
    End Sub


    Private Sub tanggal_ValueChanged(sender As Object, e As EventArgs) Handles tanggal.ValueChanged
        Da = New SqlDataAdapter("SELECT * FROM tbl_pembelian WHERE " & kategori & " LIKE '%" & tanggal.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_pembelian")
        DataGridView1.DataSource = (Ds.Tables("tbl_pembelian"))
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.RowHeadersVisible = False
    End Sub

End Class