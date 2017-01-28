Public Class Persona
    Private nombrePersona As String
    Public Property Nombre() As String
        Get
            Return nombrePersona
        End Get
        Set(ByVal value As String)
            nombrePersona = value
        End Set
    End Property
    Private apellidoPersona As String

    Public Property Apellido() As String
        Get
            Return apellidoPersona
        End Get
        Set(ByVal value As String)
            apellidoPersona = value
        End Set
    End Property

    Private cedulaPersona As String

    Public Property Cedula() As String
        Get
            Return cedulaPersona
        End Get
        Set(ByVal value As String)
            cedulaPersona = value
        End Set
    End Property

    Private edadPersona As Byte
    Public Property edad() As Byte
        Get
            Return edadPersona
        End Get
        Set(ByVal value As Byte)
            edadPersona = value
        End Set
    End Property
End Class
