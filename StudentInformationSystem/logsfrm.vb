Public Class logsfrm
    Public forselectedsearchinlogs As New Label
    Private Sub logsfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With searchbyCMBO

            .Items.Add("ID Number")
            .Items.Add("Username")
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub searchbyCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchbyCMBO.SelectedIndexChanged
        If searchbyCMBO.SelectedIndex = 0 Then
            forselectedsearchinlogs.Text = "controlnum"

        ElseIf searchbyCMBO.SelectedIndex = 1 Then
            forselectedsearchinlogs.Text = "username"

        End If
    End Sub

    Private Sub searchprintCMD_Click(sender As Object, e As EventArgs) Handles searchprintCMD.Click
        forlogscrysreptnouserid()
    End Sub

    Private Sub backCMD_Click(sender As Object, e As EventArgs) Handles backCMD.Click
        searchbyCMBO.SelectedIndex = 0
        forlogscrysreptnouserid()
        Me.Hide()
        Mainfrm.Enabled = True
    End Sub

    
End Class