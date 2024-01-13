Imports System.Data.SqlClient
Public Class FormCoupon

    ' Mendefinisikan variabel untuk menyimpan jumlah order dan jumlah kupon
    Private orderCount As Integer = 0
    Private totalCoupon As Integer = 0

    Private Sub FormCoupon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.connect()

        'menangkap user id
        Dim userId As String = Module1.LoggedInUserID

        ' hitung total order tanpa kupon
        Dim totalOrderWithoutCouponQuery As String = "SELECT COUNT(*) FROM Transaksi WHERE pakai_kupon = 0 AND id_pengguna = @id_pengguna"
        Using cmdTotalOrderWithoutCoupon As New SqlCommand(totalOrderWithoutCouponQuery, Module1.Conn)
            cmdTotalOrderWithoutCoupon.Parameters.AddWithValue("@id_pengguna", userId)

            Try
                Dim totalOrderWithoutCoupon As Integer = CInt(cmdTotalOrderWithoutCoupon.ExecuteScalar())

                ' hitung current orders
                Dim currentOrders As Integer = totalOrderWithoutCoupon Mod 10

                ' Tampilkan current orders
                lblCurrentOrders.Text = "Current Orders: " & currentOrders.ToString()

                ' hitung unused coupons
                Dim totalOrderWithCouponQuery As String = "SELECT COUNT(*) FROM Transaksi WHERE pakai_kupon = 1 AND id_pengguna = @id_pengguna"
                Using cmdTotalOrderWithCoupon As New SqlCommand(totalOrderWithCouponQuery, Module1.Conn)
                    cmdTotalOrderWithCoupon.Parameters.AddWithValue("@id_pengguna", userId)

                    Try
                        Dim totalOrderWithCoupon As Integer = CInt(cmdTotalOrderWithCoupon.ExecuteScalar())

                        Dim unusedCoupons As Integer = (totalOrderWithoutCoupon \ 10) - totalOrderWithCoupon

                        ' tampilkan unused coupons
                        lblUnusedCoupons.Text = "Unused Coupons: " & unusedCoupons.ToString()
                    Catch ex As Exception
                        ' Handle any exceptions that may occur during the database operation
                        MsgBox("An error occurred while calculating total orders with coupon: " & ex.Message)
                    End Try
                End Using
            Catch ex As Exception
                ' Handle any exceptions that may occur during the database operation
                MsgBox("An error occurred while calculating total orders without coupon: " & ex.Message)
            End Try
        End Using
    End Sub

End Class