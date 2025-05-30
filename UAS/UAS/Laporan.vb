Imports System.Data.Odbc
Imports Microsoft.Reporting.WinForms

Public Class Laporan

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
        Dim sql As String = "insert into tbmhs values('" &
       Form_Data_Barang.kodebarang.Text & "','" & Form_Data_Barang.namabarang.Text & "','" &
       Form_Data_Barang.jumlahbarang.Text & "','" & Form_Data_Barang.hargabarang.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub



    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim id As New ReportParameter("daftar", Form_Data_Barang.daftar.Text)
        Me.ReportViewer1.LocalReport.SetParameters(id)
        Dim nama As New ReportParameter("nama", Form_Data_Barang.nama.Text)
        Me.ReportViewer1.LocalReport.SetParameters(nama)
        Dim alamat As New ReportParameter("alamat", Form_Data_Barang.jenis.Text)
        Me.ReportViewer1.LocalReport.SetParameters(alamat)
        Dim jenis As New ReportParameter("jenis kelamin", Form_Data_Barang.jenis.Text)
        Me.ReportViewer1.LocalReport.SetParameters(jenis)
        Me.ReportViewer1.RefreshReport()
    End Sub
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class