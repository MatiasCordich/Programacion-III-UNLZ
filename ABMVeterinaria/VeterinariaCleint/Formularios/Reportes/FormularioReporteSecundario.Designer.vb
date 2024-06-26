<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioReporteSecundario
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_ReporteSecundario = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ReporteSecundario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.PictureBox2.BackgroundImage = Global.VeterinariaCleint.My.Resources.Resources.patitas
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(33, 12)
        Me.PictureBox2.MaximumSize = New System.Drawing.Size(134, 126)
        Me.PictureBox2.MinimumSize = New System.Drawing.Size(134, 126)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(134, 126)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 30.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(173, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 47)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Reporte secundario"
        '
        'DGV_ReporteSecundario
        '
        Me.DGV_ReporteSecundario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ReporteSecundario.Location = New System.Drawing.Point(11, 153)
        Me.DGV_ReporteSecundario.Margin = New System.Windows.Forms.Padding(2)
        Me.DGV_ReporteSecundario.Name = "DGV_ReporteSecundario"
        Me.DGV_ReporteSecundario.RowHeadersWidth = 51
        Me.DGV_ReporteSecundario.RowTemplate.Height = 24
        Me.DGV_ReporteSecundario.Size = New System.Drawing.Size(1133, 449)
        Me.DGV_ReporteSecundario.TabIndex = 21
        '
        'FormularioReporteSecundario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1154, 613)
        Me.Controls.Add(Me.DGV_ReporteSecundario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(1170, 652)
        Me.MinimumSize = New System.Drawing.Size(1170, 652)
        Me.Name = "FormularioReporteSecundario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Secundario"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ReporteSecundario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV_ReporteSecundario As DataGridView
End Class
