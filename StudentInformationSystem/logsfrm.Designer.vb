<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logsfrm
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.usernidnumTXT = New System.Windows.Forms.TextBox()
        Me.searchbyCMBO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchprintCMD = New System.Windows.Forms.Button()
        Me.backCMD = New System.Windows.Forms.Button()
        Me.crystalReport21 = New StudentInformationSystem.CrystalReport2()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 142)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(925, 404)
        Me.CrystalReportViewer1.TabIndex = 7
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(949, 100)
        Me.Panel1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(484, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Date Logged in:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Username/ID Number:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(573, 116)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(105, 20)
        Me.DateTimePicker1.TabIndex = 8
        Me.DateTimePicker1.Value = New Date(2020, 6, 15, 0, 0, 0, 0)
        '
        'usernidnumTXT
        '
        Me.usernidnumTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usernidnumTXT.Location = New System.Drawing.Point(328, 120)
        Me.usernidnumTXT.Name = "usernidnumTXT"
        Me.usernidnumTXT.Size = New System.Drawing.Size(150, 13)
        Me.usernidnumTXT.TabIndex = 7
        '
        'searchbyCMBO
        '
        Me.searchbyCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.searchbyCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchbyCMBO.FormattingEnabled = True
        Me.searchbyCMBO.Location = New System.Drawing.Point(81, 116)
        Me.searchbyCMBO.Name = "searchbyCMBO"
        Me.searchbyCMBO.Size = New System.Drawing.Size(121, 21)
        Me.searchbyCMBO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search by:"
        '
        'searchprintCMD
        '
        Me.searchprintCMD.FlatAppearance.BorderSize = 0
        Me.searchprintCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchprintCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_search
        Me.searchprintCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.searchprintCMD.Location = New System.Drawing.Point(684, 115)
        Me.searchprintCMD.Name = "searchprintCMD"
        Me.searchprintCMD.Size = New System.Drawing.Size(81, 23)
        Me.searchprintCMD.TabIndex = 14
        Me.searchprintCMD.Text = "     Search"
        Me.searchprintCMD.UseVisualStyleBackColor = True
        '
        'backCMD
        '
        Me.backCMD.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.backCMD.FlatAppearance.BorderSize = 0
        Me.backCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backCMD.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.backCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_back_arrow
        Me.backCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.backCMD.Location = New System.Drawing.Point(851, 552)
        Me.backCMD.Name = "backCMD"
        Me.backCMD.Size = New System.Drawing.Size(86, 30)
        Me.backCMD.TabIndex = 15
        Me.backCMD.Text = "        &Back"
        Me.backCMD.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.account_logs_banner
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(949, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'logsfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(949, 594)
        Me.Controls.Add(Me.backCMD)
        Me.Controls.Add(Me.searchprintCMD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.searchbyCMBO)
        Me.Controls.Add(Me.usernidnumTXT)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "logsfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "logsfrm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents usernidnumTXT As System.Windows.Forms.TextBox
    Friend WithEvents searchbyCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents crystalReport21 As StudentInformationSystem.CrystalReport2
    Friend WithEvents searchprintCMD As System.Windows.Forms.Button
    Friend WithEvents backCMD As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
