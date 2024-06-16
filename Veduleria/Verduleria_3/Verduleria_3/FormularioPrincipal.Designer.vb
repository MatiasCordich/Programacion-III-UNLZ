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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MaestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeVerdurasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarVerdurasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaestrosToolStripMenuItem, Me.InformesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MaestrosToolStripMenuItem
        '
        Me.MaestrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeVerdurasToolStripMenuItem})
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
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarVerdurasToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'ListarVerdurasToolStripMenuItem
        '
        Me.ListarVerdurasToolStripMenuItem.Name = "ListarVerdurasToolStripMenuItem"
        Me.ListarVerdurasToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ListarVerdurasToolStripMenuItem.Text = "Listar verduras"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(224, 148)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 234)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_login)
        Me.GroupBox1.Controls.Add(Me.txt_password)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 228)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(157, 123)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(88, 32)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(62, 91)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(286, 26)
        Me.txt_password.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese contraseña"
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormularioPrincipal"
        Me.Text = "Formulario Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MaestrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeVerdurasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarVerdurasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_login As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label1 As Label
End Class
