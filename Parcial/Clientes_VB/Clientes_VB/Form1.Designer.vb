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
        Me.dtGrid_Cliente = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_Localidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Edad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbox_Plan = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_promedioEdad = New System.Windows.Forms.Label()
        Me.lbl_clientesBsAs = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_clienteJoven = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_clienteViejo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_Lite = New System.Windows.Forms.Label()
        Me.lbl_Pro = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_Basic = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_DNI = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_AgregarCliente = New System.Windows.Forms.Button()
        CType(Me.dtGrid_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtGrid_Cliente
        '
        Me.dtGrid_Cliente.AllowUserToAddRows = False
        Me.dtGrid_Cliente.AllowUserToDeleteRows = False
        Me.dtGrid_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid_Cliente.Location = New System.Drawing.Point(424, 12)
        Me.dtGrid_Cliente.Name = "dtGrid_Cliente"
        Me.dtGrid_Cliente.ReadOnly = True
        Me.dtGrid_Cliente.Size = New System.Drawing.Size(364, 426)
        Me.dtGrid_Cliente.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(79, 35)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(307, 20)
        Me.txt_Nombre.TabIndex = 2
        '
        'txt_Localidad
        '
        Me.txt_Localidad.Location = New System.Drawing.Point(91, 86)
        Me.txt_Localidad.Name = "txt_Localidad"
        Me.txt_Localidad.Size = New System.Drawing.Size(295, 20)
        Me.txt_Localidad.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellido"
        '
        'txt_Edad
        '
        Me.txt_Edad.Location = New System.Drawing.Point(91, 112)
        Me.txt_Edad.Name = "txt_Edad"
        Me.txt_Edad.Size = New System.Drawing.Size(295, 20)
        Me.txt_Edad.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Localidad"
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Location = New System.Drawing.Point(79, 61)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(307, 20)
        Me.txt_Apellido.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Edad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Plan"
        '
        'cmbox_Plan
        '
        Me.cmbox_Plan.FormattingEnabled = True
        Me.cmbox_Plan.Items.AddRange(New Object() {"Lite", "Basic", "Pro"})
        Me.cmbox_Plan.Location = New System.Drawing.Point(91, 138)
        Me.cmbox_Plan.Name = "cmbox_Plan"
        Me.cmbox_Plan.Size = New System.Drawing.Size(295, 21)
        Me.cmbox_Plan.TabIndex = 10
        Me.cmbox_Plan.Text = "Lite"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Promedio edad:"
        '
        'lbl_promedioEdad
        '
        Me.lbl_promedioEdad.AutoSize = True
        Me.lbl_promedioEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_promedioEdad.Location = New System.Drawing.Point(161, 260)
        Me.lbl_promedioEdad.Name = "lbl_promedioEdad"
        Me.lbl_promedioEdad.Size = New System.Drawing.Size(20, 24)
        Me.lbl_promedioEdad.TabIndex = 12
        Me.lbl_promedioEdad.Text = "0"
        '
        'lbl_clientesBsAs
        '
        Me.lbl_clientesBsAs.AutoSize = True
        Me.lbl_clientesBsAs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clientesBsAs.Location = New System.Drawing.Point(288, 284)
        Me.lbl_clientesBsAs.Name = "lbl_clientesBsAs"
        Me.lbl_clientesBsAs.Size = New System.Drawing.Size(20, 24)
        Me.lbl_clientesBsAs.TabIndex = 14
        Me.lbl_clientesBsAs.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 284)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(272, 24)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Cant. clientes de Buenos Aires:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(157, 24)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Cliente mas viejo:"
        '
        'lbl_clienteJoven
        '
        Me.lbl_clienteJoven.AutoSize = True
        Me.lbl_clienteJoven.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clienteJoven.Location = New System.Drawing.Point(173, 308)
        Me.lbl_clienteJoven.Name = "lbl_clienteJoven"
        Me.lbl_clienteJoven.Size = New System.Drawing.Size(16, 24)
        Me.lbl_clienteJoven.TabIndex = 18
        Me.lbl_clienteJoven.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 308)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(164, 24)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Cliente mas joven:"
        '
        'lbl_clienteViejo
        '
        Me.lbl_clienteViejo.AutoSize = True
        Me.lbl_clienteViejo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clienteViejo.Location = New System.Drawing.Point(173, 333)
        Me.lbl_clienteViejo.Name = "lbl_clienteViejo"
        Me.lbl_clienteViejo.Size = New System.Drawing.Size(16, 24)
        Me.lbl_clienteViejo.TabIndex = 19
        Me.lbl_clienteViejo.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(109, 368)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(189, 24)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Cantidad de Usuarios"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(22, 392)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 24)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "LITE"
        '
        'lbl_Lite
        '
        Me.lbl_Lite.AutoSize = True
        Me.lbl_Lite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Lite.Location = New System.Drawing.Point(35, 416)
        Me.lbl_Lite.Name = "lbl_Lite"
        Me.lbl_Lite.Size = New System.Drawing.Size(20, 24)
        Me.lbl_Lite.TabIndex = 22
        Me.lbl_Lite.Text = "0"
        '
        'lbl_Pro
        '
        Me.lbl_Pro.AutoSize = True
        Me.lbl_Pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pro.Location = New System.Drawing.Point(353, 416)
        Me.lbl_Pro.Name = "lbl_Pro"
        Me.lbl_Pro.Size = New System.Drawing.Size(20, 24)
        Me.lbl_Pro.TabIndex = 24
        Me.lbl_Pro.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(340, 392)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 24)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "PRO"
        '
        'lbl_Basic
        '
        Me.lbl_Basic.AutoSize = True
        Me.lbl_Basic.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Basic.Location = New System.Drawing.Point(196, 416)
        Me.lbl_Basic.Name = "lbl_Basic"
        Me.lbl_Basic.Size = New System.Drawing.Size(20, 24)
        Me.lbl_Basic.TabIndex = 26
        Me.lbl_Basic.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(177, 392)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 24)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "BASIC"
        '
        'txt_DNI
        '
        Me.txt_DNI.Location = New System.Drawing.Point(51, 12)
        Me.txt_DNI.Name = "txt_DNI"
        Me.txt_DNI.Size = New System.Drawing.Size(335, 20)
        Me.txt_DNI.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 18)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "DNI"
        '
        'btn_AgregarCliente
        '
        Me.btn_AgregarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AgregarCliente.Location = New System.Drawing.Point(12, 180)
        Me.btn_AgregarCliente.Name = "btn_AgregarCliente"
        Me.btn_AgregarCliente.Size = New System.Drawing.Size(374, 55)
        Me.btn_AgregarCliente.TabIndex = 29
        Me.btn_AgregarCliente.Text = "Agregar cliente"
        Me.btn_AgregarCliente.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_AgregarCliente)
        Me.Controls.Add(Me.txt_DNI)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_Basic)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lbl_Pro)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lbl_Lite)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_clienteViejo)
        Me.Controls.Add(Me.lbl_clienteJoven)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_clientesBsAs)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_promedioEdad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbox_Plan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_Apellido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Edad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Localidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtGrid_Cliente)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dtGrid_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtGrid_Cliente As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_Localidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Edad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Apellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbox_Plan As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_promedioEdad As Label
    Friend WithEvents lbl_clientesBsAs As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_clienteJoven As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_clienteViejo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbl_Lite As Label
    Friend WithEvents lbl_Pro As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbl_Basic As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_DNI As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_AgregarCliente As Button
End Class
