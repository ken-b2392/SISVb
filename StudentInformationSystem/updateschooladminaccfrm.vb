Imports MySql.Data.MySqlClient
Public Class updateschooladminaccfrm

    Private Sub scadcurUsernTXT_TextChanged(sender As Object, e As EventArgs) Handles scadcurUsernTXT.TextChanged

    End Sub

    Private Sub updatescsAdCMD_Click(sender As Object, e As EventArgs) Handles updatescsAdCMD.Click
            

        Dim usernlist As New ListBox
        Dim forcheckacc As String = "select * from schooladminaccntstbl where usern = '" + scsadnewusernTXT.Text + "'"
        cmd = New MySqlCommand(forcheckacc, con)
        dr = cmd.ExecuteReader
        While dr.Read
            usernlist.Items.Add(dr.Item("usern"))
        End While
        dr.Close()

        If usernlist.Items.Contains(scsadnewusernTXT.Text) Then
            MessageBox.Show("The username has been already used.", "Username Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim fordateTODAY As System.DateTime = System.DateTime.Now
            Dim monthNOW, dayNOW, yearNOW, timeNOW, DToday As String
            monthNOW = fordateTODAY.Month
            dayNOW = fordateTODAY.Day
            yearNOW = fordateTODAY.Year
            timeNOW = Format(Now, "hh:mm:ss")

            DToday = monthNOW & "/" & dayNOW & "/" & yearNOW


            Dim forupdateSchoolAdminAcc As String = "UPDATE schooladminaccntstbl set usern = '" + scsadnewusernTXT.Text + "', userpass = '" + scsaddconfirmPassTXT.Text _
                                                    + "', datecreated = '" + DToday + "', timecreated = '" + timeNOW + "' where controlnum = '" & searchAccfrm.forselectedrow & "'"
            cmd = New MySqlCommand(forupdateSchoolAdminAcc, con)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Account " & scadcurUsernTXT.Text & " has been updated.", "Updated.", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim txtctrl As Control
            For Each txtctrl In Me.Controls
                If TypeOf txtctrl Is TextBox Then
                    txtctrl.Text = Nothing
                End If
            Next

            searchAccfrm.Enabled = True
            searchAccfrm.Show()
            Me.Hide()

            forloadDGVSchoolAdminAcc()

        End If
    End Sub

    Private Sub closeCMD_Click(sender As Object, e As EventArgs) Handles closeCMD.Click
        Dim txtctrl As Control
        For Each txtctrl In Me.Controls
            If TypeOf txtctrl Is TextBox Then
                txtctrl.Text = Nothing
            End If
        Next

        searchAccfrm.Enabled = True
        searchAccfrm.Show()
        Me.Hide()
    End Sub

    Private Sub scsaddconfirmPassTXT_TextChanged(sender As Object, e As EventArgs) Handles scsaddconfirmPassTXT.TextChanged
        If String.Equals(scsadnewPassTXT.Text, scsaddconfirmPassTXT.Text) = True Then
            checkpassPB.Visible = True
            incorrectPB.Visible = False
        Else
            checkpassPB.Visible = False
            incorrectPB.Visible = True
        End If
        If scsaddconfirmPassTXT.Text.Length = 0 Then
            checkpassPB.Visible = False
            incorrectPB.Visible = False
        End If
    End Sub

    Private Sub scsadnewusernTXT_TextChanged(sender As Object, e As EventArgs) Handles scsadnewusernTXT.TextChanged
        If scsadnewusernTXT.Text.Length = 0 Then
            scsadnewPassTXT.Clear()
            scsadnewPassTXT.Enabled = False
            scsaddconfirmPassTXT.Clear()
            scsaddconfirmPassTXT.Enabled = False
            incorrectPB.Visible = False
            checkpassPB.Visible = False
        Else
            scsadnewPassTXT.Enabled = True

        End If
    End Sub

    Private Sub scsadnewPassTXT_TextChanged(sender As Object, e As EventArgs) Handles scsadnewPassTXT.TextChanged
        If scsadnewPassTXT.Text.Length = 0 Then
            scsaddconfirmPassTXT.Clear()
            scsaddconfirmPassTXT.Enabled = False
            checkpassPB.Visible = False
            incorrectPB.Visible = False
        Else
            scsaddconfirmPassTXT.Enabled = True
        End If
        scsaddconfirmPassTXT.Clear()

    End Sub

    Private Sub updateschooladminaccfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkpassPB.Visible = False
        incorrectPB.Visible = False
        scsaddconfirmPassTXT.Enabled = False
        scsadnewPassTXT.Enabled = False

    End Sub
End Class