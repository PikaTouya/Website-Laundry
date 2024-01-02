Imports System.Runtime.InteropServices.ComTypes
Public Class FormTransaction


    Dim ctrl As String
        Sub View()
            ' Pastikan bahwa DataReader (Dr) ditutup sebelum menjalankan perintah SELECT
            If Dr IsNot Nothing AndAlso Not Dr.IsClosed Then
                Dr.Close()
            End If

            ' Pastikan bahwa Cmd telah diinisialisasi sebelum digunakan
            If Cmd Is Nothing Then
                Cmd = New SqlClient.SqlCommand()
            End If

        ' Bersihkan ListView
        LVDataTransaction.Items.Clear()

        ' Lakukan SELECT data dari tabel Pengguna
        strsql = "SELECT * FROM Transaksi"
            Cmd.CommandText = strsql
            Cmd.Connection = Conn
            Da.SelectCommand = Cmd
            Dr = Cmd.ExecuteReader()

            ' Tampilkan hasil SELECT di ListView
            While (Dr.Read())
                Dim id_transaksi As String = Dr("id_transaksi").ToString()
                Dim tanggal_Transaksi As String = Dr("tanggal_transaksi").ToString()
                Dim id_pengguna As String = Dr("id_pengguna").ToString()
                Dim berat_pakaian As String = Dr("berat_pakaian").ToString() & " kg"
                Dim jenis_cuci As String = Dr("jenis_cuci").ToString()
                Dim pakai_kupon As String = Dr("pakai_kupon").ToString()
                Dim harga_transaksi As String = Dr("harga_transaksi").ToString()



            ' Tambahkan item baru ke ListView
            With LVDataTransaction.Items.Add(id_transaksi)
                .SubItems.Add(tanggal_Transaksi)
                .SubItems.Add(id_pengguna)
                .SubItems.Add(berat_pakaian)
                .SubItems.Add(jenis_cuci)
                .SubItems.Add(pakai_kupon)
                .SubItems.Add(harga_transaksi)

            End With

        End While

            ' Tutup DataReader
            Dr.Close()
        End Sub

        Private Sub FormHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Module1.connect()
            View()
        LVDataTransaction.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
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
        LVDataTransaction.Items.Clear()

        ' Lakukan pencarian berdasarkan nama_pengguna
        strsql = "SELECT * FROM Transaksi WHERE id_transaksi LIKE @SearchText"
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
                Dim id_pengguna As String = Dr("id_pengguna").ToString()
                Dim berat_pakaian As String = Dr("berat_pakaian").ToString()
                Dim jenis_cuci As String = Dr("jenis_cuci").ToString()
                Dim pakai_kupon As String = Dr("pakai_kupon").ToString()
                Dim harga_transaksi As String = Dr("harga_transaksi").ToString()

            With LVDataTransaction.Items.Add(id_transaksi)
                .SubItems.Add(tanggal_Transaksi)
                .SubItems.Add(id_pengguna)
                .SubItems.Add(berat_pakaian)
                .SubItems.Add(jenis_cuci)
                .SubItems.Add(pakai_kupon)
                .SubItems.Add(harga_transaksi)
            End With
        End While

            ' Tutup DataReader
            Dr.Close()
        End Sub

        Private Sub TBSearch_TextChanged(sender As Object, e As EventArgs) Handles TBSearch.TextChanged
            SearchData(TBSearch.Text)
        End Sub
    End Class
