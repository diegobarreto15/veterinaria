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
        logicaPersona.Altapersona(newPersona)

        tbxCedula.Enabled = True
        tbxCedula.Text = ""
        tbxDireccion.Text = ""
        tbxName.Text = ""
        tbxTel.Text = ""

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

        tbxCedula.Enabled = True
        tbxCedula.Text = ""
        tbxDireccion.Text = ""
        tbxName.Text = ""
        tbxTel.Text = ""

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cedula As Integer
        cedula = tbxCedula.Text
        Dim personaNueva As persona
        Dim logica As New logicaPersona
        personaNueva = logica.buscarPersona(cedula)

        If IsNothing(personaNueva) Then
            tbxTel.Enabled = True
            tbxName.Enabled = True
            tbxDireccion.Enabled = True
        Else
            tbxName.Text = personaNueva.NombreProp
            tbxDireccion.Text = personaNueva.DireccionProp
            tbxTel.Enabled = True
            tbxName.Enabled = True
            tbxDireccion.Enabled = True
            tbxCedula.Enabled = False
        End If
    End Sub

    Private Sub CrearPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxDireccion.Enabled = False
        tbxName.Enabled = False
        tbxTel.Enabled = False

    End Sub
End Class
