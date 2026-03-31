Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class Reservasi
    ' Mendeklarasikan variabel untuk menyimpan informasi tiket
    Dim selectedSeat As Button
    Dim movieTitle As String
    Dim studio As String
    Dim showTime As String
    Dim selectedDate As String
    Dim seatNumber As String
    Dim paymentMethod As String

    ' Mendeklarasikan objek dari form (ComboBox, Label, Button)
    Private WithEvents cmbMovieTitle As ComboBox
    Private WithEvents cmbStudio As ComboBox
    Private WithEvents cmbShowTime As ComboBox
    Private WithEvents cmbPaymentMethod As ComboBox
    Private WithEvents dtpDate As DateTimePicker

    Private lblDetailDate As Label
    Private lblDetailShowTime As Label
    Private lblDetailSeatNumber As Label
    Private lblDetailPaymentMethod As Label

    ' Koneksi ke database MySQL
    Private conn As MySqlConnection

    ' Fungsi untuk mengatur nilai default ketika form dibuka
    Private Sub Reservasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi koneksi ke database
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=aplikasitiketbioskop")

        ' Inisialisasi warna button seat menjadi putih
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Name.StartsWith("Button") Then
                ctrl.BackColor = Color.White
            End If
        Next
    End Sub

    ' Fungsi untuk memilih seat
    Private Sub Seat_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click
        Dim btn As Button = CType(sender, Button)
        If btn.BackColor = Color.White Then
            If selectedSeat IsNot Nothing Then
                selectedSeat.BackColor = Color.White ' Mengembalikan seat yang sebelumnya dipilih ke warna putih
            End If
            btn.BackColor = Color.Red ' Mengubah seat yang dipilih menjadi warna merah
            selectedSeat = btn
        Else
            btn.BackColor = Color.White ' Jika seat dipilih kembali, maka kembalikan ke warna putih
            selectedSeat = Nothing
        End If
    End Sub

    ' Tombol Check Out untuk mengupdate informasi tiket di Detail Ticket dan menyimpan ke database
    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles Button29.Click
        ' Mengambil data dari combo box dan date picker di "Order Here"
        movieTitle = ComboBox1.SelectedItem.ToString()
        studio = ComboBox2.SelectedItem.ToString()
        showTime = ComboBox3.SelectedItem.ToString()
        selectedDate = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        seatNumber = ComboBox4.Text & ComboBox5.Text
        paymentMethod = ComboBox6.SelectedItem.ToString()

        ' Menampilkan data di panel "Detail Ticket"
        Label14.Text = movieTitle
        Label15.Text = studio
        Label25.Text = selectedDate
        Label26.Text = showTime
        Label27.Text = seatNumber
        Label28.Text = paymentMethod

        Try
            ' Membuka koneksi ke database
            conn.Open()

            ' Menyimpan data tiket ke database
            Dim query As String = "INSERT INTO tiket (MovieTitle, Studio, ShowTime, Date, SeatNumber, PaymentMethod) VALUES (@MovieTitle, @Studio, @ShowTime, @Date, @SeatNumber, @PaymentMethod)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MovieTitle", movieTitle)
                cmd.Parameters.AddWithValue("@Studio", studio)
                cmd.Parameters.AddWithValue("@ShowTime", showTime)
                cmd.Parameters.AddWithValue("@Date", selectedDate)
                cmd.Parameters.AddWithValue("@SeatNumber", seatNumber)
                cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Tiket berhasil disimpan ke database.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menyimpan ke database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Tombol EXIT untuk menutup aplikasi
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Application.Exit()
    End Sub

    ' Tombol BACK untuk kembali ke form Menu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Me.Hide()
        Dim Menu As New Menu()
        Menu.Show()
    End Sub

    ' Tombol "Get Ticket" untuk menyimpan gambar tiket
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Try
            ' Tentukan lokasi dan ukuran area yang ingin diambil sebagai gambar
            Dim bmp As New Bitmap(DetailOrder.Width, DetailOrder.Height)
            DetailOrder.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))

            ' Tentukan lokasi penyimpanan dan nama file
            Dim savePath As String = "D:\TicketDetail.jpg" ' Sesuaikan path penyimpanan

            ' Simpan gambar dalam format JPG
            bmp.Save(savePath, ImageFormat.Jpeg)

            ' Informasikan ke pengguna bahwa gambar berhasil disimpan
            MessageBox.Show("Tiket berhasil disimpan sebagai gambar di lokasi: " & savePath, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
