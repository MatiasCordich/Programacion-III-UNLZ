<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAltaCliente
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
        Me.P_altaCliente = New System.Windows.Forms.Panel()
        Me.LBL_descripcionAltaCliente = New System.Windows.Forms.Label()
        Me.PB_cargaAltaCliente = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_altaCliente = New System.Windows.Forms.Button()
        Me.Txt_DNIClienteAlta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_nombreClienteAlta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T_altaCliente = New System.Windows.Forms.Timer(Me.components)
        Me.P_altaCliente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_altaCliente
        '
        Me.P_altaCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_altaCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.P_altaCliente.Controls.Add(Me.LBL_descripcionAltaCliente)
        Me.P_altaCliente.Controls.Add(Me.PB_cargaAltaCliente)
        Me.P_altaCliente.Controls.Add(Me.GroupBox1)
        Me.P_altaCliente.Location = New System.Drawing.Point(66, 45)
        Me.P_altaCliente.Name = "P_altaCliente"
        Me.P_altaCliente.Size = New System.Drawing.Size(668, 360)
        Me.P_altaCliente.TabIndex = 2
        '
        'LBL_descripcionAltaCliente
        '
        Me.LBL_descripcionAltaCliente.AutoSize = True
        Me.LBL_descripcionAltaCliente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_descripcionAltaCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.LBL_descripcionAltaCliente.Location = New System.Drawing.Point(12, 283)
        Me.LBL_descripcionAltaCliente.Name = "LBL_descripcionAltaCliente"
        Me.LBL_descripcionAltaCliente.Size = New System.Drawing.Size(0, 19)
        Me.LBL_descripcionAltaCliente.TabIndex = 2
        Me.LBL_descripcionAltaCliente.Visible = False
        '
        'PB_cargaAltaCliente
        '
        Me.PB_cargaAltaCliente.Location = New System.Drawing.Point(16, 305)
        Me.PB_cargaAltaCliente.Name = "PB_cargaAltaCliente"
        Me.PB_cargaAltaCliente.Size = New System.Drawing.Size(634, 40)
        Me.PB_cargaAltaCliente.TabIndex = 1
        Me.PB_cargaAltaCliente.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Btn_altaCliente)
        Me.GroupBox1.Controls.Add(Me.Txt_DNIClienteAlta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_nombreClienteAlta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alta de cliente"
        '
        'Btn_altaCliente
        '
        Me.Btn_altaCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Btn_altaCliente.FlatAppearance.BorderSize = 0
        Me.Btn_altaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_altaCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_altaCliente.Location = New System.Drawing.Point(234, 153)
        Me.Btn_altaCliente.Name = "Btn_altaCliente"
        Me.Btn_altaCliente.Size = New System.Drawing.Size(138, 47)
        Me.Btn_altaCliente.TabIndex = 4
        Me.Btn_altaCliente.Text = "Registrar"
        Me.Btn_altaCliente.UseVisualStyleBackColor = False
        '
        'Txt_DNIClienteAlta
        '
        Me.Txt_DNIClienteAlta.Location = New System.Drawing.Point(209, 104)
        Me.Txt_DNIClienteAlta.Name = "Txt_DNIClienteAlta"
        Me.Txt_DNIClienteAlta.Size = New System.Drawing.Size(348, 31)
        Me.Txt_DNIClienteAlta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DNI"
        '
        'Txt_nombreClienteAlta
        '
        Me.Txt_nombreClienteAlta.Location = New System.Drawing.Point(209, 48)
        Me.Txt_nombreClienteAlta.Name = "Txt_nombreClienteAlta"
        Me.Txt_nombreClienteAlta.Size = New System.Drawing.Size(348, 31)
        Me.Txt_nombreClienteAlta.TabIndex = 1
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
        'T_altaCliente
        '
        '
        'FormularioAltaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.P_altaCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "FormularioAltaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta - Animal"
        Me.P_altaCliente.ResumeLayout(False)
        Me.P_altaCliente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P_altaCliente As Panel
    Friend WithEvents LBL_descripcionAltaCliente As Label
    Friend WithEvents PB_cargaAltaCliente As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_altaCliente As Button
    Friend WithEvents Txt_DNIClienteAlta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_nombreClienteAlta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents T_altaCliente As Timer
End Class
