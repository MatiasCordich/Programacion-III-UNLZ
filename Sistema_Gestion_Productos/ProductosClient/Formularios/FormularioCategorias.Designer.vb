<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioCategorias
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_listarProductos = New System.Windows.Forms.Button()
        Me.DGV_listaProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_buscarProducto = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Lbl_cantidadProducto = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Lbl_estadoProducto = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Lbl_categoriaIDProducto = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Lbl_valorProducto = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lbl_descripcionProducto = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lbl_codigoProducto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_codigoProductoBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_editarProducto = New System.Windows.Forms.Button()
        Me.Txt_cantidadProductoEditar = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Txt_estadoProductoEditar = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Txt_categoriaProductoEditar = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Txt_valorProductoEditar = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Txt_descripcionProductoEditar = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txt_codigoProductoEditar = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txt_idProductoEditar = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_listaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Btn_listarProductos)
        Me.GroupBox3.Controls.Add(Me.DGV_listaProductos)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(320, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(719, 664)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Categorias"
        '
        'Btn_listarProductos
        '
        Me.Btn_listarProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_listarProductos.FlatAppearance.BorderSize = 0
        Me.Btn_listarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_listarProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_listarProductos.Location = New System.Drawing.Point(6, 30)
        Me.Btn_listarProductos.Name = "Btn_listarProductos"
        Me.Btn_listarProductos.Size = New System.Drawing.Size(219, 40)
        Me.Btn_listarProductos.TabIndex = 4
        Me.Btn_listarProductos.Text = "Listar"
        Me.Btn_listarProductos.UseVisualStyleBackColor = False
        '
        'DGV_listaProductos
        '
        Me.DGV_listaProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_listaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_listaProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_listaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_listaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_listaProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_listaProductos.Location = New System.Drawing.Point(6, 78)
        Me.DGV_listaProductos.Name = "DGV_listaProductos"
        Me.DGV_listaProductos.Size = New System.Drawing.Size(707, 580)
        Me.DGV_listaProductos.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_buscarProducto)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Txt_codigoProductoBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 337)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Categoria"
        '
        'Btn_buscarProducto
        '
        Me.Btn_buscarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_buscarProducto.FlatAppearance.BorderSize = 0
        Me.Btn_buscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_buscarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_buscarProducto.Location = New System.Drawing.Point(6, 62)
        Me.Btn_buscarProducto.Name = "Btn_buscarProducto"
        Me.Btn_buscarProducto.Size = New System.Drawing.Size(290, 40)
        Me.Btn_buscarProducto.TabIndex = 12
        Me.Btn_buscarProducto.Text = "Buscar"
        Me.Btn_buscarProducto.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Lbl_cantidadProducto)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Lbl_estadoProducto)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Lbl_categoriaIDProducto)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Lbl_valorProducto)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Lbl_descripcionProducto)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Lbl_codigoProducto)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(6, 108)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(290, 215)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resultado"
        '
        'Lbl_cantidadProducto
        '
        Me.Lbl_cantidadProducto.AutoSize = True
        Me.Lbl_cantidadProducto.Location = New System.Drawing.Point(124, 181)
        Me.Lbl_cantidadProducto.Name = "Lbl_cantidadProducto"
        Me.Lbl_cantidadProducto.Size = New System.Drawing.Size(0, 24)
        Me.Lbl_cantidadProducto.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(6, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 20)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Cantidad:"
        '
        'Lbl_estadoProducto
        '
        Me.Lbl_estadoProducto.AutoSize = True
        Me.Lbl_estadoProducto.Location = New System.Drawing.Point(124, 152)
        Me.Lbl_estadoProducto.Name = "Lbl_estadoProducto"
        Me.Lbl_estadoProducto.Size = New System.Drawing.Size(0, 24)
        Me.Lbl_estadoProducto.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(6, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Estado:"
        '
        'Lbl_categoriaIDProducto
        '
        Me.Lbl_categoriaIDProducto.AutoSize = True
        Me.Lbl_categoriaIDProducto.Location = New System.Drawing.Point(124, 123)
        Me.Lbl_categoriaIDProducto.Name = "Lbl_categoriaIDProducto"
        Me.Lbl_categoriaIDProducto.Size = New System.Drawing.Size(0, 24)
        Me.Lbl_categoriaIDProducto.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(6, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Categoria ID:"
        '
        'Lbl_valorProducto
        '
        Me.Lbl_valorProducto.AutoSize = True
        Me.Lbl_valorProducto.Location = New System.Drawing.Point(124, 94)
        Me.Lbl_valorProducto.Name = "Lbl_valorProducto"
        Me.Lbl_valorProducto.Size = New System.Drawing.Size(0, 24)
        Me.Lbl_valorProducto.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(6, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Valor:"
        '
        'Lbl_descripcionProducto
        '
        Me.Lbl_descripcionProducto.AutoSize = True
        Me.Lbl_descripcionProducto.Location = New System.Drawing.Point(124, 63)
        Me.Lbl_descripcionProducto.Name = "Lbl_descripcionProducto"
        Me.Lbl_descripcionProducto.Size = New System.Drawing.Size(0, 24)
        Me.Lbl_descripcionProducto.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(6, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Descripcion:"
        '
        'Lbl_codigoProducto
        '
        Me.Lbl_codigoProducto.AutoSize = True
        Me.Lbl_codigoProducto.Location = New System.Drawing.Point(124, 33)
        Me.Lbl_codigoProducto.Name = "Lbl_codigoProducto"
        Me.Lbl_codigoProducto.Size = New System.Drawing.Size(0, 24)
        Me.Lbl_codigoProducto.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(6, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo:"
        '
        'Txt_codigoProductoBuscar
        '
        Me.Txt_codigoProductoBuscar.Location = New System.Drawing.Point(46, 30)
        Me.Txt_codigoProductoBuscar.Name = "Txt_codigoProductoBuscar"
        Me.Txt_codigoProductoBuscar.Size = New System.Drawing.Size(250, 29)
        Me.Txt_codigoProductoBuscar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_editarProducto)
        Me.GroupBox2.Controls.Add(Me.Txt_cantidadProductoEditar)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Txt_estadoProductoEditar)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Txt_categoriaProductoEditar)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Txt_valorProductoEditar)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Txt_descripcionProductoEditar)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Txt_codigoProductoEditar)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Txt_idProductoEditar)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 355)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 321)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Editar Producto"
        '
        'Btn_editarProducto
        '
        Me.Btn_editarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_editarProducto.FlatAppearance.BorderSize = 0
        Me.Btn_editarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_editarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_editarProducto.Location = New System.Drawing.Point(9, 275)
        Me.Btn_editarProducto.Name = "Btn_editarProducto"
        Me.Btn_editarProducto.Size = New System.Drawing.Size(279, 40)
        Me.Btn_editarProducto.TabIndex = 16
        Me.Btn_editarProducto.Text = "Editar"
        Me.Btn_editarProducto.UseVisualStyleBackColor = False
        '
        'Txt_cantidadProductoEditar
        '
        Me.Txt_cantidadProductoEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txt_cantidadProductoEditar.Location = New System.Drawing.Point(116, 240)
        Me.Txt_cantidadProductoEditar.Name = "Txt_cantidadProductoEditar"
        Me.Txt_cantidadProductoEditar.Size = New System.Drawing.Size(171, 29)
        Me.Txt_cantidadProductoEditar.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(11, 246)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 20)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Cantidad"
        '
        'Txt_estadoProductoEditar
        '
        Me.Txt_estadoProductoEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txt_estadoProductoEditar.Location = New System.Drawing.Point(116, 205)
        Me.Txt_estadoProductoEditar.Name = "Txt_estadoProductoEditar"
        Me.Txt_estadoProductoEditar.Size = New System.Drawing.Size(171, 29)
        Me.Txt_estadoProductoEditar.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(12, 211)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 20)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Estado"
        '
        'Txt_categoriaProductoEditar
        '
        Me.Txt_categoriaProductoEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txt_categoriaProductoEditar.Location = New System.Drawing.Point(116, 170)
        Me.Txt_categoriaProductoEditar.Name = "Txt_categoriaProductoEditar"
        Me.Txt_categoriaProductoEditar.Size = New System.Drawing.Size(171, 29)
        Me.Txt_categoriaProductoEditar.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(11, 176)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 20)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Categoria"
        '
        'Txt_valorProductoEditar
        '
        Me.Txt_valorProductoEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txt_valorProductoEditar.Location = New System.Drawing.Point(116, 135)
        Me.Txt_valorProductoEditar.Name = "Txt_valorProductoEditar"
        Me.Txt_valorProductoEditar.Size = New System.Drawing.Size(171, 29)
        Me.Txt_valorProductoEditar.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(11, 144)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 20)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Valor"
        '
        'Txt_descripcionProductoEditar
        '
        Me.Txt_descripcionProductoEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txt_descripcionProductoEditar.Location = New System.Drawing.Point(116, 98)
        Me.Txt_descripcionProductoEditar.Name = "Txt_descripcionProductoEditar"
        Me.Txt_descripcionProductoEditar.Size = New System.Drawing.Size(171, 29)
        Me.Txt_descripcionProductoEditar.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(9, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 20)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Descripcion"
        '
        'Txt_codigoProductoEditar
        '
        Me.Txt_codigoProductoEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txt_codigoProductoEditar.Location = New System.Drawing.Point(117, 62)
        Me.Txt_codigoProductoEditar.Name = "Txt_codigoProductoEditar"
        Me.Txt_codigoProductoEditar.Size = New System.Drawing.Size(171, 29)
        Me.Txt_codigoProductoEditar.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(9, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 20)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Codigo"
        '
        'Txt_idProductoEditar
        '
        Me.Txt_idProductoEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txt_idProductoEditar.Location = New System.Drawing.Point(116, 28)
        Me.Txt_idProductoEditar.Name = "Txt_idProductoEditar"
        Me.Txt_idProductoEditar.Size = New System.Drawing.Size(171, 29)
        Me.Txt_idProductoEditar.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(12, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 20)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "ID"
        '
        'FormularioCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1051, 685)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormularioCategorias"
        Me.Text = "FormularioCategorias"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGV_listaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Btn_listarProductos As Button
    Friend WithEvents DGV_listaProductos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_buscarProducto As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Lbl_cantidadProducto As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Lbl_estadoProducto As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Lbl_categoriaIDProducto As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Lbl_valorProducto As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Lbl_descripcionProducto As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Lbl_codigoProducto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_codigoProductoBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_editarProducto As Button
    Friend WithEvents Txt_cantidadProductoEditar As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Txt_estadoProductoEditar As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Txt_categoriaProductoEditar As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Txt_valorProductoEditar As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Txt_descripcionProductoEditar As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Txt_codigoProductoEditar As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Txt_idProductoEditar As TextBox
    Friend WithEvents Label14 As Label
End Class
