<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAccionesEspecie
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
        Me.Btn_listarEspecies = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txt_pesoEspecie = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_edadEspecie = New System.Windows.Forms.TextBox()
        Me.Btn_editarEspecie = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_nombreEspecie = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_editarID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGV_listaEspecies = New System.Windows.Forms.DataGridView()
        Me.P_altaUsuario = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBL_pesoEspecie = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBL_nombreEspecie = New System.Windows.Forms.Label()
        Me.LBL_idEspecie = New System.Windows.Forms.Label()
        Me.LBL_edadEspecie = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_busquedaEspecie = New System.Windows.Forms.Button()
        Me.Txt_idEspecie = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV_listaEspecies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_altaUsuario.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_listarEspecies
        '
        Me.Btn_listarEspecies.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_listarEspecies.FlatAppearance.BorderSize = 0
        Me.Btn_listarEspecies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_listarEspecies.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_listarEspecies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Btn_listarEspecies.Location = New System.Drawing.Point(634, 15)
        Me.Btn_listarEspecies.Name = "Btn_listarEspecies"
        Me.Btn_listarEspecies.Size = New System.Drawing.Size(155, 38)
        Me.Btn_listarEspecies.TabIndex = 3
        Me.Btn_listarEspecies.Text = "Listar Especies"
        Me.Btn_listarEspecies.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Location = New System.Drawing.Point(12, 226)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 248)
        Me.Panel1.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Txt_editarID)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(584, 211)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Editar Especie"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Txt_pesoEspecie)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Txt_edadEspecie)
        Me.GroupBox4.Controls.Add(Me.Btn_editarEspecie)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Txt_nombreEspecie)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(261, 25)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(317, 180)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Campos"
        '
        'Txt_pesoEspecie
        '
        Me.Txt_pesoEspecie.Location = New System.Drawing.Point(131, 94)
        Me.Txt_pesoEspecie.Name = "Txt_pesoEspecie"
        Me.Txt_pesoEspecie.Size = New System.Drawing.Size(180, 26)
        Me.Txt_pesoEspecie.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Peso promedio:"
        '
        'Txt_edadEspecie
        '
        Me.Txt_edadEspecie.Location = New System.Drawing.Point(131, 62)
        Me.Txt_edadEspecie.Name = "Txt_edadEspecie"
        Me.Txt_edadEspecie.Size = New System.Drawing.Size(180, 26)
        Me.Txt_edadEspecie.TabIndex = 8
        '
        'Btn_editarEspecie
        '
        Me.Btn_editarEspecie.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Btn_editarEspecie.FlatAppearance.BorderSize = 0
        Me.Btn_editarEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_editarEspecie.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_editarEspecie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_editarEspecie.Location = New System.Drawing.Point(6, 127)
        Me.Btn_editarEspecie.Name = "Btn_editarEspecie"
        Me.Btn_editarEspecie.Size = New System.Drawing.Size(305, 47)
        Me.Btn_editarEspecie.TabIndex = 4
        Me.Btn_editarEspecie.Text = "Editar"
        Me.Btn_editarEspecie.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Edad madurez:"
        '
        'Txt_nombreEspecie
        '
        Me.Txt_nombreEspecie.Location = New System.Drawing.Point(131, 30)
        Me.Txt_nombreEspecie.Name = "Txt_nombreEspecie"
        Me.Txt_nombreEspecie.Size = New System.Drawing.Size(180, 26)
        Me.Txt_nombreEspecie.TabIndex = 6
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
        Me.Label8.Size = New System.Drawing.Size(89, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Especie ID:"
        '
        'DGV_listaEspecies
        '
        Me.DGV_listaEspecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_listaEspecies.Location = New System.Drawing.Point(634, 59)
        Me.DGV_listaEspecies.Name = "DGV_listaEspecies"
        Me.DGV_listaEspecies.Size = New System.Drawing.Size(426, 415)
        Me.DGV_listaEspecies.TabIndex = 4
        '
        'P_altaUsuario
        '
        Me.P_altaUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_altaUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.P_altaUsuario.Controls.Add(Me.GroupBox1)
        Me.P_altaUsuario.Location = New System.Drawing.Point(12, 15)
        Me.P_altaUsuario.Name = "P_altaUsuario"
        Me.P_altaUsuario.Size = New System.Drawing.Size(616, 205)
        Me.P_altaUsuario.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Btn_busquedaEspecie)
        Me.GroupBox1.Controls.Add(Me.Txt_idEspecie)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 173)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Especie"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.LBL_pesoEspecie)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.LBL_nombreEspecie)
        Me.GroupBox2.Controls.Add(Me.LBL_idEspecie)
        Me.GroupBox2.Controls.Add(Me.LBL_edadEspecie)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(261, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(311, 142)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion"
        '
        'LBL_pesoEspecie
        '
        Me.LBL_pesoEspecie.AutoSize = True
        Me.LBL_pesoEspecie.Location = New System.Drawing.Point(135, 109)
        Me.LBL_pesoEspecie.Name = "LBL_pesoEspecie"
        Me.LBL_pesoEspecie.Size = New System.Drawing.Size(0, 18)
        Me.LBL_pesoEspecie.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Peso promedio:"
        '
        'LBL_nombreEspecie
        '
        Me.LBL_nombreEspecie.AutoSize = True
        Me.LBL_nombreEspecie.Location = New System.Drawing.Point(86, 52)
        Me.LBL_nombreEspecie.Name = "LBL_nombreEspecie"
        Me.LBL_nombreEspecie.Size = New System.Drawing.Size(0, 18)
        Me.LBL_nombreEspecie.TabIndex = 5
        '
        'LBL_idEspecie
        '
        Me.LBL_idEspecie.AutoSize = True
        Me.LBL_idEspecie.Location = New System.Drawing.Point(97, 24)
        Me.LBL_idEspecie.Name = "LBL_idEspecie"
        Me.LBL_idEspecie.Size = New System.Drawing.Size(0, 18)
        Me.LBL_idEspecie.TabIndex = 4
        '
        'LBL_edadEspecie
        '
        Me.LBL_edadEspecie.AutoSize = True
        Me.LBL_edadEspecie.Location = New System.Drawing.Point(131, 82)
        Me.LBL_edadEspecie.Name = "LBL_edadEspecie"
        Me.LBL_edadEspecie.Size = New System.Drawing.Size(0, 18)
        Me.LBL_edadEspecie.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Edad madurez:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Especie ID:"
        '
        'Btn_busquedaEspecie
        '
        Me.Btn_busquedaEspecie.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Btn_busquedaEspecie.FlatAppearance.BorderSize = 0
        Me.Btn_busquedaEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_busquedaEspecie.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_busquedaEspecie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_busquedaEspecie.Location = New System.Drawing.Point(28, 91)
        Me.Btn_busquedaEspecie.Name = "Btn_busquedaEspecie"
        Me.Btn_busquedaEspecie.Size = New System.Drawing.Size(216, 47)
        Me.Btn_busquedaEspecie.TabIndex = 4
        Me.Btn_busquedaEspecie.Text = "Buscar"
        Me.Btn_busquedaEspecie.UseVisualStyleBackColor = False
        '
        'Txt_idEspecie
        '
        Me.Txt_idEspecie.Location = New System.Drawing.Point(116, 41)
        Me.Txt_idEspecie.Name = "Txt_idEspecie"
        Me.Txt_idEspecie.Size = New System.Drawing.Size(128, 26)
        Me.Txt_idEspecie.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Especie ID:"
        '
        'FormularioAccionesEspecie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1072, 488)
        Me.Controls.Add(Me.Btn_listarEspecies)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGV_listaEspecies)
        Me.Controls.Add(Me.P_altaUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(1088, 527)
        Me.MinimumSize = New System.Drawing.Size(1088, 527)
        Me.Name = "FormularioAccionesEspecie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acciones - Especie"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGV_listaEspecies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_altaUsuario.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_listarEspecies As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Txt_edadEspecie As TextBox
    Friend WithEvents Btn_editarEspecie As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_nombreEspecie As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_editarID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DGV_listaEspecies As DataGridView
    Friend WithEvents P_altaUsuario As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LBL_nombreEspecie As Label
    Friend WithEvents LBL_idEspecie As Label
    Friend WithEvents LBL_edadEspecie As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_busquedaEspecie As Button
    Friend WithEvents Txt_idEspecie As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_pesoEspecie As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LBL_pesoEspecie As Label
End Class
