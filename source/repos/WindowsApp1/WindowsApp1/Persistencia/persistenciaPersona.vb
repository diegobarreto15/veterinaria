Public Class persistenciaPersona
    Sub New()
    End Sub

    Dim conection = New Npgsql.NpgsqlConnection

    Public Sub AltaPersona(personaNueva As persona)
        Try

            Dim classConn = New conexionPostgre
            conection = classConn.AbrirConexion()
            Dim cadenaDeComandos As String
            cadenaDeComandos = "insert into persona(ci,nombre,direccion) values (@ci,@nombre,@direccion)"
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

                    cmd = New Npgsql.NpgsqlCommand()
                    cmd.Connection = conection

                    cadenaDeComandos = "insert into telefono(ci,telefono) values (@cip,@telefono);"
                    cmd.CommandText = cadenaDeComandos

                    cmd.Parameters.Add("@cip", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaNueva.CedulaProp
                    cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaNueva.ListaTelefono.Item(i)

                    cmd.ExecuteNonQuery()
                    i = i + 1
                End While



            End If
        Catch ex As Exception
            Throw ex
        Finally
            conection.close

        End Try
        
    End Sub


    Public Function buscarPersona(ci As Integer) As persona
        Dim newPersona As New persona
        Try

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
        Return newPersona
    End Function

    Public Function listadoPersonas()
        Dim listaPersona As New List(Of persona)
        Try

            Dim newPersona As New persona
            Dim classConn As New conexionPostgre
            Dim cadenaDeComandos As String

            Dim reader As Npgsql.NpgsqlDataReader
            conection = classConn.AbrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand()

            cmd.Connection = conection

            cadenaDeComandos = "select * from personas"
            cmd.CommandText = cadenaDeComandos
            reader = cmd.ExecuteReader


            While reader.Read
                newPersona.CedulaProp = Convert.ToInt32(reader(0).ToString)
                newPersona.NombreProp = reader(1).ToString
                newPersona.DireccionProp = reader(2).ToString

                listaPersona.Add(newPersona)
            End While


        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
        Return listaPersona
    End Function

    Public Sub modificarPersona(personaNueva As persona)

        Try
            Dim classConn = New conexionPostgre
            conection = classConn.AbrirConexion()
            Dim cadenaDeComandos As String
            Dim cmd As New Npgsql.NpgsqlCommand()
            cmd.Connection = conection
            Dim resultado As Integer

            cadenaDeComandos = "update persona set nombre = @nombre, direccion=@direccion where telefono.ci = @cip"
            cmd.CommandText = cadenaDeComandos

            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = personaNueva.NombreProp

            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = personaNueva.DireccionProp

            cmd.Parameters.Add("@cip", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaNueva.CedulaProp


            resultado = cmd.ExecuteNonQuery()

            If resultado = 1 Then
                Dim i As Integer
                i = 0
                'MODIFICAR TELEFONO
                cmd = New Npgsql.NpgsqlCommand()
                cmd.Connection = conection
                cadenaDeComandos = "delete from telefono t where t.cedulapersona = @cip ;"
                cmd.CommandText = cadenaDeComandos
                cmd.Parameters.Add("@cip", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaNueva.CedulaProp
                cmd.ExecuteNonQuery()

                While i < personaNueva.ListaTelefono.Count

                    cmd = New Npgsql.NpgsqlCommand()
                    cmd.Connection = conection

                    cadenaDeComandos = "insert into telefono(cedulapersona,telefono) values (@cip,@telefono);"
                    cmd.CommandText = cadenaDeComandos

                    cmd.Parameters.Add("@cip", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaNueva.CedulaProp
                    cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaNueva.ListaTelefono.Item(i)

                    cmd.ExecuteNonQuery()
                    i = i + 1

                End While

            End If
        Catch ex As Exception
            Throw ex
        Finally
            conection.close

        End Try
    End Sub




End Class
