﻿Imports System.Data.SqlClient
Imports System.Globalization 'untuk desimal
Public Class FormOrder
    Private transactionCounter As Integer = 1
    Private Sub FormTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tetapkan tanggal dan jam dan hari
        tanggal_transaksi.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy HH:mm:ss")

        'membuat pilihan pada cbjenis cuci
        cbjenis.Items.Add("Normal Wash")
        cbjenis.Items.Add("Normal Wash + Ironing")
        cbjenis.Items.Add("Quick Wash")
        cbjenis.Items.Add("Quick Wash + Ironing")

        'membuat pilihan pada cbcoupon
        cbcoupon.Items.Add("Yes, I wanna use my coupon!")
        cbcoupon.Items.Add("No, I wanna keep it!")

        ' Connect ke database
        Module1.connect()

        ' Mendapatkan nilai terbesar dari id_transaksi pada database
        Dim strsqlMaxCounter As String = "SELECT MAX(CAST(SUBSTRING(id_transaksi, 3, 3) AS INT)) FROM Transaksi" 'mengambil potongan dari kolom id_transaksi dimulai dari karakter ke-3 sepanjang 3 karakter Misalnya, jika id_transaksi adalah "TR001", maka ini akan menghasilkan "001"
        Dim CmdMaxCounter As New SqlClient.SqlCommand(strsqlMaxCounter, Module1.Conn)

        Try
            Dim maxCounter As Object = CmdMaxCounter.ExecuteScalar()

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

        ' Access the phone number from the database based on the user ID
        Dim phoneNumberQuery As String = "SELECT nomortelepon_pengguna FROM Pengguna WHERE id_pengguna = @id_pengguna"
        Using cmd As New SqlCommand(phoneNumberQuery, Module1.Conn)
            cmd.Parameters.AddWithValue("@id_pengguna", Module1.LoggedInUserID)

            Try
                Dim phoneNumber As Object = cmd.ExecuteScalar()

                If phoneNumber IsNot DBNull.Value AndAlso phoneNumber IsNot Nothing Then
                    ' Set the phone number to lbltelepon
                    lbltelepon.Text = phoneNumber.ToString()
                End If
            Catch ex As Exception
                ' Handle any exceptions that may occur during the database operation
                MsgBox("An error occurred while retrieving the phone number: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub berat_pakaian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles berat_pakaian.KeyPress
        ' Mendapatkan tanda desimal dari pengaturan regional
        Dim decimalSeparator As String = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator

        ' Memeriksa apakah karakter yang dimasukkan adalah angka, tanda desimal, atau kontrol karakter (seperti backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = decimalSeparator AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Jika bukan angka, tanda desimal, atau kontrol karakter, batalkan input
            e.Handled = True
        End If

        ' Mencegah lebih dari satu tanda desimal
        If e.KeyChar = decimalSeparator AndAlso berat_pakaian.Text.Contains(decimalSeparator) Then
            e.Handled = True
        End If
    End Sub

    Private Sub berat_pakaian_TextChanged(sender As Object, e As EventArgs) Handles berat_pakaian.TextChanged
        'periksa apakah cbjenis dan beratpakaian sudah di isi
        If Not String.IsNullOrEmpty(cbjenis.Text) AndAlso Not String.IsNullOrEmpty(berat_pakaian.Text) Then
            If cbjenis.Text = "Normal Wash" Then
                If cbcoupon.Text = "Yes, I wanna use my coupon!" Then
                    harga_transaksi.Text = 0
                Else
                    harga_transaksi.Text = (10000 * Val(berat_pakaian.Text)).ToString()
                End If
            ElseIf cbjenis.Text = "Normal Wash + Ironing" Then
                If cbcoupon.Text = "Yes, I wanna use my coupon!" Then
                    harga_transaksi.Text = 0
                Else
                    harga_transaksi.Text = ((10000 * Val(berat_pakaian.Text)) + 5000).ToString()
                End If
            ElseIf cbjenis.Text = "Quick Wash" Then
                If cbcoupon.Text = "Yes, I wanna use my coupon!" Then
                    harga_transaksi.Text = 0
                Else
                    harga_transaksi.Text = (15000 * Val(berat_pakaian.Text)).ToString()
                End If
            ElseIf cbjenis.Text = "Quick Wash + Ironing" Then
                If cbcoupon.Text = "Yes, I wanna use my coupon!" Then
                    harga_transaksi.Text = 0
                Else
                    harga_transaksi.Text = ((15000 * Val(berat_pakaian.Text)) + 5000).ToString()
                End If
            Else
                harga_transaksi.Text = "????"
            End If
        End If
    End Sub

    Private Sub cbjenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbjenis.SelectedIndexChanged, cbcoupon.SelectedIndexChanged
        'mengupdate harga transaksi setelah user memasukan cbjenis dan berat pakaian
        berat_pakaian_TextChanged(sender, e)
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

            ' Prepare the SQL statement for inserting data into the database
            Dim strsql As String = "INSERT INTO Transaksi (id_transaksi, id_pengguna, tanggal_transaksi, jenis_cuci, berat_pakaian, harga_transaksi, pakai_kupon) " &
                               "VALUES (@id_transaksi, @id_pengguna, @tanggal_transaksi, @jenis_cuci, @berat_pakaian, @harga_transaksi, @pakai_kupon)"

            ' Create a new SqlCommand object
            Dim Cmd As New SqlClient.SqlCommand(strsql, Module1.Conn)

            ' Add parameters to the SqlCommand to prevent SQL injection
            Cmd.Parameters.AddWithValue("@id_transaksi", Id_Transaksi.Text)
            Cmd.Parameters.AddWithValue("@id_pengguna", Id_User.Text)
            Cmd.Parameters.AddWithValue("@tanggal_transaksi", DateTime.Now) ' Assuming you want to use the current timestamp
            Cmd.Parameters.AddWithValue("@jenis_cuci", cbjenis.Text)
            Cmd.Parameters.AddWithValue("@berat_pakaian", Decimal.Parse(berat_pakaian.Text))
            Cmd.Parameters.AddWithValue("@harga_transaksi", Decimal.Parse(harga_transaksi.Text))
            Cmd.Parameters.AddWithValue("@pakai_kupon", If(cbcoupon.Text = "Yes, I wanna use my coupon!", True, False))

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