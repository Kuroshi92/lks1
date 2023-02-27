Imports System.Data.SqlClient

Module KoneksiDB
    Public Conn As SqlConnection
    Public cmd As SqlCommand
    Public Da As SqlDataAdapter
    Public Dr As SqlDataReader
    Public Ds As DataSet

    Sub Koneksi()
        Dim Source As String
        Source = "Data Source=RPL15\SQLEXPRESS;initial catalog=db_user;integrated security=true"
        Conn = New SqlConnection(Source)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
