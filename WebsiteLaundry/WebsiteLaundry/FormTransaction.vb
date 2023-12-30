Imports System.Data.SqlClient
Public Class FormTransaction
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

        ' Update id_transaksi based on the transactionCounter
        Id_Transaksi.Text = "TR" & transactionCounter.ToString("D3") 'disini D3 karena kita menformat agar angka dengan panjang tetap 3 digit
        transactionCounter += 1

        'menangkap id user secara otomatis
        Id_User.Text = Module1.LoggedInUserID
    End Sub

    Private Sub berat_pakaian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles berat_pakaian.KeyPress, tbtelepon.KeyPress
        ' Memeriksa apakah karakter yang dimasukkan adalah angka atau kontrol karakter (seperti backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Jika bukan angka, batalkan input
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
        If tbtelepon.Text = "" Or berat_pakaian.Text = "" Or cbjenis.Text = "" Then
            MsgBox("Please fill in your order!")
        Else
            ' Connect to the database

            MsgBox("Your order has been successfully received!")

            ' Close the current form and show the main form or any other form as needed
            Me.Close()
            FormUtama.Show()
        End If
    End Sub
End Class