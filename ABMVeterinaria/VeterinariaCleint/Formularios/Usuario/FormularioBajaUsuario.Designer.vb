<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioBajaUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioBajaUsuario))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_idBaja = New System.Windows.Forms.TextBox()
        Me.Btn_bajaUsuario = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PB_cargaBaja = New System.Windows.Forms.ProgressBar()
        Me.LBL_descripcionBaja = New System.Windows.Forms.Label()
        Me.T_Baja = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_idBaja)
        Me.GroupBox1.Controls.Add(Me.Btn_bajaUsuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Txt_idBaja
        '
        resources.ApplyResources(Me.Txt_idBaja, "Txt_idBaja")
        Me.Txt_idBaja.Name = "Txt_idBaja"
        '
        'Btn_bajaUsuario
        '
        Me.Btn_bajaUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Btn_bajaUsuario.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Btn_bajaUsuario, "Btn_bajaUsuario")
        Me.Btn_bajaUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_bajaUsuario.Name = "Btn_bajaUsuario"
        Me.Btn_bajaUsuario.UseVisualStyleBackColor = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'PB_cargaBaja
        '
        resources.ApplyResources(Me.PB_cargaBaja, "PB_cargaBaja")
        Me.PB_cargaBaja.Name = "PB_cargaBaja"
        '
        'LBL_descripcionBaja
        '
        resources.ApplyResources(Me.LBL_descripcionBaja, "LBL_descripcionBaja")
        Me.LBL_descripcionBaja.BackColor = System.Drawing.Color.Transparent
        Me.LBL_descripcionBaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.LBL_descripcionBaja.Name = "LBL_descripcionBaja"
        '
        'T_Baja
        '
        '
        'FormularioBajaUsuario
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Controls.Add(Me.LBL_descripcionBaja)
        Me.Controls.Add(Me.PB_cargaBaja)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormularioBajaUsuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txt_idBaja As TextBox
    Friend WithEvents Btn_bajaUsuario As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PB_cargaBaja As ProgressBar
    Friend WithEvents LBL_descripcionBaja As Label
    Friend WithEvents T_Baja As Timer
End Class
