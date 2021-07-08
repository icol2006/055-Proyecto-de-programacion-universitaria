Imports System.Data.SqlClient

Public Class DetalleVentaDAO
    Dim baseDAO As BaseDAO = New BaseDAO()

    'Obtener listado de registros
    Public Function obtenerListado() As List(Of DetalleVenta)
        Dim oComman As New SqlCommand
        Try
            Dim listado As List(Of DetalleVenta)
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "SELECT id, id_producto, cantidad, totalPrecio, id_venta FROM tb_venta_detalle"
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
    Public Function obtenerPorId(ByVal Id As Integer) As DetalleVenta
        Dim oComman As New SqlCommand
        Try
            Dim datos As DetalleVenta
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "SELECT  id, id_producto, cantidad, totalPrecio, id_venta FROM tb_venta_detalle WHERE id = @id"
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
    Public Sub insertar(ByVal datos As DetalleVenta)
        Dim oComman As New SqlCommand
        Try
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "INSERT INTO tb_venta_detalle VALUES (@id_producto,@cantidad,@totalPrecio,@id_venta)"
            oComman.Parameters.Add("@id_producto", SqlDbType.Int)
            oComman.Parameters.Add("@cantidad", SqlDbType.Int)
            oComman.Parameters.Add("@totalPrecio", SqlDbType.Decimal)
            oComman.Parameters.Add("@id_venta", SqlDbType.Int)
            oComman.Connection.Open()

            oComman.Parameters("@id_producto").Value = datos.id_producto
            oComman.Parameters("@cantidad").Value = datos.cantidad
            oComman.Parameters("@totalPrecio").Value = datos.totalPrecio
            oComman.Parameters("@id_venta").Value = datos.id_venta
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
    Public Sub actualizar(ByVal datos As DetalleVenta)
        Dim oComman As New SqlCommand
        Try
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "UPDATE tb_venta_detalle SET id_producto = @id_producto, cantidad= @cantidad, totalPrecio= @totalPrecio, id_venta= @id_venta   WHERE id = @id"
            oComman.Parameters.Add("@id", SqlDbType.Char)
            oComman.Parameters.Add("@id_producto", SqlDbType.Int)
            oComman.Parameters.Add("@cantidad", SqlDbType.Int)
            oComman.Parameters.Add("@totalPrecio", SqlDbType.Decimal)
            oComman.Parameters.Add("@id_venta", SqlDbType.Int)
            oComman.Connection.Open()

            oComman.Parameters("@id").Value = datos.id
            oComman.Parameters("@id_producto").Value = datos.id_producto
            oComman.Parameters("@cantidad").Value = datos.cantidad
            oComman.Parameters("@totalPrecio").Value = datos.totalPrecio
            oComman.Parameters("@id_venta").Value = datos.id_venta
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
            oComman.CommandText = "DELETE FROM tb_venta_detalle WHERE id = @id"
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
    Private Function recuperarListado(ByVal dataReader As SqlDataReader) As List(Of DetalleVenta)
        Try
            Dim listado As New List(Of DetalleVenta)
            While (dataReader.Read)
                Dim x As New DetalleVenta
                x.id = dataReader("id")
                x.id_producto = dataReader("id_producto")
                x.cantidad = dataReader("cantidad")
                x.totalPrecio = dataReader("totalPrecio")
                x.id_venta = dataReader("id_venta")
                listado.Add(x)
            End While
            Return listado
        Catch ex As Exception
            Throw New System.AggregateException("No se puedo crear el listado para consulta", ex)
        End Try
    End Function
End Class
