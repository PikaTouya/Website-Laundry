Imports System.Data.SqlClient

Public Class FormConfirm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tbConfirm.Text = Module1.LoggedInUserPassword Then
            Me.Close()
            MasterFormPengguna.PanelUbahData.Visible = True
        Else
            MsgBox("Please put the correct password!")
            tbConfirm.Text = ""
            tbConfirm.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Call FormUtama.OpenChildForm(New MasterFormPengguna)
    End Sub

    Private Sub FormConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbConfirm.PasswordChar = "*"
    End Sub
End Class