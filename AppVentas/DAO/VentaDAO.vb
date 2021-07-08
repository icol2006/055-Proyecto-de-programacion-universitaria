Imports System.Data.SqlClient

Public Class VentaDAO
    Dim baseDAO As BaseDAO = New BaseDAO()

    'Obtener listado de registros
    Public Function obtenerListado() As List(Of Venta)
        Dim oComman As New SqlCommand
        Try
            Dim listado As List(Of Venta)
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "SELECT id, fecha, total_precio FROM tb_venta"
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
    Public Function obtenerPorId(ByVal Id As Integer) As Venta
        Dim oComman As New SqlCommand
        Try
            Dim datos As Venta
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "SELECT id, fecha, total_precio   FROM tb_venta WHERE id = @id"
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
    Public Sub insertar(ByVal datos As Venta)
        Dim oComman As New SqlCommand
        Try
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "INSERT INTO tb_venta VALUES (@fecha,@total_precio)"
            oComman.Parameters.Add("@fecha", SqlDbType.NChar)
            oComman.Parameters.Add("@total_precio", SqlDbType.Decimal)
            oComman.Connection.Open()

            oComman.Parameters("@fecha").Value = datos.fecha
            oComman.Parameters("@total_precio").Value = datos.total_precio
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
    Public Sub actualizar(ByVal datos As Venta)
        Dim oComman As New SqlCommand
        Try
            oComman.Connection = baseDAO.ObtenerConexion()
            oComman.CommandText = "UPDATE tb_venta SET fecha = @fecha, total_precio= @total_precio  WHERE id = @id"
            oComman.Parameters.Add("@id", SqlDbType.Char)
            oComman.Parameters.Add("@fecha", SqlDbType.NChar)
            oComman.Parameters.Add("@total_precio", SqlDbType.Decimal)
            oComman.Connection.Open()

            oComman.Parameters("@id").Value = datos.id
            oComman.Parameters("@fecha").Value = datos.fecha
            oComman.Parameters("@total_precio").Value = datos.total_precio
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
            oComman.CommandText = "DELETE FROM tb_venta WHERE id = @id"
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
    Private Function recuperarListado(ByVal dataReader As SqlDataReader) As List(Of Venta)
        Try
            Dim listado As New List(Of Venta)
            While (dataReader.Read)
                Dim x As New Venta
                x.id = dataReader("id")
                x.fecha = dataReader("fecha")
                x.total_precio = dataReader("total_precio")
                listado.Add(x)
            End While
            Return listado
        Catch ex As Exception
            Throw New System.AggregateException("No se puedo crear el listado para consulta", ex)
        End Try
    End Function
End Class
