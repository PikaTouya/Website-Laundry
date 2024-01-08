Public Class FormConfirmation

    Private Sub FormConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        If TBPass.Text = "" Then
            MsgBox("Please confirm your Password!")
        Else
            ' Retrieve the currently logged-in user's password from the database
            Call connect()
            Cmd = New SqlClient.SqlCommand("SELECT password_pengguna FROM Pengguna WHERE nama_pengguna='" & FormUtama.lblNamaUser.Text & "'", Conn)
            Da = New SqlClient.SqlDataAdapter()
            Dr = Cmd.ExecuteReader
            Dr.Read()

            If Dr.HasRows Then
                Dim PassPengguna As String = Dr("password_pengguna").ToString()
                If TBPass.Text = PassPengguna Then
                    Me.Close()
                End If
            End If
        End If

    End Sub
End Class