Public Class registernewAccfrm

   
    Private Sub registernewAccfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        forloadcontrolnum()

        reguserTXT.Clear()
        regpassTXT.Clear()
        regconfirmpassTXT.Clear()
        checkpassPB.Visible = False
        incorrectPB.Visible = False

    End Sub

    Private Sub regconfirmpassTXT_TextChanged(sender As Object, e As EventArgs) Handles regconfirmpassTXT.TextChanged
        If regpassTXT.Text.Length = 0 Then
            checkpassPB.Visible = False
            incorrectPB.Visible = False
        ElseIf regconfirmpassTXT.Text.Length = 0 Then
            checkpassPB.Visible = False
            incorrectPB.Visible = False
            'String.Compare(regpassTXT.Text, regconfirmpassTXT.Text, StringComparison.InvariantCultureIgnoreCase) = 0 Then
        ElseIf regpassTXT.Text.Equals(regconfirmpassTXT.Text) Then
            checkpassPB.Visible = True
            incorrectPB.Visible = False
        Else
            incorrectPB.Visible = True
            checkpassPB.Visible = False
        End If
    End Sub

    Private Sub regAccCMD_Click(sender As Object, e As EventArgs) Handles regAccCMD.Click

        If regpassTXT.Text.Equals(regconfirmpassTXT.Text) Then
            If ConnectionState.Closed Then
                con.Open()
            End If

            forRegisterSchoolAdminAcc()
            controlnumLBL.Text = ""
            forloadcontrolnum()
        Else
            MessageBox.Show("Make sure that the password and confirmation password is correct.", "Check password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub backregAccCMD_Click(sender As Object, e As EventArgs) Handles backregAccCMD.Click
        Mainfrm.Enabled = True
        Me.Hide()
    End Sub

    Private Sub clearAccCMD_Click(sender As Object, e As EventArgs) Handles clearAccCMD.Click
        reguserTXT.Clear()
        regpassTXT.Clear()
        regconfirmpassTXT.Clear()
    End Sub

    Private Sub regpassTXT_TextChanged(sender As Object, e As EventArgs) Handles regpassTXT.TextChanged
        If regpassTXT.Text.Length = 0 Then
            regconfirmpassTXT.Clear()
            regconfirmpassTXT.Enabled = False
        Else
            regconfirmpassTXT.Enabled = True
        End If
    End Sub
End Class