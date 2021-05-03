<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class instructorinfofrm
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
        Me.teachFNameTXT = New System.Windows.Forms.TextBox()
        Me.teachMITXT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.teachFamNameTXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.teachAddTXT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.teachNameCodeTXT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.teachgenderCMBO = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.teachIDNumLBL = New System.Windows.Forms.Label()
        Me.displayinstructdgv = New System.Windows.Forms.DataGridView()
        Me.searchbyCMBO = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.searchbarTXT = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.refreshPB = New System.Windows.Forms.PictureBox()
        Me.closeCMD = New System.Windows.Forms.Button()
        Me.teachclearCMD = New System.Windows.Forms.Button()
        Me.teachUpdateCMD = New System.Windows.Forms.Button()
        Me.teachDeleteCMD = New System.Windows.Forms.Button()
        Me.teachsaveCMD = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.displayinstructdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.refreshPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(39, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First name:"
        '
        'teachFNameTXT
        '
        Me.teachFNameTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.teachFNameTXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.teachFNameTXT.Location = New System.Drawing.Point(131, 99)
        Me.teachFNameTXT.Name = "teachFNameTXT"
        Me.teachFNameTXT.Size = New System.Drawing.Size(210, 19)
        Me.teachFNameTXT.TabIndex = 1
        '
        'teachMITXT
        '
        Me.teachMITXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.teachMITXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.teachMITXT.Location = New System.Drawing.Point(131, 124)
        Me.teachMITXT.Name = "teachMITXT"
        Me.teachMITXT.Size = New System.Drawing.Size(210, 19)
        Me.teachMITXT.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(20, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Middle Name:"
        '
        'teachFamNameTXT
        '
        Me.teachFamNameTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.teachFamNameTXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.teachFamNameTXT.Location = New System.Drawing.Point(131, 149)
        Me.teachFamNameTXT.Name = "teachFamNameTXT"
        Me.teachFamNameTXT.Size = New System.Drawing.Size(210, 19)
        Me.teachFamNameTXT.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(21, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Family Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(61, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Gender:"
        '
        'teachAddTXT
        '
        Me.teachAddTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.teachAddTXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.teachAddTXT.Location = New System.Drawing.Point(131, 201)
        Me.teachAddTXT.Name = "teachAddTXT"
        Me.teachAddTXT.Size = New System.Drawing.Size(210, 19)
        Me.teachAddTXT.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(54, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Address:"
        '
        'teachNameCodeTXT
        '
        Me.teachNameCodeTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.teachNameCodeTXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.teachNameCodeTXT.Location = New System.Drawing.Point(131, 226)
        Me.teachNameCodeTXT.Name = "teachNameCodeTXT"
        Me.teachNameCodeTXT.Size = New System.Drawing.Size(210, 19)
        Me.teachNameCodeTXT.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(32, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Name code:"
        '
        'teachgenderCMBO
        '
        Me.teachgenderCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.teachgenderCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.teachgenderCMBO.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.teachgenderCMBO.FormattingEnabled = True
        Me.teachgenderCMBO.Location = New System.Drawing.Point(131, 171)
        Me.teachgenderCMBO.Name = "teachgenderCMBO"
        Me.teachgenderCMBO.Size = New System.Drawing.Size(210, 26)
        Me.teachgenderCMBO.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(39, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ID Number:"
        '
        'teachIDNumLBL
        '
        Me.teachIDNumLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teachIDNumLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.teachIDNumLBL.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.teachIDNumLBL.Location = New System.Drawing.Point(131, 77)
        Me.teachIDNumLBL.Name = "teachIDNumLBL"
        Me.teachIDNumLBL.Size = New System.Drawing.Size(187, 19)
        Me.teachIDNumLBL.TabIndex = 13
        Me.teachIDNumLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayinstructdgv
        '
        Me.displayinstructdgv.AllowUserToAddRows = False
        Me.displayinstructdgv.AllowUserToDeleteRows = False
        Me.displayinstructdgv.AllowUserToResizeColumns = False
        Me.displayinstructdgv.AllowUserToResizeRows = False
        Me.displayinstructdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.displayinstructdgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.displayinstructdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.displayinstructdgv.Location = New System.Drawing.Point(9, 44)
        Me.displayinstructdgv.MultiSelect = False
        Me.displayinstructdgv.Name = "displayinstructdgv"
        Me.displayinstructdgv.ReadOnly = True
        Me.displayinstructdgv.RowHeadersVisible = False
        Me.displayinstructdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.displayinstructdgv.Size = New System.Drawing.Size(540, 241)
        Me.displayinstructdgv.TabIndex = 18
        '
        'searchbyCMBO
        '
        Me.searchbyCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.searchbyCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchbyCMBO.FormattingEnabled = True
        Me.searchbyCMBO.Location = New System.Drawing.Point(94, 17)
        Me.searchbyCMBO.Name = "searchbyCMBO"
        Me.searchbyCMBO.Size = New System.Drawing.Size(123, 21)
        Me.searchbyCMBO.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Search by:"
        '
        'searchbarTXT
        '
        Me.searchbarTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchbarTXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.searchbarTXT.Location = New System.Drawing.Point(223, 19)
        Me.searchbarTXT.Name = "searchbarTXT"
        Me.searchbarTXT.Size = New System.Drawing.Size(210, 19)
        Me.searchbarTXT.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.displayinstructdgv)
        Me.GroupBox1.Controls.Add(Me.searchbarTXT)
        Me.GroupBox1.Controls.Add(Me.searchbyCMBO)
        Me.GroupBox1.Location = New System.Drawing.Point(347, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 291)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(916, 65)
        Me.Panel1.TabIndex = 25
        '
        'refreshPB
        '
        Me.refreshPB.Image = Global.StudentInformationSystem.My.Resources.Resources.refresh_or_update
        Me.refreshPB.Location = New System.Drawing.Point(320, 77)
        Me.refreshPB.Name = "refreshPB"
        Me.refreshPB.Size = New System.Drawing.Size(20, 20)
        Me.refreshPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.refreshPB.TabIndex = 23
        Me.refreshPB.TabStop = False
        '
        'closeCMD
        '
        Me.closeCMD.BackColor = System.Drawing.Color.Transparent
        Me.closeCMD.FlatAppearance.BorderSize = 0
        Me.closeCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeCMD.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.closeCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_close
        Me.closeCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closeCMD.Location = New System.Drawing.Point(875, 0)
        Me.closeCMD.Name = "closeCMD"
        Me.closeCMD.Size = New System.Drawing.Size(41, 38)
        Me.closeCMD.TabIndex = 19
        Me.closeCMD.UseVisualStyleBackColor = False
        '
        'teachclearCMD
        '
        Me.teachclearCMD.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.teachclearCMD.FlatAppearance.BorderSize = 0
        Me.teachclearCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.teachclearCMD.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.teachclearCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.CLEAR_ico1
        Me.teachclearCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.teachclearCMD.Location = New System.Drawing.Point(131, 315)
        Me.teachclearCMD.Name = "teachclearCMD"
        Me.teachclearCMD.Size = New System.Drawing.Size(102, 43)
        Me.teachclearCMD.TabIndex = 17
        Me.teachclearCMD.Text = "       &Clear"
        Me.teachclearCMD.UseVisualStyleBackColor = False
        '
        'teachUpdateCMD
        '
        Me.teachUpdateCMD.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.teachUpdateCMD.FlatAppearance.BorderSize = 0
        Me.teachUpdateCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.teachUpdateCMD.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.teachUpdateCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_update_db_logo
        Me.teachUpdateCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.teachUpdateCMD.Location = New System.Drawing.Point(131, 266)
        Me.teachUpdateCMD.Name = "teachUpdateCMD"
        Me.teachUpdateCMD.Size = New System.Drawing.Size(102, 43)
        Me.teachUpdateCMD.TabIndex = 16
        Me.teachUpdateCMD.Text = "       &Update"
        Me.teachUpdateCMD.UseVisualStyleBackColor = False
        '
        'teachDeleteCMD
        '
        Me.teachDeleteCMD.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.teachDeleteCMD.FlatAppearance.BorderSize = 0
        Me.teachDeleteCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.teachDeleteCMD.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.teachDeleteCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_delete
        Me.teachDeleteCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.teachDeleteCMD.Location = New System.Drawing.Point(239, 266)
        Me.teachDeleteCMD.Name = "teachDeleteCMD"
        Me.teachDeleteCMD.Size = New System.Drawing.Size(102, 43)
        Me.teachDeleteCMD.TabIndex = 15
        Me.teachDeleteCMD.Text = "       &Delete"
        Me.teachDeleteCMD.UseVisualStyleBackColor = False
        '
        'teachsaveCMD
        '
        Me.teachsaveCMD.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.teachsaveCMD.FlatAppearance.BorderSize = 0
        Me.teachsaveCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.teachsaveCMD.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.teachsaveCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_save_logo
        Me.teachsaveCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.teachsaveCMD.Location = New System.Drawing.Point(23, 266)
        Me.teachsaveCMD.Name = "teachsaveCMD"
        Me.teachsaveCMD.Size = New System.Drawing.Size(102, 43)
        Me.teachsaveCMD.TabIndex = 14
        Me.teachsaveCMD.Text = "       &Save"
        Me.teachsaveCMD.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.add_instructor_banner
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(916, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'instructorinfofrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(915, 371)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.refreshPB)
        Me.Controls.Add(Me.closeCMD)
        Me.Controls.Add(Me.teachclearCMD)
        Me.Controls.Add(Me.teachUpdateCMD)
        Me.Controls.Add(Me.teachDeleteCMD)
        Me.Controls.Add(Me.teachsaveCMD)
        Me.Controls.Add(Me.teachIDNumLBL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.teachgenderCMBO)
        Me.Controls.Add(Me.teachNameCodeTXT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.teachAddTXT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.teachFamNameTXT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.teachMITXT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.teachFNameTXT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "instructorinfofrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "instructorinfofrm"
        CType(Me.displayinstructdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.refreshPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents teachFNameTXT As System.Windows.Forms.TextBox
    Friend WithEvents teachMITXT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents teachFamNameTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents teachAddTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents teachNameCodeTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents teachgenderCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents teachIDNumLBL As System.Windows.Forms.Label
    Friend WithEvents teachsaveCMD As System.Windows.Forms.Button
    Friend WithEvents teachDeleteCMD As System.Windows.Forms.Button
    Friend WithEvents teachUpdateCMD As System.Windows.Forms.Button
    Friend WithEvents teachclearCMD As System.Windows.Forms.Button
    Friend WithEvents displayinstructdgv As System.Windows.Forms.DataGridView
    Friend WithEvents closeCMD As System.Windows.Forms.Button
    Friend WithEvents searchbyCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents searchbarTXT As System.Windows.Forms.TextBox
    Friend WithEvents refreshPB As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
