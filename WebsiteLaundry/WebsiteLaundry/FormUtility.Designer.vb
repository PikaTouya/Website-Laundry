<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtility
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CurrentPass = New System.Windows.Forms.TextBox()
        Me.NewPass = New System.Windows.Forms.TextBox()
        Me.RetypeNewPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("News706 BT", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(345, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(617, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change Your Password"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(422, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Current Password"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(421, 404)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "New Password"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(421, 518)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(266, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Re-type New Password"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(425, 671)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(470, 80)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Change Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CurrentPass
        '
        Me.CurrentPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CurrentPass.BackColor = System.Drawing.SystemColors.Window
        Me.CurrentPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPass.ForeColor = System.Drawing.Color.Black
        Me.CurrentPass.Location = New System.Drawing.Point(426, 328)
        Me.CurrentPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CurrentPass.Name = "CurrentPass"
        Me.CurrentPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CurrentPass.Size = New System.Drawing.Size(470, 44)
        Me.CurrentPass.TabIndex = 1
        '
        'NewPass
        '
        Me.NewPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NewPass.BackColor = System.Drawing.SystemColors.Window
        Me.NewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPass.ForeColor = System.Drawing.Color.Black
        Me.NewPass.Location = New System.Drawing.Point(425, 439)
        Me.NewPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NewPass.Name = "NewPass"
        Me.NewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPass.Size = New System.Drawing.Size(470, 44)
        Me.NewPass.TabIndex = 2
        '
        'RetypeNewPass
        '
        Me.RetypeNewPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RetypeNewPass.BackColor = System.Drawing.SystemColors.Window
        Me.RetypeNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetypeNewPass.ForeColor = System.Drawing.Color.Black
        Me.RetypeNewPass.Location = New System.Drawing.Point(425, 555)
        Me.RetypeNewPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RetypeNewPass.Name = "RetypeNewPass"
        Me.RetypeNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RetypeNewPass.Size = New System.Drawing.Size(470, 44)
        Me.RetypeNewPass.TabIndex = 3
        '
        'FormUtility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1306, 913)
        Me.Controls.Add(Me.RetypeNewPass)
        Me.Controls.Add(Me.NewPass)
        Me.Controls.Add(Me.CurrentPass)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormUtility"
        Me.Text = "Utility"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CurrentPass As TextBox
    Friend WithEvents NewPass As TextBox
    Friend WithEvents RetypeNewPass As TextBox
End Class
