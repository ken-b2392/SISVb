<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginfrmSysAdmin
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.logpasstxt = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.logusernametxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogSysAdminCMD = New System.Windows.Forms.Button()
        Me.LogExitCMD = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.logpasstxt)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.logusernametxt)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 207)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(304, 163)
        Me.Panel2.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel4.Location = New System.Drawing.Point(54, 145)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 3)
        Me.Panel4.TabIndex = 6
        '
        'logpasstxt
        '
        Me.logpasstxt.BackColor = System.Drawing.Color.MediumAquamarine
        Me.logpasstxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.logpasstxt.Location = New System.Drawing.Point(55, 120)
        Me.logpasstxt.Name = "logpasstxt"
        Me.logpasstxt.Size = New System.Drawing.Size(199, 19)
        Me.logpasstxt.TabIndex = 4
        Me.logpasstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.logpasstxt.UseSystemPasswordChar = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Location = New System.Drawing.Point(54, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 3)
        Me.Panel3.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'logusernametxt
        '
        Me.logusernametxt.BackColor = System.Drawing.Color.MediumAquamarine
        Me.logusernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.logusernametxt.Location = New System.Drawing.Point(55, 42)
        Me.logusernametxt.Name = "logusernametxt"
        Me.logusernametxt.Size = New System.Drawing.Size(199, 19)
        Me.logusernametxt.TabIndex = 0
        Me.logusernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 208)
        Me.Panel1.TabIndex = 9
        '
        'LogSysAdminCMD
        '
        Me.LogSysAdminCMD.BackColor = System.Drawing.Color.SpringGreen
        Me.LogSysAdminCMD.FlatAppearance.BorderSize = 0
        Me.LogSysAdminCMD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.LogSysAdminCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogSysAdminCMD.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogSysAdminCMD.Location = New System.Drawing.Point(0, 376)
        Me.LogSysAdminCMD.Name = "LogSysAdminCMD"
        Me.LogSysAdminCMD.Size = New System.Drawing.Size(304, 34)
        Me.LogSysAdminCMD.TabIndex = 11
        Me.LogSysAdminCMD.Text = "&Log-in"
        Me.LogSysAdminCMD.UseVisualStyleBackColor = False
        '
        'LogExitCMD
        '
        Me.LogExitCMD.BackColor = System.Drawing.Color.SpringGreen
        Me.LogExitCMD.FlatAppearance.BorderSize = 0
        Me.LogExitCMD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.LogExitCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogExitCMD.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogExitCMD.Location = New System.Drawing.Point(0, 421)
        Me.LogExitCMD.Name = "LogExitCMD"
        Me.LogExitCMD.Size = New System.Drawing.Size(304, 34)
        Me.LogExitCMD.TabIndex = 12
        Me.LogExitCMD.Text = "&Back"
        Me.LogExitCMD.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.StudentInformationSystem.My.Resources.Resources.system_admin1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'loginfrmSysAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(304, 467)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LogSysAdminCMD)
        Me.Controls.Add(Me.LogExitCMD)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "loginfrmSysAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loginfrmSysAdmin"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents logpasstxt As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents logusernametxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LogSysAdminCMD As System.Windows.Forms.Button
    Friend WithEvents LogExitCMD As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
