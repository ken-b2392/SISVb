Public Class backgroundfrm

    Private Sub backgroundfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub backgroundfrm_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover

        With selectLog
            .Show()
            .Focus()
        End With

        selectLog.Show()
        Me.Enabled = False
    End Sub
End Class