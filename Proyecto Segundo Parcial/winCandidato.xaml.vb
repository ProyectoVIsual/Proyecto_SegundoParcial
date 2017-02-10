Public Class winCandidato
    Private Sub btnResul_Click(sender As Object, e As RoutedEventArgs) Handles btnResul.Click
        Dim wReportePersonal As New ReportePersonal
        wReportePersonal.Show()

    End Sub

    Private Sub btnListar_Click(sender As Object, e As RoutedEventArgs) Handles btnListar.Click
        Dim wReporteGeneral As New ReporteGeneral
        wReporteGeneral.Show()

    End Sub

    Private Sub btnCerrarC_Click(sender As Object, e As RoutedEventArgs) Handles btnCerrarC.Click
        Me.Close()

    End Sub
End Class
