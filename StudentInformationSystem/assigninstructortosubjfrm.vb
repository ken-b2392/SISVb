Imports MySql.Data.MySqlClient

Public Class assigninstructortosubjfrm

    Public forselectedrowsubj, forselectedrowteach, forselectedrowhandeledsubj As String
    Public forselectedday, forselectedtfrom, forselectedtto As New Label
    Public forsubjcode, forsubjName, forsubjnoUnits, forsubjLecHr, forsubjLabHr, forsubjTotalHr, forsubjDay, forsubjRoom, forsubjTFrom, forsubjTTo As New Label
    Public forHsubjcode, forHsubjName, forHsubjnoUnits, forHsubjLecHr, forHsubjLabHr, forHsubjTotalHr, forHsubjDay, forHsubjRoom, forHsubjTFrom, forHsubjTTo As New Label
    Public forteachIDNum, forteachFname, forteachMI, forteachFamname, forteachGender, forteachAddress, forteachnamecode As New ListBox
    Public forsearchbyinstruct, forsearchbysubj As String
    Public dayselected, roomselected, Tfromselected, TToselected As New ListBox
    Public selectedDay, selectedRoom, selectedTFrom, selectedTTo, selectedsubjcountr, combinecompare As String
    Public forsubjectcode As New ListBox
    Public forsubjcountr As New ListBox
    Public forselectedsearchfor As New Label
    Public forsubjectcounter As String

    Private Sub closeCMD_Click(sender As Object, e As EventArgs) Handles closeCMD.Click
        Me.searchbyinstructCMBO.SelectedIndex = 0
        Me.searchbysubjtoAssignCMBO.SelectedIndex = 0
        Mainfrm.Enabled = True
        Me.Hide()
    End Sub

    Private Sub assigninstructortosubjfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fordgvassignteach()
        fordisplaysubjtoassigndgv()
        displaytheassignedsubjects()




        With Me.searchbyinstructCMBO
            .Items.Add("")
            .Items.Add("ID Number")
            .Items.Add("Name code")
            .Items.Add("First name")
            .Items.Add("Last name")
            .SelectedIndex = 0
        End With


        With searchbysubjtoAssignCMBO
            .Items.Add("")
            .Items.Add("Subject Code")
            .Items.Add("Subject Description")
            .SelectedIndex = 0
        End With


        fordgvassignteach()



    End Sub


    Private Sub searchbyinstructCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchbyinstructCMBO.SelectedIndexChanged

        If searchbyinstructCMBO.SelectedIndex = 0 Then
            searchbarinstructorTXT.Text = ""
            searchbarinstructorTXT.Enabled = False
            forsearchbyinstruct = ""

        ElseIf searchbyinstructCMBO.SelectedIndex = 1 Then
            forsearchbyinstruct = "teachIDNum"
            searchbarinstructorTXT.Enabled = True
            searchbarinstructorTXT.Text = Nothing
        ElseIf searchbyinstructCMBO.SelectedIndex = 2 Then
            forsearchbyinstruct = "teachnamecode"
            searchbarinstructorTXT.Enabled = True
            searchbarinstructorTXT.Text = Nothing
        ElseIf searchbyinstructCMBO.SelectedIndex = 3 Then
            forsearchbyinstruct = "teachFnam"
            searchbarinstructorTXT.Enabled = True
            searchbarinstructorTXT.Text = Nothing
        ElseIf searchbyinstructCMBO.SelectedIndex = 4 Then
            forsearchbyinstruct = "teachFamname"
            searchbarinstructorTXT.Enabled = True
            searchbarinstructorTXT.Text = Nothing
        End If
    End Sub


    Private Sub teacherDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles teacherDGV.CellClick



        dr.Close()
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = teacherDGV.Rows(index)
            forselectedrowteach = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from teacherinfotbl where teachIDNum = '" & forselectedrowteach & "'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader
            dr.Read()

            While dr.Read
                forteachIDNum.Text = dr.Item("teachIDNum")
                forteachFname.Text = dr.Item("teachFname")
                forteachMI.Text = dr.Item("teachMI")
                forteachFamname.Text = dr.Item("teachFamname")
                forteachGender.Text = dr.Item("teachGender")
                forteachAddress.Text = dr.Item("teachAddress")
                forteachnamecode.Text = dr.Item("teachnamecode")
            End While
            dr.Close()

        Else

            selectedrow = teacherDGV.Rows(index)
            forselectedrowteach = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from teacherinfotbl where teachIDNum = '" & forselectedrowteach & "'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader

            While dr.Read
                forteachIDNum.Text = dr.Item("teachIDNum")
                forteachFname.Text = dr.Item("teachFname")
                forteachMI.Text = dr.Item("teachMI")
                forteachFamname.Text = dr.Item("teachFamname")
                forteachGender.Text = dr.Item("teachGender")
                forteachAddress.Text = dr.Item("teachAddress")
                forteachnamecode.Text = dr.Item("teachnamecode")
            End While

            dr.Close()




        End If




        getteachIDNumandsubjCode()

        displaytheassignedsubjects()

        toremoveselectedsubj()

    End Sub

    Private Sub teacherDGV_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles teacherDGV.CellEnter

        dr.Close()
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = teacherDGV.Rows(index)
            forselectedrowteach = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from teacherinfotbl where teachIDNum = '" & forselectedrowteach & "'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader
            While dr.Read()
                'forteachIDNum, forteachFname, forteachMI, forteachFamname, forteachGender, forteachAddress, forteachnamecode 

                forteachIDNum.Text = dr.Item("teachIDNum")
                forteachFname.Text = dr.Item("teachFname")
                forteachMI.Text = dr.Item("teachMI")
                forteachFamname.Text = dr.Item("teachFamname")
                forteachGender.Text = dr.Item("teachGender")
                forteachAddress.Text = dr.Item("teachAddress")
                forteachnamecode.Text = dr.Item("teachnamecode")
            End While
            dr.Close()





        Else

            selectedrow = teacherDGV.Rows(index)
            forselectedrowteach = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from teacherinfotbl where teachIDNum = '" & forselectedrowteach & "'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader

            While dr.Read
                forteachIDNum.Text = dr.Item("teachIDNum")
                forteachFname.Text = dr.Item("teachFname")
                forteachMI.Text = dr.Item("teachMI")
                forteachFamname.Text = dr.Item("teachFamname")
                forteachGender.Text = dr.Item("teachGender")
                forteachAddress.Text = dr.Item("teachAddress")
                forteachnamecode.Text = dr.Item("teachnamecode")
            End While

            dr.Close()







        End If




        getteachIDNumandsubjCode()

        displaytheassignedsubjects()

        toremoveselectedsubj()


    End Sub

    Private Sub handledsubjDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles handledsubjDGV.CellClick
        dr.Close()
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = handledsubjDGV.Rows(index)
            forselectedrowhandeledsubj = selectedrow.Cells(0).Value.ToString()
            forsubjectcounter = selectedrow.Cells(10).Value.ToString
            forsearch = "select * from assignedsubjtoteachtbl where subjCode like '%" & forselectedrowhandeledsubj & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader







        Else

            selectedrow = handledsubjDGV.Rows(index)
            forselectedrowhandeledsubj = selectedrow.Cells(0).Value.ToString()
            forsubjectcounter = selectedrow.Cells(10).Value.ToString
            forsearch = "select * from assignedsubjtoteachtbl where subjCode like '%" & forselectedrowhandeledsubj & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader



        End If



    End Sub

    Private Sub handledsubjDGV_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles handledsubjDGV.CellEnter
        forselectedrowhandeledsubj

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = handledsubjDGV.Rows(index)
            forselectedrowhandeledsubj = selectedrow.Cells(0).Value.ToString()
            forsubjectcounter = selectedrow.Cells(10).Value.ToString

            

        Else

            selectedrow = handledsubjDGV.Rows(index)
            forselectedrowhandeledsubj = selectedrow.Cells(0).Value.ToString()
            forsubjectcounter = selectedrow.Cells(10).Value.ToString

            
        End If




    End Sub

    Private Sub assignsubjCMD_Click(sender As Object, e As EventArgs) Handles assignsubjCMD.Click
        dr.Close()
        If displaysubjdgv.Rows.Count = 0 Then
        Else
            forassignsubj()
            assignschedfrm.Show()
            fordisplaystudassignedsubj()
            forLoadDGVdisplaytoassignsched()
            removefromtoassignedsubj()
            assignschedfrm.Hide()

        End If
    End Sub

    Private Sub removesubjCMD_Click(sender As Object, e As EventArgs) Handles removesubjCMD.Click
        dr.Close()
        If handledsubjDGV.Rows.Count = 0 Then
        Else
            removefromlist()



            fordisplaystudassignedsubj()
            forLoadDGVdisplaytoassignsched()
            removefromtoassignedsubj()

        End If

    End Sub




    Private Sub searchbarinstructorTXT_TextChanged(sender As Object, e As EventArgs) Handles searchbarinstructorTXT.TextChanged
        If searchbarinstructorTXT.Text.Length = 0 Then
            fordgvassignteach()
        Else
            fordgvassignteachsearch()
        End If
    End Sub



    Private Sub teacherDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles teacherDGV.CellContentClick

    End Sub

    Private Sub displaysubjdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles displaysubjdgv.CellContentClick

    End Sub

    Private Sub displaysubjdgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles displaysubjdgv.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = displaysubjdgv.Rows(index)
            forselectedrowsubj = selectedrow.Cells(0).Value.ToString()


            forselectedday.Text = selectedrow.Cells(6).Value.ToString
            forselectedtfrom.Text = selectedrow.Cells(8).Value.ToString
            forselectedtto.Text = selectedrow.Cells(9).Value.ToString



        Else

            selectedrow = displaysubjdgv.Rows(index)
            forselectedrowsubj = selectedrow.Cells(0).Value.ToString()


            forselectedday.Text = selectedrow.Cells(6).Value.ToString
            forselectedtfrom.Text = selectedrow.Cells(8).Value.ToString
            forselectedtto.Text = selectedrow.Cells(9).Value.ToString


            dayselected.Text = Nothing
            roomselected.Text = Nothing
            Tfromselected.Text = Nothing
            TToselected.Text = Nothing
            Dim searchfor As String = "select * from assignedsubjtoteachtbl where subjCode = '" + forselectedrowsubj + "' and subjDay = '" + selectedDay _
                                      + "' and subjRoom = '" + selectedRoom + "' and subjTimefrom = '" + selectedTFrom + "' and subjTimeTo = '" + selectedTTo + "'"
            cmd = New MySqlCommand(searchfor, con)
            dr = cmd.ExecuteReader
            While dr.Read
                dayselected.Text = dr.Item("subjDay")
                roomselected.Text = dr.Item("subjRoom")
                Tfromselected.Text = dr.Item("subjTimefrom")
                TToselected.Text = dr.Item("subjTimeTo")
            End While
            dr.Close()
            combinecompare = dayselected.Text & roomselected.Text & Tfromselected.Text & TToselected.Text


        End If
    End Sub

    Private Sub displaysubjdgv_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles displaysubjdgv.CellEnter
        dr.Close()
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = displaysubjdgv.Rows(index)
            forselectedrowsubj = selectedrow.Cells(0).Value.ToString()


            forselectedday.Text = selectedrow.Cells(6).Value.ToString
            forselectedtfrom.Text = selectedrow.Cells(8).Value.ToString
            forselectedtto.Text = selectedrow.Cells(9).Value.ToString


        Else

            selectedrow = displaysubjdgv.Rows(index)
            forselectedrowsubj = selectedrow.Cells(0).Value.ToString()


            forselectedday.Text = selectedrow.Cells(6).Value.ToString
            forselectedtfrom.Text = selectedrow.Cells(8).Value.ToString
            forselectedtto.Text = selectedrow.Cells(9).Value.ToString



            dayselected.Text = Nothing
            roomselected.Text = Nothing
            Tfromselected.Text = Nothing
            TToselected.Text = Nothing
            selectedDay = selectedrow.Cells(6).Value.ToString()
            selectedRoom = selectedrow.Cells(7).Value.ToString()
            selectedTFrom = selectedrow.Cells(8).Value.ToString()
            selectedTTo = selectedrow.Cells(9).Value.ToString()
            Dim searchfor As String = "select * from assignedsubjtoteachtbl where subjCode = '" + forselectedrowsubj + "' and subjDay = '" + selectedDay _
                                      + "' and subjRoom = '" + selectedRoom + "' and subjTimefrom = '" + selectedTFrom + "' and subjTimeTo = '" + selectedTTo + "'"
            cmd = New MySqlCommand(searchfor, con)
            dr = cmd.ExecuteReader
            While dr.Read
                dayselected.Text = dr.Item("subjDay")
                roomselected.Text = dr.Item("subjRoom")
                Tfromselected.Text = dr.Item("subjTimefrom")
                TToselected.Text = dr.Item("subjTimeTo")
            End While
            dr.Close()
            combinecompare = dayselected.Text & roomselected.Text & Tfromselected.Text & TToselected.Text

            Dim searchingsubjcountr As String = "select * from subjectstbl where subjCode = '" + forselectedrowsubj + "' and subjDay = '" + selectedDay _
                                      + "' and subjRoom = '" + selectedRoom + "' and subjTimefrom = '" + selectedTFrom + "' and subjTimeTo = '" + selectedTTo + "'"
            cmd = New MySqlCommand(searchingsubjcountr, con)
            dr = cmd.ExecuteReader
            While dr.Read
                selectedsubjcountr = dr.Item("subjcountr")
            End While
            dr.Close()
        End If
    End Sub


    Private Sub handledsubjDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles handledsubjDGV.CellContentClick

    End Sub


    Private Sub searchtoassignsubjTXT_TextChanged(sender As Object, e As EventArgs) Handles searchtoassignsubjTXT.TextChanged
        searchfortoassignsubjects()
    End Sub

    Private Sub searchbysubjtoAssignCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchbysubjtoAssignCMBO.SelectedIndexChanged
        If searchbysubjtoAssignCMBO.SelectedIndex = 0 Then
            searchtoassignsubjTXT.Text = Nothing
            searchtoassignsubjTXT.Enabled = False
        ElseIf searchbysubjtoAssignCMBO.SelectedIndex = 1 Then
            forselectedsearchfor.Text = "subjCode"
            searchtoassignsubjTXT.Text = Nothing
            searchtoassignsubjTXT.Enabled = True
        ElseIf searchbysubjtoAssignCMBO.SelectedIndex = 2 Then
            forselectedsearchfor.Text = "subjDescript"
            searchtoassignsubjTXT.Text = Nothing
            searchtoassignsubjTXT.Enabled = True
        End If
    End Sub

End Class