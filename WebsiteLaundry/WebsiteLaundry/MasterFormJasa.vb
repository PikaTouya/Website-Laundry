﻿Imports System.Data.SqlClient


Public Class MasterFormJasa
    Private Sub IconBack_Click(sender As Object, e As EventArgs) Handles IconBack.Click
        Me.Close()
        Call FormUtama.OpenChildForm(New FormMaster)
    End Sub

    Private Sub MasterFormJasa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Panggil fungsi untuk mengisi nilai awal textbox dengan harga dari database
        LoadPricesFromDatabase()
    End Sub

    Private Sub LoadPricesFromDatabase()
        ' Panggil fungsi connect dari Module1 untuk membuka koneksi ke database
        connect()

        ' Ambil harga dari database untuk setiap jenis cuci
        Dim query As String = "SELECT * FROM Jasa"
        Cmd = New SqlCommand(query, Conn)
        Dr = Cmd.ExecuteReader()

        While Dr.Read()
            Dim jenisCuci As String = Dr("jenis_cuci").ToString()
        Dim harga As Decimal = Convert.ToDecimal(Dr("harga"))

        ' Update nilai textbox sesuai dengan jenis cuci
        Select Case jenisCuci
            Case "Normal Wash"
                tbharganormal.Text = harga.ToString("N0")
            Case "Normal Wash + Ironing"
                tbharganormalsetrika.Text = harga.ToString("N0")
            Case "Quick Wash"
                tbhargaquick.Text = harga.ToString("N0")
            Case "Quick Wash + Ironing"
                tbhargaquicksetrika.Text = harga.ToString("N0")
        End Select
        End While

        ' Tutup koneksi setelah selesai membaca data
        Dr.Close()
        Conn.Close()
    End Sub

    Private Sub SavePricesToDatabase()
        ' Panggil fungsi connect dari Module1 untuk membuka koneksi ke database
        connect()

        ' Update harga di database sesuai dengan nilai textbox yang diubah
        Dim updateQuery As String = "UPDATE Jasa SET harga = @harga WHERE jenis_cuci = @jenisCuci"
        Cmd = New SqlCommand(updateQuery, Conn)

        ' Parameter untuk jenis cuci Normal Wash
        UpdatePrice("Normal Wash", tbharganormal.Text)

        ' Parameter untuk jenis cuci Normal Wash + Ironing
        UpdatePrice("Normal Wash + Ironing", tbharganormalsetrika.Text)

        ' Parameter untuk jenis cuci Quick Wash
        UpdatePrice("Quick Wash", tbhargaquick.Text)

        ' Parameter untuk jenis cuci Quick Wash + Ironing
        UpdatePrice("Quick Wash + Ironing", tbhargaquicksetrika.Text)

        ' Tutup koneksi setelah selesai menyimpan data
        Conn.Close()

        ' Tampilkan pesan bahwa harga telah berhasil disimpan
        MessageBox.Show("Harga berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UpdatePrice(jenisCuci As String, hargaText As String)
        ' Convert hargaText ke nilai Decimal
        Dim harga As Decimal
        If Decimal.TryParse(hargaText, harga) Then
            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("@harga", harga)
            ' Ganti tipe data parameter sesuai dengan tipe data kolom di database
            Cmd.Parameters.Add("@jenisCuci", SqlDbType.NVarChar).Value = jenisCuci
            Cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub SavePrice_Click(sender As Object, e As EventArgs) Handles SavePrice.Click
        ' Panggil fungsi untuk menyimpan harga ke database
        SavePricesToDatabase()
    End Sub
End Class