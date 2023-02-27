Imports System.Data.SqlClient

Public Class FormLaporanPenjualan
    Public Kategori As String

    Sub KondisiAwal()
        Call Koneksi()

        Da = New SqlDataAdapter("SELECT * FROM tbl_penjualan ORDER BY id_penjualan DESC", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_penjualan")
        DataGridView1.DataSource = (Ds.Tables("tbl_penjualan"))
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.RowHeadersVisible = False

        tanggal.Hide()
        ComboBox1.SelectedItem = "ID"

    End Sub

    Private Sub FormLaporanPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub txt_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_search.KeyPress
        Call Koneksi()
        Da = New SqlDataAdapter("SELECT * FROM tbl_penjualan WHERE " & Kategori & " LIKE '%" & txt_search.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_penjualan")
        DataGridView1.DataSource = (Ds.Tables("tbl_penjualan"))
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.RowHeadersVisible = False
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Select Case ComboBox1.Text
            Case "Tanggal"
                Kategori = "tanggal"
                tanggal.Show()
                txt_search.Hide()
            Case "Nama Pelanggan"
                Kategori = "nama_pelanggan"
                tanggal.Hide()
                txt_search.Show()
            Case "Nama Barang"
                Kategori = "nama_barang"
                tanggal.Hide()
                txt_search.Show()
            Case "ID"
                Kategori = "id_penjualan"
                tanggal.Hide()
                txt_search.Show()
        End Select
    End Sub

    Private Sub tanggal_ValueChanged(sender As Object, e As EventArgs) Handles tanggal.ValueChanged
        Da = New SqlDataAdapter("SELECT * FROM tbl_penjualan WHERE " & Kategori & " LIKE '%" & tanggal.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_penjualan")
        DataGridView1.DataSource = (Ds.Tables("tbl_penjualan"))
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.RowHeadersVisible = False
    End Sub

End Class