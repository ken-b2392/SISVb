<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sysAdminAccfrm
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
        Me.updateSysAdCMD = New System.Windows.Forms.Button()
        Me.sysadnewPassTXT = New System.Windows.Forms.TextBox()
        Me.sysadcurrentpassTXT = New System.Windows.Forms.TextBox()
        Me.sysadcurUsernTXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sysaddconfirmPassTXT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sysadnewusernTXT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.incorrectPB = New System.Windows.Forms.PictureBox()
        Me.backregAccCMD = New System.Windows.Forms.Button()
        Me.clearAccCMD = New System.Windows.Forms.Button()
        Me.checkpassPB = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.incorrectPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkpassPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 100)
        Me.Panel1.TabIndex = 23
        '
        'updateSysAdCMD
        '
        Me.updateSysAdCMD.BackColor = System.Drawing.Color.SlateBlue
        Me.updateSysAdCMD.FlatAppearance.BorderSize = 0
        Me.updateSysAdCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateSysAdCMD.Location = New System.Drawing.Point(271, 267)
        Me.updateSysAdCMD.Name = "updateSysAdCMD"
        Me.updateSysAdCMD.Size = New System.Drawing.Size(173, 26)
        Me.updateSysAdCMD.TabIndex = 24
        Me.updateSysAdCMD.Text = "&Update System Admin"
        Me.updateSysAdCMD.UseVisualStyleBackColor = False
        '
        'sysadnewPassTXT
        '
        Me.sysadnewPassTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sysadnewPassTXT.Location = New System.Drawing.Point(271, 217)
        Me.sysadnewPassTXT.Name = "sysadnewPassTXT"
        Me.sysadnewPassTXT.Size = New System.Drawing.Size(173, 19)
        Me.sysadnewPassTXT.TabIndex = 31
        Me.sysadnewPassTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.sysadnewPassTXT.UseSystemPasswordChar = True
        '
        'sysadcurrentpassTXT
        '
        Me.sysadcurrentpassTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sysadcurrentpassTXT.Location = New System.Drawing.Point(271, 166)
        Me.sysadcurrentpassTXT.Name = "sysadcurrentpassTXT"
        Me.sysadcurrentpassTXT.Size = New System.Drawing.Size(173, 19)
        Me.sysadcurrentpassTXT.TabIndex = 30
        Me.sysadcurrentpassTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.sysadcurrentpassTXT.UseSystemPasswordChar = True
        '
        'sysadcurUsernTXT
        '
        Me.sysadcurUsernTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sysadcurUsernTXT.Location = New System.Drawing.Point(271, 141)
        Me.sysadcurUsernTXT.Name = "sysadcurUsernTXT"
        Me.sysadcurUsernTXT.Size = New System.Drawing.Size(173, 19)
        Me.sysadcurUsernTXT.TabIndex = 29
        Me.sysadcurUsernTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 18)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Type in new password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 18)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Current password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Current username:"
        '
        'sysaddconfirmPassTXT
        '
        Me.sysaddconfirmPassTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sysaddconfirmPassTXT.Location = New System.Drawing.Point(271, 242)
        Me.sysaddconfirmPassTXT.Name = "sysaddconfirmPassTXT"
        Me.sysaddconfirmPassTXT.Size = New System.Drawing.Size(173, 19)
        Me.sysaddconfirmPassTXT.TabIndex = 38
        Me.sysaddconfirmPassTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.sysaddconfirmPassTXT.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(121, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 18)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Confirm password:"
        '
        'sysadnewusernTXT
        '
        Me.sysadnewusernTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sysadnewusernTXT.Location = New System.Drawing.Point(271, 191)
        Me.sysadnewusernTXT.Name = "sysadnewusernTXT"
        Me.sysadnewusernTXT.Size = New System.Drawing.Size(173, 19)
        Me.sysadnewusernTXT.TabIndex = 40
        Me.sysadnewusernTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 18)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Type in new username:"
        '
        'incorrectPB
        '
        Me.incorrectPB.Image = Global.StudentInformationSystem.My.Resources.Resources.incorrect
        Me.incorrectPB.Location = New System.Drawing.Point(447, 243)
        Me.incorrectPB.Name = "incorrectPB"
        Me.incorrectPB.Size = New System.Drawing.Size(19, 19)
        Me.incorrectPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.incorrectPB.TabIndex = 36
        Me.incorrectPB.TabStop = False
        '
        'backregAccCMD
        '
        Me.backregAccCMD.BackColor = System.Drawing.Color.SlateBlue
        Me.backregAccCMD.FlatAppearance.BorderSize = 0
        Me.backregAccCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backregAccCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.BACK_ARROW_ICO
        Me.backregAccCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.backregAccCMD.Location = New System.Drawing.Point(515, 360)
        Me.backregAccCMD.Name = "backregAccCMD"
        Me.backregAccCMD.Size = New System.Drawing.Size(102, 26)
        Me.backregAccCMD.TabIndex = 34
        Me.backregAccCMD.Text = "            &Back"
        Me.backregAccCMD.UseVisualStyleBackColor = False
        '
        'clearAccCMD
        '
        Me.clearAccCMD.BackColor = System.Drawing.Color.SlateBlue
        Me.clearAccCMD.FlatAppearance.BorderSize = 0
        Me.clearAccCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearAccCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.CLEAR_ico
        Me.clearAccCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clearAccCMD.Location = New System.Drawing.Point(271, 299)
        Me.clearAccCMD.Name = "clearAccCMD"
        Me.clearAccCMD.Size = New System.Drawing.Size(173, 26)
        Me.clearAccCMD.TabIndex = 33
        Me.clearAccCMD.Text = "&Clear"
        Me.clearAccCMD.UseVisualStyleBackColor = False
        '
        'checkpassPB
        '
        Me.checkpassPB.Image = Global.StudentInformationSystem.My.Resources.Resources.correctpass
        Me.checkpassPB.Location = New System.Drawing.Point(447, 243)
        Me.checkpassPB.Name = "checkpassPB"
        Me.checkpassPB.Size = New System.Drawing.Size(19, 19)
        Me.checkpassPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.checkpassPB.TabIndex = 27
        Me.checkpassPB.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.update_system_admin_banner
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(617, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'sysAdminAccfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(617, 387)
        Me.Controls.Add(Me.sysadnewusernTXT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sysaddconfirmPassTXT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.incorrectPB)
        Me.Controls.Add(Me.backregAccCMD)
        Me.Controls.Add(Me.clearAccCMD)
        Me.Controls.Add(Me.updateSysAdCMD)
        Me.Controls.Add(Me.checkpassPB)
        Me.Controls.Add(Me.sysadnewPassTXT)
        Me.Controls.Add(Me.sysadcurrentpassTXT)
        Me.Controls.Add(Me.sysadcurUsernTXT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "sysAdminAccfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sysAdminAccfrm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.incorrectPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkpassPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents incorrectPB As System.Windows.Forms.PictureBox
    Friend WithEvents backregAccCMD As System.Windows.Forms.Button
    Friend WithEvents clearAccCMD As System.Windows.Forms.Button
    Friend WithEvents updateSysAdCMD As System.Windows.Forms.Button
    Friend WithEvents checkpassPB As System.Windows.Forms.PictureBox
    Friend WithEvents sysadnewPassTXT As System.Windows.Forms.TextBox
    Friend WithEvents sysadcurrentpassTXT As System.Windows.Forms.TextBox
    Friend WithEvents sysadcurUsernTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sysaddconfirmPassTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents sysadnewusernTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
