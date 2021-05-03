<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class assignschedfrm
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
        Me.StudIDNumLBL = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.studentsDGV = New System.Windows.Forms.DataGridView()
        Me.addsubjCMBO = New System.Windows.Forms.Button()
        Me.searchstudnameTXT = New System.Windows.Forms.TextBox()
        Me.searchbyCMBO = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.semesterCMBO = New System.Windows.Forms.ComboBox()
        Me.searchbarsubjTXT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.yearlvlCMBO = New System.Windows.Forms.ComboBox()
        Me.subjectsDGV = New System.Windows.Forms.DataGridView()
        Me.assignedsubj = New System.Windows.Forms.DataGridView()
        Me.removeassignedsubjCMD = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.forsubjcount = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.closeCMD = New System.Windows.Forms.Button()
        CType(Me.studentsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.subjectsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.assignedsubj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search name by:"
        '
        'StudIDNumLBL
        '
        Me.StudIDNumLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudIDNumLBL.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.StudIDNumLBL.Location = New System.Drawing.Point(119, 16)
        Me.StudIDNumLBL.Name = "StudIDNumLBL"
        Me.StudIDNumLBL.Size = New System.Drawing.Size(152, 16)
        Me.StudIDNumLBL.TabIndex = 3
        Me.StudIDNumLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(35, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ID Number:"
        '
        'studentsDGV
        '
        Me.studentsDGV.AllowUserToAddRows = False
        Me.studentsDGV.AllowUserToDeleteRows = False
        Me.studentsDGV.AllowUserToResizeColumns = False
        Me.studentsDGV.AllowUserToResizeRows = False
        Me.studentsDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.studentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.studentsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.studentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.studentsDGV.Location = New System.Drawing.Point(6, 66)
        Me.studentsDGV.MultiSelect = False
        Me.studentsDGV.Name = "studentsDGV"
        Me.studentsDGV.ReadOnly = True
        Me.studentsDGV.RowHeadersVisible = False
        Me.studentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.studentsDGV.Size = New System.Drawing.Size(370, 410)
        Me.studentsDGV.TabIndex = 8
        '
        'addsubjCMBO
        '
        Me.addsubjCMBO.FlatAppearance.BorderSize = 0
        Me.addsubjCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addsubjCMBO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addsubjCMBO.Location = New System.Drawing.Point(269, 257)
        Me.addsubjCMBO.Name = "addsubjCMBO"
        Me.addsubjCMBO.Size = New System.Drawing.Size(44, 23)
        Me.addsubjCMBO.TabIndex = 9
        Me.addsubjCMBO.Text = "v v"
        Me.addsubjCMBO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addsubjCMBO.UseVisualStyleBackColor = True
        '
        'searchstudnameTXT
        '
        Me.searchstudnameTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchstudnameTXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.searchstudnameTXT.Location = New System.Drawing.Point(255, 41)
        Me.searchstudnameTXT.Name = "searchstudnameTXT"
        Me.searchstudnameTXT.Size = New System.Drawing.Size(121, 19)
        Me.searchstudnameTXT.TabIndex = 15
        '
        'searchbyCMBO
        '
        Me.searchbyCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.searchbyCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchbyCMBO.FormattingEnabled = True
        Me.searchbyCMBO.Location = New System.Drawing.Point(119, 41)
        Me.searchbyCMBO.Name = "searchbyCMBO"
        Me.searchbyCMBO.Size = New System.Drawing.Size(130, 21)
        Me.searchbyCMBO.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.searchbyCMBO)
        Me.GroupBox1.Controls.Add(Me.StudIDNumLBL)
        Me.GroupBox1.Controls.Add(Me.studentsDGV)
        Me.GroupBox1.Controls.Add(Me.searchstudnameTXT)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 487)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.semesterCMBO)
        Me.GroupBox2.Controls.Add(Me.searchbarsubjTXT)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.yearlvlCMBO)
        Me.GroupBox2.Controls.Add(Me.subjectsDGV)
        Me.GroupBox2.Controls.Add(Me.assignedsubj)
        Me.GroupBox2.Controls.Add(Me.removeassignedsubjCMD)
        Me.GroupBox2.Controls.Add(Me.addsubjCMBO)
        Me.GroupBox2.Location = New System.Drawing.Point(400, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 487)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(130, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(6, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Total No. of Units:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(159, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Semester:"
        '
        'semesterCMBO
        '
        Me.semesterCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.semesterCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.semesterCMBO.FormattingEnabled = True
        Me.semesterCMBO.Location = New System.Drawing.Point(239, 13)
        Me.semesterCMBO.Name = "semesterCMBO"
        Me.semesterCMBO.Size = New System.Drawing.Size(57, 21)
        Me.semesterCMBO.TabIndex = 27
        '
        'searchbarsubjTXT
        '
        Me.searchbarsubjTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchbarsubjTXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.searchbarsubjTXT.Location = New System.Drawing.Point(364, 16)
        Me.searchbarsubjTXT.Name = "searchbarsubjTXT"
        Me.searchbarsubjTXT.Size = New System.Drawing.Size(266, 19)
        Me.searchbarsubjTXT.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Year level:"
        '
        'yearlvlCMBO
        '
        Me.yearlvlCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yearlvlCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.yearlvlCMBO.FormattingEnabled = True
        Me.yearlvlCMBO.Location = New System.Drawing.Point(86, 14)
        Me.yearlvlCMBO.Name = "yearlvlCMBO"
        Me.yearlvlCMBO.Size = New System.Drawing.Size(57, 21)
        Me.yearlvlCMBO.TabIndex = 25
        '
        'subjectsDGV
        '
        Me.subjectsDGV.AllowUserToAddRows = False
        Me.subjectsDGV.AllowUserToDeleteRows = False
        Me.subjectsDGV.AllowUserToResizeColumns = False
        Me.subjectsDGV.AllowUserToResizeRows = False
        Me.subjectsDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.subjectsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.subjectsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.subjectsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.subjectsDGV.Location = New System.Drawing.Point(5, 41)
        Me.subjectsDGV.MultiSelect = False
        Me.subjectsDGV.Name = "subjectsDGV"
        Me.subjectsDGV.ReadOnly = True
        Me.subjectsDGV.RowHeadersVisible = False
        Me.subjectsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.subjectsDGV.Size = New System.Drawing.Size(625, 210)
        Me.subjectsDGV.TabIndex = 22
        '
        'assignedsubj
        '
        Me.assignedsubj.AllowUserToAddRows = False
        Me.assignedsubj.AllowUserToDeleteRows = False
        Me.assignedsubj.AllowUserToResizeColumns = False
        Me.assignedsubj.AllowUserToResizeRows = False
        Me.assignedsubj.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.assignedsubj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.assignedsubj.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.assignedsubj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.assignedsubj.Location = New System.Drawing.Point(6, 288)
        Me.assignedsubj.MultiSelect = False
        Me.assignedsubj.Name = "assignedsubj"
        Me.assignedsubj.ReadOnly = True
        Me.assignedsubj.RowHeadersVisible = False
        Me.assignedsubj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.assignedsubj.Size = New System.Drawing.Size(625, 188)
        Me.assignedsubj.TabIndex = 14
        '
        'removeassignedsubjCMD
        '
        Me.removeassignedsubjCMD.FlatAppearance.BorderSize = 0
        Me.removeassignedsubjCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.removeassignedsubjCMD.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.removeassignedsubjCMD.Location = New System.Drawing.Point(319, 259)
        Me.removeassignedsubjCMD.Name = "removeassignedsubjCMD"
        Me.removeassignedsubjCMD.Size = New System.Drawing.Size(44, 23)
        Me.removeassignedsubjCMD.TabIndex = 13
        Me.removeassignedsubjCMD.Text = "^^"
        Me.removeassignedsubjCMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.removeassignedsubjCMD.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1087, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "total"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(1090, 233)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(73, 43)
        Me.ListBox1.TabIndex = 21
        '
        'forsubjcount
        '
        Me.forsubjcount.FormattingEnabled = True
        Me.forsubjcount.Location = New System.Drawing.Point(1090, 160)
        Me.forsubjcount.Name = "forsubjcount"
        Me.forsubjcount.Size = New System.Drawing.Size(73, 43)
        Me.forsubjcount.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1055, 88)
        Me.Panel1.TabIndex = 29
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.assign_stud_sched_banner
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1055, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'closeCMD
        '
        Me.closeCMD.BackColor = System.Drawing.Color.Transparent
        Me.closeCMD.FlatAppearance.BorderSize = 0
        Me.closeCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeCMD.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.closeCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_close
        Me.closeCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closeCMD.Location = New System.Drawing.Point(1014, 0)
        Me.closeCMD.Name = "closeCMD"
        Me.closeCMD.Size = New System.Drawing.Size(41, 38)
        Me.closeCMD.TabIndex = 16
        Me.closeCMD.UseVisualStyleBackColor = False
        '
        'assignschedfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1055, 593)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.forsubjcount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.closeCMD)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "assignschedfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "assignschedfrm"
        CType(Me.studentsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.subjectsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.assignedsubj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StudIDNumLBL As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents studentsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents addsubjCMBO As System.Windows.Forms.Button
    Friend WithEvents searchstudnameTXT As System.Windows.Forms.TextBox
    Friend WithEvents closeCMD As System.Windows.Forms.Button
    Friend WithEvents searchbyCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents removeassignedsubjCMD As System.Windows.Forms.Button
    Friend WithEvents assignedsubj As System.Windows.Forms.DataGridView
    Friend WithEvents searchbarsubjTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents yearlvlCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents subjectsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents semesterCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents forsubjcount As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
