<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAltaEspecie
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
        Me.LBL_descripcionAltaEspecie = New System.Windows.Forms.Label()
        Me.PB_cargaAltaEspecie = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_PesoEspecieAlta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_altaEspecie = New System.Windows.Forms.Button()
        Me.Txt_EdadEspecieAlta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_nombreEspecieAlta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T_AltaEspecie = New System.Windows.Forms.Timer(Me.components)
        Me.P_altaUsuario.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_altaUsuario
        '
        Me.P_altaUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_altaUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.P_altaUsuario.Controls.Add(Me.LBL_descripcionAltaEspecie)
        Me.P_altaUsuario.Controls.Add(Me.PB_cargaAltaEspecie)
        Me.P_altaUsuario.Controls.Add(Me.GroupBox1)
        Me.P_altaUsuario.Location = New System.Drawing.Point(63, 43)
        Me.P_altaUsuario.Name = "P_altaUsuario"
        Me.P_altaUsuario.Size = New System.Drawing.Size(668, 360)
        Me.P_altaUsuario.TabIndex = 1
        '
        'LBL_descripcionAltaEspecie
        '
        Me.LBL_descripcionAltaEspecie.AutoSize = True
        Me.LBL_descripcionAltaEspecie.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_descripcionAltaEspecie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.LBL_descripcionAltaEspecie.Location = New System.Drawing.Point(12, 283)
        Me.LBL_descripcionAltaEspecie.Name = "LBL_descripcionAltaEspecie"
        Me.LBL_descripcionAltaEspecie.Size = New System.Drawing.Size(0, 19)
        Me.LBL_descripcionAltaEspecie.TabIndex = 2
        Me.LBL_descripcionAltaEspecie.Visible = False
        '
        'PB_cargaAltaEspecie
        '
        Me.PB_cargaAltaEspecie.Location = New System.Drawing.Point(16, 305)
        Me.PB_cargaAltaEspecie.Name = "PB_cargaAltaEspecie"
        Me.PB_cargaAltaEspecie.Size = New System.Drawing.Size(634, 40)
        Me.PB_cargaAltaEspecie.TabIndex = 1
        Me.PB_cargaAltaEspecie.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Txt_PesoEspecieAlta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Btn_altaEspecie)
        Me.GroupBox1.Controls.Add(Me.Txt_EdadEspecieAlta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_nombreEspecieAlta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alta de especie"
        '
        'Txt_PesoEspecieAlta
        '
        Me.Txt_PesoEspecieAlta.Location = New System.Drawing.Point(209, 122)
        Me.Txt_PesoEspecieAlta.Name = "Txt_PesoEspecieAlta"
        Me.Txt_PesoEspecieAlta.Size = New System.Drawing.Size(348, 31)
        Me.Txt_PesoEspecieAlta.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Peso promedio"
        '
        'Btn_altaEspecie
        '
        Me.Btn_altaEspecie.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Btn_altaEspecie.FlatAppearance.BorderSize = 0
        Me.Btn_altaEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_altaEspecie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_altaEspecie.Location = New System.Drawing.Point(234, 167)
        Me.Btn_altaEspecie.Name = "Btn_altaEspecie"
        Me.Btn_altaEspecie.Size = New System.Drawing.Size(138, 47)
        Me.Btn_altaEspecie.TabIndex = 4
        Me.Btn_altaEspecie.Text = "Registrar"
        Me.Btn_altaEspecie.UseVisualStyleBackColor = False
        '
        'Txt_EdadEspecieAlta
        '
        Me.Txt_EdadEspecieAlta.Location = New System.Drawing.Point(209, 85)
        Me.Txt_EdadEspecieAlta.Name = "Txt_EdadEspecieAlta"
        Me.Txt_EdadEspecieAlta.Size = New System.Drawing.Size(348, 31)
        Me.Txt_EdadEspecieAlta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Edad madurez"
        '
        'Txt_nombreEspecieAlta
        '
        Me.Txt_nombreEspecieAlta.Location = New System.Drawing.Point(209, 48)
        Me.Txt_nombreEspecieAlta.Name = "Txt_nombreEspecieAlta"
        Me.Txt_nombreEspecieAlta.Size = New System.Drawing.Size(348, 31)
        Me.Txt_nombreEspecieAlta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'T_AltaEspecie
        '
        '
        'FormularioAltaEspecie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.P_altaUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "FormularioAltaEspecie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta - Especie"
        Me.P_altaUsuario.ResumeLayout(False)
        Me.P_altaUsuario.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P_altaUsuario As Panel
    Friend WithEvents LBL_descripcionAltaEspecie As Label
    Friend WithEvents PB_cargaAltaEspecie As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_altaEspecie As Button
    Friend WithEvents Txt_EdadEspecieAlta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_nombreEspecieAlta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_PesoEspecieAlta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents T_AltaEspecie As Timer
End Class
