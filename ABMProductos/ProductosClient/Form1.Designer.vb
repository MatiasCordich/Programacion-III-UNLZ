<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_agregarProducto = New System.Windows.Forms.Button()
        Me.txt_precioInsert = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_tipoInsert = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombreInsert = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lbl_Tipo = New System.Windows.Forms.Label()
        Me.lbl_Precio = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_buscarPorID = New System.Windows.Forms.Button()
        Me.txt_getByID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtGrid_productos = New System.Windows.Forms.DataGridView()
        Me.btn_listar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_idUpdate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_guardarCambios = New System.Windows.Forms.Button()
        Me.txt_precioUpdate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_tipoUpdate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nombreUpdate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.txt_idDelete = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dtGrid_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_agregarProducto)
        Me.GroupBox1.Controls.Add(Me.txt_precioInsert)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_tipoInsert)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_nombreInsert)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 214)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar"
        '
        'btn_agregarProducto
        '
        Me.btn_agregarProducto.Location = New System.Drawing.Point(10, 157)
        Me.btn_agregarProducto.Name = "btn_agregarProducto"
        Me.btn_agregarProducto.Size = New System.Drawing.Size(376, 44)
        Me.btn_agregarProducto.TabIndex = 10
        Me.btn_agregarProducto.Text = "Guardar"
        Me.btn_agregarProducto.UseVisualStyleBackColor = True
        '
        'txt_precioInsert
        '
        Me.txt_precioInsert.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precioInsert.Location = New System.Drawing.Point(103, 110)
        Me.txt_precioInsert.Name = "txt_precioInsert"
        Me.txt_precioInsert.Size = New System.Drawing.Size(283, 28)
        Me.txt_precioInsert.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Precio"
        '
        'txt_tipoInsert
        '
        Me.txt_tipoInsert.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tipoInsert.Location = New System.Drawing.Point(103, 76)
        Me.txt_tipoInsert.Name = "txt_tipoInsert"
        Me.txt_tipoInsert.Size = New System.Drawing.Size(283, 28)
        Me.txt_tipoInsert.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo"
        '
        'txt_nombreInsert
        '
        Me.txt_nombreInsert.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombreInsert.Location = New System.Drawing.Point(103, 42)
        Me.txt_nombreInsert.Name = "txt_nombreInsert"
        Me.txt_nombreInsert.Size = New System.Drawing.Size(283, 28)
        Me.txt_nombreInsert.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cascadia Code Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(609, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Distribuidora Go"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.btn_buscarPorID)
        Me.GroupBox4.Controls.Add(Me.txt_getByID)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(1090, 78)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(330, 578)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buscar"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lbl_Tipo)
        Me.GroupBox6.Controls.Add(Me.lbl_Precio)
        Me.GroupBox6.Controls.Add(Me.lbl_Nombre)
        Me.GroupBox6.Controls.Add(Me.lbl_ID)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Location = New System.Drawing.Point(25, 178)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(290, 391)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Resultado"
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.AutoSize = True
        Me.lbl_Tipo.Location = New System.Drawing.Point(119, 196)
        Me.lbl_Tipo.Name = "lbl_Tipo"
        Me.lbl_Tipo.Size = New System.Drawing.Size(18, 24)
        Me.lbl_Tipo.TabIndex = 9
        Me.lbl_Tipo.Text = "-"
        '
        'lbl_Precio
        '
        Me.lbl_Precio.AutoSize = True
        Me.lbl_Precio.Location = New System.Drawing.Point(119, 262)
        Me.lbl_Precio.Name = "lbl_Precio"
        Me.lbl_Precio.Size = New System.Drawing.Size(18, 24)
        Me.lbl_Precio.TabIndex = 8
        Me.lbl_Precio.Text = "-"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(130, 139)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(18, 24)
        Me.lbl_Nombre.TabIndex = 7
        Me.lbl_Nombre.Text = "-"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(62, 74)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(18, 24)
        Me.lbl_ID.TabIndex = 5
        Me.lbl_ID.Text = "-"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft PhagsPa", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 256)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 32)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Precio: "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft PhagsPa", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 188)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 32)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Tipo: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft PhagsPa", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 32)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Nombre: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft PhagsPa", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 32)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "ID: "
        '
        'btn_buscarPorID
        '
        Me.btn_buscarPorID.Location = New System.Drawing.Point(15, 92)
        Me.btn_buscarPorID.Name = "btn_buscarPorID"
        Me.btn_buscarPorID.Size = New System.Drawing.Size(309, 52)
        Me.btn_buscarPorID.TabIndex = 6
        Me.btn_buscarPorID.Text = "Buscar"
        Me.btn_buscarPorID.UseVisualStyleBackColor = True
        '
        'txt_getByID
        '
        Me.txt_getByID.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_getByID.Location = New System.Drawing.Point(44, 57)
        Me.txt_getByID.Name = "txt_getByID"
        Me.txt_getByID.Size = New System.Drawing.Size(280, 28)
        Me.txt_getByID.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 21)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "ID"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dtGrid_productos)
        Me.GroupBox5.Controls.Add(Me.btn_listar)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(420, 78)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(664, 728)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Listar"
        '
        'dtGrid_productos
        '
        Me.dtGrid_productos.AllowUserToAddRows = False
        Me.dtGrid_productos.AllowUserToDeleteRows = False
        Me.dtGrid_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid_productos.Location = New System.Drawing.Point(6, 92)
        Me.dtGrid_productos.Name = "dtGrid_productos"
        Me.dtGrid_productos.ReadOnly = True
        Me.dtGrid_productos.Size = New System.Drawing.Size(652, 630)
        Me.dtGrid_productos.TabIndex = 1
        '
        'btn_listar
        '
        Me.btn_listar.Location = New System.Drawing.Point(6, 31)
        Me.btn_listar.Name = "btn_listar"
        Me.btn_listar.Size = New System.Drawing.Size(161, 52)
        Me.btn_listar.TabIndex = 0
        Me.btn_listar.Text = "Listar"
        Me.btn_listar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_idUpdate)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.btn_guardarCambios)
        Me.GroupBox3.Controls.Add(Me.txt_precioUpdate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txt_tipoUpdate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_nombreUpdate)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 298)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(402, 268)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Editar"
        '
        'txt_idUpdate
        '
        Me.txt_idUpdate.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idUpdate.Location = New System.Drawing.Point(103, 51)
        Me.txt_idUpdate.Name = "txt_idUpdate"
        Me.txt_idUpdate.Size = New System.Drawing.Size(283, 28)
        Me.txt_idUpdate.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 21)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "ID"
        '
        'btn_guardarCambios
        '
        Me.btn_guardarCambios.Location = New System.Drawing.Point(10, 207)
        Me.btn_guardarCambios.Name = "btn_guardarCambios"
        Me.btn_guardarCambios.Size = New System.Drawing.Size(376, 44)
        Me.btn_guardarCambios.TabIndex = 10
        Me.btn_guardarCambios.Text = "Guardar cambios"
        Me.btn_guardarCambios.UseVisualStyleBackColor = True
        '
        'txt_precioUpdate
        '
        Me.txt_precioUpdate.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precioUpdate.Location = New System.Drawing.Point(103, 156)
        Me.txt_precioUpdate.Name = "txt_precioUpdate"
        Me.txt_precioUpdate.Size = New System.Drawing.Size(283, 28)
        Me.txt_precioUpdate.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 21)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Precio"
        '
        'txt_tipoUpdate
        '
        Me.txt_tipoUpdate.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tipoUpdate.Location = New System.Drawing.Point(103, 122)
        Me.txt_tipoUpdate.Name = "txt_tipoUpdate"
        Me.txt_tipoUpdate.Size = New System.Drawing.Size(283, 28)
        Me.txt_tipoUpdate.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tipo"
        '
        'txt_nombreUpdate
        '
        Me.txt_nombreUpdate.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombreUpdate.Location = New System.Drawing.Point(103, 88)
        Me.txt_nombreUpdate.Name = "txt_nombreUpdate"
        Me.txt_nombreUpdate.Size = New System.Drawing.Size(283, 28)
        Me.txt_nombreUpdate.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 21)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_eliminar)
        Me.GroupBox2.Controls.Add(Me.txt_idDelete)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 577)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 144)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Eliminar"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(6, 85)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(376, 44)
        Me.btn_eliminar.TabIndex = 10
        Me.btn_eliminar.Text = "Eliminar Producto"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'txt_idDelete
        '
        Me.txt_idDelete.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idDelete.Location = New System.Drawing.Point(39, 42)
        Me.txt_idDelete.Name = "txt_idDelete"
        Me.txt_idDelete.Size = New System.Drawing.Size(347, 28)
        Me.txt_idDelete.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 21)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "ID"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1434, 812)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dtGrid_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nombreInsert As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btn_agregarProducto As Button
    Friend WithEvents txt_precioInsert As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_tipoInsert As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_idUpdate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_guardarCambios As Button
    Friend WithEvents txt_precioUpdate As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_tipoUpdate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nombreUpdate As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents txt_idDelete As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btn_buscarPorID As Button
    Friend WithEvents txt_getByID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtGrid_productos As DataGridView
    Friend WithEvents btn_listar As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_Tipo As Label
    Friend WithEvents lbl_Precio As Label
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents lbl_ID As Label
End Class
