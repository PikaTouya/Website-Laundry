﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterFormPengguna
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
        Me.btnFind = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBSearch
        '
        Me.TBSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBSearch.BackColor = System.Drawing.SystemColors.Window
        Me.TBSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSearch.ForeColor = System.Drawing.Color.Black
        Me.TBSearch.Location = New System.Drawing.Point(145, 207)
        Me.TBSearch.Name = "TBSearch"
        Me.TBSearch.Size = New System.Drawing.Size(335, 35)
        Me.TBSearch.TabIndex = 7
        Me.TBSearch.WordWrap = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(789, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "UserID :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(38, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Search :"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAdd.Location = New System.Drawing.Point(794, 705)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(142, 44)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("News706 BT", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(438, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(498, 67)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Daftar Pengguna"
        '
        'LVData
        '
        Me.LVData.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LVData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_pengguna, Me.nama_pengguna, Me.level_pengguna})
        Me.LVData.GridLines = True
        Me.LVData.HideSelection = False
        Me.LVData.Location = New System.Drawing.Point(43, 311)
        Me.LVData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LVData.Name = "LVData"
        Me.LVData.Size = New System.Drawing.Size(709, 458)
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
        Me.CBLevel1.Location = New System.Drawing.Point(794, 618)
        Me.CBLevel1.Name = "CBLevel1"
        Me.CBLevel1.Size = New System.Drawing.Size(478, 37)
        Me.CBLevel1.TabIndex = 15
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUpdate.Location = New System.Drawing.Point(960, 705)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(142, 44)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDelete.Location = New System.Drawing.Point(1126, 705)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(142, 44)
        Me.btnDelete.TabIndex = 4
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
        Me.IconBack.Location = New System.Drawing.Point(12, 12)
        Me.IconBack.Name = "IconBack"
        Me.IconBack.Size = New System.Drawing.Size(70, 70)
        Me.IconBack.TabIndex = 16
        Me.IconBack.UseVisualStyleBackColor = True
        '
        'TBUserID
        '
        Me.TBUserID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBUserID.BackColor = System.Drawing.SystemColors.Window
        Me.TBUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBUserID.ForeColor = System.Drawing.Color.Black
        Me.TBUserID.Location = New System.Drawing.Point(794, 359)
        Me.TBUserID.Name = "TBUserID"
        Me.TBUserID.Size = New System.Drawing.Size(474, 35)
        Me.TBUserID.TabIndex = 7
        Me.TBUserID.WordWrap = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(789, 584)
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
        Me.Label5.Location = New System.Drawing.Point(789, 497)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Password :"
        '
        'TBPass
        '
        Me.TBPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBPass.BackColor = System.Drawing.SystemColors.Window
        Me.TBPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPass.ForeColor = System.Drawing.Color.Black
        Me.TBPass.Location = New System.Drawing.Point(794, 531)
        Me.TBPass.Name = "TBPass"
        Me.TBPass.Size = New System.Drawing.Size(474, 35)
        Me.TBPass.TabIndex = 7
        Me.TBPass.WordWrap = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(789, 411)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Username :"
        '
        'TBUsername
        '
        Me.TBUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBUsername.BackColor = System.Drawing.SystemColors.Window
        Me.TBUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBUsername.ForeColor = System.Drawing.Color.Black
        Me.TBUsername.Location = New System.Drawing.Point(794, 445)
        Me.TBUsername.Name = "TBUsername"
        Me.TBUsername.Size = New System.Drawing.Size(474, 35)
        Me.TBUsername.TabIndex = 7
        Me.TBUsername.WordWrap = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(486, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 29)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Level :"
        '
        'Cblevel2
        '
        Me.Cblevel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cblevel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cblevel2.FormattingEnabled = True
        Me.Cblevel2.Location = New System.Drawing.Point(575, 207)
        Me.Cblevel2.Name = "Cblevel2"
        Me.Cblevel2.Size = New System.Drawing.Size(177, 37)
        Me.Cblevel2.TabIndex = 15
        '
        'btnFind
        '
        Me.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnFind.Location = New System.Drawing.Point(43, 260)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(709, 44)
        Me.btnFind.TabIndex = 4
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'MasterFormPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1335, 813)
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
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
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
    Friend WithEvents btnFind As Button
End Class