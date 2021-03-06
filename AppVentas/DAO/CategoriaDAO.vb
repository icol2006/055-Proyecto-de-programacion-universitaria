Imports System.Data.SqlClient

Public Class CategoriaDAO
    Dim baseDAO As BaseDAO = New BaseDAO()

    'Obtener listado de registros
    Public Function obtenerListado() As List(Of Categoria)
        Dim oComman As New SqlCommand
        Try
            Dim listado As List(Of Categoria)
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "SELECT id, descripcion FROM tb_categoria"
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
    Public Function obtenerPorId(ByVal Id As Integer) As Categoria
        Dim oComman As New SqlCommand
        Try
            Dim datos As Categoria
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "SELECT id, descripcion FROM tb_categoria WHERE id = @id"
            oComman.Parameters.Add("@id", SqlDbType.Int).Value = Id
            oComman.Connection.Open()

            Dim oDataRead As SqlDataReader = oComman.ExecuteReader()
            datos = recuperarListado(oDataRead).FirstOrDefault()

            oDataRead.IsClosed.ToString()
            oComman.Connection.Close()
            Return datos

        Catch ex As Exception
            Throw New System.AggregateException("No se puedo encontrar el cliente por Id", ex)
        Finally
            If oComman.Connection.State = ConnectionState.Open Then
                oComman.Connection.Close()
            End If
        End Try
    End Function

    'Insertar registro
    Public Sub insertar(ByVal datos As Categoria)
        Dim oComman As New SqlCommand
        Try
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "INSERT INTO tb_categoria VALUES (@descripcion)"
            oComman.Parameters.Add("@descripcion", SqlDbType.NChar)
            oComman.Connection.Open()

            oComman.Parameters("@descripcion").Value = datos.descripcion
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
    Public Sub actualizar(ByVal datos As Categoria)
        Dim oComman As New SqlCommand
        Try
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "UPDATE tb_categoria SET descripcion = @descripcion  WHERE id = @id"
            oComman.Parameters.Add("@id", SqlDbType.Char)
            oComman.Parameters.Add("@descripcion", SqlDbType.NChar)
            oComman.Connection.Open()

            oComman.Parameters("@id").Value = datos.id
            oComman.Parameters("@descripcion").Value = datos.descripcion
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
            oComman.CommandText = "DELETE FROM tb_categoria WHERE id = @id"
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
    Private Function recuperarListado(ByVal dataReader As SqlDataReader) As List(Of Categoria)
        Try
            Dim listado As New List(Of Categoria)
            While (dataReader.Read)
                Dim x As New Categoria
                x.id = dataReader("id")
                x.descripcion = dataReader("descripcion")
                listado.Add(x)
            End While
            Return listado
        Catch ex As Exception
            Throw New System.AggregateException("No se puedo crear el listado para consulta", ex)
        End Try
    End Function
End Class
