<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateschooladminaccfrm
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
        Me.scsadnewusernTXT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.scsaddconfirmPassTXT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.updatescsAdCMD = New System.Windows.Forms.Button()
        Me.scsadnewPassTXT = New System.Windows.Forms.TextBox()
        Me.scsadcurrentpassTXT = New System.Windows.Forms.TextBox()
        Me.scadcurUsernTXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.incorrectPB = New System.Windows.Forms.PictureBox()
        Me.checkpassPB = New System.Windows.Forms.PictureBox()
        Me.closeCMD = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.incorrectPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkpassPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.closeCMD)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 100)
        Me.Panel1.TabIndex = 0
        '
        'scsadnewusernTXT
        '
        Me.scsadnewusernTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.scsadnewusernTXT.Location = New System.Drawing.Point(233, 204)
        Me.scsadnewusernTXT.Name = "scsadnewusernTXT"
        Me.scsadnewusernTXT.Size = New System.Drawing.Size(173, 13)
        Me.scsadnewusernTXT.TabIndex = 54
        Me.scsadnewusernTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(110, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Type in new username:"
        '
        'scsaddconfirmPassTXT
        '
        Me.scsaddconfirmPassTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.scsaddconfirmPassTXT.Location = New System.Drawing.Point(233, 255)
        Me.scsaddconfirmPassTXT.Name = "scsaddconfirmPassTXT"
        Me.scsaddconfirmPassTXT.Size = New System.Drawing.Size(173, 13)
        Me.scsaddconfirmPassTXT.TabIndex = 52
        Me.scsaddconfirmPassTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.scsaddconfirmPassTXT.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Confirm password:"
        '
        'updatescsAdCMD
        '
        Me.updatescsAdCMD.BackColor = System.Drawing.Color.SlateBlue
        Me.updatescsAdCMD.FlatAppearance.BorderSize = 0
        Me.updatescsAdCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updatescsAdCMD.Location = New System.Drawing.Point(233, 280)
        Me.updatescsAdCMD.Name = "updatescsAdCMD"
        Me.updatescsAdCMD.Size = New System.Drawing.Size(173, 26)
        Me.updatescsAdCMD.TabIndex = 41
        Me.updatescsAdCMD.Text = "&Update School Admin"
        Me.updatescsAdCMD.UseVisualStyleBackColor = False
        '
        'scsadnewPassTXT
        '
        Me.scsadnewPassTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.scsadnewPassTXT.Location = New System.Drawing.Point(233, 230)
        Me.scsadnewPassTXT.Name = "scsadnewPassTXT"
        Me.scsadnewPassTXT.Size = New System.Drawing.Size(173, 13)
        Me.scsadnewPassTXT.TabIndex = 48
        Me.scsadnewPassTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.scsadnewPassTXT.UseSystemPasswordChar = True
        '
        'scsadcurrentpassTXT
        '
        Me.scsadcurrentpassTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.scsadcurrentpassTXT.Location = New System.Drawing.Point(233, 179)
        Me.scsadcurrentpassTXT.Name = "scsadcurrentpassTXT"
        Me.scsadcurrentpassTXT.ReadOnly = True
        Me.scsadcurrentpassTXT.Size = New System.Drawing.Size(173, 13)
        Me.scsadcurrentpassTXT.TabIndex = 47
        Me.scsadcurrentpassTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.scsadcurrentpassTXT.UseSystemPasswordChar = True
        '
        'scadcurUsernTXT
        '
        Me.scadcurUsernTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.scadcurUsernTXT.Location = New System.Drawing.Point(233, 154)
        Me.scadcurUsernTXT.Name = "scadcurUsernTXT"
        Me.scadcurUsernTXT.ReadOnly = True
        Me.scadcurUsernTXT.Size = New System.Drawing.Size(173, 13)
        Me.scadcurUsernTXT.TabIndex = 46
        Me.scadcurUsernTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Type in new password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Current password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Current username:"
        '
        'incorrectPB
        '
        Me.incorrectPB.Image = Global.StudentInformationSystem.My.Resources.Resources.incorrect
        Me.incorrectPB.Location = New System.Drawing.Point(409, 256)
        Me.incorrectPB.Name = "incorrectPB"
        Me.incorrectPB.Size = New System.Drawing.Size(19, 19)
        Me.incorrectPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.incorrectPB.TabIndex = 50
        Me.incorrectPB.TabStop = False
        '
        'checkpassPB
        '
        Me.checkpassPB.Image = Global.StudentInformationSystem.My.Resources.Resources.correctpass
        Me.checkpassPB.Location = New System.Drawing.Point(409, 256)
        Me.checkpassPB.Name = "checkpassPB"
        Me.checkpassPB.Size = New System.Drawing.Size(19, 19)
        Me.checkpassPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.checkpassPB.TabIndex = 44
        Me.checkpassPB.TabStop = False
        '
        'closeCMD
        '
        Me.closeCMD.BackColor = System.Drawing.Color.Transparent
        Me.closeCMD.FlatAppearance.BorderSize = 0
        Me.closeCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeCMD.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.closeCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_close
        Me.closeCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closeCMD.Location = New System.Drawing.Point(515, 2)
        Me.closeCMD.Name = "closeCMD"
        Me.closeCMD.Size = New System.Drawing.Size(41, 38)
        Me.closeCMD.TabIndex = 55
        Me.closeCMD.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.update_account_banner
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(558, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'updateschooladminaccfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(558, 363)
        Me.Controls.Add(Me.scsadnewusernTXT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.scsaddconfirmPassTXT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.incorrectPB)
        Me.Controls.Add(Me.updatescsAdCMD)
        Me.Controls.Add(Me.checkpassPB)
        Me.Controls.Add(Me.scsadnewPassTXT)
        Me.Controls.Add(Me.scsadcurrentpassTXT)
        Me.Controls.Add(Me.scadcurUsernTXT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "updateschooladminaccfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "updateschooladminaccfrm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.incorrectPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkpassPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents scsadnewusernTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents scsaddconfirmPassTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents incorrectPB As System.Windows.Forms.PictureBox
    Friend WithEvents updatescsAdCMD As System.Windows.Forms.Button
    Friend WithEvents checkpassPB As System.Windows.Forms.PictureBox
    Friend WithEvents scsadnewPassTXT As System.Windows.Forms.TextBox
    Friend WithEvents scsadcurrentpassTXT As System.Windows.Forms.TextBox
    Friend WithEvents scadcurUsernTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents closeCMD As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
