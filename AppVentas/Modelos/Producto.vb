Public Class Producto
    Public Sub New()
    End Sub

    Public Property id As Integer
    Public Property codigo As String
    Public Property nombre As String
    Public Property descripcion As String
    Public Property precio As Decimal
    Public Property id_marca As Integer?
    Public Property id_categoria As Integer?
    Public Property marca As Marca
    Public Property categoria As Categoria

End Class