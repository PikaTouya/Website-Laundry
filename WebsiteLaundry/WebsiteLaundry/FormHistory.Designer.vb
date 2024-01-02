<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHistory
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LVDataHistory = New System.Windows.Forms.ListView()
        Me.id_transaksi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tanggal_transaksi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id_pengguna = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.berat_pakaian = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.jenis_cuci = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pakai_kupon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.harga_transaksi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TBSearch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(47, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search by ID Tansaksi :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("News706 BT", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(514, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(321, 67)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "All History"
        '
        'LVDataHistory
        '
        Me.LVDataHistory.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.LVDataHistory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LVDataHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LVDataHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_transaksi, Me.tanggal_transaksi, Me.id_pengguna, Me.berat_pakaian, Me.jenis_cuci, Me.pakai_kupon, Me.harga_transaksi})
        Me.LVDataHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVDataHistory.FullRowSelect = True
        Me.LVDataHistory.GridLines = True
        Me.LVDataHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LVDataHistory.HideSelection = False
        Me.LVDataHistory.Location = New System.Drawing.Point(35, 257)
        Me.LVDataHistory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LVDataHistory.Name = "LVDataHistory"
        Me.LVDataHistory.Size = New System.Drawing.Size(1276, 574)
        Me.LVDataHistory.TabIndex = 15
        Me.LVDataHistory.UseCompatibleStateImageBehavior = False
        Me.LVDataHistory.View = System.Windows.Forms.View.Details
        '
        'id_transaksi
        '
        Me.id_transaksi.Text = "ID Transaksi"
        Me.id_transaksi.Width = 140
        '
        'tanggal_transaksi
        '
        Me.tanggal_transaksi.Text = "Tanggal Transaksi"
        Me.tanggal_transaksi.Width = 176
        '
        'id_pengguna
        '
        Me.id_pengguna.Text = "ID Customer"
        Me.id_pengguna.Width = 126
        '
        'berat_pakaian
        '
        Me.berat_pakaian.Text = "Berat Pakaian"
        Me.berat_pakaian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.berat_pakaian.Width = 136
        '
        'jenis_cuci
        '
        Me.jenis_cuci.Text = "Paket Cucian"
        Me.jenis_cuci.Width = 244
        '
        'pakai_kupon
        '
        Me.pakai_kupon.Text = "Kupon Terpakai"
        Me.pakai_kupon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.pakai_kupon.Width = 160
        '
        'harga_transaksi
        '
        Me.harga_transaksi.Text = "Total harga"
        Me.harga_transaksi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.harga_transaksi.Width = 116
        '
        'TBSearch
        '
        Me.TBSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBSearch.BackColor = System.Drawing.SystemColors.Window
        Me.TBSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSearch.ForeColor = System.Drawing.Color.Black
        Me.TBSearch.Location = New System.Drawing.Point(311, 196)
        Me.TBSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBSearch.Name = "TBSearch"
        Me.TBSearch.Size = New System.Drawing.Size(1000, 39)
        Me.TBSearch.TabIndex = 16
        Me.TBSearch.WordWrap = False
        '
        'FormHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1342, 859)
        Me.Controls.Add(Me.TBSearch)
        Me.Controls.Add(Me.LVDataHistory)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormHistory"
        Me.Text = "History"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LVDataHistory As ListView
    Friend WithEvents id_transaksi As ColumnHeader
    Friend WithEvents id_pengguna As ColumnHeader
    Friend WithEvents berat_pakaian As ColumnHeader
    Friend WithEvents tanggal_transaksi As ColumnHeader
    Friend WithEvents harga_transaksi As ColumnHeader
    Friend WithEvents jenis_cuci As ColumnHeader
    Friend WithEvents pakai_kupon As ColumnHeader
    Friend WithEvents TBSearch As TextBox
End Class
