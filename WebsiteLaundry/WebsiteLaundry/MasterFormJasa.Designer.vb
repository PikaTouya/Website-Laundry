<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterFormJasa
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
        Me.IconBack = New FontAwesome.Sharp.IconButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbharganormal = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tbhargaquick = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.tbharganormalsetrika = New System.Windows.Forms.TextBox()
        Me.tbhargaquicksetrika = New System.Windows.Forms.TextBox()
        Me.SavePrice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.IconBack.TabIndex = 17
        Me.IconBack.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("News706 BT", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(380, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(544, 67)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Laundry Price List"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(165, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 46)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Normal Wash           "
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(162, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(442, 63)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Price per kilogram"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(165, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(461, 46)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Normal Wash + Ironing "
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(165, 499)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(258, 46)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Quick Wash "
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(165, 571)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(434, 46)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Quick Wash + Ironing "
        '
        'tbharganormal
        '
        Me.tbharganormal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbharganormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbharganormal.Location = New System.Drawing.Point(715, 354)
        Me.tbharganormal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbharganormal.Name = "tbharganormal"
        Me.tbharganormal.Size = New System.Drawing.Size(411, 52)
        Me.tbharganormal.TabIndex = 20
        Me.tbharganormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(715, 428)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(411, 52)
        Me.TextBox2.TabIndex = 20
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbhargaquick
        '
        Me.tbhargaquick.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbhargaquick.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbhargaquick.Location = New System.Drawing.Point(715, 501)
        Me.tbhargaquick.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbhargaquick.Name = "tbhargaquick"
        Me.tbhargaquick.Size = New System.Drawing.Size(411, 52)
        Me.tbhargaquick.TabIndex = 20
        Me.tbhargaquick.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(715, 574)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(411, 52)
        Me.TextBox4.TabIndex = 20
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbharganormalsetrika
        '
        Me.tbharganormalsetrika.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbharganormalsetrika.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbharganormalsetrika.Location = New System.Drawing.Point(715, 428)
        Me.tbharganormalsetrika.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbharganormalsetrika.Name = "tbharganormalsetrika"
        Me.tbharganormalsetrika.Size = New System.Drawing.Size(411, 52)
        Me.tbharganormalsetrika.TabIndex = 20
        Me.tbharganormalsetrika.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbhargaquicksetrika
        '
        Me.tbhargaquicksetrika.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbhargaquicksetrika.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbhargaquicksetrika.Location = New System.Drawing.Point(715, 574)
        Me.tbhargaquicksetrika.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbhargaquicksetrika.Name = "tbhargaquicksetrika"
        Me.tbhargaquicksetrika.Size = New System.Drawing.Size(411, 52)
        Me.tbhargaquicksetrika.TabIndex = 20
        Me.tbhargaquicksetrika.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SavePrice
        '
        Me.SavePrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SavePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SavePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavePrice.ForeColor = System.Drawing.Color.Gainsboro
        Me.SavePrice.Location = New System.Drawing.Point(976, 799)
        Me.SavePrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SavePrice.Name = "SavePrice"
        Me.SavePrice.Size = New System.Drawing.Size(300, 80)
        Me.SavePrice.TabIndex = 21
        Me.SavePrice.Text = "Save Data "
        Me.SavePrice.UseVisualStyleBackColor = True
        '
        'MasterFormJasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1306, 913)
        Me.Controls.Add(Me.SavePrice)
        Me.Controls.Add(Me.tbhargaquicksetrika)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.tbharganormalsetrika)
        Me.Controls.Add(Me.tbhargaquick)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.tbharganormal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IconBack)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MasterFormJasa"
        Me.Text = "Price List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconBack As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbharganormal As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents tbhargaquick As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents tbharganormalsetrika As TextBox
    Friend WithEvents tbhargaquicksetrika As TextBox
    Friend WithEvents SavePrice As Button
End Class
