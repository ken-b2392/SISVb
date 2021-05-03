Imports System
Imports System.IO
Imports MySql.Data.MySqlClient

Module module1



    Public constr As String = "server=127.0.0.1; uid=root; pwd=ProjectSystem; database=sisdatabase"
    Public con As New MySqlConnection(constr)
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public dadpt As New MySqlDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet

    Public query, forInsert, forcount, forprimeK, schoolyear, selectedRB, forsearch, forupdate As String
    Public countStud As Int32

    Public forsemestercmbo, forselectedRB, forqualifier, forgender, forcourse, foryrlvl, forCStats As String

    Public defaultpicpath As String = Path.GetFullPath("default pic.png")
    Public comparestring As String = Path.GetFullPath("default pic.png")
    Public toaddstudpicdefault As String = defaultpicpath

    Public Sub connectDB()

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
            End
        End Try


    End Sub

    Public Sub foraddstudent()
       
        Dim fordateTODAY As System.DateTime = System.DateTime.Now
        Dim monthNOW, dayNOW, yearNOW, timeNOW, DToday As String
        monthNOW = fordateTODAY.Month
        dayNOW = fordateTODAY.Day
        yearNOW = fordateTODAY.Year
        timeNOW = Format(Now, "hhmmss")

        DToday = monthNOW & dayNOW & yearNOW & timeNOW

        forcount = "select COUNT(*)AS Row_Count from studInfoTBL"
        cmd = New MySqlCommand(forcount, con)
        Dim rowcount As Integer = Convert.ToInt32(cmd.ExecuteScalar)

        Dim yrcheck As String
        Dim listb As New ListBox
        Dim firstIDNum As New Label
        yrcheck = ""
        forsearch = "select * from studInfoTBL where SYFrom like '%" + addStudfrm.SyFromTXT.Text + "%'"
        cmd = New MySqlCommand(forsearch, con)
        listb.Items.Clear()
        dr = cmd.ExecuteReader
        While dr.Read
            listb.Items.Add(dr.Item("StudNum"))
            firstIDNum.Text = CInt(dr.Item("StudNum"))
            yrcheck = dr.Item("SYFrom")
        End While
        dr.Close()

        schoolyear = addStudfrm.SyFromTXT.Text & addStudfrm.SyToTXT.Text

        If addStudfrm.NewStudRB.Checked = True Then
            selectedRB = addStudfrm.NewStudRB.Text
        ElseIf addStudfrm.OldStudRB.Checked = True Then
            selectedRB = addStudfrm.OldStudRB.Text
        ElseIf addStudfrm.RetStudRB.Checked = True Then
            selectedRB = addStudfrm.RetStudRB.Text
        ElseIf addStudfrm.TransStudRB.Checked = True Then
            selectedRB = addStudfrm.TransStudRB.Text
        End If

        Dim tryPB As New PictureBox

        tryPB.Image = My.Resources.default_pic
        Dim forsemesterDB As String
        If addStudfrm.semesterCMBO.SelectedIndex = 1 Then
            forsemesterDB = "1"
        Else
            forsemesterDB = "2"
        End If

        If rowcount = 0 Then
            'this is for adding/inserting first student's data

            Dim forIDNum As Integer = 0
            Dim toadd As Integer = forIDNum + 1

            If String.Equals("1", addStudfrm.clickedBrowse) Then
                'determines if the student picture is taken from browsing the pc/laptop and the first student info


                File.Copy(addStudfrm.pathbrowsedpic, "StudentPics\" & addStudfrm.SyFromTXT.Text & toadd.ToString().PadLeft(6, "0") & ".jpg", True)

                Dim forbrowsedpic As String = My.Computer.FileSystem.CombinePath(Path.GetFullPath(addStudfrm.forcreatefolder), _
                                                                                         addStudfrm.SyFromTXT.Text & toadd.ToString().PadLeft(6, "0") & ".jpg")
                Dim forpicpath As String = forbrowsedpic.Replace("\", "\\")
                forprimeK = schoolyear & "-" & forsemesterDB & "-" & toadd.ToString().PadLeft(6, "0")

                forInsert = "insert into studInfoTBL (IDNum, StudNum, StudGender, FName, MidName, FamName, Qualifier, SYFrom, SYTo, Semester, Status, " _
                    & "Pic, Course, YearLevel, ContactNum, Birthdate, Age, CivilStat, Religion, EmailAdd, PlaceBirth, PresentAdd, HomeAdd, FatherName, FatherOccupation, " _
                    & "FatherContactNum, MotherName, MotherOccupation, MotherContactNum) VALUES ('" + forprimeK + "' , '" + toadd.ToString().PadLeft(6, "0") + "' , '" _
                    + addStudfrm.studGenderCMBO.Text + "' , '" + addStudfrm.FnameTXT.Text + "' , '" + addStudfrm.MidnameTXT.Text + "' , '" _
                    + addStudfrm.FamnameTXT.Text + "' , '" + addStudfrm.QualiCMBO.Text + "' , '" + addStudfrm.SyFromTXT.Text + "' , '" + addStudfrm.SyToTXT.Text + "' , '" _
                    + addStudfrm.semesterCMBO.Text + "' , '" + selectedRB + "' , '" + forpicpath + "' , '" + addStudfrm.courseCMBO.Text + "' , '" _
                    + addStudfrm.yearCMBO.Text + "' , '" + addStudfrm.ContactNoTXT.Text + "' , ' " + addStudfrm.BdayDTP.Text + "' , '" + addStudfrm.ageLBL.Text + "' , '" _
                    + addStudfrm.CivilStatCMBO.Text + "' , '" + addStudfrm.religionTXT.Text + "' , '" + addStudfrm.emailAddTXT.Text + "' , '" _
                    + addStudfrm.PlaceBirthTXT.Text + "' , '" + addStudfrm.PresentAddTXT.Text + "' , '" + addStudfrm.HomeAddTXT.Text + "' , '" _
                    + addStudfrm.fathernameTXT.Text + "' , '" + addStudfrm.fatherOccTXT.Text + "' , '" + addStudfrm.fatherContactTXT.Text + "' , '" _
                    + addStudfrm.MotherNameTXT.Text + "' , '" + addStudfrm.MotherOccTXT.Text + "' , '" + addStudfrm.MotherContactTXT.Text + "')"
                cmd = New MySqlCommand(forInsert, con)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Student Information Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                forReloadDGVSearchStudfrm()
                forLoadDGVUpdateStudfrm()
                forAfterUpdateStudInfo()

            ElseIf String.Equals("1", addStudfrm.clickedCapture) Then
                'for capturing student pic through camera (WEBCAM)
                
                forprimeK = schoolyear & "-" & forsemesterDB & "-" & toadd.ToString().PadLeft(6, "0")


                addStudfrm.studpicPB.Image.Save(My.Computer.FileSystem.CombinePath(Path.GetFullPath(addStudfrm.forcreatefolder), _
                                                                                   addStudfrm.SyFromTXT.Text & toadd.ToString().PadLeft(6, "0") & ".jpg"))

                Dim forcapturedpic As String = My.Computer.FileSystem.CombinePath(Path.GetFullPath(addStudfrm.forcreatefolder), _
                                                                                     addStudfrm.SyFromTXT.Text & toadd.ToString().PadLeft(6, "0") & ".jpg")


                Dim forpicpath As String = forcapturedpic.Replace("\", "\\")

                forInsert = "insert into studInfoTBL (IDNum, StudNum, StudGender, FName, MidName, FamName, Qualifier, SYFrom, SYTo, Semester, Status, Pic, Course, " _
                    & "YearLevel, ContactNum, Birthdate, Age, CivilStat, Religion, EmailAdd, PlaceBirth, PresentAdd, HomeAdd, FatherName, FatherOccupation, FatherContactNum, " _
                    & "MotherName, MotherOccupation, MotherContactNum) VALUES ('" + forprimeK + "' , '" + toadd.ToString().PadLeft(6, "0") + "' , '" _
                    + addStudfrm.studGenderCMBO.Text + "' , '" + addStudfrm.FnameTXT.Text + "' , '" + addStudfrm.MidnameTXT.Text + "' , '" _
                    + addStudfrm.FamnameTXT.Text + "' , '" + addStudfrm.QualiCMBO.Text + "' , '" + addStudfrm.SyFromTXT.Text + "' , '" + addStudfrm.SyToTXT.Text + "' , '" _
                    + addStudfrm.semesterCMBO.Text + "' , '" + selectedRB + "' , '" + forpicpath + "' , '" + addStudfrm.courseCMBO.Text + "' , '" _
                    + addStudfrm.yearCMBO.Text + "' , '" + addStudfrm.ContactNoTXT.Text + "' , '" + addStudfrm.BdayDTP.Text + "' , '" + addStudfrm.ageLBL.Text + "' , '" _
                    + addStudfrm.CivilStatCMBO.Text + "' , '" + addStudfrm.religionTXT.Text + "' , '" + addStudfrm.emailAddTXT.Text + "' , '" _
                    + addStudfrm.PlaceBirthTXT.Text + "' , '" + addStudfrm.PresentAddTXT.Text + "' , '" + addStudfrm.HomeAddTXT.Text + "' , '" _
                    + addStudfrm.fathernameTXT.Text + "' , '" + addStudfrm.fatherOccTXT.Text + "' , '" + addStudfrm.fatherContactTXT.Text + "' , '" _
                    + addStudfrm.MotherNameTXT.Text + "' , '" + addStudfrm.MotherOccTXT.Text + "' , '" + addStudfrm.MotherContactTXT.Text + "')"
                cmd = New MySqlCommand(forInsert, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Student Information Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                forReloadDGVSearchStudfrm()
                forLoadDGVUpdateStudfrm()
                forAfterUpdateStudInfo()

            ElseIf String.Equals(defaultpicpath, comparestring) Then
                'this is for the default student picture and the first student info

                Dim toDefPic As String
                toDefPic = tryPB.Image.ToString
                forprimeK = schoolyear & "-" & forsemesterDB & "-" & toadd.ToString().PadLeft(6, "0")

                File.Copy(toaddstudpicdefault, "StudentPics\" & addStudfrm.SyFromTXT.Text & toadd.ToString().PadLeft(6, "0") & ".jpg", True)
                Dim fordefaultfilepathpic As String = My.Computer.FileSystem.CombinePath(Path.GetFullPath(addStudfrm.forcreatefolder), _
                                                                                         addStudfrm.SyFromTXT.Text & toadd.ToString().PadLeft(6, "0") & ".jpg")
                Dim forpicpath As String = fordefaultfilepathpic.Replace("\", "\\")

                forInsert = "insert into studInfoTBL (IDNum, StudNum, StudGender, FName, MidName, FamName, Qualifier, SYFrom, SYTo, Semester, " _
                    & "Status, Pic, Course, YearLevel, ContactNum, Birthdate, Age, CivilStat, Religion, EmailAdd, PlaceBirth, PresentAdd, HomeAdd, FatherName, " _
                    & "FatherOccupation, FatherContactNum, MotherName, MotherOccupation, MotherContactNum) VALUES ('" + forprimeK + "' , '" _
                    + toadd.ToString().PadLeft(6, "0") + "' , '" + addStudfrm.studGenderCMBO.Text + "' , '" + addStudfrm.FnameTXT.Text + "' , '" _
                    + addStudfrm.MidnameTXT.Text + "' , '" + addStudfrm.FamnameTXT.Text + "' , '" + addStudfrm.QualiCMBO.Text + "' , '" + addStudfrm.SyFromTXT.Text + "' , '" _
                    + addStudfrm.SyToTXT.Text + "' , '" + addStudfrm.semesterCMBO.Text + "' , '" + selectedRB + "' , '" + forpicpath + "' , '" _
                    + addStudfrm.courseCMBO.Text + "' , '" + addStudfrm.yearCMBO.Text + "' , '" + addStudfrm.ContactNoTXT.Text + "' , '" + addStudfrm.BdayDTP.Text + "' , '" _
                    + addStudfrm.ageLBL.Text + "' , '" + addStudfrm.CivilStatCMBO.Text + "' , '" + addStudfrm.religionTXT.Text + "' , '" _
                    + addStudfrm.emailAddTXT.Text + "' , '" + addStudfrm.PlaceBirthTXT.Text + "' , '" + addStudfrm.PresentAddTXT.Text + "' , '" _
                    + addStudfrm.HomeAddTXT.Text + "' , '" + addStudfrm.fathernameTXT.Text + "' , '" + addStudfrm.fatherOccTXT.Text + "' , '" _
                    + addStudfrm.fatherContactTXT.Text + "' , '" + addStudfrm.MotherNameTXT.Text + "' , '" + addStudfrm.MotherOccTXT.Text + "' , '" _
                    + addStudfrm.MotherContactTXT.Text + "')"
                cmd = New MySqlCommand(forInsert, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Student Information Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                forReloadDGVSearchStudfrm()
                forLoadDGVUpdateStudfrm()
                forAfterUpdateStudInfo()

            End If

        ElseIf rowcount = 1 Then
            'this is for adding/inserting 2nd student's data
            If String.Equals("1", addStudfrm.clickedBrowse) Then
                If firstIDNum.Text.Length = 0 Then
                    firstIDNum.Text = 0
                End If
                'determines if the student picture is taken from browsing the pc/laptop and the 2nd student info
                Dim addfirstIDNum As Integer = CInt(firstIDNum.Text) + 1
                Dim toDefPic As String
                toDefPic = tryPB.Image.ToString
                forprimeK = schoolyear & "-" & forsemesterDB & "-" & addfirstIDNum.ToString().PadLeft(6, "0")

                File.Copy(addStudfrm.pathbrowsedpic, "StudentPics\" & addStudfrm.SyFromTXT.Text & addfirstIDNum.ToString().PadLeft(6, "0") & ".jpg", True)

                Dim forbrowsedpic As String = My.Computer.FileSystem.CombinePath(Path.GetFullPath(addStudfrm.forcreatefolder), _
                                                                                         addStudfrm.SyFromTXT.Text & addfirstIDNum.ToString().PadLeft(6, "0") & ".jpg")
                Dim forpicpath As String = forbrowsedpic.Replace("\", "\\")
                forInsert = "insert into studInfoTBL (IDNum, StudNum, StudGender, FName, MidName, FamName, Qualifier, SYFrom, SYTo, Semester, Status, Pic, Course, " _
                    & "YearLevel, ContactNum, Birthdate, Age, CivilStat, Religion, EmailAdd, PlaceBirth, PresentAdd, HomeAdd, FatherName, FatherOccupation, FatherContactNum, " _
                    & "MotherName, MotherOccupation, MotherContactNum) VALUES ('" + forprimeK + "' , '" + addfirstIDNum.ToString().PadLeft(6, "0") + "' , '" _
                    + addStudfrm.studGenderCMBO.Text + "' , '" + addStudfrm.FnameTXT.Text + "' , '" + addStudfrm.MidnameTXT.Text + "' , '" _
                    + addStudfrm.FamnameTXT.Text + "' , '" + addStudfrm.QualiCMBO.Text + "' , '" + addStudfrm.SyFromTXT.Text + "' , '" + addStudfrm.SyToTXT.Text + "' , '" _
                    + addStudfrm.semesterCMBO.Text + "' , '" + selectedRB + "' , '" + forpicpath + "' , '" + addStudfrm.courseCMBO.Text + "' , '" _
                    + addStudfrm.yearCMBO.Text + "' , '" + addStudfrm.ContactNoTXT.Text + "' , '" + addStudfrm.BdayDTP.Text + "' , '" + addStudfrm.ageLBL.Text + "' , '" _
                    + addStudfrm.CivilStatCMBO.Text + "' , '" + addStudfrm.religionTXT.Text + "' , '" + addStudfrm.emailAddTXT.Text + "' , '" _
                    + addStudfrm.PlaceBirthTXT.Text + "' , '" + addStudfrm.PresentAddTXT.Text + "' , '" + addStudfrm.HomeAddTXT.Text + "' , '" _
                    + addStudfrm.fathernameTXT.Text + "' , '" + addStudfrm.fatherOccTXT.Text + "' , '" + addStudfrm.fatherContactTXT.Text + "' , '" _
                    + addStudfrm.MotherNameTXT.Text + "' , '" + addStudfrm.MotherOccTXT.Text + "' , '" + addStudfrm.MotherContactTXT.Text + "')"
                cmd = New MySqlCommand(forInsert, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Student Information Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                forReloadDGVSearchStudfrm()
                forLoadDGVUpdateStudfrm()
                forAfterUpdateStudInfo()

            ElseIf String.Equals("1", addStudfrm.clickedCapture) Then
                'for capturing student pic through camera (WEBCAM)

                If firstIDNum.Text.Length = 0 Then
                    firstIDNum.Text = 0
                End If

                Dim addfirstIDNum As Integer = CInt(firstIDNum.Text) + 1
                Dim toDefPic As String
                toDefPic = tryPB.Image.ToString
                forprimeK = schoolyear & "-" & forsemesterDB & "-" & addfirstIDNum.ToString().PadLeft(6, "0")


                addStudfrm.studpicPB.Image.Save(My.Computer.FileSystem.CombinePath(Path.GetFullPath(addStudfrm.forcreatefolder), _
                                                                                   addStudfrm.SyFromTXT.Text & addfirstIDNum.ToString().PadLeft(6, "0") & ".jpg"))

                Dim forcapturedpic As String = My.Computer.FileSystem.CombinePath(Path.GetFullPath(addStudfrm.forcreatefolder), _
                                                                                     addStudfrm.SyFromTXT.Text & addfirstIDNum.ToString().PadLeft(6, "0") & ".jpg")


                Dim forpicpath As String = forcapturedpic.Replace("\", "\\")

                forInsert = "insert into studInfoTBL (IDNum, StudNum, StudGender, FName, MidName, FamName, Qualifier, SYFrom, SYTo, Semester, Status, Pic, Course, " _
                    & "YearLevel, ContactNum, Birthdate, Age, CivilStat, Religion, EmailAdd, PlaceBirth, PresentAdd, HomeAdd, FatherName, FatherOccupation, FatherContactNum, " _
                    & "MotherName, MotherOccupation, MotherContactNum) VALUES ('" + forprimeK + "' , '" + addfirstIDNum.ToString().PadLeft(6, "0") + "' , '" _
                    + addStudfrm.studGenderCMBO.Text + "' , '" + addStudfrm.FnameTXT.Text + "' , '" + addStudfrm.MidnameTXT.Text + "' , '" _
                    + addStudfrm.FamnameTXT.Text + "' , '" + addStudfrm.QualiCMBO.Text + "' , '" + addStudfrm.SyFromTXT.Text + "' , '" + addStudfrm.SyToTXT.Text + "' , '" _
                    + addStudfrm.semesterCMBO.Text + "' , '" + selectedRB + "' , '" + forpicpath + "' , '" + addStudfrm.courseCMBO.Text + "' , '" _
                    + addStudfrm.yearCMBO.Text + "' , '" + addStudfrm.ContactNoTXT.Text + "' , '" + addStudfrm.BdayDTP.Text + "' , '" + addStudfrm.ageLBL.Text + "' , '" _
                    + addStudfrm.CivilStatCMBO.Text + "' , '" + addStudfrm.religionTXT.Text + "' , '" + addStudfrm.emailAddTXT.Text + "' , '" _
                    + addStudfrm.PlaceBirthTXT.Text + "' , '" + addStudfrm.PresentAddTXT.Text + "' , '" + addStudfrm.HomeAddTXT.Text + "' , '" _
                    + addStudfrm.fathernameTXT.Text + "' , '" + addStudfrm.fatherOccTXT.Text + "' , '" + addStudfrm.fatherContactTXT.Text + "' , '" _
                    + addStudfrm.MotherNameTXT.Text + "' , '" + addStudfrm.MotherOccTXT.Text + "' , '" + addStudfrm.MotherContactTXT.Text + "')"
                cmd = New MySqlCommand(forInsert, con)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Student Information Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                forReloadDGVSearchStudfrm()
                forLoadDGVUpdateStudfrm()
                forAfterUpdateStudInfo()

            ElseIf String.Equals(defaultpicpath, comparestring) Then

                If firstIDNum.Text.Length = 0 Then
                    firstIDNum.Text = 0
                End If

                Dim addfirstIDNum As Integer = CInt(firstIDNum.Text) + 1
                forprimeK = schoolyear & "-" & forsemesterDB & "-" & addfirstIDNum.ToString().PadLeft(6, "0")

                File.Copy(toaddstudpicdefault, "StudentPics\" & addStudfrm.SyFromTXT.Text & addfirstIDNum.ToString().PadLeft(6, "0") & ".jpg", True)

                Dim fordefaultfilepathpic As String = My.Computer.FileSystem.CombinePath(Path.GetFullPath(addStudfrm.forcreatefolder), _
                                                                                         addStudfrm.SyFromTXT.Text & addfirstIDNum.ToString().PadLeft(6, "0") & ".jpg")
                Dim forpicpath As String = fordefaultfilepathpic.Replace("\", "\\")
                forInsert = "insert into studInfoTBL (IDNum, StudNum, StudGender, FName, MidName, FamName, Qualifier, SYFrom, SYTo, Semester, Status, Pic, " _
                    & "Course, YearLevel, ContactNum, Birthdate, Age, CivilStat, Religion, EmailAdd, PlaceBirth, PresentAdd, HomeAdd, FatherName, FatherOccupation, " _
                    & "FatherContactNum, MotherName, MotherOccupation, MotherContactNum) VALUES ('" + forprimeK + "' , '" _
                    + addfirstIDNum.ToString().PadLeft(6, "0") + "' , '" + addStudfrm.studGenderCMBO.Text + "' , '" + addStudfrm.FnameTXT.Text + "' , '" _
                    + addStudfrm.MidnameTXT.Text + "' , '" + addStudfrm.FamnameTXT.Text + "' , '" + addStudfrm.QualiCMBO.Text + "' , '" + addStudfrm.SyFromTXT.Text + "' , '" _
                    + addStudfrm.SyToTXT.Text + "' , '" + addStudfrm.semesterCMBO.Text + "' , '" + selectedRB + "' , '" + forpicpath + "' , '" _
                    + addStudfrm.courseCMBO.Text + "' , '" + addStudfrm.yearCMBO.Text + "' , '" + addStudfrm.ContactNoTXT.Text + "' , '" + addStudfrm.BdayDTP.Text + "' , '" _
                    + addStudfrm.ageLBL.Text + "' , '" + addStudfrm.CivilStatCMBO.Text + "' , '" + addStudfrm.religionTXT.Text + "' , '" _
                    + addStudfrm.emailAddTXT.Text + "' , '" + addStudfrm.PlaceBirthTXT.Text + "' , '" + addStudfrm.PresentAddTXT.Text + "' , '" _
                    + addStudfrm.HomeAddTXT.Text + "' , '" + addStudfrm.fathernameTXT.Text + "' , '" + addStudfrm.fatherOccTXT.Text + "' , '" _
                    + addStudfrm.fatherContactTXT.Text + "' , '" + addStudfrm.MotherNameTXT.Text + "' , '" + addStudfrm.MotherOccTXT.Text + "' , '" _
                    + addStudfrm.MotherContactTXT.Text + "')"
                cmd = New MySqlCommand(forInsert, con)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Student Information Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                forReloadDGVSearchStudfrm()
                forLoadDGVUpdateStudfrm()
                forAfterUpdateStudInfo()

            End If
        Else


            If addStudfrm.SyFromTXT.Text.Contains(yrcheck) Then

                Dim lastYrNum As Integer = 0
                For Each item As Integer In listb.Items
                    If item > lastYrNum Then lastYrNum = item
                Next
                Dim lastYearNumber As Integer = lastYrNum

                Dim toaddstudnum As Integer = CInt(lastYearNumber)
                countStud = toaddstudnum + 1

                forprimeK = schoolyear & "-" & forsemesterDB & "-" & countStud.ToString().PadLeft(6, "0")


                If String.Equals("1", addStudfrm.clickedBrowse) Then



                    forprimeK = schoolyear & "-" & forsemesterDB & "-" & countStud.ToString().PadLeft(6, "0")

                    File.Copy(addStudfrm.pathbrowsedpic, "StudentPics\" & addStudfrm.SyFromTXT.Text & countStud.ToString().PadLeft(6, "0") & ".jpg", True)

                    Dim forbrowsedpic As String = My.Computer.FileSystem.CombinePath(Path.GetFullPath(addStudfrm.forcreatefolder), _
                                                                                         addStudfrm.SyFromTXT.Text & countStud.ToString().PadLeft(6, "0") & ".jpg")
                    Dim forpicpath As String = forbrowsedpic.Replace("\", "\\")

                    forInsert = "insert into studInfoTBL (IDNum, StudNum, StudGender, FName, MidName, FamName, Qualifier, SYFrom, SYTo, Semester, Status, Pic, Course, " _
                        & "YearLevel, ContactNum, Birthdate, Age, CivilStat, Religion, EmailAdd, PlaceBirth, PresentAdd, HomeAdd, FatherName, FatherOccupation, FatherContactNum, " _
                        & "MotherName, MotherOccupation, MotherContactNum) VALUES ('" + forprimeK + "' , '" + countStud.ToString().PadLeft(6, "0") + "' , '" _
                        + addStudfrm.studGenderCMBO.Text + "' , '" + addStudfrm.FnameTXT.Text + "' , '" + addStudfrm.MidnameTXT.Text + "' , '" _
                        + addStudfrm.FamnameTXT.Text + "' , '" + addStudfrm.QualiCMBO.Text + "' , '" + addStudfrm.SyFromTXT.Text + "' , '" + addStudfrm.SyToTXT.Text + "' , '" _
                        + addStudfrm.semesterCMBO.Text + "' , '" + selectedRB + "' , '" + forpicpath + "' , '" + addStudfrm.courseCMBO.Text + "' , '" _
                        + addStudfrm.yearCMBO.Text + "' , '" + addStudfrm.ContactNoTXT.Text + "' , '" + addStudfrm.BdayDTP.Text + "' , '" + addStudfrm.ageLBL.Text + "' , '" _
                        + addStudfrm.CivilStatCMBO.Text + "' , '" + addStudfrm.religionTXT.Text + "' , '" + addStudfrm.emailAddTXT.Text + "' , '" _
                        + addStudfrm.PlaceBirthTXT.Text + "' , '" + addStudfrm.PresentAddTXT.Text + "' , '" + addStudfrm.HomeAddTXT.Text + "' , '" _
                        + addStudfrm.fathernameTXT.Text + "' , '" + addStudfrm.fatherOccTXT.Text + "' , '" + addStudfrm.fatherContactTXT.Text + "' , '" _
                        + addStudfrm.MotherNameTXT.Text + "' , '" + addStudfrm.MotherOccTXT.Text + "' , '" + addStudfrm.MotherContactTXT.Text + "')"
                    cmd = New MySqlCommand(forInsert, con)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Student Information Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    forReloadDGVSearchStudfrm()
                    forLoadDGVUpdateStudfrm()
                    forAfterUpdateStudInfo()

                ElseIf String.Equals("1", addStudfrm.clickedCapture) Then


                    forprimeK = schoolyear & "-" & forsemesterDB & "-" & countStud.ToString().PadLeft(6, "0")

                    addStudfrm.studpicPB.Image.Save(My.Computer.FileSystem.CombinePath(Path.GetFullPath(addStudfrm.forcreatefolder), _
                                                                                       addStudfrm.SyFromTXT.Text & countStud.ToString().PadLeft(6, "0") & ".jpg"))

                    Dim forcapturedpic As String = My.Computer.FileSystem.CombinePath(Path.GetFullPath(addStudfrm.forcreatefolder), _
                                                                                         addStudfrm.SyFromTXT.Text & countStud.ToString().PadLeft(6, "0") & ".jpg")
                    Dim forpicpath As String = forcapturedpic.Replace("\", "\\")

                    forInsert = "insert into studInfoTBL (IDNum, StudNum, StudGender, FName, MidName, FamName, Qualifier, SYFrom, SYTo, Semester, Status, Pic, Course, " _
                        & "YearLevel, ContactNum, Birthdate, Age, CivilStat, Religion, EmailAdd, PlaceBirth, PresentAdd, HomeAdd, FatherName, FatherOccupation, FatherContactNum, " _
                        & "MotherName, MotherOccupation, MotherContactNum) VALUES ('" + forprimeK + "' , '" + countStud.ToString().PadLeft(6, "0") + "' , '" _
                        + addStudfrm.studGenderCMBO.Text + "' , '" + addStudfrm.FnameTXT.Text + "' , '" + addStudfrm.MidnameTXT.Text + "' , '" _
                        + addStudfrm.FamnameTXT.Text + "' , '" + addStudfrm.QualiCMBO.Text + "' , '" + addStudfrm.SyFromTXT.Text + "' , '" + addStudfrm.SyToTXT.Text + "' , '" _
                        + addStudfrm.semesterCMBO.Text + "' , '" + selectedRB + "' , '" + forpicpath + "' , '" + addStudfrm.courseCMBO.Text + "' , '" _
                        + addStudfrm.yearCMBO.Text + "' , '" + addStudfrm.ContactNoTXT.Text + "' , '" + addStudfrm.BdayDTP.Text + "' , '" + addStudfrm.ageLBL.Text + "' , '" _
                        + addStudfrm.CivilStatCMBO.Text + "' , '" + addStudfrm.religionTXT.Text + "' , '" + addStudfrm.emailAddTXT.Text + "' , '" _
                        + addStudfrm.PlaceBirthTXT.Text + "' , '" + addStudfrm.PresentAddTXT.Text + "' , '" + addStudfrm.HomeAddTXT.Text + "' , '" _
                        + addStudfrm.fathernameTXT.Text + "' , '" + addStudfrm.fatherOccTXT.Text + "' , '" + addStudfrm.fatherContactTXT.Text + "' , '" _
                        + addStudfrm.MotherNameTXT.Text + "' , '" + addStudfrm.MotherOccTXT.Text + "' , '" + addStudfrm.MotherContactTXT.Text + "')"
                    cmd = New MySqlCommand(forInsert, con)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Student Information Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    forReloadDGVSearchStudfrm()
                    forLoadDGVUpdateStudfrm()
                    forAfterUpdateStudInfo()

                ElseIf String.Equals(defaultpicpath, comparestring) Then


                    forprimeK = schoolyear & "-" & forsemesterDB & "-" & countStud.ToString().PadLeft(6, "0")
                    File.Copy(toaddstudpicdefault, "StudentPics\" & addStudfrm.SyFromTXT.Text & countStud.ToString().PadLeft(6, "0") & ".jpg", True)
                    Dim fordefaultfilepathpic As String
                    fordefaultfilepathpic = My.Computer.FileSystem.CombinePath(Path.GetFullPath(addStudfrm.forcreatefolder), _
                                                                               addStudfrm.SyFromTXT.Text & countStud.ToString().PadLeft(6, "0") & ".jpg")

                    Dim forpicpath As String = fordefaultfilepathpic.Replace("\", "\\")
                    forInsert = "insert into studInfoTBL (IDNum, StudNum, StudGender, FName, MidName, FamName, Qualifier, SYFrom, SYTo, Semester, Status, " _
                        & "Pic, Course, YearLevel, ContactNum, Birthdate, Age, CivilStat, Religion, EmailAdd, PlaceBirth, PresentAdd, HomeAdd, FatherName, " _
                        & "FatherOccupation, FatherContactNum, MotherName, MotherOccupation, MotherContactNum) VALUES ('" _
                        + forprimeK + "' , '" + countStud.ToString.PadLeft(6, "0") + "' , '" + addStudfrm.studGenderCMBO.Text + "' , '" _
                        + addStudfrm.FnameTXT.Text + "' , '" + addStudfrm.MidnameTXT.Text + "' , '" + addStudfrm.FamnameTXT.Text + "' , '" _
                        + addStudfrm.QualiCMBO.Text + "' , '" + addStudfrm.SyFromTXT.Text + "' , '" + addStudfrm.SyToTXT.Text + "' , '" + addStudfrm.semesterCMBO.Text + "' , '" _
                        + selectedRB + "' , '" + forpicpath + "' , '" + addStudfrm.courseCMBO.Text + "' , '" + addStudfrm.yearCMBO.Text + "' , '" _
                        + addStudfrm.ContactNoTXT.Text + "' , '" + addStudfrm.BdayDTP.Text + "' , '" + addStudfrm.ageLBL.Text + "' , '" _
                        + addStudfrm.CivilStatCMBO.Text + "' , '" + addStudfrm.religionTXT.Text + "' , '" + addStudfrm.emailAddTXT.Text + "' , '" _
                        + addStudfrm.PlaceBirthTXT.Text + "' , '" + addStudfrm.PresentAddTXT.Text + "' , '" + addStudfrm.HomeAddTXT.Text + "' , '" _
                        + addStudfrm.fathernameTXT.Text + "' , '" + addStudfrm.fatherOccTXT.Text + "' , '" + addStudfrm.fatherContactTXT.Text + "' , '" _
                        + addStudfrm.MotherNameTXT.Text + "' , '" + addStudfrm.MotherOccTXT.Text + "' , '" + addStudfrm.MotherContactTXT.Text + "')"
                    cmd = New MySqlCommand(forInsert, con)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Student Information Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    forReloadDGVSearchStudfrm()
                    forLoadDGVUpdateStudfrm()
                    forAfterUpdateStudInfo()


                End If
            Else

            End If


        End If





    End Sub

    Public Sub forbackfromaddstudent()

        If addStudfrm.SyFromTXT.Text.Length = 0 And addStudfrm.SyToTXT.Text.Length = 0 And addStudfrm.MidnameTXT.Text.Length = 0 And addStudfrm.HomeAddTXT.Text.Length = 0 And addStudfrm.MotherContactTXT.Text.Length = 0 Then
            addStudfrm.firstPANEL.Visible = True

            With addStudfrm.firstPANEL
                .Visible = True
                .Location = New Point(217, 145)
                .Size = New Size(628, 285)
            End With

            addStudfrm.semesterCMBO.Enabled = False
            addStudfrm.statusStudGB.Enabled = False
            addStudfrm.namestudGB.Enabled = False
            addStudfrm.nextPANEL.Enabled = False

            With addStudfrm.studGenderCMBO
                .SelectedIndex = 0
            End With

            With addStudfrm.semesterCMBO
                .SelectedIndex = 0
            End With

            With addStudfrm.QualiCMBO
                .SelectedIndex = 0
            End With

            With addStudfrm.courseCMBO
                .SelectedIndex = 0
            End With

            With addStudfrm.yearCMBO
                .SelectedIndex = 0
                .Enabled = False
            End With

            With addStudfrm.CivilStatCMBO
                .SelectedIndex = 0
            End With

            addStudfrm.SyFromTXT.Clear()
            addStudfrm.SyToTXT.Clear()
            addStudfrm.NewStudRB.Checked = False
            addStudfrm.OldStudRB.Checked = False
            addStudfrm.RetStudRB.Checked = False
            addStudfrm.TransStudRB.Checked = False
            addStudfrm.FamnameTXT.Clear()
            addStudfrm.FnameTXT.Clear()
            addStudfrm.MidnameTXT.Clear()


            addStudfrm.ContactNoTXT.Clear()
            addStudfrm.emailAddTXT.Clear()
            addStudfrm.PlaceBirthTXT.Clear()
            addStudfrm.PresentAddTXT.Clear()
            addStudfrm.HomeAddTXT.Clear()

            addStudfrm.fathernameTXT.Clear()
            addStudfrm.fatherOccTXT.Clear()
            addStudfrm.fatherContactTXT.Clear()
            addStudfrm.MotherNameTXT.Clear()
            addStudfrm.MotherOccTXT.Clear()
            addStudfrm.MotherContactTXT.Clear()

            addStudfrm.semesterCMBO.Enabled = False
            addStudfrm.statusStudGB.Enabled = False
            addStudfrm.namestudGB.Enabled = False
            addStudfrm.nextPANEL.Enabled = False

            addStudfrm.ContactNoTXT.Clear()
            addStudfrm.ContactNoTXT.Enabled = False
            addStudfrm.BdayDTP.Enabled = False

            addStudfrm.CivilStatCMBO.SelectedIndex = 0
            addStudfrm.CivilStatCMBO.Enabled = False

            addStudfrm.religionTXT.Clear()
            addStudfrm.emailAddTXT.Clear()
            addStudfrm.emailAddTXT.Enabled = False
            addStudfrm.PlaceBirthTXT.Clear()
            addStudfrm.PlaceBirthTXT.Enabled = False
            addStudfrm.PresentAddTXT.Clear()
            addStudfrm.PresentAddTXT.Enabled = False
            addStudfrm.HomeAddTXT.Clear()
            addStudfrm.HomeAddTXT.Enabled = False

            addStudfrm.fathernameTXT.Enabled = True
            addStudfrm.fatherContactTXT.Enabled = False
            addStudfrm.fatherOccTXT.Enabled = False
            addStudfrm.MotherNameTXT.Enabled = False
            addStudfrm.MotherContactTXT.Enabled = False
            addStudfrm.MotherOccTXT.Enabled = False

            addStudfrm.secPANEL.Visible = False
            addStudfrm.thirdPANEL.Visible = False

            addStudfrm.previousPANEL.Hide()

            Mainfrm.Enabled = True
            Mainfrm.Show()
            addStudfrm.Hide()
        Else

            Dim decide As DialogResult = MessageBox.Show("All information you entered will be nullified.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If decide = DialogResult.Yes Then

                addStudfrm.studpicPB.Image = Image.FromFile(defaultpicpath)

                addStudfrm.firstPANEL.Visible = True

                With addStudfrm.firstPANEL
                    .Visible = True
                    .Location = New Point(217, 145)
                    .Size = New Size(628, 285)
                End With



                addStudfrm.semesterCMBO.Enabled = False
                addStudfrm.statusStudGB.Enabled = False
                addStudfrm.namestudGB.Enabled = False
                addStudfrm.nextPANEL.Enabled = False

                With addStudfrm.studGenderCMBO
                    .SelectedIndex = 0
                End With

                With addStudfrm.semesterCMBO

                    .SelectedIndex = 0
                End With

                With addStudfrm.QualiCMBO
                    .SelectedIndex = 0
                End With


                With addStudfrm.courseCMBO
                    .SelectedIndex = 0
                End With


                With addStudfrm.yearCMBO
                    .SelectedIndex = 0
                    .Enabled = False
                End With

                With addStudfrm.CivilStatCMBO
                    .SelectedIndex = 0
                End With


                addStudfrm.SyFromTXT.Clear()
                addStudfrm.SyToTXT.Clear()
                addStudfrm.NewStudRB.Checked = False
                addStudfrm.OldStudRB.Checked = False
                addStudfrm.RetStudRB.Checked = False
                addStudfrm.TransStudRB.Checked = False
                addStudfrm.FamnameTXT.Clear()
                addStudfrm.FnameTXT.Clear()
                addStudfrm.MidnameTXT.Clear()


                addStudfrm.ContactNoTXT.Clear()
                addStudfrm.emailAddTXT.Clear()
                addStudfrm.PlaceBirthTXT.Clear()
                addStudfrm.PresentAddTXT.Clear()
                addStudfrm.HomeAddTXT.Clear()

                addStudfrm.fathernameTXT.Clear()
                addStudfrm.fatherOccTXT.Clear()
                addStudfrm.fatherContactTXT.Clear()
                addStudfrm.MotherNameTXT.Clear()
                addStudfrm.MotherOccTXT.Clear()
                addStudfrm.MotherContactTXT.Clear()

                addStudfrm.semesterCMBO.Enabled = False
                addStudfrm.statusStudGB.Enabled = False
                addStudfrm.namestudGB.Enabled = False
                addStudfrm.nextPANEL.Enabled = False

                addStudfrm.ContactNoTXT.Clear()
                addStudfrm.ContactNoTXT.Enabled = False
                addStudfrm.BdayDTP.Enabled = False

                addStudfrm.CivilStatCMBO.SelectedIndex = 0
                addStudfrm.CivilStatCMBO.Enabled = False

                addStudfrm.religionTXT.Clear()
                addStudfrm.emailAddTXT.Clear()
                addStudfrm.emailAddTXT.Enabled = False
                addStudfrm.PlaceBirthTXT.Clear()
                addStudfrm.PlaceBirthTXT.Enabled = False
                addStudfrm.PresentAddTXT.Clear()
                addStudfrm.PresentAddTXT.Enabled = False
                addStudfrm.HomeAddTXT.Clear()
                addStudfrm.HomeAddTXT.Enabled = False

                addStudfrm.fathernameTXT.Enabled = True
                addStudfrm.fatherContactTXT.Enabled = False
                addStudfrm.fatherOccTXT.Enabled = False
                addStudfrm.MotherNameTXT.Enabled = False
                addStudfrm.MotherContactTXT.Enabled = False
                addStudfrm.MotherOccTXT.Enabled = False

                addStudfrm.thirdPANEL.Visible = False
                addStudfrm.secPANEL.Visible = False

                addStudfrm.previousPANEL.Hide()


                Mainfrm.Enabled = True
                addStudfrm.Hide()
                Mainfrm.Show()
            ElseIf decide = DialogResult.No Then

            End If


        End If

    End Sub

    Public Sub forformLoadaddstudfrm()

        Dim pb As New PictureBox
        pb.Image = Image.FromFile(defaultpicpath)
        Dim IOMemStream As New IO.MemoryStream
        pb.Image.Save(IOMemStream, Imaging.ImageFormat.Jpeg)
        addStudfrm.studpicPB.Image = Image.FromStream(IOMemStream)

        With addStudfrm.previousPB
            .Size = New Size(47, 47)
            .Location = New Point((addStudfrm.previousPANEL.Width / 2) - (addStudfrm.previousPB.Width / 2), (addStudfrm.previousPANEL.Height / 2) - (addStudfrm.previousPB.Height / 2))
        End With

        With addStudfrm.nextPB
            .Size = New Size(47, 47)
            .Location = New Point((addStudfrm.nextPANEL.Width / 2) - (addStudfrm.nextPB.Width / 2), (addStudfrm.nextPANEL.Height / 2) - (addStudfrm.nextPB.Height / 2))
        End With

        addStudfrm.previousPANEL.Hide()

        With addStudfrm.firstPANEL
            .Visible = True
            .Location = New Point(217, 145)
            .Size = New Size(628, 285)
        End With

        addStudfrm.secPANEL.Visible = False
        addStudfrm.thirdPANEL.Visible = False



        addStudfrm.semesterCMBO.Enabled = False
        addStudfrm.statusStudGB.Enabled = False
        addStudfrm.namestudGB.Enabled = False
        addStudfrm.nextPANEL.Enabled = False
        addStudfrm.MidnameTXT.Enabled = False
        addStudfrm.FamnameTXT.Enabled = False
        addStudfrm.QualiCMBO.Enabled = False



        With addStudfrm.studGenderCMBO
            .Items.Add("")
            .Items.Add("M")
            .Items.Add("F")
            .SelectedIndex = 0
        End With

        With addStudfrm.semesterCMBO
            .Items.Add("")
            .Items.Add("1st")
            .Items.Add("2nd")
            .Items.Add("Summer")
            .SelectedIndex = 0
        End With

        With addStudfrm.QualiCMBO
            .Items.Add("")
            .Items.Add("N/A")
            .Items.Add("Jr.")
            .Items.Add("Sr.")
            .Items.Add("I")
            .Items.Add("II")
            .Items.Add("III")
            .Items.Add("IV")
            .Items.Add("V")
            .SelectedIndex = 0
        End With


        With addStudfrm.courseCMBO
            .Items.Add("")
            .Items.Add("BSIT")
            .Items.Add("BSBA")
            .Items.Add("BSED")
            .SelectedIndex = 0
            .Enabled = False
        End With


        With addStudfrm.yearCMBO
            .Items.Add("")
            .Items.Add("1st")
            .Items.Add("2nd")
            .Items.Add("3rd")
            .Items.Add("4th")
            .SelectedIndex = 0
            .Enabled = False
        End With

        With addStudfrm.CivilStatCMBO
            .Items.Add("")
            .Items.Add("Single")
            .Items.Add("Married")
            .Items.Add("Widow")
            .Items.Add("Widower")
            .SelectedIndex = 0
        End With

       

        addStudfrm.SyToTXT.ReadOnly = True
        addStudfrm.SyToTXT.TextAlign = HorizontalAlignment.Center
        addStudfrm.SyFromTXT.TextAlign = HorizontalAlignment.Center

        addStudfrm.ContactNoTXT.Clear()
        addStudfrm.ContactNoTXT.Enabled = False
        addStudfrm.BdayDTP.Enabled = False
        addStudfrm.ageLBL.Text = "  "
        addStudfrm.CivilStatCMBO.SelectedIndex = 0
        addStudfrm.CivilStatCMBO.Enabled = False

        addStudfrm.religionTXT.Clear()
        addStudfrm.emailAddTXT.Clear()
        addStudfrm.emailAddTXT.Enabled = False
        addStudfrm.PlaceBirthTXT.Clear()
        addStudfrm.PlaceBirthTXT.Enabled = False
        addStudfrm.PresentAddTXT.Clear()
        addStudfrm.PresentAddTXT.Enabled = False
        addStudfrm.HomeAddTXT.Clear()
        addStudfrm.HomeAddTXT.Enabled = False

        addStudfrm.fathernameTXT.Enabled = True
        addStudfrm.fatherContactTXT.Enabled = False
        addStudfrm.fatherOccTXT.Enabled = False
        addStudfrm.MotherNameTXT.Enabled = False
        addStudfrm.MotherContactTXT.Enabled = False
        addStudfrm.MotherOccTXT.Enabled = False
    End Sub

    Public Sub forLoadSearchStudfrm()

        Try

            ds.Tables.Clear()
            Dim query As String = "select IDNum as 'Student ID Number', FName as 'First Name', MidName as 'Middle Name', FamName as 'Family Name', Qualifier, " _
                                  & "StudGender as 'Gender', Course, SYFrom as 'SY From', SYTo as 'SY To', Status, YearLevel as 'Year Level', " _
                                  & "CivilStat as 'Civil Status', EmailAdd as 'Email Address', Religion, Birthdate, " _
                                  & "PresentAdd as 'Present Address', HomeAdd as 'Home Address', PlaceBirth as 'Place of Birth', FatherName as 'Fathers Name', " _
                                  & "FatherContactNum as 'Fathers Contact Number', FatherOccupation as 'Fathers Occupation', MotherName as 'Mothers Name', " _
                                  & "MotherContactNum as 'Mothers Contact Number', MotherOccupation as 'Mothers Occupation' from studInfoTBL"

            dadpt.SelectCommand = New MySqlCommand(query, con)
            dadpt.Fill(ds, query)

            With searchstudfrm.displayinfoDGV
                .DataSource = ds.Tables(0)
                .AutoResizeColumns()
            End With
        Catch ex As Exception
            MessageBox.Show("For load DGV catch " & ex.Message, "Error on Loading Data in DGV", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub forReloadDGVSearchStudfrm()
        Try

            ds.Tables.Clear()

            Dim reload As String = "select IDNum as 'Student ID Number', FName as 'First Name', MidName as 'Middle Name', FamName as 'Family Name', Qualifier, " _
                                  & "StudGender as 'Gender', Course, SYFrom as 'SY From', SYTo as 'SY To', Status, YearLevel as 'Year Level', " _
                                  & "CivilStat as 'Civil Status', EmailAdd as 'Email Address', Religion, Birthdate, " _
                                  & "PresentAdd as 'Present Address', HomeAdd as 'Home Address', PlaceBirth as 'Place of Birth', FatherName as 'Fathers Name', " _
                                  & "FatherContactNum as 'Fathers Contact Number', FatherOccupation as 'Fathers Occupation', MotherName as 'Mothers Name', " _
                                  & "MotherContactNum as 'Mothers Contact Number', MotherOccupation as 'Mothers Occupation' from studInfoTBL"

            dadpt.SelectCommand = New MySqlCommand(reload, con)

            dadpt.Fill(ds, reload)

            With searchstudfrm.displayinfoDGV
                .DataSource = ds.Tables(0)
                .AutoResizeColumns()
            End With


        Catch ex As Exception
            MessageBox.Show("For reload catch " & ex.Message, "Error on Reloading DGV", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub forSearchStudent()
        Try
            ds.Tables.Clear()

            forsearch = "select IDNum as 'Student ID Number', FName as 'First Name', MidName as 'Middle Name', FamName as 'Family Name', Qualifier as 'Qualifier', " _
                                  & "StudGender as 'Gender', Course as 'Course', SYFrom as 'School Year From', SYTo as 'School Year To', Status as 'Status', YearLevel as 'Year Level', " _
                                  & "CivilStat as 'Civil Status', EmailAdd as 'Email Address', Religion as 'Religion', Birthdate as 'Birthdate', " _
                                  & "PresentAdd as 'Present Address', HomeAdd as 'Home Address', PlaceBirth as 'Place of Birth', FatherName as 'Name of Father', " _
                                  & "FatherContactNum as 'Fathers Contact Number', FatherOccupation as 'Fathers Occupation', MotherName as 'Name of Mother', " _
                                  & "MotherContactNum as 'Mothers Contact Number', MotherOccupation as 'Mothers Occupation' from studInfoTBL where " _
                                  + searchstudfrm.forselectedsearchby + " like '%" + searchstudfrm.searchBarTXT.Text + "%'"

            dadpt.SelectCommand = New MySqlCommand(forsearch, con)
            dadpt.Fill(ds, forsearch)
            With searchstudfrm.displayinfoDGV
                .DataSource = ds.Tables(0)
                .AutoResizeColumns()
            End With
            dr.Close()


        Catch ex As Exception
            MessageBox.Show("For Student Search Catch " & ex.Message, "Error on Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub forLoadDetails()
        updateStudInfofrm.SyFromTXT.Text = dr.Item("SYFrom")
        updateStudInfofrm.IDNumStorage = dr.Item("IDNum")
        updateStudInfofrm.SyToTXT.Text = dr.Item("SYTo")
        updateStudInfofrm.semTXT.Text = dr.Item("Semester")
        forselectedRB = dr.Item("Status")
        updateStudInfofrm.FnameTXT.Text = dr.Item("FName")
        updateStudInfofrm.MidnameTXT.Text = dr.Item("MidName")
        updateStudInfofrm.FamnameTXT.Text = dr.Item("FamName")
        forqualifier = dr.Item("Qualifier")
        forgender = dr.Item("StudGender")
        forcourse = dr.Item("Course")
        foryrlvl = dr.Item("YearLevel")
        updateStudInfofrm.ContactNoTXT.Text = dr.Item("ContactNum")
        updateStudInfofrm.BdayDTP.Text = dr.Item("Birthdate")
        updateStudInfofrm.ageLBL.Text = dr.Item("Age")
        forCStats = dr.Item("CivilStat")
        updateStudInfofrm.religionTXT.Text = dr.Item("Religion")
        updateStudInfofrm.emailAddTXT.Text = dr.Item("EmailAdd")
        updateStudInfofrm.PlaceBirthTXT.Text = dr.Item("PlaceBirth")
        updateStudInfofrm.PresentAddTXT.Text = dr.Item("PresentAdd")
        updateStudInfofrm.HomeAddTXT.Text = dr.Item("HomeAdd")
        updateStudInfofrm.fathernameTXT.Text = dr.Item("FatherName")
        updateStudInfofrm.fatherOccTXT.Text = dr.Item("FatherOccupation")
        updateStudInfofrm.fatherContactTXT.Text = dr.Item("FatherContactNum")
        updateStudInfofrm.MotherNameTXT.Text = dr.Item("MotherName")
        updateStudInfofrm.MotherOccTXT.Text = dr.Item("MotherOccupation")
        updateStudInfofrm.MotherContactTXT.Text = dr.Item("MotherContactNum")


        updateStudInfofrm.studGenderCMBO.SelectedItem = forgender
        updateStudInfofrm.QualiCMBO.SelectedItem = forqualifier
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

    End Sub

    Public Sub forAfterUpdateStudInfo()
        forReloadDGVSearchStudfrm()
        forLoadDGVUpdateStudfrm()
        updateStudInfofrm.StudIDNumTXT.ReadOnly = True
        updateStudInfofrm.SyFromTXT.ReadOnly = True
        updateStudInfofrm.SyFromTXT.ReadOnly = True
        updateStudInfofrm.semTXT.ReadOnly = True
        Dim txtctrl, rbctrl, cmboctrl As Control
        For Each txtctrl In updateStudInfofrm.Controls
            If TypeOf txtctrl Is TextBox Then
                txtctrl.Text = Nothing
                txtctrl.BackColor = Color.White
            End If
        Next
        For Each rbctrl In updateStudInfofrm.Controls
            If TypeOf rbctrl Is RadioButton Then
                TryCast(rbctrl, RadioButton).Checked = False
            End If
        Next
        For Each cmboctrl In updateStudInfofrm.Controls
            If TypeOf cmboctrl Is ComboBox Then
                TryCast(cmboctrl, ComboBox).SelectedItem = ""
                TryCast(cmboctrl, ComboBox).BackColor = Color.White
            End If
        Next

        Dim IOMemStream As New IO.MemoryStream
        Dim studpicStoragePB As New PictureBox
        studpicStoragePB.Image = Image.FromFile(defaultpicpath)
        studpicStoragePB.Image.Save(IOMemStream, Imaging.ImageFormat.Png)
        updateStudInfofrm.studpicPB.Image = Image.FromStream(IOMemStream)
    End Sub

    Public Sub forUpdateStudInfo()
        dr.Close()
        If String.Equals("1", updateStudInfofrm.forbrowsedclicked) Then

            If updateStudInfofrm.NewStudRB.Checked = True Then
                selectedRB = updateStudInfofrm.NewStudRB.Text
            ElseIf updateStudInfofrm.OldStudRB.Checked = True Then
                selectedRB = updateStudInfofrm.OldStudRB.Text
            ElseIf updateStudInfofrm.RetStudRB.Checked = True Then
                selectedRB = updateStudInfofrm.RetStudRB.Text
            ElseIf updateStudInfofrm.TransStudRB.Checked = True Then
                selectedRB = updateStudInfofrm.TransStudRB.Text
            End If

            Dim transferedpicpath As String = My.Computer.FileSystem.CombinePath(Path.GetFullPath("StudentPics\"), updateStudInfofrm.SyFromTXT.Text & _
                                                                          updateStudInfofrm.forstudnumber & ".jpg")

            System.IO.File.Copy(updateStudInfofrm.forpathbrowsedpic, transferedpicpath, True)

            Dim forpicpath As String = transferedpicpath.Replace("\", "\\")

            dr.Close()
            forupdate = "update studInfoTBL set FName = '" + updateStudInfofrm.FnameTXT.Text + "', MidName = '" + updateStudInfofrm.MidnameTXT.Text + "' , FamName = '" _
                + updateStudInfofrm.FamnameTXT.Text + "', Qualifier = '" + updateStudInfofrm.QualiCMBO.Text + "', StudGender = '" + updateStudInfofrm.studGenderCMBO.Text _
                + "', SYFrom = '" + updateStudInfofrm.SyFromTXT.Text + "', SYTo = '" + updateStudInfofrm.SyToTXT.Text + "', Status = '" + selectedRB + "', YearLevel = '" _
                + updateStudInfofrm.yearCMBO.Text + "', ContactNum = '" + updateStudInfofrm.ContactNoTXT.Text _
                + "', Course = '" + updateStudInfofrm.courseCMBO.Text + "', Birthdate = '" + updateStudInfofrm.BdayDTP.Text + "', Age = '" + updateStudInfofrm.ageLBL.Text _
                + "', Pic = '" + forpicpath + "', CivilStat = '" + updateStudInfofrm.CivilStatCMBO.Text + "', Religion = '" _
                + updateStudInfofrm.religionTXT.Text + "', EmailAdd = '" + updateStudInfofrm.emailAddTXT.Text + "', PlaceBirth = '" + updateStudInfofrm.PlaceBirthTXT.Text _
                + "', PresentAdd  = '" + updateStudInfofrm.PresentAddTXT.Text + "', HomeAdd = '" + updateStudInfofrm.HomeAddTXT.Text + "', FatherName = '" _
                + updateStudInfofrm.fathernameTXT.Text + "', FatherOccupation = '" + updateStudInfofrm.fatherOccTXT.Text + "', FatherContactNum = '" _
                + updateStudInfofrm.fatherContactTXT.Text + "', MotherName = '" + updateStudInfofrm.MotherNameTXT.Text + "', MotherOccupation = '" _
                + updateStudInfofrm.MotherOccTXT.Text + "', MotherContactNum = '" + updateStudInfofrm.MotherContactTXT.Text _
                + "' where IDNum = '" + updateStudInfofrm.StudIDNumTXT.Text + "'"

            cmd = New MySqlCommand(forupdate, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Student Information Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            forReloadDGVSearchStudfrm()
            forLoadDGVUpdateStudfrm()
            forAfterUpdateStudInfo()

        ElseIf String.Equals("1", updateStudInfofrm.forcaptureclicked) Then

            If updateStudInfofrm.NewStudRB.Checked = True Then
                selectedRB = updateStudInfofrm.NewStudRB.Text
            ElseIf updateStudInfofrm.OldStudRB.Checked = True Then
                selectedRB = updateStudInfofrm.OldStudRB.Text
            ElseIf updateStudInfofrm.RetStudRB.Checked = True Then
                selectedRB = updateStudInfofrm.RetStudRB.Text
            ElseIf updateStudInfofrm.TransStudRB.Checked = True Then
                selectedRB = updateStudInfofrm.TransStudRB.Text
            End If

            updateStudInfofrm.studpicPB.Image.Save(My.Computer.FileSystem.CombinePath(Path.GetFullPath(addStudfrm.forcreatefolder), _
                                                                               updateStudInfofrm.SyFromTXT.Text & updateStudInfofrm.forstudnumber & ".jpg"))

            Dim browsedpic As String = My.Computer.FileSystem.CombinePath(Path.GetFullPath("StudentPics\"), updateStudInfofrm.SyFromTXT.Text & _
                                                                          updateStudInfofrm.forstudnumber & ".jpg")

            Dim forpicpath As String = browsedpic.Replace("\", "\\")
            dr.Close()
            forupdate = "update studInfoTBL set FName = '" + updateStudInfofrm.FnameTXT.Text + "', MidName = '" + updateStudInfofrm.MidnameTXT.Text + "' , FamName = '" _
                + updateStudInfofrm.FamnameTXT.Text + "', Qualifier = '" + updateStudInfofrm.QualiCMBO.Text + "', StudGender = '" + updateStudInfofrm.studGenderCMBO.Text _
                + "', SYFrom = '" + updateStudInfofrm.SyFromTXT.Text + "', SYTo = '" + updateStudInfofrm.SyToTXT.Text + "', Status = '" + selectedRB + "', YearLevel = '" _
                + updateStudInfofrm.yearCMBO.Text + "', ContactNum = '" + updateStudInfofrm.ContactNoTXT.Text + "', Course = '" + updateStudInfofrm.courseCMBO.Text _
                + "', Birthdate = '" + updateStudInfofrm.BdayDTP.Text + "', Age = '" + updateStudInfofrm.ageLBL.Text + "', Pic = '" + forpicpath + "', CivilStat = '" _
                + updateStudInfofrm.CivilStatCMBO.Text + "', Religion = '" + updateStudInfofrm.religionTXT.Text + "', EmailAdd = '" + updateStudInfofrm.emailAddTXT.Text _
                + "', PlaceBirth = '" + updateStudInfofrm.PlaceBirthTXT.Text + "', PresentAdd  = '" + updateStudInfofrm.PresentAddTXT.Text + "', HomeAdd = '" _
                + updateStudInfofrm.HomeAddTXT.Text + "', FatherName = '" + updateStudInfofrm.fathernameTXT.Text + "', FatherOccupation = '" _
                + updateStudInfofrm.fatherOccTXT.Text + "', FatherContactNum = '" + updateStudInfofrm.fatherContactTXT.Text + "', MotherName = '" _
                + updateStudInfofrm.MotherNameTXT.Text + "', MotherOccupation = '" + updateStudInfofrm.MotherOccTXT.Text + "', MotherContactNum = '" _
                + updateStudInfofrm.MotherContactTXT.Text + "' where IDNum = '" + updateStudInfofrm.StudIDNumTXT.Text + "'"

            cmd = New MySqlCommand(forupdate, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Student Information Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            forReloadDGVSearchStudfrm()
            forLoadDGVUpdateStudfrm()
            forAfterUpdateStudInfo()


        Else

            If updateStudInfofrm.NewStudRB.Checked = True Then
                selectedRB = updateStudInfofrm.NewStudRB.Text
            ElseIf updateStudInfofrm.OldStudRB.Checked = True Then
                selectedRB = updateStudInfofrm.OldStudRB.Text
            ElseIf updateStudInfofrm.RetStudRB.Checked = True Then
                selectedRB = updateStudInfofrm.RetStudRB.Text
            ElseIf updateStudInfofrm.TransStudRB.Checked = True Then
                selectedRB = updateStudInfofrm.TransStudRB.Text
            End If

            dr.Close()
            forupdate = "update studInfoTBL set FName = '" + updateStudInfofrm.FnameTXT.Text + "', MidName = '" + updateStudInfofrm.MidnameTXT.Text + "' , FamName = '" _
                + updateStudInfofrm.FamnameTXT.Text + "', Qualifier = '" + updateStudInfofrm.QualiCMBO.Text + "', StudGender = '" + updateStudInfofrm.studGenderCMBO.Text _
                + "', SYFrom = '" + updateStudInfofrm.SyFromTXT.Text + "', SYTo = '" + updateStudInfofrm.SyToTXT.Text + "', Status = '" + selectedRB + "', YearLevel = '" _
                + updateStudInfofrm.yearCMBO.Text + "', ContactNum = '" + updateStudInfofrm.ContactNoTXT.Text + "', Course = '" + updateStudInfofrm.courseCMBO.Text _
                + "', Birthdate = '" + updateStudInfofrm.BdayDTP.Text + "', Age = '" + updateStudInfofrm.ageLBL.Text + "', CivilStat = '" + updateStudInfofrm.CivilStatCMBO.Text _
                + "', Religion = '" + updateStudInfofrm.religionTXT.Text + "', EmailAdd = '" + updateStudInfofrm.emailAddTXT.Text + "', PlaceBirth = '" _
                + updateStudInfofrm.PlaceBirthTXT.Text + "', PresentAdd  = '" + updateStudInfofrm.PresentAddTXT.Text + "', HomeAdd = '" _
                + updateStudInfofrm.HomeAddTXT.Text + "', FatherName = '" + updateStudInfofrm.fathernameTXT.Text + "', FatherOccupation = '" _
                + updateStudInfofrm.fatherOccTXT.Text + "', FatherContactNum = '" + updateStudInfofrm.fatherContactTXT.Text + "', MotherName = '" _
                + updateStudInfofrm.MotherNameTXT.Text + "', MotherOccupation = '" + updateStudInfofrm.MotherOccTXT.Text + "', MotherContactNum = '" _
                + updateStudInfofrm.MotherContactTXT.Text + "' where IDNum = '" + updateStudInfofrm.StudIDNumTXT.Text + "'"

            cmd = New MySqlCommand(forupdate, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Student Information Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            forReloadDGVSearchStudfrm()
            forLoadDGVUpdateStudfrm()
            forAfterUpdateStudInfo()

        End If

    End Sub

    Public Sub forFormLoadUpdateStudInfoFRM()
        With updateStudInfofrm.studGenderCMBO
            .Items.Add("")
            .Items.Add("M")
            .Items.Add("F")
        End With

        With updateStudInfofrm.QualiCMBO
            .Items.Add("")
            .Items.Add("N/A")
            .Items.Add("Jr.")
            .Items.Add("Sr.")
            .Items.Add("I")
            .Items.Add("II")
            .Items.Add("III")
            .Items.Add("IV")
            .Items.Add("V")
        End With


        With updateStudInfofrm.courseCMBO
            .Items.Add("")
            .Items.Add("BSIT")
            .Items.Add("BSBA")
            .Items.Add("BSED")
        End With


        With updateStudInfofrm.yearCMBO
            .Items.Add("")
            .Items.Add("1st")
            .Items.Add("2nd")
            .Items.Add("3rd")
            .Items.Add("4th")
        End With

        With updateStudInfofrm.CivilStatCMBO
            .Items.Add("")
            .Items.Add("Single")
            .Items.Add("Married")
            .Items.Add("Widow")
            .Items.Add("Widower")
        End With

        
    End Sub

    Public Sub forLoadDGVUpdateStudfrm()
        Try

            Dim query As String = "select IDNum as 'Student ID Number', FName as 'First Name', MidName as 'Middle Name', FamName as 'Family Name', Qualifier, " _
                                  & "StudGender as 'Gender' from studInfoTBL"
            
            dadpt.SelectCommand = New MySqlCommand(query, con)
            ds.Tables.Clear()
            dadpt.Fill(ds, query)
            With updateStudInfofrm.displayStudforUpdateDGV
                .DataSource = ds.Tables(0)
                .AutoResizeColumns()
            End With


        Catch ex As Exception
            MessageBox.Show("For reload catch " & ex.Message, "Error on Reloading DGV", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub forBacktoSearchStudent()
        dr.Close()
        searchstudfrm.Enabled = True
        searchstudfrm.Show()
        updateStudInfofrm.Hide()
    End Sub

    Public Sub forSearchtoUpdateStudInfo()
        Try

            dt.Clear()

            Dim query As String = "select IDNum as 'Student ID Number', FName as 'First Name', MidName as 'Middle Name', FamName as 'Family Name', Qualifier, " _
                                  & "StudGender as 'Gender' from studInfoTBL where " + updateStudInfofrm.forselectedsearchby + " like '%" + updateStudInfofrm.searchBarTXT.Text + "%'"
            cmd = New MySqlCommand(query, con)
            cmd.CommandType = CommandType.Text
            dt.Load(cmd.ExecuteReader)
            updateStudInfofrm.displayStudforUpdateDGV.DataSource = dt


        Catch ex As Exception
            MessageBox.Show("For Student Search Catch " & ex.Message, "Error on Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub forsameDGVSelectedRow()
        Try

            dt.Clear()

            Dim query As String = "select IDNum as 'Student ID Number', FName as 'First Name', MidName as 'Middle Name', FamName as 'Family Name', Qualifier, " _
                                  & "StudGender as 'Gender' from studInfoTBL where IDNum like '%" + searchstudfrm.forselectedrow + "%'"
            cmd = New MySqlCommand(query, con)
            cmd.CommandType = CommandType.Text
            dt.Load(cmd.ExecuteReader)
            updateStudInfofrm.displayStudforUpdateDGV.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("For Student Search Catch " & ex.Message, "Error on Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub forloadcontrolnum()
        Try

            Dim tocountnumrows As String = "select controlnum from schooladminaccntstbl"
            Dim controlnumcount As New ListBox
            Dim lbl As New Label
            controlnumcount.Items.Clear()
            cmd = New MySqlCommand(tocountnumrows, con)
            dr = cmd.ExecuteReader
            While dr.Read
                controlnumcount.Items.Add(dr.Item("controlnum"))
                lbl.Text = dr.Item("controlnum")

            End While
            If controlnumcount.Items.Count = 0 Then
                registernewAccfrm.controlnumLBL.Text = 1.ToString().PadLeft(6, "0")
            Else
                Dim toadd As String = ""
                toadd = CInt(lbl.Text + 1)
                registernewAccfrm.controlnumLBL.Text = toadd.ToString().PadLeft(6, "0")
            End If
            dr.Close()
            con.Close()
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub forRegisterSchoolAdminAcc()

        Dim usernlist As New ListBox
        Dim forcheckacc As String = "select * from schooladminaccntstbl where usern like '%" + registernewAccfrm.reguserTXT.Text + "%'"
        cmd = New MySqlCommand(forcheckacc, con)
        dr = cmd.ExecuteReader
        While dr.Read
            usernlist.Items.Add(dr.Item("usern"))
        End While
        dr.Close()

        If usernlist.Items.Contains(registernewAccfrm.reguserTXT.Text) Then
            MessageBox.Show("The username has been already used.", "Username Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim fordateTODAY As System.DateTime = System.DateTime.Now
            Dim monthNOW, dayNOW, yearNOW, timeNOW, DToday As String
            monthNOW = fordateTODAY.Month
            dayNOW = fordateTODAY.Day
            yearNOW = fordateTODAY.Year
            timeNOW = Format(Now, "hh:mm:ss")

            DToday = monthNOW & "/" & dayNOW & "/" & yearNOW

            Dim insertnewSchoolAdminAcc As String = "insert into schooladminaccntstbl (controlnum, usern, userpass, datecreated, timecreated) VALUES ('" _
                                                    + registernewAccfrm.controlnumLBL.Text + "' , '" + registernewAccfrm.reguserTXT.Text + "', '" _
                                                    + registernewAccfrm.regconfirmpassTXT.Text + "' , '" + DToday + "' , '" + timeNOW + "')"
            cmd = New MySqlCommand(insertnewSchoolAdminAcc, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("New User has been registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            forloadDGVSchoolAdminAcc()
            registernewAccfrm.reguserTXT.Text = Nothing
            registernewAccfrm.regpassTXT.Text = Nothing
            registernewAccfrm.regconfirmpassTXT.Text = Nothing

        End If
    End Sub

    Public Sub forloadDGVSchoolAdminAcc()
        Try


            ds.Tables.Clear()

            Dim displaySchoolAdminAcc As String = "select controlnum as 'Control Number', usern as 'Username', userpass as 'Password', datecreated as 'Date Created', timecreated as 'Time Created' " _
                                  & "from schooladminaccntstbl"

            dadpt.SelectCommand = New MySqlCommand(displaySchoolAdminAcc, con)
            dadpt.Fill(ds, displaySchoolAdminAcc)
            With searchAccfrm.schoolAdminAccDGV
                .DataSource = ds.Tables(0)
                .AutoResizeColumns()
            End With
            dr.Close()


           

        Catch ex As Exception
            MessageBox.Show("For reload catch " & ex.Message, "Error on Laoding DGV in School Admin Account", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub forsearchSchoolAdminAcc()
        Try

            Dim forsearchAdminAcc = "select controlnum as 'Control Number', usern as 'Username', userpass as 'Password', datecreated as 'Date Created', timecreated as 'Time Created' " _
                                    & "from schooladminaccntstbl where " + searchAccfrm.searchbySchoolAdminAcc + " like '%" + searchAccfrm.searchBarTXT.Text + "%'"

            dadpt = New MySqlDataAdapter(forsearchAdminAcc, con)
            dt.Clear()
            dadpt.Fill(dt)
            searchAccfrm.schoolAdminAccDGV.DataSource = dt

            con.Close()
            dadpt.Dispose()
            con.Open()

        Catch ex As Exception
            MessageBox.Show("For Student Search Catch " & ex.Message, "Error while searching in School Admin Account.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub forlogSchoolAdmin()

        Dim forsearchSchoolAdmin As String = "select * from schooladminaccntstbl where usern = '" + loginfrm.logusernametxt.Text + "'"
        cmd = New MySqlCommand(forsearchSchoolAdmin, con)
        dr = cmd.ExecuteReader

        Dim usern, pass, combinetxtdb, combinetxt, controlnumlbl As New Label
        Do While dr.Read
            usern.Text = dr.Item("usern")
            pass.Text = dr.Item("userpass")
            controlnumlbl.Text = dr.Item("controlnum")
            Mainfrm.ctrlnum.Text = dr.Item("controlnum")
            Mainfrm.usern.Text = dr.Item("usern")
            Mainfrm.userpas.Text = dr.Item("userpass")
        Loop
        dr.Close()

        combinetxtdb.Text = usern.Text & pass.Text
        combinetxt.Text = loginfrm.logusernametxt.Text & loginfrm.logpasstxt.Text

        If String.Equals(combinetxtdb.Text, combinetxt.Text) Then
            'create new table to have logs controlnumber,username,password,date,time

            Dim fordateTODAY As System.DateTime = System.DateTime.Now
            Dim monthNOW, dayNOW, yearNOW, timeNOW, DToday, typelog As String
            monthNOW = fordateTODAY.Month
            dayNOW = fordateTODAY.Day
            yearNOW = fordateTODAY.Year
            timeNOW = Format(Now, "hh:mm:ss")

            DToday = monthNOW & "/" & dayNOW & "/" & yearNOW
            typelog = "Login"
            Dim forlogs As String = "insert into logstbl (controlnum, username, pass, date, time, typeoflog) VALUES ('" _
                                                    + controlnumlbl.Text + "' , '" + loginfrm.logusernametxt.Text + "' , '" + loginfrm.logpasstxt.Text + "', '" _
                                                    + DToday + "' , '" + timeNOW + "' , '" + typelog + "')"
            cmd = New MySqlCommand(forlogs, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Welcome user: " & loginfrm.logusernametxt.Text & " have a nice day!", "Logged in Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loginfrm.logusernametxt.Text = Nothing
            loginfrm.logpasstxt.Text = Nothing
            loginfrm.logusernametxt.Focus()
            Mainfrm.Show()
            loginfrm.Hide()
        Else
            MsgBox("Incorrect Username/Password.", MsgBoxStyle.Critical)
            loginfrm.logusernametxt.Text = Nothing
            loginfrm.logpasstxt.Text = Nothing
            loginfrm.logusernametxt.Focus()
        End If


    End Sub

    Public Sub forlogout()
        dr.Close()
        Dim fordateTODAY As System.DateTime = System.DateTime.Now
        Dim monthNOW, dayNOW, yearNOW, timeNOW, DToday, typelog As String
        monthNOW = fordateTODAY.Month
        dayNOW = fordateTODAY.Day
        yearNOW = fordateTODAY.Year
        timeNOW = Format(Now, "hh:mm:ss")

        DToday = monthNOW & "/" & dayNOW & "/" & yearNOW
        typelog = "Logout"

        Dim forlogs As String = "insert into logstbl (controlnum, username, pass, date, time, typeoflog) VALUES ('" _
                                                + Mainfrm.ctrlnum.Text + "' , '" + Mainfrm.usern.Text + "' , '" + Mainfrm.userpas.Text + "', '" _
                                                + DToday + "' , '" + timeNOW + "' , '" + typelog + "')"
        cmd = New MySqlCommand(forlogs, con)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub forsysadminlogin()

        Dim forsearchsysadmin As String = "select * from systemadmintbl where adminusername like '%" + loginfrmSysAdmin.logusernametxt.Text + "%'"
        cmd = New MySqlCommand(forsearchsysadmin, con)
        dr = cmd.ExecuteReader

        Dim usern, pass, combinetxtdb, combinetxt, controlnumlbl As New Label
        Do While dr.Read
            usern.Text = dr.Item("adminusername")
            pass.Text = dr.Item("adminpassword")
            controlnumlbl.Text = dr.Item("admincountnum")
            Mainfrm.ctrlnum.Text = dr.Item("admincountnum")
            Mainfrm.usern.Text = dr.Item("adminusername")
            Mainfrm.userpas.Text = dr.Item("adminpassword")
        Loop
        dr.Close()

        combinetxtdb.Text = usern.Text & pass.Text
        combinetxt.Text = loginfrmSysAdmin.logusernametxt.Text & loginfrmSysAdmin.logpasstxt.Text
        If String.Equals(combinetxtdb.Text, combinetxt.Text) Then


            Dim fordateTODAY As System.DateTime = System.DateTime.Now
            Dim monthNOW, dayNOW, yearNOW, timeNOW, DToday, typelog As String
            monthNOW = fordateTODAY.Month
            dayNOW = fordateTODAY.Day
            yearNOW = fordateTODAY.Year
            timeNOW = Format(Now, "hh:mm:ss")

            DToday = monthNOW & "/" & dayNOW & "/" & yearNOW
            typelog = "Login"
            Dim forlogs As String = "insert into logstbl (controlnum, username, pass, date, time, typeoflog) VALUES ('" _
                                                    + controlnumlbl.Text + "' , '" + loginfrmSysAdmin.logusernametxt.Text + "' , '" + loginfrmSysAdmin.logpasstxt.Text + "', '" _
                                                    + DToday + "' , '" + timeNOW + "' , '" + typelog + "')"
            cmd = New MySqlCommand(forlogs, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Welcome user: " & loginfrmSysAdmin.logusernametxt.Text & " have a nice day!", "Logged in Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loginfrmSysAdmin.logusernametxt.Text = Nothing
            loginfrmSysAdmin.logpasstxt.Text = Nothing
            loginfrmSysAdmin.logusernametxt.Focus()
            Mainfrm.Show()
            loginfrmSysAdmin.Hide()

            Mainfrm.Show()
            loginfrmSysAdmin.Hide()
        Else
            MsgBox("Incorrect Username/Password.", MsgBoxStyle.Critical)
            loginfrmSysAdmin.logusernametxt.Text = Nothing
            loginfrmSysAdmin.logusernametxt.Focus()
            loginfrmSysAdmin.logpasstxt.Text = Nothing
        End If


    End Sub

    Public Sub forlogoutsysadmin()
        Dim fordateTODAY As System.DateTime = System.DateTime.Now
        Dim monthNOW, dayNOW, yearNOW, timeNOW, DToday, typelog As String
        monthNOW = fordateTODAY.Month
        dayNOW = fordateTODAY.Day
        yearNOW = fordateTODAY.Year
        timeNOW = Format(Now, "hh:mm:ss")

        DToday = monthNOW & "/" & dayNOW & "/" & yearNOW
        typelog = "Logout"
        Dim forlogs As String = "insert into logstbl (controlnum, username, pass, date, time, typeoflog) VALUES ('" _
                                                + Mainfrm.ctrlnum.Text + "' , '" + Mainfrm.usern.Text + "' , '" + Mainfrm.userpas.Text + "', '" _
                                                + DToday + "' , '" + timeNOW + "' , '" + typelog + "')"
        cmd = New MySqlCommand(forlogs, con)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub forconfirmcurrentsystemadpassword()
        Dim forsearchsysadmin As String = "select * from systemadmintbl where adminusername like '%" + sysAdminAccfrm.sysadcurUsernTXT.Text + "%'"
        cmd = New MySqlCommand(forsearchsysadmin, con)
        dr = cmd.ExecuteReader

        Dim usern, controlnumlbl As New Label
        Do While dr.Read
            usern.Text = dr.Item("adminusername")
            sysAdminAccfrm.pass.Text = dr.Item("adminpassword")
            controlnumlbl.Text = dr.Item("admincountnum")

        Loop
        dr.Close()


    End Sub

    Public Sub forupdatesystemadminusernamepassword()

        Dim forupdatesysad As String = "update systemadmintbl set adminusername = '" + sysAdminAccfrm.sysadnewusernTXT.Text + "', adminpassword = '" _
                                       + sysAdminAccfrm.sysaddconfirmPassTXT.Text + "' where admincountnum = 1"
        cmd = New MySqlCommand(forupdatesysad, con)
        cmd.ExecuteNonQuery()

        MessageBox.Show("System Admin Username and Password has been updated.", "Account Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim txtctrl As Control
        For Each txtctrl In sysAdminAccfrm.Controls
            If TypeOf txtctrl Is TextBox Then
                txtctrl.Text = Nothing
            End If
        Next
    End Sub



    'student info------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub displaylistofstudents()
        Try


            Dim fordisplaystud As String = "select IDNum as 'ID Number', FName as 'First Name', MidName as 'Middle Name', FamName as 'Family Name', Qualifier, " _
                                             & "StudGender as 'Gender', YearLevel as 'Year Level', Semester from studInfoTBL"
            dadpt.SelectCommand = New MySqlCommand(fordisplaystud, con)
            ds.Tables.Clear()
            dadpt.Fill(ds, fordisplaystud)
            With assignschedfrm.studentsDGV
                .DataSource = ds.Tables(0)
                .AutoResizeColumns()
            End With


        Catch ex As Exception
            MessageBox.Show("For Student Search Catch. " & ex.Message, "Error on Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub forDGVsearchstudentlist()

        Try


            Dim searchstudfromsubj As String = "select IDNum as 'ID Number', FName as 'First Name', MidName as 'Middle Name', FamName as 'Family Name', Qualifier, " _
                                             & "StudGender as 'Gender' from studInfoTBL where " + assignschedfrm.forselectedsearch + " like '%" + assignschedfrm.searchstudnameTXT.Text + "%'"
            dadpt.SelectCommand = New MySqlCommand(searchstudfromsubj, con)
            ds.Tables.Clear()
            dadpt.Fill(ds, searchstudfromsubj)
            With assignschedfrm.studentsDGV
                .DataSource = ds.Tables(0)
                .AutoResizeColumns()
            End With


        Catch ex As Exception
            MessageBox.Show("For Student Search Catch. " & ex.Message, "Error on Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub forLoadDGVdisplaytoassignsched()

        dr.Close()
        ds.Tables.Clear()


        Dim displaysubjectstoassign As String = "select subjectstbl.subjcountr, subjectstbl.subjCode as 'Subject Code', subjectstbl.subjDescript as 'Subject name', " _
                                                        & "teacherinfotbl.teachnamecode as 'Instructor', subjectstbl.subjUnit as 'Units', " _
                                                        & "subjectstbl.subjLecHr as 'No. of hour (Lec)', subjectstbl.subjLabHr as 'No. of hour (Lab)', " _
                                                        & "subjectstbl.subjTotalhr as 'Total hours', subjectstbl.subjDay as 'Day', subjectstbl.subjRoom as 'Room', " _
                                                        & "subjectstbl.subjTimefrom as 'Time in', subjectstbl.subjTimeTo as 'Time out' from assignedsubjtoteachtbl " _
                                                        & "inner join subjectstbl on assignedsubjtoteachtbl.subjcountr = subjectstbl.subjcountr inner join teacherinfotbl " _
                                                        & "on assignedsubjtoteachtbl.teachIDNum = teacherinfotbl.teachIDNum where subjectstbl.foryearlvl = '" _
                                                        + assignschedfrm.foryearlvl.Text + "' and subjectstbl.forsubjsem = '" + assignschedfrm.forsemester.Text + "'"


        dadpt.SelectCommand = New MySqlCommand(displaysubjectstoassign, con)
        dadpt.Fill(ds, displaysubjectstoassign)
        With assignschedfrm.subjectsDGV
            .DataSource = ds.Tables(0)
            .AutoResizeColumns()
            .Columns(0).Visible = False
        End With
        dr.Close()



    End Sub

    Public Sub forsortingsubj()

        dr.Close()
        ds.Tables.Clear()


        Dim displaysortedsubjectstoassign As String = "select subjectstbl.subjcountr, subjectstbl.subjCode as 'Subject Code', subjectstbl.subjDescript as 'Subject name', " _
                                                       & "teacherinfotbl.teachnamecode as 'Instructor', subjectstbl.subjUnit as 'Units', " _
                                                       & "subjectstbl.subjLecHr as 'No. of hour (Lec)', subjectstbl.subjLabHr as 'No. of hour (Lab)', " _
                                                       & "subjectstbl.subjTotalhr as 'Total hours', subjectstbl.subjDay as 'Day', subjectstbl.subjRoom as 'Room', " _
                                                       & "subjectstbl.subjTimefrom as 'Time in', subjectstbl.subjTimeTo as 'Time out' from assignedsubjtoteachtbl " _
                                                       & "inner join subjectstbl on assignedsubjtoteachtbl.subjcountr = subjectstbl.subjcountr inner join teacherinfotbl " _
                                                       & "on assignedsubjtoteachtbl.teachIDNum = teacherinfotbl.teachIDNum where subjectstbl.foryearlvl = '" _
                                                       + assignschedfrm.yearlvlCMBO.SelectedItem + "' and subjectstbl.forsubjsem = '" + assignschedfrm.semesterCMBO.SelectedItem + "'"


        dadpt.SelectCommand = New MySqlCommand(displaysortedsubjectstoassign, con)
        dadpt.Fill(ds, displaysortedsubjectstoassign)
        With assignschedfrm.subjectsDGV
            .DataSource = ds.Tables(0)
            .AutoResizeColumns()
            .Columns(0).Visible = False
        End With
        dr.Close()


    End Sub

    Public Sub searchsorttoassignsubjsched()

        dr.Close()
        ds.Tables.Clear()

        Dim displaysubjectstoassign As String = "select subjectstbl.subjcountr, subjectstbl.subjCode as 'Subject Code', subjectstbl.subjDescript as 'Subject name', " _
                                                        & "teacherinfotbl.teachnamecode as 'Instructor', subjectstbl.subjUnit as 'Units', " _
                                                        & "subjectstbl.subjLecHr as 'No. of hour (Lec)', subjectstbl.subjLabHr as 'No. of hour (Lab)', " _
                                                        & "subjectstbl.subjTotalhr as 'Total hours', subjectstbl.subjDay as 'Day', subjectstbl.subjRoom as 'Room', " _
                                                        & "subjectstbl.subjTimefrom as 'Time in', subjectstbl.subjTimeTo as 'Time out' from assignedsubjtoteachtbl " _
                                                        & "inner join subjectstbl on assignedsubjtoteachtbl.subjcountr = subjectstbl.subjcountr inner join teacherinfotbl " _
                                                        & "on assignedsubjtoteachtbl.teachIDNum = teacherinfotbl.teachIDNum where subjectstbl.foryearlvl = '" _
                                                        + assignschedfrm.yearlvlCMBO.SelectedItem + "' and subjectstbl.forsubjsem = '" _
                                                        + assignschedfrm.semesterCMBO.SelectedItem + "' and subjectstbl.subjDescript like '%" + assignschedfrm.searchbarsubjTXT.Text + "%'"

        dadpt.SelectCommand = New MySqlCommand(displaysubjectstoassign, con)
        dadpt.Fill(ds, displaysubjectstoassign)
        With assignschedfrm.subjectsDGV
            .DataSource = ds.Tables(0)
            .AutoResizeColumns()
            .Columns(0).Visible = False
        End With
        dr.Close()
    End Sub

    Public Sub forassigningsubj()

        If assignschedfrm.subjectsDGV.Rows.Count = 0 Then
        Else
            Dim forassignstudsched As String = "insert into studsubjtbl (IDNum, teachIDNum, subjcountr) VALUES ('" + assignschedfrm.forselectedrowstud _
                                           + "' , '" + assignschedfrm.forteachIDNum + "' , '" + assignschedfrm.forselectedsubjcountr.Text + "')"
            cmd = New MySqlCommand(forassignstudsched, con)
            cmd.ExecuteNonQuery()
        End If
        
    End Sub

    Public Sub fordisplaystudassignedsubj()
        dr.Close()
        ds.Tables.Clear()
        Dim displaydgvassignedsubjects As String = "select studsubjtbl.subjcountr, subjectstbl.subjCode as 'Subject Code', subjectstbl.subjDescript as 'Subject name', " _
                                                                    & "teacherinfotbl.teachnamecode as 'Instructor', subjectstbl.subjUnit as 'Units', " _
                                                                    & "subjectstbl.subjLecHr as 'No. of hour (Lec)', subjectstbl.subjLabHr as 'No. of hour (Lab)', " _
                                                                    & "subjectstbl.subjTotalhr as 'Total hours', subjectstbl.subjDay as 'Day', subjectstbl.subjRoom as 'Room', " _
                                                                    & "subjectstbl.subjTimefrom as 'Time in', subjectstbl.subjTimeTo as 'Time out' from studsubjtbl " _
                                                                    & "inner join subjectstbl on studsubjtbl.subjcountr = subjectstbl.subjcountr inner join teacherinfotbl " _
                                                                    & "on studsubjtbl.teachIDNum = teacherinfotbl.teachIDNum where studsubjtbl.IDNum = '" _
                                                                    + assignschedfrm.forselectedrowstud + "'"

        dadpt.SelectCommand = New MySqlCommand(displaydgvassignedsubjects, con)

        dadpt.Fill(ds, displaydgvassignedsubjects)
        With assignschedfrm.assignedsubj
            .DataSource = ds.Tables(0)
            .AutoResizeColumns()
            .Columns(0).Visible = False
        End With



    End Sub

    Public Sub removefromtoassignedsubj()


        assignschedfrm.forsubjcount.Items.Clear()

        Dim subjcountonly As New ListBox
        subjcountonly.Items.Clear()
        Dim loadstudsubj As String = "select * from studsubjtbl where IDNum = '" + assignschedfrm.forselectedrowstud + "'"
        cmd = New MySqlCommand(loadstudsubj, con)
        dr = cmd.ExecuteReader
        Do While dr.Read

          
                assignschedfrm.forsubjcount.Items.Add(dr.Item("subjcountr"))

                subjcountonly.Items.Add(dr.Item("subjcountr"))

        Loop
        dr.Close()

        For indexx As Integer = 0 To subjcountonly.Items.Count - 1
            subjcountonly.SelectedIndex = indexx
            subjcountonly.SelectedItem = subjcountonly.SelectedIndex
            If assignschedfrm.forsubjcount.Items.Count = 0 Then
            Else
                assignschedfrm.forsubjcount.SelectedIndex = indexx
                assignschedfrm.forsubjcount.SelectedItem = assignschedfrm.forsubjcount.SelectedIndex
            End If

            Dim rowindex As String
            Dim tocomparestring As String

            For Each row As DataGridViewRow In assignschedfrm.subjectsDGV.Rows
                tocomparestring = row.Cells.Item(0).Value.ToString()

                If row.Cells.Item(0).Value = assignschedfrm.forsubjcount.SelectedItem Then

                    rowindex = row.Index.ToString
                    assignschedfrm.subjectsDGV.Rows.RemoveAt(rowindex)
                ElseIf assignschedfrm.forsubjcount.Items.Contains(row.Cells.Item(0).Value) = True Then
                    rowindex = row.Index.ToString
                    assignschedfrm.subjectsDGV.Rows.RemoveAt(rowindex)
                End If
              
            Next

        Next

    End Sub

    Public Sub removeassignedsubj()
        Dim removeassignedsubject As String = "delete from studsubjtbl where IDNum = '" + assignschedfrm.StudIDNumLBL.Text + "' and subjcountr = '" + assignschedfrm.forselectedassignedsubj + "'"
        cmd = New MySqlCommand(removeassignedsubject, con)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub forprintstudschedonupdatestudinfo()
        dr.Close()
        ds.Tables.Clear()
        Dim displaydgvassignedsubjects As String = "select studsubjtbl.subjcountr, subjectstbl.subjCode as 'Subject Code', subjectstbl.subjDescript as 'Subject name', " _
                                                                    & "teacherinfotbl.teachnamecode as 'Instructor', subjectstbl.subjUnit as 'Units', " _
                                                                    & "subjectstbl.subjLecHr as 'No. of hour (Lec)', subjectstbl.subjLabHr as 'No. of hour (Lab)', " _
                                                                    & "subjectstbl.subjTotalhr as 'Total hours', subjectstbl.subjDay as 'Day', subjectstbl.subjRoom as 'Room', " _
                                                                    & "subjectstbl.subjTimefrom as 'Time in', subjectstbl.subjTimeTo as 'Time out' from studsubjtbl " _
                                                                    & "inner join subjectstbl on studsubjtbl.subjcountr = subjectstbl.subjcountr inner join teacherinfotbl " _
                                                                    & "on studsubjtbl.teachIDNum = teacherinfotbl.teachIDNum where studsubjtbl.IDNum = '" _
                                                                    + updateStudInfofrm.StudIDNumTXT.Text + "'"

        dadpt.SelectCommand = New MySqlCommand(displaydgvassignedsubjects, con)

        dadpt.Fill(ds, displaydgvassignedsubjects)
        With updateStudInfofrm.DataGridView1
            .DataSource = ds.Tables(0)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial Narrow", 10)
            .DefaultCellStyle.Font = New Font("Arial Narrow", 9)
            .Columns(0).Visible = False
        End With
    End Sub

    Public Sub forprintstudschedonsearchstud()
        dr.Close()
        ds.Tables.Clear()
        Dim displaydgvassignedsubjects As String = "select studsubjtbl.subjcountr, subjectstbl.subjCode as 'Subject Code', subjectstbl.subjDescript as 'Subject name', " _
                                                                    & "teacherinfotbl.teachnamecode as 'Instructor', subjectstbl.subjUnit as 'Units', " _
                                                                    & "subjectstbl.subjLecHr as 'No. of hour (Lec)', subjectstbl.subjLabHr as 'No. of hour (Lab)', " _
                                                                    & "subjectstbl.subjTotalhr as 'Total hours', subjectstbl.subjDay as 'Day', subjectstbl.subjRoom as 'Room', " _
                                                                    & "subjectstbl.subjTimefrom as 'Time in', subjectstbl.subjTimeTo as 'Time out' from studsubjtbl " _
                                                                    & "inner join subjectstbl on studsubjtbl.subjcountr = subjectstbl.subjcountr inner join teacherinfotbl " _
                                                                    & "on studsubjtbl.teachIDNum = teacherinfotbl.teachIDNum where studsubjtbl.IDNum = '" _
                                                                    + searchstudfrm.selectedrowtoprint.Text + "'"

        dadpt.SelectCommand = New MySqlCommand(displaydgvassignedsubjects, con)
        dadpt.Fill(ds, displaydgvassignedsubjects)
        ds.Tables.Clear()
        dadpt.Fill(ds, displaydgvassignedsubjects)
        With searchstudfrm.DataGridView1
            .DataSource = ds.Tables(0)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial Narrow", 10)
            .DefaultCellStyle.Font = New Font("Arial Narrow", 9)
            .Columns(0).Visible = False
        End With
    End Sub

    Public Sub subjunitcountr()
        assignschedfrm.ListBox1.Items.Clear()
        For indexx As Integer = 0 To assignschedfrm.forsubjcount.Items.Count - 1
            assignschedfrm.forsubjcount.SelectedIndex = indexx
            assignschedfrm.forsubjcount.SelectedItem = assignschedfrm.forsubjcount.SelectedIndex
            assignschedfrm.Label3.Text = assignschedfrm.forsubjcount.SelectedItem.ToString

            Dim forunitcount As String = "select * from subjectstbl where subjcountr = '" + assignschedfrm.Label3.Text + "'"
            assignschedfrm.Label3.Text = assignschedfrm.forsubjcount.SelectedItem
            cmd = New MySqlCommand(forunitcount, con)
            dr = cmd.ExecuteReader

            Do While dr.Read
                
                    assignschedfrm.ListBox1.Items.Add(dr.Item("subjUnit"))


            Loop
            dr.Close()
        Next


        Dim sumofall As Integer
        For Each Str As String In assignschedfrm.ListBox1.Items
            sumofall = sumofall + CInt(Str)
        Next
        assignschedfrm.Label7.Text = sumofall
    End Sub

    'student info------------------------------------------------------------------------------------------------------------------------------------------------------------------


    '---------------for adding teacher info
    Public Sub forloadinserteachidnum()
        Try
            instructorinfofrm.checklb.Items.Clear()
            Dim forchecktableteach As String = "select * from teacherinfotbl"
            cmd = New MySqlCommand(forchecktableteach, con)
            dr = cmd.ExecuteReader
            Dim foridnum As New Label
            Do While dr.Read
                instructorinfofrm.checklb.Items.Add(dr.Item("teachIDNum"))
                foridnum.Text = dr.Item("teachIDNum")
            Loop
            dr.Close()
            If instructorinfofrm.checklb.Items.Count = 0 Then
                instructorinfofrm.teachIDNumLBL.Text = "00001"
            Else
                instructorinfofrm.teachIDNumLBL.Text = CInt(foridnum.Text + 1).ToString.PadLeft(5, "0")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub forinsertteachinfo()
        Dim forinsertteacherinfo As String = "insert into teacherinfotbl (teachIDNum, teachFname, teachMI, teachFamname, teachGender, teachAddress, teachnamecode)" _
                                              & " VALUES ('" + instructorinfofrm.teachIDNumLBL.Text + "' , '" + instructorinfofrm.teachFNameTXT.Text _
                                              + "' , '" + instructorinfofrm.teachMITXT.Text + "' , '" + instructorinfofrm.teachFamNameTXT.Text _
                                              + "' , '" + instructorinfofrm.teachgenderCMBO.Text + "' , '" + instructorinfofrm.teachAddTXT.Text _
                                              + "' , '" + instructorinfofrm.teachNameCodeTXT.Text + "')"
        cmd = New MySqlCommand(forinsertteacherinfo, con)
        cmd.ExecuteNonQuery()

        fordgvteachinfo()

        forloadinserteachidnum()

        For Each txtctrl In instructorinfofrm.Controls
            If TypeOf txtctrl Is TextBox Then
                txtctrl.Text = Nothing
                txtctrl.BackColor = Color.White
            End If
        Next
        instructorinfofrm.teachgenderCMBO.SelectedIndex = 0
        instructorinfofrm.teachgenderCMBO.BackColor = Color.White

    End Sub

    Public Sub fordgvteachinfo()

        Try

            ds.Tables.Clear()
            Dim displayteachinfodgv As String = "select teachIDNum as 'Teacher ID Number', teachFname as 'First name', teachMI as 'Middle Name', teachFamname as 'Family name', " _
                                                & "teachGender as 'Gender', teachAddress as 'Address', teachnamecode as 'Teacher name code' from teacherinfotbl"
            dadpt.SelectCommand = New MySqlCommand(displayteachinfodgv, con)
            dadpt.Fill(ds, displayteachinfodgv)
            With instructorinfofrm.displayinstructdgv
                .DataSource = ds.Tables(0)
                .AutoResizeColumns()
            End With
        Catch ex As Exception
            MessageBox.Show("Error on loading teacher's info " & ex.Message, "Error on Teacher's Info", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub todisplayteachinfo()
        Try

            ds.Tables.Clear()

            Dim displaydgvteachinfo As String = "select teachIDNum as 'Teacher ID Number', teachFname as 'First name', teachMI as 'Middle Name', teachFamname as 'Family name', " _
                                                & "teachGender as 'Gender', teachAddress as 'Address', teachnamecode as 'Teacher name code' " _
                                                & "from teacherinfotbl where " + instructorinfofrm.forselectedcmboteach + " like '%" + instructorinfofrm.searchbarTXT.Text + "%'"

            dadpt.SelectCommand = New MySqlCommand(displaydgvteachinfo, con)
            dadpt.Fill(ds, displaydgvteachinfo)
            With instructorinfofrm.displayinstructdgv
                .DataSource = ds.Tables(0)
                .AutoResizeColumns()
            End With

        Catch ex As Exception
            MessageBox.Show("Error on loading/displaying student subjects  " & ex.Message, "Error on loading subjects", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub fordeleteteachinfo()
        Dim fordeleteteachrec As String = "delete from teacherinfotbl where teachIDNum like '%" + instructorinfofrm.forselectedrow + "%'"
        cmd = New MySqlCommand(fordeleteteachrec, con)
        cmd.ExecuteNonQuery()


        fordgvteachinfo()

        forloadinserteachidnum()

        For Each txtctrl In instructorinfofrm.Controls
            If TypeOf txtctrl Is TextBox Then
                txtctrl.Text = Nothing
                txtctrl.BackColor = Color.White
            End If
        Next
        instructorinfofrm.teachgenderCMBO.SelectedIndex = 0
        instructorinfofrm.teachgenderCMBO.BackColor = Color.White

    End Sub

    Public Sub forupdatedteachinfo()

        Dim forupdateteachinfo As String = "update teacherinfotbl set teachFname = '" + instructorinfofrm.teachFNameTXT.Text + "', teachMI = '" _
                                           + instructorinfofrm.teachMITXT.Text + "', teachFamname = '" + instructorinfofrm.teachFamNameTXT.Text _
                                           + "', teachGender = '" + instructorinfofrm.teachgenderCMBO.Text + "', teachAddress = '" _
                                           + instructorinfofrm.teachAddTXT.Text + "', teachnamecode = '" + instructorinfofrm.teachNameCodeTXT.Text _
                                           + "' where teachIDNum = '" + instructorinfofrm.forselectedrow + "'"
        cmd = New MySqlCommand(forupdateteachinfo, con)
        cmd.ExecuteNonQuery()

        fordgvteachinfo()
        forloadinserteachidnum()
        For Each txtctrl In instructorinfofrm.Controls
            If TypeOf txtctrl Is TextBox Then
                txtctrl.Text = Nothing
                txtctrl.BackColor = Color.White
            End If
        Next
        instructorinfofrm.teachgenderCMBO.SelectedIndex = 0
        instructorinfofrm.teachgenderCMBO.BackColor = Color.White

    End Sub
    '---------------for adding teacher info


    '----------------for adding subject details
    Public Sub fordisplaysubjdgv()
        Try

            ds.Tables.Clear()

            Dim displaysubjinfodgv As String = "select subjcountr, subjCode as 'Subject Code', subjDescript as 'Subject Name', subjUnit as 'Units', " _
                                   & "subjLecHr as 'No. of hour (Lec)', subjLabHr as 'No. of hour (Lab)', subjTotalHr as 'Total Hours', " _
                                   & "subjDay as 'Day', subjRoom as 'Room No.', subjTimeFrom as 'Time In', subjTimeTo as 'Time Out' from subjectstbl"
            dadpt.SelectCommand = New MySqlCommand(displaysubjinfodgv, con)
            dadpt.Fill(ds, displaysubjinfodgv)
            With addsubjectfrm.displaysubjdgv
                .DataSource = ds.Tables(0)
                .AutoResizeColumns()
                .Columns(0).Visible = False
            End With
            dr.Close()


        Catch ex As Exception
            MessageBox.Show("For display subjects to assign catch " & ex.Message, "Error on subject Info", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub toresetctrl()

        For Each txtctrl As Control In addsubjectfrm.Controls
            If TypeOf txtctrl Is TextBox Then
                txtctrl.Text = Nothing
                txtctrl.BackColor = Color.White
            End If
        Next

        With addsubjectfrm
            .subjdayCMBO.SelectedIndex = 0
            .subjTotalHrLBL.Text = ""
            .subjdayCMBO.BackColor = Color.White
            .searchbyCMBO.BackColor = Color.White
            .subjTFromPICKER.ResetText()
            .semesterCMBO.SelectedIndex = 0
            .semesterCMBO.BackColor = Color.White
            .yearlvlCMBO.SelectedIndex = 0
            .semesterCMBO.BackColor = Color.White
        End With

    End Sub

    Public Sub forcheckduplicate()

        dr.Close()

        Dim timeBStart, timeBEnd As String

        With addsubjectfrm
            .listtimeStartB.Items.Clear()
            .listtimeEndB.Items.Clear()
            .daylist.Items.Clear()
            .roomlist.Items.Clear()
        End With

        Dim checkduplicate As String = "select * from subjectstbl where subjDay like '%" + addsubjectfrm.forselectedday + "%'"
        cmd = New MySqlCommand(checkduplicate, con)
        dr = cmd.ExecuteReader

        While dr.Read
            addsubjectfrm.daylist.Items.Add(dr.Item("subjDay"))
            addsubjectfrm.roomlist.Items.Add(dr.Item("subjRoom"))

            timeBStart = Replace(DateTime.Parse(dr.Item("subjTimefrom")).ToString("HH:mm"), ":", "")
            timeBEnd = Replace(DateTime.Parse(dr.Item("subjTimeTo")).ToString("HH:mm"), ":", "")

            addsubjectfrm.listtimeStartB.Items.Add(timeBStart)
            addsubjectfrm.listtimeEndB.Items.Add(timeBEnd)
        End While
        dr.Close()

    End Sub

    Public Sub beforeadding()
        forcheckduplicate()

        If addsubjectfrm.daylist.Items.Contains(addsubjectfrm.subjdayCMBO.Text) = True Then

            If addsubjectfrm.roomlist.Items.Contains(addsubjectfrm.subjRoomTXT.Text.ToUpper) = True Then

                Dim countlistitems As Integer

                Dim checktime As String = CInt(Replace(DateTime.Parse(addsubjectfrm.subjTFromPICKER.Text).ToString("hh:mm"), ":", ""))

                Dim timeAStart, timeAEnd As String
                timeAStart = Replace(DateTime.Parse(addsubjectfrm.subjTFromPICKER.Text).ToString("HH:mm"), ":", "")
                timeAEnd = Replace(DateTime.Parse(addsubjectfrm.subjTToPICKER.Text).ToString("HH:mm"), ":", "")

                countlistitems = addsubjectfrm.listtimeStartB.Items.Count

                For indexx As Integer = 0 To addsubjectfrm.listtimeStartB.Items.Count - 1
                    addsubjectfrm.listtimeStartB.SelectedIndex = indexx
                    addsubjectfrm.listtimeEndB.SelectedIndex = indexx

                    If timeAStart <= addsubjectfrm.listtimeEndB.SelectedItem And timeAEnd <= addsubjectfrm.listtimeStartB.SelectedItem Or timeAStart >= addsubjectfrm.listtimeEndB.SelectedItem And timeAEnd >= addsubjectfrm.listtimeStartB.SelectedItem Then
                        addsubjectfrm.checklbl.Text = "0"
                    Else
                        addsubjectfrm.checklbl.Text = "1"
                    End If
                Next

                If String.Equals("0", addsubjectfrm.checklbl.Text) = True Then
                    foraddingsubj()

                    displaytheassignedsubjects()
                    fordisplaysubjtoassigndgv()
                    toremoveselectedsubj()

                End If

                If String.Equals("1", addsubjectfrm.checklbl.Text) = True Then
                    MessageBox.Show("There is a conflict in schedule.", "Conflict of schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            ElseIf addsubjectfrm.subjRoomTXT.Text.Length = 0 Then
                MessageBox.Show("Please comply all the necessary details.", "Incomplete details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else

                foraddingsubj()

                displaytheassignedsubjects()
                fordisplaysubjtoassigndgv()
                toremoveselectedsubj()

            End If
        ElseIf addsubjectfrm.subjdayCMBO.SelectedItem = "" And addsubjectfrm.semesterCMBO.SelectedItem = "" And addsubjectfrm.yearlvlCMBO.SelectedItem = "" Then
            If addsubjectfrm.subjdayCMBO.Text.Length = 0 And addsubjectfrm.semesterCMBO.Text.Length = 0 And addsubjectfrm.yearlvlCMBO.Text.Length = 0 Then
                addsubjectfrm.subjdayCMBO.BackColor = Color.DarkRed
                addsubjectfrm.semesterCMBO.BackColor = Color.DarkRed
                addsubjectfrm.yearlvlCMBO.BackColor = Color.DarkRed
            Else
                addsubjectfrm.subjdayCMBO.BackColor = Color.White
                addsubjectfrm.semesterCMBO.BackColor = Color.White
                addsubjectfrm.yearlvlCMBO.BackColor = Color.White
            End If

        ElseIf addsubjectfrm.daylist.Items.Count = 0 Then
            foraddingsubj()

            displaytheassignedsubjects()
            fordisplaysubjtoassigndgv()
            toremoveselectedsubj()

        End If
    End Sub

    Public Sub foraddingsubj()

        Try
            dr.Close()
            Dim foraddingsubj As String = "insert into subjectstbl (subjCode, subjDescript, subjUnit, subjLecHr, subjLabHr, subjTotalHr, subjDay, subjRoom, subjTimeFrom, " _
                                      & "subjTimeTo, foryearlvl, forsubjsem) VALUES ('" + addsubjectfrm.subjCodeTXT.Text + "' , '" + addsubjectfrm.subjNameTXT.Text + "' , '" _
                                      + addsubjectfrm.subjnoUnitsTXT.Text + "' , '" + addsubjectfrm.subjLecHrTXT.Text + "' , '" + addsubjectfrm.subjLabHrTXT.Text + "' , '" _
                                      + addsubjectfrm.subjTotalHrLBL.Text + "' , '" + addsubjectfrm.subjdayCMBO.Text + "' , '" + addsubjectfrm.subjRoomTXT.Text.ToUpper + "' , '" _
                                      + addsubjectfrm.subjTFromPICKER.Text + "' , '" + addsubjectfrm.subjTToPICKER.Text + "' , '" + addsubjectfrm.yearlvlCMBO.Text _
                                      + "' , '" + addsubjectfrm.semesterCMBO.Text + "')"
            cmd = New MySqlCommand(foraddingsubj, con)
            cmd.ExecuteNonQuery()

            fordisplaysubjdgv()

            toresetctrl()

        Catch ex As Exception
            MessageBox.Show("Error on adding subject. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Public Sub forupdatesubj()


        Dim forupdatesubj As String = "update subjectstbl set subjCode = '" + addsubjectfrm.subjCodeTXT.Text + "', subjDescript = '" _
                                       + addsubjectfrm.subjNameTXT.Text + "', subjUnit = '" + addsubjectfrm.subjnoUnitsTXT.Text _
                                       + "', subjLechr = '" + addsubjectfrm.subjLecHrTXT.Text + "', subjLabHr= '" _
                                       + addsubjectfrm.subjLabHrTXT.Text + "', subjTotalHr = '" + addsubjectfrm.subjTotalHrLBL.Text _
                                       + "' , subjDay = '" + addsubjectfrm.subjdayCMBO.Text + "', subjRoom = '" _
                                       + addsubjectfrm.subjRoomTXT.Text + "', subjTimeFrom = '" + addsubjectfrm.subjTFromPICKER.Text _
                                       + "', subjTimeTo = '" + addsubjectfrm.subjTToPICKER.Text + "', foryearlvl = '" _
                                       + addsubjectfrm.yearlvlCMBO.Text + "', forsubjsem = '" + addsubjectfrm.semesterCMBO.Text _
                                       + "' where subjcountr = '" + addsubjectfrm.forselectedrow + "'"
        cmd = New MySqlCommand(forupdatesubj, con)
        cmd.ExecuteNonQuery()

        Dim forupdateassignedsubjtoteach As String = "update assignedsubjtoteachtbl set subjCode = '" + addsubjectfrm.subjCodeTXT.Text + "', subjcountr = '" _
                                       + addsubjectfrm.forselectedrow + "', subjDay = '" + addsubjectfrm.subjdayCMBO.Text + "', subjRoom = '" _
                                       + addsubjectfrm.subjRoomTXT.Text + "', subjTimeFrom = '" + addsubjectfrm.subjTFromPICKER.Text _
                                       + "', subjTimeTo = '" + addsubjectfrm.subjTToPICKER.Text + "' where subjcountr = '" + addsubjectfrm.forselectedrow + "'"
        cmd = New MySqlCommand(forupdateassignedsubjtoteach, con)
        cmd.ExecuteNonQuery()

        fordisplaysubjdgv()


        toresetctrl()


    End Sub

    Public Sub fordeletesubj()
        Try

            Dim fordeletesubj As String = "delete from subjectstbl where subjcountr = '" + addsubjectfrm.forselectedrow + "'"
            cmd = New MySqlCommand(fordeletesubj, con)
            cmd.ExecuteNonQuery()

            Dim deleteinassignedsubjtoteach As String = "delete from assignedsubjtoteachtbl where subjcountr = '" + addsubjectfrm.forselectedrow + "'"
            cmd = New MySqlCommand(deleteinassignedsubjtoteach, con)
            cmd.ExecuteNonQuery()


            fordisplaysubjdgv()

            toresetctrl()

        Catch ex As Exception
            MessageBox.Show("Error on delete subject. " & ex.Message, "Error on Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub fordisplaysubjdgvsearch()


        ds.Tables.Clear()
        Dim displaysubjinfodgvsearch As String = "select subjCode as 'Subject Code', subjDescript as 'Subject Name', subjUnit as 'Units', subjLecHr as 'No. of hour (Lec)', " _
                                            & "subjLabHr as 'No. of hour (Lab)', subjTotalHr as 'Total Hours', subjDay as 'Day', subjRoom as 'Room No.', " _
                                            & "subjTimeFrom as 'Time In', subjTimeTo as 'Time Out' from subjectstbl where " + addsubjectfrm.forsearchby _
                                            + " like '%" & addsubjectfrm.searchbarTXT.Text & "%'"
        dadpt.SelectCommand = New MySqlCommand(displaysubjinfodgvsearch, con)
        dadpt.Fill(ds, displaysubjinfodgvsearch)
        With addsubjectfrm.displaysubjdgv
            .DataSource = ds.Tables(0)
            .AutoResizeColumns()
        End With

    End Sub
    '----------------for adding subject details



    '-----------for assigning subject to a techer
    Public Sub fordgvassignteach()

        ds.Tables.Clear()
        Dim displayteachinfodgv As String = "select teachIDNum as 'Teacher ID Number', teachFname as 'First name', teachMI as 'Middle Name', teachFamname as 'Family name', " _
                                            & "teachGender as 'Gender', teachAddress as 'Address', teachnamecode as 'Teacher name code' from teacherinfotbl"
        dadpt.SelectCommand = New MySqlCommand(displayteachinfodgv, con)
        dadpt.Fill(ds, displayteachinfodgv)
        With assigninstructortosubjfrm.teacherDGV
            .DataSource = ds.Tables(0)
            .AutoResizeColumns()
        End With

    End Sub

    Public Sub fordgvassignteachsearch()

        Try

            ds.Tables.Clear()
            Dim displayteachinfodgvsearch As String = "select teachIDNum as 'Teacher ID Number', teachFname as 'First name', teachMI as 'Middle Name', teachFamname as 'Family name', " _
                                                & "teachGender as 'Gender', teachAddress as 'Address', teachnamecode as 'Teacher name code' from teacherinfotbl where " _
                                                + assigninstructortosubjfrm.forsearchbyinstruct + " like '%" + assigninstructortosubjfrm.searchbarinstructorTXT.Text + "%'"
            dadpt.SelectCommand = New MySqlCommand(displayteachinfodgvsearch, con)
            dadpt.Fill(ds, displayteachinfodgvsearch)
            With assigninstructortosubjfrm.teacherDGV
                .DataSource = ds.Tables(0)
                .AutoResizeColumns()
            End With
        Catch ex As Exception
            MessageBox.Show("For display searched teacher's info catch " & ex.Message, "Error on searching Teacher's Info", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub fordisplaysubjtoassigndgv()
        Try

            ds.Tables.Clear()

            Dim displaysubjinfodgv As String = "select subjCode as 'Subject Code', subjDescript as 'Subject Name', subjUnit as 'Units', subjLecHr as 'No. of hour (Lec)', " _
                                                & "subjLabHr as 'No. of hour (Lab)', subjTotalHr as 'Total Hours', subjDay as 'Day', subjRoom as 'Room No.', " _
                                                & "subjTimeFrom as 'Time In', subjTimeTo as 'Time Out' from subjectstbl"
            dadpt.SelectCommand = New MySqlCommand(displaysubjinfodgv, con)

            dadpt.Fill(ds, displaysubjinfodgv)
            With assigninstructortosubjfrm.displaysubjdgv
                .DataSource = ds.Tables(0)
                .AutoResizeColumns()
            End With
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("For display subject info catch " & ex.Message, "Error on subject Info", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub forassignsubj()

        'Try


        Dim getsubjDayy, getsubjDay, getsubjTFrom, getsubjTTo, getsubjdayteach As New ListBox
        Dim listtimeStartB, listtimeEndB, daylist, roomlist As New ListBox


        If assigninstructortosubjfrm.handledsubjDGV.Rows.Count = 0 Then
            Dim forassign As String = "insert into assignedsubjtoteachtbl (subjCode, subjcountr, teachIDNum, subjDay, subjRoom, subjTimefrom, subjTimeTo) " _
                                          & "VALUES ('" + assigninstructortosubjfrm.forselectedrowsubj _
                                          + "' , '" + assigninstructortosubjfrm.selectedsubjcountr + "' , '" + assigninstructortosubjfrm.forteachIDNum.Text _
                                          + "' , '" + assigninstructortosubjfrm.selectedDay _
                                          + "' , '" + assigninstructortosubjfrm.selectedRoom + "' , '" + assigninstructortosubjfrm.selectedTFrom _
                                          + "' , '" + assigninstructortosubjfrm.selectedTTo + "')"
            cmd = New MySqlCommand(forassign, con)
            cmd.ExecuteNonQuery()



            displaytheassignedsubjects()

            toremoveselectedsubj()


            dr.Close()
        Else


            Dim timeBStart, timeBEnd As String

            listtimeStartB.Items.Clear()
            listtimeEndB.Items.Clear()
            daylist.Items.Clear()
            roomlist.Items.Clear()
            getsubjDay.Items.Clear()
            getsubjTFrom.Items.Clear()
            getsubjTTo.Items.Clear()
            getsubjdayteach.Items.Clear()
            getsubjDayy.Items.Clear()

            Dim checklbl As New Label

            Dim getsubjdetail As String = "select * from assignedsubjtoteachtbl where teachIDNum = '" + assigninstructortosubjfrm.forselectedrowteach + "'"
            cmd = New MySqlCommand(getsubjdetail, con)
            dr = cmd.ExecuteReader
            While dr.Read
                getsubjdayteach.Items.Add(dr.Item("subjcountr"))

            End While
            dr.Close()

            For i As Integer = 0 To getsubjdayteach.Items.Count - 1
                dr.Close()
                getsubjdayteach.SelectedIndex = i
                getsubjdayteach.SelectedItem = getsubjdayteach.SelectedIndex

                Dim checkduplicate As String = "select * from subjectstbl where subjcountr = '" + getsubjdayteach.SelectedItem.ToString + "'"
                cmd = New MySqlCommand(checkduplicate, con)
                dr = cmd.ExecuteReader

                While dr.Read

                    getsubjDay.Items.Add(dr.Item("subjDay"))


                End While
                dr.Close()

            Next



            'forselectedday.Text = selectedrow.Cells(6).Value.ToString
            'forselectedtfrom.Text = selectedrow.Cells(8).Value.ToString
            'forselectedtto.Text = selectedrow.Cells(9).Value.ToString

            'MsgBox(getsubjDay.Items.Contains(assigninstructortosubjfrm.forselectedday.Text))
            If getsubjDay.Items.Contains(assigninstructortosubjfrm.forselectedday.Text) = True Then

                Dim forcheckinday As String = "select * from assignedsubjtoteachtbl where subjDay like '%" + assigninstructortosubjfrm.forselectedday.Text + "%'"
                cmd = New MySqlCommand(forcheckinday, con)
                dr = cmd.ExecuteReader
                While dr.Read
                    '                    assigninstructortosubjfrm.ListBox1.Items.Add(dr.Item("subjTimefrom"))

                    timeBStart = Replace(DateTime.Parse(dr.Item("subjTimefrom")).ToString("HH:mm"), ":", "")
                    timeBEnd = Replace(DateTime.Parse(dr.Item("subjTimeTo")).ToString("HH:mm"), ":", "")

                    listtimeStartB.Items.Add(timeBStart)
                    listtimeEndB.Items.Add(timeBEnd)

                End While
                dr.Close()



                Dim checktime As String = CInt(Replace(DateTime.Parse(assigninstructortosubjfrm.forselectedtfrom.Text).ToString("hh:mm"), ":", ""))

                Dim timeAStart, timeAEnd As String
                timeAStart = Replace(DateTime.Parse(assigninstructortosubjfrm.forselectedtfrom.Text).ToString("HH:mm"), ":", "")
                timeAEnd = Replace(DateTime.Parse(assigninstructortosubjfrm.forselectedtto.Text).ToString("HH:mm"), ":", "")


                For indexx As Integer = 0 To listtimeStartB.Items.Count - 1
                    listtimeStartB.SelectedIndex = indexx
                    listtimeEndB.SelectedIndex = indexx
                    'MsgBox("timeAStart: " & timeAStart & "     timeAEnd: " & timeAEnd & "     timeStartB: " & listtimeStartB.SelectedItem & "     timeEndB: " & listtimeEndB.SelectedItem)

                    If timeAStart <= listtimeEndB.SelectedItem And timeAEnd <= listtimeStartB.SelectedItem Or timeAStart >= listtimeEndB.SelectedItem And timeAEnd >= listtimeStartB.SelectedItem Then


                        checklbl.Text = "0"

                    Else
                        checklbl.Text = "1"
                        Exit For


                    End If


                Next

                If String.Equals("0", checklbl.Text) = True Then
                    dr.Close()
                    Dim forassign As String = "insert into assignedsubjtoteachtbl (subjCode, subjcountr, teachIDNum, subjDay, subjRoom, subjTimefrom, subjTimeTo) " _
                                              & "VALUES ('" + assigninstructortosubjfrm.forselectedrowsubj _
                                              + "' , '" + assigninstructortosubjfrm.selectedsubjcountr + "' , '" + assigninstructortosubjfrm.forteachIDNum.Text _
                                              + "' , '" + assigninstructortosubjfrm.selectedDay _
                                              + "' , '" + assigninstructortosubjfrm.selectedRoom + "' , '" + assigninstructortosubjfrm.selectedTFrom _
                                              + "' , '" + assigninstructortosubjfrm.selectedTTo + "')"
                    cmd = New MySqlCommand(forassign, con)
                    cmd.ExecuteNonQuery()



                    displaytheassignedsubjects()

                    toremoveselectedsubj()


                    dr.Close()

                ElseIf String.Equals("1", checklbl.Text) = True Then
                    MessageBox.Show("There is a conflict in schedule.", "Conflict of schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If



            Else

                Dim forassign As String = "insert into assignedsubjtoteachtbl (subjCode, subjcountr, teachIDNum, subjDay, subjRoom, subjTimefrom, subjTimeTo) " _
                                              & "VALUES ('" + assigninstructortosubjfrm.forselectedrowsubj _
                                              + "' , '" + assigninstructortosubjfrm.selectedsubjcountr + "' , '" + assigninstructortosubjfrm.forteachIDNum.Text _
                                              + "' , '" + assigninstructortosubjfrm.selectedDay _
                                              + "' , '" + assigninstructortosubjfrm.selectedRoom + "' , '" + assigninstructortosubjfrm.selectedTFrom _
                                              + "' , '" + assigninstructortosubjfrm.selectedTTo + "')"
                cmd = New MySqlCommand(forassign, con)
                cmd.ExecuteNonQuery()



                displaytheassignedsubjects()

                toremoveselectedsubj()


                dr.Close()

            End If




        End If


        'Catch ex As Exception
        '    MessageBox.Show("Error on assigning subject to instructor. " & ex.Message, "Error on assigning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub



    Public Sub getteachIDNumandsubjCode()

        Try

            assigninstructortosubjfrm.forsubjcountr.Items.Clear()
            Dim displayassignedsubj As String = "select * from assignedsubjtoteachtbl where teachIDNum like '%" + assigninstructortosubjfrm.forselectedrowteach + "%'"
            cmd = New MySqlCommand(displayassignedsubj, con)
            dr = cmd.ExecuteReader
            While dr.Read()
                assigninstructortosubjfrm.forsubjcountr.Items.Add(dr.Item("subjcountr"))

            End While
            dr.Close()


            For indexx As Integer = 0 To assigninstructortosubjfrm.forsubjcountr.Items.Count - 1
                assigninstructortosubjfrm.forsubjcountr.SelectedIndex = indexx
                assigninstructortosubjfrm.forsubjcountr.SelectedItem = assigninstructortosubjfrm.forsubjcountr.SelectedIndex
            Next

        Catch ex As Exception
            MessageBox.Show("For display assigned subject info catch " & ex.Message, "Error on subject Info", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub displaytheassignedsubjects()

        dr.Close()
        ds.Tables.Clear()

        Dim displayassignedsubjdgv As String = "select subjectstbl.subjCode as 'Subject Code', subjectstbl.subjDescript as 'Subject name', " _
                                                        & "subjectstbl.subjUnit as 'Units', " _
                                                        & "subjectstbl.subjLecHr as 'No. of hour (Lec)', subjectstbl.subjLabHr as 'No. of hour (Lab)', " _
                                                        & "subjectstbl.subjTotalhr as 'Total hours', subjectstbl.subjDay as 'Day', subjectstbl.subjRoom as 'Room', " _
                                                        & "subjectstbl.subjTimefrom as 'Time in', subjectstbl.subjTimeTo as 'Time out', subjectstbl.subjcountr from assignedsubjtoteachtbl " _
                                                        & "inner join subjectstbl on assignedsubjtoteachtbl.subjcountr = subjectstbl.subjcountr inner join teacherinfotbl " _
                                                        & "on assignedsubjtoteachtbl.teachIDNum = teacherinfotbl.teachIDNum where assignedsubjtoteachtbl.teachIDNum " _
                                                        & "like '%" & assigninstructortosubjfrm.forselectedrowteach & "%'"

        dadpt.SelectCommand = New MySqlCommand(displayassignedsubjdgv, con)
        dadpt.Fill(ds, displayassignedsubjdgv)
        With assigninstructortosubjfrm.handledsubjDGV
            .DataSource = ds.Tables(0)
            .AutoResizeColumns()
            .Columns(10).Visible = False
        End With
        dr.Close()

    End Sub

    Public Sub removefromlist()
        Try
            Dim removefromlist As String = "delete from assignedsubjtoteachtbl where teachIDNum = '" + assigninstructortosubjfrm.forselectedrowteach _
                                           + "' and subjCode = '" + assigninstructortosubjfrm.forselectedrowhandeledsubj + "'"
            cmd = New MySqlCommand(removefromlist, con)
            cmd.ExecuteNonQuery()


            Dim deleteassignstudsubj As String = "delete from studsubjtbl where teachIDNum = '" + assigninstructortosubjfrm.forselectedrowteach _
                                           + "' and subjcountr = '" + assigninstructortosubjfrm.forsubjectcounter + "'"
            cmd = New MySqlCommand(deleteassignstudsubj, con)
            cmd.ExecuteNonQuery()

            fordisplaysubjtoassigndgv()
            displaytheassignedsubjects()
            toremoveselectedsubj()

        Catch ex As Exception
            MessageBox.Show("Error on removing subject. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub toremoveselectedsubj()


        assigninstructortosubjfrm.forsubjectcodeLB.Items.Clear()
        Dim subjcodeonly As New ListBox
        Dim displayassignedsubj As String = "select * from assignedsubjtoteachtbl"
        cmd = New MySqlCommand(displayassignedsubj, con)
        dr = cmd.ExecuteReader
        While dr.Read
            assigninstructortosubjfrm.forsubjectcodeLB.Items.Add(dr.Item("subjCode") & dr.Item("subjDay") & dr.Item("subjRoom") & dr.Item("subjTimefrom") & dr.Item("subjTimeTo"))
            subjcodeonly.Items.Add(dr.Item("subjCode"))
        End While
        dr.Close()

        For indexx As Integer = 0 To subjcodeonly.Items.Count - 1
            subjcodeonly.SelectedIndex = indexx
            subjcodeonly.SelectedItem = subjcodeonly.SelectedIndex
            assigninstructortosubjfrm.forsubjectcodeLB.SelectedIndex = subjcodeonly.SelectedIndex
            Dim rowindex As String
            Dim tocomparestring As String

            For Each row As DataGridViewRow In assigninstructortosubjfrm.displaysubjdgv.Rows
                tocomparestring = row.Cells.Item(0).Value.ToString & row.Cells.Item(6).Value.ToString & row.Cells.Item(7).Value.ToString & row.Cells.Item(8).Value.ToString & row.Cells.Item(9).Value.ToString

                If row.Cells.Item(0).Value.ToString = subjcodeonly.SelectedItem Then
                    rowindex = row.Index.ToString

                    If String.Equals(tocomparestring, assigninstructortosubjfrm.forsubjectcodeLB.SelectedItem) = True Then
                        assigninstructortosubjfrm.displaysubjdgv.Rows.RemoveAt(rowindex)

                    End If
                End If
            Next
        Next

    End Sub

    Public Sub searchfortoassignsubjects()

        dr.Close()
        ds.Tables.Clear()

        Dim searching As String = "select subjCode as 'Subject Code', subjDescript as 'Subject Name', subjUnit as 'Units', subjLecHr as 'No. of hour (Lec)', " _
                                                        & "subjLabHr as 'No. of hour (Lab)', subjTotalHr as 'Total Hours', subjDay as 'Day', subjRoom as 'Room No.', " _
                                                        & "subjTimeFrom as 'Time In', subjTimeTo as 'Time Out' from subjectstbl where " _
                                                        + assigninstructortosubjfrm.forselectedsearchfor.Text + " like '%" _
                                                        + assigninstructortosubjfrm.searchtoassignsubjTXT.Text + "%'"


        dadpt.SelectCommand = New MySqlCommand(searching, con)
        dadpt.Fill(ds, searching)
        With assigninstructortosubjfrm.displaysubjdgv
            .DataSource = ds.Tables(0)
            .AutoResizeColumns()
        End With
        dr.Close()

        toremoveselectedsubj()

    End Sub
    '-----------for assigning subject to a techer

    '-----------for print individual

    Public Sub displaydgvtoprintindividual()
        dr.Close()
        ds.Tables.Clear()

        Dim displaystudenttoprintindividual As String = "select IDNum as 'ID Number', FName as 'First Name', MidName as 'Middle Name', FamName as 'Family Name', " _
                                                        & "Qualifier from studinfotbl"

        dadpt.SelectCommand = New MySqlCommand(displaystudenttoprintindividual, con)
        dadpt.Fill(ds, displaystudenttoprintindividual)
        With printstudrecordfrm.individualDGV
            .DataSource = ds.Tables(0)

        End With
        dr.Close()
    End Sub

    Public Sub searchingbyindividual()
        dr.Close()
        ds.Tables.Clear()

        Dim searchbyindividual As String = "select IDNum as 'ID Number', FName as 'First Name', MidName as 'Middle Name', FamName as 'Family Name', " _
                                           & "Qualifier from studinfotbl where " & printstudrecordfrm.searchbyindividual & " like '%" & printstudrecordfrm.individualsearchbarTXT.Text & "%'"
        dadpt.SelectCommand = New MySqlCommand(searchbyindividual, con)
        dadpt.Fill(ds, searchbyindividual)
        With printstudrecordfrm.individualDGV
            .DataSource = ds.Tables(0)

        End With
        dr.Close()
    End Sub

    Public Sub forprintindividual()
        dr.Close()
        ds.Tables.Clear()
        Dim displaydgvassignedsubjects As String = "select studsubjtbl.subjcountr, subjectstbl.subjCode as 'Subject Code', subjectstbl.subjDescript as 'Subject name', " _
                                                                    & "teacherinfotbl.teachnamecode as 'Instructor', subjectstbl.subjUnit as 'Units', " _
                                                                    & "subjectstbl.subjLecHr as 'No. of hour (Lec)', subjectstbl.subjLabHr as 'No. of hour (Lab)', " _
                                                                    & "subjectstbl.subjTotalhr as 'Total hours', subjectstbl.subjDay as 'Day', subjectstbl.subjRoom as 'Room', " _
                                                                    & "subjectstbl.subjTimefrom as 'Time in', subjectstbl.subjTimeTo as 'Time out' from studsubjtbl " _
                                                                    & "inner join subjectstbl on studsubjtbl.subjcountr = subjectstbl.subjcountr inner join teacherinfotbl " _
                                                                    & "on studsubjtbl.teachIDNum = teacherinfotbl.teachIDNum where studsubjtbl.IDNum = '" _
                                                                    + printstudrecordfrm.forselectedrowindividualstud + "'"

        dadpt.SelectCommand = New MySqlCommand(displaydgvassignedsubjects, con)
        dadpt.Fill(ds, displaydgvassignedsubjects)
        ds.Tables.Clear()
        dadpt.Fill(ds, displaydgvassignedsubjects)
        With printstudrecordfrm.DataGridView1
            .DataSource = ds.Tables(0)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial Narrow", 10)
            .DefaultCellStyle.Font = New Font("Arial Narrow", 9)
            .Columns(0).Visible = False
        End With
    End Sub

    Public Sub forcrysrptcourse()
        Try

            Dim selectedcourse, selectedsem, selectedSYfrom, selectedSYTo, selectedyrlvl As New Label
            selectedcourse.Text = printstudrecordfrm.courseCMBO.SelectedItem
            selectedsem.Text = printstudrecordfrm.semCMBO.SelectedItem
            selectedSYfrom.Text = printstudrecordfrm.syfromCMBO.SelectedItem
            selectedSYTo.Text = printstudrecordfrm.sytoLBL.Text
            selectedyrlvl.Text = printstudrecordfrm.yrlvlCMBO.SelectedItem

            ds.Tables.Clear()

            Dim printcourse As String = "select * from studinfotbl where Course = '" & selectedcourse.Text & "' and " _
                                                  & "Semester like '%" & selectedsem.Text & "%' and SYFrom like '%" & selectedSYfrom.Text _
                                                  & "%' and YearLevel like '%" & selectedyrlvl.Text & "%'"
            dadpt.SelectCommand = New MySqlCommand(printcourse, con)

            dadpt.Fill(ds, printcourse)
            printstudrecordfrm.crystalReport11.Load(Application.StartupPath & "\CrystalReport1.rpt")
            printstudrecordfrm.crystalReport11.SetDataSource(ds.Tables(0))

            printstudrecordfrm.CrystalReportViewer1.ReportSource = printstudrecordfrm.crystalReport11

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub



    Public Sub loadsemester()
        dr.Close()
        printstudrecordfrm.syfromCMBO.Items.Clear()
        printstudrecordfrm.yrlvlCMBO.Items.Clear()
        printstudrecordfrm.courseCMBO.Items.Clear()
        Dim loadsem As String = "select distinct Course, SYFrom, YearLevel from studinfotbl"
        cmd = New MySqlCommand(loadsem, con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            If printstudrecordfrm.syfromCMBO.Items.Contains(dr.Item("SYFrom")) = True Then
            Else
                printstudrecordfrm.syfromCMBO.Items.Add(dr.Item("SYFrom"))
            End If
            If printstudrecordfrm.yrlvlCMBO.Items.Contains(dr.Item("YearLevel")) = True Then
            Else
                printstudrecordfrm.yrlvlCMBO.Items.Add(dr.Item("YearLevel"))
            End If
            If printstudrecordfrm.courseCMBO.Items.Contains(dr.Item("Course")) = True Then
            Else
                printstudrecordfrm.courseCMBO.Items.Add(dr.Item("Course"))
            End If

        Loop
        dr.Close()

    End Sub

    Public Sub forlogscrysreptnouserid()
        Try

            ds.Tables.Clear()
            Dim printlogs As String = "select * from logstbl where " & logsfrm.forselectedsearchinlogs.Text & " like '%" & logsfrm.usernidnumTXT.Text & "%' AND " _
                                      & "date = '" & logsfrm.DateTimePicker1.Text & "'"
            dadpt.SelectCommand = New MySqlCommand(printlogs, con)

            dadpt.Fill(ds, printlogs)
            logsfrm.crystalReport21.Load(Application.StartupPath & "\CrystalReport2.rpt")
            logsfrm.crystalReport21.SetDataSource(ds.Tables(0))

            logsfrm.CrystalReportViewer1.ReportSource = logsfrm.crystalReport21


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub forAcccrysreptUSERNAME()
        Try

            ds.Tables.Clear()
            Dim printacc As String = "select * from schooladminaccntstbl where usern like '%" & printaccountsfrm.usernameTXT.Text & "%'"
            dadpt.SelectCommand = New MySqlCommand(printacc, con)

            dadpt.Fill(ds, printacc)
            printaccountsfrm.crystalReport31.Load(Application.StartupPath & "\CrystalReport3.rpt")
            printaccountsfrm.crystalReport31.SetDataSource(ds.Tables(0))

            printaccountsfrm.CrystalReportViewer1.ReportSource = printaccountsfrm.crystalReport31


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub forAcccrysreptdatecreated()
        Try

            ds.Tables.Clear()
            Dim printacc As String = "select * from schooladminaccntstbl where datecreated like '%" & printaccountsfrm.datecreatedDTP.Text & "%'"
            dadpt.SelectCommand = New MySqlCommand(printacc, con)

            dadpt.Fill(ds, printacc)
            printaccountsfrm.crystalReport31.Load(Application.StartupPath & "\CrystalReport3.rpt")
            printaccountsfrm.crystalReport31.SetDataSource(ds.Tables(0))

            printaccountsfrm.CrystalReportViewer1.ReportSource = printaccountsfrm.crystalReport31


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub forprinttotaluntis()
        printstudrecordfrm.ListBox1.Items.Clear()
        printstudrecordfrm.ListBox2.Items.Clear()
        Dim idnum As New Label
        idnum.Text = printstudrecordfrm.forselectedrowindividualstud

        Dim fortotalunits = "select * from studsubjtbl where IDNum = '" & idnum.Text & "'"
        cmd = New MySqlCommand(fortotalunits, con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            printstudrecordfrm.ListBox1.Items.Add(dr.Item("subjcountr"))
        Loop
        dr.Close()

        For indexx As Integer = 0 To printstudrecordfrm.ListBox1.Items.Count - 1
            printstudrecordfrm.ListBox1.SelectedIndex = indexx
            printstudrecordfrm.ListBox1.SelectedItem = printstudrecordfrm.ListBox1.SelectedIndex
            printstudrecordfrm.Label9.Text = printstudrecordfrm.ListBox1.SelectedItem.ToString


            Dim forunitcountprint As String = "select * from subjectstbl where subjcountr = '" + printstudrecordfrm.Label9.Text + "'"
            cmd = New MySqlCommand(forunitcountprint, con)
            dr = cmd.ExecuteReader

            Do While dr.Read
                printstudrecordfrm.ListBox2.Items.Add(dr.Item("subjUnit"))
            Loop
            dr.Close()
        Next

        Dim sumofall As Integer
        For Each Str As String In printstudrecordfrm.ListBox2.Items
            sumofall = sumofall + CInt(Str)
        Next
        printstudrecordfrm.Label10.Text = sumofall


    End Sub

    Public Sub forprinttotaluntisonupdatetsudfrm()
        updateStudInfofrm.ListBox1.Items.Clear()
        updateStudInfofrm.ListBox2.Items.Clear()
        Dim idnum As New Label
        idnum.Text = updateStudInfofrm.StudIDNumTXT.Text
        Dim fortotalunits = "select * from studsubjtbl where IDNum = '" & idnum.Text & "'"
        cmd = New MySqlCommand(fortotalunits, con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            updateStudInfofrm.ListBox1.Items.Add(dr.Item("subjcountr"))
        Loop
        dr.Close()

        For indexx As Integer = 0 To updateStudInfofrm.ListBox1.Items.Count - 1
            updateStudInfofrm.ListBox1.SelectedIndex = indexx
            updateStudInfofrm.ListBox1.SelectedItem = updateStudInfofrm.ListBox1.SelectedIndex
            updateStudInfofrm.Label34.Text = updateStudInfofrm.ListBox1.SelectedItem.ToString


            Dim forunitcountprint As String = "select * from subjectstbl where subjcountr = '" + updateStudInfofrm.Label34.Text + "'"
            cmd = New MySqlCommand(forunitcountprint, con)
            dr = cmd.ExecuteReader

            Do While dr.Read
                updateStudInfofrm.ListBox2.Items.Add(dr.Item("subjUnit"))
            Loop
            dr.Close()
        Next


        Dim sumofall As Integer
        For Each Str As String In updateStudInfofrm.ListBox2.Items
            sumofall = sumofall + CInt(Str)
        Next
        updateStudInfofrm.Label33.Text = sumofall


    End Sub

    Public Sub forprinttotaluntisonsearchstudfrm()
        searchstudfrm.ListBox1.Items.Clear()
        searchstudfrm.ListBox2.Items.Clear()
        Dim idnum As New Label
        idnum.Text = searchstudfrm.selectedrowp.Text

        Dim fortotalunits = "select * from studsubjtbl where IDNum = '" & idnum.Text & "'"
        cmd = New MySqlCommand(fortotalunits, con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            searchstudfrm.ListBox1.Items.Add(dr.Item("subjcountr"))
        Loop
        dr.Close()

        For indexx As Integer = 0 To searchstudfrm.ListBox1.Items.Count - 1
            searchstudfrm.ListBox1.SelectedIndex = indexx
            searchstudfrm.ListBox1.SelectedItem = searchstudfrm.ListBox1.SelectedIndex
            searchstudfrm.Label9.Text = searchstudfrm.ListBox1.SelectedItem.ToString


            Dim forunitcountprint As String = "select * from subjectstbl where subjcountr = '" + searchstudfrm.Label9.Text + "'"
            cmd = New MySqlCommand(forunitcountprint, con)
            dr = cmd.ExecuteReader

            Do While dr.Read
                searchstudfrm.ListBox2.Items.Add(dr.Item("subjUnit"))
            Loop
            dr.Close()
        Next


        Dim sumofall As Integer
        For Each Str As String In searchstudfrm.ListBox2.Items
            sumofall = sumofall + CInt(Str)
        Next
        searchstudfrm.Label10.Text = sumofall


    End Sub

End Module