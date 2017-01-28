Class winLogin
    Dim SESSION As New InicioSession

    Private Sub btnVotante_Click(sender As Object, e As RoutedEventArgs) Handles btnVotante.Click
        Dim wVotante As New winVotante
        Dim votante As String

        votante = txtVotante.Text
        If SESSION.InicioSessionvOTANTE(votante) = "EXITO" Then
            wVotante.Show()
        Else
            MsgBox("Incoreccto")
        End If
    End Sub

    Private Sub btnLogC_Click(sender As Object, e As RoutedEventArgs) Handles btnLogC.Click
        Dim wCandidato As New winCandidato
        Dim user As String
        Dim pass As PasswordBox = txtPassC

        user = txtUserC.Text
        Dim pass1 As String = pass.Password

        If SESSION.InicioSessionCandidato(user, pass1) = "EXITO" Then
            wCandidato.Show()
        Else
            MsgBox("Incoreccto")
        End If
    End Sub

    Private Sub btnLogA_Click(sender As Object, e As RoutedEventArgs) Handles btnLogA.Click
        Dim wAdmin As New winAdmin
        Dim user As String
        Dim pass As PasswordBox = txtPassA

        user = txtUserA.Text
        Dim pass1 As String = pass.Password

        If SESSION.InicioSessionAdmin(user, pass1) = "EXITO" Then
            wAdmin.Show()
        Else
            MsgBox("Incoreccto")
        End If
    End Sub
End Class
