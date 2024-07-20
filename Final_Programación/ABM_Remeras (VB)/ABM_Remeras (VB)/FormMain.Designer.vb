<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.Ms_menuRemeras = New System.Windows.Forms.MenuStrip()
        Me.MaestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeRemeraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaDeRemeraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarRemeraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ms_menuRemeras.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ms_menuRemeras
        '
        Me.Ms_menuRemeras.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaestrosToolStripMenuItem})
        Me.Ms_menuRemeras.Location = New System.Drawing.Point(0, 0)
        Me.Ms_menuRemeras.Name = "Ms_menuRemeras"
        Me.Ms_menuRemeras.Size = New System.Drawing.Size(800, 29)
        Me.Ms_menuRemeras.TabIndex = 1
        Me.Ms_menuRemeras.Text = "MenuStrip1"
        '
        'MaestrosToolStripMenuItem
        '
        Me.MaestrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeRemeraToolStripMenuItem, Me.BajaDeRemeraToolStripMenuItem, Me.EditarRemeraToolStripMenuItem})
        Me.MaestrosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaestrosToolStripMenuItem.Name = "MaestrosToolStripMenuItem"
        Me.MaestrosToolStripMenuItem.Size = New System.Drawing.Size(86, 25)
        Me.MaestrosToolStripMenuItem.Text = "Maestros"
        '
        'AltaDeRemeraToolStripMenuItem
        '
        Me.AltaDeRemeraToolStripMenuItem.Name = "AltaDeRemeraToolStripMenuItem"
        Me.AltaDeRemeraToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.AltaDeRemeraToolStripMenuItem.Text = "Alta de remera"
        '
        'BajaDeRemeraToolStripMenuItem
        '
        Me.BajaDeRemeraToolStripMenuItem.Name = "BajaDeRemeraToolStripMenuItem"
        Me.BajaDeRemeraToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.BajaDeRemeraToolStripMenuItem.Text = "Baja de remera"
        '
        'EditarRemeraToolStripMenuItem
        '
        Me.EditarRemeraToolStripMenuItem.Name = "EditarRemeraToolStripMenuItem"
        Me.EditarRemeraToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.EditarRemeraToolStripMenuItem.Text = "Editar remera"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Ms_menuRemeras)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.Ms_menuRemeras
        Me.Name = "FormMain"
        Me.Text = "ABM Remeras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Ms_menuRemeras.ResumeLayout(False)
        Me.Ms_menuRemeras.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ms_menuRemeras As MenuStrip
    Friend WithEvents MaestrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeRemeraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaDeRemeraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarRemeraToolStripMenuItem As ToolStripMenuItem
End Class
