<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfirm
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
        Me.tbConfirm = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(253, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Confirm Your Password First!"
        '
        'tbConfirm
        '
        Me.tbConfirm.Location = New System.Drawing.Point(256, 176)
        Me.tbConfirm.Name = "tbConfirm"
        Me.tbConfirm.Size = New System.Drawing.Size(233, 22)
        Me.tbConfirm.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(256, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(382, 214)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FormConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbConfirm)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormConfirm"
        Me.Text = "FormConfirm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbConfirm As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCancel As Button
End Class
