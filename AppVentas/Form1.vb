Public Class Form1
    Dim categoriaDAO As CategoriaDAO = New CategoriaDAO()
    Dim marcaDAO As MarcaDAO = New MarcaDAO()
    Dim productoDAO As ProductoDAO = New ProductoDAO()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGridCategorias()
        cargarGridMarcas()
        cargarGridProductos()
        cargarComboProductoCategorias()
        cargarComboProductoMarcas()
    End Sub

#Region "Inicio Categorias ######################################################"

    'cargar grid categorias
    Public Sub cargarGridCategorias()
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
        cargarGridCategorias()
        limpiarTextInputsCategorias()
    End Sub

    'actualizar categoria
    Private Sub BtnActualizarCategoria_Click(sender As Object, e As EventArgs) Handles BtnActualizarCategoria.Click
        Dim datos = obtenerDatosTextsInputsCategorias()
        categoriaDAO.actualizar(datos)
        cargarGridCategorias()
        limpiarTextInputsCategorias()
    End Sub

    'eliminar categoria
    Private Sub btnEliminarCategoria_Click(sender As Object, e As EventArgs) Handles btnEliminarCategoria.Click
        Dim datos = obtenerDatosTextsInputsCategorias()
        categoriaDAO.eliminar(datos.id)
        cargarGridCategorias()
        limpiarTextInputsCategorias()
    End Sub

    'boton nuevo registro
    Private Sub btnNuevaCategoria_Click(sender As Object, e As EventArgs) Handles btnNuevaCategoria.Click
        limpiarTextInputsCategorias()
    End Sub

    'Final Categorias ######################################################
#End Region

#Region "Inicio Marcas ######################################################"

    'cargar grid categorias
    Public Sub cargarGridMarcas()
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
        cargarGridMarcas()
        limpiarTextInputsMarca()
    End Sub

    'actualizar marca
    Private Sub btnActualizarMarca_Click(sender As Object, e As EventArgs) Handles btnActualizarMarca.Click
        Dim datos = obtenerDatosTextsInputsMarca()
        marcaDAO.actualizar(datos)
        cargarGridMarcas()
        limpiarTextInputsMarca()
    End Sub

    'eliminar marca
    Private Sub btnEliminarMarca_Click(sender As Object, e As EventArgs) Handles btnEliminarMarca.Click
        Dim datos = obtenerDatosTextsInputsMarca()
        marcaDAO.eliminar(datos.id)
        cargarGridMarcas()
        limpiarTextInputsMarca()
    End Sub

    'boton nuevo registro
    Private Sub btnNuevaMarca_Click(sender As Object, e As EventArgs) Handles btnNuevaMarca.Click
        limpiarTextInputsMarca()
    End Sub
    'Final Marcas ######################################################

#End Region

#Region "Inicio Productos ######################################################"

    'cargar grid productos
    Public Sub cargarGridProductos()
        dgProducto.Rows.Clear()
        Dim listado = productoDAO.obtenerListado()
        For i As Integer = 0 To listado.Count - 1
            Dim item = listado(i)
            dgProducto.Rows.Add(item.id, item.codigo, item.nombre, item.precio, item.marca.nombre, item.categoria.descripcion)
        Next
    End Sub

    'carga el combo de marcas en pestana de producto
    Public Sub cargarComboProductoMarcas()
        cboProductoMarca.DataSource = Nothing
        cboProductoMarca.Items.Clear()

        cboProductoMarca.DisplayMember = "nombre"
        cboProductoMarca.ValueMember = "id"
        Dim listado = marcaDAO.obtenerListado()
        cboProductoMarca.DataSource = listado
    End Sub

    'carga el combo de categorias en pestana de producto
    Public Sub cargarComboProductoCategorias()
        cboProductoCategoria.DataSource = Nothing
        cboProductoCategoria.Items.Clear()

        cboProductoCategoria.DisplayMember = "descripcion"
        cboProductoCategoria.ValueMember = "id"
        Dim listado = categoriaDAO.obtenerListado()
        cboProductoCategoria.DataSource = listado
    End Sub

    'limpiar las cajas de texto de productos
    Public Sub limpiarTextInputsProducto()
        txtIdProducto.Clear()
        txtCodigoProducto.Clear()
        txtNombreProducto.Clear()
        txtDescripcionProducto.Clear()
        txtPrecioProducto.Clear()
        cboProductoCategoria.SelectedIndex = 0
        cboProductoMarca.SelectedIndex = 0
    End Sub

    'obtener datos de los inputs de productos
    Public Function obtenerDatosTextsInputsProducto() As Producto
        Dim datos As Producto = New Producto()
        If txtIdProducto.Text.Equals("") Then
            datos.id = 0
        Else
            datos.id = txtIdProducto.Text
        End If

        datos.nombre = txtNombreMarca.Text
        datos.codigo = txtCodigoMarca.Text
        datos.precio = txtPrecioProducto.Text
        datos.id_categoria = cboProductoCategoria.SelectedValue
        datos.id_marca = cboProductoMarca.SelectedValue
        Return datos
    End Function

    'seleccionar fila grid productos
    Private Sub dgProducto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProducto.CellClick
        Dim filaActual = dgProducto.CurrentCell.RowIndex
        Dim id = dgProducto.Rows(filaActual).Cells("idProducto").Value
        Dim datos = productoDAO.obtenerPorId(id)
        txtIdProducto.Text = datos.id
        txtNombreProducto.Text = datos.nombre
        txtCodigoProducto.Text = datos.codigo
        txtPrecioProducto.Text = datos.precio
        cboProductoCategoria.SelectedValue = datos.id_categoria
        cboProductoMarca.SelectedValue = datos.id_marca
    End Sub

    'insertar producto
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim datos = obtenerDatosTextsInputsProducto()
        productoDAO.insertar(datos)
        cargarGridProductos()
        limpiarTextInputsProducto()
    End Sub

    'actualizar producto
    Private Sub btnActualizarProducto_Click(sender As Object, e As EventArgs) Handles btnActualizarProducto.Click
        Dim datos = obtenerDatosTextsInputsProducto()
        productoDAO.actualizar(datos)
        cargarGridProductos()
        limpiarTextInputsProducto()
    End Sub

    'eliminar producto
    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        Dim datos = obtenerDatosTextsInputsProducto()
        marcaDAO.eliminar(datos.id)
        cargarGridMarcas()
        limpiarTextInputsMarca()
    End Sub

    'boton nuevo registro
    Private Sub btnNuevoProducto_Click(sender As Object, e As EventArgs) Handles btnNuevoProducto.Click
        limpiarTextInputsProducto()
    End Sub
    'Final Producto ######################################################

#End Region

End Class
