Public Class winVotante
    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim ventananPadre As winLogin
        ventananPadre = Me.Owner
        ventananPadre.Show()
    End Sub
End Class
