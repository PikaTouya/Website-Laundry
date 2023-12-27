Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class FormUtama
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
        PanelMenu.Visible = False
        btnHistory.Visible = False
        btnCoupon.Visible = False
        btnTransaction.Visible = False
        btnMaster.Visible = False
        btnUtility.Visible = False
        btnlogout.Visible = False
        lblNamaUser.Visible = False
        IconUser.Visible = False
        lblTanggal.Text = Today
        btnOrder.Visible = False

        'memunculkna jam pada status
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblwaktu.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Public Sub New()

        ' This call is required by the designer.'
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
        'mengosongkan text Form dan control form'
        Me.Text = String.Empty
        Me.ControlBox = False
    End Sub

    Sub ClearButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub


    'back to home
    Sub Reset()
        ClearButton()
        leftBorderBtn.Visible = False
        iconChildForm.IconChar = IconChar.Landmark
        iconChildForm.IconColor = Color.Gainsboro
        lblChildForm.Text = "Bobok Laundry"
    End Sub

    Private Sub ImgHome_Click(sender As Object, e As EventArgs) Handles ImgHome.Click, PictureBox1.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelContent.Controls.Add(childForm)
        PanelContent.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblChildForm.Text = childForm.Text
    End Sub


    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            ClearButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'child Form icon'
            iconChildForm.IconChar = currentBtn.IconChar
            IconChildForm.IconColor = customColor
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New FormLogin)
        Reset()
    End Sub


    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New FormHistory)
    End Sub

    Private Sub btnCoupon_Click(sender As Object, e As EventArgs) Handles btnCoupon.Click
        ActivateButton(sender, RGBColors.color2)
        OpenChildForm(New FormCoupon)
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        ActivateButton(sender, RGBColors.color3)
        OpenChildForm(New FormTransaction)
    End Sub

    Private Sub btnMaster_Click(sender As Object, e As EventArgs) Handles btnMaster.Click
        ActivateButton(sender, RGBColors.color4)
        OpenChildForm(New FormMaster)
    End Sub

    Private Sub btnUtility_Click(sender As Object, e As EventArgs) Handles btnUtility.Click
        ActivateButton(sender, RGBColors.color5)
        OpenChildForm(New FormUtility)
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If currentChildForm IsNot Nothing Then
                currentChildForm.Close()
                Reset()
                PanelMenu.Visible = False
                btnlogin.Visible = True
                lblNamaUser.Visible = False
                IconUser.Visible = False
                btnOrder.Visible = False
            End If
        End If
    End Sub


















    'codingan agar PanelNav dapat didrag
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelNav_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelNav.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    'tombol min, max, close
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    'memanggil warna 
    Public Structure RGBColors
        Public Shared color1 As Color = Color.FromArgb(172, 126, 241)
        Public Shared color2 As Color = Color.FromArgb(249, 118, 176)
        Public Shared color3 As Color = Color.FromArgb(253, 138, 114)
        Public Shared color4 As Color = Color.FromArgb(95, 77, 221)
        Public Shared color5 As Color = Color.FromArgb(249, 88, 155)
        Public Shared color6 As Color = Color.FromArgb(24, 161, 251)
    End Structure


End Class
