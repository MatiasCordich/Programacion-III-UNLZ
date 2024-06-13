<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPrincipal
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
        Me.ms_MenuOpciones = New System.Windows.Forms.MenuStrip()
        Me.MaestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeVerdurasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarFondoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerListadoVerdurasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panel_Login = New System.Windows.Forms.Panel()
        Me.lbl_labelInfo = New System.Windows.Forms.Label()
        Me.pg_barraCargando = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.txt_loginPassword = New System.Windows.Forms.TextBox()
        Me.TimerCarga = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ms_MenuOpciones.SuspendLayout()
        Me.panel_Login.SuspendLayout()
        Me.SuspendLayout()
        '
        'ms_MenuOpciones
        '
        Me.ms_MenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaestrosToolStripMenuItem, Me.InformesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ms_MenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.ms_MenuOpciones.Name = "ms_MenuOpciones"
        Me.ms_MenuOpciones.Size = New System.Drawing.Size(800, 24)
        Me.ms_MenuOpciones.Stretch = False
        Me.ms_MenuOpciones.TabIndex = 3
        Me.ms_MenuOpciones.Text = "MenuStrip1"
        Me.ms_MenuOpciones.Visible = False
        '
        'MaestrosToolStripMenuItem
        '
        Me.MaestrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeVerdurasToolStripMenuItem, Me.CambiarFondoToolStripMenuItem})
        Me.MaestrosToolStripMenuItem.Name = "MaestrosToolStripMenuItem"
        Me.MaestrosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.MaestrosToolStripMenuItem.Text = "Maestros"
        '
        'AltaDeVerdurasToolStripMenuItem
        '
        Me.AltaDeVerdurasToolStripMenuItem.Name = "AltaDeVerdurasToolStripMenuItem"
        Me.AltaDeVerdurasToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.AltaDeVerdurasToolStripMenuItem.Text = "Alta de verduras"
        '
        'CambiarFondoToolStripMenuItem
        '
        Me.CambiarFondoToolStripMenuItem.Name = "CambiarFondoToolStripMenuItem"
        Me.CambiarFondoToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CambiarFondoToolStripMenuItem.Text = "Cambiar Fondo"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerListadoVerdurasToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'VerListadoVerdurasToolStripMenuItem
        '
        Me.VerListadoVerdurasToolStripMenuItem.Name = "VerListadoVerdurasToolStripMenuItem"
        Me.VerListadoVerdurasToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.VerListadoVerdurasToolStripMenuItem.Text = "Ver listado verduras"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'panel_Login
        '
        Me.panel_Login.Controls.Add(Me.lbl_labelInfo)
        Me.panel_Login.Controls.Add(Me.pg_barraCargando)
        Me.panel_Login.Controls.Add(Me.Label1)
        Me.panel_Login.Controls.Add(Me.btn_Login)
        Me.panel_Login.Controls.Add(Me.txt_loginPassword)
        Me.panel_Login.Location = New System.Drawing.Point(158, 78)
        Me.panel_Login.Name = "panel_Login"
        Me.panel_Login.Size = New System.Drawing.Size(465, 272)
        Me.panel_Login.TabIndex = 5
        '
        'lbl_labelInfo
        '
        Me.lbl_labelInfo.AutoSize = True
        Me.lbl_labelInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_labelInfo.ForeColor = System.Drawing.Color.Black
        Me.lbl_labelInfo.Location = New System.Drawing.Point(62, 196)
        Me.lbl_labelInfo.Name = "lbl_labelInfo"
        Me.lbl_labelInfo.Size = New System.Drawing.Size(0, 25)
        Me.lbl_labelInfo.TabIndex = 8
        Me.lbl_labelInfo.Visible = False
        '
        'pg_barraCargando
        '
        Me.pg_barraCargando.Location = New System.Drawing.Point(54, 234)
        Me.pg_barraCargando.Name = "pg_barraCargando"
        Me.pg_barraCargando.Size = New System.Drawing.Size(361, 23)
        Me.pg_barraCargando.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese Password"
        '
        'btn_Login
        '
        Me.btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Login.Location = New System.Drawing.Point(167, 142)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(129, 36)
        Me.btn_Login.TabIndex = 1
        Me.btn_Login.Text = "Login"
        Me.btn_Login.UseVisualStyleBackColor = True
        '
        'txt_loginPassword
        '
        Me.txt_loginPassword.Location = New System.Drawing.Point(92, 116)
        Me.txt_loginPassword.Name = "txt_loginPassword"
        Me.txt_loginPassword.Size = New System.Drawing.Size(284, 20)
        Me.txt_loginPassword.TabIndex = 0
        Me.txt_loginPassword.UseSystemPasswordChar = True
        '
        'TimerCarga
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panel_Login)
        Me.Controls.Add(Me.ms_MenuOpciones)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.ms_MenuOpciones
        Me.Name = "FormularioPrincipal"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ms_MenuOpciones.ResumeLayout(False)
        Me.ms_MenuOpciones.PerformLayout()
        Me.panel_Login.ResumeLayout(False)
        Me.panel_Login.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ms_MenuOpciones As MenuStrip
    Friend WithEvents MaestrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeVerdurasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerListadoVerdurasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panel_Login As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Login As Button
    Friend WithEvents txt_loginPassword As TextBox
    Friend WithEvents TimerCarga As Timer
    Friend WithEvents pg_barraCargando As ProgressBar
    Friend WithEvents lbl_labelInfo As Label
    Friend WithEvents CambiarFondoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
