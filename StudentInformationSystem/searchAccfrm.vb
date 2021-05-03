Imports MySql.Data.MySqlClient
Public Class searchAccfrm

    Public searchbySchoolAdminAcc, forselectedrow As String

    Private Sub backCMD_Click(sender As Object, e As EventArgs) Handles backCMD.Click
        Mainfrm.Enabled = True
        Me.Hide()
    End Sub

    Private Sub searchAccfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With searchbyCMBO
            .Items.Add("")
            .Items.Add("Control Number")
            .Items.Add("Username")
            .SelectedIndex = 0
        End With
        forloadDGVSchoolAdminAcc()

    End Sub

    Private Sub refreshPB_Click(sender As Object, e As EventArgs) Handles refreshPB.Click
        Try
            forloadDGVSchoolAdminAcc()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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

    Private Sub clearPB_Click(sender As Object, e As EventArgs) Handles clearPB.Click
        searchBarTXT.Text = Nothing
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


    Private Sub searchbyCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchbyCMBO.SelectedIndexChanged
        If searchbyCMBO.SelectedIndex = 0 Then
            forloadDGVSchoolAdminAcc()
            searchBarTXT.Enabled = False
        ElseIf searchbyCMBO.SelectedIndex = 1 Then
            searchbySchoolAdminAcc = "controlnum"
            searchBarTXT.Enabled = True
        ElseIf searchbyCMBO.SelectedIndex = 2 Then
            searchbySchoolAdminAcc = "usern"
            searchBarTXT.Enabled = True
        End If
    End Sub

    Private Sub searchBarTXT_TextChanged(sender As Object, e As EventArgs) Handles searchBarTXT.TextChanged
        searchBarTXT.Text = LTrim(searchBarTXT.Text)
        If searchBarTXT.TextLength = 0 Then
            forloadDGVSchoolAdminAcc()
        End If

        forsearchSchoolAdminAcc()
    End Sub

    Private Sub schoolAdminAccDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles schoolAdminAccDGV.CellClick

        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = schoolAdminAccDGV.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from schooladminaccntstbl where controlnum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader
            Dim fordeleteacc As New Label
            dr.Read()
            fordeleteacc.Text = dr.Item("controlnum")
            dr.Close()



        Else

            selectedrow = schoolAdminAccDGV.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from schooladminaccntstbl where controlnum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)
            dr = cmd.ExecuteReader
            Dim fordeleteacc As New Label
            dr.Read()
            fordeleteacc.Text = dr.Item("controlnum")
            dr.Close()

        End If
    End Sub

    Private Sub deleteAccRecCMD_Click(sender As Object, e As EventArgs) Handles deleteAccRecCMD.Click

        Dim fordeleteSchoolAdminAcc As String = "delete from schooladminaccntstbl where controlnum = " & forselectedrow & "'"
        cmd = New MySqlCommand(fordeleteSchoolAdminAcc, con)

        Dim confirmdelete As DialogResult
        confirmdelete = MessageBox.Show("Are you sure you want to DELETE this Account?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirmdelete = Windows.Forms.DialogResult.Yes Then
            cmd.ExecuteNonQuery()
            MessageBox.Show("Account has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dr.Close()
            forloadDGVSchoolAdminAcc()
        End If

    End Sub





    Private Sub schoolAdminAccDGV_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles schoolAdminAccDGV.CellEnter

        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        If index < 0 Then
            index = e.RowIndex + 1
            selectedrow = schoolAdminAccDGV.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from schooladminaccntstbl where controlnum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)



        Else

            selectedrow = schoolAdminAccDGV.Rows(index)
            forselectedrow = selectedrow.Cells(0).Value.ToString()
            forsearch = "select * from schooladminaccntstbl where controlnum like '%" & forselectedrow & "%'"
            cmd = New MySqlCommand(forsearch, con)

        End If

    End Sub

    Private Sub printCMD_Click(sender As Object, e As EventArgs) Handles printCMD.Click
        Me.Enabled = False
        printaccountsfrm.Show()
    End Sub

   
    Private Sub updateaccCMD_Click(sender As Object, e As EventArgs) Handles updateaccCMD.Click

        updateschooladminaccfrm.Show()

        Dim searchtoupdateschooladacc As String = "select * from schooladminaccntstbl where controlnum = '" & forselectedrow & "'"
        cmd = New MySqlCommand(searchtoupdateschooladacc, con)
        dr = cmd.ExecuteReader
        While dr.Read
            updateschooladminaccfrm.scadcurUsernTXT.Text = dr.Item("usern")
            updateschooladminaccfrm.scsadcurrentpassTXT.Text = dr.Item("userpass")
        End While
        dr.Close()
        Me.Enabled = False

    End Sub
End Class