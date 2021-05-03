<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addsubjectfrm
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
        Me.subjCodeTXT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.subjNameTXT = New System.Windows.Forms.TextBox()
        Me.subjnoUnitsTXT = New System.Windows.Forms.TextBox()
        Me.subjLecHrTXT = New System.Windows.Forms.TextBox()
        Me.subjLabHrTXT = New System.Windows.Forms.TextBox()
        Me.subjRoomTXT = New System.Windows.Forms.TextBox()
        Me.subjTotalHrLBL = New System.Windows.Forms.Label()
        Me.subjdayCMBO = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.displaysubjdgv = New System.Windows.Forms.DataGridView()
        Me.searchbarTXT = New System.Windows.Forms.TextBox()
        Me.searchbyCMBO = New System.Windows.Forms.ComboBox()
        Me.subjclearCMD = New System.Windows.Forms.Button()
        Me.subjUpdateCMD = New System.Windows.Forms.Button()
        Me.subjDeleteCMD = New System.Windows.Forms.Button()
        Me.subjsaveCMD = New System.Windows.Forms.Button()
        Me.closeCMD = New System.Windows.Forms.Button()
        Me.subjTFromPICKER = New System.Windows.Forms.DateTimePicker()
        Me.subjTToPICKER = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.semesterCMBO = New System.Windows.Forms.ComboBox()
        Me.yearlvlCMBO = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.roomlist = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.refreshPB = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.displaysubjdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(72, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subject code:"
        '
        'subjCodeTXT
        '
        Me.subjCodeTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.subjCodeTXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.subjCodeTXT.Location = New System.Drawing.Point(181, 170)
        Me.subjCodeTXT.Name = "subjCodeTXT"
        Me.subjCodeTXT.Size = New System.Drawing.Size(208, 19)
        Me.subjCodeTXT.TabIndex = 1
        Me.subjCodeTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(68, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Subject name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(83, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No. of Units:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(64, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total no. of hrs:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(15, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "No. of Hrs Laboratory:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(38, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "No. of Hrs Lecture:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(129, 384)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Time:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(97, 357)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Room No:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(82, 327)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 18)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Subject day:"
        '
        'subjNameTXT
        '
        Me.subjNameTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.subjNameTXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.subjNameTXT.Location = New System.Drawing.Point(181, 195)
        Me.subjNameTXT.Name = "subjNameTXT"
        Me.subjNameTXT.Size = New System.Drawing.Size(208, 19)
        Me.subjNameTXT.TabIndex = 2
        Me.subjNameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'subjnoUnitsTXT
        '
        Me.subjnoUnitsTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.subjnoUnitsTXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.subjnoUnitsTXT.Location = New System.Drawing.Point(181, 220)
        Me.subjnoUnitsTXT.MaxLength = 1
        Me.subjnoUnitsTXT.Name = "subjnoUnitsTXT"
        Me.subjnoUnitsTXT.Size = New System.Drawing.Size(208, 19)
        Me.subjnoUnitsTXT.TabIndex = 3
        Me.subjnoUnitsTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'subjLecHrTXT
        '
        Me.subjLecHrTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.subjLecHrTXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.subjLecHrTXT.Location = New System.Drawing.Point(181, 245)
        Me.subjLecHrTXT.MaxLength = 1
        Me.subjLecHrTXT.Name = "subjLecHrTXT"
        Me.subjLecHrTXT.Size = New System.Drawing.Size(208, 19)
        Me.subjLecHrTXT.TabIndex = 4
        Me.subjLecHrTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'subjLabHrTXT
        '
        Me.subjLabHrTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.subjLabHrTXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.subjLabHrTXT.Location = New System.Drawing.Point(181, 270)
        Me.subjLabHrTXT.MaxLength = 1
        Me.subjLabHrTXT.Name = "subjLabHrTXT"
        Me.subjLabHrTXT.Size = New System.Drawing.Size(208, 19)
        Me.subjLabHrTXT.TabIndex = 5
        Me.subjLabHrTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'subjRoomTXT
        '
        Me.subjRoomTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.subjRoomTXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.subjRoomTXT.Location = New System.Drawing.Point(181, 357)
        Me.subjRoomTXT.Name = "subjRoomTXT"
        Me.subjRoomTXT.Size = New System.Drawing.Size(208, 19)
        Me.subjRoomTXT.TabIndex = 7
        Me.subjRoomTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'subjTotalHrLBL
        '
        Me.subjTotalHrLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.subjTotalHrLBL.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.subjTotalHrLBL.Location = New System.Drawing.Point(181, 295)
        Me.subjTotalHrLBL.Name = "subjTotalHrLBL"
        Me.subjTotalHrLBL.Size = New System.Drawing.Size(208, 26)
        Me.subjTotalHrLBL.TabIndex = 25
        Me.subjTotalHrLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'subjdayCMBO
        '
        Me.subjdayCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subjdayCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subjdayCMBO.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.subjdayCMBO.FormattingEnabled = True
        Me.subjdayCMBO.Location = New System.Drawing.Point(181, 325)
        Me.subjdayCMBO.Name = "subjdayCMBO"
        Me.subjdayCMBO.Size = New System.Drawing.Size(208, 26)
        Me.subjdayCMBO.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.displaysubjdgv)
        Me.GroupBox1.Controls.Add(Me.searchbarTXT)
        Me.GroupBox1.Controls.Add(Me.searchbyCMBO)
        Me.GroupBox1.Location = New System.Drawing.Point(421, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(627, 317)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(3, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 18)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Search by:"
        '
        'displaysubjdgv
        '
        Me.displaysubjdgv.AllowUserToAddRows = False
        Me.displaysubjdgv.AllowUserToDeleteRows = False
        Me.displaysubjdgv.AllowUserToResizeColumns = False
        Me.displaysubjdgv.AllowUserToResizeRows = False
        Me.displaysubjdgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.displaysubjdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.displaysubjdgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.displaysubjdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.displaysubjdgv.Location = New System.Drawing.Point(6, 44)
        Me.displaysubjdgv.MultiSelect = False
        Me.displaysubjdgv.Name = "displaysubjdgv"
        Me.displaysubjdgv.ReadOnly = True
        Me.displaysubjdgv.RowHeadersVisible = False
        Me.displaysubjdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.displaysubjdgv.Size = New System.Drawing.Size(615, 267)
        Me.displaysubjdgv.TabIndex = 18
        '
        'searchbarTXT
        '
        Me.searchbarTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchbarTXT.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.searchbarTXT.Location = New System.Drawing.Point(220, 19)
        Me.searchbarTXT.Name = "searchbarTXT"
        Me.searchbarTXT.Size = New System.Drawing.Size(210, 19)
        Me.searchbarTXT.TabIndex = 22
        '
        'searchbyCMBO
        '
        Me.searchbyCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.searchbyCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchbyCMBO.FormattingEnabled = True
        Me.searchbyCMBO.Location = New System.Drawing.Point(91, 17)
        Me.searchbyCMBO.Name = "searchbyCMBO"
        Me.searchbyCMBO.Size = New System.Drawing.Size(123, 21)
        Me.searchbyCMBO.TabIndex = 21
        '
        'subjclearCMD
        '
        Me.subjclearCMD.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subjclearCMD.FlatAppearance.BorderSize = 0
        Me.subjclearCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subjclearCMD.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.subjclearCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.CLEAR_ico1
        Me.subjclearCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.subjclearCMD.Location = New System.Drawing.Point(637, 428)
        Me.subjclearCMD.Name = "subjclearCMD"
        Me.subjclearCMD.Size = New System.Drawing.Size(102, 43)
        Me.subjclearCMD.TabIndex = 13
        Me.subjclearCMD.Text = "       &Clear"
        Me.subjclearCMD.UseVisualStyleBackColor = False
        '
        'subjUpdateCMD
        '
        Me.subjUpdateCMD.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subjUpdateCMD.FlatAppearance.BorderSize = 0
        Me.subjUpdateCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subjUpdateCMD.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.subjUpdateCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_update_db_logo
        Me.subjUpdateCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.subjUpdateCMD.Location = New System.Drawing.Point(421, 428)
        Me.subjUpdateCMD.Name = "subjUpdateCMD"
        Me.subjUpdateCMD.Size = New System.Drawing.Size(102, 43)
        Me.subjUpdateCMD.TabIndex = 30
        Me.subjUpdateCMD.Text = "       &Update"
        Me.subjUpdateCMD.UseVisualStyleBackColor = False
        '
        'subjDeleteCMD
        '
        Me.subjDeleteCMD.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subjDeleteCMD.FlatAppearance.BorderSize = 0
        Me.subjDeleteCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subjDeleteCMD.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.subjDeleteCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_delete
        Me.subjDeleteCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.subjDeleteCMD.Location = New System.Drawing.Point(529, 428)
        Me.subjDeleteCMD.Name = "subjDeleteCMD"
        Me.subjDeleteCMD.Size = New System.Drawing.Size(102, 43)
        Me.subjDeleteCMD.TabIndex = 12
        Me.subjDeleteCMD.Text = "       &Delete"
        Me.subjDeleteCMD.UseVisualStyleBackColor = False
        '
        'subjsaveCMD
        '
        Me.subjsaveCMD.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subjsaveCMD.FlatAppearance.BorderSize = 0
        Me.subjsaveCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subjsaveCMD.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.subjsaveCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_save_logo
        Me.subjsaveCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.subjsaveCMD.Location = New System.Drawing.Point(313, 428)
        Me.subjsaveCMD.Name = "subjsaveCMD"
        Me.subjsaveCMD.Size = New System.Drawing.Size(102, 43)
        Me.subjsaveCMD.TabIndex = 11
        Me.subjsaveCMD.Text = "       &Save"
        Me.subjsaveCMD.UseVisualStyleBackColor = False
        '
        'closeCMD
        '
        Me.closeCMD.BackColor = System.Drawing.Color.Transparent
        Me.closeCMD.FlatAppearance.BorderSize = 0
        Me.closeCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeCMD.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.closeCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_close
        Me.closeCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closeCMD.Location = New System.Drawing.Point(1020, -2)
        Me.closeCMD.Name = "closeCMD"
        Me.closeCMD.Size = New System.Drawing.Size(41, 38)
        Me.closeCMD.TabIndex = 32
        Me.closeCMD.UseVisualStyleBackColor = False
        '
        'subjTFromPICKER
        '
        Me.subjTFromPICKER.CalendarFont = New System.Drawing.Font("Arial", 12.0!)
        Me.subjTFromPICKER.CustomFormat = "hh:mm tt"
        Me.subjTFromPICKER.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.subjTFromPICKER.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.subjTFromPICKER.Location = New System.Drawing.Point(181, 382)
        Me.subjTFromPICKER.Name = "subjTFromPICKER"
        Me.subjTFromPICKER.ShowUpDown = True
        Me.subjTFromPICKER.Size = New System.Drawing.Size(89, 26)
        Me.subjTFromPICKER.TabIndex = 8
        Me.subjTFromPICKER.Value = New Date(2020, 4, 27, 14, 55, 1, 0)
        '
        'subjTToPICKER
        '
        Me.subjTToPICKER.CustomFormat = "hh:mm tt"
        Me.subjTToPICKER.Enabled = False
        Me.subjTToPICKER.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.subjTToPICKER.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.subjTToPICKER.Location = New System.Drawing.Point(294, 382)
        Me.subjTToPICKER.Name = "subjTToPICKER"
        Me.subjTToPICKER.ShowUpDown = True
        Me.subjTToPICKER.Size = New System.Drawing.Size(95, 26)
        Me.subjTToPICKER.TabIndex = 9
        Me.subjTToPICKER.Value = New Date(2020, 4, 27, 14, 55, 1, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(275, 384)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 18)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(95, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 18)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Semester:"
        '
        'semesterCMBO
        '
        Me.semesterCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.semesterCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.semesterCMBO.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.semesterCMBO.FormattingEnabled = True
        Me.semesterCMBO.Location = New System.Drawing.Point(181, 138)
        Me.semesterCMBO.Name = "semesterCMBO"
        Me.semesterCMBO.Size = New System.Drawing.Size(208, 26)
        Me.semesterCMBO.TabIndex = 45
        '
        'yearlvlCMBO
        '
        Me.yearlvlCMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yearlvlCMBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.yearlvlCMBO.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.yearlvlCMBO.FormattingEnabled = True
        Me.yearlvlCMBO.Location = New System.Drawing.Point(181, 106)
        Me.yearlvlCMBO.Name = "yearlvlCMBO"
        Me.yearlvlCMBO.Size = New System.Drawing.Size(208, 26)
        Me.yearlvlCMBO.TabIndex = 47
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(91, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 18)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Year Level:"
        '
        'roomlist
        '
        Me.roomlist.FormattingEnabled = True
        Me.roomlist.Location = New System.Drawing.Point(1090, 170)
        Me.roomlist.Name = "roomlist"
        Me.roomlist.Size = New System.Drawing.Size(120, 95)
        Me.roomlist.TabIndex = 48
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(1090, 295)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 49
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(395, 248)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 50
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(395, 274)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton2.TabIndex = 51
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 85)
        Me.Panel1.TabIndex = 52
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.add_subject_details_banner
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1061, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'refreshPB
        '
        Me.refreshPB.Image = Global.StudentInformationSystem.My.Resources.Resources.refresh_or_update
        Me.refreshPB.Location = New System.Drawing.Point(395, 110)
        Me.refreshPB.Name = "refreshPB"
        Me.refreshPB.Size = New System.Drawing.Size(20, 20)
        Me.refreshPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.refreshPB.TabIndex = 53
        Me.refreshPB.TabStop = False
        '
        'addsubjectfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1061, 498)
        Me.Controls.Add(Me.refreshPB)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.roomlist)
        Me.Controls.Add(Me.yearlvlCMBO)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.semesterCMBO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.subjTToPICKER)
        Me.Controls.Add(Me.subjTFromPICKER)
        Me.Controls.Add(Me.closeCMD)
        Me.Controls.Add(Me.subjclearCMD)
        Me.Controls.Add(Me.subjUpdateCMD)
        Me.Controls.Add(Me.subjDeleteCMD)
        Me.Controls.Add(Me.subjsaveCMD)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.subjdayCMBO)
        Me.Controls.Add(Me.subjTotalHrLBL)
        Me.Controls.Add(Me.subjRoomTXT)
        Me.Controls.Add(Me.subjLabHrTXT)
        Me.Controls.Add(Me.subjLecHrTXT)
        Me.Controls.Add(Me.subjnoUnitsTXT)
        Me.Controls.Add(Me.subjNameTXT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.subjCodeTXT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addsubjectfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addsubjectfrm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.displaysubjdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refreshPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents subjCodeTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents subjNameTXT As System.Windows.Forms.TextBox
    Friend WithEvents subjnoUnitsTXT As System.Windows.Forms.TextBox
    Friend WithEvents subjLecHrTXT As System.Windows.Forms.TextBox
    Friend WithEvents subjLabHrTXT As System.Windows.Forms.TextBox
    Friend WithEvents subjRoomTXT As System.Windows.Forms.TextBox
    Friend WithEvents subjTotalHrLBL As System.Windows.Forms.Label
    Friend WithEvents subjdayCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents displaysubjdgv As System.Windows.Forms.DataGridView
    Friend WithEvents searchbarTXT As System.Windows.Forms.TextBox
    Friend WithEvents searchbyCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents subjclearCMD As System.Windows.Forms.Button
    Friend WithEvents subjUpdateCMD As System.Windows.Forms.Button
    Friend WithEvents subjDeleteCMD As System.Windows.Forms.Button
    Friend WithEvents subjsaveCMD As System.Windows.Forms.Button
    Friend WithEvents closeCMD As System.Windows.Forms.Button
    Friend WithEvents subjTFromPICKER As System.Windows.Forms.DateTimePicker
    Friend WithEvents subjTToPICKER As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents semesterCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents yearlvlCMBO As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents roomlist As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents refreshPB As System.Windows.Forms.PictureBox
End Class
