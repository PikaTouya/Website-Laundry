Imports FontAwesome.Sharp

Public Class FormLogin
    Sub KondisiAwal()
        TextBox1.Text = "erwin"
        TextBox2.Text = "erwin"
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Mohon masukkan data dengan lengkap!")
            TextBox1.Focus()
        Else
            Call connect()
            Cmd = New SqlClient.SqlCommand("Select * From Pengguna where nama_pengguna='" & TextBox1.Text & "' and password_pengguna='" & TextBox2.Text & "'", Conn)
            Da = New SqlClient.SqlDataAdapter()
            Dr = Cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.Close()
                FormUtama.Show()
                Dim NamaUser As String = Dr("nama_pengguna").ToString()
                FormUtama.lblNamaUser.Text = NamaUser
                FormUtama.lblNamaUser.Visible = True
                FormUtama.IconUser.IconChar = IconChar.UserAlt
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

            Else
                MsgBox("Nama atau Password Salah!")
                Call KondisiAwal()
                TextBox1.Focus()
            End If
            Dr.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        FormUtama.Show()
        Call FormUtama.Reset()
    End Sub

End Class