﻿Public Class MasterFormPengguna
    Dim ctrl As String

    Private Sub IconBack_Click(sender As Object, e As EventArgs) Handles IconBack.Click
        Me.Close()
        Call FormUtama.OpenChildForm(New FormMaster)
    End Sub

    'edited by ferico'
    Private Sub MasterFormPengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.connect()
        CBLevel1.Items.Add("ADMIN")
        CBLevel1.Items.Add("USER")
        CBLevel1.DropDownStyle = ComboBoxStyle.DropDownList
        Cblevel2.Items.Add("ADMIN")
        Cblevel2.Items.Add("USER")
        Cblevel2.DropDownStyle = ComboBoxStyle.DropDownList
        View()

        ' Inisialisasi objek Da'
        Da = New SqlClient.SqlDataAdapter()

        ' Tambahkan event handler untuk TBSearch
        AddHandler TBSearch.TextChanged, AddressOf TBSearch_TextChanged
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
        LVData.Items.Clear()

        ' Lakukan SELECT data dari tabel Pengguna
        strsql = "SELECT * FROM Pengguna"
        Cmd.CommandText = strsql
        Cmd.Connection = Conn
        Da.SelectCommand = Cmd
        Dr = Cmd.ExecuteReader()

        ' Tampilkan hasil SELECT di ListView
        While (Dr.Read())
            Dim id_pengguna As String = Dr("id_pengguna").ToString()
            Dim nama_pengguna As String = Dr("nama_pengguna").ToString()
            Dim level_pengguna As String = Dr("level_pengguna").ToString()
            Dim nomortelepon_pengguna As String = Dr("nomortelepon_pengguna").ToString()

            ' Tambahkan item baru ke ListView
            With LVData.Items.Add(id_pengguna)
                .SubItems.Add(nama_pengguna)
                .SubItems.Add(level_pengguna)
                .SubItems.Add(nomortelepon_pengguna)
            End With
        End While

        ' Tutup DataReader
        Dr.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If TBUserID.Text = "" Or TBUsername.Text = "" Or TBPass.Text = "" Or CBLevel1.Text = "" Or TBPhone.Text = "" Then
            MsgBox("Please complete the information!")
            Exit Sub
        End If

        ' Pengecekan apakah TBUserID.Text sudah ada dalam LVData
        For Each item As ListViewItem In LVData.Items
            If item.SubItems(0).Text = TBUserID.Text Then
                MsgBox("ID already exists. Please choose a different ID!")
                TBUserID.Focus()
                TBUserID.Text = ""
                Exit Sub
            End If
        Next

        ' Pastikan bahwa DataReader (Dr) ditutup sebelum menjalankan perintah INSERT
        If Dr IsNot Nothing AndAlso Not Dr.IsClosed Then
            Dr.Close()
        End If

        strsql = "INSERT INTO Pengguna VALUES ('" & TBUserID.Text & "','" & TBUsername.Text & "','" & TBPass.Text & "','" & CBLevel1.Text & "','" & TBPhone.Text & "')"
        Dim Cmd As New SqlClient.SqlCommand
        Cmd.CommandText = strsql
        Cmd.Connection = Conn

        Try
            Cmd.ExecuteNonQuery()
            MsgBox("Saved!")
            View()
            TBUserID.Text = ""
            TBUsername.Text = ""
            TBPass.Text = ""
            CBLevel1.Text = ""
            TBPhone.Text = ""

        Catch ex As SqlClient.SqlException
            If ex.Number = 2627 Then 'ex number adalah property yang memberikan nomor kesalahan yang diberikan oleh sql server 2627, itu berarti terjadi pelanggaran integritas data yang menyebabkan duplikasi nilai kunci unik (duplicate key)'
                MsgBox("Id must not be the same!") 'Oleh karena itu, kita menampilkan pesan "ID must not be the same!" kepada pengguna
            Else
                MsgBox("An error occurred: " & ex.Message) 'Jika nomor kesalahan bukan 2627, kita menampilkan pesan umum "An error occurred: " disertai dengan pesan kesalahan yang diberikan oleh eksepsi
            End If
        End Try
    End Sub

    Private Sub LVData_DoubleClick(sender As Object, e As EventArgs) Handles LVData.DoubleClick
        With LVData.SelectedItems(0)
            ctrl = .SubItems(0).Text
            TBUserID.Text = .SubItems(0).Text
            TBUserID.Enabled = False
            TBUsername.Text = .SubItems(1).Text
            CBLevel1.Text = .SubItems(2).Text
            TBPhone.Text = .SubItems(3).Text
            ' ketika mau ubah data, tombol tambah tidak akan bisa dipakai
            btnAdd.Enabled = False
            btnAdd.ForeColor = Color.DimGray
        End With
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If TBUserID.Text = "" Or TBUsername.Text = "" Or TBPass.Text = "" Or CBLevel1.Text = "" Or TBPhone.Text = "" Then
            MsgBox("Please fill in the data you want to modify first!")
            Exit Sub
        End If

        ' Pastikan bahwa DataReader ditutup sebelum menjalankan perintah UPDATE
        If Dr IsNot Nothing AndAlso Not Dr.IsClosed Then
                Dr.Close()
            End If

            strsql = "UPDATE Pengguna SET nama_pengguna = '" & TBUsername.Text & "', password_pengguna = '" & TBPass.Text & "', level_pengguna = '" & CBLevel1.Text & "', nomortelepon_pengguna = '" & TBPhone.Text & "' WHERE id_pengguna = '" & ctrl & "'"
            Dim Cmd As New SqlClient.SqlCommand
            Cmd.CommandText = strsql
            Cmd.Connection = Conn

        Try
            Cmd.ExecuteNonQuery()
            MsgBox("The data has been successfully updated!")
            View()
            TBUserID.Text = ""
            TBUsername.Text = ""
            TBPass.Text = ""
            CBLevel1.Text = ""
            TBPhone.Text = ""
            TBUserID.Enabled = True
            btnAdd.Enabled = True
            btnAdd.ForeColor = Color.Gainsboro
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If TBUserID.Text = "" Or TBUsername.Text = "" Or TBPass.Text = "" Or CBLevel1.Text = "" Or TBPhone.Text = "" Then
            MsgBox("Please fill In the data you want To modify first!")
            Exit Sub
        End If

        ' Pastikan bahwa DataReader ditutup sebelum menjalankan perintah DELETE
        If Dr IsNot Nothing AndAlso Not Dr.IsClosed Then
            Dr.Close()
        End If

        strsql = "DELETE FROM Pengguna WHERE id_pengguna = '" & ctrl & "'"
        Dim Cmd As New SqlClient.SqlCommand
        Cmd.CommandText = strsql
        Cmd.Connection = Conn
        Cmd.ExecuteNonQuery()
        MsgBox("The data has been successfully deleted!")
        View()
        TBUserID.Text = ""
        TBUsername.Text = ""
        TBPass.Text = ""
        CBLevel1.Text = ""
        TBPhone.Text = ""
        TBUserID.Enabled = True
        btnAdd.Enabled = True
        btnAdd.ForeColor = Color.Gainsboro
    End Sub

    'agar ketika tbsearch diketik, sudah memunculkan data yang berkaitan dengan tbsearch.text
    Private Sub TBSearch_TextChanged(sender As Object, e As EventArgs) Handles TBSearch.TextChanged
        SearchData(TBSearch.Text)
    End Sub

    Private Sub SearchData(searchText As String)
        ' Pastikan bahwa DataReader ditutup sebelum menjalankan perintah SELECT
        If Dr IsNot Nothing AndAlso Not Dr.IsClosed Then
            Dr.Close()
        End If
        ' Bersihkan ListView
        LVData.Items.Clear()

        ' Lakukan pencarian berdasarkan nama_pengguna
        strsql = "SELECT * FROM Pengguna WHERE nama_pengguna LIKE @SearchText"
        Cmd.CommandText = strsql
        Cmd.Connection = Conn
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")
        Da.SelectCommand = Cmd
        Dr = Cmd.ExecuteReader()

        ' Tampilkan hasil pencarian di ListView
        While (Dr.Read())
            With LVData.Items.Add(Dr("id_pengguna"))
                .SubItems.Add(Dr("nama_pengguna"))
                .SubItems.Add(Dr("level_pengguna"))
                .subItems.Add(Dr("nomortelepon_pengguna"))
            End With
        End While

        ' Tutup DataReader
        Dr.Close()
    End Sub


    Private Sub Cblevel2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cblevel2.SelectedIndexChanged
        ' Pastikan bahwa DataReader ditutup sebelum menjalankan perintah SELECT
        If Dr IsNot Nothing AndAlso Not Dr.IsClosed Then
            Dr.Close()
        End If

        ' Bersihkan ListView
        LVData.Items.Clear()

        ' Lakukan pencarian berdasarkan level_pengguna
        strsql = "SELECT * FROM Pengguna WHERE level_pengguna = '" & Cblevel2.Text & "'"
        Cmd.CommandText = strsql
        Cmd.Connection = Conn
        Da.SelectCommand = Cmd
        Dr = Cmd.ExecuteReader()

        ' Tampilkan hasil pencarian di ListView
        While (Dr.Read())
            With LVData.Items.Add(Dr("id_pengguna"))
                .SubItems.Add(Dr("nama_pengguna"))
                .SubItems.Add(Dr("level_pengguna"))
                .SubItems.Add(Dr("nomortelepon_pengguna"))
            End With
        End While

        ' Tutup DataReader
        Dr.Close()
    End Sub

    Private Sub ClearCbLevel2_Click(sender As Object, e As EventArgs) Handles ClearCbLevel2.Click
        Cblevel2.Items.Clear()
        Cblevel2.Items.Add("ADMIN")
        Cblevel2.Items.Add("USER")
        Cblevel2.DropDownStyle = ComboBoxStyle.DropDownList
        View()
    End Sub
    Private Sub ClearCbLevel1_Click(sender As Object, e As EventArgs) Handles ClearCbLevel1.Click
        CBLevel1.Items.Clear()
        CBLevel1.Items.Add("ADMIN")
        CBLevel1.Items.Add("USER")
        CBLevel1.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub TBPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBPhone.KeyPress
        ' Memeriksa apakah karakter yang dimasukkan adalah angka atau kontrol karakter (seperti backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Jika bukan angka, batalkan input
            e.Handled = True
        End If
    End Sub

    'finish by ferico
End Class