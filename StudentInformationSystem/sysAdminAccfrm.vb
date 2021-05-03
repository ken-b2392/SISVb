Public Class sysAdminAccfrm

    Public pass As New Label
   
    Private Sub sysadcurrentpassTXT_TextChanged(sender As Object, e As EventArgs) Handles sysadcurrentpassTXT.TextChanged

        If sysadcurrentpassTXT.Text.Length = 0 Then
            incorrectPB.Visible = False
            checkpassPB.Visible = False
            sysadnewPassTXT.Clear()
            sysadnewPassTXT.Enabled = False
            sysaddconfirmPassTXT.Clear()
            sysaddconfirmPassTXT.Enabled = False
            sysadnewusernTXT.Clear()
            sysadnewusernTXT.Enabled = False
        Else
            If String.Equals(sysadcurrentpassTXT.Text, pass.Text) = True Then
                sysadnewusernTXT.Enabled = True
            Else
                sysadnewusernTXT.Enabled = False
            End If
        End If




    End Sub

    Private Sub sysAdminAccfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sysadnewPassTXT.Enabled = False
        sysaddconfirmPassTXT.Enabled = False
        incorrectPB.Visible = False
        checkpassPB.Visible = False
        updateSysAdCMD.Enabled = False
        sysadnewusernTXT.Enabled = False
    End Sub

    Private Sub backregAccCMD_Click(sender As Object, e As EventArgs) Handles backregAccCMD.Click
        Dim txtctrl As Control
        For Each txtctrl In Me.Controls
            If TypeOf txtctrl Is TextBox Then
                txtctrl.Text = Nothing
            End If
        Next
        Mainfrm.Enabled = True
        Me.Hide()
    End Sub

   
   
    Private Sub sysadnewPassTXT_TextChanged(sender As Object, e As EventArgs) Handles sysadnewPassTXT.TextChanged
        If sysadnewPassTXT.Text.Length = 0 Then
            sysaddconfirmPassTXT.Clear()
            sysaddconfirmPassTXT.Enabled = False
        Else
            sysaddconfirmPassTXT.Enabled = True
        End If
    End Sub

    Private Sub sysaddconfirmPassTXT_TextChanged(sender As Object, e As EventArgs) Handles sysaddconfirmPassTXT.TextChanged
        If sysaddconfirmPassTXT.Text.Length = 0 Then
            incorrectPB.Visible = False
            checkpassPB.Visible = False
            updateSysAdCMD.Enabled = False
        ElseIf sysaddconfirmPassTXT.Text.Equals(sysadnewPassTXT.Text) Then
            incorrectPB.Visible = False
            checkpassPB.Visible = True
            updateSysAdCMD.Enabled = True
        Else
            incorrectPB.Visible = True
            updateSysAdCMD.Enabled = False
            checkpassPB.Visible = False
        End If
    End Sub

    Private Sub updateSysAdCMD_Click(sender As Object, e As EventArgs) Handles updateSysAdCMD.Click
        forupdatesystemadminusernamepassword()
        sysadnewPassTXT.Enabled = False
        sysaddconfirmPassTXT.Enabled = False
        incorrectPB.Visible = False
        checkpassPB.Visible = False
        updateSysAdCMD.Enabled = False
        sysadnewusernTXT.Enabled = False

    End Sub

    Private Sub sysadnewusernTXT_TextChanged(sender As Object, e As EventArgs) Handles sysadnewusernTXT.TextChanged
        If sysadnewusernTXT.Text.Length = 0 Then
            sysadnewPassTXT.Enabled = False
        Else
            sysadnewPassTXT.Enabled = True
        End If
    End Sub

    Private Sub clearAccCMD_Click(sender As Object, e As EventArgs) Handles clearAccCMD.Click
        Dim txtctrl As Control
        For Each txtctrl In Me.Controls
            If TypeOf txtctrl Is TextBox Then
                txtctrl.Text = Nothing
            End If
        Next
    End Sub

    Private Sub sysadcurUsernTXT_TextChanged(sender As Object, e As EventArgs) Handles sysadcurUsernTXT.TextChanged
        forconfirmcurrentsystemadpassword()
    End Sub
End Class