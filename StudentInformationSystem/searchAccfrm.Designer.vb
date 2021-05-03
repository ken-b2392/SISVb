<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchAccfrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.searchbyCMBO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.updateaccCMD = New System.Windows.Forms.Button()
        Me.backCMD = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.printCMD = New System.Windows.Forms.Button()
        Me.deleteAccRecCMD = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.clearPB = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.refreshPB = New System.Windows.Forms.PictureBox()
        Me.schoolAdminAccDGV = New System.Windows.Forms.DataGridView()
        Me.searchBarTXT = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.clearPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.refreshPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schoolAdminAccDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(819, 100)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.search_accounts_banner
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(819, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'searchbyCMBO
        '
        Me.searchbyCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.searchbyCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchbyCMBO.FormattingEnabled = True
        Me.searchbyCMBO.Location = New System.Drawing.Point(85, 20)
        Me.searchbyCMBO.Name = "searchbyCMBO"
        Me.searchbyCMBO.Size = New System.Drawing.Size(121, 26)
        Me.searchbyCMBO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search by:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.updateaccCMD)
        Me.Panel2.Controls.Add(Me.backCMD)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.printCMD)
        Me.Panel2.Controls.Add(Me.deleteAccRecCMD)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(209, 435)
        Me.Panel2.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Navy
        Me.Panel7.Location = New System.Drawing.Point(9, 138)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 3)
        Me.Panel7.TabIndex = 4
        '
        'updateaccCMD
        '
        Me.updateaccCMD.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.updateaccCMD.FlatAppearance.BorderSize = 0
        Me.updateaccCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateaccCMD.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateaccCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_update_db_logo2
        Me.updateaccCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.updateaccCMD.Location = New System.Drawing.Point(9, 80)
        Me.updateaccCMD.Name = "updateaccCMD"
        Me.updateaccCMD.Size = New System.Drawing.Size(197, 53)
        Me.updateaccCMD.TabIndex = 6
        Me.updateaccCMD.Text = "&Update"
        Me.updateaccCMD.UseVisualStyleBackColor = False
        '
        'backCMD
        '
        Me.backCMD.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.backCMD.FlatAppearance.BorderSize = 0
        Me.backCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backCMD.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.BACK_ARROW_ICO
        Me.backCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.backCMD.Location = New System.Drawing.Point(9, 215)
        Me.backCMD.Name = "backCMD"
        Me.backCMD.Size = New System.Drawing.Size(197, 53)
        Me.backCMD.TabIndex = 5
        Me.backCMD.Text = "&Back"
        Me.backCMD.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Navy
        Me.Panel5.Location = New System.Drawing.Point(9, 206)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 3)
        Me.Panel5.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Location = New System.Drawing.Point(9, 74)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 3)
        Me.Panel4.TabIndex = 3
        '
        'printCMD
        '
        Me.printCMD.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.printCMD.FlatAppearance.BorderSize = 0
        Me.printCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printCMD.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.print_ICO
        Me.printCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.printCMD.Location = New System.Drawing.Point(9, 147)
        Me.printCMD.Name = "printCMD"
        Me.printCMD.Size = New System.Drawing.Size(197, 53)
        Me.printCMD.TabIndex = 4
        Me.printCMD.Text = "&Print"
        Me.printCMD.UseVisualStyleBackColor = False
        '
        'deleteAccRecCMD
        '
        Me.deleteAccRecCMD.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.deleteAccRecCMD.FlatAppearance.BorderSize = 0
        Me.deleteAccRecCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteAccRecCMD.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteAccRecCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.delete_ICO
        Me.deleteAccRecCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deleteAccRecCMD.Location = New System.Drawing.Point(9, 16)
        Me.deleteAccRecCMD.Name = "deleteAccRecCMD"
        Me.deleteAccRecCMD.Size = New System.Drawing.Size(197, 53)
        Me.deleteAccRecCMD.TabIndex = 3
        Me.deleteAccRecCMD.Text = "&Delete"
        Me.deleteAccRecCMD.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.schoolAdminAccDGV)
        Me.GroupBox1.Controls.Add(Me.searchBarTXT)
        Me.GroupBox1.Controls.Add(Me.searchbyCMBO)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(215, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 422)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.clearPB)
        Me.Panel6.Location = New System.Drawing.Point(495, 22)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(34, 23)
        Me.Panel6.TabIndex = 6
        '
        'clearPB
        '
        Me.clearPB.Image = Global.StudentInformationSystem.My.Resources.Resources.CLEAR
        Me.clearPB.Location = New System.Drawing.Point(4, 3)
        Me.clearPB.Name = "clearPB"
        Me.clearPB.Size = New System.Drawing.Size(25, 15)
        Me.clearPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.clearPB.TabIndex = 4
        Me.clearPB.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.refreshPB)
        Me.Panel3.Location = New System.Drawing.Point(561, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(25, 25)
        Me.Panel3.TabIndex = 6
        '
        'refreshPB
        '
        Me.refreshPB.Image = Global.StudentInformationSystem.My.Resources.Resources.refresh_or_update
        Me.refreshPB.Location = New System.Drawing.Point(6, 6)
        Me.refreshPB.Name = "refreshPB"
        Me.refreshPB.Size = New System.Drawing.Size(15, 15)
        Me.refreshPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.refreshPB.TabIndex = 5
        Me.refreshPB.TabStop = False
        '
        'schoolAdminAccDGV
        '
        Me.schoolAdminAccDGV.AllowUserToAddRows = False
        Me.schoolAdminAccDGV.AllowUserToDeleteRows = False
        Me.schoolAdminAccDGV.AllowUserToResizeColumns = False
        Me.schoolAdminAccDGV.AllowUserToResizeRows = False
        Me.schoolAdminAccDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.schoolAdminAccDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.schoolAdminAccDGV.Location = New System.Drawing.Point(9, 51)
        Me.schoolAdminAccDGV.MultiSelect = False
        Me.schoolAdminAccDGV.Name = "schoolAdminAccDGV"
        Me.schoolAdminAccDGV.ReadOnly = True
        Me.schoolAdminAccDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.schoolAdminAccDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.schoolAdminAccDGV.Size = New System.Drawing.Size(578, 365)
        Me.schoolAdminAccDGV.TabIndex = 3
        '
        'searchBarTXT
        '
        Me.searchBarTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchBarTXT.Location = New System.Drawing.Point(212, 23)
        Me.searchBarTXT.Name = "searchBarTXT"
        Me.searchBarTXT.Size = New System.Drawing.Size(282, 19)
        Me.searchBarTXT.TabIndex = 2
        '
        'searchAccfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(819, 535)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "searchAccfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "searchAccfrm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.clearPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.refreshPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schoolAdminAccDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents backCMD As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents deleteAccRecCMD As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents searchbyCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents printCMD As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents clearPB As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents refreshPB As System.Windows.Forms.PictureBox
    Friend WithEvents schoolAdminAccDGV As System.Windows.Forms.DataGridView
    Friend WithEvents searchBarTXT As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents updateaccCMD As System.Windows.Forms.Button
End Class
