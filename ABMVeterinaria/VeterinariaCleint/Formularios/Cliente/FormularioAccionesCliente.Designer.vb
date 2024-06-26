<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAccionesCliente
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
        Me.Btn_listarClientes = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txt_dniEditarCliente = New System.Windows.Forms.TextBox()
        Me.Btn_editarCliente = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_nombreEditarCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_editarIDCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGV_listaClientes = New System.Windows.Forms.DataGridView()
        Me.P_altaUsuario = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBL_dniCliente = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBL_nombreDescripcionCliente = New System.Windows.Forms.Label()
        Me.LBL_idDescripcionCliente = New System.Windows.Forms.Label()
        Me.LBL_descripcionEstadoCliente = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_busquedaCliente = New System.Windows.Forms.Button()
        Me.Txt_idCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV_listaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_altaUsuario.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_listarClientes
        '
        Me.Btn_listarClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_listarClientes.FlatAppearance.BorderSize = 0
        Me.Btn_listarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_listarClientes.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_listarClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Btn_listarClientes.Location = New System.Drawing.Point(567, 15)
        Me.Btn_listarClientes.Name = "Btn_listarClientes"
        Me.Btn_listarClientes.Size = New System.Drawing.Size(155, 38)
        Me.Btn_listarClientes.TabIndex = 3
        Me.Btn_listarClientes.Text = "Listar Clientes"
        Me.Btn_listarClientes.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Location = New System.Drawing.Point(12, 226)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 248)
        Me.Panel1.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Txt_editarIDCliente)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(519, 211)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Editar Cliente"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Txt_dniEditarCliente)
        Me.GroupBox4.Controls.Add(Me.Btn_editarCliente)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Txt_nombreEditarCliente)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(261, 25)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(239, 152)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Campos"
        '
        'Txt_dniEditarCliente
        '
        Me.Txt_dniEditarCliente.Location = New System.Drawing.Point(84, 62)
        Me.Txt_dniEditarCliente.Name = "Txt_dniEditarCliente"
        Me.Txt_dniEditarCliente.Size = New System.Drawing.Size(149, 26)
        Me.Txt_dniEditarCliente.TabIndex = 8
        '
        'Btn_editarCliente
        '
        Me.Btn_editarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Btn_editarCliente.FlatAppearance.BorderSize = 0
        Me.Btn_editarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_editarCliente.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_editarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_editarCliente.Location = New System.Drawing.Point(9, 94)
        Me.Btn_editarCliente.Name = "Btn_editarCliente"
        Me.Btn_editarCliente.Size = New System.Drawing.Size(224, 47)
        Me.Btn_editarCliente.TabIndex = 4
        Me.Btn_editarCliente.Text = "Editar"
        Me.Btn_editarCliente.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "DNI:"
        '
        'Txt_nombreEditarCliente
        '
        Me.Txt_nombreEditarCliente.Location = New System.Drawing.Point(84, 30)
        Me.Txt_nombreEditarCliente.Name = "Txt_nombreEditarCliente"
        Me.Txt_nombreEditarCliente.Size = New System.Drawing.Size(149, 26)
        Me.Txt_nombreEditarCliente.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nombre:"
        '
        'Txt_editarIDCliente
        '
        Me.Txt_editarIDCliente.Location = New System.Drawing.Point(116, 90)
        Me.Txt_editarIDCliente.Name = "Txt_editarIDCliente"
        Me.Txt_editarIDCliente.Size = New System.Drawing.Size(128, 26)
        Me.Txt_editarIDCliente.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Cliente ID:"
        '
        'DGV_listaClientes
        '
        Me.DGV_listaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_listaClientes.Location = New System.Drawing.Point(567, 59)
        Me.DGV_listaClientes.Name = "DGV_listaClientes"
        Me.DGV_listaClientes.Size = New System.Drawing.Size(493, 415)
        Me.DGV_listaClientes.TabIndex = 4
        '
        'P_altaUsuario
        '
        Me.P_altaUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_altaUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.P_altaUsuario.Controls.Add(Me.GroupBox1)
        Me.P_altaUsuario.Location = New System.Drawing.Point(12, 15)
        Me.P_altaUsuario.Name = "P_altaUsuario"
        Me.P_altaUsuario.Size = New System.Drawing.Size(549, 205)
        Me.P_altaUsuario.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Btn_busquedaCliente)
        Me.GroupBox1.Controls.Add(Me.Txt_idCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.LBL_dniCliente)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.LBL_nombreDescripcionCliente)
        Me.GroupBox2.Controls.Add(Me.LBL_idDescripcionCliente)
        Me.GroupBox2.Controls.Add(Me.LBL_descripcionEstadoCliente)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(261, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 136)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion"
        '
        'LBL_dniCliente
        '
        Me.LBL_dniCliente.AutoSize = True
        Me.LBL_dniCliente.Location = New System.Drawing.Point(50, 77)
        Me.LBL_dniCliente.Name = "LBL_dniCliente"
        Me.LBL_dniCliente.Size = New System.Drawing.Size(0, 18)
        Me.LBL_dniCliente.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "DNI:"
        '
        'LBL_nombreDescripcionCliente
        '
        Me.LBL_nombreDescripcionCliente.AutoSize = True
        Me.LBL_nombreDescripcionCliente.Location = New System.Drawing.Point(91, 53)
        Me.LBL_nombreDescripcionCliente.Name = "LBL_nombreDescripcionCliente"
        Me.LBL_nombreDescripcionCliente.Size = New System.Drawing.Size(0, 18)
        Me.LBL_nombreDescripcionCliente.TabIndex = 5
        '
        'LBL_idDescripcionCliente
        '
        Me.LBL_idDescripcionCliente.AutoSize = True
        Me.LBL_idDescripcionCliente.Location = New System.Drawing.Point(97, 24)
        Me.LBL_idDescripcionCliente.Name = "LBL_idDescripcionCliente"
        Me.LBL_idDescripcionCliente.Size = New System.Drawing.Size(0, 18)
        Me.LBL_idDescripcionCliente.TabIndex = 4
        '
        'LBL_descripcionEstadoCliente
        '
        Me.LBL_descripcionEstadoCliente.AutoSize = True
        Me.LBL_descripcionEstadoCliente.Location = New System.Drawing.Point(72, 105)
        Me.LBL_descripcionEstadoCliente.Name = "LBL_descripcionEstadoCliente"
        Me.LBL_descripcionEstadoCliente.Size = New System.Drawing.Size(0, 18)
        Me.LBL_descripcionEstadoCliente.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Estado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cliente ID:"
        '
        'Btn_busquedaCliente
        '
        Me.Btn_busquedaCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Btn_busquedaCliente.FlatAppearance.BorderSize = 0
        Me.Btn_busquedaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_busquedaCliente.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_busquedaCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_busquedaCliente.Location = New System.Drawing.Point(28, 91)
        Me.Btn_busquedaCliente.Name = "Btn_busquedaCliente"
        Me.Btn_busquedaCliente.Size = New System.Drawing.Size(216, 47)
        Me.Btn_busquedaCliente.TabIndex = 4
        Me.Btn_busquedaCliente.Text = "Buscar"
        Me.Btn_busquedaCliente.UseVisualStyleBackColor = False
        '
        'Txt_idCliente
        '
        Me.Txt_idCliente.Location = New System.Drawing.Point(116, 41)
        Me.Txt_idCliente.Name = "Txt_idCliente"
        Me.Txt_idCliente.Size = New System.Drawing.Size(128, 26)
        Me.Txt_idCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario ID:"
        '
        'FormularioAccionesCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1072, 488)
        Me.Controls.Add(Me.Btn_listarClientes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGV_listaClientes)
        Me.Controls.Add(Me.P_altaUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(1088, 527)
        Me.MinimumSize = New System.Drawing.Size(1088, 527)
        Me.Name = "FormularioAccionesCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acciones - Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGV_listaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_altaUsuario.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_listarClientes As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Txt_dniEditarCliente As TextBox
    Friend WithEvents Btn_editarCliente As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_nombreEditarCliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_editarIDCliente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DGV_listaClientes As DataGridView
    Friend WithEvents P_altaUsuario As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LBL_nombreDescripcionCliente As Label
    Friend WithEvents LBL_idDescripcionCliente As Label
    Friend WithEvents LBL_descripcionEstadoCliente As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_busquedaCliente As Button
    Friend WithEvents Txt_idCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBL_dniCliente As Label
End Class
