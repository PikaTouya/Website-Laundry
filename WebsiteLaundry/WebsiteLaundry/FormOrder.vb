Imports System.Data.SqlClient
Imports System.Globalization 'untuk desimal
Public Class FormOrder
    Private transactionCounter As Integer = 1
    Private Sub FormOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmCoupon As New FormCoupon()
        frmCoupon.Show() ' alasan mengshow form coupon, karena ingin mengecek bisa pakai kupon atau tidak, jika tidak maka visible false
        frmCoupon.Hide() ' Jika Anda tidak ingin menampilkan FormCoupon secara langsung

        ' Tetapkan tanggal dan jam dan hari
        tanggal_transaksi.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy HH:mm:ss")

        'membuat pilihan pada cbjenis cuci
        cbjenis.Items.Add("Normal Wash")
        cbjenis.Items.Add("Normal Wash + Ironing")
        cbjenis.Items.Add("Quick Wash")
        cbjenis.Items.Add("Quick Wash + Ironing")

        'membuat pilihan cbjenis cbcoupon
        cbcoupon.Items.Add("Yes, I wanna use my coupon!")
        cbcoupon.Items.Add("No, I wanna keep it!")

        ' Connect ke database
        Module1.connect()

        ' Mendapatkan nilai terbesar dari id_transaksi pada database
        Dim strsqlMaxCounter As String = "SELECT MAX(CAST(SUBSTRING(id_transaksi, 3, 3) AS INT)) FROM Transaksi" 'mengambil potongan dari kolom id_transaksi dimulai dari karakter ke-3 sepanjang 3 karakter Misalnya, jika id_transaksi adalah "TR001", maka ini akan menghasilkan "001"
        Dim CmdMaxCounter As New SqlClient.SqlCommand(strsqlMaxCounter, Module1.Conn)

        Try
            Dim maxCounter As Object = CmdMaxCounter.ExecuteScalar() 'mengembalikan nilai pertama dari hasil eksekusi

            If maxCounter IsNot DBNull.Value AndAlso maxCounter IsNot Nothing Then
                ' Jika sudah ada transaksi, increment counter
                transactionCounter = CInt(maxCounter) + 1
            End If
        Catch ex As Exception
            ' Tangani exception jika terjadi kesalahan saat mengambil nilai terbesar
            MsgBox("Terjadi kesalahan saat mengambil nilai terbesar dari counter transaksi: " & ex.Message)
        End Try

        ' Set id_transaksi berdasarkan counter yang sudah diperbarui
        Id_Transaksi.Text = "TR" & transactionCounter.ToString("D3")

        'menangkap id user secara otomatis
        Id_User.Text = Module1.LoggedInUserID

        ' mengakses nomor telepon user dari database
        Dim phoneNumberQuery As String = "SELECT nomortelepon_pengguna FROM Pengguna WHERE id_pengguna = @id_pengguna"
        Using cmd As New SqlCommand(phoneNumberQuery, Module1.Conn)
            cmd.Parameters.AddWithValue("@id_pengguna", Module1.LoggedInUserID)

            Try
                Dim phoneNumber As Object = cmd.ExecuteScalar()

                If phoneNumber IsNot DBNull.Value AndAlso phoneNumber IsNot Nothing Then 'jika bukan null
                    ' menangkap nomor telepon user
                    lbltelepon.Text = phoneNumber.ToString()
                End If
            Catch ex As Exception
                ' Handle any exceptions that may occur during the database operation
                MsgBox("An error occurred while retrieving the phone number: " & ex.Message)
            End Try
        End Using

        If frmCoupon.lblUnusedCoupons.Text = "Unused Coupons: 0" Then
            Label8.Visible = False
            cbcoupon.Visible = False
        Else
            Label8.Visible = True
            cbcoupon.Visible = True
        End If
    End Sub

    Private Sub berat_pakaian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles berat_pakaian.KeyPress
        ' Mendapatkan tanda desimal dari pengaturan regional
        Dim decimalSeparator As String = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator

        ' Memeriksa apakah karakter yang dimasukkan adalah angka atau tanda desimal
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = decimalSeparator Then
            ' Jika bukan angka, tanda desimal, batalkan input
            e.Handled = True
        End If

        ' Mencegah lebih dari satu tanda desimal
        If e.KeyChar = decimalSeparator AndAlso berat_pakaian.Text.Contains(decimalSeparator) Then
            e.Handled = True
        End If
    End Sub

    Private Sub berat_pakaian_TextChanged(sender As Object, e As EventArgs) Handles berat_pakaian.TextChanged
        ' Periksa apakah cbjenis dan beratpakaian sudah di isi
        If Not String.IsNullOrEmpty(cbjenis.Text) AndAlso Not String.IsNullOrEmpty(berat_pakaian.Text) Then 'periksa apakah cbjenis dan berat pakaian textnya tidak kosong
            Dim berat As Double 'memakai tipe data double karena berat bisa saja desimal
            If Double.TryParse(berat_pakaian.Text, berat) Then 'Double.TryParse digunakan untuk mencoba mengonversi suatu string ke tipe data Double
                ' Panggil fungsi untuk mendapatkan harga dari database berdasarkan jenis cuci
                LoadPriceFromDatabase(cbjenis.Text)

                ' Hitung harga_transaksi berdasarkan harga dari database
                If cbcoupon.Text = "Yes, I wanna use my coupon!" Then
                    If berat_pakaian.Text <= 3 Then
                        harga_transaksi.Text = "0"
                    Else
                        MessageBox.Show("Maximum Weight While Using Coupon is 3 KG!")
                        berat_pakaian.Text = ""
                        cbjenis.SelectedIndex = -1 'untuk mereset pilihan combobox
                        cbcoupon.SelectedIndex = -1
                        harga_transaksi.Text = ""
                    End If
                Else
                    Dim harga As Double
                    If Double.TryParse(harga_transaksi.Text, harga) Then
                        harga_transaksi.Text = (harga * berat).ToString()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cbjenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbjenis.SelectedIndexChanged, cbcoupon.SelectedIndexChanged
        ' Panggil fungsi untuk mendapatkan harga dari database berdasarkan jenis cuci yang dipilih
        LoadPriceFromDatabase(cbjenis.Text)

        ' Mengupdate harga transaksi setelah user memilih jenis cuci
        berat_pakaian_TextChanged(sender, e)
    End Sub

    Private Sub cbcoupon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcoupon.SelectedIndexChanged
        ' Connect to the database
        Module1.connect()

        ' Get the user's ID
        Dim userId As String = Module1.LoggedInUserID

        ' Calculate total orders without using a coupon
        Dim totalOrderWithoutCouponQuery As String = "SELECT COUNT(*) FROM Transaksi WHERE pakai_kupon = 0 AND id_pengguna = @id_pengguna"
        Using cmdTotalOrderWithoutCoupon As New SqlCommand(totalOrderWithoutCouponQuery, Module1.Conn)
            cmdTotalOrderWithoutCoupon.Parameters.AddWithValue("@id_pengguna", userId)

            Try
                Dim totalOrderWithoutCoupon As Integer = CInt(cmdTotalOrderWithoutCoupon.ExecuteScalar())

                ' Calculate the remaining stars
                Dim currentOrders As Integer = totalOrderWithoutCoupon Mod 10

                ' Display the remaining stars
                FormCoupon.lblCurrentOrders.Text = "Current Orders: " & currentOrders.ToString()

                ' Calculate the unused coupons
                Dim totalOrderWithCouponQuery As String = "SELECT COUNT(*) FROM Transaksi WHERE pakai_kupon = 1 AND id_pengguna = @id_pengguna"
                Using cmdTotalOrderWithCoupon As New SqlCommand(totalOrderWithCouponQuery, Module1.Conn)
                    cmdTotalOrderWithCoupon.Parameters.AddWithValue("@id_pengguna", userId)

                    Try
                        Dim totalOrderWithCoupon As Integer = CInt(cmdTotalOrderWithCoupon.ExecuteScalar())

                        Dim unusedCoupons As Integer = (totalOrderWithoutCoupon \ 10) - totalOrderWithCoupon

                        ' If "Yes, I wanna use my coupon!" is selected, reduce the unused coupons by 1
                        If cbcoupon.Text = "Yes, I wanna use my coupon!" Then
                            unusedCoupons -= 1
                        End If

                        ' Display the unused coupons
                        FormCoupon.lblUnusedCoupons.Text = "Unused Coupons: " & unusedCoupons.ToString()
                    Catch ex As Exception
                        ' Handle any exceptions that may occur during the database operation
                        MsgBox("An error occurred while calculating total orders with coupon: " & ex.Message)
                    End Try
                End Using
            Catch ex As Exception
                ' Handle any exceptions that may occur during the database operation
                MsgBox("An error occurred while calculating total orders without coupon: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Fungsi untuk mendapatkan harga dari database berdasarkan jenis cuci
    Private Sub LoadPriceFromDatabase(jenisCuci As String)
        ' Panggil fungsi connect dari Module1 untuk membuka koneksi ke database
        connect()

        ' Ambil harga dari database untuk jenis cuci yang dipilih
        Dim query As String = "SELECT harga FROM Jasa WHERE jenis_cuci = @jenisCuci"
        Cmd = New SqlCommand(query, Conn)
        Cmd.Parameters.AddWithValue("@jenisCuci", jenisCuci)

        Try
            Dim harga As Object = Cmd.ExecuteScalar() 'untuk mengambil nilai harga dari database berdasarkan jenis cuci

            If harga IsNot DBNull.Value AndAlso harga IsNot Nothing Then
                ' Set nilai textbox harga_transaksi berdasarkan harga dari database
                harga_transaksi.Text = harga.ToString()
            End If
        Catch ex As Exception
            ' Handle any exceptions that may occur during the database operation
            MsgBox("An error occurred while retrieving the price: " & ex.Message)
        Finally
            ' Tutup koneksi setelah selesai membaca data
            Conn.Close()
        End Try
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
        FormUtama.Show()
    End Sub

    Private Sub btnorder_Click(sender As Object, e As EventArgs) Handles btnorder.Click
        If berat_pakaian.Text = "" Or cbjenis.Text = "" Then
            MsgBox("Please fill in your order!")
        Else
            ' Connect to the database
            Module1.connect()
            Dim StatusOrder As String = "In Progress.."
            ' Prepare the SQL statement for inserting data into the database
            Dim strsql As String = "INSERT INTO Transaksi (id_transaksi, id_pengguna, tanggal_transaksi, id_jasa, berat_pakaian, harga_transaksi, pakai_kupon, status_transaksi) " &
                               "VALUES (@id_transaksi, @id_pengguna, @tanggal_transaksi, @jenis_cuci, @berat_pakaian, @harga_transaksi, @pakai_kupon, @status_transaksi)"

            ' Create a new SqlCommand object
            Dim Cmd As New SqlClient.SqlCommand(strsql, Module1.Conn)

            Dim jenisCuci As String = String.Empty

            ' Ganti nilai @jenis_cuci berdasarkan kondisi
            Select Case cbjenis.Text
                Case "Normal Wash"
                    jenisCuci = "JS001"
                Case "Normal Wash + Ironing"
                    jenisCuci = "JS002"
                Case "Quick Wash"
                    jenisCuci = "JS003"
                Case "Quick Wash + Ironing"
                    jenisCuci = "JS004"
                Case Else
                    jenisCuci = "JS001"
            End Select

            Cmd.Parameters.AddWithValue("@id_transaksi", Id_Transaksi.Text)
            Cmd.Parameters.AddWithValue("@id_pengguna", Id_User.Text)
            Cmd.Parameters.AddWithValue("@tanggal_transaksi", DateTime.Now)
            Cmd.Parameters.AddWithValue("@jenis_cuci", jenisCuci)
            Cmd.Parameters.AddWithValue("@berat_pakaian", Decimal.Parse(berat_pakaian.Text))
            Cmd.Parameters.AddWithValue("@harga_transaksi", Decimal.Parse(harga_transaksi.Text))
            Cmd.Parameters.AddWithValue("@pakai_kupon", If(cbcoupon.Text = "Yes, I wanna use my coupon!", True, False))
            Cmd.Parameters.AddWithValue("@status_transaksi", StatusOrder)

            Try
                ' Execute the SQL command to insert data into the database
                Cmd.ExecuteNonQuery()

                MsgBox("Your order has been successfully received!")

                ' Close the current form and show the main form or any other form as needed
                Me.Close()
                FormUtama.Show()
            Catch ex As Exception
                ' Handle any exceptions that may occur during the database operation
                MsgBox("An error occurred while saving your order: " & ex.Message)
            End Try
        End If
    End Sub
End Class