<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class printstudrecordfrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(printstudrecordfrm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.printbyCMBO = New System.Windows.Forms.ComboBox()
        Me.individualGB = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.toprintpb = New System.Windows.Forms.PictureBox()
        Me.printindivudalCMD = New System.Windows.Forms.Button()
        Me.previewindividualCMD = New System.Windows.Forms.Button()
        Me.individualsearchbarTXT = New System.Windows.Forms.TextBox()
        Me.searchbyindividualCMBO = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.individualDGV = New System.Windows.Forms.DataGridView()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.courseGB = New System.Windows.Forms.GroupBox()
        Me.yrlvlCMBO = New System.Windows.Forms.ComboBox()
        Me.semCMBO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.searchprintCMD = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.sytoLBL = New System.Windows.Forms.Label()
        Me.courseCMBO = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.syfromCMBO = New System.Windows.Forms.ComboBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.crystalReport11 = New StudentInformationSystem.CrystalReport1()
        Me.closeCMD = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.individualGB.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toprintpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.individualDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.courseGB.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Print by:"
        '
        'printbyCMBO
        '
        Me.printbyCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.printbyCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printbyCMBO.FormattingEnabled = True
        Me.printbyCMBO.Location = New System.Drawing.Point(68, 86)
        Me.printbyCMBO.Name = "printbyCMBO"
        Me.printbyCMBO.Size = New System.Drawing.Size(121, 21)
        Me.printbyCMBO.TabIndex = 1
        '
        'individualGB
        '
        Me.individualGB.Controls.Add(Me.DataGridView1)
        Me.individualGB.Controls.Add(Me.toprintpb)
        Me.individualGB.Controls.Add(Me.printindivudalCMD)
        Me.individualGB.Controls.Add(Me.previewindividualCMD)
        Me.individualGB.Controls.Add(Me.individualsearchbarTXT)
        Me.individualGB.Controls.Add(Me.searchbyindividualCMBO)
        Me.individualGB.Controls.Add(Me.Label2)
        Me.individualGB.Controls.Add(Me.individualDGV)
        Me.individualGB.Location = New System.Drawing.Point(1026, 114)
        Me.individualGB.Name = "individualGB"
        Me.individualGB.Size = New System.Drawing.Size(407, 297)
        Me.individualGB.TabIndex = 2
        Me.individualGB.TabStop = False
        Me.individualGB.Text = "Print by individual:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(932, 54)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(784, 267)
        Me.DataGridView1.TabIndex = 8
        '
        'toprintpb
        '
        Me.toprintpb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.toprintpb.Location = New System.Drawing.Point(19, 54)
        Me.toprintpb.Name = "toprintpb"
        Me.toprintpb.Size = New System.Drawing.Size(124, 122)
        Me.toprintpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.toprintpb.TabIndex = 7
        Me.toprintpb.TabStop = False
        '
        'printindivudalCMD
        '
        Me.printindivudalCMD.FlatAppearance.BorderSize = 0
        Me.printindivudalCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printindivudalCMD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.printindivudalCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_print_ICO
        Me.printindivudalCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.printindivudalCMD.Location = New System.Drawing.Point(19, 218)
        Me.printindivudalCMD.Name = "printindivudalCMD"
        Me.printindivudalCMD.Size = New System.Drawing.Size(83, 27)
        Me.printindivudalCMD.TabIndex = 6
        Me.printindivudalCMD.Text = "Print"
        Me.printindivudalCMD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.printindivudalCMD.UseVisualStyleBackColor = True
        '
        'previewindividualCMD
        '
        Me.previewindividualCMD.FlatAppearance.BorderSize = 0
        Me.previewindividualCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.previewindividualCMD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.previewindividualCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_preview
        Me.previewindividualCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.previewindividualCMD.Location = New System.Drawing.Point(19, 182)
        Me.previewindividualCMD.Name = "previewindividualCMD"
        Me.previewindividualCMD.Size = New System.Drawing.Size(102, 30)
        Me.previewindividualCMD.TabIndex = 5
        Me.previewindividualCMD.Text = "Preview"
        Me.previewindividualCMD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.previewindividualCMD.UseVisualStyleBackColor = True
        '
        'individualsearchbarTXT
        '
        Me.individualsearchbarTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.individualsearchbarTXT.Location = New System.Drawing.Point(207, 24)
        Me.individualsearchbarTXT.Name = "individualsearchbarTXT"
        Me.individualsearchbarTXT.Size = New System.Drawing.Size(197, 13)
        Me.individualsearchbarTXT.TabIndex = 4
        '
        'searchbyindividualCMBO
        '
        Me.searchbyindividualCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.searchbyindividualCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchbyindividualCMBO.FormattingEnabled = True
        Me.searchbyindividualCMBO.Location = New System.Drawing.Point(80, 19)
        Me.searchbyindividualCMBO.Name = "searchbyindividualCMBO"
        Me.searchbyindividualCMBO.Size = New System.Drawing.Size(121, 21)
        Me.searchbyindividualCMBO.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Search by:"
        '
        'individualDGV
        '
        Me.individualDGV.AllowUserToAddRows = False
        Me.individualDGV.AllowUserToDeleteRows = False
        Me.individualDGV.AllowUserToResizeColumns = False
        Me.individualDGV.AllowUserToResizeRows = False
        Me.individualDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.individualDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.individualDGV.Location = New System.Drawing.Point(149, 54)
        Me.individualDGV.MultiSelect = False
        Me.individualDGV.Name = "individualDGV"
        Me.individualDGV.ReadOnly = True
        Me.individualDGV.RowHeadersVisible = False
        Me.individualDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.individualDGV.Size = New System.Drawing.Size(758, 463)
        Me.individualDGV.TabIndex = 0
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'courseGB
        '
        Me.courseGB.Controls.Add(Me.yrlvlCMBO)
        Me.courseGB.Controls.Add(Me.semCMBO)
        Me.courseGB.Controls.Add(Me.Label4)
        Me.courseGB.Controls.Add(Me.searchprintCMD)
        Me.courseGB.Controls.Add(Me.Label8)
        Me.courseGB.Controls.Add(Me.sytoLBL)
        Me.courseGB.Controls.Add(Me.courseCMBO)
        Me.courseGB.Controls.Add(Me.Label3)
        Me.courseGB.Controls.Add(Me.syfromCMBO)
        Me.courseGB.Controls.Add(Me.CrystalReportViewer1)
        Me.courseGB.Controls.Add(Me.Label7)
        Me.courseGB.Controls.Add(Me.Label5)
        Me.courseGB.Controls.Add(Me.Label6)
        Me.courseGB.Location = New System.Drawing.Point(12, 114)
        Me.courseGB.Name = "courseGB"
        Me.courseGB.Size = New System.Drawing.Size(913, 523)
        Me.courseGB.TabIndex = 3
        Me.courseGB.TabStop = False
        '
        'yrlvlCMBO
        '
        Me.yrlvlCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yrlvlCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.yrlvlCMBO.FormattingEnabled = True
        Me.yrlvlCMBO.Location = New System.Drawing.Point(224, 13)
        Me.yrlvlCMBO.Name = "yrlvlCMBO"
        Me.yrlvlCMBO.Size = New System.Drawing.Size(60, 21)
        Me.yrlvlCMBO.TabIndex = 14
        '
        'semCMBO
        '
        Me.semCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.semCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.semCMBO.FormattingEnabled = True
        Me.semCMBO.Location = New System.Drawing.Point(552, 14)
        Me.semCMBO.Name = "semCMBO"
        Me.semCMBO.Size = New System.Drawing.Size(60, 21)
        Me.semCMBO.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(492, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Semester:"
        '
        'searchprintCMD
        '
        Me.searchprintCMD.FlatAppearance.BorderSize = 0
        Me.searchprintCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchprintCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_search
        Me.searchprintCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.searchprintCMD.Location = New System.Drawing.Point(617, 14)
        Me.searchprintCMD.Name = "searchprintCMD"
        Me.searchprintCMD.Size = New System.Drawing.Size(81, 23)
        Me.searchprintCMD.TabIndex = 4
        Me.searchprintCMD.Text = "     Search"
        Me.searchprintCMD.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(157, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Year Level:"
        '
        'sytoLBL
        '
        Me.sytoLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sytoLBL.Location = New System.Drawing.Point(434, 14)
        Me.sytoLBL.Name = "sytoLBL"
        Me.sytoLBL.Size = New System.Drawing.Size(50, 21)
        Me.sytoLBL.TabIndex = 12
        Me.sytoLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'courseCMBO
        '
        Me.courseCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.courseCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.courseCMBO.FormattingEnabled = True
        Me.courseCMBO.Location = New System.Drawing.Point(55, 13)
        Me.courseCMBO.Name = "courseCMBO"
        Me.courseCMBO.Size = New System.Drawing.Size(95, 21)
        Me.courseCMBO.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Course:"
        '
        'syfromCMBO
        '
        Me.syfromCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.syfromCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.syfromCMBO.FormattingEnabled = True
        Me.syfromCMBO.Location = New System.Drawing.Point(362, 14)
        Me.syfromCMBO.Name = "syfromCMBO"
        Me.syfromCMBO.Size = New System.Drawing.Size(66, 21)
        Me.syfromCMBO.TabIndex = 11
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(6, 54)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(901, 463)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(290, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "School Year:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(382, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "From"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(451, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "To"
        '
        'closeCMD
        '
        Me.closeCMD.BackColor = System.Drawing.Color.Transparent
        Me.closeCMD.FlatAppearance.BorderSize = 0
        Me.closeCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeCMD.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.closeCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_close
        Me.closeCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closeCMD.Location = New System.Drawing.Point(897, 1)
        Me.closeCMD.Name = "closeCMD"
        Me.closeCMD.Size = New System.Drawing.Size(41, 38)
        Me.closeCMD.TabIndex = 17
        Me.closeCMD.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(1094, 7)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 30)
        Me.ListBox1.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1220, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Search by:"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(1094, 49)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 30)
        Me.ListBox2.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1136, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "total"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(941, 80)
        Me.Panel1.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.print_student_banner
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(941, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'printstudrecordfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(941, 648)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.closeCMD)
        Me.Controls.Add(Me.courseGB)
        Me.Controls.Add(Me.individualGB)
        Me.Controls.Add(Me.printbyCMBO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "printstudrecordfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "printstudrecordfrm"
        Me.individualGB.ResumeLayout(False)
        Me.individualGB.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toprintpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.individualDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.courseGB.ResumeLayout(False)
        Me.courseGB.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents printbyCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents individualGB As System.Windows.Forms.GroupBox
    Friend WithEvents individualDGV As System.Windows.Forms.DataGridView
    Friend WithEvents printindivudalCMD As System.Windows.Forms.Button
    Friend WithEvents previewindividualCMD As System.Windows.Forms.Button
    Friend WithEvents individualsearchbarTXT As System.Windows.Forms.TextBox
    Friend WithEvents searchbyindividualCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents toprintpb As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents courseGB As System.Windows.Forms.GroupBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents courseCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents semCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents syfromCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents searchprintCMD As System.Windows.Forms.Button
    Friend WithEvents crystalReport11 As StudentInformationSystem.CrystalReport1
    Friend WithEvents sytoLBL As System.Windows.Forms.Label
    Friend WithEvents yrlvlCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents closeCMD As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
