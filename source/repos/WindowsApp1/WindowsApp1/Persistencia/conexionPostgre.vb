Public Class conexionPostgre
    Public Function AbrirConexion() As Npgsql.NpgsqlConnection
        Dim conexion As Npgsql.NpgsqlConnection

        Try

        Catch ex As Exception
            Throw ex
        End Try


        Return conexion

    End Function




End Class
