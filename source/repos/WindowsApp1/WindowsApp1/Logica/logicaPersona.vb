Public Class logicaPersona

    Public Sub Altapersona(personaNueva As persona)
        Dim persistencia As New persistenciaPersona
        persistencia.AltaPersona(personaNueva)
    End Sub

    Public Function buscarPersona(ci As Integer) As persona
        Dim persistencia As New persistenciaPersona
        Return persistencia.buscarPersona(ci)
    End Function

End Class
