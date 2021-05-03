Public Class loginfrmSysAdmin

    
    Private Sub LogExitCMD_Click(sender As Object, e As EventArgs) Handles LogExitCMD.Click
        logusernametxt.Clear()
        logpasstxt.Clear()
        logusernametxt.Focus()
        selectLog.Show()
        Me.Hide()
    End Sub

    Private Sub LogSysAdminCMD_Click(sender As Object, e As EventArgs) Handles LogSysAdminCMD.Click
        forsysadminlogin()
        
    End Sub
End Class