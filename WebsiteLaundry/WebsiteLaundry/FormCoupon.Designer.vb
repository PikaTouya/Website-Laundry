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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCoupon))
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUnusedCoupons = New System.Windows.Forms.Label()
        Me.lblRemainingStars = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Panel1.BackColor = System.Drawing.Color.OldLace
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.lblUnusedCoupons)
        Me.Panel1.Controls.Add(Me.lblRemainingStars)
        Me.Panel1.Location = New System.Drawing.Point(156, 138)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 639)
        Me.Panel1.TabIndex = 0
        '
        'lblUnusedCoupons
        '
        Me.lblUnusedCoupons.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUnusedCoupons.AutoSize = True
        Me.lblUnusedCoupons.Font = New System.Drawing.Font("Forte", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnusedCoupons.ForeColor = System.Drawing.Color.Black
        Me.lblUnusedCoupons.Location = New System.Drawing.Point(57, 584)
        Me.lblUnusedCoupons.Name = "lblUnusedCoupons"
        Me.lblUnusedCoupons.Size = New System.Drawing.Size(190, 31)
        Me.lblUnusedCoupons.TabIndex = 7
        Me.lblUnusedCoupons.Text = "Total Coupon"
        '
        'lblRemainingStars
        '
        Me.lblRemainingStars.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRemainingStars.AutoSize = True
        Me.lblRemainingStars.Font = New System.Drawing.Font("Forte", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingStars.ForeColor = System.Drawing.Color.Black
        Me.lblRemainingStars.Location = New System.Drawing.Point(57, 536)
        Me.lblRemainingStars.Name = "lblRemainingStars"
        Me.lblRemainingStars.Size = New System.Drawing.Size(162, 31)
        Me.lblRemainingStars.TabIndex = 7
        Me.lblRemainingStars.Text = "Total Order"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.OldLace
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Forte", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(63, 129)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(893, 363)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Blackadder ITC", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(550, 103)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "To Our Customers"
        '
        'FormCoupon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1306, 913)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormCoupon"
        Me.Text = "Coupon"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblRemainingStars As Label
    Friend WithEvents lblUnusedCoupons As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
End Class
