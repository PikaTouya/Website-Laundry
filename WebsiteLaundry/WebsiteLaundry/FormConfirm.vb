﻿Imports System.Data.SqlClient

Public Class FormConfirm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tbConfirm.Text = Module1.LoggedInUserPassword Then
            Me.Close()
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
End Class