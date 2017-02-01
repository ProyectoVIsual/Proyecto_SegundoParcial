Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Data.SqlClient
Imports System.Data

Public Class InicioSession
    Dim conex As New MySqlConnection("data source=localhost; user id=root; password=''; database=voto2016")
    '"data source=localhost; user id=root; password=''; database=voto2016")
    '("data source=localhost;user id=root; password=''; database=animales")
    Dim da As MySqlDataAdapter
    Dim ds As New DataSet
    Dim sql, neensaje As String
    Dim sw As Boolean
    Dim comando As MySqlCommand
    Sub New()

    End Sub

    Public Function InicioSessionCandidato(ByVal user As String, ByVal pass As String) As String
        Try
            sw = False

            'conex.ConnectionString = "data source=localhost;user id=root; password=''; database=voto2016"
            sql = "SELECT * FROM candidato WHERE user='" & user & "' AND pass='" & pass & "'"
            conex.Open()


            da = New MySqlDataAdapter(sql, conex)
            ds.Clear()
            da.Fill(ds, "candidato")
            If (ds.Tables("candidato").Rows.Count() <> 0) Then
                'sw = True
                'Console.WriteLine("                                ")
                'Console.WriteLine("  INICIO DE SESION EXSITOSO             ")
                'Console.WriteLine("  BIENVENIDO    " + ds.Tables("candidato").Rows(0).Item("nombre"))
                'Console.WriteLine("                                ")



                neensaje = "EXITO"
            Else
                'Console.WriteLine(".... " + ds.Tables("usuario").Rows(0).Item("pass"))
                'Console.WriteLine(" Usuario y/o password no validos ")
                neensaje = "ERROR"
            End If

        Catch ex As Exception
            'Console.WriteLine("ERROR EXCRPTION CONEXCION")
            neensaje = "ERROR"
        End Try
        conex.Close()
        Return neensaje
    End Function

    Public Function InicioSessionAdmin(ByVal user As String, ByVal pass As String) As String

        Try
            sw = False

            'conex.ConnectionString = "data source=localhost;user id=root; password=''; database=voto2016"
            sql = "SELECT * FROM admin WHERE user='" & user & "' AND pass='" & pass & "'"
            conex.Open()


            da = New MySqlDataAdapter(sql, conex)
            ds.Clear()
            da.Fill(ds, "admin")
            If (ds.Tables("admin").Rows.Count() <> 0) Then
                'sw = True
                'Console.WriteLine("                                ")
                'Console.WriteLine("  INICIO DE SESION EXSITOSO             ")
                'Console.WriteLine("  BIENVENIDO    " + ds.Tables("admin").Rows(0).Item("nombre"))
                'Console.WriteLine("                                ")



                neensaje = "EXITO"
            Else
                'Console.WriteLine(".... " + ds.Tables("admin").Rows(0).Item("pass"))
                'Console.WriteLine(" Usuario y/o password no validos ")
                neensaje = "ERROR"
            End If

        Catch ex As Exception
            'Console.WriteLine("ERROR EXCRPTION CONEXCION")
            neensaje = "ERROR"
        End Try
        conex.Close()
        Return neensaje
    End Function
    Public Function InicioSessionvOTANTE(ByVal cedula As String) As String

        Try
            sw = False

            'conex.ConnectionString = "data source=localhost;user id=root; password=''; database=voto2016"
            sql = "SELECT * FROM votante WHERE cedula='" & cedula & "'"
            conex.Open()


            da = New MySqlDataAdapter(sql, conex)
            ds.Clear()
            da.Fill(ds, "votante")
            If (ds.Tables("votante").Rows.Count() <> 0) Then
                'sw = True
                'Console.WriteLine("                                ")
                'Console.WriteLine("  INICIO DE SESION EXSITOSO             ")
                'Console.WriteLine("  BIENVENIDO   VOTANTE ")
                'Console.WriteLine("                                ")



                neensaje = "EXITO"
            Else
                'Console.WriteLine(".... " + ds.Tables("admin").Rows(0).Item("pass"))
                ' Console.WriteLine(" Usuario y/o password no validos ")
                neensaje = "ERROR"
            End If

        Catch ex As Exception
            'Console.WriteLine("ERROR EXCRPTION CONEXCION")
            neensaje = "ERROR"
        End Try
        conex.Close()
        Return neensaje
    End Function

End Class