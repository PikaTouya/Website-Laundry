﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtama))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnUtility = New FontAwesome.Sharp.IconButton()
        Me.btnMaster = New FontAwesome.Sharp.IconButton()
        Me.btnTransaction = New FontAwesome.Sharp.IconButton()
        Me.btnlogout = New FontAwesome.Sharp.IconButton()
        Me.btnCoupon = New FontAwesome.Sharp.IconButton()
        Me.btnHistory = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImgHome = New System.Windows.Forms.PictureBox()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.PanelNav = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblChildForm = New System.Windows.Forms.Label()
        Me.IconChildForm = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconUser = New FontAwesome.Sharp.IconPictureBox()
        Me.btnlogin = New FontAwesome.Sharp.IconButton()
        Me.lblNamaUser = New System.Windows.Forms.Label()
        Me.btnMaximize = New FontAwesome.Sharp.IconButton()
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.lblwaktu = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IconPictureBox10 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox8 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox11 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox7 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox9 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox6 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ImgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNav.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.IconChildForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.IconUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContent.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnUtility)
        Me.PanelMenu.Controls.Add(Me.btnMaster)
        Me.PanelMenu.Controls.Add(Me.btnTransaction)
        Me.PanelMenu.Controls.Add(Me.btnlogout)
        Me.PanelMenu.Controls.Add(Me.btnCoupon)
        Me.PanelMenu.Controls.Add(Me.btnHistory)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(250, 1044)
        Me.PanelMenu.TabIndex = 0
        '
        'btnUtility
        '
        Me.btnUtility.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUtility.FlatAppearance.BorderSize = 0
        Me.btnUtility.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUtility.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUtility.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUtility.IconChar = FontAwesome.Sharp.IconChar.Keycdn
        Me.btnUtility.IconColor = System.Drawing.Color.Gainsboro
        Me.btnUtility.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUtility.IconSize = 50
        Me.btnUtility.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUtility.Location = New System.Drawing.Point(0, 380)
        Me.btnUtility.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUtility.Name = "btnUtility"
        Me.btnUtility.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnUtility.Size = New System.Drawing.Size(250, 60)
        Me.btnUtility.TabIndex = 7
        Me.btnUtility.Text = "Utility"
        Me.btnUtility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUtility.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUtility.UseVisualStyleBackColor = True
        '
        'btnMaster
        '
        Me.btnMaster.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMaster.FlatAppearance.BorderSize = 0
        Me.btnMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaster.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMaster.IconChar = FontAwesome.Sharp.IconChar.FileEdit
        Me.btnMaster.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMaster.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaster.IconSize = 45
        Me.btnMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMaster.Location = New System.Drawing.Point(0, 320)
        Me.btnMaster.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMaster.Name = "btnMaster"
        Me.btnMaster.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnMaster.Size = New System.Drawing.Size(250, 60)
        Me.btnMaster.TabIndex = 6
        Me.btnMaster.Text = "Master"
        Me.btnMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaster.UseVisualStyleBackColor = True
        '
        'btnTransaction
        '
        Me.btnTransaction.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransaction.FlatAppearance.BorderSize = 0
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnTransaction.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer
        Me.btnTransaction.IconColor = System.Drawing.Color.Gainsboro
        Me.btnTransaction.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTransaction.IconSize = 45
        Me.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaction.Location = New System.Drawing.Point(0, 260)
        Me.btnTransaction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnTransaction.Size = New System.Drawing.Size(250, 60)
        Me.btnTransaction.TabIndex = 5
        Me.btnTransaction.Text = "Transaction"
        Me.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTransaction.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnlogout.FlatAppearance.BorderSize = 0
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnlogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnlogout.IconColor = System.Drawing.Color.Gainsboro
        Me.btnlogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnlogout.IconSize = 40
        Me.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogout.Location = New System.Drawing.Point(0, 984)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnlogout.Size = New System.Drawing.Size(250, 60)
        Me.btnlogout.TabIndex = 4
        Me.btnlogout.Text = "Log Out"
        Me.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'btnCoupon
        '
        Me.btnCoupon.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCoupon.FlatAppearance.BorderSize = 0
        Me.btnCoupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCoupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCoupon.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCoupon.IconChar = FontAwesome.Sharp.IconChar.Ticket
        Me.btnCoupon.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCoupon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCoupon.IconSize = 45
        Me.btnCoupon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCoupon.Location = New System.Drawing.Point(0, 200)
        Me.btnCoupon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCoupon.Name = "btnCoupon"
        Me.btnCoupon.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnCoupon.Size = New System.Drawing.Size(250, 60)
        Me.btnCoupon.TabIndex = 3
        Me.btnCoupon.Text = "Coupon"
        Me.btnCoupon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCoupon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCoupon.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHistory.FlatAppearance.BorderSize = 0
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnHistory.IconChar = FontAwesome.Sharp.IconChar.Receipt
        Me.btnHistory.IconColor = System.Drawing.Color.Gainsboro
        Me.btnHistory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHistory.IconSize = 45
        Me.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistory.Location = New System.Drawing.Point(0, 140)
        Me.btnHistory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnHistory.Size = New System.Drawing.Size(250, 60)
        Me.btnHistory.TabIndex = 2
        Me.btnHistory.Text = "History"
        Me.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ImgHome)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 140)
        Me.Panel1.TabIndex = 0
        '
        'ImgHome
        '
        Me.ImgHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ImgHome.Image = CType(resources.GetObject("ImgHome.Image"), System.Drawing.Image)
        Me.ImgHome.Location = New System.Drawing.Point(20, 8)
        Me.ImgHome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ImgHome.Name = "ImgHome"
        Me.ImgHome.Size = New System.Drawing.Size(196, 128)
        Me.ImgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgHome.TabIndex = 0
        Me.ImgHome.TabStop = False
        '
        'btnOrder
        '
        Me.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOrder.Font = New System.Drawing.Font("Showcard Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.ForeColor = System.Drawing.Color.Black
        Me.btnOrder.Location = New System.Drawing.Point(485, 632)
        Me.btnOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(297, 122)
        Me.btnOrder.TabIndex = 3
        Me.btnOrder.Text = "Start Laundering!"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'PanelNav
        '
        Me.PanelNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelNav.Controls.Add(Me.Panel4)
        Me.PanelNav.Controls.Add(Me.Panel2)
        Me.PanelNav.Controls.Add(Me.btnMaximize)
        Me.PanelNav.Controls.Add(Me.btnMinimize)
        Me.PanelNav.Controls.Add(Me.btnClose)
        Me.PanelNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelNav.Location = New System.Drawing.Point(250, 0)
        Me.PanelNav.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelNav.Name = "PanelNav"
        Me.PanelNav.Size = New System.Drawing.Size(1328, 75)
        Me.PanelNav.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblChildForm)
        Me.Panel4.Controls.Add(Me.IconChildForm)
        Me.Panel4.Location = New System.Drawing.Point(0, 9)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(278, 55)
        Me.Panel4.TabIndex = 11
        '
        'lblChildForm
        '
        Me.lblChildForm.AutoSize = True
        Me.lblChildForm.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblChildForm.Font = New System.Drawing.Font("Brush Script MT", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChildForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblChildForm.Location = New System.Drawing.Point(65, 0)
        Me.lblChildForm.Name = "lblChildForm"
        Me.lblChildForm.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.lblChildForm.Size = New System.Drawing.Size(199, 54)
        Me.lblChildForm.TabIndex = 7
        Me.lblChildForm.Text = "Bobok Laundry"
        '
        'IconChildForm
        '
        Me.IconChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconChildForm.Dock = System.Windows.Forms.DockStyle.Left
        Me.IconChildForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconChildForm.IconChar = FontAwesome.Sharp.IconChar.FortAwesomeAlt
        Me.IconChildForm.IconColor = System.Drawing.Color.Gainsboro
        Me.IconChildForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconChildForm.IconSize = 55
        Me.IconChildForm.Location = New System.Drawing.Point(0, 0)
        Me.IconChildForm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconChildForm.Name = "IconChildForm"
        Me.IconChildForm.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.IconChildForm.Size = New System.Drawing.Size(65, 55)
        Me.IconChildForm.TabIndex = 6
        Me.IconChildForm.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.IconUser)
        Me.Panel2.Controls.Add(Me.btnlogin)
        Me.Panel2.Controls.Add(Me.lblNamaUser)
        Me.Panel2.Location = New System.Drawing.Point(1136, 25)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(188, 50)
        Me.Panel2.TabIndex = 10
        '
        'IconUser
        '
        Me.IconUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.IconUser.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconUser.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconUser.IconColor = System.Drawing.Color.Gainsboro
        Me.IconUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconUser.IconSize = 50
        Me.IconUser.Location = New System.Drawing.Point(0, 0)
        Me.IconUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconUser.Name = "IconUser"
        Me.IconUser.Size = New System.Drawing.Size(50, 50)
        Me.IconUser.TabIndex = 8
        Me.IconUser.TabStop = False
        '
        'btnlogin
        '
        Me.btnlogin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnlogin.FlatAppearance.BorderSize = 0
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnlogin.IconChar = FontAwesome.Sharp.IconChar.RightToBracket
        Me.btnlogin.IconColor = System.Drawing.Color.Gainsboro
        Me.btnlogin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnlogin.IconSize = 40
        Me.btnlogin.Location = New System.Drawing.Point(50, 0)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.btnlogin.Size = New System.Drawing.Size(138, 50)
        Me.btnlogin.TabIndex = 5
        Me.btnlogin.Text = "Log In"
        Me.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'lblNamaUser
        '
        Me.lblNamaUser.AutoSize = True
        Me.lblNamaUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblNamaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaUser.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblNamaUser.Location = New System.Drawing.Point(188, 0)
        Me.lblNamaUser.Name = "lblNamaUser"
        Me.lblNamaUser.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.lblNamaUser.Size = New System.Drawing.Size(0, 50)
        Me.lblNamaUser.TabIndex = 7
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Square
        Me.btnMaximize.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaximize.IconSize = 23
        Me.btnMaximize.Location = New System.Drawing.Point(1269, 0)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(25, 25)
        Me.btnMaximize.TabIndex = 9
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.btnMinimize.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimize.IconSize = 25
        Me.btnMinimize.Location = New System.Drawing.Point(1238, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimize.TabIndex = 8
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnClose.IconColor = System.Drawing.Color.Gainsboro
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.IconSize = 25
        Me.btnClose.Location = New System.Drawing.Point(1299, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PanelContent
        '
        Me.PanelContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.PanelContent.Controls.Add(Me.Panel3)
        Me.PanelContent.Controls.Add(Me.PictureBox1)
        Me.PanelContent.Controls.Add(Me.btnOrder)
        Me.PanelContent.Controls.Add(Me.IconPictureBox10)
        Me.PanelContent.Controls.Add(Me.IconPictureBox8)
        Me.PanelContent.Controls.Add(Me.IconPictureBox3)
        Me.PanelContent.Controls.Add(Me.Label1)
        Me.PanelContent.Controls.Add(Me.IconPictureBox4)
        Me.PanelContent.Controls.Add(Me.IconPictureBox2)
        Me.PanelContent.Controls.Add(Me.IconPictureBox11)
        Me.PanelContent.Controls.Add(Me.IconPictureBox7)
        Me.PanelContent.Controls.Add(Me.IconPictureBox9)
        Me.PanelContent.Controls.Add(Me.IconPictureBox6)
        Me.PanelContent.Controls.Add(Me.IconPictureBox5)
        Me.PanelContent.Controls.Add(Me.Label3)
        Me.PanelContent.Controls.Add(Me.Label2)
        Me.PanelContent.Controls.Add(Me.IconPictureBox1)
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(250, 75)
        Me.PanelContent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(1328, 969)
        Me.PanelContent.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblTanggal)
        Me.Panel3.Controls.Add(Me.lblwaktu)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 939)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1328, 30)
        Me.Panel3.TabIndex = 2
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTanggal.Location = New System.Drawing.Point(1219, 0)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.lblTanggal.Size = New System.Drawing.Size(53, 35)
        Me.lblTanggal.TabIndex = 1
        Me.lblTanggal.Text = "Date"
        '
        'lblwaktu
        '
        Me.lblwaktu.AutoSize = True
        Me.lblwaktu.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblwaktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwaktu.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblwaktu.Location = New System.Drawing.Point(1272, 0)
        Me.lblwaktu.Name = "lblwaktu"
        Me.lblwaktu.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.lblwaktu.Size = New System.Drawing.Size(56, 35)
        Me.lblwaktu.TabIndex = 0
        Me.lblwaktu.Text = "Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(572, 27)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Our swift cleanliness ensures your clothes shine in an instant."
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(474, 339)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 182)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'IconPictureBox10
        '
        Me.IconPictureBox10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconPictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox10.ForeColor = System.Drawing.Color.LightGray
        Me.IconPictureBox10.IconChar = FontAwesome.Sharp.IconChar.Odysee
        Me.IconPictureBox10.IconColor = System.Drawing.Color.LightGray
        Me.IconPictureBox10.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox10.IconSize = 274
        Me.IconPictureBox10.Location = New System.Drawing.Point(285, -21)
        Me.IconPictureBox10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconPictureBox10.Name = "IconPictureBox10"
        Me.IconPictureBox10.Size = New System.Drawing.Size(274, 274)
        Me.IconPictureBox10.TabIndex = 4
        Me.IconPictureBox10.TabStop = False
        '
        'IconPictureBox8
        '
        Me.IconPictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconPictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox8.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.Cloud
        Me.IconPictureBox8.IconColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox8.IconSize = 274
        Me.IconPictureBox8.Location = New System.Drawing.Point(840, 645)
        Me.IconPictureBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconPictureBox8.Name = "IconPictureBox8"
        Me.IconPictureBox8.Size = New System.Drawing.Size(274, 276)
        Me.IconPictureBox8.TabIndex = 4
        Me.IconPictureBox8.TabStop = False
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconPictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Cloud
        Me.IconPictureBox3.IconColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.IconSize = 274
        Me.IconPictureBox3.Location = New System.Drawing.Point(1076, 292)
        Me.IconPictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(274, 276)
        Me.IconPictureBox3.TabIndex = 4
        Me.IconPictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(356, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(559, 108)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome to"
        '
        'IconPictureBox4
        '
        Me.IconPictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconPictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox4.ForeColor = System.Drawing.Color.LightGray
        Me.IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Cloud
        Me.IconPictureBox4.IconColor = System.Drawing.Color.LightGray
        Me.IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox4.IconSize = 369
        Me.IconPictureBox4.Location = New System.Drawing.Point(925, -64)
        Me.IconPictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconPictureBox4.Name = "IconPictureBox4"
        Me.IconPictureBox4.Size = New System.Drawing.Size(369, 369)
        Me.IconPictureBox4.TabIndex = 4
        Me.IconPictureBox4.TabStop = False
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.LightGray
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Cloud
        Me.IconPictureBox2.IconColor = System.Drawing.Color.LightGray
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 50
        Me.IconPictureBox2.Location = New System.Drawing.Point(893, 402)
        Me.IconPictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.IconPictureBox2.TabIndex = 4
        Me.IconPictureBox2.TabStop = False
        '
        'IconPictureBox11
        '
        Me.IconPictureBox11.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.IconPictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox11.ForeColor = System.Drawing.Color.Ivory
        Me.IconPictureBox11.IconChar = FontAwesome.Sharp.IconChar.OptinMonster
        Me.IconPictureBox11.IconColor = System.Drawing.Color.Ivory
        Me.IconPictureBox11.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox11.IconSize = 278
        Me.IconPictureBox11.Location = New System.Drawing.Point(534, 721)
        Me.IconPictureBox11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconPictureBox11.Name = "IconPictureBox11"
        Me.IconPictureBox11.Size = New System.Drawing.Size(289, 278)
        Me.IconPictureBox11.TabIndex = 4
        Me.IconPictureBox11.TabStop = False
        '
        'IconPictureBox7
        '
        Me.IconPictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconPictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox7.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Cloud
        Me.IconPictureBox7.IconColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox7.IconSize = 150
        Me.IconPictureBox7.Location = New System.Drawing.Point(248, 816)
        Me.IconPictureBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconPictureBox7.Name = "IconPictureBox7"
        Me.IconPictureBox7.Size = New System.Drawing.Size(150, 150)
        Me.IconPictureBox7.TabIndex = 4
        Me.IconPictureBox7.TabStop = False
        '
        'IconPictureBox9
        '
        Me.IconPictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconPictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox9.ForeColor = System.Drawing.Color.LightGray
        Me.IconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.Cloud
        Me.IconPictureBox9.IconColor = System.Drawing.Color.LightGray
        Me.IconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox9.IconSize = 200
        Me.IconPictureBox9.Location = New System.Drawing.Point(623, 2)
        Me.IconPictureBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconPictureBox9.Name = "IconPictureBox9"
        Me.IconPictureBox9.Size = New System.Drawing.Size(200, 200)
        Me.IconPictureBox9.TabIndex = 4
        Me.IconPictureBox9.TabStop = False
        '
        'IconPictureBox6
        '
        Me.IconPictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconPictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox6.ForeColor = System.Drawing.Color.LightGray
        Me.IconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Cloud
        Me.IconPictureBox6.IconColor = System.Drawing.Color.LightGray
        Me.IconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox6.IconSize = 150
        Me.IconPictureBox6.Location = New System.Drawing.Point(208, 392)
        Me.IconPictureBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconPictureBox6.Name = "IconPictureBox6"
        Me.IconPictureBox6.Size = New System.Drawing.Size(150, 150)
        Me.IconPictureBox6.TabIndex = 4
        Me.IconPictureBox6.TabStop = False
        '
        'IconPictureBox5
        '
        Me.IconPictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconPictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox5.ForeColor = System.Drawing.Color.LightGray
        Me.IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Cloud
        Me.IconPictureBox5.IconColor = System.Drawing.Color.LightGray
        Me.IconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox5.IconSize = 236
        Me.IconPictureBox5.Location = New System.Drawing.Point(-15, 632)
        Me.IconPictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconPictureBox5.Name = "IconPictureBox5"
        Me.IconPictureBox5.Size = New System.Drawing.Size(236, 239)
        Me.IconPictureBox5.TabIndex = 4
        Me.IconPictureBox5.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(458, 580)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(358, 33)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "We make your clothes shine"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Brush Script MT", 28.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(483, 511)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(309, 69)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bobok Laundry"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Cloud
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 369
        Me.IconPictureBox1.Location = New System.Drawing.Point(-32, 65)
        Me.IconPictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(369, 369)
        Me.IconPictureBox1.TabIndex = 4
        Me.IconPictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1578, 1044)
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.PanelNav)
        Me.Controls.Add(Me.PanelMenu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(1200, 787)
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.ImgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNav.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.IconChildForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IconUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContent.ResumeLayout(False)
        Me.PanelContent.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelNav As Panel
    Friend WithEvents PanelContent As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImgHome As PictureBox
    Friend WithEvents btnTransaction As FontAwesome.Sharp.IconButton
    Friend WithEvents btnlogout As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCoupon As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHistory As FontAwesome.Sharp.IconButton
    Friend WithEvents lblChildForm As Label
    Friend WithEvents btnMaximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUtility As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaster As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnlogin As FontAwesome.Sharp.IconButton
    Friend WithEvents lblNamaUser As Label
    Friend WithEvents IconUser As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconChildForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblwaktu As Label
    Friend WithEvents btnOrder As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconPictureBox8 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox7 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox6 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox9 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox10 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox11 As FontAwesome.Sharp.IconPictureBox
End Class
