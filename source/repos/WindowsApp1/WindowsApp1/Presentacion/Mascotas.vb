Public Class Mascotas
    Dim Nombre As String
    Dim CiDueño As Integer
    Dim FechaNac As Integer

    Private Sub btnCrearMasc_Click(sender As Object, e As EventArgs) Handles btnCrearMasc.Click
        Nombre = tbxNombreMasc.Text
        CiDueño = tbxCIDueño.Text
        FechaNac = tbxAñoNac.Text

        Dim logica As New logicaMascota
        Dim mascotaNueva As New mascota

        mascotaNueva.AnoNac = FechaNac
        mascotaNueva.Nombre = Nombre
        mascotaNueva.Dueno.CedulaProp = CiDueño

        logica.AltaMascotas(mascotaNueva)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cedula As Integer
        cedula = tbxCIDueño.Text
        Dim mascotaNueva As mascota
        Dim logica As New logicaMascota
        mascotaNueva = logica.buscarMascotas(cedula)

        If IsNothing(mascotaNueva) Then
            tbxAñoNac.Enabled = True
            tbxNombreMasc.Enabled = True
        Else
            tbxAñoNac.Text = mascotaNueva.AnoNac
            tbxCIDueño.Text = mascotaNueva.Dueno.CedulaProp
            tbxNombreMasc.Text = mascotaNueva.Nombre
        End If


    End Sub
End Class