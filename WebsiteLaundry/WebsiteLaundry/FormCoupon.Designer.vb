<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCoupon
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
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUnusedCoupons = New System.Windows.Forms.Label()
        Me.lblRemainingStars = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.Controls.Add(Me.lblUnusedCoupons)
        Me.Panel1.Controls.Add(Me.lblRemainingStars)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(287, 271)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 444)
        Me.Panel1.TabIndex = 0
        '
        'lblUnusedCoupons
        '
        Me.lblUnusedCoupons.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUnusedCoupons.AutoSize = True
        Me.lblUnusedCoupons.Font = New System.Drawing.Font("News706 BT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnusedCoupons.ForeColor = System.Drawing.Color.Black
        Me.lblUnusedCoupons.Location = New System.Drawing.Point(20, 223)
        Me.lblUnusedCoupons.Name = "lblUnusedCoupons"
        Me.lblUnusedCoupons.Size = New System.Drawing.Size(197, 34)
        Me.lblUnusedCoupons.TabIndex = 7
        Me.lblUnusedCoupons.Text = "Total Coupon"
        '
        'lblRemainingStars
        '
        Me.lblRemainingStars.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRemainingStars.AutoSize = True
        Me.lblRemainingStars.Font = New System.Drawing.Font("News706 BT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingStars.ForeColor = System.Drawing.Color.Black
        Me.lblRemainingStars.Location = New System.Drawing.Point(20, 140)
        Me.lblRemainingStars.Name = "lblRemainingStars"
        Me.lblRemainingStars.Size = New System.Drawing.Size(175, 34)
        Me.lblRemainingStars.TabIndex = 7
        Me.lblRemainingStars.Text = "Total Order"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("News706 BT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(662, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "*NB : Your total order time will be reset to 0 after getting the coupon"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("News706 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(2, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(564, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "*NB : You will get a coupon after 10 times order"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("News706 BT", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label11.Location = New System.Drawing.Point(467, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(386, 67)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Your Coupon"
        '
        'FormCoupon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1306, 913)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormCoupon"
        Me.Text = "Coupon"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRemainingStars As Label
    Friend WithEvents lblUnusedCoupons As Label
    Friend WithEvents Label4 As Label
End Class
