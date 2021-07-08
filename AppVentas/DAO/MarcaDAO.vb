Imports System.Data.SqlClient

Public Class MarcaDAO
    Dim baseDAO As BaseDAO = New BaseDAO()

    'Obtener listado de registros
    Public Function obtenerListado() As List(Of Marca)
        Dim oComman As New SqlCommand
        Try
            Dim listado As List(Of Marca)
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "SELECT id, codigo, nombre FROM tb_marca"
            oComman.Connection.Open()

            Dim oDataRead As SqlDataReader = oComman.ExecuteReader()
            listado = recuperarListado(oDataRead)
            oDataRead.IsClosed.ToString()
            oComman.Connection.Close()
            Return listado

        Catch ex As Exception
            Throw New System.AggregateException("No se puedo ejecutar la consuta", ex)
        End Try
    End Function

    'Obtener registro por id
    Public Function obtenerPorId(ByVal Id As Integer) As Marca
        Dim oComman As New SqlCommand
        Try
            Dim datos As Marca
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "SELECT id, codigo, nombre  FROM tb_marca WHERE id = @id"
            oComman.Parameters.Add("@id", SqlDbType.Int).Value = Id
            oComman.Connection.Open()

            Dim oDataRead As SqlDataReader = oComman.ExecuteReader()
            datos = recuperarListado(oDataRead).FirstOrDefault()

            oDataRead.IsClosed.ToString()
            oComman.Connection.Close()
            Return datos

        Catch ex As Exception
            Throw New System.AggregateException("No se puedo encontrar", ex)
        Finally
            If oComman.Connection.State = ConnectionState.Open Then
                oComman.Connection.Close()
            End If
        End Try
    End Function

    'Insertar registro
    Public Sub insertar(ByVal datos As Marca)
        Dim oComman As New SqlCommand
        Try
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "INSERT INTO tb_marca VALUES (@codigo,@nombre)"
            oComman.Parameters.Add("@codigo", SqlDbType.NChar)
            oComman.Parameters.Add("@nombre", SqlDbType.NChar)
            oComman.Connection.Open()

            oComman.Parameters("@codigo").Value = datos.codigo
            oComman.Parameters("@nombre").Value = datos.nombre
            oComman.ExecuteNonQuery()

            oComman.Connection.Close()
        Catch ex As Exception
            Throw New System.AggregateException("No se puedo insertar", ex)
        Finally
            If oComman.Connection.State = ConnectionState.Open Then
                oComman.Connection.Close()
            End If
        End Try
    End Sub

    'actualizar registro
    Public Sub actualizar(ByVal datos As Marca)
        Dim oComman As New SqlCommand
        Try
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "UPDATE tb_marca SET codigo = @codigo, nombre= @nombre  WHERE id = @id"
            oComman.Parameters.Add("@id", SqlDbType.Char)
            oComman.Parameters.Add("@codigo", SqlDbType.NChar)
            oComman.Parameters.Add("@nombre", SqlDbType.NChar)
            oComman.Connection.Open()

            oComman.Parameters("@id").Value = datos.id
            oComman.Parameters("@codigo").Value = datos.codigo
            oComman.Parameters("@nombre").Value = datos.nombre
            oComman.ExecuteNonQuery()

            oComman.Connection.Close()
        Catch ex As Exception
            Throw New System.AggregateException("No se puedo actualizar", ex)
        Finally
            If oComman.Connection.State = ConnectionState.Open Then
                oComman.Connection.Close()
            End If
        End Try
    End Sub
    Public Sub eliminar(ByVal Id As Integer)
        Dim oComman As New SqlCommand
        Try
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "DELETE FROM tb_marca WHERE id = @id"
            oComman.Parameters.Add("@id", SqlDbType.Int).Value = Id
            oComman.Connection.Open()
            oComman.ExecuteNonQuery()
            oComman.Connection.Close()
        Catch ex As Exception
            Throw New System.AggregateException("No se puedo eliminar", ex)
        Finally
            If oComman.Connection.State = ConnectionState.Open Then
                oComman.Connection.Close()
            End If
        End Try
    End Sub

    'recuperar registro de datareader
    Private Function recuperarListado(ByVal dataReader As SqlDataReader) As List(Of Marca)
        Try
            Dim listado As New List(Of Marca)
            While (dataReader.Read)
                Dim x As New Marca
                x.id = dataReader("id")
                x.codigo = dataReader("codigo")
                x.nombre = dataReader("nombre")
                listado.Add(x)
            End While
            Return listado
        Catch ex As Exception
            Throw New System.AggregateException("No se puedo crear el listado para consulta", ex)
        End Try
    End Function
End Class
