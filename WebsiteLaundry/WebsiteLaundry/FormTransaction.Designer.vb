<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LVDataTransaction = New System.Windows.Forms.ListView()
        Me.id_transaksi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tanggal_transaksi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id_pengguna = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.berat_pakaian = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.jenis_cuci = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pakai_kupon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.harga_transaksi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.status_transaksi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LblTotalHarga = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CBStatus = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblKuponTerpakai = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblTypeOfWash = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblWeight = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblID_User = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblIDTransaction = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.CBTipe = New System.Windows.Forms.ComboBox()
        Me.BtnSave = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LVDataTransaction
        '
        Me.LVDataTransaction.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.LVDataTransaction.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LVDataTransaction.BackColor = System.Drawing.SystemColors.Window
        Me.LVDataTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LVDataTransaction.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_transaksi, Me.tanggal_transaksi, Me.id_pengguna, Me.berat_pakaian, Me.jenis_cuci, Me.pakai_kupon, Me.harga_transaksi, Me.status_transaksi})
        Me.LVDataTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVDataTransaction.FullRowSelect = True
        Me.LVDataTransaction.GridLines = True
        Me.LVDataTransaction.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LVDataTransaction.HideSelection = False
        Me.LVDataTransaction.Location = New System.Drawing.Point(24, 598)
        Me.LVDataTransaction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LVDataTransaction.Name = "LVDataTransaction"
        Me.LVDataTransaction.Size = New System.Drawing.Size(1261, 294)
        Me.LVDataTransaction.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.LVDataTransaction.TabIndex = 0
        Me.LVDataTransaction.UseCompatibleStateImageBehavior = False
        Me.LVDataTransaction.View = System.Windows.Forms.View.Details
        '
        'id_transaksi
        '
        Me.id_transaksi.Text = "ID Transaction"
        Me.id_transaksi.Width = 137
        '
        'tanggal_transaksi
        '
        Me.tanggal_transaksi.Text = "Transaction Date"
        Me.tanggal_transaksi.Width = 245
        '
        'id_pengguna
        '
        Me.id_pengguna.Text = "ID Customer"
        Me.id_pengguna.Width = 173
        '
        'berat_pakaian
        '
        Me.berat_pakaian.Text = "Weight"
        Me.berat_pakaian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.berat_pakaian.Width = 146
        '
        'jenis_cuci
        '
        Me.jenis_cuci.Text = "Type of wash"
        Me.jenis_cuci.Width = 161
        '
        'pakai_kupon
        '
        Me.pakai_kupon.Text = "Coupon"
        Me.pakai_kupon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.pakai_kupon.Width = 139
        '
        'harga_transaksi
        '
        Me.harga_transaksi.Text = "Total Price"
        Me.harga_transaksi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.harga_transaksi.Width = 176
        '
        'status_transaksi
        '
        Me.status_transaksi.Text = "Status"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("News706 BT", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(438, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(447, 67)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "All Transaction"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(315, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 32)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Search by "
        '
        'TBSearch
        '
        Me.TBSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBSearch.BackColor = System.Drawing.SystemColors.Window
        Me.TBSearch.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.TBSearch.ForeColor = System.Drawing.Color.Black
        Me.TBSearch.Location = New System.Drawing.Point(638, 133)
        Me.TBSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBSearch.Name = "TBSearch"
        Me.TBSearch.Size = New System.Drawing.Size(377, 41)
        Me.TBSearch.TabIndex = 20
        Me.TBSearch.WordWrap = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.Location = New System.Drawing.Point(352, 198)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 378)
        Me.Panel1.TabIndex = 21
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.OldLace
        Me.Panel8.Controls.Add(Me.TableLayoutPanel6)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 328)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(626, 50)
        Me.Panel8.TabIndex = 3
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(626, 50)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.LblTotalHarga)
        Me.Panel3.Location = New System.Drawing.Point(253, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(370, 44)
        Me.Panel3.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Label16.Size = New System.Drawing.Size(68, 39)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Total"
        '
        'LblTotalHarga
        '
        Me.LblTotalHarga.AutoSize = True
        Me.LblTotalHarga.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblTotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalHarga.Location = New System.Drawing.Point(370, 0)
        Me.LblTotalHarga.Name = "LblTotalHarga"
        Me.LblTotalHarga.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.LblTotalHarga.Size = New System.Drawing.Size(0, 39)
        Me.LblTotalHarga.TabIndex = 11
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.OldLace
        Me.Panel9.Controls.Add(Me.TableLayoutPanel7)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 251)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(626, 50)
        Me.Panel9.TabIndex = 3
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.FloralWhite
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.CBStatus, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(626, 50)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Label14.Size = New System.Drawing.Size(85, 39)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Status "
        '
        'CBStatus
        '
        Me.CBStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CBStatus.BackColor = System.Drawing.Color.FloralWhite
        Me.CBStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBStatus.FormattingEnabled = True
        Me.CBStatus.Location = New System.Drawing.Point(253, 2)
        Me.CBStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBStatus.Name = "CBStatus"
        Me.CBStatus.Size = New System.Drawing.Size(370, 45)
        Me.CBStatus.TabIndex = 27
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.OldLace
        Me.Panel7.Controls.Add(Me.TableLayoutPanel5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 200)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(626, 51)
        Me.Panel7.TabIndex = 3
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.LblKuponTerpakai, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(626, 51)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Label12.Size = New System.Drawing.Size(98, 39)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Coupon"
        '
        'LblKuponTerpakai
        '
        Me.LblKuponTerpakai.AutoSize = True
        Me.LblKuponTerpakai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKuponTerpakai.Location = New System.Drawing.Point(253, 0)
        Me.LblKuponTerpakai.Name = "LblKuponTerpakai"
        Me.LblKuponTerpakai.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.LblKuponTerpakai.Size = New System.Drawing.Size(0, 39)
        Me.LblKuponTerpakai.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.OldLace
        Me.Panel6.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 150)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(626, 50)
        Me.Panel6.TabIndex = 3
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.FloralWhite
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LblTypeOfWash, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(626, 50)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Label10.Size = New System.Drawing.Size(156, 39)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Type of wash"
        '
        'LblTypeOfWash
        '
        Me.LblTypeOfWash.AutoSize = True
        Me.LblTypeOfWash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTypeOfWash.Location = New System.Drawing.Point(253, 0)
        Me.LblTypeOfWash.Name = "LblTypeOfWash"
        Me.LblTypeOfWash.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.LblTypeOfWash.Size = New System.Drawing.Size(0, 39)
        Me.LblTypeOfWash.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.OldLace
        Me.Panel5.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 100)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(626, 50)
        Me.Panel5.TabIndex = 3
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LblWeight, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(626, 50)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(88, 39)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Weight"
        '
        'LblWeight
        '
        Me.LblWeight.AutoSize = True
        Me.LblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWeight.Location = New System.Drawing.Point(253, 0)
        Me.LblWeight.Name = "LblWeight"
        Me.LblWeight.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.LblWeight.Size = New System.Drawing.Size(0, 39)
        Me.LblWeight.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.OldLace
        Me.Panel4.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 50)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(626, 50)
        Me.Panel4.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FloralWhite
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LblID_User, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(626, 50)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(146, 39)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "ID Costumer"
        '
        'LblID_User
        '
        Me.LblID_User.AutoSize = True
        Me.LblID_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID_User.Location = New System.Drawing.Point(253, 0)
        Me.LblID_User.Name = "LblID_User"
        Me.LblID_User.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.LblID_User.Size = New System.Drawing.Size(0, 39)
        Me.LblID_User.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel2.Controls.Add(Me.LblIDTransaction)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.LblDate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(626, 50)
        Me.Panel2.TabIndex = 1
        '
        'LblIDTransaction
        '
        Me.LblIDTransaction.AutoSize = True
        Me.LblIDTransaction.Dock = System.Windows.Forms.DockStyle.Left
        Me.LblIDTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIDTransaction.Location = New System.Drawing.Point(186, 0)
        Me.LblIDTransaction.Name = "LblIDTransaction"
        Me.LblIDTransaction.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.LblIDTransaction.Size = New System.Drawing.Size(0, 39)
        Me.LblIDTransaction.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(186, 39)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = " ID Transaction :"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblDate.Location = New System.Drawing.Point(626, 0)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Padding = New System.Windows.Forms.Padding(0, 10, 0, 5)
        Me.LblDate.Size = New System.Drawing.Size(0, 44)
        Me.LblDate.TabIndex = 0
        '
        'CBTipe
        '
        Me.CBTipe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CBTipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTipe.FormattingEnabled = True
        Me.CBTipe.Location = New System.Drawing.Point(469, 133)
        Me.CBTipe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBTipe.Name = "CBTipe"
        Me.CBTipe.Size = New System.Drawing.Size(162, 40)
        Me.CBTipe.TabIndex = 27
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.BtnSave.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSave.Location = New System.Drawing.Point(1000, 470)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(106, 106)
        Me.BtnSave.TabIndex = 28
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FormTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1306, 912)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.CBTipe)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LVDataTransaction)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBSearch)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormTransaction"
        Me.Text = "Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LVDataTransaction As ListView
    Friend WithEvents id_transaksi As ColumnHeader
    Friend WithEvents tanggal_transaksi As ColumnHeader
    Friend WithEvents id_pengguna As ColumnHeader
    Friend WithEvents berat_pakaian As ColumnHeader
    Friend WithEvents jenis_cuci As ColumnHeader
    Friend WithEvents pakai_kupon As ColumnHeader
    Friend WithEvents harga_transaksi As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TBSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblDate As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents LblIDTransaction As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LblKuponTerpakai As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LblTypeOfWash As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LblWeight As Label
    Friend WithEvents LblID_User As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblTotalHarga As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents CBTipe As ComboBox
    Friend WithEvents CBStatus As ComboBox
    Friend WithEvents status_transaksi As ColumnHeader
    Friend WithEvents BtnSave As FontAwesome.Sharp.IconButton
End Class
