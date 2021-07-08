<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cboProducto_Venta = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAgregarDetalleVenta = New System.Windows.Forms.Button()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.txtCantidadVenta = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnNuevoProducto = New System.Windows.Forms.Button()
        Me.cboProductoCategoria = New System.Windows.Forms.ComboBox()
        Me.cboProductoMarca = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPrecioProducto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnActualizarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.dgProducto = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnNuevaMarca = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombreMarca = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEliminarMarca = New System.Windows.Forms.Button()
        Me.btnActualizarMarca = New System.Windows.Forms.Button()
        Me.btnAgregarMarca = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigoMarca = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdMarca = New System.Windows.Forms.TextBox()
        Me.dgMarca = New System.Windows.Forms.DataGridView()
        Me.idMarca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnNuevaCategoria = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEliminarCategoria = New System.Windows.Forms.Button()
        Me.BtnActualizarCategoria = New System.Windows.Forms.Button()
        Me.btnAgregarCategoria = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcionCategoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdCategoria = New System.Windows.Forms.TextBox()
        Me.dgCategorias = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(753, 426)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Button3)
        Me.TabPage5.Controls.Add(Me.Label17)
        Me.TabPage5.Controls.Add(Me.DataGridView3)
        Me.TabPage5.Controls.Add(Me.Label16)
        Me.TabPage5.Controls.Add(Me.DataGridView2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(745, 400)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Listado Ventas"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(478, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label17.Location = New System.Drawing.Point(25, 260)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(144, 24)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Detalle de venta"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(29, 299)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.Size = New System.Drawing.Size(685, 82)
        Me.DataGridView3.TabIndex = 44
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label16.Location = New System.Drawing.Point(25, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(155, 24)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Listado de ventas"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(29, 62)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.Size = New System.Drawing.Size(685, 182)
        Me.DataGridView2.TabIndex = 42
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.cboProducto_Venta)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.btnAgregarDetalleVenta)
        Me.TabPage1.Controls.Add(Me.Cantidad)
        Me.TabPage1.Controls.Add(Me.txtCantidadVenta)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(745, 400)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar Venta"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(22, 56)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 13)
        Me.Label23.TabIndex = 61
        Me.Label23.Text = "Producto"
        '
        'cboProducto_Venta
        '
        Me.cboProducto_Venta.FormattingEnabled = True
        Me.cboProducto_Venta.Location = New System.Drawing.Point(25, 74)
        Me.cboProducto_Venta.Name = "cboProducto_Venta"
        Me.cboProducto_Venta.Size = New System.Drawing.Size(247, 21)
        Me.cboProducto_Venta.TabIndex = 60
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label21.Location = New System.Drawing.Point(26, 25)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(134, 24)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Registrar venta"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(111, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnAgregarDetalleVenta
        '
        Me.btnAgregarDetalleVenta.Location = New System.Drawing.Point(197, 144)
        Me.btnAgregarDetalleVenta.Name = "btnAgregarDetalleVenta"
        Me.btnAgregarDetalleVenta.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarDetalleVenta.TabIndex = 46
        Me.btnAgregarDetalleVenta.Text = "Agregar"
        Me.btnAgregarDetalleVenta.UseVisualStyleBackColor = True
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Location = New System.Drawing.Point(23, 98)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(49, 13)
        Me.Cantidad.TabIndex = 45
        Me.Cantidad.Text = "Cantidad"
        '
        'txtCantidadVenta
        '
        Me.txtCantidadVenta.Location = New System.Drawing.Point(26, 114)
        Me.txtCantidadVenta.Name = "txtCantidadVenta"
        Me.txtCantidadVenta.Size = New System.Drawing.Size(107, 20)
        Me.txtCantidadVenta.TabIndex = 44
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(310, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(409, 336)
        Me.DataGridView1.TabIndex = 41
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnNuevoProducto)
        Me.TabPage2.Controls.Add(Me.cboProductoCategoria)
        Me.TabPage2.Controls.Add(Me.cboProductoMarca)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtPrecioProducto)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtDescripcionProducto)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtNombreProducto)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.btnEliminarProducto)
        Me.TabPage2.Controls.Add(Me.btnActualizarProducto)
        Me.TabPage2.Controls.Add(Me.btnAgregarProducto)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtCodigoProducto)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtIdProducto)
        Me.TabPage2.Controls.Add(Me.dgProducto)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(745, 400)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Productos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnNuevoProducto
        '
        Me.btnNuevoProducto.Location = New System.Drawing.Point(308, 32)
        Me.btnNuevoProducto.Name = "btnNuevoProducto"
        Me.btnNuevoProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevoProducto.TabIndex = 43
        Me.btnNuevoProducto.Text = "Nuevo"
        Me.btnNuevoProducto.UseVisualStyleBackColor = True
        '
        'cboProductoCategoria
        '
        Me.cboProductoCategoria.FormattingEnabled = True
        Me.cboProductoCategoria.Location = New System.Drawing.Point(23, 317)
        Me.cboProductoCategoria.Name = "cboProductoCategoria"
        Me.cboProductoCategoria.Size = New System.Drawing.Size(247, 21)
        Me.cboProductoCategoria.TabIndex = 42
        '
        'cboProductoMarca
        '
        Me.cboProductoMarca.FormattingEnabled = True
        Me.cboProductoMarca.Location = New System.Drawing.Point(23, 278)
        Me.cboProductoMarca.Name = "cboProductoMarca"
        Me.cboProductoMarca.Size = New System.Drawing.Size(247, 21)
        Me.cboProductoMarca.TabIndex = 41
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 301)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Categoria"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 262)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Marca"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 219)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Precio"
        '
        'txtPrecioProducto
        '
        Me.txtPrecioProducto.Location = New System.Drawing.Point(24, 235)
        Me.txtPrecioProducto.Name = "txtPrecioProducto"
        Me.txtPrecioProducto.Size = New System.Drawing.Size(177, 20)
        Me.txtPrecioProducto.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Descripcion"
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(24, 193)
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(246, 20)
        Me.txtDescripcionProducto.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Nombre"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(24, 152)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(246, 20)
        Me.txtNombreProducto.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(24, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 24)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Productos"
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Location = New System.Drawing.Point(195, 360)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarProducto.TabIndex = 29
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnActualizarProducto
        '
        Me.btnActualizarProducto.Location = New System.Drawing.Point(109, 360)
        Me.btnActualizarProducto.Name = "btnActualizarProducto"
        Me.btnActualizarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizarProducto.TabIndex = 28
        Me.btnActualizarProducto.Text = "Actualizar"
        Me.btnActualizarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(23, 360)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarProducto.TabIndex = 27
        Me.btnAgregarProducto.Text = "Agregar"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Codigo"
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Location = New System.Drawing.Point(24, 114)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(246, 20)
        Me.txtCodigoProducto.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Id"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Enabled = False
        Me.txtIdProducto.Location = New System.Drawing.Point(24, 73)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(71, 20)
        Me.txtIdProducto.TabIndex = 23
        '
        'dgProducto
        '
        Me.dgProducto.AllowUserToAddRows = False
        Me.dgProducto.AllowUserToDeleteRows = False
        Me.dgProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProducto, Me.codigo_producto, Me.nombre_producto, Me.precio_producto, Me.marca_producto, Me.categoria_producto})
        Me.dgProducto.Location = New System.Drawing.Point(308, 73)
        Me.dgProducto.Name = "dgProducto"
        Me.dgProducto.ReadOnly = True
        Me.dgProducto.RowHeadersWidth = 51
        Me.dgProducto.Size = New System.Drawing.Size(409, 295)
        Me.dgProducto.TabIndex = 22
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnNuevaMarca)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.txtNombreMarca)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.btnEliminarMarca)
        Me.TabPage3.Controls.Add(Me.btnActualizarMarca)
        Me.TabPage3.Controls.Add(Me.btnAgregarMarca)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.txtCodigoMarca)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.txtIdMarca)
        Me.TabPage3.Controls.Add(Me.dgMarca)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(745, 400)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Marcas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnNuevaMarca
        '
        Me.btnNuevaMarca.Location = New System.Drawing.Point(308, 32)
        Me.btnNuevaMarca.Name = "btnNuevaMarca"
        Me.btnNuevaMarca.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevaMarca.TabIndex = 22
        Me.btnNuevaMarca.Text = "Nueva"
        Me.btnNuevaMarca.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Nombre"
        '
        'txtNombreMarca
        '
        Me.txtNombreMarca.Location = New System.Drawing.Point(32, 187)
        Me.txtNombreMarca.Name = "txtNombreMarca"
        Me.txtNombreMarca.Size = New System.Drawing.Size(250, 20)
        Me.txtNombreMarca.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(32, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 24)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Marca"
        '
        'btnEliminarMarca
        '
        Me.btnEliminarMarca.Location = New System.Drawing.Point(207, 232)
        Me.btnEliminarMarca.Name = "btnEliminarMarca"
        Me.btnEliminarMarca.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarMarca.TabIndex = 18
        Me.btnEliminarMarca.Text = "Eliminar"
        Me.btnEliminarMarca.UseVisualStyleBackColor = True
        '
        'btnActualizarMarca
        '
        Me.btnActualizarMarca.Location = New System.Drawing.Point(121, 232)
        Me.btnActualizarMarca.Name = "btnActualizarMarca"
        Me.btnActualizarMarca.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizarMarca.TabIndex = 17
        Me.btnActualizarMarca.Text = "Actualizar"
        Me.btnActualizarMarca.UseVisualStyleBackColor = True
        '
        'btnAgregarMarca
        '
        Me.btnAgregarMarca.Location = New System.Drawing.Point(32, 232)
        Me.btnAgregarMarca.Name = "btnAgregarMarca"
        Me.btnAgregarMarca.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarMarca.TabIndex = 16
        Me.btnAgregarMarca.Text = "Agregar"
        Me.btnAgregarMarca.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Codigo"
        '
        'txtCodigoMarca
        '
        Me.txtCodigoMarca.Location = New System.Drawing.Point(32, 135)
        Me.txtCodigoMarca.Name = "txtCodigoMarca"
        Me.txtCodigoMarca.Size = New System.Drawing.Size(250, 20)
        Me.txtCodigoMarca.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Id"
        '
        'txtIdMarca
        '
        Me.txtIdMarca.Enabled = False
        Me.txtIdMarca.Location = New System.Drawing.Point(32, 89)
        Me.txtIdMarca.Name = "txtIdMarca"
        Me.txtIdMarca.Size = New System.Drawing.Size(71, 20)
        Me.txtIdMarca.TabIndex = 12
        '
        'dgMarca
        '
        Me.dgMarca.AllowUserToAddRows = False
        Me.dgMarca.AllowUserToDeleteRows = False
        Me.dgMarca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMarca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMarca, Me.codigo_marca, Me.nombre_marca})
        Me.dgMarca.Location = New System.Drawing.Point(308, 64)
        Me.dgMarca.Name = "dgMarca"
        Me.dgMarca.ReadOnly = True
        Me.dgMarca.RowHeadersWidth = 51
        Me.dgMarca.Size = New System.Drawing.Size(409, 304)
        Me.dgMarca.TabIndex = 11
        '
        'idMarca
        '
        Me.idMarca.HeaderText = "Id"
        Me.idMarca.Name = "idMarca"
        Me.idMarca.ReadOnly = True
        '
        'codigo_marca
        '
        Me.codigo_marca.HeaderText = "Codigo Marca"
        Me.codigo_marca.Name = "codigo_marca"
        Me.codigo_marca.ReadOnly = True
        '
        'nombre_marca
        '
        Me.nombre_marca.HeaderText = "Nombre Marca"
        Me.nombre_marca.Name = "nombre_marca"
        Me.nombre_marca.ReadOnly = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnNuevaCategoria)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.btnEliminarCategoria)
        Me.TabPage4.Controls.Add(Me.BtnActualizarCategoria)
        Me.TabPage4.Controls.Add(Me.btnAgregarCategoria)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.txtDescripcionCategoria)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.txtIdCategoria)
        Me.TabPage4.Controls.Add(Me.dgCategorias)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(745, 400)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Categorias"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnNuevaCategoria
        '
        Me.btnNuevaCategoria.Location = New System.Drawing.Point(298, 19)
        Me.btnNuevaCategoria.Name = "btnNuevaCategoria"
        Me.btnNuevaCategoria.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevaCategoria.TabIndex = 11
        Me.btnNuevaCategoria.Text = "Nuevo"
        Me.btnNuevaCategoria.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(18, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Categorias"
        '
        'btnEliminarCategoria
        '
        Me.btnEliminarCategoria.Location = New System.Drawing.Point(197, 181)
        Me.btnEliminarCategoria.Name = "btnEliminarCategoria"
        Me.btnEliminarCategoria.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarCategoria.TabIndex = 9
        Me.btnEliminarCategoria.Text = "Eliminar"
        Me.btnEliminarCategoria.UseVisualStyleBackColor = True
        '
        'BtnActualizarCategoria
        '
        Me.BtnActualizarCategoria.Location = New System.Drawing.Point(111, 181)
        Me.BtnActualizarCategoria.Name = "BtnActualizarCategoria"
        Me.BtnActualizarCategoria.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizarCategoria.TabIndex = 8
        Me.BtnActualizarCategoria.Text = "Actualizar"
        Me.BtnActualizarCategoria.UseVisualStyleBackColor = True
        '
        'btnAgregarCategoria
        '
        Me.btnAgregarCategoria.Location = New System.Drawing.Point(18, 181)
        Me.btnAgregarCategoria.Name = "btnAgregarCategoria"
        Me.btnAgregarCategoria.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarCategoria.TabIndex = 7
        Me.btnAgregarCategoria.Text = "Agregar"
        Me.btnAgregarCategoria.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Descripcion"
        '
        'txtDescripcionCategoria
        '
        Me.txtDescripcionCategoria.Location = New System.Drawing.Point(18, 122)
        Me.txtDescripcionCategoria.Name = "txtDescripcionCategoria"
        Me.txtDescripcionCategoria.Size = New System.Drawing.Size(250, 20)
        Me.txtDescripcionCategoria.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Id"
        '
        'txtIdCategoria
        '
        Me.txtIdCategoria.Enabled = False
        Me.txtIdCategoria.Location = New System.Drawing.Point(18, 76)
        Me.txtIdCategoria.Name = "txtIdCategoria"
        Me.txtIdCategoria.Size = New System.Drawing.Size(71, 20)
        Me.txtIdCategoria.TabIndex = 3
        '
        'dgCategorias
        '
        Me.dgCategorias.AllowUserToAddRows = False
        Me.dgCategorias.AllowUserToDeleteRows = False
        Me.dgCategorias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCategorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.descripcion})
        Me.dgCategorias.Location = New System.Drawing.Point(298, 60)
        Me.dgCategorias.Name = "dgCategorias"
        Me.dgCategorias.ReadOnly = True
        Me.dgCategorias.RowHeadersWidth = 51
        Me.dgCategorias.Size = New System.Drawing.Size(409, 295)
        Me.dgCategorias.TabIndex = 2
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'idProducto
        '
        Me.idProducto.HeaderText = "Id"
        Me.idProducto.Name = "idProducto"
        Me.idProducto.ReadOnly = True
        '
        'codigo_producto
        '
        Me.codigo_producto.HeaderText = "Codigo"
        Me.codigo_producto.Name = "codigo_producto"
        Me.codigo_producto.ReadOnly = True
        '
        'nombre_producto
        '
        Me.nombre_producto.HeaderText = "Nombre"
        Me.nombre_producto.Name = "nombre_producto"
        Me.nombre_producto.ReadOnly = True
        '
        'precio_producto
        '
        Me.precio_producto.HeaderText = "Precio"
        Me.precio_producto.Name = "precio_producto"
        Me.precio_producto.ReadOnly = True
        '
        'marca_producto
        '
        Me.marca_producto.HeaderText = "Marca"
        Me.marca_producto.Name = "marca_producto"
        Me.marca_producto.ReadOnly = True
        '
        'categoria_producto
        '
        Me.categoria_producto.HeaderText = "Categoria"
        Me.categoria_producto.Name = "categoria_producto"
        Me.categoria_producto.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dgCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgCategorias As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdCategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescripcionCategoria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEliminarCategoria As Button
    Friend WithEvents BtnActualizarCategoria As Button
    Friend WithEvents btnAgregarCategoria As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEliminarMarca As Button
    Friend WithEvents btnActualizarMarca As Button
    Friend WithEvents btnAgregarMarca As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodigoMarca As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIdMarca As TextBox
    Friend WithEvents dgMarca As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombreMarca As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnActualizarProducto As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents dgProducto As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDescripcionProducto As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPrecioProducto As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAgregarDetalleVenta As Button
    Friend WithEvents Cantidad As Label
    Friend WithEvents txtCantidadVenta As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label23 As Label
    Friend WithEvents cboProducto_Venta As ComboBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents btnNuevaCategoria As Button
    Friend WithEvents btnNuevaMarca As Button
    Friend WithEvents idMarca As DataGridViewTextBoxColumn
    Friend WithEvents codigo_marca As DataGridViewTextBoxColumn
    Friend WithEvents nombre_marca As DataGridViewTextBoxColumn
    Friend WithEvents cboProductoCategoria As ComboBox
    Friend WithEvents cboProductoMarca As ComboBox
    Friend WithEvents btnNuevoProducto As Button
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents codigo_producto As DataGridViewTextBoxColumn
    Friend WithEvents nombre_producto As DataGridViewTextBoxColumn
    Friend WithEvents precio_producto As DataGridViewTextBoxColumn
    Friend WithEvents marca_producto As DataGridViewTextBoxColumn
    Friend WithEvents categoria_producto As DataGridViewTextBoxColumn
End Class
