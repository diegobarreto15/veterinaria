Public Class mascota
    Private _nombre As String
    Private _anoNac As Integer
    Private _dueno As persona
    Private _id As Integer


    Public Sub mascota()

    End Sub

    Public Sub mascota(nombre_ As String, anoNac_ As Integer, dueno_ As persona, id_ As Integer)

    End Sub

    Public Property Dueno As persona
        Get
            Return _dueno
        End Get
        Set(value As persona)
            _dueno = value
        End Set
    End Property


    Public Property AnoNac As Integer
        Get
            Return _anoNac
        End Get
        Set(value As Integer)
            _anoNac = value
        End Set

    End Property



    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set


    End Property

End Class
