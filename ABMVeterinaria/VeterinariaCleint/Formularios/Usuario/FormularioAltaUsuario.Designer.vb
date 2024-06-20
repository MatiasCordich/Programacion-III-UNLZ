<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioAltaUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.P_altaUsuario = New System.Windows.Forms.Panel()
        Me.LBL_descripcionAlta = New System.Windows.Forms.Label()
        Me.PB_cargaAlta = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_alta = New System.Windows.Forms.Button()
        Me.Txt_claveAlta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_nombreAlta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T_Alta = New System.Windows.Forms.Timer(Me.components)
        Me.P_altaUsuario.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_altaUsuario
        '
        Me.P_altaUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_altaUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.P_altaUsuario.Controls.Add(Me.LBL_descripcionAlta)
        Me.P_altaUsuario.Controls.Add(Me.PB_cargaAlta)
        Me.P_altaUsuario.Controls.Add(Me.GroupBox1)
        Me.P_altaUsuario.Location = New System.Drawing.Point(59, 66)
        Me.P_altaUsuario.Name = "P_altaUsuario"
        Me.P_altaUsuario.Size = New System.Drawing.Size(668, 313)
        Me.P_altaUsuario.TabIndex = 0
        '
        'LBL_descripcionAlta
        '
        Me.LBL_descripcionAlta.AutoSize = True
        Me.LBL_descripcionAlta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_descripcionAlta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.LBL_descripcionAlta.Location = New System.Drawing.Point(12, 236)
        Me.LBL_descripcionAlta.Name = "LBL_descripcionAlta"
        Me.LBL_descripcionAlta.Size = New System.Drawing.Size(0, 19)
        Me.LBL_descripcionAlta.TabIndex = 2
        Me.LBL_descripcionAlta.Visible = False
        '
        'PB_cargaAlta
        '
        Me.PB_cargaAlta.Location = New System.Drawing.Point(16, 260)
        Me.PB_cargaAlta.Name = "PB_cargaAlta"
        Me.PB_cargaAlta.Size = New System.Drawing.Size(634, 40)
        Me.PB_cargaAlta.TabIndex = 1
        Me.PB_cargaAlta.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Btn_alta)
        Me.GroupBox1.Controls.Add(Me.Txt_claveAlta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_nombreAlta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alta de usuario"
        '
        'Btn_alta
        '
        Me.Btn_alta.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Btn_alta.FlatAppearance.BorderSize = 0
        Me.Btn_alta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_alta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_alta.Location = New System.Drawing.Point(240, 118)
        Me.Btn_alta.Name = "Btn_alta"
        Me.Btn_alta.Size = New System.Drawing.Size(138, 47)
        Me.Btn_alta.TabIndex = 4
        Me.Btn_alta.Text = "Registrar"
        Me.Btn_alta.UseVisualStyleBackColor = False
        '
        'Txt_claveAlta
        '
        Me.Txt_claveAlta.Location = New System.Drawing.Point(149, 81)
        Me.Txt_claveAlta.Name = "Txt_claveAlta"
        Me.Txt_claveAlta.Size = New System.Drawing.Size(348, 31)
        Me.Txt_claveAlta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clave"
        '
        'Txt_nombreAlta
        '
        Me.Txt_nombreAlta.Location = New System.Drawing.Point(149, 44)
        Me.Txt_nombreAlta.Name = "Txt_nombreAlta"
        Me.Txt_nombreAlta.Size = New System.Drawing.Size(348, 31)
        Me.Txt_nombreAlta.TabIndex = 1
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
        'T_Alta
        '
        '
        'FormularioAltaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.P_altaUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "FormularioAltaUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de usuario"
        Me.P_altaUsuario.ResumeLayout(False)
        Me.P_altaUsuario.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P_altaUsuario As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_alta As Button
    Friend WithEvents Txt_claveAlta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_nombreAlta As TextBox
    Friend WithEvents LBL_descripcionAlta As Label
    Friend WithEvents PB_cargaAlta As ProgressBar
    Friend WithEvents T_Alta As Timer
End Class
