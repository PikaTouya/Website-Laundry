Imports FontAwesome.Sharp
Public Class FormMaster

    Private Sub BtnListOfUser_Click(sender As Object, e As EventArgs) Handles BtnListOfUser.Click
        Me.Close()
        Call FormUtama.OpenChildForm(New MasterFormPengguna)
        FormUtama.IconChildForm.IconChar = IconChar.AddressBook
    End Sub

    Private Sub BtnPriceList_Click(sender As Object, e As EventArgs) Handles BtnPriceList.Click
        Me.Close()
        Call FormUtama.OpenChildForm(New MasterFormJasa)
        FormUtama.IconChildForm.IconChar = IconChar.Tag
    End Sub

    Private Sub FormMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class