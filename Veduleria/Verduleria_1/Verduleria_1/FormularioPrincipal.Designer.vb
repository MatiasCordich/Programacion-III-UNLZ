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
        Me.btn_listaFormulario = New System.Windows.Forms.Button()
        Me.btn_altaFormulario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_listaFormulario
        '
        Me.btn_listaFormulario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_listaFormulario.Location = New System.Drawing.Point(110, 178)
        Me.btn_listaFormulario.Name = "btn_listaFormulario"
        Me.btn_listaFormulario.Size = New System.Drawing.Size(227, 53)
        Me.btn_listaFormulario.TabIndex = 0
        Me.btn_listaFormulario.Text = "Formulario Lista"
        Me.btn_listaFormulario.UseVisualStyleBackColor = True
        '
        'btn_altaFormulario
        '
        Me.btn_altaFormulario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_altaFormulario.Location = New System.Drawing.Point(402, 178)
        Me.btn_altaFormulario.Name = "btn_altaFormulario"
        Me.btn_altaFormulario.Size = New System.Drawing.Size(227, 53)
        Me.btn_altaFormulario.TabIndex = 2
        Me.btn_altaFormulario.Text = "Formulario Agregar"
        Me.btn_altaFormulario.UseVisualStyleBackColor = True
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_altaFormulario)
        Me.Controls.Add(Me.btn_listaFormulario)
        Me.IsMdiContainer = True
        Me.Name = "FormularioPrincipal"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_listaFormulario As Button
    Friend WithEvents btn_altaFormulario As Button
End Class
