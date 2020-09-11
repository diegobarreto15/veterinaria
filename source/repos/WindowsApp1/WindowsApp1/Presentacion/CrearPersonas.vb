Public Class CrearPersonas
    Dim listatelefonos As New List(Of Integer)

    Dim Cedula As Integer
    Dim Nombre As String
    Dim Telefono As Integer
    Dim Direccion As String

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim ci As Integer
        ci = tbxCedula.Text
        Dim nombrepersona As String
        nombrepersona = tbxName.Text

        Dim direccion As String
        direccion = tbxDireccion.Text

        Dim newPersona As New persona()
        newPersona.CedulaProp = ci
        newPersona.NombreProp = nombrepersona
        newPersona.DireccionProp = direccion
        newPersona.ListaTelefono = listatelefonos

        Dim logicaPersona As New logicaPersona
        logicaPersona.AltaPersona(newPersona)
    End Sub

    Private Sub btnAddTel_Click(sender As Object, e As EventArgs) Handles btnAddTel.Click
        Dim telefonos As Integer
        telefonos = tbxTel.Text

        lstvPersonas.Items.Add(telefonos)
        listatelefonos.Add(telefonos)

        tbxTel.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newPersona As New persona
        Dim ci As Integer
        Dim nombrePersona As String
        Dim Direccion As String


        ci = tbxCedula.Text
        nombrePersona = tbxName.Text
        Direccion = tbxDireccion.Text

        newPersona.CedulaProp = ci
        newPersona.NombreProp = nombrepersona
        newPersona.DireccionProp = Direccion
        newPersona.ListaTelefono = listatelefonos

        Dim logicaPersona As New logicaPersona
        logicaPersona.modificarPersona(newPersona)

    End Sub
End Class
