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
        Me.SuspendLayout()
        '
        'TBSearch
        '
        Me.TBSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBSearch.BackColor = System.Drawing.SystemColors.Window
        Me.TBSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSearch.ForeColor = System.Drawing.Color.Black
        Me.TBSearch.Location = New System.Drawing.Point(126, 177)
        Me.TBSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBSearch.Name = "TBSearch"
        Me.TBSearch.Size = New System.Drawing.Size(298, 30)
        Me.TBSearch.TabIndex = 1
        Me.TBSearch.WordWrap = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(701, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "UserID :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(31, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Search :"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAdd.Location = New System.Drawing.Point(706, 564)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(126, 35)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("News706 BT", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(389, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(415, 56)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Daftar Pengguna"
        '
        'LVData
        '
        Me.LVData.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LVData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_pengguna, Me.nama_pengguna, Me.level_pengguna})
        Me.LVData.GridLines = True
        Me.LVData.HideSelection = False
        Me.LVData.Location = New System.Drawing.Point(37, 260)
        Me.LVData.Name = "LVData"
        Me.LVData.Size = New System.Drawing.Size(631, 367)
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
        'CBLevel1
        '
        Me.CBLevel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CBLevel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBLevel1.FormattingEnabled = True
        Me.CBLevel1.Location = New System.Drawing.Point(706, 494)
        Me.CBLevel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBLevel1.Name = "CBLevel1"
        Me.CBLevel1.Size = New System.Drawing.Size(425, 33)
        Me.CBLevel1.TabIndex = 7
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUpdate.Location = New System.Drawing.Point(853, 564)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(126, 35)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDelete.Location = New System.Drawing.Point(1001, 564)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(126, 35)
        Me.btnDelete.TabIndex = 10
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
        Me.IconBack.Location = New System.Drawing.Point(11, 10)
        Me.IconBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconBack.Name = "IconBack"
        Me.IconBack.Size = New System.Drawing.Size(62, 56)
        Me.IconBack.TabIndex = 16
        Me.IconBack.UseVisualStyleBackColor = True
        '
        'TBUserID
        '
        Me.TBUserID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBUserID.BackColor = System.Drawing.SystemColors.Window
        Me.TBUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBUserID.ForeColor = System.Drawing.Color.Black
        Me.TBUserID.Location = New System.Drawing.Point(706, 287)
        Me.TBUserID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBUserID.Name = "TBUserID"
        Me.TBUserID.Size = New System.Drawing.Size(422, 30)
        Me.TBUserID.TabIndex = 4
        Me.TBUserID.WordWrap = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(701, 467)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Level :"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(701, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Password :"
        '
        'TBPass
        '
        Me.TBPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBPass.BackColor = System.Drawing.SystemColors.Window
        Me.TBPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPass.ForeColor = System.Drawing.Color.Black
        Me.TBPass.Location = New System.Drawing.Point(706, 425)
        Me.TBPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBPass.Name = "TBPass"
        Me.TBPass.Size = New System.Drawing.Size(422, 30)
        Me.TBPass.TabIndex = 6
        Me.TBPass.WordWrap = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(701, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Username :"
        '
        'TBUsername
        '
        Me.TBUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBUsername.BackColor = System.Drawing.SystemColors.Window
        Me.TBUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBUsername.ForeColor = System.Drawing.Color.Black
        Me.TBUsername.Location = New System.Drawing.Point(706, 356)
        Me.TBUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBUsername.Name = "TBUsername"
        Me.TBUsername.Size = New System.Drawing.Size(422, 30)
        Me.TBUsername.TabIndex = 5
        Me.TBUsername.WordWrap = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(429, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 25)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Level :"
        '
        'Cblevel2
        '
        Me.Cblevel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cblevel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cblevel2.FormattingEnabled = True
        Me.Cblevel2.Location = New System.Drawing.Point(508, 177)
        Me.Cblevel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cblevel2.Name = "Cblevel2"
        Me.Cblevel2.Size = New System.Drawing.Size(158, 33)
        Me.Cblevel2.TabIndex = 2
        '
        'MasterFormPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1187, 650)
        Me.Controls.Add(Me.IconBack)
        Me.Controls.Add(Me.Cblevel2)
        Me.Controls.Add(Me.CBLevel1)
        Me.Controls.Add(Me.LVData)
        Me.Controls.Add(Me.TBUsername)
        Me.Controls.Add(Me.TBPass)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBUserID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
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
End Class
