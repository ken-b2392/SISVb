Imports System
Imports System.IO

Public Class addStudfrm
    Dim totrapint As Integer

    Public forcreatefolder As String = "StudentPics"
    Public clickedBrowse, clickedCapture As String
    Public pathbrowsedpic As String

    Private Sub addStudfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        forformLoadaddstudfrm()


        If Not Directory.Exists(forcreatefolder) Then
            Directory.CreateDirectory(forcreatefolder)
        End If

        backtoMainCMD.Visible = True
        nextPANEL.Visible = True
        clickedBrowse = "0"
        clickedCapture = "0"
    End Sub

    Private Sub backtoMainCMD_Click(sender As Object, e As EventArgs) Handles backtoMainCMD.Click
        forbackfromaddstudent()
    End Sub

    Private Sub previousPB_Click(sender As Object, e As EventArgs) Handles previousPB.Click

        If secPANEL.Visible = True Then
            previousPANEL.Show()
            firstPANEL.Visible = True

            secPANEL.Visible = False
            thirdPANEL.Visible = False
            If firstPANEL.Visible = True Then
                previousPANEL.Hide()
                With firstPANEL
                    .Visible = True
                    .Location = New Point(217, 145)
                    .Size = New Size(628, 285)
                End With
            End If
        ElseIf thirdPANEL.Visible = True Then
            thirdPANEL.Visible = False
            secPANEL.Visible = True
            firstPANEL.Visible = False
            previousPANEL.Show()


        End If
    End Sub

    Private Sub previousPB_MouseHover(sender As Object, e As EventArgs) Handles previousPB.MouseHover
        With previousPB
            .Size = New Size(50, 50)
            .Location = New Point((previousPANEL.Width / 2) - (previousPB.Width / 2), (previousPANEL.Height / 2) - (previousPB.Height / 2))
        End With



    End Sub

    Private Sub previousPB_MouseLeave(sender As Object, e As EventArgs) Handles previousPB.MouseLeave
        With previousPB
            .Size = New Size(47, 47)
            .Location = New Point((previousPANEL.Width / 2) - (previousPB.Width / 2), (previousPANEL.Height / 2) - (previousPB.Height / 2))
        End With
    End Sub

    Private Sub nextPB_Click(sender As Object, e As EventArgs) Handles nextPB.Click

        If firstPANEL.Visible = True Then

            firstPANEL.Visible = False

            With secPANEL
                .Visible = True
                .Location = New Point(217, 124)
                .Size = New Size(625, 302)
            End With

            previousPANEL.Show()

            thirdPANEL.Visible = False

            If QualiCMBO.SelectedIndex = 0 Then
                nextPANEL.Enabled = False
            Else
                nextPANEL.Enabled = True
            End If
            nextPANEL.Enabled = False


         



        ElseIf secPANEL.Visible = True Then
            firstPANEL.Visible = False
            secPANEL.Visible = False

            previousPANEL.Show()
            With thirdPANEL
                .Visible = True
                .Location = New Point(217, 155)
                .Size = New Size(628, 247)
            End With


            nextPANEL.Enabled = False



        ElseIf thirdPANEL.Visible = True Then

            


            secPANEL.Visible = False

            If MotherContactTXT.Text.Length = 0 Then
                nextPANEL.Enabled = False
            Else
                nextPANEL.Enabled = True
            End If

            Dim decidetosave As DialogResult = MessageBox.Show("Student information will be saved.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If decidetosave = DialogResult.Yes Then

                foraddstudent()

                firstPANEL.Visible = True

                With firstPANEL
                    .Visible = True
                    .Location = New Point(217, 145)
                    .Size = New Size(628, 285)
                End With

                semesterCMBO.Enabled = False
                statusStudGB.Enabled = False
                namestudGB.Enabled = False
                nextPANEL.Enabled = False

                With semesterCMBO
                    .SelectedIndex = 0
                End With

                With QualiCMBO
                    .SelectedIndex = 0
                End With

                With courseCMBO
                    .SelectedIndex = 0
                End With

                With yearCMBO
                    .SelectedIndex = 0
                    .Enabled = False
                End With

                With CivilStatCMBO
                    .SelectedIndex = 0
                End With

                SyFromTXT.Clear()
                SyToTXT.Clear()
                NewStudRB.Checked = False
                OldStudRB.Checked = False
                RetStudRB.Checked = False
                TransStudRB.Checked = False
                FamnameTXT.Clear()
                FnameTXT.Clear()
                MidnameTXT.Clear()


                ContactNoTXT.Clear()
                emailAddTXT.Clear()
                PlaceBirthTXT.Clear()
                PresentAddTXT.Clear()
                HomeAddTXT.Clear()

                fathernameTXT.Clear()
                fatherOccTXT.Clear()
                fatherContactTXT.Clear()
                MotherNameTXT.Clear()
                MotherOccTXT.Clear()
                MotherContactTXT.Clear()





                semesterCMBO.Enabled = False
                statusStudGB.Enabled = False
                namestudGB.Enabled = False
                nextPANEL.Enabled = False



                ContactNoTXT.Clear()
                ContactNoTXT.Enabled = False
                BdayDTP.Enabled = False
                'ageLBL.Text = "  "
                CivilStatCMBO.SelectedIndex = 0
                CivilStatCMBO.Enabled = False
                religionTXT.Clear()
                emailAddTXT.Clear()
                emailAddTXT.Enabled = False
                PlaceBirthTXT.Clear()
                PlaceBirthTXT.Enabled = False
                PresentAddTXT.Clear()
                PresentAddTXT.Enabled = False
                HomeAddTXT.Clear()
                HomeAddTXT.Enabled = False

                fathernameTXT.Enabled = True
                fatherContactTXT.Enabled = False
                fatherOccTXT.Enabled = False
                MotherNameTXT.Enabled = False
                MotherContactTXT.Enabled = False
                MotherOccTXT.Enabled = False


                thirdPANEL.Visible = False

                previousPANEL.Hide()

                studpicPB.Image = Image.FromFile(defaultpicpath)

            ElseIf decidetosave = DialogResult.No Then

            End If

            


        End If
    End Sub

    Private Sub nextPB_MouseHover(sender As Object, e As EventArgs) Handles nextPB.MouseHover
        With nextPB
            .Size = New Size(50, 50)
            .Location = New Point((nextPANEL.Width / 2) - (nextPB.Width / 2), (nextPANEL.Height / 2) - (nextPB.Height / 2))
        End With

    End Sub

    Private Sub nextPB_MouseLeave(sender As Object, e As EventArgs) Handles nextPB.MouseLeave
        With nextPB
            .Size = New Size(47, 47)
            .Location = New Point((nextPANEL.Width / 2) - (nextPB.Width / 2), (nextPANEL.Height / 2) - (nextPB.Height / 2))
        End With
    End Sub

    Private Sub SyFromTXT_TextChanged(sender As Object, e As EventArgs) Handles SyFromTXT.TextChanged
        SyFromTXT.Text = LTrim(SyFromTXT.Text)
        If Integer.TryParse(SyFromTXT.Text, totrapint) Then
        Else
            SyFromTXT.Clear()
        End If


        If SyFromTXT.Text.Trim.Length = 0 Then
            semesterCMBO.Enabled = False
            statusStudGB.Enabled = False
            namestudGB.Enabled = False
            SyToTXT.Clear()
        Else
            SyToTXT.Text = CInt(SyFromTXT.Text + 1)
            semesterCMBO.Focus()
        End If



       

    End Sub

    Private Sub SyFromTXT_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles SyFromTXT.Validating

        Dim today As System.DateTime = System.DateTime.Now

        Dim yearnow As Integer = today.Year

        If SyFromTXT.Text.Length = 0 Then

        ElseIf yearnow < SyFromTXT.Text Then
            MessageBox.Show("Invalid Year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SyToTXT.Clear()
            SyFromTXT.Clear()
            SyFromTXT.Focus()
        Else

        End If


        If SyFromTXT.Text.Length = 0 Then

            SyToTXT.Text.ToString()
        Else

            SyToTXT.Text = CInt(SyFromTXT.Text + 1)
            semesterCMBO.Focus()
        End If





    End Sub

    Private Sub SyToTXT_GotFocus(sender As Object, e As EventArgs) Handles SyToTXT.GotFocus

        SyToTXT.Text = LTrim(SyToTXT.Text)


        SyFromTXT.Text = LTrim(RTrim(SyFromTXT.Text))



        If SyFromTXT.Text.Length = 0 Then
            SyFromTXT.Focus()

        ElseIf SyToTXT.Text.Length = 0 Then

            semesterCMBO.Enabled = False
        Else
            semesterCMBO.Enabled = True
        End If
    End Sub

    Private Sub SyToTXT_TextChanged(sender As Object, e As EventArgs) Handles SyToTXT.TextChanged
        With SyToTXT
            .Text = LTrim(SyToTXT.Text)
            .MaxLength = 4
        End With

        SyFromTXT.Text = LTrim(RTrim(SyFromTXT.Text))

        If Integer.TryParse(SyToTXT.Text, totrapint) Then
            semesterCMBO.Enabled = True
        Else
            SyToTXT.Clear()
            semesterCMBO.Enabled = False
        End If

        'check if user entered a number. if not clear the textbox
        If Integer.TryParse(SyToTXT.Text, totrapint) Then
        Else
            SyToTXT.Clear()
            semesterCMBO.Enabled = False
        End If

        If SyFromTXT.Text.Length = 0 Then
            SyFromTXT.Focus()

        ElseIf SyToTXT.Text.Length = 0 Then

            semesterCMBO.Enabled = False
        ElseIf SyToTXT.Text.Length < 4 Then
            semesterCMBO.Enabled = False
        Else
            semesterCMBO.Enabled = True
        End If

    End Sub

    Private Sub semesterCMBO_GotFocus(sender As Object, e As EventArgs) Handles semesterCMBO.GotFocus
        SyToTXT.Text = LTrim(RTrim(SyToTXT.Text))
    End Sub

    Private Sub semesterCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles semesterCMBO.SelectedIndexChanged
        If semesterCMBO.SelectedIndex = 0 Then
            statusStudGB.Enabled = False
            namestudGB.Enabled = False

        Else
            statusStudGB.Enabled = True
        End If
    End Sub

    Private Sub NewStudRB_CheckedChanged(sender As Object, e As EventArgs) Handles NewStudRB.CheckedChanged
        namestudGB.Enabled = True

        FnameTXT.Enabled = True


    End Sub

    Private Sub QualiCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QualiCMBO.SelectedIndexChanged
        If QualiCMBO.SelectedIndex = 0 Then
            nextPANEL.Enabled = False
        Else
            nextPANEL.Enabled = True
        End If
    End Sub

    Private Sub OldStudRB_CheckedChanged(sender As Object, e As EventArgs) Handles OldStudRB.CheckedChanged
        namestudGB.Enabled = True

        FnameTXT.Enabled = True
    End Sub

    Private Sub TransStudRB_CheckedChanged(sender As Object, e As EventArgs) Handles TransStudRB.CheckedChanged
        namestudGB.Enabled = True

        FnameTXT.Enabled = True

    End Sub

    Private Sub RetStudRB_CheckedChanged(sender As Object, e As EventArgs) Handles RetStudRB.CheckedChanged
        namestudGB.Enabled = True

        FnameTXT.Enabled = True
        MidnameTXT.Enabled = False
        FamnameTXT.Enabled = False


    End Sub

    Private Sub FamnameTXT_GotFocus(sender As Object, e As EventArgs) Handles FamnameTXT.GotFocus
        MidnameTXT.Text = LTrim(RTrim(MidnameTXT.Text))
    End Sub

    Private Sub FamnameTXT_TextChanged(sender As Object, e As EventArgs) Handles FamnameTXT.TextChanged
        FamnameTXT.Text = LTrim(FamnameTXT.Text)
        If FamnameTXT.Text.Length <> 0 Then
            QualiCMBO.Enabled = True
        Else
            QualiCMBO.SelectedIndex = 0
            QualiCMBO.Enabled = False

        End If
    End Sub

    Private Sub FnameTXT_TextChanged(sender As Object, e As EventArgs) Handles FnameTXT.TextChanged
        FnameTXT.Text = LTrim(FnameTXT.Text)

        If FnameTXT.Text.Length <> 0 Then
            MidnameTXT.Enabled = True
        Else
            MidnameTXT.Enabled = False
            FamnameTXT.Enabled = False
            QualiCMBO.Enabled = False
            QualiCMBO.SelectedIndex = 0
        End If
    End Sub

    Private Sub MidnameTXT_GotFocus(sender As Object, e As EventArgs) Handles MidnameTXT.GotFocus
        FnameTXT.Text = LTrim(RTrim(FnameTXT.Text))
    End Sub

    Private Sub MidnameTXT_TextChanged(sender As Object, e As EventArgs) Handles MidnameTXT.TextChanged

        MidnameTXT.Text = LTrim(MidnameTXT.Text)
        If MidnameTXT.Text.Length <> 0 Then
            FamnameTXT.Enabled = True
        Else
            FamnameTXT.Enabled = False
            QualiCMBO.SelectedIndex = 0
            QualiCMBO.Enabled = False

        End If



    End Sub

    Private Sub courseCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles courseCMBO.SelectedIndexChanged
        If courseCMBO.SelectedIndex = 0 Then
            yearCMBO.Enabled = False
            ContactNoTXT.Enabled = False
            BdayDTP.Enabled = False
            CivilStatCMBO.Enabled = False
            religionTXT.Enabled = False
            emailAddTXT.Enabled = False
            PlaceBirthTXT.Enabled = False
            PresentAddTXT.Enabled = False
            HomeAddTXT.Enabled = False
        Else
            yearCMBO.Enabled = True
            ContactNoTXT.Enabled = False
            BdayDTP.Enabled = False
            CivilStatCMBO.Enabled = False
            religionTXT.Enabled = False
            emailAddTXT.Enabled = False
            PlaceBirthTXT.Enabled = False
            PresentAddTXT.Enabled = False
            HomeAddTXT.Enabled = False
        End If
    End Sub

    Private Sub yearCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles yearCMBO.SelectedIndexChanged
        If yearCMBO.SelectedIndex = 0 Then

            ContactNoTXT.Enabled = False
            BdayDTP.Enabled = False
            CivilStatCMBO.Enabled = False
            religionTXT.Enabled = False
            emailAddTXT.Enabled = False
            PlaceBirthTXT.Enabled = False
            PresentAddTXT.Enabled = False
            HomeAddTXT.Enabled = False
        Else

            ContactNoTXT.Enabled = True
            BdayDTP.Enabled = False
            CivilStatCMBO.Enabled = False
            religionTXT.Enabled = False
            emailAddTXT.Enabled = False
            PlaceBirthTXT.Enabled = False
            PresentAddTXT.Enabled = False
            HomeAddTXT.Enabled = False
        End If
    End Sub

    Private Sub ContactNoTXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ContactNoTXT.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsLower(e.KeyChar) Then
            e.Handled = True
        
        End If
    End Sub

    Private Sub ContactNoTXT_TextChanged(sender As Object, e As EventArgs) Handles ContactNoTXT.TextChanged
        ContactNoTXT.Text = LTrim(ContactNoTXT.Text)
        If ContactNoTXT.Text.Length = 0 Then

            BdayDTP.Enabled = False
            CivilStatCMBO.Enabled = False
            religionTXT.Enabled = False
            emailAddTXT.Enabled = False
            PlaceBirthTXT.Enabled = False
            PresentAddTXT.Enabled = False
            HomeAddTXT.Enabled = False



        Else

            BdayDTP.Enabled = True
            CivilStatCMBO.Enabled = False
            religionTXT.Enabled = False
            emailAddTXT.Enabled = False
            PlaceBirthTXT.Enabled = False
            PresentAddTXT.Enabled = False
            HomeAddTXT.Enabled = False
        End If
    End Sub

    Private Sub BdayDTP_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles BdayDTP.Validating
        Try
            Dim checkdate As String
            Dim today As System.DateTime = System.DateTime.Now
            checkdate = BdayDTP.Text

            Dim yearnow As Integer = today.Year

            Dim yeardtp As Integer = BdayDTP.Value.Year
            Dim rightyear As Integer = BdayDTP.Value.Year - 17
            Dim minimage As Integer = yeardtp - rightyear

            Dim forminimage As Integer = minimage
            Dim currentage As Integer = yearnow - yeardtp
            ageLBL.Text = currentage.ToString
            If currentage >= forminimage Then
                CivilStatCMBO.Enabled = True
                CivilStatCMBO.Focus()
            Else
                MessageBox.Show("Age should be 17 y/o and above.", "Date Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BdayDTP.Focus()
                CivilStatCMBO.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error on checking date. " & ex.Message)
        End Try

    End Sub

    Private Sub CivilStatCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CivilStatCMBO.SelectedIndexChanged
        If CivilStatCMBO.SelectedIndex = 0 Then
            religionTXT.Enabled = False
        Else
            religionTXT.Enabled = True
        End If
    End Sub


    


    Private Sub HomeAddTXT_TextChanged(sender As Object, e As EventArgs) Handles HomeAddTXT.TextChanged
        HomeAddTXT.Text = LTrim(HomeAddTXT.Text)
        If HomeAddTXT.Text.Length <> 0 Then
            nextPANEL.Enabled = True
        Else
            nextPANEL.Enabled = False
        End If
    End Sub

    Private Sub emailAddTXT_TextChanged(sender As Object, e As EventArgs) Handles emailAddTXT.TextChanged
        religionTXT.Text = LTrim(RTrim(religionTXT.Text))
        emailAddTXT.Text = LTrim(emailAddTXT.Text)
        If religionTXT.Text.Length = 0 Then
            PlaceBirthTXT.Enabled = False
        Else
            PlaceBirthTXT.Enabled = True
        End If
    End Sub

    Private Sub PlaceBirthTXT_TextChanged(sender As Object, e As EventArgs) Handles PlaceBirthTXT.TextChanged
        emailAddTXT.Text = LTrim(RTrim(emailAddTXT.Text))
        PlaceBirthTXT.Text = LTrim(PlaceBirthTXT.Text)
        If emailAddTXT.Text.Length = 0 Then
            PresentAddTXT.Enabled = False
        Else
            PresentAddTXT.Enabled = True
        End If
    End Sub

    Private Sub PresentAddTXT_TextChanged(sender As Object, e As EventArgs) Handles PresentAddTXT.TextChanged
        PlaceBirthTXT.Text = LTrim(RTrim(PlaceBirthTXT.Text))
        PresentAddTXT.Text = LTrim(PresentAddTXT.Text)
        If PlaceBirthTXT.Text.Length = 0 Then
            HomeAddTXT.Enabled = False
        Else
            HomeAddTXT.Enabled = True
        End If
    End Sub

    Private Sub fathernameTXT_TextChanged(sender As Object, e As EventArgs) Handles fathernameTXT.TextChanged
        fathernameTXT.Text = LTrim(fathernameTXT.Text)
        If fathernameTXT.Text.Length = 0 Then
            fatherOccTXT.Enabled = False
        Else
            fatherOccTXT.Enabled = True
        End If
    End Sub

    Private Sub fatherOccTXT_TextChanged(sender As Object, e As EventArgs) Handles fatherOccTXT.TextChanged
        fathernameTXT.Text = LTrim(RTrim(fathernameTXT.Text))
        fatherOccTXT.Text = LTrim(fatherOccTXT.Text)
        If fatherOccTXT.Text.Length = 0 Then
            fatherContactTXT.Enabled = False
        Else
            fatherContactTXT.Enabled = True
        End If
    End Sub

    Private Sub fatherContactTXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fatherContactTXT.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsLower(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub fatherContactTXT_TextChanged(sender As Object, e As EventArgs) Handles fatherContactTXT.TextChanged
        fatherOccTXT.Text = LTrim(RTrim(fatherOccTXT.Text))
        fatherContactTXT.Text = LTrim(fatherContactTXT.Text)
        If fatherContactTXT.Text.Length = 0 Then
            MotherNameTXT.Enabled = False
        Else
            MotherNameTXT.Enabled = True
        End If
    End Sub

    Private Sub MotherNameTXT_TextChanged(sender As Object, e As EventArgs) Handles MotherNameTXT.TextChanged
        fatherContactTXT.Text = LTrim(RTrim(fatherContactTXT.Text))
        MotherNameTXT.Text = LTrim(MotherNameTXT.Text)
        If MotherNameTXT.Text.Length = 0 Then
            MotherOccTXT.Enabled = False
        Else
            MotherOccTXT.Enabled = True
        End If
    End Sub

    Private Sub MotherOccTXT_TextChanged(sender As Object, e As EventArgs) Handles MotherOccTXT.TextChanged
        MotherNameTXT.Text = LTrim(RTrim(MotherNameTXT.Text))
        MotherOccTXT.Text = LTrim(MotherOccTXT.Text)
        If MotherOccTXT.Text.Length = 0 Then
            MotherContactTXT.Enabled = False
        Else
            MotherContactTXT.Enabled = True
        End If
    End Sub

    Private Sub MotherContactTXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MotherContactTXT.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsLower(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub MotherContactTXT_TextChanged(sender As Object, e As EventArgs) Handles MotherContactTXT.TextChanged
        MotherOccTXT.Text = LTrim(RTrim(MotherOccTXT.Text))
        MotherContactTXT.Text = LTrim(MotherContactTXT.Text)
        If MotherContactTXT.Text.Length = 0 Then
            nextPANEL.Enabled = False
        Else
            nextPANEL.Enabled = True
        End If
    End Sub

    Private Sub BrowsePicCMD_Click(sender As Object, e As EventArgs) Handles BrowsePicCMD.Click



        OpenFileDialog1.Title = "Browse for Student's Photo"
        OpenFileDialog1.Filter = "Image Files (*.PNG;*.BMP;*.JPG;*.JPEG;|*.PNG;*.BMP;*.JPG;*.JPEG;)"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            studpicPB.Image = Image.FromFile(OpenFileDialog1.FileName)

            pathbrowsedpic = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
            clickedBrowse = "1"
            clickedCapture = "0"

        End If





    End Sub

    Private Sub studGenderCMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studGenderCMBO.SelectedIndexChanged
        If studGenderCMBO.SelectedIndex = 0 Then
            courseCMBO.Enabled = False
        Else
            courseCMBO.Enabled = True
        End If
    End Sub

    Private Sub captureStudpicCMD_Click(sender As Object, e As EventArgs) Handles captureStudpicCMD.Click
        clickedBrowse = "0"
        clickedCapture = "1"

        Me.Enabled = False

        captureStudPicfrm.Show()

    End Sub

    Private Sub removephotoPB_Click(sender As Object, e As EventArgs) Handles removephotoPB.Click
        studpicPB.Image = Image.FromFile(defaultpicpath)
        clickedBrowse = "0"
        clickedCapture = "0"
    End Sub

    Private Sub backtoSearchStudCMD_Click(sender As Object, e As EventArgs)
        searchstudfrm.Enabled = True
        forbackfromaddstudent()
        nextPANEL.Visible = True
        Me.Hide()

    End Sub


 
    
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ReligionCMBO_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub religionTXT_TextChanged(sender As Object, e As EventArgs) Handles religionTXT.TextChanged
        religionTXT.Text = LTrim(religionTXT.Text)
        If religionTXT.Text.Length = 0 Then
            emailAddTXT.Enabled = False
        Else
            emailAddTXT.Enabled = True
        End If
    End Sub

   
    Private Sub BdayDTP_ValueChanged(sender As Object, e As EventArgs) Handles BdayDTP.ValueChanged
        CivilStatCMBO.Enabled = True
    End Sub
End Class