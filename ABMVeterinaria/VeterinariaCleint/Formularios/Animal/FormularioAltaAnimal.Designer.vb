<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAltaAnimal
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
        Me.components = New System.ComponentModel.Container()
        Me.P_altaUsuario = New System.Windows.Forms.Panel()
        Me.LBL_descripcionAltaAnimal = New System.Windows.Forms.Label()
        Me.PB_cargaAltaAnimal = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_especieIDAltaAnimal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_clienteDNIAltaAnimal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_edadAltaAnimal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_altaAnimal = New System.Windows.Forms.Button()
        Me.Txt_pesoAltaAnimal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_nombreAltaAnimal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T_altaAnimal = New System.Windows.Forms.Timer(Me.components)
        Me.P_altaUsuario.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_altaUsuario
        '
        Me.P_altaUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_altaUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.P_altaUsuario.Controls.Add(Me.LBL_descripcionAltaAnimal)
        Me.P_altaUsuario.Controls.Add(Me.PB_cargaAltaAnimal)
        Me.P_altaUsuario.Controls.Add(Me.GroupBox1)
        Me.P_altaUsuario.Location = New System.Drawing.Point(66, 12)
        Me.P_altaUsuario.Name = "P_altaUsuario"
        Me.P_altaUsuario.Size = New System.Drawing.Size(668, 426)
        Me.P_altaUsuario.TabIndex = 1
        '
        'LBL_descripcionAltaAnimal
        '
        Me.LBL_descripcionAltaAnimal.AutoSize = True
        Me.LBL_descripcionAltaAnimal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_descripcionAltaAnimal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.LBL_descripcionAltaAnimal.Location = New System.Drawing.Point(12, 340)
        Me.LBL_descripcionAltaAnimal.Name = "LBL_descripcionAltaAnimal"
        Me.LBL_descripcionAltaAnimal.Size = New System.Drawing.Size(0, 19)
        Me.LBL_descripcionAltaAnimal.TabIndex = 2
        Me.LBL_descripcionAltaAnimal.Visible = False
        '
        'PB_cargaAltaAnimal
        '
        Me.PB_cargaAltaAnimal.Location = New System.Drawing.Point(16, 366)
        Me.PB_cargaAltaAnimal.Name = "PB_cargaAltaAnimal"
        Me.PB_cargaAltaAnimal.Size = New System.Drawing.Size(634, 40)
        Me.PB_cargaAltaAnimal.TabIndex = 1
        Me.PB_cargaAltaAnimal.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Txt_especieIDAltaAnimal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_clienteDNIAltaAnimal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_edadAltaAnimal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Btn_altaAnimal)
        Me.GroupBox1.Controls.Add(Me.Txt_pesoAltaAnimal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_nombreAltaAnimal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 292)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alta de animal"
        '
        'Txt_especieIDAltaAnimal
        '
        Me.Txt_especieIDAltaAnimal.Location = New System.Drawing.Point(171, 192)
        Me.Txt_especieIDAltaAnimal.Name = "Txt_especieIDAltaAnimal"
        Me.Txt_especieIDAltaAnimal.Size = New System.Drawing.Size(348, 31)
        Me.Txt_especieIDAltaAnimal.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Especie ID"
        '
        'Txt_clienteDNIAltaAnimal
        '
        Me.Txt_clienteDNIAltaAnimal.Location = New System.Drawing.Point(171, 155)
        Me.Txt_clienteDNIAltaAnimal.Name = "Txt_clienteDNIAltaAnimal"
        Me.Txt_clienteDNIAltaAnimal.Size = New System.Drawing.Size(348, 31)
        Me.Txt_clienteDNIAltaAnimal.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cliente DNI"
        '
        'Txt_edadAltaAnimal
        '
        Me.Txt_edadAltaAnimal.Location = New System.Drawing.Point(171, 118)
        Me.Txt_edadAltaAnimal.Name = "Txt_edadAltaAnimal"
        Me.Txt_edadAltaAnimal.Size = New System.Drawing.Size(348, 31)
        Me.Txt_edadAltaAnimal.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Edad"
        '
        'Btn_altaAnimal
        '
        Me.Btn_altaAnimal.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Btn_altaAnimal.FlatAppearance.BorderSize = 0
        Me.Btn_altaAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_altaAnimal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_altaAnimal.Location = New System.Drawing.Point(233, 239)
        Me.Btn_altaAnimal.Name = "Btn_altaAnimal"
        Me.Btn_altaAnimal.Size = New System.Drawing.Size(138, 47)
        Me.Btn_altaAnimal.TabIndex = 4
        Me.Btn_altaAnimal.Text = "Registrar"
        Me.Btn_altaAnimal.UseVisualStyleBackColor = False
        '
        'Txt_pesoAltaAnimal
        '
        Me.Txt_pesoAltaAnimal.Location = New System.Drawing.Point(171, 81)
        Me.Txt_pesoAltaAnimal.Name = "Txt_pesoAltaAnimal"
        Me.Txt_pesoAltaAnimal.Size = New System.Drawing.Size(348, 31)
        Me.Txt_pesoAltaAnimal.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Peso"
        '
        'Txt_nombreAltaAnimal
        '
        Me.Txt_nombreAltaAnimal.Location = New System.Drawing.Point(171, 44)
        Me.Txt_nombreAltaAnimal.Name = "Txt_nombreAltaAnimal"
        Me.Txt_nombreAltaAnimal.Size = New System.Drawing.Size(348, 31)
        Me.Txt_nombreAltaAnimal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'T_altaAnimal
        '
        '
        'FormularioAltaAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.P_altaUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "FormularioAltaAnimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta - Animal"
        Me.P_altaUsuario.ResumeLayout(False)
        Me.P_altaUsuario.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P_altaUsuario As Panel
    Friend WithEvents LBL_descripcionAltaAnimal As Label
    Friend WithEvents PB_cargaAltaAnimal As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_altaAnimal As Button
    Friend WithEvents Txt_pesoAltaAnimal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_nombreAltaAnimal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_especieIDAltaAnimal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_clienteDNIAltaAnimal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_edadAltaAnimal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents T_altaAnimal As Timer
End Class
