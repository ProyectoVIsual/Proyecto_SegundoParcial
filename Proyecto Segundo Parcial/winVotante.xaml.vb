Imports MySql.Data.MySqlClient
Imports System.Data
Public Class winVotante

    Dim op As Op_Administrador = New Op_Administrador
    Dim listaparlamento As New ArrayList

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
                nombre = candi("nombre")
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
                nombre = candi("nombre")
                id = candi("id")
                Dim candida As New Candidato(candi("nombre"), candi("apellido"), candi("id"))
                listaparlamento.Add(candida)
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
                nombre = candi("nombre")
                id = candi("id")
                cbAsam.Items.Add(nombre)

            Next

        End Using
    End Sub

    Private Sub btnSufragar_Click(sender As Object, e As RoutedEventArgs) Handles btnSufragar.Click

        Dim idasa As String = cbAsam.SelectedItem.ToString
        Using conex
            Dim consulta As String = "SELECT id , Votos FROM candidato WHERE nombre   ='" & cbAsam.SelectedItem.ToString & "'"
            conex.Open()
            da = New MySqlDataAdapter(consulta, conex)

            ds.Clear()
            da.Fill(ds, "candidato")
            If (ds.Tables("candidato").Rows.Count() <> 0) Then
                Dim voto As Integer = ds.Tables("candidato").Rows(0).Item("Votos")
                conex.Close()
                voto = voto + 1
                Dim sqlUPDATE As String = "UPDATE candidato SET Votos= " & voto & " WHERE nombre='" & cbAsam.SelectedItem.ToString & "'"
                conex.Open()
                Dim Comand As MySqlCommand = New MySqlCommand(sqlUPDATE, conex)
                Comand.ExecuteNonQuery()
                MsgBox("EXITO VOTO PARA EL CANDIDATO: " & cbAsam.SelectedItem.ToString)
            Else
                MsgBox("NO hay candidato" & cbAsam.SelectedItem.ToString)
            End If
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

    Private Sub btnSufragar_PA_Click(sender As Object, e As RoutedEventArgs) Handles btnSufragar_PA.Click
        Dim idasa As String = cbParl.SelectedItem.ToString
        Using conex
            Dim consulta As String = "SELECT id , Votos FROM candidato WHERE nombre   ='" & cbParl.SelectedItem.ToString & "'"
            conex.Open()
            da = New MySqlDataAdapter(consulta, conex)

            ds.Clear()
            da.Fill(ds, "candidato")
            If (ds.Tables("candidato").Rows.Count() <> 0) Then
                Dim voto As Integer = ds.Tables("candidato").Rows(0).Item("Votos")
                conex.Close()
                voto = voto + 1
                Dim sqlUPDATE As String = "UPDATE candidato SET Votos= " & voto & " WHERE nombre='" & cbParl.SelectedItem.ToString & "'"
                conex.Open()
                Dim Comand As MySqlCommand = New MySqlCommand(sqlUPDATE, conex)
                Comand.ExecuteNonQuery()
                MsgBox("EXITO VOTO PARA EL CANDIDATO: " & cbParl.SelectedItem.ToString)
            Else
                MsgBox("NO hay candidato" & cbParl.SelectedItem.ToString)
            End If
        End Using
    End Sub

    Private Sub btnSufragar_P_Click(sender As Object, e As RoutedEventArgs) Handles btnSufragar_P.Click
        Dim idasa As String = cbPresis.SelectedItem.ToString
        Using conex
            Dim consulta As String = "SELECT id , Votos FROM candidato WHERE nombre   ='" & cbPresis.SelectedItem.ToString & "'"
            conex.Open()
            da = New MySqlDataAdapter(consulta, conex)

            ds.Clear()
            da.Fill(ds, "candidato")
            If (ds.Tables("candidato").Rows.Count() <> 0) Then
                Dim voto As Integer = ds.Tables("candidato").Rows(0).Item("Votos")
                conex.Close()
                voto = voto + 1
                Dim sqlUPDATE As String = "UPDATE candidato SET Votos= " & voto & " WHERE nombre='" & cbPresis.SelectedItem.ToString & "'"
                conex.Open()
                Dim Comand As MySqlCommand = New MySqlCommand(sqlUPDATE, conex)
                Comand.ExecuteNonQuery()
                MsgBox("EXITO VOTO PARA EL CANDIDATO: " & cbPresis.SelectedItem.ToString)
            Else
                MsgBox("NO hay candidato" & cbPresis.SelectedItem.ToString)
            End If
        End Using
    End Sub
End Class
