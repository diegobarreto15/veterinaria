Public Class Mascotas
    Dim Nombre As String
    Dim CiDueño As Integer
    Dim FechaNac As Integer



    Private Sub btnCrearMasc_Click(sender As Object, e As EventArgs) Handles btnCrearMasc.Click
        Nombre = tbxNombreMasc.Text
        CiDueño = tbxCIDueño.Text
        FechaNac = tbxAñoNac.Text

    End Sub


End Class