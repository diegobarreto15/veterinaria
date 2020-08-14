Public Class persona
    Private _nombre As String
    Private _ci As Integer
    Private _telefono As List(Of Integer)
    Private _direccion As String

    Public Sub persona()

    End Sub

    Public Sub persona(nombre_ As String, ci_ As Integer, telefono_ As List(Of Integer), direccion_ As String)
        CedulaProp = ci_
        NombreProp = nombre_
        ListaTelefono = telefono_
        DireccionProp = direccion_

    End Sub





    Public Property CedulaProp As Integer
        Get
            Return _ci
        End Get

        Set(value As Integer)
            _ci = value
        End Set
    End Property

    Public Property ListaTelefono As List(Of Integer)
        Get
            Return _telefono
        End Get
        Set(value As List(Of Integer))
            _telefono = value
        End Set
    End Property

    Public Property NombreProp As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set


    End Property

    Public Property DireccionProp As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set

    End Property





End Class
