Imports System.Data.Odbc
Public Class Data_Pembeli

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
        Dim sql As String = "insert into data_pembeli values('" & txtNama.Text & "','" & txtNIK.Text & "','" &
       txtJenisKelamin.Text & "','" & txtAlamat.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Sub tampil()
        dgvpembeli.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select * from data_pembeli order by nama_pembeli asc", con)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then ' 
                For Each row In dt.Rows
                    dgvpembeli.Rows.Add(row(0), row(1), row(2), row(3))
                Next
            Else
                MsgBox("Tidak ada data yang ditemukan.")
            End If

            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL: " & ex.Message)
        End Try
    End Sub


    Private Sub Data_Pembeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tampil()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtNama.Text = ""
        txtNIK.Text = ""
        txtJenisKelamin.Text = ""
        txtAlamat.Text = ""
        txtNama.Focus()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim a As String = dgvPembeli.Item(0, dgvPembeli.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Pasien yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan daftar=" & a &
            "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) =
            Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from data_pembeli where id='" & a &
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

    Private Sub dgvPembeli_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class