Public Class Administrador
    Inherits Persona
    Private usuarioAdministrador As String
    Public Property Usuario_ADMIN() As String
        Get
            Return usuarioAdministrador
        End Get
        Set(ByVal value As String)
            usuarioAdministrador = value
        End Set
    End Property

    Private passwordAdmin As String
    Public Property Password_ADMIN() As String
        Get
            Return passwordAdmin
        End Get
        Set(ByVal value As String)
            passwordAdmin = value
        End Set
    End Property


    Sub New()
        Me.Nombre = "Desconocido"
        Me.Apellido = "Desconocido"
        Me.Cedula = "Desconocido"
        Me.edad = 0
        Me.usuarioAdministrador = "Desconocido"
        Me.Password_ADMIN = "Desconocido"
    End Sub

    Sub New(ByVal nombre As String, ByVal apellido As String, ByVal cedula As String, ByVal edadPersona As Byte, ByVal user As String, ByVal pass As String)
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Cedula = cedula
        Me.edad = edadPersona
        Me.usuarioAdministrador = user
        Me.Password_ADMIN = pass
    End Sub
End Class
