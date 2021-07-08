Imports System.Data.SqlClient

Public Class ProductoDAO
    Dim baseDAO As BaseDAO = New BaseDAO()

    'Obtener listado de registros
    Public Function obtenerListado() As List(Of Producto)
        Dim oComman As New SqlCommand
        Try
            Dim listado As List(Of Producto)
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "SELECT p.id, p.codigo, p.nombre, p.precio, p.id_marca, p.id_categoria, 
                                   m.codigo marca_codigo,m.nombre marca_nombre, 
                                   c.descripcion categoria_descripcion
                                   FROM tb_producto p, tb_marca m, tb_categoria c where p.id_categoria=c.id and p.id_marca=m.id"
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
    Public Function obtenerPorId(ByVal Id As Integer) As Producto
        Dim oComman As New SqlCommand
        Try
            Dim datos As Producto
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "SELECT p.id, p.codigo, p.nombre, p.precio, p.id_marca, p.id_categoria, 
                                   m.codigo marca_codigo,m.nombre marca_nombre, 
                                   c.descripcion categoria_descripcion
                                   FROM tb_producto p, tb_marca m, tb_categoria c where p.id = @id and p.id_categoria=c.id and p.id_marca=m.id"

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
    Public Sub insertar(ByVal datos As Producto)
        Dim oComman As New SqlCommand
        Try
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "INSERT INTO tb_producto VALUES (@codigo,@nombre,@precio,@id_marca,@id_categoria)"
            oComman.Parameters.Add("@codigo", SqlDbType.NVarChar)
            oComman.Parameters.Add("@nombre", SqlDbType.NVarChar)
            oComman.Parameters.Add("@precio", SqlDbType.NVarChar)
            oComman.Parameters.Add("@id_marca", SqlDbType.Int)
            oComman.Parameters.Add("@id_categoria", SqlDbType.Int)

            oComman.Connection.Open()

            oComman.Parameters("@codigo").Value = datos.codigo
            oComman.Parameters("@nombre").Value = datos.nombre
            oComman.Parameters("@precio").Value = datos.precio
            oComman.Parameters("@id_marca").Value = datos.id_marca
            oComman.Parameters("@id_categoria").Value = datos.id_categoria

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
    Public Sub actualizar(ByVal datos As Producto)
        Dim oComman As New SqlCommand
        Try
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "UPDATE tb_producto SET codigo = @codigo, nombre= @nombre, precio= @precio, id_marca= @id_marca, id_categoria= @id_categoria  WHERE id = @id"
            oComman.Parameters.Add("@id", SqlDbType.Int)
            oComman.Parameters.Add("@codigo", SqlDbType.NVarChar)
            oComman.Parameters.Add("@nombre", SqlDbType.NVarChar)
            oComman.Parameters.Add("@precio", SqlDbType.Decimal)
            oComman.Parameters.Add("@id_marca", SqlDbType.Int)
            oComman.Parameters.Add("@id_categoria", SqlDbType.Int)
            oComman.Connection.Open()

            oComman.Parameters("@id").Value = datos.id
            oComman.Parameters("@codigo").Value = datos.codigo
            oComman.Parameters("@nombre").Value = datos.nombre
            oComman.Parameters("@precio").Value = datos.precio
            oComman.Parameters("@id_marca").Value = datos.id_marca
            oComman.Parameters("@id_categoria").Value = datos.id_categoria

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
            oComman.CommandText = "DELETE FROM tb_producto WHERE id = @id"
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
    Private Function recuperarListado(ByVal dataReader As SqlDataReader) As List(Of Producto)
        Try
            Dim listado As New List(Of Producto)
            While (dataReader.Read)
                Dim x As New Producto
                x.id = dataReader("id")
                x.codigo = dataReader("codigo")
                x.nombre = dataReader("nombre")
                x.precio = dataReader("precio")
                x.id_marca = dataReader("id_marca")
                x.id_categoria = dataReader("id_categoria")
                x.marca.id = dataReader("id_marca")
                x.marca.codigo = dataReader("marca_codigo")
                x.marca.nombre = dataReader("marca_nombre")
                x.categoria.id = dataReader("id_categoria")
                x.categoria.descripcion = dataReader("categoria_descripcion")
                listado.Add(x)
            End While
            Return listado
        Catch ex As Exception
            Throw New System.AggregateException("No se puedo crear el listado para consulta", ex)
        End Try
    End Function
End Class
