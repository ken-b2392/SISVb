<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class assigninstructortosubjfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(assigninstructortosubjfrm))
        Me.closeCMD = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.searchbysubjtoAssignCMBO = New System.Windows.Forms.ComboBox()
        Me.searchtoassignsubjTXT = New System.Windows.Forms.TextBox()
        Me.displaysubjdgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchbyinstructCMBO = New System.Windows.Forms.ComboBox()
        Me.teacherDGV = New System.Windows.Forms.DataGridView()
        Me.searchbarinstructorTXT = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.handledsubjDGV = New System.Windows.Forms.DataGridView()
        Me.removesubjCMD = New System.Windows.Forms.Button()
        Me.assignsubjCMD = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.forsubjectcodeLB = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.displaysubjdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.teacherDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.handledsubjDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'closeCMD
        '
        Me.closeCMD.BackColor = System.Drawing.Color.Transparent
        Me.closeCMD.FlatAppearance.BorderSize = 0
        Me.closeCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeCMD.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.closeCMD.Image = CType(resources.GetObject("closeCMD.Image"), System.Drawing.Image)
        Me.closeCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closeCMD.Location = New System.Drawing.Point(1122, 0)
        Me.closeCMD.Name = "closeCMD"
        Me.closeCMD.Size = New System.Drawing.Size(41, 38)
        Me.closeCMD.TabIndex = 33
        Me.closeCMD.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.searchbysubjtoAssignCMBO)
        Me.GroupBox1.Controls.Add(Me.searchtoassignsubjTXT)
        Me.GroupBox1.Controls.Add(Me.displaysubjdgv)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 405)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 229)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Search subject by:"
        '
        'searchbysubjtoAssignCMBO
        '
        Me.searchbysubjtoAssignCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.searchbysubjtoAssignCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchbysubjtoAssignCMBO.FormattingEnabled = True
        Me.searchbysubjtoAssignCMBO.Location = New System.Drawing.Point(137, 17)
        Me.searchbysubjtoAssignCMBO.Name = "searchbysubjtoAssignCMBO"
        Me.searchbysubjtoAssignCMBO.Size = New System.Drawing.Size(165, 21)
        Me.searchbysubjtoAssignCMBO.TabIndex = 19
        '
        'searchtoassignsubjTXT
        '
        Me.searchtoassignsubjTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchtoassignsubjTXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.searchtoassignsubjTXT.Location = New System.Drawing.Point(308, 17)
        Me.searchtoassignsubjTXT.Name = "searchtoassignsubjTXT"
        Me.searchtoassignsubjTXT.Size = New System.Drawing.Size(222, 19)
        Me.searchtoassignsubjTXT.TabIndex = 18
        '
        'displaysubjdgv
        '
        Me.displaysubjdgv.AllowUserToAddRows = False
        Me.displaysubjdgv.AllowUserToDeleteRows = False
        Me.displaysubjdgv.AllowUserToResizeColumns = False
        Me.displaysubjdgv.AllowUserToResizeRows = False
        Me.displaysubjdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.displaysubjdgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.displaysubjdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.displaysubjdgv.Location = New System.Drawing.Point(6, 44)
        Me.displaysubjdgv.MultiSelect = False
        Me.displaysubjdgv.Name = "displaysubjdgv"
        Me.displaysubjdgv.ReadOnly = True
        Me.displaysubjdgv.RowHeadersVisible = False
        Me.displaysubjdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.displaysubjdgv.Size = New System.Drawing.Size(526, 179)
        Me.displaysubjdgv.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.searchbyinstructCMBO)
        Me.GroupBox2.Controls.Add(Me.teacherDGV)
        Me.GroupBox2.Controls.Add(Me.searchbarinstructorTXT)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1133, 243)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search name by:"
        '
        'searchbyinstructCMBO
        '
        Me.searchbyinstructCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.searchbyinstructCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchbyinstructCMBO.FormattingEnabled = True
        Me.searchbyinstructCMBO.Location = New System.Drawing.Point(119, 19)
        Me.searchbyinstructCMBO.Name = "searchbyinstructCMBO"
        Me.searchbyinstructCMBO.Size = New System.Drawing.Size(103, 21)
        Me.searchbyinstructCMBO.TabIndex = 17
        '
        'teacherDGV
        '
        Me.teacherDGV.AllowUserToAddRows = False
        Me.teacherDGV.AllowUserToDeleteRows = False
        Me.teacherDGV.AllowUserToResizeColumns = False
        Me.teacherDGV.AllowUserToResizeRows = False
        Me.teacherDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.teacherDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.teacherDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.teacherDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.teacherDGV.Location = New System.Drawing.Point(6, 46)
        Me.teacherDGV.MultiSelect = False
        Me.teacherDGV.Name = "teacherDGV"
        Me.teacherDGV.ReadOnly = True
        Me.teacherDGV.RowHeadersVisible = False
        Me.teacherDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.teacherDGV.Size = New System.Drawing.Size(1121, 186)
        Me.teacherDGV.TabIndex = 8
        '
        'searchbarinstructorTXT
        '
        Me.searchbarinstructorTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchbarinstructorTXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.searchbarinstructorTXT.Location = New System.Drawing.Point(237, 19)
        Me.searchbarinstructorTXT.Name = "searchbarinstructorTXT"
        Me.searchbarinstructorTXT.Size = New System.Drawing.Size(313, 19)
        Me.searchbarinstructorTXT.TabIndex = 15
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.handledsubjDGV)
        Me.GroupBox3.Location = New System.Drawing.Point(606, 405)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(539, 229)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        '
        'handledsubjDGV
        '
        Me.handledsubjDGV.AllowUserToAddRows = False
        Me.handledsubjDGV.AllowUserToDeleteRows = False
        Me.handledsubjDGV.AllowUserToResizeColumns = False
        Me.handledsubjDGV.AllowUserToResizeRows = False
        Me.handledsubjDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.handledsubjDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.handledsubjDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.handledsubjDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.handledsubjDGV.Location = New System.Drawing.Point(3, 16)
        Me.handledsubjDGV.MultiSelect = False
        Me.handledsubjDGV.Name = "handledsubjDGV"
        Me.handledsubjDGV.ReadOnly = True
        Me.handledsubjDGV.RowHeadersVisible = False
        Me.handledsubjDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.handledsubjDGV.Size = New System.Drawing.Size(533, 210)
        Me.handledsubjDGV.TabIndex = 18
        '
        'removesubjCMD
        '
        Me.removesubjCMD.FlatAppearance.BorderSize = 0
        Me.removesubjCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.removesubjCMD.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.removesubjCMD.Location = New System.Drawing.Point(556, 506)
        Me.removesubjCMD.Name = "removesubjCMD"
        Me.removesubjCMD.Size = New System.Drawing.Size(44, 23)
        Me.removesubjCMD.TabIndex = 37
        Me.removesubjCMD.Text = "<<"
        Me.removesubjCMD.UseVisualStyleBackColor = True
        '
        'assignsubjCMD
        '
        Me.assignsubjCMD.FlatAppearance.BorderSize = 0
        Me.assignsubjCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.assignsubjCMD.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assignsubjCMD.Location = New System.Drawing.Point(556, 477)
        Me.assignsubjCMD.Name = "assignsubjCMD"
        Me.assignsubjCMD.Size = New System.Drawing.Size(44, 23)
        Me.assignsubjCMD.TabIndex = 36
        Me.assignsubjCMD.Text = ">>"
        Me.assignsubjCMD.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(18, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "List of subjects:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(606, 384)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(310, 18)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "List of handled subjects of selected teacher:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(15, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 18)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "List of instructors:"
        '
        'forsubjectcodeLB
        '
        Me.forsubjectcodeLB.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.forsubjectcodeLB.FormattingEnabled = True
        Me.forsubjectcodeLB.ItemHeight = 16
        Me.forsubjectcodeLB.Location = New System.Drawing.Point(1218, 145)
        Me.forsubjectcodeLB.Name = "forsubjectcodeLB"
        Me.forsubjectcodeLB.Size = New System.Drawing.Size(43, 20)
        Me.forsubjectcodeLB.TabIndex = 42
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1166, 100)
        Me.Panel1.TabIndex = 43
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.assign_subjects_to_instructor
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1166, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(1173, 201)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(73, 148)
        Me.ListBox1.TabIndex = 44
        '
        'assigninstructortosubjfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1166, 646)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.forsubjectcodeLB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.removesubjCMD)
        Me.Controls.Add(Me.assignsubjCMD)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.closeCMD)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "assigninstructortosubjfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "assigninstructortosubjfrm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.displaysubjdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.teacherDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.handledsubjDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents closeCMD As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents displaysubjdgv As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents searchbyinstructCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents teacherDGV As System.Windows.Forms.DataGridView
    Friend WithEvents searchbarinstructorTXT As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents handledsubjDGV As System.Windows.Forms.DataGridView
    Friend WithEvents removesubjCMD As System.Windows.Forms.Button
    Friend WithEvents assignsubjCMD As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents forsubjectcodeLB As System.Windows.Forms.ListBox
    Friend WithEvents searchbysubjtoAssignCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents searchtoassignsubjTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
