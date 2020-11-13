Public Class persistenciaMascota

    Dim conection = New Npgsql.NpgsqlConnection
    Public Sub AltaMascotas(mascotaNueva As mascota)
        Try
            Dim classConn = New conexionPostgre
            conection = classConn.AbrirConexion()
            Dim cadenaDeComandos As String
            cadenaDeComandos = "insert into mascotas(ci,nombre,añonacimiento) values (@ci,@nombre,@añonacimiento)"
            Dim cmd As New Npgsql.NpgsqlCommand()
            cmd.CommandText = cadenaDeComandos
            cmd.Connection = conection
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = mascotaNueva.Dueno.CedulaProp
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = mascotaNueva.Nombre
            cmd.Parameters.Add("@añoNacimiento", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = mascotaNueva.AnoNac
            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
    End Sub


    Public Function buscarMascotas(ci As Integer) As mascota
        Try
            Dim classConn As New conexionPostgre
            Dim cadenaDeComandos As String
            Dim newMascota As New mascota
            Dim reader As Npgsql.NpgsqlDataReader
            conection = classConn.AbrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand()

            cmd.Connection = conection

            cadenaDeComandos = "select * from mascotas where ci = @ci"
            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            reader = cmd.ExecuteReader

            If reader.HasRows Then
                reader.Read()
                newMascota.Dueno.CedulaProp = Convert.ToInt32(reader(3).ToString)
                newMascota.AnoNac = Convert.ToInt32(reader(2).ToString)
                newMascota.Nombre = reader(1).ToString
            End If

            If newMascota.Nombre = "" And newMascota.Dueno.CedulaProp = "" Then
            Else
                Return newMascota
            End If

        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try

    End Function

    Public Function listadoMascotas()
        Dim listaDeMascota As New List(Of mascota)
        Try
            Dim newMascota As New mascota
            Dim classConn As New conexionPostgre
            Dim cadenaDeComandos As String
            Dim cmd As New Npgsql.NpgsqlCommand()
            Dim reader As Npgsql.NpgsqlDataReader

            conection = classConn.AbrirConexion()
            cmd.Connection = conection
            cadenaDeComandos = "select * from mascotas"
            cmd.CommandText = cadenaDeComandos
            reader = cmd.ExecuteReader

            While reader.Read()
                newMascota.id = Convert.ToInt32(reader(0).ToString)
                newMascota.Nombre = reader(1).ToString
                newMascota.AnoNac = Convert.ToInt32(reader(2).ToString)
                Dim persistenciaPersona As New persistenciaPersona
                newMascota.Dueno = persistenciaPersona.buscarPersona(Convert.ToInt32(reader(3).ToString))
                listaDeMascota.Add(newMascota)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
        Return listaDeMascota
    End Function

    Public Sub modificarMascotas(mascotaNueva As mascota)
        Try
            Dim classConn = New conexionPostgre
            Dim resultado As Integer
            Dim cadenaDeComandos As String
            Dim cmd As New Npgsql.NpgsqlCommand()
            cmd.Connection = conection
            conection = classConn.AbrirConexion()

            cadenaDeComandos = "update mascotas set nombre = @nombre, añoNacimiento=@anoNac"
            cmd.CommandText = cadenaDeComandos

            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = mascotaNueva.Nombre
            cmd.Parameters.Add("@añoNacimiento", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = mascotaNueva.AnoNac

            resultado = cmd.ExecuteNonQuery()


        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
    End Sub

End Class
