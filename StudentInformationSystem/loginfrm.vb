Public Class loginfrm

    
    Private Sub backCMD_Click(sender As Object, e As EventArgs) Handles backCMD.Click
        logusernametxt.Clear()
        logpasstxt.Clear()
        logusernametxt.Focus()
        selectLog.Show()
        Me.Hide()
    End Sub

    Private Sub LogSchoolAdminCMD_Click(sender As Object, e As EventArgs) Handles LogSchoolAdminCMD.Click
        
        forlogSchoolAdmin()

        
    End Sub
End Class