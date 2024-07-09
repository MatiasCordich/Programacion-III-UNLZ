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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btn_products = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_closeChildForm = New System.Windows.Forms.Button()
        Me.LBL_descriptionPanel = New System.Windows.Forms.Label()
        Me.Btn_minimizar = New System.Windows.Forms.Button()
        Me.Btn_cerrar = New System.Windows.Forms.Button()
        Me.P_desktopPanel = New System.Windows.Forms.Panel()
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
        Me.P_menu.Controls.Add(Me.Btn_products)
        Me.P_menu.Controls.Add(Me.Panel1)
        Me.P_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.P_menu.Location = New System.Drawing.Point(0, 0)
        Me.P_menu.Name = "P_menu"
        Me.P_menu.Size = New System.Drawing.Size(213, 630)
        Me.P_menu.TabIndex = 5
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
        'Btn_products
        '
        Me.Btn_products.FlatAppearance.BorderSize = 0
        Me.Btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_products.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_products.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_products.Image = Global.ProductosClient.My.Resources.Resources.product_icon
        Me.Btn_products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_products.Location = New System.Drawing.Point(0, 85)
        Me.Btn_products.Name = "Btn_products"
        Me.Btn_products.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Btn_products.Size = New System.Drawing.Size(210, 68)
        Me.Btn_products.TabIndex = 7
        Me.Btn_products.Text = " Productos"
        Me.Btn_products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_products.UseVisualStyleBackColor = True
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
        Me.Panel3.Controls.Add(Me.Btn_closeChildForm)
        Me.Panel3.Controls.Add(Me.LBL_descriptionPanel)
        Me.Panel3.Controls.Add(Me.Btn_minimizar)
        Me.Panel3.Controls.Add(Me.Btn_cerrar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(213, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1188, 79)
        Me.Panel3.TabIndex = 6
        '
        'Btn_closeChildForm
        '
        Me.Btn_closeChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Btn_closeChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_closeChildForm.FlatAppearance.BorderSize = 0
        Me.Btn_closeChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_closeChildForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_closeChildForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_closeChildForm.Location = New System.Drawing.Point(19, 11)
        Me.Btn_closeChildForm.Name = "Btn_closeChildForm"
        Me.Btn_closeChildForm.Size = New System.Drawing.Size(203, 59)
        Me.Btn_closeChildForm.TabIndex = 4
        Me.Btn_closeChildForm.Text = "Cerrar Formulario"
        Me.Btn_closeChildForm.UseVisualStyleBackColor = False
        Me.Btn_closeChildForm.Visible = False
        '
        'LBL_descriptionPanel
        '
        Me.LBL_descriptionPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LBL_descriptionPanel.AutoSize = True
        Me.LBL_descriptionPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_descriptionPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBL_descriptionPanel.Location = New System.Drawing.Point(514, 13)
        Me.LBL_descriptionPanel.Name = "LBL_descriptionPanel"
        Me.LBL_descriptionPanel.Size = New System.Drawing.Size(110, 42)
        Me.LBL_descriptionPanel.TabIndex = 3
        Me.LBL_descriptionPanel.Text = "Inicio"
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
        'P_desktopPanel
        '
        Me.P_desktopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.P_desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_desktopPanel.Location = New System.Drawing.Point(213, 79)
        Me.P_desktopPanel.Name = "P_desktopPanel"
        Me.P_desktopPanel.Size = New System.Drawing.Size(1188, 551)
        Me.P_desktopPanel.TabIndex = 7
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1401, 630)
        Me.Controls.Add(Me.P_desktopPanel)
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
    Friend WithEvents Btn_products As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LBL_descriptionPanel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents P_desktopPanel As Panel
    Friend WithEvents Btn_closeChildForm As Button
End Class
