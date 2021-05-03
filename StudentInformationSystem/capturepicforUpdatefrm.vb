Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow

Imports System
Imports System.IO

Public Class capturepicforUpdatefrm
    Public CAMVID As VideoCaptureDevice
    Public bitmp As Bitmap
    Public camera As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

    Private Sub capturepicforUpdatefrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        captureStudpicCMD.Enabled = False
    End Sub

    Private Sub Captureprev(sender As Object, eventArgs As NewFrameEventArgs)

        bitmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        previewPB.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)


    End Sub

    Private Sub backtoAddstudfrm_Click(sender As Object, e As EventArgs) Handles backtoAddstudfrm.Click

        If previewPB.Image Is Nothing Then

        Else
            camera.VideoDevice.Stop()
            CAMVID.Stop()
        End If

        previewPB.Image = Nothing
        previewPB.Refresh()
        capturedPB.Image = Nothing
        capturedPB.Refresh()

        updateStudInfofrm.Enabled = True


        Me.Hide()

    End Sub

    Private Sub selectCamCMD_Click(sender As Object, e As EventArgs) Handles selectCamCMD.Click



        If previewPB.Image Is Nothing Then

            previewPB.Image = Nothing
            previewPB.Refresh()
            capturedPB.Image = Nothing
            capturedPB.Refresh()

            camera.ShowDialog()

            If camera.DialogResult = Windows.Forms.DialogResult.OK Then

                captureStudpicCMD.Enabled = True

                CAMVID = camera.VideoDevice



                AddHandler CAMVID.NewFrame, New NewFrameEventHandler(AddressOf Captureprev)
                camera.VideoDevice.Stop()
                CAMVID.Stop()
                CAMVID.Start()

            End If

        Else
            CAMVID.Stop()

            previewPB.Image = Nothing
            previewPB.Refresh()
            capturedPB.Image = Nothing
            capturedPB.Refresh()


            camera.ShowDialog()

            If camera.DialogResult = Windows.Forms.DialogResult.OK Then


                CAMVID = camera.VideoDevice

                AddHandler CAMVID.NewFrame, New NewFrameEventHandler(AddressOf Captureprev)
                camera.VideoDevice.Stop()
                CAMVID.Stop()
                CAMVID.Start()



            End If

        End If

    End Sub

    Private Sub refreshpbCMD_Click(sender As Object, e As EventArgs) Handles refreshpbCMD.Click
        previewPB.Image = Nothing
        previewPB.Refresh()
        capturedPB.Image = Nothing
        capturedPB.Refresh()
    End Sub


    Private Sub captureStudpicCMD_Click(sender As Object, e As EventArgs) Handles captureStudpicCMD.Click
        capturedPB.Image = previewPB.Image
        updateStudInfofrm.studpicPB.Image = capturedPB.Image
    End Sub


End Class