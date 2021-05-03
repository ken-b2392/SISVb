<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchstudfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(searchstudfrm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.refreshPB = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.backCMD = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.studpicPB = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.previewCMD = New System.Windows.Forms.Button()
        Me.printCMD = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.clearPB = New System.Windows.Forms.PictureBox()
        Me.displayinfoDGV = New System.Windows.Forms.DataGridView()
        Me.searchBarTXT = New System.Windows.Forms.TextBox()
        Me.searchbyCMBO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.refreshPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.studpicPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.clearPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.displayinfoDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1278, 100)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.refreshPB)
        Me.Panel3.Location = New System.Drawing.Point(1031, 25)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(25, 25)
        Me.Panel3.TabIndex = 6
        '
        'refreshPB
        '
        Me.refreshPB.Image = Global.StudentInformationSystem.My.Resources.Resources.refresh_or_update
        Me.refreshPB.Location = New System.Drawing.Point(5, 6)
        Me.refreshPB.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.refreshPB.Name = "refreshPB"
        Me.refreshPB.Size = New System.Drawing.Size(14, 14)
        Me.refreshPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.refreshPB.TabIndex = 5
        Me.refreshPB.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.backCMD)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.studpicPB)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.previewCMD)
        Me.Panel2.Controls.Add(Me.printCMD)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 440)
        Me.Panel2.TabIndex = 1
        '
        'backCMD
        '
        Me.backCMD.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.backCMD.FlatAppearance.BorderSize = 0
        Me.backCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backCMD.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.BACK_ARROW_ICO
        Me.backCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.backCMD.Location = New System.Drawing.Point(0, 319)
        Me.backCMD.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.backCMD.Name = "backCMD"
        Me.backCMD.Size = New System.Drawing.Size(196, 53)
        Me.backCMD.TabIndex = 5
        Me.backCMD.Text = "    &Back"
        Me.backCMD.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Location = New System.Drawing.Point(0, 178)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 2)
        Me.Panel4.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Navy
        Me.Panel5.Location = New System.Drawing.Point(0, 310)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 2)
        Me.Panel5.TabIndex = 4
        '
        'studpicPB
        '
        Me.studpicPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.studpicPB.Location = New System.Drawing.Point(7, 29)
        Me.studpicPB.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.studpicPB.Name = "studpicPB"
        Me.studpicPB.Size = New System.Drawing.Size(186, 138)
        Me.studpicPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.studpicPB.TabIndex = 2
        Me.studpicPB.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Navy
        Me.Panel7.Location = New System.Drawing.Point(0, 244)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 2)
        Me.Panel7.TabIndex = 6
        '
        'previewCMD
        '
        Me.previewCMD.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.previewCMD.FlatAppearance.BorderSize = 0
        Me.previewCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.previewCMD.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previewCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_preview_2
        Me.previewCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.previewCMD.Location = New System.Drawing.Point(0, 185)
        Me.previewCMD.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.previewCMD.Name = "previewCMD"
        Me.previewCMD.Size = New System.Drawing.Size(196, 53)
        Me.previewCMD.TabIndex = 4
        Me.previewCMD.Text = "   &Preview"
        Me.previewCMD.UseVisualStyleBackColor = False
        '
        'printCMD
        '
        Me.printCMD.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.printCMD.FlatAppearance.BorderSize = 0
        Me.printCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printCMD.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.print_ICO
        Me.printCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.printCMD.Location = New System.Drawing.Point(0, 251)
        Me.printCMD.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.printCMD.Name = "printCMD"
        Me.printCMD.Size = New System.Drawing.Size(196, 53)
        Me.printCMD.TabIndex = 7
        Me.printCMD.Text = "   &Print"
        Me.printCMD.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.displayinfoDGV)
        Me.GroupBox1.Controls.Add(Me.searchBarTXT)
        Me.GroupBox1.Controls.Add(Me.searchbyCMBO)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(205, 106)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1062, 423)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.clearPB)
        Me.Panel6.Location = New System.Drawing.Point(529, 22)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(34, 23)
        Me.Panel6.TabIndex = 6
        '
        'clearPB
        '
        Me.clearPB.Image = Global.StudentInformationSystem.My.Resources.Resources.CLEAR
        Me.clearPB.Location = New System.Drawing.Point(4, 2)
        Me.clearPB.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.clearPB.Name = "clearPB"
        Me.clearPB.Size = New System.Drawing.Size(25, 14)
        Me.clearPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.clearPB.TabIndex = 4
        Me.clearPB.TabStop = False
        '
        'displayinfoDGV
        '
        Me.displayinfoDGV.AllowUserToAddRows = False
        Me.displayinfoDGV.AllowUserToDeleteRows = False
        Me.displayinfoDGV.AllowUserToResizeColumns = False
        Me.displayinfoDGV.AllowUserToResizeRows = False
        Me.displayinfoDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.displayinfoDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.displayinfoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.displayinfoDGV.Location = New System.Drawing.Point(9, 50)
        Me.displayinfoDGV.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.displayinfoDGV.MultiSelect = False
        Me.displayinfoDGV.Name = "displayinfoDGV"
        Me.displayinfoDGV.ReadOnly = True
        Me.displayinfoDGV.RowHeadersVisible = False
        Me.displayinfoDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.displayinfoDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.displayinfoDGV.Size = New System.Drawing.Size(1048, 365)
        Me.displayinfoDGV.TabIndex = 3
        '
        'searchBarTXT
        '
        Me.searchBarTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchBarTXT.Location = New System.Drawing.Point(212, 23)
        Me.searchBarTXT.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.searchBarTXT.Name = "searchBarTXT"
        Me.searchBarTXT.Size = New System.Drawing.Size(317, 19)
        Me.searchBarTXT.TabIndex = 2
        '
        'searchbyCMBO
        '
        Me.searchbyCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.searchbyCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchbyCMBO.FormattingEnabled = True
        Me.searchbyCMBO.Location = New System.Drawing.Point(85, 19)
        Me.searchbyCMBO.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.searchbyCMBO.Name = "searchbyCMBO"
        Me.searchbyCMBO.Size = New System.Drawing.Size(121, 26)
        Me.searchbyCMBO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search by:"
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
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
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
        Me.DataGridView1.Location = New System.Drawing.Point(1342, 233)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(784, 267)
        Me.DataGridView1.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(646, 663)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 18)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "total"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 18
        Me.ListBox2.Location = New System.Drawing.Point(604, 618)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 22)
        Me.ListBox2.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(730, 586)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 18)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Search by:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(604, 576)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 22)
        Me.ListBox1.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.search_student_banner
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1278, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'searchstudfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1278, 540)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "searchstudfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "searchstudfrm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.refreshPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.studpicPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.clearPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.displayinfoDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents studpicPB As System.Windows.Forms.PictureBox
    Friend WithEvents previewCMD As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents backCMD As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents searchbyCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents searchBarTXT As System.Windows.Forms.TextBox
    Friend WithEvents displayinfoDGV As System.Windows.Forms.DataGridView
    Friend WithEvents clearPB As System.Windows.Forms.PictureBox
    Friend WithEvents refreshPB As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents printCMD As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
