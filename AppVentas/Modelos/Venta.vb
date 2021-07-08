Public Class Venta
    Public Property id As Integer
    Public Property fecha As String
    Public Property total_precio As Decimal
    Public Property detalleVenta As List(Of DetalleVenta)

    Public Sub New()
        detalleVenta = New List(Of DetalleVenta)()
    End Sub

End Class
