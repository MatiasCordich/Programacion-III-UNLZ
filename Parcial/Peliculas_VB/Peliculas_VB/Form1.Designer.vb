<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.btn_agregarPelicula = New System.Windows.Forms.Button()
        Me.dgrid_Peliculas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Duracion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_Duracion = New System.Windows.Forms.Label()
        Me.lbl_PromedioDuracion = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_CantDrama = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_PromedioTerror = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbox_Plan = New System.Windows.Forms.ComboBox()
        CType(Me.dgrid_Peliculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(83, 58)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_Nombre.TabIndex = 1
        '
        'btn_agregarPelicula
        '
        Me.btn_agregarPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregarPelicula.Location = New System.Drawing.Point(83, 166)
        Me.btn_agregarPelicula.Name = "btn_agregarPelicula"
        Me.btn_agregarPelicula.Size = New System.Drawing.Size(200, 42)
        Me.btn_agregarPelicula.TabIndex = 2
        Me.btn_agregarPelicula.Text = "Agregar pelicula"
        Me.btn_agregarPelicula.UseVisualStyleBackColor = True
        '
        'dgrid_Peliculas
        '
        Me.dgrid_Peliculas.AllowUserToAddRows = False
        Me.dgrid_Peliculas.AllowUserToDeleteRows = False
        Me.dgrid_Peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid_Peliculas.Location = New System.Drawing.Point(372, 12)
        Me.dgrid_Peliculas.Name = "dgrid_Peliculas"
        Me.dgrid_Peliculas.ReadOnly = True
        Me.dgrid_Peliculas.Size = New System.Drawing.Size(416, 426)
        Me.dgrid_Peliculas.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Genero"
        '
        'txt_Duracion
        '
        Me.txt_Duracion.Location = New System.Drawing.Point(83, 123)
        Me.txt_Duracion.Name = "txt_Duracion"
        Me.txt_Duracion.Size = New System.Drawing.Size(100, 20)
        Me.txt_Duracion.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Duracion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Duracion total:"
        '
        'lbl_Duracion
        '
        Me.lbl_Duracion.AutoSize = True
        Me.lbl_Duracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Duracion.Location = New System.Drawing.Point(162, 233)
        Me.lbl_Duracion.Name = "lbl_Duracion"
        Me.lbl_Duracion.Size = New System.Drawing.Size(24, 25)
        Me.lbl_Duracion.TabIndex = 9
        Me.lbl_Duracion.Text = "0"
        '
        'lbl_PromedioDuracion
        '
        Me.lbl_PromedioDuracion.AutoSize = True
        Me.lbl_PromedioDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PromedioDuracion.Location = New System.Drawing.Point(209, 270)
        Me.lbl_PromedioDuracion.Name = "lbl_PromedioDuracion"
        Me.lbl_PromedioDuracion.Size = New System.Drawing.Size(24, 25)
        Me.lbl_PromedioDuracion.TabIndex = 11
        Me.lbl_PromedioDuracion.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 25)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Promedio duracion:"
        '
        'lbl_CantDrama
        '
        Me.lbl_CantDrama.AutoSize = True
        Me.lbl_CantDrama.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CantDrama.Location = New System.Drawing.Point(158, 309)
        Me.lbl_CantDrama.Name = "lbl_CantDrama"
        Me.lbl_CantDrama.Size = New System.Drawing.Size(24, 25)
        Me.lbl_CantDrama.TabIndex = 13
        Me.lbl_CantDrama.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 25)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Total ""Drama"":"
        '
        'lbl_PromedioTerror
        '
        Me.lbl_PromedioTerror.AutoSize = True
        Me.lbl_PromedioTerror.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PromedioTerror.Location = New System.Drawing.Point(12, 378)
        Me.lbl_PromedioTerror.Name = "lbl_PromedioTerror"
        Me.lbl_PromedioTerror.Size = New System.Drawing.Size(24, 25)
        Me.lbl_PromedioTerror.TabIndex = 15
        Me.lbl_PromedioTerror.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(257, 25)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Promedio tiempo ""Terror"":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(258, 233)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 25)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "minutos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(258, 270)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 25)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "minutos"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(53, 378)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 25)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "minutos"
        '
        'cmbox_Plan
        '
        Me.cmbox_Plan.FormattingEnabled = True
        Me.cmbox_Plan.Items.AddRange(New Object() {"Drama", "Terror", "Romantica", "Ciencia Ficcion", "Aventuras", "Policial", "Comedia", "Infantil"})
        Me.cmbox_Plan.Location = New System.Drawing.Point(81, 89)
        Me.cmbox_Plan.Name = "cmbox_Plan"
        Me.cmbox_Plan.Size = New System.Drawing.Size(121, 21)
        Me.cmbox_Plan.TabIndex = 19
        Me.cmbox_Plan.Text = "Drama"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbox_Plan)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbl_PromedioTerror)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_CantDrama)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_PromedioDuracion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_Duracion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Duracion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgrid_Peliculas)
        Me.Controls.Add(Me.btn_agregarPelicula)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgrid_Peliculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents btn_agregarPelicula As Button
    Friend WithEvents dgrid_Peliculas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Duracion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_Duracion As Label
    Friend WithEvents lbl_PromedioDuracion As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_CantDrama As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_PromedioTerror As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbox_Plan As ComboBox
End Class
