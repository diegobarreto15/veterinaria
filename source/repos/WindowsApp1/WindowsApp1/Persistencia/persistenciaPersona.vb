Public Class persistenciaPersona
    Sub New()
    End Sub

    Dim conection = New Npgsql.NpgsqlConnection

    Public Sub AltaPersona(personaNueva As persona)
        Try
            Dim classConn = New conexionPostgre
            conection = classConn.AbrirConexion()
            Dim cadenaDeComandos As String
            cadenaDeComandos = "insert into personas(ci,nombre,direccion) values (@ci,@nombre,@direccion)"
            Dim cmd As New Npgsql.NpgsqlCommand()
            cmd.CommandText = cadenaDeComandos
            cmd.Connection = conection
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaNueva.CedulaProp
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = personaNueva.NombreProp
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = personaNueva.DireccionProp
            Dim resultado As Integer

            resultado = cmd.ExecuteNonQuery()

            If resultado = 1 Then
                Dim i As Integer
                i = 0
                While i < personaNueva.ListaTelefono.Count
                    cadenaDeComandos = "insert into telefonos(cip,telefono) values (@cip,@telefono);"
                    cmd.CommandText = cadenaDeComandos
                    cmd.Parameters.Add("@cip", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaNueva.CedulaProp
                    cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaNueva.ListaTelefono.Item(i)
                End While
            End If
        Catch ex As Exception
            Throw ex
        Finally
            conection.close

        End Try

    End Sub


    Public Function buscarPersona(ci As Integer) As persona
        Try
            Dim newPersona As New persona
            Dim classConn As New conexionPostgre
            Dim cadenaDeComandos As String

            Dim reader As Npgsql.NpgsqlDataReader
            conection = classConn.AbrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand()

            cmd.Connection = conection

            cadenaDeComandos = "select * from persona where ci = @ci"
            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            reader = cmd.ExecuteReader

            If reader.HasRows Then
                reader.Read()
                newPersona.CedulaProp = Convert.ToInt32(reader(0).ToString)
                newPersona.NombreProp = reader(1).ToString
                newPersona.DireccionProp = reader(2).ToString

            End If

            If newPersona.NombreProp = "" And newPersona.DireccionProp = "" Then
            Else
                Return newPersona
            End If


        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
    End Function

End Class
