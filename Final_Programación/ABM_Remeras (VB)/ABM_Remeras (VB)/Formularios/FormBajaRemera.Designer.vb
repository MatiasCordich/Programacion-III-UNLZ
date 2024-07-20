<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBajaRemera
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
        Me.Btn_bajaRemera = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_codigoBaja = New System.Windows.Forms.TextBox()
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
        Me.GroupBox2.Location = New System.Drawing.Point(17, 344)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(374, 94)
        Me.GroupBox2.TabIndex = 8
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
        Me.GroupBox1.Controls.Add(Me.Btn_bajaRemera)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txt_codigoBaja)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 191)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Baja Remera"
        '
        'Btn_bajaRemera
        '
        Me.Btn_bajaRemera.Location = New System.Drawing.Point(109, 115)
        Me.Btn_bajaRemera.Name = "Btn_bajaRemera"
        Me.Btn_bajaRemera.Size = New System.Drawing.Size(145, 45)
        Me.Btn_bajaRemera.TabIndex = 3
        Me.Btn_bajaRemera.Text = "Baja"
        Me.Btn_bajaRemera.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'Txt_codigoBaja
        '
        Me.Txt_codigoBaja.Location = New System.Drawing.Point(120, 63)
        Me.Txt_codigoBaja.Name = "Txt_codigoBaja"
        Me.Txt_codigoBaja.Size = New System.Drawing.Size(186, 26)
        Me.Txt_codigoBaja.TabIndex = 1
        '
        'FormBajaRemera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Dgv_listaRemeras)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormBajaRemera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja Remera"
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
    Friend WithEvents Btn_bajaRemera As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_codigoBaja As TextBox
End Class
