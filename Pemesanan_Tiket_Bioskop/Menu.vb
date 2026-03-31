Public Class Menu
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim formReservasi As New Reservasi()
        formReservasi.Show()
        Me.Hide()
    End Sub
End Class