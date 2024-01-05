Public Class FormCoupon

    ' Mendefinisikan variabel untuk menyimpan jumlah order dan jumlah kupon
    Private orderCount As Integer = 0
    Private totalCoupon As Integer = 0

    Private Sub FormCoupon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Panggil fungsi untuk mengecek jumlah transaksi tanpa kupon
        CheckTransactionCount()
    End Sub

    Private Sub CheckTransactionCount()
        ' Connect to the database
        Module1.connect()

        ' Prepare the SQL statement for counting transactions without coupons
        Dim strsql As String = "SELECT COUNT(*) FROM Transaksi WHERE pakai_kupon = 0 AND id_pengguna = @id_pengguna"

        ' Create a new SqlCommand object
        Dim Cmd As New SqlClient.SqlCommand(strsql, Module1.Conn)

        ' Add parameters to the SqlCommand to prevent SQL injection
        Cmd.Parameters.AddWithValue("@id_pengguna", Module1.LoggedInUserID)

        Try
            ' Execute the SQL command to count order
            Dim currentOrderCount As Integer = CInt(Cmd.ExecuteScalar())

            ' Tambahkan jumlah order saat ini ke orderCount
            orderCount += currentOrderCount

            ' Jika orderCount mencapai atau melebihi 10, tambahkan 1 ke totalCoupon dan kurangkan 10 dari orderCount
            While orderCount >= 10
                totalCoupon += 1
                orderCount -= 10
            End While

            ' Tampilkan jumlah order dan jumlah kupon di label atau tempat yang sesuai di form Anda
            lblOrderCount.Text = orderCount.ToString()
            lblTotalCoupon.Text = totalCoupon.ToString()
        Catch ex As Exception
            ' Handle any exceptions that may occur during the database operation
            MsgBox("An error occurred while checking transaction count: " & ex.Message)
        Finally
            ' Tutup koneksi setelah selesai membaca data
            Module1.Conn.Close()
        End Try
    End Sub
End Class