﻿Imports System.Data
Imports MySql.Data.MySqlClient

Public Class ReporteGeneral
    Dim op As Op_Administrador = New Op_Administrador
    Dim conex As New MySqlConnection("data source=localhost; user id=root; password=''; database=voto2016")
    Dim da As MySqlDataAdapter
    Dim ds As New DataSet
    Dim dc As New DataSet
    Private Presi As DataSet
    Private Parl As DataSet
    Private conPresi As DataSet
    Dim id As Integer

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim ventananPadre As winLogin
        ventananPadre = Me.Owner
        ventananPadre.Show()
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)


        llenarCand()




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


    Public Sub llenarCand()
        'Using conex
        '    Dim consulta As String = "SELECT * FROM candidato WHERE nombre!= 'blanco' and nombre!= 'nulo'"
        '    conex.Open()
        '    da = New MySqlDataAdapter(consulta, conex)
        '    dc.Clear()
        '    da.Fill(ds, "candidato")


        '    Dim nombre As String

        '    For Each cand As DataRow In ds.Tables("candidato").Rows
        '        nombre = cand("nombre")
        '        id = cand("id")
        '        cmbCandid.Items.Add(nombre)
        '    Next







        'End Using
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


    Private Sub btnCerrarReporteG_Click(sender As Object, e As RoutedEventArgs) Handles btnCerrarReporteG.Click
        Me.Close()

    End Sub


End Class
