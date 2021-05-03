Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Printing
Public Class searchstudfrm

    Public forselectedsearchby, forselectedrow, forStudPB As String
    Public toprintidnum, toprintfname, toprintmidname, toprintfamname, toprintgender, toprintquali, toprintSYFrom, toprintSYTo, toprintSem, toprintStatus, toprintYrLvl, _
         toprintContactNum, toprintCourse, toprintBDate, toprintAge, toprintCVStat, toprintReligion, toprintEmail, toprintPlaceB, toprintPresAdd, toprintHomeAdd, _
         toprintFatherN, toprintFatherOcc, toprintFatherContact, toprintMotherName, toprintMotherOcc, toprintContact As String
    Public selectedrowtoprint, selectedrowp As New Label



    Private Sub searchstudfrm_Load(sender As Object, e As EventArgs) Handles Me.Load

        forLoadSearchStudfrm()

        With searchbyCMBO
            .Items.Add("")
            .Items.Add("ID No.")
            .Items.Add("First Name")
            .Items.Add("Family Name")
            .SelectedIndex = 0
        End With

    End Sub

    Private Sub clearPB_Click(sender As Object, e As EventArgs) Handles clearPB.Click
        searchBarTXT.Clear()
    End Sub

    Private Sub clearPB_MouseHover(sender As Object, e As EventArgs) Handles clearPB.MouseHover
        With clearPB
            .Size = New Size(30, 20)
            .Location = New Point((Panel6.Width / 2) - (clearPB.Width / 2), (Panel6.Height / 2) - (clearPB.Height / 2))
        End With
    End Sub

    Private Sub clearPB_MouseLeave(sender As Object, e As EventArgs) Handles clearPB.MouseLeave
        With clearPB
            .Size = New Size(25, 15)
            .Location = New Point((Panel6.Width / 2) - (clearPB.Width / 2), (Panel6.Height / 2) - (clearPB.Height / 2))
        End With
    End Sub

    Private Sub refreshPB_Click(sender As Object, e As EventArgs) Handles refreshPB.Click
        forReloadDGVSearchStudfrm()
    End Sub

    Private Sub refreshPB_MouseHover(sender As Object, e As EventArgs) Handles refreshPB.MouseHover
        With refreshPB
            .Size = New Size(20, 20)
            .Location = New Point((Panel3.Width / 2) - (refreshPB.Width / 2), (Panel3.Height / 2) - (refreshPB.Height / 2))
        End With
    End Sub

    Private Sub refreshPB_MouseLeave(sender As Object, e As EventArgs) Handles refreshPB.MouseLeave
        With refreshPB
            .Size = New Size(15, 15)
            .Location = New Point((Panel3.Width / 2) - (refreshPB.Width / 2), (Panel3.Height / 2) - (refreshPB.Height / 2))
        End With
    End Sub

    Private Sub backCMD_Click(sender As Object, e As EventArgs) Handles backCMD.Click
        Mainfrm.Enabled = True
        Me.Hide()
    End Sub

    Private Sub searchbyCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchbyCMBO.SelectedIndexChanged
        If searchbyCMBO.SelectedIndex = 0 Then
            searchBarTXT.Clear()
            searchBarTXT.Enabled = False
            forselectedsearchby = ""
        ElseIf searchbyCMBO.SelectedIndex = 1 Then
            forselectedsearchby = "IDNum"
            searchBarTXT.Clear()
            searchBarTXT.Enabled = True
        ElseIf searchbyCMBO.SelectedIndex = 2 Then
            forselectedsearchby = "FName"
            searchBarTXT.Clear()
            searchBarTXT.Enabled = True
        ElseIf searchbyCMBO.SelectedIndex = 3 Then
            forselectedsearchby = "FamName"
            searchBarTXT.Clear()
            searchBarTXT.Enabled = True
        End If
    End Sub

    Private Sub searchBarTXT_TextChanged(sender As Object, e As EventArgs) Handles searchBarTXT.TextChanged

        searchBarTXT.Text = LTrim(searchBarTXT.Text)

        If searchBarTXT.Text.Length = 0 Then
            forReloadDGVSearchStudfrm()
        Else
            forSearchStudent()
        End If

    End Sub

    Private Sub displayinfoDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles displayinfoDGV.CellDoubleClick

        Dim forselectedrow As String
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = displayinfoDGV.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from studInfoTBL where IDNum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader

            While dr.Read()
                updateStudInfofrm.forpicbox = dr("Pic").ToString
                updateStudInfofrm.forstudnumber = dr("StudNum").ToString
                forLoadDetails()
            End While

            updateStudInfofrm.Show()
            updateStudInfofrm.StudIDNumTXT.Text = updateStudInfofrm.IDNumStorage

            Dim IOFileStream As New IO.FileStream(updateStudInfofrm.forpicbox, IO.FileMode.Open, IO.FileAccess.Read)
            Dim tempimage As Image = Image.FromStream(IOFileStream)
            updateStudInfofrm.studpicPB.Image = tempimage
            IOFileStream.Dispose()

            updateStudInfofrm.QualiCMBO.SelectedItem = forqualifier
            updateStudInfofrm.studGenderCMBO.SelectedItem = forgender
            updateStudInfofrm.courseCMBO.SelectedItem = forcourse
            updateStudInfofrm.yearCMBO.SelectedItem = foryrlvl
            updateStudInfofrm.CivilStatCMBO.SelectedItem = forCStats

            If String.Equals(forselectedRB, updateStudInfofrm.NewStudRB.Text) Then
                updateStudInfofrm.NewStudRB.Checked = True
            ElseIf String.Equals(forselectedRB, updateStudInfofrm.OldStudRB.Text) Then
                updateStudInfofrm.OldStudRB.Checked = True
            ElseIf String.Equals(forselectedRB, updateStudInfofrm.RetStudRB.Text) Then
                updateStudInfofrm.RetStudRB.Checked = True
            ElseIf String.Equals(forselectedRB, updateStudInfofrm.TransStudRB.Text) Then
                updateStudInfofrm.TransStudRB.Checked = True
            End If

            Me.Enabled = False
            dr.Close()
        Else

            selectedrow = displayinfoDGV.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from studInfoTBL where IDNum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader

            While dr.Read
                updateStudInfofrm.forpicbox = dr.Item("Pic")
                updateStudInfofrm.forstudnumber = dr("StudNum")
                forLoadDetails()
            End While
            Dim forselectedSEM As New Label

            updateStudInfofrm.Show()
            updateStudInfofrm.StudIDNumTXT.Text = updateStudInfofrm.IDNumStorage


            Dim IOFileStream As New IO.FileStream(updateStudInfofrm.forpicbox, IO.FileMode.Open, IO.FileAccess.Read)
            Dim tempimage As Image = Image.FromStream(IOFileStream)
            updateStudInfofrm.studpicPB.Image = tempimage
            IOFileStream.Dispose()

            updateStudInfofrm.QualiCMBO.SelectedItem = forqualifier
            updateStudInfofrm.studGenderCMBO.SelectedItem = forgender
            updateStudInfofrm.courseCMBO.SelectedItem = forcourse
            updateStudInfofrm.yearCMBO.SelectedItem = foryrlvl
            updateStudInfofrm.CivilStatCMBO.SelectedItem = forCStats

            If String.Equals(forselectedRB, updateStudInfofrm.NewStudRB.Text) Then
                updateStudInfofrm.NewStudRB.Checked = True
            ElseIf String.Equals(forselectedRB, updateStudInfofrm.OldStudRB.Text) Then
                updateStudInfofrm.OldStudRB.Checked = True
            ElseIf String.Equals(forselectedRB, updateStudInfofrm.RetStudRB.Text) Then
                updateStudInfofrm.RetStudRB.Checked = True
            ElseIf String.Equals(forselectedRB, updateStudInfofrm.TransStudRB.Text) Then
                updateStudInfofrm.TransStudRB.Checked = True
            End If

            Me.Enabled = False
            dr.Close()
        End If

    End Sub



    Private Sub displayinfoDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles displayinfoDGV.CellClick

        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = displayinfoDGV.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from studInfoTBL where IDNum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader
            Dim forPicBox As New Label
            dr.Read()
            forPicBox.Text = dr("Pic").ToString
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

            Dim IOFileStream As New IO.FileStream(forPicBox.Text, IO.FileMode.Open, IO.FileAccess.Read)
            Dim tempimage As Image = Image.FromStream(IOFileStream)
            studpicPB.Image = tempimage
            IOFileStream.Dispose()
            dr.Close()




        Else

            selectedrow = displayinfoDGV.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from studInfoTBL where IDNum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader
            Dim forPicBox As New Label
            dr.Read()
            forPicBox.Text = dr.Item("Pic")
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

            Dim IOFileStream As New IO.FileStream(forPicBox.Text, IO.FileMode.Open, IO.FileAccess.Read)
            Dim tempimage As Image = Image.FromStream(IOFileStream)
            studpicPB.Image = tempimage
            IOFileStream.Dispose()
            dr.Close()




        End If

        forprintstudschedonsearchstud()

    End Sub

    Private Sub previewCMD_Click(sender As Object, e As EventArgs) Handles previewCMD.Click
        CType(PrintPreviewDialog1.Controls(1), ToolStrip).Items(0).Enabled = False
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

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
        e.Graphics.DrawString(Label10.Text, fillall, Brushes.Black, 210, 725)

        Dim objBmp As New Bitmap(DataGridView1.Width, DataGridView1.Height)
        DataGridView1.DrawToBitmap(objBmp, New Rectangle(0, 0, DataGridView1.Width, DataGridView1.Height))
        e.Graphics.DrawImage(objBmp, 15, 750)

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

    Private Sub displayinfoDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles displayinfoDGV.CellContentClick

    End Sub

    Private Sub displayinfoDGV_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles displayinfoDGV.CellEnter
        Dim forselectedrow As String
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then

            index = e.RowIndex + 1
            selectedrow = displayinfoDGV.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            selectedrowtoprint.Text = forselectedrow
            selectedrowp.Text = forselectedrow
            forsearch = "select * from studInfoTBL where IDNum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)

            dr = cmd.ExecuteReader
            Dim forPicBox As New Label
            dr.Read()
            forPicBox.Text = dr("Pic").ToString
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

            Dim IOFileStream As New IO.FileStream(forPicBox.Text, IO.FileMode.Open, IO.FileAccess.Read)
            Dim tempimage As Image = Image.FromStream(IOFileStream)
            studpicPB.Image = tempimage
            IOFileStream.Dispose()

            dr.Close()

            forprintstudschedonsearchstud()

            forprinttotaluntisonsearchstudfrm()

        Else

            selectedrow = displayinfoDGV.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            selectedrowtoprint.Text = forselectedrow
            selectedrowp.Text = forselectedrow
            forsearch = "select * from studInfoTBL where IDNum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)

            dr = cmd.ExecuteReader
            Dim forPicBox As New Label
            dr.Read()
            forPicBox.Text = dr.Item("Pic")
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

            Dim IOFileStream As New IO.FileStream(forPicBox.Text, IO.FileMode.Open, IO.FileAccess.Read)
            Dim tempimage As Image = Image.FromStream(IOFileStream)
            studpicPB.Image = tempimage
            IOFileStream.Dispose()

            dr.Close()

            forprintstudschedonsearchstud()

            forprinttotaluntisonsearchstudfrm()

        End If


    End Sub

End Class