Public Class Menu

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Dim FR As New Login
        FR.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Sub Buka_Form(ByVal FR As Form)
        For Each F As Form In Me.MdiChildren
            If F.Name = FR.Name Then
                MsgBox("Form Sudah Terbuka")
                Exit Sub
            End If
        Next

        FR.MdiParent = Me
        FR.Show()
    End Sub

    Private Sub DatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseToolStripMenuItem.Click

    End Sub

    Private Sub Menu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtTgl.Text = FormatDateTime(Date.Now, DateFormat.LongDate)
        TxtJam.Text = TimeOfDay
        Pewaktu.Enabled = True
    End Sub

    Private Sub DAtaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DAtaToolStripMenuItem.Click
        Buka_Form(Data_Pembeli)
    End Sub


    Private Sub Pewaktu_Tick(sender As Object, e As EventArgs) Handles Pewaktu.Tick
        TxtTgl.Text = FormatDateTime(Date.Now, DateFormat.LongDate)
        TxtJam.Text = TimeOfDay
    End Sub

    Private Sub BArangKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BArangKeluarToolStripMenuItem.Click
        Buka_Form(Data_Barang)
    End Sub

    Private Sub TentangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangToolStripMenuItem.Click
        Buka_Form(Tentang)
    End Sub

    Private Sub KontakToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub DataLaptopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataLaptopToolStripMenuItem.Click
        Buka_Form(Data_Laptop)
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
