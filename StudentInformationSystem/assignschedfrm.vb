Imports MySql.Data.MySqlClient

Public Class assignschedfrm

    Public forselectedsearch, forselectedrow, forselectedsubj As String
    Public forchecksubjcodedb, forsubjdescriptcontainerdb, forinstructcontainerdb, forteachnamecodedb, forsubjcodedb, forselectedidnumdb, forteachiddb, _
        forsubjdescriptdb, forsubjunitdb, forsubjlechrdb, forsubjlabhrdb, forsubjtotalhrdb, forsubjdaydb, forsubjroomdb, forsubjtimedb As String
    Public selectedrow As DataGridViewRow
    Public foronlistsubj, foronlistinstruct As New ComboBox
    Public selectedsearchby As String
    Public forsemester, foryearlvl As New Label
    Public forStudIDNum, forselectedteach, forteachIDNum, forselectedassignedsubj, forsubjcountr, forselectedrowstud, forcomparesched, _
        forcomparecurrentsched As String

    Public forselectedsubjcountr As New Label

    Private Sub assignschedfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       


        With searchbyCMBO
            .Items.Add("")
            .Items.Add("ID Number")
            .Items.Add("First Name")
            .Items.Add("Family Name")
            .SelectedIndex = 0
        End With

        With Me.yearlvlCMBO
            .Items.Add("")
            .Items.Add("1st")
            .Items.Add("2nd")
            .Items.Add("3rd")
            .Items.Add("4th")
            .SelectedIndex = 0
        End With

        With Me.semesterCMBO
            .Items.Add("")
            .Items.Add("1st")
            .Items.Add("2nd")
            .SelectedIndex = 0
        End With

        forLoadDGVdisplaytoassignsched()

        displaylistofstudents()

        If StudIDNumLBL.Text.Length = 0 Then
            GroupBox2.Enabled = False
        Else
            GroupBox2.Enabled = True
        End If




        subjunitcountr()

    End Sub

    Private Sub searchstudnameTXT_TextChanged(sender As Object, e As EventArgs) Handles searchstudnameTXT.TextChanged
        forDGVsearchstudentlist()
        If searchstudnameTXT.Text.Length = 0 Then
            'forLoadDGVdisplayassignsched()
        End If
    End Sub

    Private Sub searchbyCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchbyCMBO.SelectedIndexChanged
        If searchbyCMBO.SelectedIndex = 0 Then
            'forLoadDGVdisplayassignsched()
            forselectedsearch = ""
            searchstudnameTXT.Text = Nothing
            searchstudnameTXT.Enabled = False
        ElseIf searchbyCMBO.SelectedIndex = 1 Then
            forselectedsearch = "IDNum"
            searchstudnameTXT.Text = Nothing
            searchstudnameTXT.Enabled = True
        ElseIf searchbyCMBO.SelectedIndex = 2 Then
            forselectedsearch = "FName"
            searchstudnameTXT.Text = Nothing
            searchstudnameTXT.Enabled = True
        ElseIf searchbyCMBO.SelectedIndex = 3 Then
            forselectedsearch = "FamName"
            searchstudnameTXT.Text = Nothing
            searchstudnameTXT.Enabled = True
        End If

    End Sub


    Private Sub closeCMD_Click(sender As Object, e As EventArgs) Handles closeCMD.Click
        searchbarsubjTXT.Clear()
        forLoadDGVdisplaytoassignsched()
        removefromtoassignedsubj()


        yearlvlCMBO.SelectedIndex = 0
        semesterCMBO.SelectedIndex = 0
        searchbyCMBO.SelectedIndex = 0
        Mainfrm.Enabled = True
        Me.Hide()
    End Sub

    Private Sub studentsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentsDGV.CellClick



        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then

            index = e.RowIndex + 1
            selectedrow = studentsDGV.Rows(index)
            forselectedrowstud = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from studsubjtbl where IDNum like '%" & forselectedrowstud & "%'"
            cmd = New MySqlCommand(forsearch, con)
            StudIDNumLBL.Text = forselectedrowstud


        Else

            selectedrow = studentsDGV.Rows(index)
            forselectedrowstud = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from studsubjtbl where IDNum like '%" & forselectedrowstud & "%'"
            cmd = New MySqlCommand(forsearch, con)
            StudIDNumLBL.Text = forselectedrowstud


        End If

        yearlvlCMBO.SelectedIndex = 0
        semesterCMBO.SelectedIndex = 0

        fordisplaystudassignedsubj()
        forLoadDGVdisplaytoassignsched()
        removefromtoassignedsubj()


    End Sub

    Private Sub studentsDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentsDGV.CellContentClick

    End Sub

    Private Sub studentsDGV_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles studentsDGV.CellEnter

        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = studentsDGV.Rows(index)
            forselectedrowstud = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from studinfotbl where IDNum like '%" & forselectedrowstud & "%'"
            cmd = New MySqlCommand(forsearch, con)
            StudIDNumLBL.Text = forselectedrowstud
            dr = cmd.ExecuteReader
            While dr.Read
                forsemester.Text = dr.Item("Semester")
                foryearlvl.Text = dr.Item("YearLevel")
            End While
            dr.Close()

        Else

            selectedrow = studentsDGV.Rows(index)
            forselectedrowstud = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from studinfotbl where IDNum like '%" & forselectedrowstud & "%'"
            cmd = New MySqlCommand(forsearch, con)
            StudIDNumLBL.Text = forselectedrowstud
            dr = cmd.ExecuteReader
            While dr.Read
                forsemester.Text = dr.Item("Semester")
                foryearlvl.Text = dr.Item("YearLevel")

            End While
            dr.Close()


        End If

        yearlvlCMBO.SelectedIndex = 0
        semesterCMBO.SelectedIndex = 0

        fordisplaystudassignedsubj()
        forLoadDGVdisplaytoassignsched()
        removefromtoassignedsubj()



        subjunitcountr()


    End Sub


    Private Sub addsubjCMBO_Click(sender As Object, e As EventArgs) Handles addsubjCMBO.Click

        subjunitcountr()

        If CInt(Label7.Text) >= 26 Then
            MessageBox.Show("No. of Units has exeeded.", "Overlaod Units", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else


            forassigningsubj()


            fordisplaystudassignedsubj()

            removefromtoassignedsubj()

            subjunitcountr()

        End If

        


       


    End Sub





    
    Private Sub yearlvlCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles yearlvlCMBO.SelectedIndexChanged
        If yearlvlCMBO.SelectedIndex = 0 Then
            searchbarsubjTXT.Text = Nothing
            searchbarsubjTXT.Enabled = False
            removefromtoassignedsubj()
        Else
            searchbarsubjTXT.Enabled = True
            forsortingsubj()
            removefromtoassignedsubj()
        End If

    End Sub

    Private Sub semesterCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles semesterCMBO.SelectedIndexChanged
        If semesterCMBO.SelectedIndex = 0 Then
            searchbarsubjTXT.Text = Nothing
            searchbarsubjTXT.Enabled = False
            removefromtoassignedsubj()
        Else
            searchbarsubjTXT.Enabled = True
            forsortingsubj()
            removefromtoassignedsubj()
        End If

    End Sub

    Private Sub searchbarsubjTXT_TextChanged(sender As Object, e As EventArgs) Handles searchbarsubjTXT.TextChanged
        If searchbarsubjTXT.Text.Length = 0 Then
            forLoadDGVdisplaytoassignsched()
            removefromtoassignedsubj()
        Else
            searchsorttoassignsubjsched()
            removefromtoassignedsubj()
        End If

    End Sub

    Private Sub subjectsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles subjectsDGV.CellClick
        dr.Close()
        Dim index As Integer
        index = e.RowIndex


        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = subjectsDGV.Rows(index)
            forselectedrow = selectedrow.Cells(1).Value.ToString()
            forselectedsubjcountr.Text = selectedrow.Cells(0).Value.ToString
            Dim selectedsubj As String = "select * from subjectstbl where subjCode = '" + forselectedrow + "'"
            cmd = New MySqlCommand(selectedsubj, con)
            dr = cmd.ExecuteReader
            While dr.Read
                forsubjcountr = dr.Item("subjcountr")

            End While
            dr.Close()

            forselectedteach = selectedrow.Cells(3).Value.ToString()
            Dim selectedinstruct As String = "select * from teacherinfotbl where teachnamecode = '" + forselectedteach + "'"
            cmd = New MySqlCommand(selectedinstruct, con)
            dr = cmd.ExecuteReader
            While dr.Read
                forteachIDNum = dr.Item("teachIDNum")
            End While
            dr.Close()



        Else

            selectedrow = subjectsDGV.Rows(index)
            forselectedrow = selectedrow.Cells(1).Value.ToString()
            forselectedsubjcountr.Text = selectedrow.Cells(0).Value.ToString
            Dim selectedsubj As String = "select * from subjectstbl where subjCode = '" + forselectedrow + "'"
            cmd = New MySqlCommand(selectedsubj, con)
            dr = cmd.ExecuteReader
            While dr.Read
                forsubjcountr = dr.Item("subjcountr")

            End While
            dr.Close()

            forselectedteach = selectedrow.Cells(3).Value.ToString()
            Dim selectedinstruct As String = "select * from teacherinfotbl where teachnamecode = '" + forselectedteach + "'"
            cmd = New MySqlCommand(selectedinstruct, con)
            dr = cmd.ExecuteReader
            While dr.Read
                forteachIDNum = dr.Item("teachIDNum")
            End While
            dr.Close()



        End If



    End Sub

    Private Sub subjectsDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles subjectsDGV.CellContentClick

    End Sub

    Private Sub subjectsDGV_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles subjectsDGV.CellEnter
        dr.Close()
        Dim index As Integer
        index = e.RowIndex


        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = subjectsDGV.Rows(index)
            forselectedrow = selectedrow.Cells(1).Value.ToString()
            forselectedsubjcountr.Text = selectedrow.Cells(0).Value.ToString
            Dim selectedsubj As String = "select * from subjectstbl where subjCode = '" + forselectedrow + "'"
            cmd = New MySqlCommand(selectedsubj, con)
            dr = cmd.ExecuteReader
            While dr.Read
                forsubjcountr = dr.Item("subjcountr")

            End While
            dr.Close()

            forselectedteach = selectedrow.Cells(3).Value.ToString()
            Dim selectedinstruct As String = "select * from teacherinfotbl where teachnamecode = '" + forselectedteach + "'"
            cmd = New MySqlCommand(selectedinstruct, con)
            dr = cmd.ExecuteReader
            While dr.Read
                forteachIDNum = dr.Item("teachIDNum")
            End While
            dr.Close()




        Else

            selectedrow = subjectsDGV.Rows(index)
            forselectedrow = selectedrow.Cells(1).Value.ToString()
            forselectedsubjcountr.Text = selectedrow.Cells(0).Value.ToString
            Dim selectedsubj As String = "select * from subjectstbl where subjCode = '" + forselectedrow + "'"
            cmd = New MySqlCommand(selectedsubj, con)
            dr = cmd.ExecuteReader
            Do While dr.Read
                forsubjcountr = dr.Item("subjcountr")

            Loop
            dr.Close()



            forselectedteach = selectedrow.Cells(3).Value.ToString()
            Dim selectedinstruct As String = "select * from teacherinfotbl where teachnamecode = '" + forselectedteach + "'"
            cmd = New MySqlCommand(selectedinstruct, con)
            dr = cmd.ExecuteReader
            While dr.Read
                forteachIDNum = dr.Item("teachIDNum")
            End While
            dr.Close()



        End If



    End Sub

  
    Private Sub assignedsubj_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles assignedsubj.CellContentClick
        
    End Sub


    Private Sub assignedsubj_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles assignedsubj.CellEnter

        dr.Close()
        Dim index As Integer
        index = e.RowIndex

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = assignedsubj.Rows(index)
            forselectedassignedsubj = selectedrow.Cells(0).Value.ToString
        Else
            selectedrow = assignedsubj.Rows(index)
            forselectedassignedsubj = selectedrow.Cells(0).Value.ToString
        End If

    End Sub

    Private Sub removeassignedsubjCMD_Click(sender As Object, e As EventArgs) Handles removeassignedsubjCMD.Click


        removeassignedsubj()

        fordisplaystudassignedsubj()
        forLoadDGVdisplaytoassignsched()
        removefromtoassignedsubj()

        subjunitcountr()

    End Sub

    Private Sub forsubjcount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles forsubjcount.SelectedIndexChanged

    End Sub
End Class