<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMaster
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
        Me.BtnListOfUser = New FontAwesome.Sharp.IconButton()
        Me.BtnPriceList = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("News706 BT", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(253, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(887, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What data do you want to change?"
        '
        'BtnListOfUser
        '
        Me.BtnListOfUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnListOfUser.Font = New System.Drawing.Font("Swis721 Hv BT", 14.0!)
        Me.BtnListOfUser.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnListOfUser.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.BtnListOfUser.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnListOfUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnListOfUser.IconSize = 80
        Me.BtnListOfUser.Location = New System.Drawing.Point(336, 437)
        Me.BtnListOfUser.Name = "BtnListOfUser"
        Me.BtnListOfUser.Size = New System.Drawing.Size(250, 125)
        Me.BtnListOfUser.TabIndex = 2
        Me.BtnListOfUser.Text = "List Of User"
        Me.BtnListOfUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnListOfUser.UseVisualStyleBackColor = True
        '
        'BtnPriceList
        '
        Me.BtnPriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPriceList.Font = New System.Drawing.Font("Swis721 Hv BT", 14.0!)
        Me.BtnPriceList.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnPriceList.IconChar = FontAwesome.Sharp.IconChar.Tag
        Me.BtnPriceList.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnPriceList.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnPriceList.IconSize = 80
        Me.BtnPriceList.Location = New System.Drawing.Point(732, 437)
        Me.BtnPriceList.Name = "BtnPriceList"
        Me.BtnPriceList.Size = New System.Drawing.Size(250, 125)
        Me.BtnPriceList.TabIndex = 2
        Me.BtnPriceList.Text = "Price List"
        Me.BtnPriceList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPriceList.UseVisualStyleBackColor = True
        '
        'FormMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1306, 913)
        Me.Controls.Add(Me.BtnPriceList)
        Me.Controls.Add(Me.BtnListOfUser)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormMaster"
        Me.Text = "Master"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnListOfUser As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnPriceList As FontAwesome.Sharp.IconButton
End Class
