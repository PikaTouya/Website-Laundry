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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tanggal_transaksi
        '
        Me.tanggal_transaksi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tanggal_transaksi.AutoSize = True
        Me.tanggal_transaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal_transaksi.ForeColor = System.Drawing.Color.Gainsboro
        Me.tanggal_transaksi.Location = New System.Drawing.Point(170, 318)
        Me.tanggal_transaksi.Name = "tanggal_transaksi"
        Me.tanggal_transaksi.Size = New System.Drawing.Size(135, 29)
        Me.tanggal_transaksi.TabIndex = 0
        Me.tanggal_transaksi.Text = "Date/Time"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(663, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Type of Wash :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(170, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ID Transaction :"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(170, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 29)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Your User ID :"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(170, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(233, 29)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Date of Transaction :"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(663, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 29)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Weight of Clothes :"
        '
        'Id_Transaksi
        '
        Me.Id_Transaksi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Id_Transaksi.AutoSize = True
        Me.Id_Transaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_Transaksi.ForeColor = System.Drawing.Color.Gainsboro
        Me.Id_Transaksi.Location = New System.Drawing.Point(170, 255)
        Me.Id_Transaksi.Name = "Id_Transaksi"
        Me.Id_Transaksi.Size = New System.Drawing.Size(195, 29)
        Me.Id_Transaksi.TabIndex = 0
        Me.Id_Transaksi.Text = "ID Transsaction"
        '
        'cbjenis
        '
        Me.cbjenis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbjenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbjenis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbjenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbjenis.FormattingEnabled = True
        Me.cbjenis.Location = New System.Drawing.Point(668, 344)
        Me.cbjenis.Name = "cbjenis"
        Me.cbjenis.Size = New System.Drawing.Size(312, 37)
        Me.cbjenis.TabIndex = 1
        '
        'berat_pakaian
        '
        Me.berat_pakaian.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.berat_pakaian.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.berat_pakaian.Location = New System.Drawing.Point(668, 255)
        Me.berat_pakaian.Name = "berat_pakaian"
        Me.berat_pakaian.Size = New System.Drawing.Size(267, 34)
        Me.berat_pakaian.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(939, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kg"
        '
        'harga_transaksi
        '
        Me.harga_transaksi.AutoSize = True
        Me.harga_transaksi.BackColor = System.Drawing.Color.White
        Me.harga_transaksi.Dock = System.Windows.Forms.DockStyle.Right
        Me.harga_transaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.harga_transaksi.ForeColor = System.Drawing.Color.Black
        Me.harga_transaksi.Location = New System.Drawing.Point(353, 0)
        Me.harga_transaksi.Margin = New System.Windows.Forms.Padding(44, 40, 44, 40)
        Me.harga_transaksi.Name = "harga_transaksi"
        Me.harga_transaksi.Size = New System.Drawing.Size(31, 45)
        Me.harga_transaksi.TabIndex = 0
        Me.harga_transaksi.Text = "0"
        Me.harga_transaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.harga_transaksi.UseCompatibleTextRendering = True
        '
        'btnorder
        '
        Me.btnorder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnorder.Location = New System.Drawing.Point(392, 615)
        Me.btnorder.Name = "btnorder"
        Me.btnorder.Size = New System.Drawing.Size(178, 56)
        Me.btnorder.TabIndex = 3
        Me.btnorder.Text = "Order"
        Me.btnorder.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(598, 615)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(178, 56)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(663, 405)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(298, 29)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Want to use Your Coupon?"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(662, 436)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 29)
        Me.Label9.TabIndex = 0
        '
        'cbcoupon
        '
        Me.cbcoupon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbcoupon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcoupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbcoupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbcoupon.FormattingEnabled = True
        Me.cbcoupon.Location = New System.Drawing.Point(668, 434)
        Me.cbcoupon.Name = "cbcoupon"
        Me.cbcoupon.Size = New System.Drawing.Size(315, 37)
        Me.cbcoupon.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(170, 418)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(245, 29)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Your Phone Number :"
        '
        'Id_User
        '
        Me.Id_User.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Id_User.AutoSize = True
        Me.Id_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_User.ForeColor = System.Drawing.Color.Gainsboro
        Me.Id_User.Location = New System.Drawing.Point(170, 381)
        Me.Id_User.Name = "Id_User"
        Me.Id_User.Size = New System.Drawing.Size(100, 29)
        Me.Id_User.TabIndex = 0
        Me.Id_User.Text = "User ID"
        '
        'lbltelepon
        '
        Me.lbltelepon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltelepon.AutoSize = True
        Me.lbltelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelepon.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbltelepon.Location = New System.Drawing.Point(172, 442)
        Me.lbltelepon.Name = "lbltelepon"
        Me.lbltelepon.Size = New System.Drawing.Size(202, 29)
        Me.lbltelepon.TabIndex = 0
        Me.lbltelepon.Text = "User Telephone"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.harga_transaksi)
        Me.Panel1.Location = New System.Drawing.Point(392, 548)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 44)
        Me.Panel1.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-1, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 39)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Total : Rp."
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("News706 BT", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label12.Location = New System.Drawing.Point(351, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(438, 56)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Book Our Service!"
        '
        'FormOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1161, 730)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnorder)
        Me.Controls.Add(Me.berat_pakaian)
        Me.Controls.Add(Me.cbcoupon)
        Me.Controls.Add(Me.cbjenis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbltelepon)
        Me.Controls.Add(Me.Id_User)
        Me.Controls.Add(Me.Id_Transaksi)
        Me.Controls.Add(Me.tanggal_transaksi)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormOrder"
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tanggal_transaksi As Label
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
