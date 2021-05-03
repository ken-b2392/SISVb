Imports MySql.Data.MySqlClient

Public Class addsubjectfrm

    Public forselectedrow, forselectedday, forsearchby As String
    Public listtimeStartB, listtimeEndB As New ListBox
    Public daylist As New ListBox
    Public forsubjcountr As New Label
    Public checklbl As New Label

    Private Sub closeCMD_Click(sender As Object, e As EventArgs) Handles closeCMD.Click
        Mainfrm.Enabled = True
        searchbarTXT.Text = Nothing
        searchbyCMBO.SelectedIndex = 0
        toresetctrl()
        Me.Hide()
    End Sub



    Private Sub addsubjectfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With Me.semesterCMBO
            .Items.Add("")
            .Items.Add("1st")
            .Items.Add("2nd")
            .Items.Add("Summer")
            .SelectedIndex = 0
            .BackColor = Color.White
        End With

        With Me.yearlvlCMBO
            .Items.Add("")
            .Items.Add("1st")
            .Items.Add("2nd")
            .Items.Add("3rd")
            .Items.Add("4th")
            .SelectedIndex = 0
            .BackColor = Color.White
        End With

        With Me.subjdayCMBO
            .Items.Add("")
            .Items.Add("Mon")
            .Items.Add("Tue")
            .Items.Add("Wed")
            .Items.Add("Thu")
            .Items.Add("Fri")
            .Items.Add("Sat")
            .SelectedIndex = 0
            .BackColor = Color.White
        End With

        With Me.searchbyCMBO
            .Items.Add("")
            .Items.Add("Subject Code")
            .Items.Add("Subject Name")
            .Items.Add("Day")
            .Items.Add("Room")
            .SelectedIndex = 0
            .BackColor = Color.White
        End With

        RadioButton1.Checked = True

        fordisplaysubjdgv()
        toresetctrl()


    End Sub

    Private Sub subjsaveCMD_Click(sender As Object, e As EventArgs) Handles subjsaveCMD.Click

        Dim empty = Me.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)



        If displaysubjdgv.Rows.Count = 0 Then

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


                MessageBox.Show("Please comply all the necessary details.", "Incomplete details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                foraddingsubj()

                displaytheassignedsubjects()
                fordisplaysubjtoassigndgv()
                toremoveselectedsubj()

            End If

            
        Else

            beforeadding()



        End If


    End Sub


    Private Sub subjdayCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subjdayCMBO.SelectedIndexChanged


        If subjdayCMBO.SelectedItem = "" Then
            subjdayCMBO.BackColor = Color.DarkRed
            forselectedday = ""

        Else
            subjdayCMBO.BackColor = Color.White
            forselectedday = subjdayCMBO.Text

        End If

    End Sub

    Private Sub searchbyCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchbyCMBO.SelectedIndexChanged
        If searchbyCMBO.SelectedIndex = 0 Then
            fordisplaysubjdgv()
            searchbarTXT.Enabled = False
        ElseIf searchbyCMBO.SelectedIndex = 1 Then
            forsearchby = "subjCode"
            searchbarTXT.Enabled = True
        ElseIf searchbyCMBO.SelectedIndex = 2 Then
            forsearchby = "subjDescript"
            searchbarTXT.Enabled = True
        ElseIf searchbyCMBO.SelectedIndex = 3 Then
            forsearchby = "subjDay"
            searchbarTXT.Enabled = True
        ElseIf searchbyCMBO.SelectedIndex = 4 Then
            forsearchby = "subjRoom"
            searchbarTXT.Enabled = True
        End If

    End Sub

    Private Sub subjnoUnitsTXT_TextChanged(sender As Object, e As EventArgs) Handles subjnoUnitsTXT.TextChanged
        subjnoUnitsTXT.Text = LTrim(subjnoUnitsTXT.Text)
        Dim totrapint As Integer
        If Integer.TryParse(subjnoUnitsTXT.Text, totrapint) Then
        Else
            subjnoUnitsTXT.Clear()
        End If

        If subjnoUnitsTXT.Text.Length <> 0 Then
            subjnoUnitsTXT.BackColor = Color.White
        End If

    End Sub

    Private Sub subjLecHrTXT_TextChanged(sender As Object, e As EventArgs) Handles subjLecHrTXT.TextChanged
        subjLecHrTXT.Text = LTrim(subjLecHrTXT.Text)
        Dim totrapint As Integer
        If Integer.TryParse(subjLecHrTXT.Text, totrapint) Then
            If subjLabHrTXT.Text.Length = 0 Then
                subjLabHrTXT.Text = 0
                Me.subjTotalHrLBL.Text = CInt(subjLecHrTXT.Text) + CInt(subjLabHrTXT.Text)
            Else
                Me.subjTotalHrLBL.Text = CInt(subjLecHrTXT.Text) + CInt(subjLabHrTXT.Text)
            End If
        Else
            subjLecHrTXT.Clear()
        End If
        If subjLecHrTXT.Text.Length <> 0 Then
            subjLecHrTXT.BackColor = Color.White
        End If

        If subjLecHrTXT.Text.Length = 0 And subjLabHrTXT.Text.Length = 0 Then
            subjTotalHrLBL.Text = Nothing
        End If

    End Sub

    Private Sub subjLabHrTXT_TextChanged(sender As Object, e As EventArgs) Handles subjLabHrTXT.TextChanged
        subjLabHrTXT.Text = LTrim(subjLabHrTXT.Text)
        Dim totrapint As Integer
        If Integer.TryParse(subjLabHrTXT.Text, totrapint) Then
            If subjLecHrTXT.Text.Length = 0 Then
                subjLecHrTXT.Text = 0
                Me.subjTotalHrLBL.Text = CInt(subjLecHrTXT.Text) + CInt(subjLabHrTXT.Text)
            Else
                Me.subjTotalHrLBL.Text = CInt(subjLecHrTXT.Text) + CInt(subjLabHrTXT.Text)
            End If
        Else
            subjLabHrTXT.Clear()
        End If
        If subjLabHrTXT.Text.Length <> 0 Then
            subjLabHrTXT.BackColor = Color.White
        End If

        If subjLecHrTXT.Text.Length = 0 And subjLabHrTXT.Text.Length = 0 Then
            subjTotalHrLBL.Text = Nothing
        End If

    End Sub


    Private Sub displaysubjdgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles displaysubjdgv.CellClick

        subjsaveCMD.Enabled = False

        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = displaysubjdgv.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from subjectstbl where subjcountr = '" & forselectedrow & "'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader


            While dr.Read()


                Me.semesterCMBO.SelectedItem = dr.Item("forsubjsem")
                Me.yearlvlCMBO.SelectedItem = dr.Item("foryearlvl")
                Me.subjCodeTXT.Text = dr.Item("subjCode")
                Me.subjNameTXT.Text = dr.Item("subjDescript")
                Me.subjnoUnitsTXT.Text = dr.Item("subjUnit")
                Me.subjLecHrTXT.Text = dr.Item("subjLecHr")
                Me.subjLabHrTXT.Text = dr.Item("subjLabHr")
                Me.subjTotalHrLBL.Text = dr.Item("subjTotalHr")
                Me.subjdayCMBO.Text = dr.Item("subjDay")
                Me.subjRoomTXT.Text = dr.Item("subjRoom")
                Me.subjTFromPICKER.Text = dr.Item("subjTimefrom")
                Me.subjTToPICKER.Text = dr.Item("subjTimeTo")
            End While
            dr.Close()



        Else




            selectedrow = displaysubjdgv.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from subjectstbl where subjcountr = '" & forselectedrow & "'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader

            While dr.Read()


                Me.semesterCMBO.SelectedItem = dr.Item("forsubjsem")
                Me.yearlvlCMBO.SelectedItem = dr.Item("foryearlvl")
                Me.subjCodeTXT.Text = dr.Item("subjCode")
                Me.subjNameTXT.Text = dr.Item("subjDescript")
                Me.subjnoUnitsTXT.Text = dr.Item("subjUnit")
                Me.subjLecHrTXT.Text = dr.Item("subjLecHr")
                Me.subjLabHrTXT.Text = dr.Item("subjLabHr")
                Me.subjTotalHrLBL.Text = dr.Item("subjTotalHr")
                Me.subjdayCMBO.Text = dr.Item("subjDay")
                Me.subjRoomTXT.Text = dr.Item("subjRoom")
                Me.subjTFromPICKER.Text = dr.Item("subjTimefrom")
                Me.subjTToPICKER.Text = dr.Item("subjTimeTo")
            End While
            dr.Close()

        End If
    End Sub

    Private Sub displaysubjdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles displaysubjdgv.CellContentClick

    End Sub

    Private Sub displaysubjdgv_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles displaysubjdgv.CellEnter

        subjsaveCMD.Enabled = False

        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = displaysubjdgv.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from subjectstbl where subjcountr = '" & forselectedrow & "'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader


            While dr.Read()


                Me.semesterCMBO.SelectedItem = dr.Item("forsubjsem")
                Me.yearlvlCMBO.SelectedItem = dr.Item("foryearlvl")
                Me.subjCodeTXT.Text = dr.Item("subjCode")
                Me.subjNameTXT.Text = dr.Item("subjDescript")
                Me.subjnoUnitsTXT.Text = dr.Item("subjUnit")
                Me.subjLecHrTXT.Text = dr.Item("subjLecHr")
                Me.subjLabHrTXT.Text = dr.Item("subjLabHr")
                Me.subjTotalHrLBL.Text = dr.Item("subjTotalHr")
                Me.subjdayCMBO.Text = dr.Item("subjDay")
                Me.subjRoomTXT.Text = dr.Item("subjRoom")
                Me.subjTFromPICKER.Text = dr.Item("subjTimefrom")
                Me.subjTToPICKER.Text = dr.Item("subjTimeTo")
            End While
            dr.Close()



        Else




            selectedrow = displaysubjdgv.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from subjectstbl where subjcountr = '" & forselectedrow & "'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader

            While dr.Read()
                Me.semesterCMBO.SelectedItem = dr.Item("forsubjsem")
                Me.yearlvlCMBO.SelectedItem = dr.Item("foryearlvl")
                Me.subjCodeTXT.Text = dr.Item("subjCode")
                Me.subjNameTXT.Text = dr.Item("subjDescript")
                Me.subjnoUnitsTXT.Text = dr.Item("subjUnit")
                Me.subjLecHrTXT.Text = dr.Item("subjLecHr")
                Me.subjLabHrTXT.Text = dr.Item("subjLabHr")
                Me.subjTotalHrLBL.Text = dr.Item("subjTotalHr")
                Me.subjdayCMBO.Text = dr.Item("subjDay")
                Me.subjRoomTXT.Text = dr.Item("subjRoom")
                Me.subjTFromPICKER.Text = dr.Item("subjTimefrom")
                Me.subjTToPICKER.Text = dr.Item("subjTimeTo")

            End While
            dr.Close()



        End If
    End Sub

    Private Sub subjUpdateCMD_Click(sender As Object, e As EventArgs) Handles subjUpdateCMD.Click
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



            For Each cmbo As Control In Me.Controls
                If TypeOf cmbo Is ComboBox Then
                    If cmbo.Text.Length = 0 Then
                        cmbo.BackColor = Color.DarkRed
                    Else
                        cmbo.BackColor = Color.White
                    End If
                End If
            Next


        ElseIf subjdayCMBO.SelectedItem = "" And Me.semesterCMBO.SelectedItem = "" And Me.yearlvlCMBO.SelectedItem = "" Then
            If subjdayCMBO.Text.Length = 0 And Me.semesterCMBO.Text.Length = 0 And Me.yearlvlCMBO.Text.Length = 0 Then
                subjdayCMBO.BackColor = Color.DarkRed
                semesterCMBO.BackColor = Color.DarkRed
                yearlvlCMBO.BackColor = Color.DarkRed
            Else
                subjdayCMBO.BackColor = Color.White
                semesterCMBO.BackColor = Color.White
                yearlvlCMBO.BackColor = Color.White
            End If

            MessageBox.Show("Please comply all the necessary details.", "Incomplete details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            forupdatesubj()

            displaytheassignedsubjects()
            fordisplaysubjtoassigndgv()
            toremoveselectedsubj()

        
        End If

    End Sub

    Private Sub subjDeleteCMD_Click(sender As Object, e As EventArgs) Handles subjDeleteCMD.Click
        If displaysubjdgv.RowCount = 0 Then

        Else
            Dim confirmdelete As DialogResult = MessageBox.Show("Are you sure you want to delete the subject information?", "Confirmation", MessageBoxButtons.YesNo, _
                                                                MessageBoxIcon.Question)
            If confirmdelete = Windows.Forms.DialogResult.Yes Then
                fordeletesubj()
                displaytheassignedsubjects()
                fordisplaysubjtoassigndgv()
                toremoveselectedsubj()


                

            End If

        End If
    End Sub

    Private Sub subjclearCMD_Click(sender As Object, e As EventArgs) Handles subjclearCMD.Click
        toresetctrl()
    End Sub

    Private Sub subjRoomTXT_LostFocus(sender As Object, e As EventArgs) Handles subjRoomTXT.LostFocus
        'subjRoomTXT.Text = subjRoomTXT.Text.ToUpper
    End Sub

    Private Sub subjRoomTXT_TextChanged(sender As Object, e As EventArgs) Handles subjRoomTXT.TextChanged

        If subjRoomTXT.Text.Length <> 0 Then
            subjRoomTXT.BackColor = Color.White
        End If
    End Sub

    Private Sub subjCodeTXT_TextChanged(sender As Object, e As EventArgs) Handles subjCodeTXT.TextChanged
        If subjCodeTXT.Text.Length <> 0 Then
            subjCodeTXT.BackColor = Color.White
        End If
    End Sub

    Private Sub subjNameTXT_TextChanged(sender As Object, e As EventArgs) Handles subjNameTXT.TextChanged

        If subjNameTXT.Text.Length <> 0 Then
            subjNameTXT.BackColor = Color.White
        End If
    End Sub

    
    Private Sub searchbarTXT_TextChanged(sender As Object, e As EventArgs) Handles searchbarTXT.TextChanged

        If searchbarTXT.Text.Length = 0 Then
            fordisplaysubjdgv()
            ' Else

        End If
        fordisplaysubjdgvsearch()
    End Sub

  

    Private Sub subjTFromPICKER_ValueChanged(sender As Object, e As EventArgs) Handles subjTFromPICKER.ValueChanged
        Try
            If subjTotalHrLBL.Text.Length = 0 Then
            Else
                Dim toaddtime, insertcolon As String

                toaddtime = Replace(DateTime.Parse(subjTFromPICKER.Text).ToString("HH:mm"), ":", "") + CInt(Me.subjTotalHrLBL.Text & "00")
                If toaddtime.Length = 3 Then
                    insertcolon = "0" & toaddtime.Insert(1, ":")

                    subjTToPICKER.Text = insertcolon

                Else
                    insertcolon = toaddtime.Insert(2, ":")

                    subjTToPICKER.Text = insertcolon

                End If


            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            subjLecHrTXT.Enabled = True
            subjLecHrTXT.Clear()
            RadioButton2.Checked = False
            subjLabHrTXT.Clear()
            subjLabHrTXT.Enabled = False
            If subjLecHrTXT.Text.Length = 0 And subjLabHrTXT.Text.Length = 0 Then
                subjTotalHrLBL.Text = Nothing
            End If
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            subjLecHrTXT.Enabled = False
            RadioButton1.Checked = False
            subjLecHrTXT.Clear()
            subjLabHrTXT.Enabled = True
            subjLabHrTXT.Clear()
            If subjLecHrTXT.Text.Length = 0 And subjLabHrTXT.Text.Length = 0 Then
                subjTotalHrLBL.Text = Nothing
            End If
        End If
    End Sub

    Private Sub refreshPB_Click(sender As Object, e As EventArgs) Handles refreshPB.Click
        subjsaveCMD.Enabled = True
        yearlvlCMBO.SelectedIndex = 0
        semesterCMBO.SelectedIndex = 0
        subjCodeTXT.Clear()
        subjNameTXT.Clear()
        subjnoUnitsTXT.Clear()
        subjLecHrTXT.Clear()
        subjLabHrTXT.Clear()
        subjTotalHrLBL.Text = Nothing
        subjdayCMBO.SelectedIndex = 0
        subjdayCMBO.BackColor = Color.White
        subjRoomTXT.Clear()
        subjTFromPICKER.ResetText()

    End Sub
End Class