Public Class FormUtility

    Sub KondisiAwal()
        CurrentPass.Text = ""
        NewPass.Text = ""
        RetypeNewPass.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CurrentPass.Text = "" Or NewPass.Text = "" Or RetypeNewPass.Text = "" Then
            MsgBox("Please fill all the password!")
        Else
            If CurrentPass.Text = NewPass.Text Then
                MsgBox("Please, use a different password.")
            Else
                ' Retrieve the currently logged-in user's password from the database
                Call connect()
                Cmd = New SqlClient.SqlCommand("SELECT password_pengguna FROM Pengguna WHERE nama_pengguna='" & FormUtama.lblNamaUser.Text & "'", Conn)
                Da = New SqlClient.SqlDataAdapter()
                Dr = Cmd.ExecuteReader
                Dr.Read()

                If Dr.HasRows Then
                    ' Compare the entered current password with the password from the database
                    Dim userEnteredCurrentPassword As String = CurrentPass.Text
                    Dim actualPasswordFromDatabase As String = Dr("password_pengguna").ToString()

                    If userEnteredCurrentPassword <> actualPasswordFromDatabase Then
                        MsgBox("Current password is incorrect!")
                        Call KondisiAwal()
                    ElseIf NewPass.Text <> RetypeNewPass.Text Then
                        MsgBox("Please Reconfirm your password!")
                        Call KondisiAwal()
                    Else
                        ' Update password in the database
                        Call connect()
                        Dim newPassword As String = NewPass.Text
                        Cmd = New SqlClient.SqlCommand("UPDATE Pengguna SET password_pengguna = @NewPassword WHERE nama_pengguna = @Username", Conn)
                        Cmd.Parameters.AddWithValue("@NewPassword", newPassword)
                        Cmd.Parameters.AddWithValue("@Username", FormUtama.lblNamaUser.Text)
                        Cmd.ExecuteNonQuery()

                        MsgBox("Password successfully changed! Please re-login")
                        Me.Close()
                        FormLoginOrSignup.show()
                        KondisiAwal()
                    End If
                End If
            End If

            Dr.Close()
        End If
    End Sub

    Private Sub FormUtility_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
End Class