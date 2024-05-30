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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_litrosRojo = New System.Windows.Forms.Label()
        Me.lbl_litrosAzul = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.txt_litros = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_agregarPintura = New System.Windows.Forms.Button()
        Me.dtgrid_Pinturas = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dtgrid_Pinturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(430, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CODIGO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(417, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total litros pintura ROJA:"
        '
        'lbl_litrosRojo
        '
        Me.lbl_litrosRojo.AutoSize = True
        Me.lbl_litrosRojo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_litrosRojo.Location = New System.Drawing.Point(675, 376)
        Me.lbl_litrosRojo.Name = "lbl_litrosRojo"
        Me.lbl_litrosRojo.Size = New System.Drawing.Size(20, 24)
        Me.lbl_litrosRojo.TabIndex = 2
        Me.lbl_litrosRojo.Text = "0"
        '
        'lbl_litrosAzul
        '
        Me.lbl_litrosAzul.AutoSize = True
        Me.lbl_litrosAzul.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_litrosAzul.Location = New System.Drawing.Point(716, 409)
        Me.lbl_litrosAzul.Name = "lbl_litrosAzul"
        Me.lbl_litrosAzul.Size = New System.Drawing.Size(20, 24)
        Me.lbl_litrosAzul.TabIndex = 4
        Me.lbl_litrosAzul.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(417, 409)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(293, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Promedio litros pintura AZUL:"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(435, 115)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(320, 20)
        Me.txt_codigo.TabIndex = 5
        '
        'txt_litros
        '
        Me.txt_litros.Location = New System.Drawing.Point(435, 237)
        Me.txt_litros.Name = "txt_litros"
        Me.txt_litros.Size = New System.Drawing.Size(320, 20)
        Me.txt_litros.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(430, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "LITROS"
        '
        'txt_color
        '
        Me.txt_color.Location = New System.Drawing.Point(435, 175)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(320, 20)
        Me.txt_color.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(430, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 25)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "COLOR"
        '
        'btn_agregarPintura
        '
        Me.btn_agregarPintura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregarPintura.Location = New System.Drawing.Point(499, 286)
        Me.btn_agregarPintura.Name = "btn_agregarPintura"
        Me.btn_agregarPintura.Size = New System.Drawing.Size(170, 40)
        Me.btn_agregarPintura.TabIndex = 10
        Me.btn_agregarPintura.Text = "Agregar Pintura"
        Me.btn_agregarPintura.UseVisualStyleBackColor = True
        '
        'dtgrid_Pinturas
        '
        Me.dtgrid_Pinturas.AllowUserToAddRows = False
        Me.dtgrid_Pinturas.AllowUserToDeleteRows = False
        Me.dtgrid_Pinturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrid_Pinturas.Location = New System.Drawing.Point(12, 93)
        Me.dtgrid_Pinturas.Name = "dtgrid_Pinturas"
        Me.dtgrid_Pinturas.ReadOnly = True
        Me.dtgrid_Pinturas.Size = New System.Drawing.Size(384, 345)
        Me.dtgrid_Pinturas.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(235, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(321, 62)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "PINTURIQUIO"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtgrid_Pinturas)
        Me.Controls.Add(Me.btn_agregarPintura)
        Me.Controls.Add(Me.txt_color)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_litros)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.lbl_litrosAzul)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_litrosRojo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dtgrid_Pinturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_litrosRojo As Label
    Friend WithEvents lbl_litrosAzul As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents txt_litros As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_color As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_agregarPintura As Button
    Friend WithEvents dtgrid_Pinturas As DataGridView
    Friend WithEvents Label8 As Label
End Class
