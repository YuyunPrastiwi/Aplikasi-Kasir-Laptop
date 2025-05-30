Imports System.Data.Odbc
Public Class Data_Laptop

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

    Sub simpan()
        koneksi()
        Dim sql As String = "insert into data_laptop values('" & kodebarang.Text & "','" & nama.Text & "','" &
       harga.Text & "','" & jumlah.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Sub tampil()
        dgvlaptop.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select * from data_laptop order by kode_barang asc", con)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then ' Periksa apakah DataTable berisi data
                For Each row In dt.Rows
                    dgvlaptop.Rows.Add(row(0), row(1), row(2), row(3))
                Next
            Else
                MsgBox("Tidak ada data yang ditemukan.")
            End If

            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL: " & ex.Message)
        End Try
    End Sub


    Sub KondisiAwal()
        kodebarang.Text = ""
        nama.Text = ""
        harga.Text = ""
        jumlah.Text = ""
        kodebarang.Enabled = False
        nama.Enabled = False
        harga.Enabled = False
        jumlah.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button1.Text = "input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"


    End Sub

    Private Sub Data_Laptop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tampil()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        kodebarang.Text = ""
        nama.Text = ""
        harga.Text = ""
        jumlah.Text = ""
        kodebarang.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As String = dgvlaptop.Item(0, dgvlaptop.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Laptop yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan daftar=" & a &
            "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) =
            Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from pasien_bpjs where id='" & a &
                "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                tampil()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub dgvlaptop_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        simpan()
    End Sub
End Class