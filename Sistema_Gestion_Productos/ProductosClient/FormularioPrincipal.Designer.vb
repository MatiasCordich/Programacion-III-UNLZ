<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioPrincipal
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
        Me.P_menu = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_minimizar = New System.Windows.Forms.Button()
        Me.Btn_cerrar = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.P_menu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_menu
        '
        Me.P_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.P_menu.Controls.Add(Me.Button5)
        Me.P_menu.Controls.Add(Me.Button3)
        Me.P_menu.Controls.Add(Me.Button2)
        Me.P_menu.Controls.Add(Me.Button1)
        Me.P_menu.Controls.Add(Me.Panel1)
        Me.P_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.P_menu.Location = New System.Drawing.Point(0, 0)
        Me.P_menu.Name = "P_menu"
        Me.P_menu.Size = New System.Drawing.Size(213, 630)
        Me.P_menu.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 79)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(219, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 79)
        Me.Panel2.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Btn_minimizar)
        Me.Panel3.Controls.Add(Me.Btn_cerrar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(213, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1188, 79)
        Me.Panel3.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(523, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(22, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ABM Productos"
        '
        'Btn_minimizar
        '
        Me.Btn_minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_minimizar.FlatAppearance.BorderSize = 0
        Me.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_minimizar.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_minimizar.Image = Global.ProductosClient.My.Resources.Resources.minimize_btn
        Me.Btn_minimizar.Location = New System.Drawing.Point(1047, 12)
        Me.Btn_minimizar.Name = "Btn_minimizar"
        Me.Btn_minimizar.Size = New System.Drawing.Size(60, 58)
        Me.Btn_minimizar.TabIndex = 2
        Me.Btn_minimizar.UseVisualStyleBackColor = True
        '
        'Btn_cerrar
        '
        Me.Btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_cerrar.FlatAppearance.BorderSize = 0
        Me.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_cerrar.Image = Global.ProductosClient.My.Resources.Resources.close_btn
        Me.Btn_cerrar.Location = New System.Drawing.Point(1117, 12)
        Me.Btn_cerrar.Name = "Btn_cerrar"
        Me.Btn_cerrar.Size = New System.Drawing.Size(59, 58)
        Me.Btn_cerrar.TabIndex = 1
        Me.Btn_cerrar.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Image = Global.ProductosClient.My.Resources.Resources.info_icon1
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(0, 550)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(210, 68)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = " Informacion"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Image = Global.ProductosClient.My.Resources.Resources.report_icon
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(3, 233)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(210, 68)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = " Reportes"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Image = Global.ProductosClient.My.Resources.Resources.category_icon1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(3, 159)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(210, 68)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = " Categorias"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = Global.ProductosClient.My.Resources.Resources.product_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(210, 68)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = " Productos"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1401, 630)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.P_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormularioPrincipal"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.P_menu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_cerrar As Button
    Friend WithEvents Btn_minimizar As Button
    Friend WithEvents P_menu As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
