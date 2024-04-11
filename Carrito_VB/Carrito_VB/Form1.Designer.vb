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
        Me.labelDescripcion = New System.Windows.Forms.Label()
        Me.labelPrecio = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.gridProductos = New System.Windows.Forms.DataGridView()
        Me.columnaDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.labelTotalTitulo = New System.Windows.Forms.Label()
        Me.labelTotalPrecio = New System.Windows.Forms.Label()
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelDescripcion
        '
        Me.labelDescripcion.AutoSize = True
        Me.labelDescripcion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDescripcion.Location = New System.Drawing.Point(12, 95)
        Me.labelDescripcion.Name = "labelDescripcion"
        Me.labelDescripcion.Size = New System.Drawing.Size(121, 24)
        Me.labelDescripcion.TabIndex = 0
        Me.labelDescripcion.Text = "Descripcion"
        '
        'labelPrecio
        '
        Me.labelPrecio.AutoSize = True
        Me.labelPrecio.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPrecio.Location = New System.Drawing.Point(12, 141)
        Me.labelPrecio.Name = "labelPrecio"
        Me.labelPrecio.Size = New System.Drawing.Size(71, 24)
        Me.labelPrecio.TabIndex = 1
        Me.labelPrecio.Text = "Precio"
        '
        'txtDetalle
        '
        Me.txtDetalle.Location = New System.Drawing.Point(139, 95)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(163, 20)
        Me.txtDetalle.TabIndex = 4
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(139, 141)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(163, 20)
        Me.txtPrecio.TabIndex = 5
        '
        'gridProductos
        '
        Me.gridProductos.AllowUserToAddRows = False
        Me.gridProductos.AllowUserToDeleteRows = False
        Me.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnaDetalle, Me.ColumnaPrecio})
        Me.gridProductos.Location = New System.Drawing.Point(333, 23)
        Me.gridProductos.Name = "gridProductos"
        Me.gridProductos.ReadOnly = True
        Me.gridProductos.Size = New System.Drawing.Size(455, 415)
        Me.gridProductos.TabIndex = 7
        '
        'columnaDetalle
        '
        Me.columnaDetalle.HeaderText = "Detalle"
        Me.columnaDetalle.Name = "columnaDetalle"
        Me.columnaDetalle.ReadOnly = True
        '
        'ColumnaPrecio
        '
        Me.ColumnaPrecio.HeaderText = "Precio"
        Me.ColumnaPrecio.Name = "ColumnaPrecio"
        Me.ColumnaPrecio.ReadOnly = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(83, 198)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(145, 53)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'labelTotalTitulo
        '
        Me.labelTotalTitulo.AutoSize = True
        Me.labelTotalTitulo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTotalTitulo.Location = New System.Drawing.Point(103, 311)
        Me.labelTotalTitulo.Name = "labelTotalTitulo"
        Me.labelTotalTitulo.Size = New System.Drawing.Size(54, 24)
        Me.labelTotalTitulo.TabIndex = 9
        Me.labelTotalTitulo.Text = "Total"
        '
        'labelTotalPrecio
        '
        Me.labelTotalPrecio.AutoSize = True
        Me.labelTotalPrecio.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTotalPrecio.Location = New System.Drawing.Point(163, 311)
        Me.labelTotalPrecio.Name = "labelTotalPrecio"
        Me.labelTotalPrecio.Size = New System.Drawing.Size(22, 24)
        Me.labelTotalPrecio.TabIndex = 10
        Me.labelTotalPrecio.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.labelTotalPrecio)
        Me.Controls.Add(Me.labelTotalTitulo)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.gridProductos)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.labelPrecio)
        Me.Controls.Add(Me.labelDescripcion)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelDescripcion As Label
    Friend WithEvents labelPrecio As Label
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents gridProductos As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents labelTotalTitulo As Label
    Friend WithEvents labelTotalPrecio As Label
    Friend WithEvents columnaDetalle As DataGridViewTextBoxColumn
    Friend WithEvents ColumnaPrecio As DataGridViewTextBoxColumn
End Class
