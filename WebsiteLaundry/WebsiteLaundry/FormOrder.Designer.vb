<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tanggal_transaksi = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Id_Transaksi = New System.Windows.Forms.Label()
        Me.cbjenis = New System.Windows.Forms.ComboBox()
        Me.berat_pakaian = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.harga_transaksi = New System.Windows.Forms.Label()
        Me.btnorder = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbcoupon = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Id_User = New System.Windows.Forms.Label()
        Me.lbltelepon = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tanggal_transaksi
        '
        Me.tanggal_transaksi.AutoSize = True
        Me.tanggal_transaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal_transaksi.ForeColor = System.Drawing.Color.Gainsboro
        Me.tanggal_transaksi.Location = New System.Drawing.Point(229, 293)
        Me.tanggal_transaksi.Name = "tanggal_transaksi"
        Me.tanggal_transaksi.Size = New System.Drawing.Size(103, 25)
        Me.tanggal_transaksi.TabIndex = 0
        Me.tanggal_transaksi.Text = "Date/Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(151, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(388, 51)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Book Our Service!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(71, 370)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Type of Wash :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(67, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ID Transaction :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(129, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ID User :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(24, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Date of Transaction :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(39, 333)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Weight of Clothes :"
        '
        'Id_Transaksi
        '
        Me.Id_Transaksi.AutoSize = True
        Me.Id_Transaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_Transaksi.ForeColor = System.Drawing.Color.Gainsboro
        Me.Id_Transaksi.Location = New System.Drawing.Point(229, 173)
        Me.Id_Transaksi.Name = "Id_Transaksi"
        Me.Id_Transaksi.Size = New System.Drawing.Size(27, 25)
        Me.Id_Transaksi.TabIndex = 0
        Me.Id_Transaksi.Text = "id"
        '
        'cbjenis
        '
        Me.cbjenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbjenis.FormattingEnabled = True
        Me.cbjenis.Location = New System.Drawing.Point(234, 374)
        Me.cbjenis.Name = "cbjenis"
        Me.cbjenis.Size = New System.Drawing.Size(256, 24)
        Me.cbjenis.TabIndex = 1
        '
        'berat_pakaian
        '
        Me.berat_pakaian.Location = New System.Drawing.Point(234, 335)
        Me.berat_pakaian.Name = "berat_pakaian"
        Me.berat_pakaian.Size = New System.Drawing.Size(74, 22)
        Me.berat_pakaian.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(324, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kg"
        '
        'harga_transaksi
        '
        Me.harga_transaksi.AutoSize = True
        Me.harga_transaksi.BackColor = System.Drawing.Color.White
        Me.harga_transaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.harga_transaksi.ForeColor = System.Drawing.Color.Black
        Me.harga_transaksi.Location = New System.Drawing.Point(663, 173)
        Me.harga_transaksi.Name = "harga_transaksi"
        Me.harga_transaksi.Size = New System.Drawing.Size(242, 91)
        Me.harga_transaksi.TabIndex = 0
        Me.harga_transaksi.Text = "Biaya"
        '
        'btnorder
        '
        Me.btnorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnorder.Location = New System.Drawing.Point(605, 439)
        Me.btnorder.Name = "btnorder"
        Me.btnorder.Size = New System.Drawing.Size(163, 53)
        Me.btnorder.TabIndex = 3
        Me.btnorder.Text = "Order"
        Me.btnorder.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(797, 439)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(163, 53)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(600, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(375, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "You have a coupon, do you wanna use it?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(600, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 25)
        Me.Label9.TabIndex = 0
        '
        'cbcoupon
        '
        Me.cbcoupon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcoupon.FormattingEnabled = True
        Me.cbcoupon.Location = New System.Drawing.Point(605, 322)
        Me.cbcoupon.Name = "cbcoupon"
        Me.cbcoupon.Size = New System.Drawing.Size(370, 24)
        Me.cbcoupon.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(17, 250)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "User Phone Number :"
        '
        'Id_User
        '
        Me.Id_User.AutoSize = True
        Me.Id_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_User.ForeColor = System.Drawing.Color.Gainsboro
        Me.Id_User.Location = New System.Drawing.Point(229, 214)
        Me.Id_User.Name = "Id_User"
        Me.Id_User.Size = New System.Drawing.Size(27, 25)
        Me.Id_User.TabIndex = 0
        Me.Id_User.Text = "id"
        '
        'lbltelepon
        '
        Me.lbltelepon.AutoSize = True
        Me.lbltelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelepon.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbltelepon.Location = New System.Drawing.Point(229, 250)
        Me.lbltelepon.Name = "lbltelepon"
        Me.lbltelepon.Size = New System.Drawing.Size(76, 25)
        Me.lbltelepon.TabIndex = 0
        Me.lbltelepon.Text = "telepon"
        '
        'FormTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 554)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnorder)
        Me.Controls.Add(Me.berat_pakaian)
        Me.Controls.Add(Me.cbcoupon)
        Me.Controls.Add(Me.cbjenis)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.harga_transaksi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbltelepon)
        Me.Controls.Add(Me.Id_User)
        Me.Controls.Add(Me.Id_Transaksi)
        Me.Controls.Add(Me.tanggal_transaksi)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormTransaction"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tanggal_transaksi As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Id_Transaksi As Label
    Friend WithEvents cbjenis As ComboBox
    Friend WithEvents berat_pakaian As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents harga_transaksi As Label
    Friend WithEvents btnorder As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbcoupon As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Id_User As Label
    Friend WithEvents lbltelepon As Label
End Class
