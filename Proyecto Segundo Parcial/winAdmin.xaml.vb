Imports MySql.Data.MySqlClient
Imports System.Data
Public Class winAdmin
    Dim cmbD As ComboBox = CB_Dignidades
    Dim op As Op_Administrador = New Op_Administrador
    Dim conex As New MySqlConnection("data source=localhost; user id=root; password=''; database=voto2016")
    Dim da As MySqlDataAdapter
    Dim ds As New DataSet
    Dim dc As New DataSet
    Private Presi As DataSet
    Private Parl As DataSet
    Private conPresi As DataSet

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim ventananPadre As winLogin
        ventananPadre = Me.Owner
        ventananPadre.Show()
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        CB_Dignidades.Items.Add("Presidente")
        CB_Dignidades.Items.Add("Parlamento Andino")
        CB_Dignidades.Items.Add("Asanbleista")
        llenarCand()




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

    Private Sub dgPres_Loaded(sender As Object, e As RoutedEventArgs) Handles dgPres.Loaded

        Using conex
            Console.WriteLine("Conexion exitosa")
            Dim consulta As String = "SELECT  nombre, apellido, votos FROM candidato WHERE dignidad ='presidente'"
            conex.Open()
            da = New MySqlDataAdapter(consulta, conex)
            Presi = New DataSet("candidato")

            da.Fill(Presi, "candidato")

            dgPres.DataContext = Presi
            dgPres.DisplayMemberPath = "candidato"




        End Using
    End Sub

    Private Sub btnListP_Click(sender As Object, e As RoutedEventArgs) Handles btnListP.Click
        Using conex
            Console.WriteLine("Conexion exitosa")
            Dim consulta As String = "SELECT  * FROM candidato WHERE dignidad ='presidente'"
            conex.Open()
            da = New MySqlDataAdapter(consulta, conex)
            conPresi = New DataSet("candidato")

            da.Fill(conPresi, "candidato")

            dglistar.DataContext = conPresi




        End Using
    End Sub
    Public Sub llenarCand()
        Using conex
            Dim consulta As String = "SELECT * FROM candidato WHERE nombre!= 'blanco' and nombre!= 'nulo'"
            conex.Open()
            da = New MySqlDataAdapter(consulta, conex)



            dc.Clear()
            da.Fill(ds, "candidato")


            Dim nombre As String
            Dim id As Integer



            For Each cand As DataRow In ds.Tables("candidato").Rows
                nombre = cand("nombre") & " " & cand("apellido")
                id = cand("id")
                cmbCandid.Items.Add(nombre)
            Next







        End Using
    End Sub

    Private Sub dgParan_Loaded(sender As Object, e As RoutedEventArgs) Handles dgParan.Loaded


        Using conex
            Console.WriteLine("Conexion exitosa")
            Dim consulta As String = "SELECT  nombre, apellido, votos FROM candidato WHERE dignidad LIKE '%andino%' "
            conex.Open()
            da = New MySqlDataAdapter(consulta, conex)
            Parl = New DataSet("candidatos")

            da.Fill(Parl, "candidatos")

            dgParan.DataContext = Parl
            dgParan.DisplayMemberPath = "candidatos"




        End Using

    End Sub

    Private Sub dgAsam_Loaded(sender As Object, e As RoutedEventArgs) Handles dgAsam.Loaded
        Using conex
            Console.WriteLine("Conexion exitosa")
            Dim consulta As String = "SELECT  nombre, apellido, votos FROM candidato WHERE dignidad ='Asambleista' "
            conex.Open()
            da = New MySqlDataAdapter(consulta, conex)
            Parl = New DataSet("candidatos")

            da.Fill(Parl, "candidatos")

            dgAsam.DataContext = Parl
            dgAsam.DisplayMemberPath = "candidatos"




        End Using
    End Sub

    Private Sub Window_Closing_1(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim ventananPadre As winLogin
        ventananPadre = Me.Owner
        ventananPadre.Show()
    End Sub

    Private Sub btnCerrarA_Click(sender As Object, e As RoutedEventArgs) Handles btnCerrarA.Click
        Dim ventananPadre As winLogin
        ventananPadre = Me.Owner
        ventananPadre.Show()
    End Sub

    Private Sub btnListA_Click(sender As Object, e As RoutedEventArgs) Handles btnListA.Click
        Using conex
            Console.WriteLine("Conexion exitosa")
            Dim consulta As String = "SELECT  * FROM candidato WHERE dignidad ='asambleista'"
            conex.Open()
            da = New MySqlDataAdapter(consulta, conex)
            conPresi = New DataSet("candidato")

            da.Fill(conPresi, "candidato")

            dglistar.DataContext = conPresi




        End Using
    End Sub

    Private Sub btnListPa_Click(sender As Object, e As RoutedEventArgs) Handles btnListPa.Click
        Using conex
            Console.WriteLine("Conexion exitosa")
            Dim consulta As String = "SELECT  * FROM candidato WHERE dignidad LIKE '%andino%' "
            conex.Open()
            da = New MySqlDataAdapter(consulta, conex)
            Parl = New DataSet("candidatos")

            da.Fill(Parl, "candidato")

            dglistar.DataContext = Parl
            dglistar.DisplayMemberPath = "candidato"




        End Using
    End Sub
End Class

