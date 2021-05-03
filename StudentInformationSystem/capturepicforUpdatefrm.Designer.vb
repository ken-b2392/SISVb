<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class capturepicforUpdatefrm
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.previewPB = New System.Windows.Forms.PictureBox()
        Me.capturedPB = New System.Windows.Forms.PictureBox()
        Me.refreshpbCMD = New System.Windows.Forms.Button()
        Me.selectCamCMD = New System.Windows.Forms.Button()
        Me.captureStudpicCMD = New System.Windows.Forms.Button()
        Me.backtoAddstudfrm = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.previewPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.capturedPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.previewPB, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.capturedPB, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(24, 57)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 167.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(423, 167)
        Me.TableLayoutPanel1.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(308, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Captured"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(104, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Preview"
        '
        'previewPB
        '
        Me.previewPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.previewPB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.previewPB.Location = New System.Drawing.Point(3, 3)
        Me.previewPB.Name = "previewPB"
        Me.previewPB.Size = New System.Drawing.Size(205, 161)
        Me.previewPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.previewPB.TabIndex = 0
        Me.previewPB.TabStop = False
        '
        'capturedPB
        '
        Me.capturedPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.capturedPB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.capturedPB.Location = New System.Drawing.Point(214, 3)
        Me.capturedPB.Name = "capturedPB"
        Me.capturedPB.Size = New System.Drawing.Size(206, 161)
        Me.capturedPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.capturedPB.TabIndex = 1
        Me.capturedPB.TabStop = False
        '
        'refreshpbCMD
        '
        Me.refreshpbCMD.BackgroundImage = Global.StudentInformationSystem.My.Resources.Resources.refresh_or_update
        Me.refreshpbCMD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.refreshpbCMD.FlatAppearance.BorderSize = 0
        Me.refreshpbCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refreshpbCMD.Location = New System.Drawing.Point(426, 14)
        Me.refreshpbCMD.Name = "refreshpbCMD"
        Me.refreshpbCMD.Size = New System.Drawing.Size(40, 40)
        Me.refreshpbCMD.TabIndex = 38
        Me.refreshpbCMD.UseVisualStyleBackColor = True
        '
        'selectCamCMD
        '
        Me.selectCamCMD.BackgroundImage = Global.StudentInformationSystem.My.Resources.Resources.select_cam
        Me.selectCamCMD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.selectCamCMD.FlatAppearance.BorderSize = 0
        Me.selectCamCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectCamCMD.Location = New System.Drawing.Point(123, 232)
        Me.selectCamCMD.Name = "selectCamCMD"
        Me.selectCamCMD.Size = New System.Drawing.Size(69, 53)
        Me.selectCamCMD.TabIndex = 37
        Me.selectCamCMD.UseVisualStyleBackColor = True
        '
        'captureStudpicCMD
        '
        Me.captureStudpicCMD.BackgroundImage = Global.StudentInformationSystem.My.Resources.Resources.camera1
        Me.captureStudpicCMD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.captureStudpicCMD.FlatAppearance.BorderSize = 0
        Me.captureStudpicCMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.captureStudpicCMD.Location = New System.Drawing.Point(207, 230)
        Me.captureStudpicCMD.Name = "captureStudpicCMD"
        Me.captureStudpicCMD.Size = New System.Drawing.Size(55, 55)
        Me.captureStudpicCMD.TabIndex = 36
        Me.captureStudpicCMD.UseVisualStyleBackColor = True
        '
        'backtoAddstudfrm
        '
        Me.backtoAddstudfrm.FlatAppearance.BorderSize = 0
        Me.backtoAddstudfrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backtoAddstudfrm.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.backtoAddstudfrm.Image = Global.StudentInformationSystem.My.Resources.Resources.mini_back_arrow
        Me.backtoAddstudfrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.backtoAddstudfrm.Location = New System.Drawing.Point(370, 239)
        Me.backtoAddstudfrm.Margin = New System.Windows.Forms.Padding(4)
        Me.backtoAddstudfrm.Name = "backtoAddstudfrm"
        Me.backtoAddstudfrm.Size = New System.Drawing.Size(96, 35)
        Me.backtoAddstudfrm.TabIndex = 32
        Me.backtoAddstudfrm.Text = "     &Back"
        Me.backtoAddstudfrm.UseVisualStyleBackColor = True
        '
        'capturepicforUpdatefrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(478, 305)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.refreshpbCMD)
        Me.Controls.Add(Me.selectCamCMD)
        Me.Controls.Add(Me.captureStudpicCMD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.backtoAddstudfrm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "capturepicforUpdatefrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "capturepicforUpdatefrm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.previewPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.capturedPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents previewPB As System.Windows.Forms.PictureBox
    Friend WithEvents capturedPB As System.Windows.Forms.PictureBox
    Friend WithEvents refreshpbCMD As System.Windows.Forms.Button
    Friend WithEvents selectCamCMD As System.Windows.Forms.Button
    Friend WithEvents captureStudpicCMD As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents backtoAddstudfrm As System.Windows.Forms.Button
End Class
