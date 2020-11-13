Public Class logicaPersona

    Public Sub Altapersona(personaNueva As persona)
        Dim persistencia As New persistenciaPersona
        persistencia.AltaPersona(personaNueva)
    End Sub

    Public Function buscarPersona(ci As Integer) As persona
        Dim persistencia As New persistenciaPersona
        Return persistencia.buscarPersona(ci)
    End Function


    Public Function listadoPersonas()
        Dim persistencia As New persistenciaPersona
        Return persistencia.listadoPersonas()
    End Function

    Public Sub modificarPersona(personaNueva As persona)
        Dim persistencia As New persistenciaPersona
        persistencia.modificarPersona(personaNueva)
    End Sub

End Class
