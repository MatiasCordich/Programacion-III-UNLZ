<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarRemera
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_codigoEditar = New System.Windows.Forms.TextBox()
        Me.Cb_talleEditar = New System.Windows.Forms.ComboBox()
        Me.Btn_editarRemera = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_precioEditar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_detalleEditar = New System.Windows.Forms.TextBox()
        Me.Dgv_listaRemeras = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lbl_descripcionCantidad = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Lbl_descripcionPromedio = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgv_listaRemeras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'Txt_codigoEditar
        '
        Me.Txt_codigoEditar.Location = New System.Drawing.Point(118, 44)
        Me.Txt_codigoEditar.Name = "Txt_codigoEditar"
        Me.Txt_codigoEditar.Size = New System.Drawing.Size(186, 26)
        Me.Txt_codigoEditar.TabIndex = 1
        '
        'Cb_talleEditar
        '
        Me.Cb_talleEditar.FormattingEnabled = True
        Me.Cb_talleEditar.Items.AddRange(New Object() {"S", "M", "L", "XL"})
        Me.Cb_talleEditar.Location = New System.Drawing.Point(118, 223)
        Me.Cb_talleEditar.Name = "Cb_talleEditar"
        Me.Cb_talleEditar.Size = New System.Drawing.Size(73, 28)
        Me.Cb_talleEditar.TabIndex = 2
        Me.Cb_talleEditar.Text = "S"
        '
        'Btn_editarRemera
        '
        Me.Btn_editarRemera.Location = New System.Drawing.Point(118, 266)
        Me.Btn_editarRemera.Name = "Btn_editarRemera"
        Me.Btn_editarRemera.Size = New System.Drawing.Size(145, 45)
        Me.Btn_editarRemera.TabIndex = 3
        Me.Btn_editarRemera.Text = "Guardar"
        Me.Btn_editarRemera.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_precioEditar)
        Me.GroupBox1.Controls.Add(Me.Btn_editarRemera)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Cb_talleEditar)
        Me.GroupBox1.Controls.Add(Me.Txt_detalleEditar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txt_codigoEditar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 326)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Editar Remera"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Talle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Precio"
        '
        'Txt_precioEditar
        '
        Me.Txt_precioEditar.Location = New System.Drawing.Point(118, 173)
        Me.Txt_precioEditar.Name = "Txt_precioEditar"
        Me.Txt_precioEditar.Size = New System.Drawing.Size(186, 26)
        Me.Txt_precioEditar.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Detalle"
        '
        'Txt_detalleEditar
        '
        Me.Txt_detalleEditar.Location = New System.Drawing.Point(118, 127)
        Me.Txt_detalleEditar.Name = "Txt_detalleEditar"
        Me.Txt_detalleEditar.Size = New System.Drawing.Size(186, 26)
        Me.Txt_detalleEditar.TabIndex = 3
        '
        'Dgv_listaRemeras
        '
        Me.Dgv_listaRemeras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_listaRemeras.Location = New System.Drawing.Point(405, 12)
        Me.Dgv_listaRemeras.Name = "Dgv_listaRemeras"
        Me.Dgv_listaRemeras.Size = New System.Drawing.Size(383, 426)
        Me.Dgv_listaRemeras.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lbl_descripcionCantidad)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Lbl_descripcionPromedio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 344)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(374, 94)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion"
        '
        'Lbl_descripcionCantidad
        '
        Me.Lbl_descripcionCantidad.AutoSize = True
        Me.Lbl_descripcionCantidad.ForeColor = System.Drawing.Color.ForestGreen
        Me.Lbl_descripcionCantidad.Location = New System.Drawing.Point(209, 67)
        Me.Lbl_descripcionCantidad.Name = "Lbl_descripcionCantidad"
        Me.Lbl_descripcionCantidad.Size = New System.Drawing.Size(19, 20)
        Me.Lbl_descripcionCantidad.TabIndex = 10
        Me.Lbl_descripcionCantidad.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Cantidad talle XL:"
        '
        'Lbl_descripcionPromedio
        '
        Me.Lbl_descripcionPromedio.AutoSize = True
        Me.Lbl_descripcionPromedio.ForeColor = System.Drawing.Color.ForestGreen
        Me.Lbl_descripcionPromedio.Location = New System.Drawing.Point(209, 38)
        Me.Lbl_descripcionPromedio.Name = "Lbl_descripcionPromedio"
        Me.Lbl_descripcionPromedio.Size = New System.Drawing.Size(19, 20)
        Me.Lbl_descripcionPromedio.TabIndex = 8
        Me.Lbl_descripcionPromedio.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Precio promedio talle L:"
        '
        'FormEditarRemera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Dgv_listaRemeras)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormEditarRemera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Remera"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dgv_listaRemeras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_codigoEditar As TextBox
    Friend WithEvents Cb_talleEditar As ComboBox
    Friend WithEvents Btn_editarRemera As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Dgv_listaRemeras As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_precioEditar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_detalleEditar As TextBox
    Friend WithEvents Lbl_descripcionPromedio As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Lbl_descripcionCantidad As Label
    Friend WithEvents Label8 As Label
End Class
