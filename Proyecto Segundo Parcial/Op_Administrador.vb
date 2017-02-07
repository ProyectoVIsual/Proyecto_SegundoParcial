Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Data.SqlTypes
Imports System.Data

Public Class Op_Administrador

    Dim conex As New MySqlConnection("data source=localhost; user id=root; password=''; database=voto2016")
    Dim da As MySqlDataAdapter
    Dim ds As New DataSet
    Dim sql, sqlUPDATE, neensaje As String
    Dim sw As Boolean
    Dim comando As MySqlCommand
    Sub New()

    End Sub

    Public Function EliminarCandidato(ByVal CedulaCandidato As Integer) As Boolean

        Try
            sw = True
            sql = "DELETE FROM candidato WHERE candidato.id = " & CedulaCandidato
            conex.Open()
            da = New MySqlDataAdapter(sql, conex)
            ds.Clear()
            da.Fill(ds, "candidato")


        Catch ex As Exception
            sw = False
            ' Console.WriteLine("ERROR DE CONEXCION")
            neensaje = "ERROR"
        End Try
        conex.Close()
        Return sw

    End Function

    Public Function AgregarCandidato(
        ByVal nombre As String,
        ByVal apellido As String,
        ByVal edad As Integer,
        ByVal cedula As Integer,
        ByVal lista As Integer,
        ByVal dignidad As String,
        ByVal usercand As String,
        ByVal passcand As String) As Boolean
        Try
            sw = True
            sql = "INSERT into candidato(nombre,apellido,edad,user,pass,lista,dignidad, votos,cedula) VALUES ('" & nombre &
                        "', '" & apellido & "', " & edad & ", '" & usercand & "', '" & passcand & "', '" & lista & "', 
                '" & dignidad & "', 0, '" & cedula & "')"
            conex.Open()


            da = New MySqlDataAdapter(sql, conex)
            ds.Clear()
            da.Fill(ds, "candidato")


        Catch ex As Exception
            sw = False
            'Console.WriteLine("ERROR EXCRPTION CONEXCION")
            neensaje = "ERROR"
        End Try
        conex.Close()
        Return sw
    End Function

    Public Sub ListarCandidatos()
        Try
            sw = False
            sql = "SELECT * FROM candidato"
            conex.Open()


            da = New MySqlDataAdapter(sql, conex)
            ds.Clear()
            da.Fill(ds, "candidato")
            'Console.WriteLine("                                ")
            'Console.WriteLine("     TODOS LOS CANDIDATOS INSCRITOS            ")
            For index = 0 To ds.Tables("candidato").Rows.Count()
                '   Console.WriteLine(" NOMBRES: " & ds.Tables("candidato").Rows(index).Item("nombre") & " " & ds.Tables("candidato").Rows(index).Item("apellido") & "| DIGNIDAD: " & ds.Tables("candidato").Rows(index).Item("dignidad"))
            Next
            ' Console.WriteLine("{0}. Regresar al Menú Principal", CInt(OpAdminResulCandidato.Out))
            'Console.WriteLine("                                ")
        Catch ex As Exception
            'Console.WriteLine("ERROR EXCRPTION CONEXCION")
            neensaje = "ERROR"
        End Try
        conex.Close()
    End Sub
    Public Sub VerResultados()
        Try
            sw = False
            sql = "SELECT * FROM candidato"
            conex.Open()


            da = New MySqlDataAdapter(sql, conex)
            ds.Clear()
            da.Fill(ds, "candidato")
            'Console.WriteLine("                                ")
            'Console.WriteLine("     TODOS LOS CANDIDATOS INSCRITOS            ")
            For index = 0 To ds.Tables("candidato").Rows.Count()
                '   Console.WriteLine(" NOMBRES: " & ds.Tables("candidato").Rows(index).Item("nombre") & " " & ds.Tables("candidato").Rows(index).Item("apellido") & " | DIGNIDAD: " & ds.Tables("candidato").Rows(index).Item("dignidad") & " | VOTOS: " & ds.Tables("candidato").Rows(index).Item("Votos"))
            Next

            'Console.WriteLine("                                ")
        Catch ex As Exception
            'Console.WriteLine("ERROR EXCRPTION CONEXCION")
            neensaje = "ERROR"
        End Try
        conex.Close()
    End Sub
    Public Function ActualizarCandidato()

        Return neensaje

    End Function
    Public Sub MenuParaVotante()
        Try
            sw = False
            sql = "SELECT * FROM candidato"
            conex.Open()


            da = New MySqlDataAdapter(sql, conex)
            ds.Clear()
            da.Fill(ds, "candidato")
            'Console.WriteLine("123. Regresar al Menú Principal", CInt(OpVotante.Out))
            'Console.WriteLine("                                ")
            'Console.WriteLine("     TODOS LOS CANDIDATOS INSCRITOS            ")

            For index = 0 To ds.Tables("candidato").Rows.Count()
                'Console.WriteLine("ID: " & ds.Tables("candidato").Rows(index).Item("id") & " " & ds.Tables("candidato").Rows(index).Item("nombre") & " " & ds.Tables("candidato").Rows(index).Item("apellido") & " | DIGNIDAD: " & ds.Tables("candidato").Rows(index).Item("dignidad") & ":", index + 1)
            Next


        Catch ex As Exception
            'Console.WriteLine("ERROR EXCRPTION CONEXCION")
            neensaje = "ERROR"
        End Try
        conex.Close()
    End Sub
    Public Function Votar(ByVal id As Integer) As Boolean
        Dim voto As Integer
        voto = 0
        Try


            sql = "SELECT * FROM candidato WHERE id=" & id
            conex.Open()
            da = New MySqlDataAdapter(sql, conex)
            ds.Clear()
            da.Fill(ds, "candidato")
            If (ds.Tables("candidato").Rows.Count() <> 0) Then
                sw = True

                'Console.WriteLine("" & id & " " & ds.Tables("candidato").Rows(0).Item("Votos"))
                'Console.WriteLine("" & ds.Tables("candidato").Rows(0).Item("nombre"))

                voto = ds.Tables("candidato").Rows(0).Item("Votos")
                conex.Close()
                voto = voto + 1

                sqlUPDATE = "UPDATE candidato SET Votos= '" & voto & "' WHERE id='" & id & "'"
                conex.Open()
                Dim Comand As MySqlCommand = New MySqlCommand(sqlUPDATE, conex)
                Comand.ExecuteNonQuery()

            Else
                sw = False
                'Console.WriteLine("NO EXISTE ESE CANDIDADTO ")
                'Console.WriteLine(" Usuario y/o password no validos ")

            End If

        Catch ex As MySqlException
            sw = False
        End Try
        conex.Close()
        Return sw
    End Function

End Class

