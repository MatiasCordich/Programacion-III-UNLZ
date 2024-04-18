<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPokedex
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
        Me.groupBoxAlta = New System.Windows.Forms.GroupBox()
        Me.labelNumero = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.comboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.gridPokemones = New System.Windows.Forms.DataGridView()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.labelTipo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.groupBoxAlta.SuspendLayout()
        CType(Me.gridPokemones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBoxAlta
        '
        Me.groupBoxAlta.Controls.Add(Me.btnAgregar)
        Me.groupBoxAlta.Controls.Add(Me.txtNombre)
        Me.groupBoxAlta.Controls.Add(Me.labelTipo)
        Me.groupBoxAlta.Controls.Add(Me.labelNombre)
        Me.groupBoxAlta.Controls.Add(Me.comboBoxTipo)
        Me.groupBoxAlta.Controls.Add(Me.txtNumero)
        Me.groupBoxAlta.Controls.Add(Me.labelNumero)
        Me.groupBoxAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxAlta.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxAlta.Name = "groupBoxAlta"
        Me.groupBoxAlta.Size = New System.Drawing.Size(320, 426)
        Me.groupBoxAlta.TabIndex = 0
        Me.groupBoxAlta.TabStop = False
        Me.groupBoxAlta.Text = "Alta"
        '
        'labelNumero
        '
        Me.labelNumero.AutoSize = True
        Me.labelNumero.Location = New System.Drawing.Point(26, 78)
        Me.labelNumero.Name = "labelNumero"
        Me.labelNumero.Size = New System.Drawing.Size(32, 25)
        Me.labelNumero.TabIndex = 0
        Me.labelNumero.Text = "ID"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(118, 78)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(120, 31)
        Me.txtNumero.TabIndex = 1
        '
        'comboBoxTipo
        '
        Me.comboBoxTipo.FormattingEnabled = True
        Me.comboBoxTipo.Items.AddRange(New Object() {"Agua", "Fuego", "Planta"})
        Me.comboBoxTipo.Location = New System.Drawing.Point(118, 176)
        Me.comboBoxTipo.Name = "comboBoxTipo"
        Me.comboBoxTipo.Size = New System.Drawing.Size(121, 33)
        Me.comboBoxTipo.TabIndex = 2
        Me.comboBoxTipo.Text = "Agua"
        '
        'gridPokemones
        '
        Me.gridPokemones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPokemones.Location = New System.Drawing.Point(338, 12)
        Me.gridPokemones.Name = "gridPokemones"
        Me.gridPokemones.Size = New System.Drawing.Size(450, 426)
        Me.gridPokemones.TabIndex = 1
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(26, 130)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(87, 25)
        Me.labelNombre.TabIndex = 3
        Me.labelNombre.Text = "Nombre"
        '
        'labelTipo
        '
        Me.labelTipo.AutoSize = True
        Me.labelTipo.Location = New System.Drawing.Point(26, 179)
        Me.labelTipo.Name = "labelTipo"
        Me.labelTipo.Size = New System.Drawing.Size(54, 25)
        Me.labelTipo.TabIndex = 4
        Me.labelTipo.Text = "Tipo"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(118, 130)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(120, 31)
        Me.txtNombre.TabIndex = 5
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(79, 244)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(119, 41)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'FormPokedex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gridPokemones)
        Me.Controls.Add(Me.groupBoxAlta)
        Me.Name = "FormPokedex"
        Me.Text = "Form1"
        Me.groupBoxAlta.ResumeLayout(False)
        Me.groupBoxAlta.PerformLayout()
        CType(Me.gridPokemones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupBoxAlta As GroupBox
    Friend WithEvents comboBoxTipo As ComboBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents labelNumero As Label
    Friend WithEvents gridPokemones As DataGridView
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents labelTipo As Label
    Friend WithEvents labelNombre As Label
    Friend WithEvents btnAgregar As Button
End Class
