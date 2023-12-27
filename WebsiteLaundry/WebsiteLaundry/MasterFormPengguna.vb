Public Class MasterFormPengguna
    Private Sub IconBack_Click(sender As Object, e As EventArgs) Handles IconBack.Click
        Me.Close()
        Call FormUtama.OpenChildForm(New FormMaster)
    End Sub


End Class