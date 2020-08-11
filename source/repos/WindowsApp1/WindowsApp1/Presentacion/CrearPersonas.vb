Public Class CrearPersonas
    Dim Cedula As Integer
    Dim Nombre As String
    Dim Telefono As Integer
    Dim Direccion As String

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Cedula = tbxCedula.Text
        Nombre = tbxName.Text
        Telefono = tbxTel.Text
        Direccion = tbxDireccion.Text

        lblListPersonas.Text = Convert.ToString(Cedula) + " " + Nombre + " " + Convert.ToString(Telefono) + " " + Direccion
    End Sub


End Class
