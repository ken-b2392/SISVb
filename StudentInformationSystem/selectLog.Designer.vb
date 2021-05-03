<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectLog
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
        Me.SelLogExitCMD = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.schooladminPB = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.sysadminPB = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.schooladminPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.sysadminPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelLogExitCMD
        '
        Me.SelLogExitCMD.BackColor = System.Drawing.Color.RoyalBlue
        Me.SelLogExitCMD.FlatAppearance.BorderSize = 0
        Me.SelLogExitCMD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.SelLogExitCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelLogExitCMD.Location = New System.Drawing.Point(195, 336)
        Me.SelLogExitCMD.Name = "SelLogExitCMD"
        Me.SelLogExitCMD.Size = New System.Drawing.Size(257, 34)
        Me.SelLogExitCMD.TabIndex = 6
        Me.SelLogExitCMD.Text = "&Exit"
        Me.SelLogExitCMD.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.select_type_of_user
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(666, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.schooladminPB)
        Me.Panel1.Location = New System.Drawing.Point(51, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 240)
        Me.Panel1.TabIndex = 8
        '
        'schooladminPB
        '
        Me.schooladminPB.Image = Global.StudentInformationSystem.My.Resources.Resources.school_admin_new1
        Me.schooladminPB.Location = New System.Drawing.Point(7, 7)
        Me.schooladminPB.Name = "schooladminPB"
        Me.schooladminPB.Size = New System.Drawing.Size(233, 233)
        Me.schooladminPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.schooladminPB.TabIndex = 11
        Me.schooladminPB.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.sysadminPB)
        Me.Panel2.Location = New System.Drawing.Point(381, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 240)
        Me.Panel2.TabIndex = 9
        '
        'sysadminPB
        '
        Me.sysadminPB.Image = Global.StudentInformationSystem.My.Resources.Resources.system_administrator
        Me.sysadminPB.Location = New System.Drawing.Point(7, 7)
        Me.sysadminPB.Name = "sysadminPB"
        Me.sysadminPB.Size = New System.Drawing.Size(233, 233)
        Me.sysadminPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sysadminPB.TabIndex = 10
        Me.sysadminPB.TabStop = False
        '
        'selectLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(666, 391)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SelLogExitCMD)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "selectLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "School Admin Log-in Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.schooladminPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.sysadminPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SelLogExitCMD As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents schooladminPB As System.Windows.Forms.PictureBox
    Friend WithEvents sysadminPB As System.Windows.Forms.PictureBox

End Class
