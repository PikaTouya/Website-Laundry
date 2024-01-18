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
        Me.BtnSaveAndUpdate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LVData = New System.Windows.Forms.ListView()
        Me.id_pengguna = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nama_pengguna = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.level_pengguna = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nomortelepon_pengguna = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CBLevel1 = New System.Windows.Forms.ComboBox()
        Me.BtnClearAndDelete = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBPhone = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelUbahData = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblUbahData = New System.Windows.Forms.Label()
        Me.PanelLV = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnNew = New FontAwesome.Sharp.IconButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelUbahData.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelLV.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBSearch
        '
        Me.TBSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBSearch.BackColor = System.Drawing.SystemColors.Window
        Me.TBSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSearch.ForeColor = System.Drawing.Color.Black
        Me.TBSearch.Location = New System.Drawing.Point(248, 10)
        Me.TBSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBSearch.Name = "TBSearch"
        Me.TBSearch.Size = New System.Drawing.Size(81, 39)
        Me.TBSearch.TabIndex = 1
        Me.TBSearch.WordWrap = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(14, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "UserID :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Search by Username :"
        '
        'BtnSaveAndUpdate
        '
        Me.BtnSaveAndUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSaveAndUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveAndUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveAndUpdate.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnSaveAndUpdate.Location = New System.Drawing.Point(18, 615)
        Me.BtnSaveAndUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSaveAndUpdate.Name = "BtnSaveAndUpdate"
        Me.BtnSaveAndUpdate.Size = New System.Drawing.Size(142, 60)
        Me.BtnSaveAndUpdate.TabIndex = 9
        Me.BtnSaveAndUpdate.Text = "Save/Updt"
        Me.BtnSaveAndUpdate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("News706 BT", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(488, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(360, 67)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "List Of User"
        '
        'LVData
        '
        Me.LVData.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_pengguna, Me.nama_pengguna, Me.level_pengguna, Me.nomortelepon_pengguna})
        Me.LVData.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVData.FullRowSelect = True
        Me.LVData.GridLines = True
        Me.LVData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LVData.HideSelection = False
        Me.LVData.Location = New System.Drawing.Point(0, 91)
        Me.LVData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LVData.Name = "LVData"
        Me.LVData.Size = New System.Drawing.Size(732, 592)
        Me.LVData.TabIndex = 14
        Me.LVData.UseCompatibleStateImageBehavior = False
        Me.LVData.View = System.Windows.Forms.View.Details
        '
        'id_pengguna
        '
        Me.id_pengguna.Text = "ID User"
        Me.id_pengguna.Width = 170
        '
        'nama_pengguna
        '
        Me.nama_pengguna.Text = "Username"
        Me.nama_pengguna.Width = 170
        '
        'level_pengguna
        '
        Me.level_pengguna.Text = "User Level"
        Me.level_pengguna.Width = 165
        '
        'nomortelepon_pengguna
        '
        Me.nomortelepon_pengguna.Text = "Phone Number"
        Me.nomortelepon_pengguna.Width = 200
        '
        'CBLevel1
        '
        Me.CBLevel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CBLevel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBLevel1.FormattingEnabled = True
        Me.CBLevel1.Location = New System.Drawing.Point(0, 0)
        Me.CBLevel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBLevel1.Name = "CBLevel1"
        Me.CBLevel1.Size = New System.Drawing.Size(474, 40)
        Me.CBLevel1.TabIndex = 7
        '
        'BtnClearAndDelete
        '
        Me.BtnClearAndDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnClearAndDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClearAndDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearAndDelete.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnClearAndDelete.Location = New System.Drawing.Point(184, 615)
        Me.BtnClearAndDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClearAndDelete.Name = "BtnClearAndDelete"
        Me.BtnClearAndDelete.Size = New System.Drawing.Size(142, 60)
        Me.BtnClearAndDelete.TabIndex = 10
        Me.BtnClearAndDelete.Text = "Clear/dlt"
        Me.BtnClearAndDelete.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnCancel.Location = New System.Drawing.Point(350, 615)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(142, 60)
        Me.BtnCancel.TabIndex = 11
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
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
        Me.TBUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBUserID.ForeColor = System.Drawing.Color.Black
        Me.TBUserID.Location = New System.Drawing.Point(18, 162)
        Me.TBUserID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBUserID.Name = "TBUserID"
        Me.TBUserID.Size = New System.Drawing.Size(474, 39)
        Me.TBUserID.TabIndex = 4
        Me.TBUserID.WordWrap = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(14, 402)
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
        Me.Label5.Location = New System.Drawing.Point(14, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Password :"
        '
        'TBPass
        '
        Me.TBPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBPass.BackColor = System.Drawing.SystemColors.Window
        Me.TBPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPass.ForeColor = System.Drawing.Color.Black
        Me.TBPass.Location = New System.Drawing.Point(18, 345)
        Me.TBPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBPass.Name = "TBPass"
        Me.TBPass.Size = New System.Drawing.Size(474, 39)
        Me.TBPass.TabIndex = 6
        Me.TBPass.WordWrap = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(14, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Username :"
        '
        'TBUsername
        '
        Me.TBUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBUsername.BackColor = System.Drawing.SystemColors.Window
        Me.TBUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBUsername.ForeColor = System.Drawing.Color.Black
        Me.TBUsername.Location = New System.Drawing.Point(18, 252)
        Me.TBUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBUsername.Name = "TBUsername"
        Me.TBUsername.Size = New System.Drawing.Size(474, 39)
        Me.TBUsername.TabIndex = 5
        Me.TBUsername.WordWrap = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(-4, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 29)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Level :"
        '
        'Cblevel2
        '
        Me.Cblevel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cblevel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cblevel2.FormattingEnabled = True
        Me.Cblevel2.Location = New System.Drawing.Point(0, 0)
        Me.Cblevel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cblevel2.Name = "Cblevel2"
        Me.Cblevel2.Size = New System.Drawing.Size(108, 40)
        Me.Cblevel2.TabIndex = 2
        '
        'ClearCbLevel2
        '
        Me.ClearCbLevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClearCbLevel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.ClearCbLevel2.FlatAppearance.BorderSize = 0
        Me.ClearCbLevel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearCbLevel2.IconChar = FontAwesome.Sharp.IconChar.TimesSquare
        Me.ClearCbLevel2.IconColor = System.Drawing.SystemColors.Window
        Me.ClearCbLevel2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ClearCbLevel2.IconSize = 45
        Me.ClearCbLevel2.Location = New System.Drawing.Point(108, 0)
        Me.ClearCbLevel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearCbLevel2.Name = "ClearCbLevel2"
        Me.ClearCbLevel2.Padding = New System.Windows.Forms.Padding(0, 0, 4, 8)
        Me.ClearCbLevel2.Size = New System.Drawing.Size(40, 42)
        Me.ClearCbLevel2.TabIndex = 17
        Me.ClearCbLevel2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(14, 499)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 29)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Phone Number :"
        '
        'TBPhone
        '
        Me.TBPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBPhone.BackColor = System.Drawing.SystemColors.Window
        Me.TBPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPhone.ForeColor = System.Drawing.Color.Black
        Me.TBPhone.Location = New System.Drawing.Point(17, 532)
        Me.TBPhone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBPhone.Name = "TBPhone"
        Me.TBPhone.Size = New System.Drawing.Size(475, 39)
        Me.TBPhone.TabIndex = 8
        Me.TBPhone.WordWrap = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.Cblevel2)
        Me.Panel1.Controls.Add(Me.ClearCbLevel2)
        Me.Panel1.Location = New System.Drawing.Point(76, 8)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 42)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.CBLevel1)
        Me.Panel2.Location = New System.Drawing.Point(18, 448)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(474, 35)
        Me.Panel2.TabIndex = 19
        '
        'PanelUbahData
        '
        Me.PanelUbahData.Controls.Add(Me.Panel3)
        Me.PanelUbahData.Controls.Add(Me.TBUserID)
        Me.PanelUbahData.Controls.Add(Me.Panel2)
        Me.PanelUbahData.Controls.Add(Me.BtnSaveAndUpdate)
        Me.PanelUbahData.Controls.Add(Me.BtnClearAndDelete)
        Me.PanelUbahData.Controls.Add(Me.BtnCancel)
        Me.PanelUbahData.Controls.Add(Me.Label2)
        Me.PanelUbahData.Controls.Add(Me.TBUsername)
        Me.PanelUbahData.Controls.Add(Me.Label4)
        Me.PanelUbahData.Controls.Add(Me.TBPhone)
        Me.PanelUbahData.Controls.Add(Me.Label8)
        Me.PanelUbahData.Controls.Add(Me.TBPass)
        Me.PanelUbahData.Controls.Add(Me.Label5)
        Me.PanelUbahData.Controls.Add(Me.Label6)
        Me.PanelUbahData.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelUbahData.Location = New System.Drawing.Point(738, 0)
        Me.PanelUbahData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelUbahData.Name = "PanelUbahData"
        Me.PanelUbahData.Size = New System.Drawing.Size(516, 695)
        Me.PanelUbahData.TabIndex = 20
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LblUbahData)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(516, 90)
        Me.Panel3.TabIndex = 23
        '
        'LblUbahData
        '
        Me.LblUbahData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblUbahData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblUbahData.Font = New System.Drawing.Font("Showcard Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUbahData.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblUbahData.Location = New System.Drawing.Point(0, 0)
        Me.LblUbahData.Name = "LblUbahData"
        Me.LblUbahData.Size = New System.Drawing.Size(516, 90)
        Me.LblUbahData.TabIndex = 20
        Me.LblUbahData.Text = "Add New Account"
        Me.LblUbahData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelLV
        '
        Me.PanelLV.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelLV.Controls.Add(Me.LVData)
        Me.PanelLV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLV.Location = New System.Drawing.Point(0, 0)
        Me.PanelLV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelLV.Name = "PanelLV"
        Me.PanelLV.Size = New System.Drawing.Size(738, 695)
        Me.PanelLV.TabIndex = 21
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.BtnNew, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel8, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(724, 65)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'BtnNew
        '
        Me.BtnNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnNew.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.BtnNew.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnNew.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnNew.IconSize = 55
        Me.BtnNew.Location = New System.Drawing.Point(566, 3)
        Me.BtnNew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BtnNew.Size = New System.Drawing.Size(155, 59)
        Me.BtnNew.TabIndex = 23
        Me.BtnNew.Text = "New"
        Me.BtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TBSearch)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 2)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(332, 61)
        Me.Panel7.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel1)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(341, 2)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(219, 61)
        Me.Panel8.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.Controls.Add(Me.PanelLV)
        Me.Panel5.Controls.Add(Me.PanelUbahData)
        Me.Panel5.Location = New System.Drawing.Point(27, 172)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1254, 695)
        Me.Panel5.TabIndex = 22
        '
        'MasterFormPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1306, 912)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.IconBack)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MasterFormPengguna"
        Me.Text = "List Of User"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PanelUbahData.ResumeLayout(False)
        Me.PanelUbahData.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.PanelLV.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSaveAndUpdate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LVData As ListView
    Friend WithEvents id_pengguna As ColumnHeader
    Friend WithEvents nama_pengguna As ColumnHeader
    Friend WithEvents level_pengguna As ColumnHeader
    Friend WithEvents CBLevel1 As ComboBox
    Friend WithEvents BtnClearAndDelete As Button
    Friend WithEvents BtnCancel As Button
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
    Friend WithEvents nomortelepon_pengguna As ColumnHeader
    Friend WithEvents Label8 As Label
    Friend WithEvents TBPhone As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelUbahData As Panel
    Friend WithEvents PanelLV As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents BtnNew As FontAwesome.Sharp.IconButton
    Friend WithEvents LblUbahData As Label
    Friend WithEvents Panel3 As Panel
End Class
