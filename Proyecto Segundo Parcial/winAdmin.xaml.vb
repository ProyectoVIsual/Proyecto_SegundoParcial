Public Class winAdmin
    Dim cmbD As ComboBox = CB_Dignidades
    Dim op As Op_Administrador = New Op_Administrador


    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim ventananPadre As winLogin
        ventananPadre = Me.Owner
        ventananPadre.Show()
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        CB_Dignidades.Items.Add("Presidente")
        CB_Dignidades.Items.Add("Vocal")
        CB_Dignidades.Items.Add("Asanbleista")
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As RoutedEventArgs) Handles btnagregar.Click
        Dim nombre As String = txt_NombreAdminagg.Text
        Dim pass As String = txt_ContrasenaAdminagg.Text
        Dim cedula As String = txt_CedulaAdminagg.Text
        Dim user As String = txt_UsuarioAdminagg.Text
        Dim apellido As String = txt_ApellidoAdminagg.Text
        Dim dignidad As String = CB_Dignidades.SelectionBoxItem
        Dim lista As Integer = txt_ListaAdminagg.Text
        Dim edad As String = txt_edadAdminagg.Text


        If op.AgregarCandidato(nombre, apellido, edad, cedula, lista, dignidad, user, pass).Equals("EXITO") Then
            MsgBox("Correcto")
        Else
            MsgBox("Incoreccto")
        End If
    End Sub
End Class
