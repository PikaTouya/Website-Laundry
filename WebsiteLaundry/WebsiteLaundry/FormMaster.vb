Public Class FormMaster
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Call FormUtama.OpenChildForm(New MasterFormPengguna)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Call FormUtama.OpenChildForm(New MasterFormJasa)
    End Sub

End Class