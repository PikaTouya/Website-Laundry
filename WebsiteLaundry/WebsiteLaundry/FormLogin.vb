Imports System.Data.SqlClient
Imports FontAwesome.Sharp

Public Class FormLoginOrSignup
    Sub KondisiAwal()
        TBUsername1.Text = "ADMIN001"
        TBPass1.Text = "SAYAADMIN001"
        TBPass1.PasswordChar = "*"

        TBUserID.Text = ""
        TBUsername1.Text = ""
        TBPass2.Text = ""
        TBConfirmPass.Text = ""
        cmbLevel.Text = ""
        TBUserID.Enabled = False
        TBUsername2.Enabled = False 'awalnya tbusername, ferico ubah jadi tbusername2
        TBPass2.Enabled = False
        TBConfirmPass.Enabled = False
        If cmbLevel.Items.Count = 0 Then
            cmbLevel.Items.Add("ADMIN")
            cmbLevel.Items.Add("USER")
        End If
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
                TBUsername1.Focus()
            End If
            Dr.Close()
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
        Else
            Timer1.Stop()
            btnLogIn.Enabled = True
            btnSignUp.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PanelSlide.Location.X < 0 Then
            PanelSlide.Location = New Point(PanelSlide.Location.X + 10, PanelSlide.Location.Y)
        Else
            Timer2.Stop()
            btnLogIn.Enabled = True
            btnSignUp.Enabled = True
        End If
    End Sub
End Class