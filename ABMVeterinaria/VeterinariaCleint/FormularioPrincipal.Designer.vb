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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioPrincipal))
        Me.T_login = New System.Windows.Forms.Timer(Me.components)
        Me.P_login = New System.Windows.Forms.Panel()
        Me.LBL_cargaBarra = New System.Windows.Forms.Label()
        Me.PB_barraLogin = New System.Windows.Forms.ProgressBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.Txt_claveLogin = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_nombreLogin = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MS_menuABM = New System.Windows.Forms.MenuStrip()
        Me.AltasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LBL_nombreUsuario = New System.Windows.Forms.Label()
        Me.Btn_salirApp = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.P_login.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MS_menuABM.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'T_login
        '
        '
        'P_login
        '
        Me.P_login.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.P_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.P_login.Controls.Add(Me.LBL_cargaBarra)
        Me.P_login.Controls.Add(Me.PB_barraLogin)
        Me.P_login.Controls.Add(Me.GroupBox2)
        Me.P_login.Location = New System.Drawing.Point(315, 198)
        Me.P_login.MaximumSize = New System.Drawing.Size(512, 287)
        Me.P_login.MinimumSize = New System.Drawing.Size(512, 287)
        Me.P_login.Name = "P_login"
        Me.P_login.Size = New System.Drawing.Size(512, 287)
        Me.P_login.TabIndex = 7
        '
        'LBL_cargaBarra
        '
        Me.LBL_cargaBarra.AutoSize = True
        Me.LBL_cargaBarra.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_cargaBarra.Location = New System.Drawing.Point(21, 206)
        Me.LBL_cargaBarra.Name = "LBL_cargaBarra"
        Me.LBL_cargaBarra.Size = New System.Drawing.Size(0, 18)
        Me.LBL_cargaBarra.TabIndex = 9
        '
        'PB_barraLogin
        '
        Me.PB_barraLogin.Location = New System.Drawing.Point(16, 236)
        Me.PB_barraLogin.Name = "PB_barraLogin"
        Me.PB_barraLogin.Size = New System.Drawing.Size(484, 40)
        Me.PB_barraLogin.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_Login)
        Me.GroupBox2.Controls.Add(Me.Txt_claveLogin)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Txt_nombreLogin)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(484, 167)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Login"
        '
        'Btn_Login
        '
        Me.Btn_Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_Login.FlatAppearance.BorderSize = 0
        Me.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Btn_Login.Location = New System.Drawing.Point(153, 111)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(170, 47)
        Me.Btn_Login.TabIndex = 4
        Me.Btn_Login.Text = "I N G R E S A R"
        Me.Btn_Login.UseVisualStyleBackColor = False
        '
        'Txt_claveLogin
        '
        Me.Txt_claveLogin.Location = New System.Drawing.Point(125, 74)
        Me.Txt_claveLogin.Name = "Txt_claveLogin"
        Me.Txt_claveLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_claveLogin.Size = New System.Drawing.Size(305, 31)
        Me.Txt_claveLogin.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 23)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Clave"
        '
        'Txt_nombreLogin
        '
        Me.Txt_nombreLogin.Location = New System.Drawing.Point(125, 37)
        Me.Txt_nombreLogin.Name = "Txt_nombreLogin"
        Me.Txt_nombreLogin.Size = New System.Drawing.Size(305, 31)
        Me.Txt_nombreLogin.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 23)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nombre"
        '
        'MS_menuABM
        '
        Me.MS_menuABM.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.MS_menuABM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MS_menuABM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltasToolStripMenuItem, Me.BajasToolStripMenuItem, Me.BusquedaToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.InformesToolStripMenuItem})
        Me.MS_menuABM.Location = New System.Drawing.Point(0, 0)
        Me.MS_menuABM.Name = "MS_menuABM"
        Me.MS_menuABM.Size = New System.Drawing.Size(1149, 29)
        Me.MS_menuABM.TabIndex = 8
        Me.MS_menuABM.Text = "MenuStrip1"
        Me.MS_menuABM.Visible = False
        '
        'AltasToolStripMenuItem
        '
        Me.AltasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeUsuarioToolStripMenuItem, Me.BajaDeUsuarioToolStripMenuItem, Me.AToolStripMenuItem})
        Me.AltasToolStripMenuItem.Name = "AltasToolStripMenuItem"
        Me.AltasToolStripMenuItem.Size = New System.Drawing.Size(84, 25)
        Me.AltasToolStripMenuItem.Text = "Usuarios"
        '
        'AltaDeUsuarioToolStripMenuItem
        '
        Me.AltaDeUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.AltaDeUsuarioToolStripMenuItem.Name = "AltaDeUsuarioToolStripMenuItem"
        Me.AltaDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.AltaDeUsuarioToolStripMenuItem.Text = "Alta de usuario"
        '
        'BajaDeUsuarioToolStripMenuItem
        '
        Me.BajaDeUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.BajaDeUsuarioToolStripMenuItem.Name = "BajaDeUsuarioToolStripMenuItem"
        Me.BajaDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.BajaDeUsuarioToolStripMenuItem.Text = "Baja de usuario"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.AToolStripMenuItem.Text = "Acciones"
        '
        'BajasToolStripMenuItem
        '
        Me.BajasToolStripMenuItem.Name = "BajasToolStripMenuItem"
        Me.BajasToolStripMenuItem.Size = New System.Drawing.Size(84, 25)
        Me.BajasToolStripMenuItem.Text = "Clientes"
        '
        'BusquedaToolStripMenuItem
        '
        Me.BusquedaToolStripMenuItem.Name = "BusquedaToolStripMenuItem"
        Me.BusquedaToolStripMenuItem.Size = New System.Drawing.Size(93, 25)
        Me.BusquedaToolStripMenuItem.Text = "Animales"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(87, 25)
        Me.ReportesToolStripMenuItem.Text = "Especies"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(88, 25)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.VeterinariaCleint.My.Resources.Resources.patitas
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 60)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(134, 126)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(134, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 126)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'LBL_nombreUsuario
        '
        Me.LBL_nombreUsuario.AutoSize = True
        Me.LBL_nombreUsuario.Font = New System.Drawing.Font("Century Gothic", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_nombreUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.LBL_nombreUsuario.Location = New System.Drawing.Point(463, 60)
        Me.LBL_nombreUsuario.Name = "LBL_nombreUsuario"
        Me.LBL_nombreUsuario.Size = New System.Drawing.Size(0, 63)
        Me.LBL_nombreUsuario.TabIndex = 11
        Me.LBL_nombreUsuario.Visible = False
        '
        'Btn_salirApp
        '
        Me.Btn_salirApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_salirApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_salirApp.FlatAppearance.BorderSize = 0
        Me.Btn_salirApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_salirApp.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_salirApp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Btn_salirApp.Location = New System.Drawing.Point(974, 535)
        Me.Btn_salirApp.Name = "Btn_salirApp"
        Me.Btn_salirApp.Size = New System.Drawing.Size(163, 56)
        Me.Btn_salirApp.TabIndex = 12
        Me.Btn_salirApp.Text = "S A L I R"
        Me.Btn_salirApp.UseVisualStyleBackColor = False
        Me.Btn_salirApp.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 491)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 100)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ABM Veterinaria"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(297, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 17)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Programacion III"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(238, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Materia:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Integrantes:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(297, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Niglio, Gabriel"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(238, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Profesor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(96, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Sio Cordich, Matias"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Olivera, Abril"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Buggenthin, Nicolas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(152, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 63)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Bienvenidx"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(152, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(543, 63)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "a Patitas Veterinaria"
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1149, 603)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_salirApp)
        Me.Controls.Add(Me.LBL_nombreUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.P_login)
        Me.Controls.Add(Me.MS_menuABM)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(1169, 646)
        Me.Name = "FormularioPrincipal"
        Me.Text = "ABM Veterinaria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.P_login.ResumeLayout(False)
        Me.P_login.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MS_menuABM.ResumeLayout(False)
        Me.MS_menuABM.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents T_login As Timer
    Friend WithEvents P_login As Panel
    Friend WithEvents LBL_cargaBarra As Label
    Friend WithEvents PB_barraLogin As ProgressBar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_Login As Button
    Friend WithEvents Txt_claveLogin As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_nombreLogin As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents MS_menuABM As MenuStrip
    Friend WithEvents AltasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LBL_nombreUsuario As Label
    Friend WithEvents Btn_salirApp As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BajaDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
End Class
