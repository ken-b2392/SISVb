Imports System
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Printing
Public Class updateStudInfofrm

    Public forselectedsearchby, forselectedrow, forbrowsedclicked, forcaptureclicked, forpathbrowsedpic, forstudnumber, forpicbox, IDNumStorage As String
    Public liststudnum As New ListBox

    Public forStudPB, toprintidnum, toprintfname, toprintmidname, toprintfamname, toprintgender, toprintquali, toprintSYFrom, toprintSYTo, toprintSem, toprintStatus, toprintYrLvl, _
         toprintContactNum, toprintCourse, toprintBDate, toprintAge, toprintCVStat, toprintReligion, toprintEmail, toprintPlaceB, toprintPresAdd, toprintHomeAdd, _
         toprintFatherN, toprintFatherOcc, toprintFatherContact, toprintMotherName, toprintMotherOcc, toprintContact As String
    Public forsubjcode, forsubjname, forinstructor, forunits, fornumhrLec, fornumhrLab, forTotalhr, forday, forRoom, forTIn, forTOut As String

    Private Sub updateStudInfofrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dr.Close()
        forFormLoadUpdateStudInfoFRM()
        forLoadDGVUpdateStudfrm()
        forsameDGVSelectedRow()

        With searchbyCMBO
            .Items.Add("")
            .Items.Add("Student ID")
            .Items.Add("First Name")
            .Items.Add("Middle Name")
            .Items.Add("Family Name")
        End With

    End Sub

    Private Sub backtoSearchStudCMD_Click(sender As Object, e As EventArgs) Handles backtoSearchStudCMD.Click

        forReloadDGVSearchStudfrm()
        forLoadDGVUpdateStudfrm()
        forAfterUpdateStudInfo()

        forBacktoSearchStudent()
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
                ctrl.BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub updateStudInfoCMD_Click(sender As Object, e As EventArgs) Handles updateStudInfoCMD.Click
        dr.Close()
        Dim confirmupdate As DialogResult = MessageBox.Show("Are you sure you want to update the student information?", "Confirmation", MessageBoxButtons.YesNo, _
                                                            MessageBoxIcon.Question)
        If confirmupdate = Windows.Forms.DialogResult.Yes Then
            Dim empty = Me.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)
            If empty.Any Then
                Dim txtctrl As Control
                For Each txtctrl In Me.Controls
                    If TypeOf txtctrl Is TextBox Then
                        If txtctrl.Text.Length = 0 Then
                            txtctrl.BackColor = Color.DarkRed
                        Else
                            txtctrl.BackColor = Color.White
                        End If
                    End If
                Next

                For Each cmboctrl In Me.Controls

                    If TypeOf cmboctrl Is ComboBox Then

                        If TryCast(cmboctrl, ComboBox).SelectedItem = "" Then
                            TryCast(cmboctrl, ComboBox).BackColor = Color.DarkRed
                        Else
                            TryCast(cmboctrl, ComboBox).BackColor = Color.DarkRed
                        End If
                    End If
                Next
                MsgBox("Please comply all the color red.")
            Else
                forUpdateStudInfo()
            End If



        End If




    End Sub

    Private Sub captureStudpicCMD_Click(sender As Object, e As EventArgs) Handles captureStudpicCMD.Click
        capturepicforUpdatefrm.Show()
        Me.Enabled = False
        forcaptureclicked = "1"
        forbrowsedclicked = "0"
    End Sub

    Private Sub BrowsePicCMD_Click(sender As Object, e As EventArgs) Handles BrowsePicCMD.Click
        forcaptureclicked = "0"
        forbrowsedclicked = "1"


        OpenFileDialog1.Title = "Browse for Student's Photo"
        OpenFileDialog1.Filter = "Image Files (*.PNG;*.BMP;*.JPG;*.JPEG;|*.PNG;*.BMP;*.JPG;*.JPEG;)"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            
            forpathbrowsedpic = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)

            Dim IOFileStream As New IO.FileStream(forpathbrowsedpic, IO.FileMode.Open, IO.FileAccess.Read)
            Dim tempimage As Image = Image.FromStream(IOFileStream)
            studpicPB.Image = tempimage
            IOFileStream.Dispose()
            '            Dim studpicStoragePB As New PictureBox
            '            Dim IOMemStream As New IO.FileStream(forpathbrowsedpic, IO.FileMode.Open, IO.FileAccess.Read)
            '            studpicStoragePB.Image = Image.FromFile(forpathbrowsedpic)
            '            studpicStoragePB.Image.Save(IOMemStream, Imaging.ImageFormat.Png)
            '
            '            studpicPB.Image = Image.FromStream(IOMemStream)

        End If

    End Sub

    Private Sub removephotoPB_Click(sender As Object, e As EventArgs) Handles removephotoPB.Click
        studpicPB.Image = Image.FromFile(defaultpicpath)
        forcaptureclicked = "0"
        forbrowsedclicked = "0"
    End Sub


    Private Sub displayStudforUpdateDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles displayStudforUpdateDGV.CellClick

        dr.Close()
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = displayStudforUpdateDGV.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from studInfoTBL where IDNum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader
            Dim forPicBox As New Label
            dr.Read()
            forPicBox.Text = dr.Item("Pic")
            forstudnumber = dr.Item("StudNum")
            forLoadDetails()

            forStudPB = dr.Item("Pic")
            toprintidnum = dr.Item("IDNum")
            toprintfname = dr.Item("FName")
            toprintmidname = dr.Item("MidName")
            toprintfamname = dr.Item("FamName")
            toprintgender = dr.Item("StudGender")
            toprintquali = dr.Item("Qualifier")
            toprintSYFrom = dr.Item("SYFrom")
            toprintSYTo = dr.Item("SYTo")
            toprintSem = dr.Item("Semester")
            toprintStatus = dr.Item("Status")
            toprintYrLvl = dr.Item("YearLevel")
            toprintContactNum = dr.Item("ContactNum")
            toprintCourse = dr.Item("Course")
            toprintBDate = dr.Item("Birthdate")
            toprintAge = dr.Item("Age")
            toprintCVStat = dr.Item("CivilStat")
            toprintReligion = dr.Item("Religion")
            toprintEmail = dr.Item("EmailAdd")
            toprintPlaceB = dr.Item("PlaceBirth")
            toprintPresAdd = dr.Item("PresentAdd")
            toprintHomeAdd = dr.Item("HomeAdd")
            toprintFatherN = dr.Item("FatherName")
            toprintFatherOcc = dr.Item("FatherOccupation")
            toprintFatherContact = dr.Item("FatherContactNum")
            toprintMotherName = dr.Item("MotherName")
            toprintMotherOcc = dr.Item("MotherOccupation")
            toprintContact = dr.Item("MotherContactNum")

            QualiCMBO.SelectedItem = forqualifier
            studGenderCMBO.SelectedItem = forgender
            courseCMBO.SelectedItem = forcourse
            yearCMBO.SelectedItem = foryrlvl
            CivilStatCMBO.SelectedItem = forCStats

            StudIDNumTXT.Text = IDNumStorage

            Dim IOFileStream As New IO.FileStream(forPicBox.Text, IO.FileMode.Open, IO.FileAccess.Read)
            Dim tempimage As Image = Image.FromStream(IOFileStream)
            studpicPB.Image = tempimage
            IOFileStream.Dispose()

            dr.Close()


            'Public forsubjcode, forsubjname, forinstructor, forunits, fornumhrLec, fornumhrLab, forTotalhr, forday, forRoom, forTIn, forTOut As String
            Dim displaysched As String = "select * from studstubjtbl where IDNum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader
            dr.Read()

            dr.Close()
        Else

            selectedrow = displayStudforUpdateDGV.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from studInfoTBL where IDNum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader
            Dim forPicBox As New Label
            dr.Read()
            forPicBox.Text = dr.Item("Pic")
            forstudnumber = dr.Item("StudNum")
            forLoadDetails()

            forStudPB = dr.Item("Pic")
            toprintidnum = dr.Item("IDNum")
            toprintfname = dr.Item("FName")
            toprintmidname = dr.Item("MidName")
            toprintfamname = dr.Item("FamName")
            toprintgender = dr.Item("StudGender")
            toprintquali = dr.Item("Qualifier")
            toprintSYFrom = dr.Item("SYFrom")
            toprintSYTo = dr.Item("SYTo")
            toprintSem = dr.Item("Semester")
            toprintStatus = dr.Item("Status")
            toprintYrLvl = dr.Item("YearLevel")
            toprintContactNum = dr.Item("ContactNum")
            toprintCourse = dr.Item("Course")
            toprintBDate = dr.Item("Birthdate")
            toprintAge = dr.Item("Age")
            toprintCVStat = dr.Item("CivilStat")
            toprintReligion = dr.Item("Religion")
            toprintEmail = dr.Item("EmailAdd")
            toprintPlaceB = dr.Item("PlaceBirth")
            toprintPresAdd = dr.Item("PresentAdd")
            toprintHomeAdd = dr.Item("HomeAdd")
            toprintFatherN = dr.Item("FatherName")
            toprintFatherOcc = dr.Item("FatherOccupation")
            toprintFatherContact = dr.Item("FatherContactNum")
            toprintMotherName = dr.Item("MotherName")
            toprintMotherOcc = dr.Item("MotherOccupation")
            toprintContact = dr.Item("MotherContactNum")


            QualiCMBO.SelectedItem = forqualifier
            studGenderCMBO.SelectedItem = forgender
            courseCMBO.SelectedItem = forcourse
            yearCMBO.SelectedItem = foryrlvl
            CivilStatCMBO.SelectedItem = forCStats
            StudIDNumTXT.Text = IDNumStorage

            Dim IOFileStream As New IO.FileStream(forPicBox.Text, IO.FileMode.Open, IO.FileAccess.Read)
            Dim tempimage As Image = Image.FromStream(IOFileStream)
            studpicPB.Image = tempimage
            IOFileStream.Dispose()

            dr.Close()
        End If
    End Sub

    Private Sub searchBarTXT_TextChanged(sender As Object, e As EventArgs) Handles searchBarTXT.TextChanged
        searchBarTXT.Text = LTrim(searchBarTXT.Text)

        If searchBarTXT.Text.Length = 0 Then
            forLoadDGVUpdateStudfrm()
        Else
            forSearchtoUpdateStudInfo()
        End If
    End Sub


    Private Sub searchbyCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchbyCMBO.SelectedIndexChanged
        If searchbyCMBO.SelectedIndex = 0 Then
            forLoadDGVUpdateStudfrm()
        ElseIf searchbyCMBO.SelectedIndex = 1 Then
            forselectedsearchby = "IDNum"
        ElseIf searchbyCMBO.SelectedIndex = 2 Then
            forselectedsearchby = "FName"
        ElseIf searchbyCMBO.SelectedIndex = 3 Then
            forselectedsearchby = "MidName"
        ElseIf searchbyCMBO.SelectedIndex = 4 Then
            forselectedsearchby = "FamName"
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


        Dim forheaderfont As Font = New Drawing.Font("Arial", 12, FontStyle.Regular)
        Dim nameproj As Font = New Drawing.Font("Arial", 12, FontStyle.Bold)
        Dim skuladd As Font = New Drawing.Font("Arial", 10, FontStyle.Regular)
        Dim title As Font = New Drawing.Font("Arial", 15, FontStyle.Bold)
        e.Graphics.DrawString("Student Information System", forheaderfont, Brushes.Black, 300, 100)
        e.Graphics.DrawString("BSIT-2A Project", nameproj, Brushes.Black, 340, 120)
        e.Graphics.DrawString("Poblacion, Opol, Misamis Oriental", skuladd, Brushes.Black, 295, 140)
        e.Graphics.DrawString("STUDENT INFORMATION", title, Brushes.Black, 275, 190)

        Dim IOFileStream As New IO.FileStream(forStudPB, IO.FileMode.Open, IO.FileAccess.Read)
        Dim tempimage As Image = Image.FromStream(IOFileStream)
        Dim picboxstud As Image = tempimage
        IOFileStream.Dispose()

        e.Graphics.DrawImage(picboxstud, 60, 215, 100, 100)

        Dim fillall As Font = New Drawing.Font("Arial", 12, FontStyle.Underline)
        Dim tofill As Font = New Drawing.Font("Arial", 12, FontStyle.Bold)
        e.Graphics.DrawString("Student ID No.: ", tofill, Brushes.Black, 60, 320)
        e.Graphics.DrawString(toprintidnum, tofill, Brushes.Black, 190, 320)
        e.Graphics.DrawString("Name: ", tofill, Brushes.Black, 60, 350)
        e.Graphics.DrawString(toprintfname & "   " & toprintmidname & "   " & toprintfamname, fillall, Brushes.Black, 120, 350)
        e.Graphics.DrawString("Qualifier: ", tofill, Brushes.Black, 500, 350)
        e.Graphics.DrawString(toprintquali, fillall, Brushes.Black, 580, 350)
        e.Graphics.DrawString("Gender: ", tofill, Brushes.Black, 630, 350)
        e.Graphics.DrawString(toprintgender, fillall, Brushes.Black, 700, 350)
        e.Graphics.DrawString("Age: ", tofill, Brushes.Black, 60, 380)
        e.Graphics.DrawString(toprintAge, fillall, Brushes.Black, 100, 380)
        e.Graphics.DrawString("Birthdate: ", tofill, Brushes.Black, 140, 380)
        e.Graphics.DrawString(toprintBDate, fillall, Brushes.Black, 220, 380)
        e.Graphics.DrawString("Marital Status: ", tofill, Brushes.Black, 320, 380)
        e.Graphics.DrawString(toprintCVStat, fillall, Brushes.Black, 440, 380)
        e.Graphics.DrawString("Contact No.: ", tofill, Brushes.Black, 510, 380)
        e.Graphics.DrawString(toprintContactNum, fillall, Brushes.Black, 610, 380)
        e.Graphics.DrawString("Present Address: ", tofill, Brushes.Black, 60, 410)
        e.Graphics.DrawString(toprintPresAdd, fillall, Brushes.Black, 200, 410)
        e.Graphics.DrawString("Home Address: ", tofill, Brushes.Black, 60, 440)
        e.Graphics.DrawString(toprintHomeAdd, fillall, Brushes.Black, 190, 440)
        e.Graphics.DrawString("Place of Birth: ", tofill, Brushes.Black, 60, 470)
        e.Graphics.DrawString(toprintPlaceB, fillall, Brushes.Black, 180, 470)
        e.Graphics.DrawString("Religion: ", tofill, Brushes.Black, 60, 500)
        e.Graphics.DrawString(toprintReligion, fillall, Brushes.Black, 140, 500)
        e.Graphics.DrawString("Email Address: ", tofill, Brushes.Black, 380, 500)
        e.Graphics.DrawString(toprintEmail, fillall, Brushes.Black, 510, 500)
        e.Graphics.DrawString("Father's name: ", tofill, Brushes.Black, 60, 530)
        e.Graphics.DrawString(toprintFatherN, fillall, Brushes.Black, 180, 530)
        e.Graphics.DrawString("Occupation: ", tofill, Brushes.Black, 380, 530)
        e.Graphics.DrawString(toprintFatherOcc, fillall, Brushes.Black, 480, 530)
        e.Graphics.DrawString("Contact No.:", tofill, Brushes.Black, 60, 560)
        e.Graphics.DrawString(toprintFatherContact, fillall, Brushes.Black, 160, 560)
        e.Graphics.DrawString("Mother's name:", tofill, Brushes.Black, 60, 590)
        e.Graphics.DrawString(toprintMotherName, fillall, Brushes.Black, 190, 590)
        e.Graphics.DrawString("Occupation:", tofill, Brushes.Black, 380, 590)
        e.Graphics.DrawString(toprintMotherOcc, fillall, Brushes.Black, 480, 590)
        e.Graphics.DrawString("Contact No.:", tofill, Brushes.Black, 60, 620)
        e.Graphics.DrawString(toprintContact, fillall, Brushes.Black, 160, 620)
        e.Graphics.DrawString("School Year:", tofill, Brushes.Black, 60, 670)
        e.Graphics.DrawString(toprintSYFrom & "-" & toprintSYTo, fillall, Brushes.Black, 170, 670)
        e.Graphics.DrawString("Semester:", tofill, Brushes.Black, 270, 670)
        e.Graphics.DrawString(toprintSem, fillall, Brushes.Black, 360, 670)
        e.Graphics.DrawString("Student Status:", tofill, Brushes.Black, 400, 670)
        e.Graphics.DrawString(toprintStatus, fillall, Brushes.Black, 530, 670)
        e.Graphics.DrawString("Year Level:", tofill, Brushes.Black, 640, 670)
        e.Graphics.DrawString(toprintYrLvl, fillall, Brushes.Black, 740, 670)
        e.Graphics.DrawString("Course:", tofill, Brushes.Black, 60, 700)
        e.Graphics.DrawString(toprintCourse, fillall, Brushes.Black, 130, 700)
        e.Graphics.DrawString("Total No. of Units:", tofill, Brushes.Black, 60, 725)
        e.Graphics.DrawString(Label33.Text, fillall, Brushes.Black, 210, 725)

        Dim objBmp As New Bitmap(DataGridView1.Width, DataGridView1.Height)
        DataGridView1.DrawToBitmap(objBmp, New Rectangle(0, 0, DataGridView1.Width, DataGridView1.Height))
        e.Graphics.DrawImage(objBmp, 15, 750)

    End Sub

 

    Private Sub previewCMD_Click(sender As Object, e As EventArgs) Handles previewCMD.Click
        CType(PrintPreviewDialog1.Controls(1), ToolStrip).Items(0).Enabled = False
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub


    Private Sub printCMD_Click(sender As Object, e As EventArgs) Handles printCMD.Click


        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings

        If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            Dim pagesetup As New PageSettings
            With pagesetup
                .Margins.Left = 50
                .Margins.Right = 50
                .Margins.Top = 100
                .Margins.Bottom = 100
                .PaperSize = New PaperSize("A4", 8.27, 11.69)
                .Landscape = False
            End With
            PrintDialog1.Document = PrintDocument1
            PrintDocument1.DefaultPageSettings = pagesetup
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub BdayDTP_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles BdayDTP.Validating
        Try
            Dim checkdate As String
            Dim today As System.DateTime = System.DateTime.Now
            checkdate = BdayDTP.Text

            Dim yearnow As Integer = today.Year

            Dim yeardtp As Integer = BdayDTP.Value.Year
            Dim rightyear As Integer = BdayDTP.Value.Year - 17
            Dim minimage As Integer = yeardtp - rightyear

            Dim forminimage As Integer = minimage
            Dim currentage As Integer = yearnow - yeardtp
            ageLBL.Text = currentage.ToString
            If currentage >= forminimage Then
                CivilStatCMBO.Enabled = True
                CivilStatCMBO.Focus()
            Else
                MessageBox.Show("Age should be 17 y/o and above.", "Date Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BdayDTP.Focus()
                CivilStatCMBO.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error on checking date. " & ex.Message)
        End Try
    End Sub

    Private Sub BdayDTP_ValueChanged(sender As Object, e As EventArgs) Handles BdayDTP.ValueChanged

    End Sub

    Private Sub displayStudforUpdateDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles displayStudforUpdateDGV.CellContentClick

    End Sub

    Private Sub displayStudforUpdateDGV_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles displayStudforUpdateDGV.CellEnter
        dr.Close()
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = displayStudforUpdateDGV.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from studInfoTBL where IDNum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader
            Dim forPicBox As New Label
            dr.Read()
            forPicBox.Text = dr.Item("Pic")
            forstudnumber = dr.Item("StudNum")
            forLoadDetails()

            forStudPB = dr.Item("Pic")
            toprintidnum = dr.Item("IDNum")
            toprintfname = dr.Item("FName")
            toprintmidname = dr.Item("MidName")
            toprintfamname = dr.Item("FamName")
            toprintgender = dr.Item("StudGender")
            toprintquali = dr.Item("Qualifier")
            toprintSYFrom = dr.Item("SYFrom")
            toprintSYTo = dr.Item("SYTo")
            toprintSem = dr.Item("Semester")
            toprintStatus = dr.Item("Status")
            toprintYrLvl = dr.Item("YearLevel")
            toprintContactNum = dr.Item("ContactNum")
            toprintCourse = dr.Item("Course")
            toprintBDate = dr.Item("Birthdate")
            toprintAge = dr.Item("Age")
            toprintCVStat = dr.Item("CivilStat")
            toprintReligion = dr.Item("Religion")
            toprintEmail = dr.Item("EmailAdd")
            toprintPlaceB = dr.Item("PlaceBirth")
            toprintPresAdd = dr.Item("PresentAdd")
            toprintHomeAdd = dr.Item("HomeAdd")
            toprintFatherN = dr.Item("FatherName")
            toprintFatherOcc = dr.Item("FatherOccupation")
            toprintFatherContact = dr.Item("FatherContactNum")
            toprintMotherName = dr.Item("MotherName")
            toprintMotherOcc = dr.Item("MotherOccupation")
            toprintContact = dr.Item("MotherContactNum")

            QualiCMBO.SelectedItem = forqualifier
            studGenderCMBO.SelectedItem = forgender
            courseCMBO.SelectedItem = forcourse
            yearCMBO.SelectedItem = foryrlvl
            CivilStatCMBO.SelectedItem = forCStats

            StudIDNumTXT.Text = IDNumStorage

            Dim IOFileStream As New IO.FileStream(forPicBox.Text, IO.FileMode.Open, IO.FileAccess.Read)
            Dim tempimage As Image = Image.FromStream(IOFileStream)
            studpicPB.Image = tempimage
            IOFileStream.Dispose()

            dr.Close()

        Else

            selectedrow = displayStudforUpdateDGV.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from studInfoTBL where IDNum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader
            Dim forPicBox As New Label
            dr.Read()
            forPicBox.Text = dr.Item("Pic")
            forstudnumber = dr.Item("StudNum")
            forLoadDetails()

            forStudPB = dr.Item("Pic")
            toprintidnum = dr.Item("IDNum")
            toprintfname = dr.Item("FName")
            toprintmidname = dr.Item("MidName")
            toprintfamname = dr.Item("FamName")
            toprintgender = dr.Item("StudGender")
            toprintquali = dr.Item("Qualifier")
            toprintSYFrom = dr.Item("SYFrom")
            toprintSYTo = dr.Item("SYTo")
            toprintSem = dr.Item("Semester")
            toprintStatus = dr.Item("Status")
            toprintYrLvl = dr.Item("YearLevel")
            toprintContactNum = dr.Item("ContactNum")
            toprintCourse = dr.Item("Course")
            toprintBDate = dr.Item("Birthdate")
            toprintAge = dr.Item("Age")
            toprintCVStat = dr.Item("CivilStat")
            toprintReligion = dr.Item("Religion")
            toprintEmail = dr.Item("EmailAdd")
            toprintPlaceB = dr.Item("PlaceBirth")
            toprintPresAdd = dr.Item("PresentAdd")
            toprintHomeAdd = dr.Item("HomeAdd")
            toprintFatherN = dr.Item("FatherName")
            toprintFatherOcc = dr.Item("FatherOccupation")
            toprintFatherContact = dr.Item("FatherContactNum")
            toprintMotherName = dr.Item("MotherName")
            toprintMotherOcc = dr.Item("MotherOccupation")
            toprintContact = dr.Item("MotherContactNum")


            QualiCMBO.SelectedItem = forqualifier
            studGenderCMBO.SelectedItem = forgender
            courseCMBO.SelectedItem = forcourse
            yearCMBO.SelectedItem = foryrlvl
            CivilStatCMBO.SelectedItem = forCStats
            StudIDNumTXT.Text = IDNumStorage

            Dim IOFileStream As New IO.FileStream(forPicBox.Text, IO.FileMode.Open, IO.FileAccess.Read)
            Dim tempimage As Image = Image.FromStream(IOFileStream)
            studpicPB.Image = tempimage
            IOFileStream.Dispose()

            dr.Close()
        End If
    End Sub

    Private Sub StudIDNumTXT_TextChanged(sender As Object, e As EventArgs) Handles StudIDNumTXT.TextChanged
        forprintstudschedonupdatestudinfo()

        forprinttotaluntisonupdatetsudfrm()
    End Sub

    Private Sub refreshPB_Click(sender As Object, e As EventArgs) Handles refreshPB.Click
        forLoadDGVUpdateStudfrm()
    End Sub
End Class