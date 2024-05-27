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
        Me.dataGrid_Articulos = New System.Windows.Forms.DataGridView()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_Precio = New System.Windows.Forms.TextBox()
        Me.lbl_Precio = New System.Windows.Forms.Label()
        Me.btn_Agregar_Producto = New System.Windows.Forms.Button()
        Me.lbl_totalR = New System.Windows.Forms.Label()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.lbl_total_titulo = New System.Windows.Forms.Label()
        Me.lbl_totalR_titulo = New System.Windows.Forms.Label()
        Me.lbl_Promedio_title = New System.Windows.Forms.Label()
        Me.lbl_Promedio = New System.Windows.Forms.Label()
        Me.lbl_PromedioT_Title = New System.Windows.Forms.Label()
        Me.lbl_PromedioR = New System.Windows.Forms.Label()
        CType(Me.dataGrid_Articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGrid_Articulos
        '
        Me.dataGrid_Articulos.AllowUserToAddRows = False
        Me.dataGrid_Articulos.AllowUserToDeleteRows = False
        Me.dataGrid_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid_Articulos.Location = New System.Drawing.Point(357, 32)
        Me.dataGrid_Articulos.Name = "dataGrid_Articulos"
        Me.dataGrid_Articulos.ReadOnly = True
        Me.dataGrid_Articulos.Size = New System.Drawing.Size(412, 406)
        Me.dataGrid_Articulos.TabIndex = 0
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.Location = New System.Drawing.Point(30, 60)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(87, 25)
        Me.lbl_Nombre.TabIndex = 1
        Me.lbl_Nombre.Text = "Nombre"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(123, 60)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_Nombre.TabIndex = 2
        '
        'txt_Precio
        '
        Me.txt_Precio.Location = New System.Drawing.Point(123, 109)
        Me.txt_Precio.Name = "txt_Precio"
        Me.txt_Precio.Size = New System.Drawing.Size(100, 20)
        Me.txt_Precio.TabIndex = 4
        '
        'lbl_Precio
        '
        Me.lbl_Precio.AutoSize = True
        Me.lbl_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Precio.Location = New System.Drawing.Point(30, 109)
        Me.lbl_Precio.Name = "lbl_Precio"
        Me.lbl_Precio.Size = New System.Drawing.Size(73, 25)
        Me.lbl_Precio.TabIndex = 3
        Me.lbl_Precio.Text = "Precio"
        '
        'btn_Agregar_Producto
        '
        Me.btn_Agregar_Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar_Producto.Location = New System.Drawing.Point(35, 161)
        Me.btn_Agregar_Producto.Name = "btn_Agregar_Producto"
        Me.btn_Agregar_Producto.Size = New System.Drawing.Size(232, 44)
        Me.btn_Agregar_Producto.TabIndex = 5
        Me.btn_Agregar_Producto.Text = "Agregar Producto"
        Me.btn_Agregar_Producto.UseVisualStyleBackColor = True
        '
        'lbl_totalR
        '
        Me.lbl_totalR.AutoSize = True
        Me.lbl_totalR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalR.Location = New System.Drawing.Point(223, 306)
        Me.lbl_totalR.Name = "lbl_totalR"
        Me.lbl_totalR.Size = New System.Drawing.Size(24, 25)
        Me.lbl_totalR.TabIndex = 6
        Me.lbl_totalR.Text = "0"
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(199, 252)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(24, 25)
        Me.lbl_Total.TabIndex = 7
        Me.lbl_Total.Text = "0"
        '
        'lbl_total_titulo
        '
        Me.lbl_total_titulo.AutoSize = True
        Me.lbl_total_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_titulo.Location = New System.Drawing.Point(10, 252)
        Me.lbl_total_titulo.Name = "lbl_total_titulo"
        Me.lbl_total_titulo.Size = New System.Drawing.Size(80, 33)
        Me.lbl_total_titulo.TabIndex = 8
        Me.lbl_total_titulo.Text = "Total"
        '
        'lbl_totalR_titulo
        '
        Me.lbl_totalR_titulo.AutoSize = True
        Me.lbl_totalR_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalR_titulo.Location = New System.Drawing.Point(12, 299)
        Me.lbl_totalR_titulo.Name = "lbl_totalR_titulo"
        Me.lbl_totalR_titulo.Size = New System.Drawing.Size(164, 33)
        Me.lbl_totalR_titulo.TabIndex = 9
        Me.lbl_totalR_titulo.Text = "Total con R"
        '
        'lbl_Promedio_title
        '
        Me.lbl_Promedio_title.AutoSize = True
        Me.lbl_Promedio_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Promedio_title.Location = New System.Drawing.Point(12, 348)
        Me.lbl_Promedio_title.Name = "lbl_Promedio_title"
        Me.lbl_Promedio_title.Size = New System.Drawing.Size(140, 33)
        Me.lbl_Promedio_title.TabIndex = 11
        Me.lbl_Promedio_title.Text = "Promedio"
        '
        'lbl_Promedio
        '
        Me.lbl_Promedio.AutoSize = True
        Me.lbl_Promedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Promedio.Location = New System.Drawing.Point(201, 348)
        Me.lbl_Promedio.Name = "lbl_Promedio"
        Me.lbl_Promedio.Size = New System.Drawing.Size(24, 25)
        Me.lbl_Promedio.TabIndex = 10
        Me.lbl_Promedio.Text = "0"
        '
        'lbl_PromedioT_Title
        '
        Me.lbl_PromedioT_Title.AutoSize = True
        Me.lbl_PromedioT_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PromedioT_Title.Location = New System.Drawing.Point(12, 394)
        Me.lbl_PromedioT_Title.Name = "lbl_PromedioT_Title"
        Me.lbl_PromedioT_Title.Size = New System.Drawing.Size(224, 33)
        Me.lbl_PromedioT_Title.TabIndex = 13
        Me.lbl_PromedioT_Title.Text = "Promedio con R"
        '
        'lbl_PromedioR
        '
        Me.lbl_PromedioR.AutoSize = True
        Me.lbl_PromedioR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PromedioR.Location = New System.Drawing.Point(259, 394)
        Me.lbl_PromedioR.Name = "lbl_PromedioR"
        Me.lbl_PromedioR.Size = New System.Drawing.Size(24, 25)
        Me.lbl_PromedioR.TabIndex = 12
        Me.lbl_PromedioR.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_PromedioT_Title)
        Me.Controls.Add(Me.lbl_PromedioR)
        Me.Controls.Add(Me.lbl_Promedio_title)
        Me.Controls.Add(Me.lbl_Promedio)
        Me.Controls.Add(Me.lbl_totalR_titulo)
        Me.Controls.Add(Me.lbl_total_titulo)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.lbl_totalR)
        Me.Controls.Add(Me.btn_Agregar_Producto)
        Me.Controls.Add(Me.txt_Precio)
        Me.Controls.Add(Me.lbl_Precio)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.dataGrid_Articulos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dataGrid_Articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataGrid_Articulos As DataGridView
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_Precio As TextBox
    Friend WithEvents lbl_Precio As Label
    Friend WithEvents btn_Agregar_Producto As Button
    Friend WithEvents lbl_totalR As Label
    Friend WithEvents lbl_Total As Label
    Friend WithEvents lbl_total_titulo As Label
    Friend WithEvents lbl_totalR_titulo As Label
    Friend WithEvents lbl_Promedio_title As Label
    Friend WithEvents lbl_Promedio As Label
    Friend WithEvents lbl_PromedioT_Title As Label
    Friend WithEvents lbl_PromedioR As Label
End Class
