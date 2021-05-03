Imports MySql.Data.MySqlClient

Public Class instructorinfofrm



    Public checklb As New ListBox
    Public forselectedcmboteach, forselectedrow As String

    Private Sub teachsaveCMD_Click(sender As Object, e As EventArgs) Handles teachsaveCMD.Click


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

           
            MessageBox.Show("Please comply all the necessary details.", "Incomplete details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf teachgenderCMBO.SelectedIndex = 0 Then
            MessageBox.Show("Please comply all the necessary details.", "Incomplete details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            teachgenderCMBO.BackColor = Color.DarkRed
        Else
            forinsertteachinfo()


            fordgvassignteach()

        End If

    End Sub

    Private Sub teachUpdateCMD_Click(sender As Object, e As EventArgs) Handles teachUpdateCMD.Click


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

            MessageBox.Show("Please comply all the necessary details.", "Incomplete details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf teachgenderCMBO.SelectedIndex = 0 Then
            MessageBox.Show("Please comply all the necessary details.", "Incomplete details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            teachgenderCMBO.BackColor = Color.DarkRed
        Else
            forupdatedteachinfo()

            teachsaveCMD.Enabled = True

            fordgvassignteach()
        End If

    End Sub

    Private Sub instructorinfofrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With teachgenderCMBO
            .Items.Add("")
            .Items.Add("Male")
            .Items.Add("Female")
            .SelectedIndex = 0
        End With

        With searchbyCMBO
            .Items.Add("")
            .Items.Add("ID Number")
            .Items.Add("First name")
            .Items.Add("Family name")
        End With

        forloadinserteachidnum()
        fordgvteachinfo()


        teachDeleteCMD.Enabled = True

    End Sub

    Private Sub teachDeleteCMD_Click(sender As Object, e As EventArgs) Handles teachDeleteCMD.Click
        Dim confirmdelete As DialogResult = MessageBox.Show("Are you sure you want to delete the teacher's information?", "Confirmation", MessageBoxButtons.YesNo, _
                                                            MessageBoxIcon.Question)
        If confirmdelete = Windows.Forms.DialogResult.Yes Then
            fordeleteteachinfo()

            fordgvassignteach()

        End If
    End Sub

    Private Sub closeCMD_Click(sender As Object, e As EventArgs) Handles closeCMD.Click
        Mainfrm.Enabled = True
        teachsaveCMD.Enabled = True
        teachDeleteCMD.Enabled = True
        For Each txtctrl As Control In Me.Controls
            If TypeOf txtctrl Is TextBox Then
                txtctrl.Text = Nothing
                txtctrl.BackColor = Color.White
            End If
        Next
        fordgvteachinfo()
        Me.searchbyCMBO.SelectedIndex = 0
        Me.Hide()
    End Sub

    Private Sub searchbyCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchbyCMBO.SelectedIndexChanged
        If searchbyCMBO.SelectedIndex = 0 Then
            forselectedcmboteach = ""
            fordgvteachinfo()
            searchbarTXT.Enabled = False
        ElseIf searchbyCMBO.SelectedIndex = 1 Then
            forselectedcmboteach = "teachIDNum"
            searchbarTXT.Enabled = True
        ElseIf searchbyCMBO.SelectedIndex = 2 Then
            forselectedcmboteach = "teachFname"
            searchbarTXT.Enabled = True
        ElseIf searchbyCMBO.SelectedIndex = 3 Then
            forselectedcmboteach = "teachFamname"
            searchbarTXT.Enabled = True
        End If
    End Sub

    Private Sub searchbarTXT_TextChanged(sender As Object, e As EventArgs) Handles searchbarTXT.TextChanged
        If searchbarTXT.Text.Length = 0 Then
            fordgvteachinfo()
        Else
            todisplayteachinfo()
        End If
    End Sub

    Private Sub displayinstructdgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles displayinstructdgv.CellClick
        teachsaveCMD.Enabled = False
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = displayinstructdgv.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from teacherinfotbl where teachIDNum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader
            Dim fordeleteteachacc As New Label
            dr.Read()
            fordeleteteachacc.Text = dr.Item("teachIDNum")

            Me.teachIDNumLBL.Text = dr.Item("teachIDNum")
            Me.teachFNameTXT.Text = dr.Item("teachFname")
            Me.teachMITXT.Text = dr.Item("teachMI")
            Me.teachFamNameTXT.Text = dr.Item("teachFamname")
            Me.teachgenderCMBO.Text = dr.Item("teachGender")
            Me.teachAddTXT.Text = dr.Item("teachAddress")
            Me.teachNameCodeTXT.Text = dr.Item("teachnamecode")
            dr.Close()



        Else

            teachsaveCMD.Enabled = False


            selectedrow = displayinstructdgv.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from teacherinfotbl where teachIDNum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader
            Dim fordeleteteachacc As New Label
            dr.Read()
            fordeleteteachacc.Text = dr.Item("teachIDNum")
            Me.teachIDNumLBL.Text = dr.Item("teachIDNum")
            Me.teachFNameTXT.Text = dr.Item("teachFname")
            Me.teachMITXT.Text = dr.Item("teachMI")
            Me.teachFamNameTXT.Text = dr.Item("teachFamname")
            Me.teachgenderCMBO.Text = dr.Item("teachGender")
            Me.teachAddTXT.Text = dr.Item("teachAddress")
            Me.teachNameCodeTXT.Text = dr.Item("teachnamecode")
            dr.Close()

        End If
    End Sub

    Private Sub displayinstructdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles displayinstructdgv.CellContentClick

    End Sub

    Private Sub refreshPB_Click(sender As Object, e As EventArgs) Handles refreshPB.Click
        forloadinserteachidnum()
        For Each txtctrl In Me.Controls
            If TypeOf txtctrl Is TextBox Then
                txtctrl.Text = Nothing
                txtctrl.BackColor = Color.White
            End If
        Next
        teachgenderCMBO.SelectedIndex = 0
        teachsaveCMD.Enabled = True
        teachDeleteCMD.Enabled = True
    End Sub

    Private Sub displayinstructdgv_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles displayinstructdgv.CellEnter
        teachsaveCMD.Enabled = False

        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = displayinstructdgv.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from teacherinfotbl where teachIDNum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader
            Do While dr.Read
                Me.teachIDNumLBL.Text = dr.Item("teachIDNum")
                Me.teachFNameTXT.Text = dr.Item("teachFname")
                Me.teachMITXT.Text = dr.Item("teachMI")
                Me.teachFamNameTXT.Text = dr.Item("teachFamname")
                Me.teachgenderCMBO.Text = dr.Item("teachGender")
                Me.teachAddTXT.Text = dr.Item("teachAddress")
                Me.teachNameCodeTXT.Text = dr.Item("teachnamecode")
            Loop
            dr.Close()

        Else

            teachsaveCMD.Enabled = False


            selectedrow = displayinstructdgv.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from teacherinfotbl where teachIDNum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader
            Do While dr.Read
                Me.teachIDNumLBL.Text = dr.Item("teachIDNum")
                Me.teachFNameTXT.Text = dr.Item("teachFname")
                Me.teachMITXT.Text = dr.Item("teachMI")
                Me.teachFamNameTXT.Text = dr.Item("teachFamname")
                Me.teachgenderCMBO.Text = dr.Item("teachGender")
                Me.teachAddTXT.Text = dr.Item("teachAddress")
                Me.teachNameCodeTXT.Text = dr.Item("teachnamecode")
            Loop
            dr.Close()
        End If
    End Sub

    
End Class