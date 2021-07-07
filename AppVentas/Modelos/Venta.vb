Public Class Venta

    Public Property detalleVenta As List(Of DetalleVenta)
    Public Property total As Decimal

    Public Sub New()
        detalleVenta = New List(Of DetalleVenta)()
    End Sub

End Class
