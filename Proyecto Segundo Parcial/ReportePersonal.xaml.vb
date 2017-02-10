Imports System.Data
Imports MySql.Data.MySqlClient

Public Class ReportePersonal
    Dim op As Op_Administrador = New Op_Administrador

    Dim conex As New MySqlConnection("data source=localhost; user id=root; password=''; database=voto2016")
    Dim da As MySqlDataAdapter
    Dim ds As New DataSet
    Dim listapres As ArrayList

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        llenarDatos()


    End Sub
    Public Sub llenarDatos()
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

            Next


        End Using
    End Sub



    Private Sub btnCerrarReporte_Click(sender As Object, e As RoutedEventArgs) Handles btnCerrarReporte.Click
        Me.Close()

    End Sub
End Class
