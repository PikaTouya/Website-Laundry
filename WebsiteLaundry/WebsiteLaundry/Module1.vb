﻿Imports System.Data.SqlClient
Module Module1
    Public LoggedInUserID As String = ""
    Public SignedUpPhoneNumber As String = ""
    Public LoggedInUserPassword As String = ""

    Public Conn As SqlConnection
    Public Cmd As SqlCommand
    Public Dr As SqlDataReader
    Public strsql As String
    Public Da As SqlDataAdapter
    Public Ds As DataSet

    Sub connect()
        strsql = "Data Source=localhost; Initial Catalog=Laundry; Integrated Security=True"
        Conn = New SqlConnection(strsql)
        If Conn.State = ConnectionState.Closed Then 'jika koneksi sedang tertutup
            Conn.Open()
        End If
    End Sub
End Module
