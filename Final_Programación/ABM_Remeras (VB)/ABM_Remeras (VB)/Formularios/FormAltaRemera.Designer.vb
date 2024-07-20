<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaRemera
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lbl_descripcionCantidad = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Lbl_descripcionPromedio = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Dgv_listaRemeras = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_precioAlta = New System.Windows.Forms.TextBox()
        Me.Btn_AltaRemera = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cb_talleAlta = New System.Windows.Forms.ComboBox()
        Me.Txt_detalleAlta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_codigoAlta = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dgv_listaRemeras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lbl_descripcionCantidad)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Lbl_descripcionPromedio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 313)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 125)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion"
        '
        'Lbl_descripcionCantidad
        '
        Me.Lbl_descripcionCantidad.AutoSize = True
        Me.Lbl_descripcionCantidad.ForeColor = System.Drawing.Color.ForestGreen
        Me.Lbl_descripcionCantidad.Location = New System.Drawing.Point(209, 82)
        Me.Lbl_descripcionCantidad.Name = "Lbl_descripcionCantidad"
        Me.Lbl_descripcionCantidad.Size = New System.Drawing.Size(19, 20)
        Me.Lbl_descripcionCantidad.TabIndex = 10
        Me.Lbl_descripcionCantidad.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 82)
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
        'Dgv_listaRemeras
        '
        Me.Dgv_listaRemeras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_listaRemeras.Location = New System.Drawing.Point(410, 12)
        Me.Dgv_listaRemeras.Name = "Dgv_listaRemeras"
        Me.Dgv_listaRemeras.Size = New System.Drawing.Size(383, 426)
        Me.Dgv_listaRemeras.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_precioAlta)
        Me.GroupBox1.Controls.Add(Me.Btn_AltaRemera)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Cb_talleAlta)
        Me.GroupBox1.Controls.Add(Me.Txt_detalleAlta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txt_codigoAlta)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 295)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alta Remera"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Talle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Precio"
        '
        'Txt_precioAlta
        '
        Me.Txt_precioAlta.Location = New System.Drawing.Point(117, 136)
        Me.Txt_precioAlta.Name = "Txt_precioAlta"
        Me.Txt_precioAlta.Size = New System.Drawing.Size(186, 26)
        Me.Txt_precioAlta.TabIndex = 5
        '
        'Btn_AltaRemera
        '
        Me.Btn_AltaRemera.Location = New System.Drawing.Point(118, 232)
        Me.Btn_AltaRemera.Name = "Btn_AltaRemera"
        Me.Btn_AltaRemera.Size = New System.Drawing.Size(145, 45)
        Me.Btn_AltaRemera.TabIndex = 3
        Me.Btn_AltaRemera.Text = "Guardar"
        Me.Btn_AltaRemera.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Detalle"
        '
        'Cb_talleAlta
        '
        Me.Cb_talleAlta.FormattingEnabled = True
        Me.Cb_talleAlta.Items.AddRange(New Object() {"S", "M", "L", "XL"})
        Me.Cb_talleAlta.Location = New System.Drawing.Point(117, 186)
        Me.Cb_talleAlta.Name = "Cb_talleAlta"
        Me.Cb_talleAlta.Size = New System.Drawing.Size(73, 28)
        Me.Cb_talleAlta.TabIndex = 2
        Me.Cb_talleAlta.Text = "S"
        '
        'Txt_detalleAlta
        '
        Me.Txt_detalleAlta.Location = New System.Drawing.Point(117, 90)
        Me.Txt_detalleAlta.Name = "Txt_detalleAlta"
        Me.Txt_detalleAlta.Size = New System.Drawing.Size(186, 26)
        Me.Txt_detalleAlta.TabIndex = 3
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
        'Txt_codigoAlta
        '
        Me.Txt_codigoAlta.Location = New System.Drawing.Point(118, 44)
        Me.Txt_codigoAlta.Name = "Txt_codigoAlta"
        Me.Txt_codigoAlta.Size = New System.Drawing.Size(186, 26)
        Me.Txt_codigoAlta.TabIndex = 1
        '
        'FormAltaRemera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Dgv_listaRemeras)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormAltaRemera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta Remera"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Dgv_listaRemeras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Lbl_descripcionCantidad As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Lbl_descripcionPromedio As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Dgv_listaRemeras As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_precioAlta As TextBox
    Friend WithEvents Btn_AltaRemera As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Cb_talleAlta As ComboBox
    Friend WithEvents Txt_detalleAlta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_codigoAlta As TextBox
End Class
