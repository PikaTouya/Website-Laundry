﻿Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.ComTypes
Imports Microsoft.VisualBasic.ApplicationServices

Public Class FormHistory
    Dim ctrl As String

    Private Sub Statuscolor()
        For i = 0 To LVDataHistory.Items.Count - 1
            If LVDataHistory.Items(i).SubItems(6).Text = "In Progress.." Then

                LVDataHistory.Items.Item(i).BackColor = Color.FromArgb(250, 123, 123) 'warna merah
            Else
                LVDataHistory.Items.Item(i).BackColor = Color.FromArgb(149, 255, 102) ' warna hijau
            End If
        Next

    End Sub

    Public Function GetLVDataHistory() As ListView
        Return LVDataHistory
    End Function

    Sub View(lVDataHistory As ListView)
        If Dr IsNot Nothing AndAlso Not Dr.IsClosed Then
            Dr.Close()
        End If

        ' Pastikan bahwa Cmd telah diinisialisasi sebelum digunakan
        If Cmd Is Nothing Then
            Cmd = New SqlClient.SqlCommand()
        End If

        ' Bersihkan ListView
        lVDataHistory.Items.Clear()

        ' Pastikan bahwa DataReader (Dr) ditutup sebelum menjalankan perintah SELECT
        Call connect()
        Cmd = New SqlClient.SqlCommand("SELECT * FROM Pengguna WHERE nama_pengguna = '" & FormUtama.lblNamaUser.Text & "'", Conn)
        Da = New SqlClient.SqlDataAdapter()
        Dr = Cmd.ExecuteReader
        Dr.Read()
        Dim IdUSER As String = Dr("id_pengguna").ToString()

        Dr.Close()

        ' Lakukan SELECT data dari tabel Pengguna
        strsql = "SELECT * FROM Transaksi  WHERE id_pengguna= '" & IdUSER & "'"
        Cmd.CommandText = strsql
        Cmd.Connection = Conn
        Da.SelectCommand = Cmd
        Dr = Cmd.ExecuteReader()

        ' Tampilkan hasil SELECT di ListView
        While (Dr.Read())
            Dim jenis_cuci As String

            Select Case Dr("id_jasa").ToString()
                Case "JS001"
                    jenis_cuci = "Normal Wash"
                Case "JS002"
                    jenis_cuci = "Normal Wash + Ironing"
                Case "JS003"
                    jenis_cuci = "Quick Wash"
                Case "JS004"
                    jenis_cuci = "Quick Wash + Ironing"
                Case Else
                    jenis_cuci = "Tidak Diketahui"
            End Select


            Dim id_transaksi As String = Dr("id_transaksi").ToString()
            Dim tanggal_Transaksi As String = Dr("tanggal_transaksi").ToString()
            Dim berat_pakaian As String = Dr("berat_pakaian").ToString() & " KG"
            Dim pakai_kupon As String = Dr("pakai_kupon").ToString()
            Dim harga_transaksi As String = "Rp " & Convert.ToDecimal(Dr("harga_transaksi")).ToString("F0").Replace(",", "").Replace(".", "")
            Dim status_transaksi As String = Dr("status_transaksi").ToString()



            ' Tambahkan item baru ke ListView
            With lVDataHistory.Items.Add(id_transaksi)
                .SubItems.Add(tanggal_Transaksi)
                .SubItems.Add(berat_pakaian)
                .SubItems.Add(jenis_cuci)
                .SubItems.Add(pakai_kupon)
                .SubItems.Add(harga_transaksi)
                .SubItems.Add(status_transaksi)
            End With

        End While

        ' Tutup DataReader
        Dr.Close()
    End Sub

    Private Sub FormHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.connect()
        View(GetLVDataHistory())
        LVDataHistory.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize) 'menyesuaikan lebar kolom sesuai dengan headernya
        Statuscolor()
    End Sub

    Private Sub SearchData(searchText As String)
        ' Pastikan bahwa DataReader ditutup sebelum menjalankan perintah SELECT
        If Dr IsNot Nothing AndAlso Not Dr.IsClosed Then
            Dr.Close()
        End If
        If Cmd Is Nothing Then
            Cmd = New SqlClient.SqlCommand()
        End If
        ' Bersihkan ListView
        LVDataHistory.Items.Clear()

        Call connect()
        Cmd = New SqlClient.SqlCommand("SELECT * FROM Pengguna WHERE nama_pengguna = '" & FormUtama.lblNamaUser.Text & "'", Conn)
        Da = New SqlClient.SqlDataAdapter()
        Dr = Cmd.ExecuteReader
        Dr.Read()
        Dim IdUSER As String = Dr("id_pengguna").ToString()

        Dr.Close()

        ' Lakukan pencarian berdasarkan nama_pengguna
        strsql = "SELECT * FROM Transaksi WHERE id_pengguna = '" & IdUSER & "' AND id_transaksi LIKE @SearchText"

        Cmd.CommandText = strsql
        Cmd.Connection = Conn
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")
        Da.SelectCommand = Cmd
        Dr = Cmd.ExecuteReader()

        ' Tampilkan hasil pencarian di ListView
        While (Dr.Read())
            Dim id_transaksi As String = Dr("id_transaksi").ToString()
            Dim tanggal_Transaksi As String = Dr("tanggal_transaksi").ToString()
            Dim berat_pakaian As String = Dr("berat_pakaian").ToString() & " KG"
            Dim jenis_cuci As String

            Select Case Dr("id_jasa").ToString()
                Case "JS001"
                    jenis_cuci = "Normal Wash"
                Case "JS002"
                    jenis_cuci = "Normal Wash + Ironing"
                Case "JS003"
                    jenis_cuci = "Quick Wash"
                Case "JS004"
                    jenis_cuci = "Quick Wash + Ironing"
                Case Else
                    jenis_cuci = "Tidak Diketahui"
            End Select
            Dim pakai_kupon As String = Dr("pakai_kupon").ToString()
            Dim harga_transaksi As String = "Rp " & Convert.ToDecimal(Dr("harga_transaksi")).ToString("F0").Replace(",", "").Replace(".", "")
            Dim status_transaksi As String = Dr("status_transaksi").ToString()

            With LVDataHistory.Items.Add(id_transaksi)
                .SubItems.Add(tanggal_Transaksi)
                .SubItems.Add(berat_pakaian)
                .SubItems.Add(jenis_cuci)
                .SubItems.Add(pakai_kupon)
                .SubItems.Add(harga_transaksi)
                .SubItems.Add(status_transaksi)
            End With
        End While

        ' Tutup DataReader
        Dr.Close()
    End Sub

    Private Sub TBSearch_TextChanged(sender As Object, e As EventArgs) Handles TBSearch.TextChanged
        SearchData(TBSearch.Text)
        Statuscolor()
    End Sub

End Class