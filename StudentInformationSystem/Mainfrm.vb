Public Class Mainfrm

    
    Public ctrlnum, usern, userpas As New Label
    Private Sub Mainfrm_Click(sender As Object, e As EventArgs) Handles Me.Click
        If AboutPANEL.Height = 181 Then
            AboutPANEL.Height = 0

        End If

        If StudentPANEL.Height = 233 Then
            StudentPANEL.Height = 0

        End If

        If AccountPANEL.Height = 116 Then
            AccountPANEL.Height = 0
        End If

        If instructpanel.Height = 128 Then
            instructpanel.Height = 0
        End If

        If ManageAccPANEL.Height = 218 Then
            ManageAccPANEL.Height = 0
        End If



    End Sub

 

    Private Sub LogoutExitCMD_Click(sender As Object, e As EventArgs) Handles LogoutExitCMD.Click

        If String.Equals(ctrlnum, "1") Then
            forlogoutsysadmin()
            con.Close()
            End
        Else
            forlogout()
            con.Close()
            End
        End If




    End Sub

    Private Sub logoutCMD_Click(sender As Object, e As EventArgs) Handles logoutCMD.Click
        AccountPANEL.Height = 0
        forlogout()
        selectLog.Show()
        Me.Hide()
    End Sub

    Private Sub addstudsubtoolCMD_Click(sender As Object, e As EventArgs) Handles addstudsubtoolCMD.Click
        addStudfrm.Show()
        Me.Enabled = False
    End Sub



    Private Sub StudentToolCMD_MouseHover(sender As Object, e As EventArgs) Handles StudentToolCMD.MouseHover
        
        Try

            If StudentPANEL.Height = 0 Then
                StudentPANEL.Height = 233

            End If


            If AboutPANEL.Height = 181 Then
                AboutPANEL.Height = 0
            End If

            If AccountPANEL.Height = 116 Then
                AccountPANEL.Height = 0
            End If

            If instructpanel.Height = 128 Then
                instructpanel.Height = 0
            End If

            If ManageAccPANEL.Height = 218 Then
                ManageAccPANEL.Height = 0
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub AcctoolCMD_MouseHover(sender As Object, e As EventArgs) Handles AcctoolCMD.MouseHover
        Try
            If AccountPANEL.Height = 0 Then
                AccountPANEL.Height = 116


            End If

            If AboutPANEL.Height = 181 Then
                AboutPANEL.Height = 0
            End If

            If StudentPANEL.Height = 233 Then
                StudentPANEL.Height = 0

            End If

            If instructpanel.Height = 128 Then
                instructpanel.Height = 0
            End If

            If ManageAccPANEL.Height = 218 Then
                ManageAccPANEL.Height = 0
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AcctoolCMD_Click(sender As Object, e As EventArgs) Handles AcctoolCMD.Click

        Try
            If AccountPANEL.Height = 0 Then
                AccountPANEL.Height = 116
            Else
                AccountPANEL.Height = 0
            End If


            If AboutPANEL.Height = 181 Then
                AboutPANEL.Height = 0
            End If

            If StudentPANEL.Height = 233 Then
                StudentPANEL.Height = 0

            End If

            If instructpanel.Height = 128 Then
                instructpanel.Height = 0
            End If

            If ManageAccPANEL.Height = 218 Then
                ManageAccPANEL.Height = 0
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PrintToolCMD_Click(sender As Object, e As EventArgs) Handles PrintToolCMD.Click
        Try

            If StudentPANEL.Height = 233 Then
                StudentPANEL.Height = 0

            End If

            If AccountPANEL.Height = 116 Then
                AccountPANEL.Height = 0
            End If

            If instructpanel.Height = 128 Then
                instructpanel.Height = 0
            End If

            If ManageAccPANEL.Height = 233 Then
                ManageAccPANEL.Height = 0
            End If
            If AboutPANEL.Height = 181 Then
                AboutPANEL.Height = 0
            End If

                printstudrecordfrm.Show()
                loadsemester()
                Me.Enabled = False


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub manageToolCMD_Click(sender As Object, e As EventArgs) Handles manageToolCMD.Click

        Try
            If ManageAccPANEL.Height = 218 Then
                ManageAccPANEL.Height = 0
            Else
                ManageAccPANEL.Height = 218

            End If

            If AboutPANEL.Height = 181 Then
                AboutPANEL.Height = 0
            End If

            If StudentPANEL.Height = 233 Then
                StudentPANEL.Height = 0

            End If

            If AccountPANEL.Height = 116 Then
                AccountPANEL.Height = 0
            End If

            If instructpanel.Height = 128 Then
                instructpanel.Height = 0
            End If





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub AboutToolCMD_Click(sender As Object, e As EventArgs) Handles AboutToolCMD.Click
        Try
            
            If AboutPANEL.Height = 181 Then
                AboutPANEL.Height = 0
            Else
                AboutPANEL.Height = 181

            End If

            If StudentPANEL.Height = 233 Then
                StudentPANEL.Height = 0

            End If

            If AccountPANEL.Height = 116 Then
                AccountPANEL.Height = 0
            End If

            If instructpanel.Height = 128 Then
                instructpanel.Height = 0
            End If

            If ManageAccPANEL.Height = 218 Then
                ManageAccPANEL.Height = 0
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub StudentToolCMD_Click(sender As Object, e As EventArgs) Handles StudentToolCMD.Click
        Try
            If StudentPANEL.Height = 233 Then
                StudentPANEL.Height = 0
            Else
                StudentPANEL.Height = 233

            End If

            If AboutPANEL.Height = 181 Then
                AboutPANEL.Height = 0
            End If

            If AccountPANEL.Height = 116 Then
                AccountPANEL.Height = 0
            End If

            If instructpanel.Height = 128 Then
                instructpanel.Height = 0
            End If

            If ManageAccPANEL.Height = 218 Then
                ManageAccPANEL.Height = 0
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AboutToolCMD_MouseHover(sender As Object, e As EventArgs) Handles AboutToolCMD.MouseHover
        Try
            If AboutPANEL.Height = 0 Then
                AboutPANEL.Height = 181

            End If


            If StudentPANEL.Height = 233 Then
                StudentPANEL.Height = 0

            End If

            If AccountPANEL.Height = 116 Then
                AccountPANEL.Height = 0
            End If

            If instructpanel.Height = 128 Then
                instructpanel.Height = 0
            End If

            If ManageAccPANEL.Height = 218 Then
                ManageAccPANEL.Height = 0
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub manageToolCMD_MouseHover(sender As Object, e As EventArgs) Handles manageToolCMD.MouseHover
        Try
            
            If ManageAccPANEL.Height = 0 Then
                ManageAccPANEL.Height = 218
            End If

            If AboutPANEL.Height = 181 Then
                AboutPANEL.Height = 0
            End If

            If StudentPANEL.Height = 233 Then
                StudentPANEL.Height = 0

            End If

            If AccountPANEL.Height = 116 Then
                AccountPANEL.Height = 0
            End If

            If instructpanel.Height = 128 Then
                instructpanel.Height = 0
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PrintToolCMD_MouseHover(sender As Object, e As EventArgs) Handles PrintToolCMD.MouseHover
        Try
            If StudentPANEL.Height = 233 Then
                StudentPANEL.Height = 0
            End If

            If AccountPANEL.Height = 116 Then
                AccountPANEL.Height = 0
            End If

            If instructpanel.Height = 128 Then
                instructpanel.Height = 0
            End If

            If ManageAccPANEL.Height = 218 Then
                ManageAccPANEL.Height = 0
            End If
            If AboutPANEL.Height = 181 Then
                AboutPANEL.Height = 0
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub searchStudCMD_Click(sender As Object, e As EventArgs) Handles searchStudCMD.Click
        searchstudfrm.Show()
        Me.Enabled = False
    End Sub


    Private Sub registernewAccCMD_Click(sender As Object, e As EventArgs) Handles registernewAccCMD.Click
        registernewAccfrm.Show()
        Me.Enabled = False
    End Sub

    Private Sub searchAccCMD_Click(sender As Object, e As EventArgs) Handles searchAccCMD.Click
        searchAccfrm.Show()
        Me.Enabled = False
    End Sub

    Private Sub membersCMD_Click(sender As Object, e As EventArgs) Handles membersCMD.Click
        membersfrm.Show()
        Me.Enabled = False
    End Sub

    Private Sub aboutSISCMD_Click(sender As Object, e As EventArgs) Handles aboutSISCMD.Click
        aboutSISfrm.Show()
        Me.Enabled = False

    End Sub

   
    Private Sub updateSysAdCMD_Click(sender As Object, e As EventArgs) Handles updateSysAdCMD.Click
        sysAdminAccfrm.Show()
        Me.Enabled = False
    End Sub

    Private Sub Mainfrm_Load(sender As Object, e As EventArgs) Handles Me.Load
    

    End Sub


    Private Sub assignschedCMD_Click(sender As Object, e As EventArgs) Handles assignschedCMD.Click
        assignschedfrm.Show()
        Me.Enabled = False
    End Sub


    Private Sub instructorinfoCMD_Click(sender As Object, e As EventArgs) Handles instructorinfoCMD.Click
        instructorinfofrm.Show()
        Me.Enabled = False
    End Sub


   
    Private Sub assignsubjtoteachCMD_Click(sender As Object, e As EventArgs) Handles assignsubjtoteachCMD.Click
        assigninstructortosubjfrm.Show()
        Me.Enabled = False
    End Sub

   
    Private Sub subjectsCMD_Click(sender As Object, e As EventArgs) Handles subjectsCMD.Click

        If StudentPANEL.Height = 233 Then
            StudentPANEL.Height = 0

        End If

        If AccountPANEL.Height = 116 Then
            AccountPANEL.Height = 0
        End If

        If instructpanel.Height = 128 Then
            instructpanel.Height = 0
        End If

        If ManageAccPANEL.Height = 218 Then
            ManageAccPANEL.Height = 0
        End If
        If AboutPANEL.Height = 181 Then
            AboutPANEL.Height = 0
        End If

        addsubjectfrm.Show()
        Me.Enabled = False

    End Sub

    Private Sub instructortoolCMD_Click(sender As Object, e As EventArgs) Handles instructortoolCMD.Click

        If instructpanel.Height = 0 Then
            instructpanel.Height = 128
        Else
            instructpanel.Height = 0
        End If

        If AboutPANEL.Height = 181 Then
            AboutPANEL.Height = 0
        End If

        If StudentPANEL.Height = 233 Then
            StudentPANEL.Height = 0

        End If

        If AccountPANEL.Height = 116 Then
            AccountPANEL.Height = 0
        End If

        If ManageAccPANEL.Height = 218 Then
            ManageAccPANEL.Height = 0
        End If

    End Sub

    Private Sub instructortoolCMD_MouseHover(sender As Object, e As EventArgs) Handles instructortoolCMD.MouseHover

        If instructpanel.Height = 0 Then
            instructpanel.Height = 128
        End If


        If StudentPANEL.Height = 233 Then
            StudentPANEL.Height = 0

        End If

        If AccountPANEL.Height = 116 Then
            AccountPANEL.Height = 0
        End If

        If ManageAccPANEL.Height = 218 Then
            ManageAccPANEL.Height = 0
        End If

        If AboutPANEL.Height = 181 Then
            AboutPANEL.Height = 0
        End If
    End Sub

    Private Sub subjectsCMD_MouseHover(sender As Object, e As EventArgs) Handles subjectsCMD.MouseHover
        If StudentPANEL.Height = 233 Then
            StudentPANEL.Height = 0

        End If

        If AccountPANEL.Height = 116 Then
            AccountPANEL.Height = 0
        End If

        If instructpanel.Height = 128 Then
            instructpanel.Height = 0
        End If

        If ManageAccPANEL.Height = 218 Then
            ManageAccPANEL.Height = 0
        End If
        If AboutPANEL.Height = 181 Then
            AboutPANEL.Height = 0
        End If
    End Sub

    
    Private Sub logsCMD_Click(sender As Object, e As EventArgs) Handles logsCMD.Click
        logsfrm.Show()
        forlogscrysreptnouserid()
        Me.Enabled = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If AboutPANEL.Height = 181 Then
            AboutPANEL.Height = 0

        End If

        If StudentPANEL.Height = 233 Then
            StudentPANEL.Height = 0

        End If

        If AccountPANEL.Height = 116 Then
            AccountPANEL.Height = 0
        End If

        If instructpanel.Height = 128 Then
            instructpanel.Height = 0
        End If

        If ManageAccPANEL.Height = 218 Then
            ManageAccPANEL.Height = 0
        End If
    End Sub
End Class