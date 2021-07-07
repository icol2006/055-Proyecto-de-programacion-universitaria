Public Class Marca
    Public Sub New()
        producto = New List(Of Producto)()
    End Sub

    Public Property id As Integer
    Public Property codigo As String
    Public Property nombre As String
    Public Property producto As List(Of Producto)

    Public Overrides Function ToString() As String
        Return Me.nombre
    End Function
End Class
