Imports System.Data.SqlClient

Public Class BaseDAO
    Public Function ObtenerConexion() As SqlConnection
        Dim oCon As New SqlConnection
        oCon.ConnectionString = "Data Source=.\SQLDEVELOPER;Initial Catalog=db_ventas2018;Integrated Security=True"
        Return oCon
    End Function
End Class
