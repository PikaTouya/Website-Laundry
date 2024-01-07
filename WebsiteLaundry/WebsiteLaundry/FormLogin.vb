Imports System.Data.SqlClient
Imports FontAwesome.Sharp

Public Class FormLoginOrSignup
    Dim connectionString As String = "Data Source=localhost; Initial Catalog=Laundry; Integrated Security=True"
    Dim strsql As String
    Sub KondisiAwal()
        TBUsername1.Text = "ADMIN001"
        TBPass1.Text = "SAYAADMIN001"
        TBPass1.PasswordChar = "*"

        TBUserID.Text = ""
        TBUserID.Enabled = False
        TBUsername2.Text = ""
        TBPhoneNumber.Text = ""
        TBPass2.Text = ""
        TBConfirmPass.Text = ""
        TBPass2.PasswordChar = "*"
        TBConfirmPass.PasswordChar = "*"
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KondisiAwal()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Text = String.Empty
    End Sub
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If TBUsername1.Text = "" Or TBPass1.Text = "" Then
            MsgBox("Mohon masukkan data dengan lengkap!")
            TBUsername1.Focus()
        Else
            Call connect()
            Cmd = New SqlClient.SqlCommand("Select * From Pengguna where nama_pengguna='" & TBUsername1.Text & "' and password_pengguna='" & TBPass1.Text & "'", Conn)
            Da = New SqlClient.SqlDataAdapter()
            Dr = Cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.Close()
                FormUtama.Show()
                Dim NamaUser As String = Dr("nama_pengguna").ToString()
                FormUtama.lblNamaUser.Text = NamaUser
                FormUtama.lblNamaUser.Visible = True
                FormUtama.IconUser.IconChar = IconChar.CircleUser
                FormUtama.IconUser.Visible = True
                FormUtama.btnlogin.Visible = False
                FormUtama.btnlogout.Visible = True
                Dim levelpengguna As String = Dr("level_pengguna").ToString()
                If levelpengguna = "ADMIN" Then
                    FormUtama.PanelMenu.Visible = True
                    FormUtama.btnTransaction.Visible = True
                    FormUtama.btnMaster.Visible = True
                    FormUtama.btnUtility.Visible = True
                    FormUtama.btnHistory.Visible = False
                    FormUtama.btnCoupon.Visible = False
                Else
                    FormUtama.PanelMenu.Visible = True
                    FormUtama.btnHistory.Visible = True
                    FormUtama.btnCoupon.Visible = True
                    FormUtama.btnUtility.Visible = True
                    FormUtama.btnTransaction.Visible = False
                    FormUtama.btnMaster.Visible = False
                    FormUtama.btnOrder.Visible = True
                End If
                Module1.LoggedInUserID = Dr("id_pengguna").ToString()

            Else
                MsgBox("Nama atau Password Salah!")
                Call KondisiAwal()
                TBUsername1.Focus()
            End If
            Dr.Close()
        End If
    End Sub

    Private Function GenerateID(prefix As String) As String
        ' Inisialisasi objek Conn (SqlConnection)
        Using Conn As New SqlConnection(connectionString)
            ' Buka koneksi sebelum menjalankan perintah SQL
            Conn.Open()

            ' Mendapatkan ID terakhir untuk pola tertentu
            strsql = "SELECT TOP 1 id_pengguna FROM Pengguna WHERE id_pengguna LIKE '" & prefix & "%' ORDER BY id_pengguna DESC"

            Using Cmd As New SqlCommand(strsql, Conn)
                Dr = Cmd.ExecuteReader()

                Dim newId As String

                If Dr.Read() Then
                    ' Jika ID sudah ada, dapatkan nomor berikutnya
                    Dim lastId As String = Dr("id_pengguna").ToString()
                    Dim lastNumber As Integer = Integer.Parse(lastId.Substring(prefix.Length))
                    Dim newNumber As Integer = lastNumber + 1
                    newId = prefix & newNumber.ToString("D3") ' D3 untuk format tiga digit angka
                Else
                    ' Jika belum ada ID, gunakan nomor awal
                    newId = prefix & "001"
                End If

                Dr.Close()

                ' Pastikan untuk menutup koneksi setelah selesai
                Conn.Close()

                Return newId
            End Using
        End Using
    End Function

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If (TBUserID.Text = "" Or TBUsername2.Text = "" Or TBPass2.Text = "" Or TBConfirmPass.Text = "" Or TBPhoneNumber.Text = "") Then
            MsgBox("Mohon isi semua data dengan lengkap!")
        Else
            'mengecek apakah nama user sudah ada di database atau belum
            Call connect()
            Cmd = New SqlClient.SqlCommand("SELECT nama_pengguna FROM Pengguna WHERE nama_pengguna='" & TBUsername2.Text & "'", Conn)
            Da = New SqlClient.SqlDataAdapter()
            Dr = Cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Dim NamaPengguna As String = Dr("nama_pengguna").ToString()
                If NamaPengguna = TBUsername2.Text Then
                    MsgBox("Username ini telah dipakai, silahkan pilih username lain.")
                End If
            End If
            Dr.Close()


            ' Mendapatkan pola ID 
            Dim idPola As String = If(TBUsername2.Text = "ADMIN", "ADM", "USR")
            Dim lvlpengguna As String = "USER"

            Using Conn As New SqlConnection(connectionString)
                Conn.Open()

                ' Mendapatkan ID terakhir untuk pola tertentu
                strsql = "SELECT TOP 1 id_pengguna FROM Pengguna WHERE id_pengguna LIKE '" & idPola & "%' ORDER BY id_pengguna DESC"
                Using Cmd As New SqlCommand(strsql, Conn)
                    Dim Dr As SqlDataReader = Cmd.ExecuteReader()
                    Dim newId As String

                    If Dr.Read() Then
                        ' Jika ID sudah ada, dapatkan nomor berikutnya
                        Dim lastId As String = Dr("id_pengguna").ToString()
                        Dim lastNumber As Integer = Integer.Parse(lastId.Substring(idPola.Length))
                        Dim newNumber As Integer = lastNumber + 1
                        newId = idPola & newNumber.ToString("D3") ' D3 untuk format tiga digit angka
                    Else
                        ' Jika belum ada ID, gunakan nomor awal
                        newId = idPola & "001"
                    End If
                    Dr.Close()


                    ' Insert data baru
                    strsql = "INSERT INTO Pengguna VALUES ('" & newId & "', '" & TBUsername2.Text & "', '" & TBPass2.Text & "', '" & lvlpengguna & "' ,'" & TBPhoneNumber.Text & "')"

                    Cmd.CommandText = strsql
                    Cmd.ExecuteNonQuery()
                End Using

                If TBPass2.Text = TBConfirmPass.Text Then
                    MsgBox("Data berhasil ditambahkan!")
                    Call KondisiAwal()
                    If PanelSlide.Location.X < 0 Then
                        PanelSlide.Location = New Point(PanelSlide.Location.X + 10, PanelSlide.Location.Y)
                    Else
                        Timer2.Stop()
                        btnLogIn.Enabled = True
                        btnSignUp.Enabled = True
                    End If

                    Timer2.Start()
                Else
                    MsgBox("Mohon konfirmasi password anda!")
                End If

            End Using
            ' Store the phone number in the shared property
            Module1.SignedUpPhoneNumber = TBPhoneNumber.Text
        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel1.Click
        Me.Close()
        FormUtama.Show()
    End Sub
    Private Sub btnCancel2_Click(sender As Object, e As EventArgs) Handles btnCancel2.Click
        Me.Close()
        FormUtama.Show()
    End Sub
    Private Sub LinkSignIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSignIn.LinkClicked
        Timer1.Start()
        btnLogIn.Enabled = False
        btnSignUp.Enabled = False
    End Sub
    Private Sub LinkLogIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLogIn.LinkClicked
        Timer2.Start()
        btnLogIn.Enabled = False
        btnSignUp.Enabled = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PanelSlide.Location.X > -750 Then
            PanelSlide.Location = New Point(PanelSlide.Location.X - 10, PanelSlide.Location.Y)
            TBUserID.Text = GenerateID("USR")

        Else
            Timer1.Stop()
            btnLogIn.Enabled = True
            btnSignUp.Enabled = True
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PanelSlide.Location.X < 0 Then
            PanelSlide.Location = New Point(PanelSlide.Location.X + 10, PanelSlide.Location.Y)
            TBUserID.Text = ""
        Else
            Timer2.Stop()
            btnLogIn.Enabled = True
            btnSignUp.Enabled = True
        End If
    End Sub


    Private Sub TBPhoneNumber_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TBPhoneNumber.KeyPress
        ' Hanya izinkan angka, backspace, dan tombol delete
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
            e.Handled = True ' Menahan karakter yang tidak valid
        End If
    End Sub
End Class