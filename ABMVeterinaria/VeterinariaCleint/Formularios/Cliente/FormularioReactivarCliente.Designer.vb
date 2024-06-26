<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioReactivarCliente
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
        Me.LBL_descripcionReactivarCliente = New System.Windows.Forms.Label()
        Me.PB_cargaReactivarCliente = New System.Windows.Forms.ProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_idReactivarCliente = New System.Windows.Forms.TextBox()
        Me.Btn_reactivarCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T_ReactivarCliente = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_descripcionReactivarCliente
        '
        Me.LBL_descripcionReactivarCliente.AutoSize = True
        Me.LBL_descripcionReactivarCliente.BackColor = System.Drawing.Color.Transparent
        Me.LBL_descripcionReactivarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LBL_descripcionReactivarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.LBL_descripcionReactivarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LBL_descripcionReactivarCliente.Location = New System.Drawing.Point(12, 225)
        Me.LBL_descripcionReactivarCliente.Name = "LBL_descripcionReactivarCliente"
        Me.LBL_descripcionReactivarCliente.Size = New System.Drawing.Size(0, 20)
        Me.LBL_descripcionReactivarCliente.TabIndex = 12
        Me.LBL_descripcionReactivarCliente.Visible = False
        '
        'PB_cargaReactivarCliente
        '
        Me.PB_cargaReactivarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PB_cargaReactivarCliente.Location = New System.Drawing.Point(12, 251)
        Me.PB_cargaReactivarCliente.Name = "PB_cargaReactivarCliente"
        Me.PB_cargaReactivarCliente.Size = New System.Drawing.Size(620, 44)
        Me.PB_cargaReactivarCliente.TabIndex = 11
        Me.PB_cargaReactivarCliente.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(620, 194)
        Me.Panel1.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_idReactivarCliente)
        Me.GroupBox1.Controls.Add(Me.Btn_reactivarCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(33, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 152)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reactivar Cliente"
        '
        'Txt_idReactivarCliente
        '
        Me.Txt_idReactivarCliente.Location = New System.Drawing.Point(196, 42)
        Me.Txt_idReactivarCliente.Name = "Txt_idReactivarCliente"
        Me.Txt_idReactivarCliente.Size = New System.Drawing.Size(237, 27)
        Me.Txt_idReactivarCliente.TabIndex = 2
        '
        'Btn_reactivarCliente
        '
        Me.Btn_reactivarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Btn_reactivarCliente.FlatAppearance.BorderSize = 0
        Me.Btn_reactivarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_reactivarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_reactivarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_reactivarCliente.Location = New System.Drawing.Point(106, 85)
        Me.Btn_reactivarCliente.Name = "Btn_reactivarCliente"
        Me.Btn_reactivarCliente.Size = New System.Drawing.Size(327, 42)
        Me.Btn_reactivarCliente.TabIndex = 1
        Me.Btn_reactivarCliente.Text = "Reactivar"
        Me.Btn_reactivarCliente.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(102, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente ID:"
        '
        'T_ReactivarCliente
        '
        '
        'FormularioReactivarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(644, 307)
        Me.Controls.Add(Me.LBL_descripcionReactivarCliente)
        Me.Controls.Add(Me.PB_cargaReactivarCliente)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(660, 346)
        Me.MinimumSize = New System.Drawing.Size(660, 346)
        Me.Name = "FormularioReactivarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reactivar - Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_descripcionReactivarCliente As Label
    Friend WithEvents PB_cargaReactivarCliente As ProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_idReactivarCliente As TextBox
    Friend WithEvents Btn_reactivarCliente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents T_ReactivarCliente As Timer
End Class
