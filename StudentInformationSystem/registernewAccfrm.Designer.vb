<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registernewAccfrm
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.incorrectPB = New System.Windows.Forms.PictureBox()
        Me.controlnumLBL = New System.Windows.Forms.Label()
        Me.backregAccCMD = New System.Windows.Forms.Button()
        Me.clearAccCMD = New System.Windows.Forms.Button()
        Me.regAccCMD = New System.Windows.Forms.Button()
        Me.checkpassPB = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.regconfirmpassTXT = New System.Windows.Forms.TextBox()
        Me.regpassTXT = New System.Windows.Forms.TextBox()
        Me.reguserTXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.incorrectPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkpassPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.incorrectPB)
        Me.Panel2.Controls.Add(Me.controlnumLBL)
        Me.Panel2.Controls.Add(Me.backregAccCMD)
        Me.Panel2.Controls.Add(Me.clearAccCMD)
        Me.Panel2.Controls.Add(Me.regAccCMD)
        Me.Panel2.Controls.Add(Me.checkpassPB)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.regconfirmpassTXT)
        Me.Panel2.Controls.Add(Me.regpassTXT)
        Me.Panel2.Controls.Add(Me.reguserTXT)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 106)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(509, 208)
        Me.Panel2.TabIndex = 1
        '
        'incorrectPB
        '
        Me.incorrectPB.Image = Global.StudentInformationSystem.My.Resources.Resources.incorrect
        Me.incorrectPB.Location = New System.Drawing.Point(387, 89)
        Me.incorrectPB.Name = "incorrectPB"
        Me.incorrectPB.Size = New System.Drawing.Size(19, 19)
        Me.incorrectPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.incorrectPB.TabIndex = 11
        Me.incorrectPB.TabStop = False
        '
        'controlnumLBL
        '
        Me.controlnumLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.controlnumLBL.Location = New System.Drawing.Point(211, 14)
        Me.controlnumLBL.Name = "controlnumLBL"
        Me.controlnumLBL.Size = New System.Drawing.Size(173, 19)
        Me.controlnumLBL.TabIndex = 10
        Me.controlnumLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'backregAccCMD
        '
        Me.backregAccCMD.BackColor = System.Drawing.Color.SlateBlue
        Me.backregAccCMD.FlatAppearance.BorderSize = 0
        Me.backregAccCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backregAccCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.BACK_ARROW_ICO
        Me.backregAccCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.backregAccCMD.Location = New System.Drawing.Point(151, 175)
        Me.backregAccCMD.Name = "backregAccCMD"
        Me.backregAccCMD.Size = New System.Drawing.Size(173, 26)
        Me.backregAccCMD.TabIndex = 9
        Me.backregAccCMD.Text = "&Back"
        Me.backregAccCMD.UseVisualStyleBackColor = False
        '
        'clearAccCMD
        '
        Me.clearAccCMD.BackColor = System.Drawing.Color.SlateBlue
        Me.clearAccCMD.FlatAppearance.BorderSize = 0
        Me.clearAccCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearAccCMD.Image = Global.StudentInformationSystem.My.Resources.Resources.CLEAR_ico
        Me.clearAccCMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clearAccCMD.Location = New System.Drawing.Point(151, 143)
        Me.clearAccCMD.Name = "clearAccCMD"
        Me.clearAccCMD.Size = New System.Drawing.Size(173, 26)
        Me.clearAccCMD.TabIndex = 8
        Me.clearAccCMD.Text = "&Clear"
        Me.clearAccCMD.UseVisualStyleBackColor = False
        '
        'regAccCMD
        '
        Me.regAccCMD.BackColor = System.Drawing.Color.SlateBlue
        Me.regAccCMD.FlatAppearance.BorderSize = 0
        Me.regAccCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.regAccCMD.Location = New System.Drawing.Point(151, 114)
        Me.regAccCMD.Name = "regAccCMD"
        Me.regAccCMD.Size = New System.Drawing.Size(173, 26)
        Me.regAccCMD.TabIndex = 0
        Me.regAccCMD.Text = "&Register new account"
        Me.regAccCMD.UseVisualStyleBackColor = False
        '
        'checkpassPB
        '
        Me.checkpassPB.Image = Global.StudentInformationSystem.My.Resources.Resources.correctpass
        Me.checkpassPB.Location = New System.Drawing.Point(387, 89)
        Me.checkpassPB.Name = "checkpassPB"
        Me.checkpassPB.Size = New System.Drawing.Size(19, 19)
        Me.checkpassPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.checkpassPB.TabIndex = 2
        Me.checkpassPB.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(115, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Control No.:"
        '
        'regconfirmpassTXT
        '
        Me.regconfirmpassTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.regconfirmpassTXT.Location = New System.Drawing.Point(211, 89)
        Me.regconfirmpassTXT.MaxLength = 50
        Me.regconfirmpassTXT.Name = "regconfirmpassTXT"
        Me.regconfirmpassTXT.Size = New System.Drawing.Size(173, 19)
        Me.regconfirmpassTXT.TabIndex = 5
        Me.regconfirmpassTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.regconfirmpassTXT.UseSystemPasswordChar = True
        '
        'regpassTXT
        '
        Me.regpassTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.regpassTXT.Location = New System.Drawing.Point(211, 64)
        Me.regpassTXT.MaxLength = 50
        Me.regpassTXT.Name = "regpassTXT"
        Me.regpassTXT.Size = New System.Drawing.Size(173, 19)
        Me.regpassTXT.TabIndex = 4
        Me.regpassTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.regpassTXT.UseSystemPasswordChar = True
        '
        'reguserTXT
        '
        Me.reguserTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.reguserTXT.Location = New System.Drawing.Point(211, 39)
        Me.reguserTXT.MaxLength = 20
        Me.reguserTXT.Name = "reguserTXT"
        Me.reguserTXT.Size = New System.Drawing.Size(173, 19)
        Me.reguserTXT.TabIndex = 3
        Me.reguserTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirm Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(509, 100)
        Me.Panel3.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.register_new_acc_banner
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(509, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'registernewAccfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(509, 314)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "registernewAccfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registernewAccfrm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.incorrectPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkpassPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents regpassTXT As System.Windows.Forms.TextBox
    Friend WithEvents reguserTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents regconfirmpassTXT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents checkpassPB As System.Windows.Forms.PictureBox
    Friend WithEvents regAccCMD As System.Windows.Forms.Button
    Friend WithEvents controlnumLBL As System.Windows.Forms.Label
    Friend WithEvents backregAccCMD As System.Windows.Forms.Button
    Friend WithEvents clearAccCMD As System.Windows.Forms.Button
    Friend WithEvents incorrectPB As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
