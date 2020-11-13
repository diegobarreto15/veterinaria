Public Class logicaMascota
    Public Sub AltaMascotas(mascotaNueva As mascota)
        Dim persistencia As New persistenciaMascota
        persistencia.AltaMascotas(mascotaNueva)
    End Sub

    Public Function buscarMascotas(ci As Integer) As mascota
        Dim persistencia As New persistenciaMascota
        Return persistencia.buscarMascotas(ci)
    End Function

    Public Function listadoMascotas()
        Dim persistencia As New persistenciaMascota
        Return persistencia.listadoMascotas()
    End Function


    Public Sub modificarMascotas(mascotaNueva As mascota)
        Dim persistencia As New persistenciaMascota
        persistencia.modificarMascotas(mascotaNueva)
    End Sub



End Class
