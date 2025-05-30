Imports System.Data.Odbc
Public Class Data_Barang

    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand

    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=toko_laptop"
        con.Open()
    End Sub


    Private Sub Data_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fr As New Menu
        fr.Show()
        Me.Close()
    End Sub
    

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        Dim connectionString As String = "your_connection_string_here"
        Dim query As String = "select * from data_obat where kode_obat='" & Cb1.Text & "'"

        Using con As New OdbcConnection(connectionString)
            con.Open()

            Using cmd As New OdbcCommand(query, con)
                Dim dr As OdbcDataReader = cmd.ExecuteReader()

                If dr.HasRows Then
                    dr.Read()
                    namabarang.Text = dr.Item("nama_barang").ToString()
                    txtharga.Text = dr.Item("harga_laptop").ToString()
                Else
                    MsgBox("Kode barang tidak ada")
                End If

                dr.Close()
            End Using
        End Using
    End Sub

End Class