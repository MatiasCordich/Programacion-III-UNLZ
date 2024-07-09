<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioProductos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_buscarCategoria = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Lbl_nombreCategoria = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lbl_idCategoria = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_idCategoriaBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_editarCategoria = New System.Windows.Forms.Button()
        Me.Txt_nombreCategoriaEditar = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txt_idCategoriaEditar = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_listarCategorias = New System.Windows.Forms.Button()
        Me.DGV_listaProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_listaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_buscarCategoria)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Txt_idCategoriaBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Producto"
        '
        'Btn_buscarCategoria
        '
        Me.Btn_buscarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_buscarCategoria.FlatAppearance.BorderSize = 0
        Me.Btn_buscarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_buscarCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_buscarCategoria.Location = New System.Drawing.Point(6, 62)
        Me.Btn_buscarCategoria.Name = "Btn_buscarCategoria"
        Me.Btn_buscarCategoria.Size = New System.Drawing.Size(290, 40)
        Me.Btn_buscarCategoria.TabIndex = 12
        Me.Btn_buscarCategoria.Text = "Buscar"
        Me.Btn_buscarCategoria.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Lbl_nombreCategoria)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Lbl_idCategoria)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(6, 108)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(290, 101)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resultado"
        '
        'Lbl_nombreCategoria
        '
        Me.Lbl_nombreCategoria.AutoSize = True
        Me.Lbl_nombreCategoria.Location = New System.Drawing.Point(92, 63)
        Me.Lbl_nombreCategoria.Name = "Lbl_nombreCategoria"
        Me.Lbl_nombreCategoria.Size = New System.Drawing.Size(0, 24)
        Me.Lbl_nombreCategoria.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(6, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nombre:"
        '
        'Lbl_idCategoria
        '
        Me.Lbl_idCategoria.AutoSize = True
        Me.Lbl_idCategoria.Location = New System.Drawing.Point(92, 33)
        Me.Lbl_idCategoria.Name = "Lbl_idCategoria"
        Me.Lbl_idCategoria.Size = New System.Drawing.Size(0, 24)
        Me.Lbl_idCategoria.TabIndex = 1
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
        'Txt_idCategoriaBuscar
        '
        Me.Txt_idCategoriaBuscar.Location = New System.Drawing.Point(88, 30)
        Me.Txt_idCategoriaBuscar.Name = "Txt_idCategoriaBuscar"
        Me.Txt_idCategoriaBuscar.Size = New System.Drawing.Size(208, 29)
        Me.Txt_idCategoriaBuscar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(11, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_editarCategoria)
        Me.GroupBox2.Controls.Add(Me.Txt_nombreCategoriaEditar)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Txt_idCategoriaEditar)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 238)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 149)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Editar Producto"
        '
        'Btn_editarCategoria
        '
        Me.Btn_editarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_editarCategoria.FlatAppearance.BorderSize = 0
        Me.Btn_editarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_editarCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_editarCategoria.Location = New System.Drawing.Point(9, 97)
        Me.Btn_editarCategoria.Name = "Btn_editarCategoria"
        Me.Btn_editarCategoria.Size = New System.Drawing.Size(279, 40)
        Me.Btn_editarCategoria.TabIndex = 16
        Me.Btn_editarCategoria.Text = "Editar"
        Me.Btn_editarCategoria.UseVisualStyleBackColor = False
        '
        'Txt_nombreCategoriaEditar
        '
        Me.Txt_nombreCategoriaEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txt_nombreCategoriaEditar.Location = New System.Drawing.Point(117, 62)
        Me.Txt_nombreCategoriaEditar.Name = "Txt_nombreCategoriaEditar"
        Me.Txt_nombreCategoriaEditar.Size = New System.Drawing.Size(171, 29)
        Me.Txt_nombreCategoriaEditar.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(9, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 20)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Nombre"
        '
        'Txt_idCategoriaEditar
        '
        Me.Txt_idCategoriaEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txt_idCategoriaEditar.Location = New System.Drawing.Point(116, 28)
        Me.Txt_idCategoriaEditar.Name = "Txt_idCategoriaEditar"
        Me.Txt_idCategoriaEditar.Size = New System.Drawing.Size(171, 29)
        Me.Txt_idCategoriaEditar.TabIndex = 3
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
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Btn_listarCategorias)
        Me.GroupBox3.Controls.Add(Me.DGV_listaProductos)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(320, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(719, 664)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Productos"
        '
        'Btn_listarCategorias
        '
        Me.Btn_listarCategorias.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_listarCategorias.FlatAppearance.BorderSize = 0
        Me.Btn_listarCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_listarCategorias.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_listarCategorias.Location = New System.Drawing.Point(6, 30)
        Me.Btn_listarCategorias.Name = "Btn_listarCategorias"
        Me.Btn_listarCategorias.Size = New System.Drawing.Size(219, 40)
        Me.Btn_listarCategorias.TabIndex = 4
        Me.Btn_listarCategorias.Text = "Listar"
        Me.Btn_listarCategorias.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_listaProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_listaProductos.Location = New System.Drawing.Point(6, 78)
        Me.DGV_listaProductos.Name = "DGV_listaProductos"
        Me.DGV_listaProductos.Size = New System.Drawing.Size(707, 580)
        Me.DGV_listaProductos.TabIndex = 0
        '
        'FormularioProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1051, 685)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormularioProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGV_listaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGV_listaProductos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_idCategoriaBuscar As TextBox
    Friend WithEvents Lbl_nombreCategoria As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Lbl_idCategoria As Label
    Friend WithEvents Txt_idCategoriaEditar As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Txt_nombreCategoriaEditar As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Btn_listarCategorias As Button
    Friend WithEvents Btn_buscarCategoria As Button
    Friend WithEvents Btn_editarCategoria As Button
End Class
