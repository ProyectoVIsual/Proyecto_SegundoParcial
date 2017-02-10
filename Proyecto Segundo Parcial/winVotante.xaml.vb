Imports MySql.Data.MySqlClient
Imports System.Data
Public Class winVotante

    Dim op As Op_Administrador = New Op_Administrador

    Dim conex As New MySqlConnection("data source=localhost; user id=root; password=''; database=voto2016")
    Dim da As MySqlDataAdapter
    Dim ds As New DataSet
    Dim listapres As ArrayList
    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim ventananPadre As winLogin
        ventananPadre = Me.Owner
        ventananPadre.Show()
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        llenarPres()
        llenarAsam()
        llenarParl()


    End Sub
    Public Sub llenarPres()
        Using conex
            Dim consulta As String = "SELECT id, nombre, apellido FROM candidato WHERE dignidad ='presidente' "
            conex.Open()
            da = New MySqlDataAdapter(consulta, conex)



            ds.Clear()
            da.Fill(ds, "candidato")


            listapres = New ArrayList
            Dim nombre As String
            Dim id As Integer



            For Each candi As DataRow In ds.Tables("candidato").Rows
                nombre = candi("nombre") & " " & candi("apellido")
                id = candi("id")
                cbPresis.Items.Add(nombre)
            Next







        End Using
    End Sub
    Public Sub llenarParl()
        Using conex
            Dim consulta As String = "SELECT id, nombre, apellido FROM candidato WHERE dignidad LIKE '%andino%' "
            conex.Open()
            da = New MySqlDataAdapter(consulta, conex)

            ds.Clear()
            da.Fill(ds, "candidato")


            listapres = New ArrayList
            Dim nombre As String
            Dim id As Integer



            For Each candi As DataRow In ds.Tables("candidato").Rows
                nombre = candi("nombre") & " " & candi("apellido")
                id = candi("id")
                cbParl.Items.Add(nombre)

            Next

        End Using
    End Sub
    Public Sub llenarAsam()
        Using conex
            Dim consulta As String = "SELECT id, nombre, apellido FROM candidato WHERE dignidad  ='Asambleista' "
            conex.Open()
            da = New MySqlDataAdapter(consulta, conex)

            ds.Clear()
            da.Fill(ds, "candidato")


            listapres = New ArrayList
            Dim nombre As String
            Dim id As Integer



            For Each candi As DataRow In ds.Tables("candidato").Rows
                nombre = candi("nombre") & " " & candi("apellido")
                id = candi("id")
                cbAsam.Items.Add(nombre)

            Next

        End Using
    End Sub

    Private Sub btnSufragar_Click(sender As Object, e As RoutedEventArgs) Handles btnSufragar.Click
        Dim idpres As String = cbPresis.SelectedItem.ToString
        Dim idpar As String = cbParl.SelectedItem.ToString
        Dim idasa As String = cbAsam.SelectedItem.ToString
        Using conex
            Dim consulta As String = "SELECT id FROM candidato WHERE nombre   ='""' "
            conex.Open()
            da = New MySqlDataAdapter(consulta, conex)

            ds.Clear()
            da.Fill(ds, "candidato")

        End Using
        ' Using conexion As New OleDbConnection(strConexion)
        ' Dim consulta As String = "Select * FROM lista;"
        ' Dim adapter As New OleDbDataAdapter(New OleDbCommand(consulta, conexion))
        '  listD = New DataSet("lista")
        '    adapter.Fill(listD, "lista")
        '  For Each candi As DataRow In listD.Tables("lista").Rows
        'If candi("NombreLista") = numero Then
        '   nombrelist = candi("Nombre Completo")
        '        End If
        '  Next
        ' End Using



    End Sub

    Private Sub btnCerrarV_Click(sender As Object, e As RoutedEventArgs) Handles btnCerrarV.Click
        Dim ventananPadre As winLogin
        ventananPadre = Me.Owner
        ventananPadre.Show()
    End Sub
End Class
