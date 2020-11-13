Public Class ModificarPersona
    Private Sub ModificarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbxCedula_TextChanged(sender As Object, e As EventArgs) Handles tbxCedula.TextChanged
        Dim persistencia As New persistenciaPersona
        Dim ci As Integer

        ci = tbxCedula.Text

        persistencia.modificarPersona(ci)
    End Sub
End Class