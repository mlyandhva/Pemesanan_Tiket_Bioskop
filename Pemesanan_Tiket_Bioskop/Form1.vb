Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Cek validasi username dan password (contoh sederhana)
        If TextBox1.Text = "admin" And TextBox2.Text = "password123" Then
            ' Jika validasi berhasil, lanjutkan ke form menu
            Dim formMenu As New Menu() ' Ganti Form2 dengan nama form menu Anda
            formMenu.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau password salah.")
        End If
    End Sub
End Class
