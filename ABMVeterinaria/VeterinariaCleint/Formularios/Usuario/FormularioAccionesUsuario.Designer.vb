<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAccionesUsuario
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
        Me.P_altaUsuario = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBL_nombreDescripcion = New System.Windows.Forms.Label()
        Me.LBL_idDescripcion = New System.Windows.Forms.Label()
        Me.LBL_descripcionEstado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_busquedaUsuario = New System.Windows.Forms.Button()
        Me.Txt_idUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_listaUsuarios = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txt_claveEditar = New System.Windows.Forms.TextBox()
        Me.Btn_editarUsuario = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_nombreEditar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_editarID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_listarUsuarios = New System.Windows.Forms.Button()
        Me.P_altaUsuario.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_listaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_altaUsuario
        '
        Me.P_altaUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_altaUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.P_altaUsuario.Controls.Add(Me.GroupBox1)
        Me.P_altaUsuario.Location = New System.Drawing.Point(-4, 12)
        Me.P_altaUsuario.Name = "P_altaUsuario"
        Me.P_altaUsuario.Size = New System.Drawing.Size(549, 205)
        Me.P_altaUsuario.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Btn_busquedaUsuario)
        Me.GroupBox1.Controls.Add(Me.Txt_idUsuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.LBL_nombreDescripcion)
        Me.GroupBox2.Controls.Add(Me.LBL_idDescripcion)
        Me.GroupBox2.Controls.Add(Me.LBL_descripcionEstado)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(261, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 125)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion"
        '
        'LBL_nombreDescripcion
        '
        Me.LBL_nombreDescripcion.AutoSize = True
        Me.LBL_nombreDescripcion.Location = New System.Drawing.Point(91, 53)
        Me.LBL_nombreDescripcion.Name = "LBL_nombreDescripcion"
        Me.LBL_nombreDescripcion.Size = New System.Drawing.Size(0, 18)
        Me.LBL_nombreDescripcion.TabIndex = 5
        '
        'LBL_idDescripcion
        '
        Me.LBL_idDescripcion.AutoSize = True
        Me.LBL_idDescripcion.Location = New System.Drawing.Point(97, 24)
        Me.LBL_idDescripcion.Name = "LBL_idDescripcion"
        Me.LBL_idDescripcion.Size = New System.Drawing.Size(0, 18)
        Me.LBL_idDescripcion.TabIndex = 4
        '
        'LBL_descripcionEstado
        '
        Me.LBL_descripcionEstado.AutoSize = True
        Me.LBL_descripcionEstado.Location = New System.Drawing.Point(72, 82)
        Me.LBL_descripcionEstado.Name = "LBL_descripcionEstado"
        Me.LBL_descripcionEstado.Size = New System.Drawing.Size(0, 18)
        Me.LBL_descripcionEstado.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 80)
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
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Usuario ID:"
        '
        'Btn_busquedaUsuario
        '
        Me.Btn_busquedaUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Btn_busquedaUsuario.FlatAppearance.BorderSize = 0
        Me.Btn_busquedaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_busquedaUsuario.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_busquedaUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_busquedaUsuario.Location = New System.Drawing.Point(28, 91)
        Me.Btn_busquedaUsuario.Name = "Btn_busquedaUsuario"
        Me.Btn_busquedaUsuario.Size = New System.Drawing.Size(216, 47)
        Me.Btn_busquedaUsuario.TabIndex = 4
        Me.Btn_busquedaUsuario.Text = "Buscar"
        Me.Btn_busquedaUsuario.UseVisualStyleBackColor = False
        '
        'Txt_idUsuario
        '
        Me.Txt_idUsuario.Location = New System.Drawing.Point(116, 41)
        Me.Txt_idUsuario.Name = "Txt_idUsuario"
        Me.Txt_idUsuario.Size = New System.Drawing.Size(128, 26)
        Me.Txt_idUsuario.TabIndex = 1
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
        'DGV_listaUsuarios
        '
        Me.DGV_listaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_listaUsuarios.Location = New System.Drawing.Point(567, 56)
        Me.DGV_listaUsuarios.Name = "DGV_listaUsuarios"
        Me.DGV_listaUsuarios.Size = New System.Drawing.Size(493, 415)
        Me.DGV_listaUsuarios.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Location = New System.Drawing.Point(-4, 223)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 248)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Txt_editarID)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(519, 191)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Editar Usuario"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Txt_claveEditar)
        Me.GroupBox4.Controls.Add(Me.Btn_editarUsuario)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Txt_nombreEditar)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(261, 25)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(239, 152)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Campos"
        '
        'Txt_claveEditar
        '
        Me.Txt_claveEditar.Location = New System.Drawing.Point(84, 62)
        Me.Txt_claveEditar.Name = "Txt_claveEditar"
        Me.Txt_claveEditar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_claveEditar.Size = New System.Drawing.Size(149, 26)
        Me.Txt_claveEditar.TabIndex = 8
        '
        'Btn_editarUsuario
        '
        Me.Btn_editarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Btn_editarUsuario.FlatAppearance.BorderSize = 0
        Me.Btn_editarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_editarUsuario.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_editarUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_editarUsuario.Location = New System.Drawing.Point(9, 94)
        Me.Btn_editarUsuario.Name = "Btn_editarUsuario"
        Me.Btn_editarUsuario.Size = New System.Drawing.Size(224, 47)
        Me.Btn_editarUsuario.TabIndex = 4
        Me.Btn_editarUsuario.Text = "Editar"
        Me.Btn_editarUsuario.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Clave:"
        '
        'Txt_nombreEditar
        '
        Me.Txt_nombreEditar.Location = New System.Drawing.Point(84, 30)
        Me.Txt_nombreEditar.Name = "Txt_nombreEditar"
        Me.Txt_nombreEditar.Size = New System.Drawing.Size(149, 26)
        Me.Txt_nombreEditar.TabIndex = 6
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
        'Txt_editarID
        '
        Me.Txt_editarID.Location = New System.Drawing.Point(116, 90)
        Me.Txt_editarID.Name = "Txt_editarID"
        Me.Txt_editarID.Size = New System.Drawing.Size(128, 26)
        Me.Txt_editarID.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Usuario ID:"
        '
        'Btn_listarUsuarios
        '
        Me.Btn_listarUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_listarUsuarios.FlatAppearance.BorderSize = 0
        Me.Btn_listarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_listarUsuarios.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_listarUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Btn_listarUsuarios.Location = New System.Drawing.Point(567, 12)
        Me.Btn_listarUsuarios.Name = "Btn_listarUsuarios"
        Me.Btn_listarUsuarios.Size = New System.Drawing.Size(155, 38)
        Me.Btn_listarUsuarios.TabIndex = 1
        Me.Btn_listarUsuarios.Text = "Listar Usuarios"
        Me.Btn_listarUsuarios.UseVisualStyleBackColor = False
        '
        'FormularioAccionesUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1072, 488)
        Me.Controls.Add(Me.Btn_listarUsuarios)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGV_listaUsuarios)
        Me.Controls.Add(Me.P_altaUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(50, 50)
        Me.MaximumSize = New System.Drawing.Size(1088, 527)
        Me.MinimumSize = New System.Drawing.Size(1088, 527)
        Me.Name = "FormularioAccionesUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acciones - Usuario"
        Me.P_altaUsuario.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV_listaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P_altaUsuario As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_busquedaUsuario As Button
    Friend WithEvents Txt_idUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DGV_listaUsuarios As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn_editarUsuario As Button
    Friend WithEvents Txt_editarID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_nombreEditar As TextBox
    Friend WithEvents Txt_claveEditar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Btn_listarUsuarios As Button
    Friend WithEvents LBL_descripcionEstado As Label
    Friend WithEvents LBL_nombreDescripcion As Label
    Friend WithEvents LBL_idDescripcion As Label
End Class
