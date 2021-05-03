

Public Class selectLog



    Private Sub SelLogExitCMD_Click(sender As Object, e As EventArgs) Handles SelLogExitCMD.Click
        con.Close()
        End
    End Sub

    Private Sub selectLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        


       
        connectDB()



        

        With schooladminPB
            .Size = New Size(233, 233)
            .Location = New Point((Panel1.Width / 2) - (schooladminPB.Width / 2), (Panel1.Height / 2) - (schooladminPB.Height / 2))
        End With

        With sysadminPB
            .Size = New Size(233, 233)
            .Location = New Point((Panel2.Width / 2) - (sysadminPB.Width / 2), (Panel2.Height / 2) - (sysadminPB.Height / 2))
        End With

    End Sub

    Private Sub schooladminPB_Click(sender As Object, e As EventArgs) Handles schooladminPB.Click
        With Mainfrm
            .Show()
            .manageToolCMD.Enabled = False
            .Hide()
        End With

        With loginfrm
            .Show()
        End With
        Me.Hide()
    End Sub

    Private Sub schooladminPB_MouseHover(sender As Object, e As EventArgs) Handles schooladminPB.MouseHover
        With schooladminPB
            .Size = New Size(225, 225)
            .Location = New Point((Panel1.Width / 2) - (schooladminPB.Width / 2), (Panel1.Height / 2) - (schooladminPB.Height / 2))
        End With
    End Sub

    Private Sub schooladminPB_MouseLeave(sender As Object, e As EventArgs) Handles schooladminPB.MouseLeave
        With schooladminPB
            .Size = New Size(233, 233)
            .Location = New Point((Panel1.Width / 2) - (schooladminPB.Width / 2), (Panel1.Height / 2) - (schooladminPB.Height / 2))
        End With
    End Sub

    Private Sub sysadminPB_Click(sender As Object, e As EventArgs) Handles sysadminPB.Click
        With Mainfrm
            .Show()
            .manageToolCMD.Enabled = True
            .Hide()
        End With

        With loginfrmSysAdmin
            .Show()
        End With
        Me.Hide()
    End Sub

    Private Sub sysadminPB_MouseHover(sender As Object, e As EventArgs) Handles sysadminPB.MouseHover
        With sysadminPB
            .Size = New Size(225, 225)
            .Location = New Point((Panel2.Width / 2) - (sysadminPB.Width / 2), (Panel2.Height / 2) - (sysadminPB.Height / 2))
        End With
    End Sub

    Private Sub sysadminPB_MouseLeave(sender As Object, e As EventArgs) Handles sysadminPB.MouseLeave
        With sysadminPB
            .Size = New Size(233, 233)
            .Location = New Point((Panel2.Width / 2) - (sysadminPB.Width / 2), (Panel2.Height / 2) - (sysadminPB.Height / 2))
        End With
    End Sub
End Class
