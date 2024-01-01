<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterFormPengguna
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
        Me.TBSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LVData = New System.Windows.Forms.ListView()
        Me.id_pengguna = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nama_pengguna = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.level_pengguna = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nomortelepon_pengguna = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CBLevel1 = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.IconBack = New FontAwesome.Sharp.IconButton()
        Me.TBUserID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBPass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBUsername = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cblevel2 = New System.Windows.Forms.ComboBox()
        Me.ClearCbLevel2 = New FontAwesome.Sharp.IconButton()
        Me.ClearCbLevel1 = New FontAwesome.Sharp.IconButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBPhone = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TBSearch
        '
        Me.TBSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBSearch.BackColor = System.Drawing.SystemColors.Window
        Me.TBSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSearch.ForeColor = System.Drawing.Color.Black
        Me.TBSearch.Location = New System.Drawing.Point(142, 221)
        Me.TBSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBSearch.Name = "TBSearch"
        Me.TBSearch.Size = New System.Drawing.Size(335, 35)
        Me.TBSearch.TabIndex = 1
        Me.TBSearch.WordWrap = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(790, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "UserID :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(35, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Search :"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAdd.Location = New System.Drawing.Point(795, 740)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(142, 44)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("News706 BT", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(438, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(498, 67)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Daftar Pengguna"
        '
        'LVData
        '
        Me.LVData.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LVData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_pengguna, Me.nama_pengguna, Me.level_pengguna, Me.nomortelepon_pengguna})
        Me.LVData.GridLines = True
        Me.LVData.HideSelection = False
        Me.LVData.Location = New System.Drawing.Point(40, 291)
        Me.LVData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LVData.Name = "LVData"
        Me.LVData.Size = New System.Drawing.Size(710, 492)
        Me.LVData.TabIndex = 14
        Me.LVData.UseCompatibleStateImageBehavior = False
        Me.LVData.View = System.Windows.Forms.View.Details
        '
        'id_pengguna
        '
        Me.id_pengguna.Text = "id_pengguna"
        Me.id_pengguna.Width = 100
        '
        'nama_pengguna
        '
        Me.nama_pengguna.Text = "nama_pengguna"
        Me.nama_pengguna.Width = 133
        '
        'level_pengguna
        '
        Me.level_pengguna.Text = "level_pengguna"
        Me.level_pengguna.Width = 93
        '
        'nomortelepon_pengguna
        '
        Me.nomortelepon_pengguna.Text = "nomortelepon_pengguna"
        Me.nomortelepon_pengguna.Width = 173
        '
        'CBLevel1
        '
        Me.CBLevel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CBLevel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBLevel1.FormattingEnabled = True
        Me.CBLevel1.Location = New System.Drawing.Point(795, 584)
        Me.CBLevel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBLevel1.Name = "CBLevel1"
        Me.CBLevel1.Size = New System.Drawing.Size(446, 37)
        Me.CBLevel1.TabIndex = 7
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUpdate.Location = New System.Drawing.Point(961, 740)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(142, 44)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDelete.Location = New System.Drawing.Point(1127, 740)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(142, 44)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'IconBack
        '
        Me.IconBack.FlatAppearance.BorderSize = 0
        Me.IconBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBack.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft
        Me.IconBack.IconColor = System.Drawing.Color.Gainsboro
        Me.IconBack.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconBack.IconSize = 70
        Me.IconBack.Location = New System.Drawing.Point(12, 12)
        Me.IconBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconBack.Name = "IconBack"
        Me.IconBack.Size = New System.Drawing.Size(70, 70)
        Me.IconBack.TabIndex = 16
        Me.IconBack.UseVisualStyleBackColor = True
        '
        'TBUserID
        '
        Me.TBUserID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBUserID.BackColor = System.Drawing.SystemColors.Window
        Me.TBUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBUserID.ForeColor = System.Drawing.Color.Black
        Me.TBUserID.Location = New System.Drawing.Point(795, 325)
        Me.TBUserID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBUserID.Name = "TBUserID"
        Me.TBUserID.Size = New System.Drawing.Size(474, 35)
        Me.TBUserID.TabIndex = 4
        Me.TBUserID.WordWrap = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(790, 550)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Level :"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(790, 464)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Password :"
        '
        'TBPass
        '
        Me.TBPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBPass.BackColor = System.Drawing.SystemColors.Window
        Me.TBPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPass.ForeColor = System.Drawing.Color.Black
        Me.TBPass.Location = New System.Drawing.Point(795, 498)
        Me.TBPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBPass.Name = "TBPass"
        Me.TBPass.Size = New System.Drawing.Size(474, 35)
        Me.TBPass.TabIndex = 6
        Me.TBPass.WordWrap = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(790, 378)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Username :"
        '
        'TBUsername
        '
        Me.TBUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBUsername.BackColor = System.Drawing.SystemColors.Window
        Me.TBUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBUsername.ForeColor = System.Drawing.Color.Black
        Me.TBUsername.Location = New System.Drawing.Point(795, 411)
        Me.TBUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBUsername.Name = "TBUsername"
        Me.TBUsername.Size = New System.Drawing.Size(474, 35)
        Me.TBUsername.TabIndex = 5
        Me.TBUsername.WordWrap = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(483, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 29)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Level :"
        '
        'Cblevel2
        '
        Me.Cblevel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cblevel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cblevel2.FormattingEnabled = True
        Me.Cblevel2.Location = New System.Drawing.Point(572, 221)
        Me.Cblevel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cblevel2.Name = "Cblevel2"
        Me.Cblevel2.Size = New System.Drawing.Size(177, 37)
        Me.Cblevel2.TabIndex = 2
        '
        'ClearCbLevel2
        '
        Me.ClearCbLevel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ClearCbLevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClearCbLevel2.FlatAppearance.BorderSize = 0
        Me.ClearCbLevel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearCbLevel2.IconChar = FontAwesome.Sharp.IconChar.TimesSquare
        Me.ClearCbLevel2.IconColor = System.Drawing.SystemColors.Window
        Me.ClearCbLevel2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ClearCbLevel2.IconSize = 40
        Me.ClearCbLevel2.Location = New System.Drawing.Point(742, 216)
        Me.ClearCbLevel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearCbLevel2.Name = "ClearCbLevel2"
        Me.ClearCbLevel2.Size = New System.Drawing.Size(40, 40)
        Me.ClearCbLevel2.TabIndex = 17
        Me.ClearCbLevel2.UseVisualStyleBackColor = True
        '
        'ClearCbLevel1
        '
        Me.ClearCbLevel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ClearCbLevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClearCbLevel1.FlatAppearance.BorderSize = 0
        Me.ClearCbLevel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearCbLevel1.IconChar = FontAwesome.Sharp.IconChar.TimesSquare
        Me.ClearCbLevel1.IconColor = System.Drawing.SystemColors.Window
        Me.ClearCbLevel1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ClearCbLevel1.IconSize = 40
        Me.ClearCbLevel1.Location = New System.Drawing.Point(1236, 580)
        Me.ClearCbLevel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearCbLevel1.Name = "ClearCbLevel1"
        Me.ClearCbLevel1.Size = New System.Drawing.Size(38, 38)
        Me.ClearCbLevel1.TabIndex = 17
        Me.ClearCbLevel1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(790, 641)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 29)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Phone Number :"
        '
        'TBPhone
        '
        Me.TBPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBPhone.BackColor = System.Drawing.SystemColors.Window
        Me.TBPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPhone.ForeColor = System.Drawing.Color.Black
        Me.TBPhone.Location = New System.Drawing.Point(794, 675)
        Me.TBPhone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBPhone.Name = "TBPhone"
        Me.TBPhone.Size = New System.Drawing.Size(474, 35)
        Me.TBPhone.TabIndex = 8
        Me.TBPhone.WordWrap = False
        '
        'MasterFormPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1335, 812)
        Me.Controls.Add(Me.IconBack)
        Me.Controls.Add(Me.Cblevel2)
        Me.Controls.Add(Me.CBLevel1)
        Me.Controls.Add(Me.LVData)
        Me.Controls.Add(Me.TBUsername)
        Me.Controls.Add(Me.TBPhone)
        Me.Controls.Add(Me.TBPass)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBUserID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ClearCbLevel1)
        Me.Controls.Add(Me.ClearCbLevel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MasterFormPengguna"
        Me.Text = "MasterFormPengguna"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LVData As ListView
    Friend WithEvents id_pengguna As ColumnHeader
    Friend WithEvents nama_pengguna As ColumnHeader
    Friend WithEvents level_pengguna As ColumnHeader
    Friend WithEvents CBLevel1 As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents IconBack As FontAwesome.Sharp.IconButton
    Friend WithEvents TBUserID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBPass As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBUsername As TextBox
    Friend WithEvents Cblevel2 As ComboBox
    Protected WithEvents Label7 As Label
    Friend WithEvents ClearCbLevel2 As FontAwesome.Sharp.IconButton
    Friend WithEvents ClearCbLevel1 As FontAwesome.Sharp.IconButton
    Friend WithEvents nomortelepon_pengguna As ColumnHeader
    Friend WithEvents Label8 As Label
    Friend WithEvents TBPhone As TextBox
End Class
