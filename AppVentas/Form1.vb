Public Class Form1
    Dim categoriaDAO As CategoriaDAO = New CategoriaDAO()
    Dim marcaDAO As MarcaDAO = New MarcaDAO()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCategorias()
        cargarMarcas()
    End Sub

    'Inicio Categorias ######################################################

    'cargar grid categorias
    Public Sub cargarCategorias()
        dgCategorias.Rows.Clear()
        Dim listado = categoriaDAO.obtenerListado()
        For i As Integer = 0 To listado.Count - 1
            Dim item = listado(i)
            dgCategorias.Rows.Add(item.id, item.descripcion)
        Next
    End Sub

    'limpiar las cajas de texto de categorias
    Public Sub limpiarTextInputsCategorias()
        txtIdCategoria.Clear()
        txtDescripcionCategoria.Clear()
    End Sub

    'obtener datos de los inputs de categorias
    Public Function obtenerDatosTextsInputsCategorias() As Categoria
        Dim categoria As Categoria = New Categoria()
        If txtIdCategoria.Text.Equals("") Then
            categoria.id = 0
        Else
            categoria.id = txtIdCategoria.Text
        End If

        categoria.descripcion = txtDescripcionCategoria.Text
        Return categoria
    End Function

    'seleccionar fila grid categorias
    Private Sub dgCategorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCategorias.CellClick
        Dim filaActual = dgCategorias.CurrentCell.RowIndex
        Dim id = dgCategorias.Rows(filaActual).Cells("id").Value
        Dim datos = categoriaDAO.obtenerPorId(id)
        txtIdCategoria.Text = datos.id
        txtDescripcionCategoria.Text = datos.descripcion
    End Sub

    'insertar categoria
    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click
        Dim datos = obtenerDatosTextsInputsCategorias()
        categoriaDAO.insertar(datos)
        cargarCategorias()
        limpiarTextInputsCategorias()
    End Sub

    'actualizar categoria
    Private Sub BtnActualizarCategoria_Click(sender As Object, e As EventArgs) Handles BtnActualizarCategoria.Click
        Dim datos = obtenerDatosTextsInputsCategorias()
        categoriaDAO.actualizar(datos)
        cargarCategorias()
        limpiarTextInputsCategorias()
    End Sub

    'eliminar categoria
    Private Sub btnEliminarCategoria_Click(sender As Object, e As EventArgs) Handles btnEliminarCategoria.Click
        Dim datos = obtenerDatosTextsInputsCategorias()
        categoriaDAO.eliminar(datos.id)
        cargarCategorias()
        limpiarTextInputsCategorias()
    End Sub

    'boton nuevo registro
    Private Sub btnNuevaCategoria_Click(sender As Object, e As EventArgs) Handles btnNuevaCategoria.Click
        limpiarTextInputsCategorias()
    End Sub

    'Final Categorias ######################################################


    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    'Inicio Marcas ######################################################

    'cargar grid categorias
    Public Sub cargarMarcas()
        dgMarca.Rows.Clear()
        Dim listado = marcaDAO.obtenerListado()
        For i As Integer = 0 To listado.Count - 1
            Dim item = listado(i)
            dgMarca.Rows.Add(item.id, item.codigo, item.nombre)
        Next
    End Sub

    'limpiar las cajas de texto de categorias
    Public Sub limpiarTextInputsMarca()
        txtIdMarca.Clear()
        txtNombreMarca.Clear()
        txtCodigoMarca.Clear()
    End Sub

    'obtener datos de los inputs de categorias
    Public Function obtenerDatosTextsInputsMarca() As Marca
        Dim datos As Marca = New Marca()
        If txtIdMarca.Text.Equals("") Then
            datos.id = 0
        Else
            datos.id = txtIdMarca.Text
        End If

        datos.nombre = txtNombreMarca.Text
        datos.codigo = txtCodigoMarca.Text
        Return datos
    End Function

    'seleccionar fila grid marca
    Private Sub dgMarca_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMarca.CellClick
        Dim filaActual = dgMarca.CurrentCell.RowIndex
        Dim id = dgMarca.Rows(filaActual).Cells("idMarca").Value
        Dim datos = marcaDAO.obtenerPorId(id)
        txtIdMarca.Text = datos.id
        txtNombreMarca.Text = datos.nombre
        txtCodigoMarca.Text = datos.codigo
    End Sub

    'insertar marca
    Private Sub btnAgregarMarca_Click(sender As Object, e As EventArgs) Handles btnAgregarMarca.Click
        Dim datos = obtenerDatosTextsInputsMarca()
        marcaDAO.insertar(datos)
        cargarMarcas()
        limpiarTextInputsMarca()
    End Sub

    'actualizar marca
    Private Sub btnActualizarMarca_Click(sender As Object, e As EventArgs) Handles btnActualizarMarca.Click
        Dim datos = obtenerDatosTextsInputsMarca()
        marcaDAO.actualizar(datos)
        cargarMarcas()
        limpiarTextInputsMarca()
    End Sub

    'eliminar marca
    Private Sub btnEliminarMarca_Click(sender As Object, e As EventArgs) Handles btnEliminarMarca.Click
        Dim datos = obtenerDatosTextsInputsMarca()
        marcaDAO.eliminar(datos.id)
        cargarMarcas()
        limpiarTextInputsMarca()
    End Sub

    'boton nuevo registro
    Private Sub btnNuevaMarca_Click(sender As Object, e As EventArgs) Handles btnNuevaMarca.Click
        limpiarTextInputsMarca()
    End Sub

    'Final Marca ######################################################

End Class
