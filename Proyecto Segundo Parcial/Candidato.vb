Public Class Candidato
    Inherits Persona
    Private _usuarioCandidato As String
    Public Property Usuario_ADMIN() As String
        Get
            Return _usuarioCandidato
        End Get
        Set(ByVal value As String)
            _usuarioCandidato = value
        End Set
    End Property

    Private _passwordCandidato As String
    Public Property Password_ADMIN() As String
        Get
            Return _passwordCandidato
        End Get
        Set(ByVal value As String)
            _passwordCandidato = value
        End Set
    End Property
    Private _dignidad As String
    Public Property Dignidad() As String
        Get
            Return _dignidad
        End Get
        Set(ByVal value As String)
            _dignidad = value
        End Set
    End Property
    Private _partido As String
    Public Property Partido() As String
        Get
            Return _partido
        End Get
        Set(ByVal value As String)
            _partido = value
        End Set
    End Property
    Private _votos As Integer
    Public Property Votos() As Integer
        Get
            Return _votos
        End Get
        Set(ByVal value As Integer)
            _votos = value
        End Set
    End Property


    Sub New()
        Me.Nombre = "Desconocido"
        Me.Apellido = "Desconocido"
        Me.Cedula = "Desconocido"
        Me.edad = 0
        Me._usuarioCandidato = "Desconocido"
        Me._passwordCandidato = "Desconocido"
        Me._dignidad = "Desconocido"
        Me._partido = "Desconocido"
        Me._votos = 0
    End Sub

    Sub New(ByVal nombre As String, ByVal apellido As String, ByVal cedula As String, ByVal edadPersona As Byte, ByVal user As String, ByVal pass As String, ByVal dig As String, ByVal part As String)
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Cedula = cedula
        Me.edad = edadPersona
        Me._usuarioCandidato = user
        Me._passwordCandidato = pass
        Me._dignidad = dig
        Me._partido = part
        Me._votos = 0
    End Sub
End Class
