<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAccionesAnimal
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
        Me.Btn_listarAnimales = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txt_especieIDEditar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txt_clienteDNIEditar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_pesoEditar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_edadEditar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_nombreEditar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_editarAnimalID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_editarAnimal = New System.Windows.Forms.Button()
        Me.DGV_listaAnimales = New System.Windows.Forms.DataGridView()
        Me.P_altaUsuario = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBL_estadoAnimal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LBL_clienteID = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LBL_pesoAnimal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LBL_edadAnimal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBL_nombreAnimal = New System.Windows.Forms.Label()
        Me.LBL_idAnimal = New System.Windows.Forms.Label()
        Me.LBL_especieAnimal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_busquedaAnimal = New System.Windows.Forms.Button()
        Me.Txt_idAnimal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV_listaAnimales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_altaUsuario.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_listarAnimales
        '
        Me.Btn_listarAnimales.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_listarAnimales.FlatAppearance.BorderSize = 0
        Me.Btn_listarAnimales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_listarAnimales.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_listarAnimales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Btn_listarAnimales.Location = New System.Drawing.Point(567, 15)
        Me.Btn_listarAnimales.Name = "Btn_listarAnimales"
        Me.Btn_listarAnimales.Size = New System.Drawing.Size(155, 38)
        Me.Btn_listarAnimales.TabIndex = 3
        Me.Btn_listarAnimales.Text = "Listar Animales"
        Me.Btn_listarAnimales.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Location = New System.Drawing.Point(12, 329)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 264)
        Me.Panel1.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Txt_editarAnimalID)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Btn_editarAnimal)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(519, 232)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Editar Animal"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Txt_especieIDEditar)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Txt_clienteDNIEditar)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Txt_pesoEditar)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Txt_edadEditar)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Txt_nombreEditar)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(20, 77)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(480, 138)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Campos"
        '
        'Txt_especieIDEditar
        '
        Me.Txt_especieIDEditar.Location = New System.Drawing.Point(338, 70)
        Me.Txt_especieIDEditar.Name = "Txt_especieIDEditar"
        Me.Txt_especieIDEditar.Size = New System.Drawing.Size(137, 26)
        Me.Txt_especieIDEditar.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(243, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 18)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Especie ID:"
        '
        'Txt_clienteDNIEditar
        '
        Me.Txt_clienteDNIEditar.Location = New System.Drawing.Point(338, 38)
        Me.Txt_clienteDNIEditar.Name = "Txt_clienteDNIEditar"
        Me.Txt_clienteDNIEditar.Size = New System.Drawing.Size(137, 26)
        Me.Txt_clienteDNIEditar.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(242, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 18)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Cliente DNI:"
        '
        'Txt_pesoEditar
        '
        Me.Txt_pesoEditar.Location = New System.Drawing.Point(96, 103)
        Me.Txt_pesoEditar.Name = "Txt_pesoEditar"
        Me.Txt_pesoEditar.Size = New System.Drawing.Size(137, 26)
        Me.Txt_pesoEditar.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Peso:"
        '
        'Txt_edadEditar
        '
        Me.Txt_edadEditar.Location = New System.Drawing.Point(96, 71)
        Me.Txt_edadEditar.Name = "Txt_edadEditar"
        Me.Txt_edadEditar.Size = New System.Drawing.Size(137, 26)
        Me.Txt_edadEditar.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Edad:"
        '
        'Txt_nombreEditar
        '
        Me.Txt_nombreEditar.Location = New System.Drawing.Point(96, 39)
        Me.Txt_nombreEditar.Name = "Txt_nombreEditar"
        Me.Txt_nombreEditar.Size = New System.Drawing.Size(137, 26)
        Me.Txt_nombreEditar.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nombre:"
        '
        'Txt_editarAnimalID
        '
        Me.Txt_editarAnimalID.Location = New System.Drawing.Point(119, 37)
        Me.Txt_editarAnimalID.Name = "Txt_editarAnimalID"
        Me.Txt_editarAnimalID.Size = New System.Drawing.Size(128, 26)
        Me.Txt_editarAnimalID.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Animal ID:"
        '
        'Btn_editarAnimal
        '
        Me.Btn_editarAnimal.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Btn_editarAnimal.FlatAppearance.BorderSize = 0
        Me.Btn_editarAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_editarAnimal.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_editarAnimal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_editarAnimal.Location = New System.Drawing.Point(271, 25)
        Me.Btn_editarAnimal.Name = "Btn_editarAnimal"
        Me.Btn_editarAnimal.Size = New System.Drawing.Size(224, 47)
        Me.Btn_editarAnimal.TabIndex = 4
        Me.Btn_editarAnimal.Text = "Editar"
        Me.Btn_editarAnimal.UseVisualStyleBackColor = False
        '
        'DGV_listaAnimales
        '
        Me.DGV_listaAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_listaAnimales.Location = New System.Drawing.Point(567, 59)
        Me.DGV_listaAnimales.Name = "DGV_listaAnimales"
        Me.DGV_listaAnimales.Size = New System.Drawing.Size(734, 534)
        Me.DGV_listaAnimales.TabIndex = 4
        '
        'P_altaUsuario
        '
        Me.P_altaUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_altaUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.P_altaUsuario.Controls.Add(Me.GroupBox1)
        Me.P_altaUsuario.Location = New System.Drawing.Point(12, 15)
        Me.P_altaUsuario.Name = "P_altaUsuario"
        Me.P_altaUsuario.Size = New System.Drawing.Size(549, 308)
        Me.P_altaUsuario.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Btn_busquedaAnimal)
        Me.GroupBox1.Controls.Add(Me.Txt_idAnimal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 278)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Animal"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.LBL_estadoAnimal)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.LBL_clienteID)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.LBL_pesoAnimal)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.LBL_edadAnimal)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.LBL_nombreAnimal)
        Me.GroupBox2.Controls.Add(Me.LBL_idAnimal)
        Me.GroupBox2.Controls.Add(Me.LBL_especieAnimal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(261, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 236)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion"
        '
        'LBL_estadoAnimal
        '
        Me.LBL_estadoAnimal.AutoSize = True
        Me.LBL_estadoAnimal.Location = New System.Drawing.Point(72, 204)
        Me.LBL_estadoAnimal.Name = "LBL_estadoAnimal"
        Me.LBL_estadoAnimal.Size = New System.Drawing.Size(0, 18)
        Me.LBL_estadoAnimal.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 170)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 18)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Especie ID:"
        '
        'LBL_clienteID
        '
        Me.LBL_clienteID.AutoSize = True
        Me.LBL_clienteID.Location = New System.Drawing.Point(107, 142)
        Me.LBL_clienteID.Name = "LBL_clienteID"
        Me.LBL_clienteID.Size = New System.Drawing.Size(0, 18)
        Me.LBL_clienteID.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 142)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 18)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Cliente DNI:"
        '
        'LBL_pesoAnimal
        '
        Me.LBL_pesoAnimal.AutoSize = True
        Me.LBL_pesoAnimal.Location = New System.Drawing.Point(59, 112)
        Me.LBL_pesoAnimal.Name = "LBL_pesoAnimal"
        Me.LBL_pesoAnimal.Size = New System.Drawing.Size(0, 18)
        Me.LBL_pesoAnimal.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 18)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Peso:"
        '
        'LBL_edadAnimal
        '
        Me.LBL_edadAnimal.AutoSize = True
        Me.LBL_edadAnimal.Location = New System.Drawing.Point(66, 82)
        Me.LBL_edadAnimal.Name = "LBL_edadAnimal"
        Me.LBL_edadAnimal.Size = New System.Drawing.Size(0, 18)
        Me.LBL_edadAnimal.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Edad:"
        '
        'LBL_nombreAnimal
        '
        Me.LBL_nombreAnimal.AutoSize = True
        Me.LBL_nombreAnimal.Location = New System.Drawing.Point(91, 53)
        Me.LBL_nombreAnimal.Name = "LBL_nombreAnimal"
        Me.LBL_nombreAnimal.Size = New System.Drawing.Size(0, 18)
        Me.LBL_nombreAnimal.TabIndex = 5
        '
        'LBL_idAnimal
        '
        Me.LBL_idAnimal.AutoSize = True
        Me.LBL_idAnimal.Location = New System.Drawing.Point(97, 24)
        Me.LBL_idAnimal.Name = "LBL_idAnimal"
        Me.LBL_idAnimal.Size = New System.Drawing.Size(0, 18)
        Me.LBL_idAnimal.TabIndex = 4
        '
        'LBL_especieAnimal
        '
        Me.LBL_especieAnimal.AutoSize = True
        Me.LBL_especieAnimal.Location = New System.Drawing.Point(101, 170)
        Me.LBL_especieAnimal.Name = "LBL_especieAnimal"
        Me.LBL_especieAnimal.Size = New System.Drawing.Size(0, 18)
        Me.LBL_especieAnimal.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 204)
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
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Animal ID:"
        '
        'Btn_busquedaAnimal
        '
        Me.Btn_busquedaAnimal.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Btn_busquedaAnimal.FlatAppearance.BorderSize = 0
        Me.Btn_busquedaAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_busquedaAnimal.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_busquedaAnimal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_busquedaAnimal.Location = New System.Drawing.Point(28, 91)
        Me.Btn_busquedaAnimal.Name = "Btn_busquedaAnimal"
        Me.Btn_busquedaAnimal.Size = New System.Drawing.Size(216, 47)
        Me.Btn_busquedaAnimal.TabIndex = 4
        Me.Btn_busquedaAnimal.Text = "Buscar"
        Me.Btn_busquedaAnimal.UseVisualStyleBackColor = False
        '
        'Txt_idAnimal
        '
        Me.Txt_idAnimal.Location = New System.Drawing.Point(116, 41)
        Me.Txt_idAnimal.Name = "Txt_idAnimal"
        Me.Txt_idAnimal.Size = New System.Drawing.Size(128, 26)
        Me.Txt_idAnimal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Animal ID:"
        '
        'FormularioAccionesAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1313, 611)
        Me.Controls.Add(Me.Btn_listarAnimales)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGV_listaAnimales)
        Me.Controls.Add(Me.P_altaUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(1329, 650)
        Me.MinimumSize = New System.Drawing.Size(1329, 650)
        Me.Name = "FormularioAccionesAnimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acciones - Animal"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGV_listaAnimales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_altaUsuario.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_listarAnimales As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Txt_edadEditar As TextBox
    Friend WithEvents Btn_editarAnimal As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_nombreEditar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_editarAnimalID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DGV_listaAnimales As DataGridView
    Friend WithEvents P_altaUsuario As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LBL_nombreAnimal As Label
    Friend WithEvents LBL_idAnimal As Label
    Friend WithEvents LBL_especieAnimal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_busquedaAnimal As Button
    Friend WithEvents Txt_idAnimal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_clienteID As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LBL_pesoAnimal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LBL_edadAnimal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LBL_estadoAnimal As Label
    Friend WithEvents Txt_clienteDNIEditar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_pesoEditar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_especieIDEditar As TextBox
    Friend WithEvents Label12 As Label
End Class
