Public Class Login

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        End
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnMasuk.Click
        If TxtUser.Text = "" Then
            MsgBox("User Kosong")
        ElseIf TxtPassword.Text = "" Then
            MsgBox("User Kosong")
        Else
            If TxtUser.Text = "Admin" And TxtPassword.Text = "123" Then
                Dim FR As New Menu
                FR.Show()
                Me.Hide()
            Else
                MsgBox("Password Salah")
            End If
        End If
    End Sub
End Class