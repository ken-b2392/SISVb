Public Class printaccountsfrm

    Private Sub printaccountsfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With searchbyCMBO
            .Items.Add("Username")
            .Items.Add("Date Created")
            .SelectedIndex = 0
            .Focus()
        End With

    End Sub

    Private Sub searchbyCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchbyCMBO.SelectedIndexChanged
        If searchbyCMBO.SelectedIndex = 0 Then
            usernameTXT.Enabled = True
            datecreatedDTP.Enabled = False
        ElseIf searchbyCMBO.SelectedIndex = 1 Then
            usernameTXT.Clear()
            usernameTXT.Enabled = False
            datecreatedDTP.Enabled = True

        End If
    End Sub

    Private Sub searchprintCMD_Click(sender As Object, e As EventArgs) Handles searchprintCMD.Click

        If searchbyCMBO.SelectedIndex = 0 Then
            forAcccrysreptUSERNAME()
        ElseIf searchbyCMBO.SelectedIndex = 1 Then
            forAcccrysreptdatecreated()
        End If
    End Sub

    Private Sub backCMD_Click(sender As Object, e As EventArgs) Handles backCMD.Click
        searchbyCMBO.SelectedIndex = 0
        If searchbyCMBO.SelectedIndex = 0 Then
            forAcccrysreptUSERNAME()
            usernameTXT.Clear()
        ElseIf searchbyCMBO.SelectedIndex = 1 Then
            forAcccrysreptdatecreated()
            usernameTXT.Clear()
        End If

        searchAccfrm.Enabled = True
        searchAccfrm.Show()
        Me.Hide()

    End Sub
End Class