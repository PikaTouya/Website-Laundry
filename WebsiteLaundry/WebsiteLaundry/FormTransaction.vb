Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows

Public Class FormTransaction


    Dim ctrl As String

    Private Sub kondisiawal()
        CBTipe.Items.Add("ID Transaction")
        CBTipe.Items.Add("ID User")
        CBTipe.DropDownStyle = ComboBoxStyle.DropDownList
        CBTipe.Text = "ID Transaction"
        CBStatus.Items.Add("In Progress..")
        CBStatus.Items.Add("Completed")
        CBStatus.DropDownStyle = ComboBoxStyle.DropDownList
        CBStatus.Visible = False
        BtnSave.Visible = False
    End Sub
    Private Sub Statuscolor()
        For i = 0 To LVDataTransaction.Items.Count - 1
            If LVDataTransaction.Items(i).SubItems(7).Text = "In Progress.." Then

                LVDataTransaction.Items.Item(i).BackColor = Color.FromArgb(255, 128, 128)
            Else
                LVDataTransaction.Items.Item(i).BackColor = Color.FromArgb(149, 255, 102)
            End If
        Next

    End Sub

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
            Dim berat_pakaian As String = Dr("berat_pakaian").ToString() & " KG"
            Dim jenis_cuci As String = Dr("jenis_cuci").ToString()
            Dim pakai_kupon As String = Dr("pakai_kupon").ToString()
            Dim harga_transaksi As String = "Rp " & Dr("harga_transaksi").ToString()
            Dim status_transaksi As String = Dr("status_transaksi").ToString()



            ' Tambahkan item baru ke ListView
            With LVDataTransaction.Items.Add(id_transaksi)
                .SubItems.Add(tanggal_Transaksi)
                .SubItems.Add(id_pengguna)
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
        View()
        LVDataTransaction.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Statuscolor()
        kondisiawal()
    End Sub

    Private Sub SearchData(searchText As String)
        If CBTipe.Text = "ID Transaction" Then

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
            strsql = "Select * FROM Transaksi WHERE id_transaksi Like @SearchText"
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
                Dim berat_pakaian As String = Dr("berat_pakaian").ToString() & " KG"
                Dim jenis_cuci As String = Dr("jenis_cuci").ToString()
                Dim pakai_kupon As String = Dr("pakai_kupon").ToString()
                Dim harga_transaksi As String = Dr("harga_transaksi").ToString()
                Dim status_transaksi As String = Dr("status_transaksi").ToString()

                With LVDataTransaction.Items.Add(id_transaksi)
                    .SubItems.Add(tanggal_Transaksi)
                    .SubItems.Add(id_pengguna)
                    .SubItems.Add(berat_pakaian)
                    .SubItems.Add(jenis_cuci)
                    .SubItems.Add(pakai_kupon)
                    .SubItems.Add(harga_transaksi)
                    .SubItems.Add(status_transaksi)
                End With
            End While

            ' Tutup DataReader
            Dr.Close()

        Else

            If Dr IsNot Nothing AndAlso Not Dr.IsClosed Then
                Dr.Close()
            End If
            If Cmd Is Nothing Then
                Cmd = New SqlClient.SqlCommand()
            End If
            ' Bersihkan ListView
            LVDataTransaction.Items.Clear()

            ' Lakukan pencarian berdasarkan id_pengguna
            strsql = "Select * FROM Transaksi WHERE id_pengguna Like @SearchText"
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
                Dim berat_pakaian As String = Dr("berat_pakaian").ToString() & " KG"
                Dim jenis_cuci As String = Dr("jenis_cuci").ToString()
                Dim pakai_kupon As String = Dr("pakai_kupon").ToString()
                Dim harga_transaksi As String = Dr("harga_transaksi").ToString()
                Dim status_transaksi As String = Dr("status_transaksi").ToString()

                With LVDataTransaction.Items.Add(id_transaksi)
                    .SubItems.Add(tanggal_Transaksi)
                    .SubItems.Add(id_pengguna)
                    .SubItems.Add(berat_pakaian)
                    .SubItems.Add(jenis_cuci)
                    .SubItems.Add(pakai_kupon)
                    .SubItems.Add(harga_transaksi)
                    .SubItems.Add(status_transaksi)
                End With
            End While

            ' Tutup DataReader
            Dr.Close()

        End If
    End Sub

    Private Sub TBSearch_TextChanged(sender As Object, e As EventArgs) Handles TBSearch.TextChanged
        SearchData(TBSearch.Text)
        Statuscolor()
    End Sub

    Private Sub CBTipe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTipe.SelectedIndexChanged
        TBSearch.Text = ""
        View()
        Statuscolor()
    End Sub

    Private Sub LVDataTransaction_DoubleClick(sender As Object, e As EventArgs) Handles LVDataTransaction.DoubleClick
        With LVDataTransaction.SelectedItems(0)
            ctrl = .SubItems(0).Text
            LblIDTransaction.Text = .SubItems(0).Text
            LblDate.Text = .SubItems(1).Text
            LblID_User.Text = .SubItems(2).Text
            LblWeight.Text = .SubItems(3).Text
            LblTypeOfWash.Text = .SubItems(4).Text
            LblKuponTerpakai.Text = .SubItems(5).Text
            LblTotalHarga.Text = .SubItems(6).Text
            CBStatus.Visible = True
            CBStatus.Text = .SubItems(7).Text
        End With
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Dr IsNot Nothing AndAlso Not Dr.IsClosed Then
            Dr.Close()
        End If

        strsql = "UPDATE Transaksi Set status_transaksi = '" & CBStatus.Text & "' WHERE id_transaksi = '" & ctrl & "'"
        Dim Cmd As New SqlClient.SqlCommand
        Cmd.CommandText = strsql
        Cmd.Connection = Conn

        Try
            Cmd.ExecuteNonQuery()
            MsgBox("The data has been successfully updated!")
            View()
            Statuscolor()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
        BtnSave.Visible = False
        LblDate.Text = ""
        LblIDTransaction.Text = ""
        LblID_User.Text = ""
        LblKuponTerpakai.Text = ""
        LblTotalHarga.Text = ""
        LblTypeOfWash.Text = ""
        LblWeight.Text = ""
        CBStatus.Visible = False
    End Sub

    Private Sub CBStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBStatus.SelectedIndexChanged
        If Dr IsNot Nothing AndAlso Not Dr.IsClosed Then
            Dr.Close()
        End If

        strsql = "Select * FROM Transaksi WHERE id_transaksi = '" & ctrl & "'"
        Cmd.CommandText = strsql
        Cmd.Connection = Conn
        Da.SelectCommand = Cmd
        Dr = Cmd.ExecuteReader()

        Dr.Read()
        Dim status As String = Dr("status_transaksi").ToString()
        If status <> CBStatus.Text Then
            BtnSave.Visible = True
        Else
            BtnSave.Visible = False
        End If
    End Sub

End Class
