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
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Data_grid_Personas = New System.Windows.Forms.DataGridView()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_Apellido = New System.Windows.Forms.Label()
        Me.txt_Apellidos = New System.Windows.Forms.TextBox()
        Me.btn_Agregar_2 = New System.Windows.Forms.Button()
        CType(Me.Data_grid_Personas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(442, 250)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(170, 49)
        Me.btn_agregar.TabIndex = 0
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'Data_grid_Personas
        '
        Me.Data_grid_Personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_grid_Personas.Location = New System.Drawing.Point(12, 12)
        Me.Data_grid_Personas.Name = "Data_grid_Personas"
        Me.Data_grid_Personas.Size = New System.Drawing.Size(362, 426)
        Me.Data_grid_Personas.TabIndex = 1
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(555, 83)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(135, 20)
        Me.txt_Nombre.TabIndex = 2
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.Location = New System.Drawing.Point(437, 77)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(87, 25)
        Me.lbl_Nombre.TabIndex = 3
        Me.lbl_Nombre.Text = "Nombre"
        '
        'lbl_Apellido
        '
        Me.lbl_Apellido.AutoSize = True
        Me.lbl_Apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Apellido.Location = New System.Drawing.Point(437, 126)
        Me.lbl_Apellido.Name = "lbl_Apellido"
        Me.lbl_Apellido.Size = New System.Drawing.Size(100, 25)
        Me.lbl_Apellido.TabIndex = 5
        Me.lbl_Apellido.Text = "Apellidos"
        '
        'txt_Apellidos
        '
        Me.txt_Apellidos.Location = New System.Drawing.Point(555, 132)
        Me.txt_Apellidos.Name = "txt_Apellidos"
        Me.txt_Apellidos.Size = New System.Drawing.Size(135, 20)
        Me.txt_Apellidos.TabIndex = 4
        '
        'btn_Agregar_2
        '
        Me.btn_Agregar_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar_2.Location = New System.Drawing.Point(442, 169)
        Me.btn_Agregar_2.Name = "btn_Agregar_2"
        Me.btn_Agregar_2.Size = New System.Drawing.Size(170, 48)
        Me.btn_Agregar_2.TabIndex = 6
        Me.btn_Agregar_2.Text = "Agregar Persona"
        Me.btn_Agregar_2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Agregar_2)
        Me.Controls.Add(Me.lbl_Apellido)
        Me.Controls.Add(Me.txt_Apellidos)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.Data_grid_Personas)
        Me.Controls.Add(Me.btn_agregar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Data_grid_Personas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_agregar As Button
    Friend WithEvents Data_grid_Personas As DataGridView
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents lbl_Apellido As Label
    Friend WithEvents txt_Apellidos As TextBox
    Friend WithEvents btn_Agregar_2 As Button
End Class
