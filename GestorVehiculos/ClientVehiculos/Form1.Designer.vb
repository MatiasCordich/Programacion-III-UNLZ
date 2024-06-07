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
        Me.btn_cargarDatos = New System.Windows.Forms.Button()
        Me.dataG_vehiculos = New System.Windows.Forms.DataGridView()
        Me.btn_mostrarDatos = New System.Windows.Forms.Button()
        Me.txt_patente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_velocidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_tipoID = New System.Windows.Forms.TextBox()
        CType(Me.dataG_vehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Concesionaria Tsuki"
        '
        'btn_cargarDatos
        '
        Me.btn_cargarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cargarDatos.Location = New System.Drawing.Point(39, 217)
        Me.btn_cargarDatos.Name = "btn_cargarDatos"
        Me.btn_cargarDatos.Size = New System.Drawing.Size(269, 64)
        Me.btn_cargarDatos.TabIndex = 1
        Me.btn_cargarDatos.Text = "Cargar"
        Me.btn_cargarDatos.UseVisualStyleBackColor = True
        '
        'dataG_vehiculos
        '
        Me.dataG_vehiculos.AllowUserToAddRows = False
        Me.dataG_vehiculos.AllowUserToDeleteRows = False
        Me.dataG_vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataG_vehiculos.Location = New System.Drawing.Point(342, 92)
        Me.dataG_vehiculos.Name = "dataG_vehiculos"
        Me.dataG_vehiculos.ReadOnly = True
        Me.dataG_vehiculos.Size = New System.Drawing.Size(446, 346)
        Me.dataG_vehiculos.TabIndex = 2
        '
        'btn_mostrarDatos
        '
        Me.btn_mostrarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mostrarDatos.Location = New System.Drawing.Point(477, 45)
        Me.btn_mostrarDatos.Name = "btn_mostrarDatos"
        Me.btn_mostrarDatos.Size = New System.Drawing.Size(204, 41)
        Me.btn_mostrarDatos.TabIndex = 3
        Me.btn_mostrarDatos.Text = "Mostrar Datos"
        Me.btn_mostrarDatos.UseVisualStyleBackColor = True
        '
        'txt_patente
        '
        Me.txt_patente.Location = New System.Drawing.Point(120, 97)
        Me.txt_patente.Name = "txt_patente"
        Me.txt_patente.Size = New System.Drawing.Size(188, 20)
        Me.txt_patente.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Patente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Velocidad"
        '
        'txt_velocidad
        '
        Me.txt_velocidad.Location = New System.Drawing.Point(141, 172)
        Me.txt_velocidad.Name = "txt_velocidad"
        Me.txt_velocidad.Size = New System.Drawing.Size(167, 20)
        Me.txt_velocidad.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tipo ID"
        '
        'txt_tipoID
        '
        Me.txt_tipoID.Location = New System.Drawing.Point(120, 134)
        Me.txt_tipoID.Name = "txt_tipoID"
        Me.txt_tipoID.Size = New System.Drawing.Size(188, 20)
        Me.txt_tipoID.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_tipoID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_velocidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_patente)
        Me.Controls.Add(Me.btn_mostrarDatos)
        Me.Controls.Add(Me.dataG_vehiculos)
        Me.Controls.Add(Me.btn_cargarDatos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dataG_vehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cargarDatos As Button
    Friend WithEvents dataG_vehiculos As DataGridView
    Friend WithEvents btn_mostrarDatos As Button
    Friend WithEvents txt_patente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_velocidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_tipoID As TextBox
End Class
