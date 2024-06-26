<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioReportePrincipal
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
        Me.LblTituloReporte = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DGV_reportePrincipal = New System.Windows.Forms.DataGridView()
        Me.PanelFiltrado = New System.Windows.Forms.Panel()
        Me.GroupBoxRangos = New System.Windows.Forms.GroupBox()
        Me.Txt_edadMaxima = New System.Windows.Forms.TextBox()
        Me.Txt_edadMinima = New System.Windows.Forms.TextBox()
        Me.Btn_FiltrarReporte = New System.Windows.Forms.Button()
        Me.LblEdadmax = New System.Windows.Forms.Label()
        Me.LblEdadMin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_reportePrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltrado.SuspendLayout()
        Me.GroupBoxRangos.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTituloReporte
        '
        Me.LblTituloReporte.AutoSize = True
        Me.LblTituloReporte.Font = New System.Drawing.Font("Century Gothic", 30.75!, System.Drawing.FontStyle.Bold)
        Me.LblTituloReporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.LblTituloReporte.Location = New System.Drawing.Point(171, 47)
        Me.LblTituloReporte.Name = "LblTituloReporte"
        Me.LblTituloReporte.Size = New System.Drawing.Size(360, 47)
        Me.LblTituloReporte.TabIndex = 16
        Me.LblTituloReporte.Text = "Reporte principal"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.VeterinariaCleint.My.Resources.Resources.patitas
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(134, 126)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(134, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 126)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'DGV_reportePrincipal
        '
        Me.DGV_reportePrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_reportePrincipal.Location = New System.Drawing.Point(21, 143)
        Me.DGV_reportePrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.DGV_reportePrincipal.Name = "DGV_reportePrincipal"
        Me.DGV_reportePrincipal.RowHeadersWidth = 51
        Me.DGV_reportePrincipal.RowTemplate.Height = 24
        Me.DGV_reportePrincipal.Size = New System.Drawing.Size(790, 436)
        Me.DGV_reportePrincipal.TabIndex = 20
        '
        'PanelFiltrado
        '
        Me.PanelFiltrado.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.PanelFiltrado.Controls.Add(Me.GroupBoxRangos)
        Me.PanelFiltrado.Location = New System.Drawing.Point(851, 139)
        Me.PanelFiltrado.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelFiltrado.Name = "PanelFiltrado"
        Me.PanelFiltrado.Size = New System.Drawing.Size(266, 437)
        Me.PanelFiltrado.TabIndex = 22
        '
        'GroupBoxRangos
        '
        Me.GroupBoxRangos.Controls.Add(Me.Txt_edadMaxima)
        Me.GroupBoxRangos.Controls.Add(Me.Txt_edadMinima)
        Me.GroupBoxRangos.Controls.Add(Me.Btn_FiltrarReporte)
        Me.GroupBoxRangos.Controls.Add(Me.LblEdadmax)
        Me.GroupBoxRangos.Controls.Add(Me.LblEdadMin)
        Me.GroupBoxRangos.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxRangos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GroupBoxRangos.Location = New System.Drawing.Point(40, 32)
        Me.GroupBoxRangos.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxRangos.Name = "GroupBoxRangos"
        Me.GroupBoxRangos.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxRangos.Size = New System.Drawing.Size(188, 377)
        Me.GroupBoxRangos.TabIndex = 0
        Me.GroupBoxRangos.TabStop = False
        Me.GroupBoxRangos.Text = "RANGOS"
        '
        'Txt_edadMaxima
        '
        Me.Txt_edadMaxima.Location = New System.Drawing.Point(28, 208)
        Me.Txt_edadMaxima.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_edadMaxima.Name = "Txt_edadMaxima"
        Me.Txt_edadMaxima.Size = New System.Drawing.Size(122, 31)
        Me.Txt_edadMaxima.TabIndex = 7
        '
        'Txt_edadMinima
        '
        Me.Txt_edadMinima.Location = New System.Drawing.Point(28, 98)
        Me.Txt_edadMinima.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_edadMinima.Name = "Txt_edadMinima"
        Me.Txt_edadMinima.Size = New System.Drawing.Size(122, 31)
        Me.Txt_edadMinima.TabIndex = 6
        '
        'Btn_FiltrarReporte
        '
        Me.Btn_FiltrarReporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Btn_FiltrarReporte.FlatAppearance.BorderSize = 0
        Me.Btn_FiltrarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_FiltrarReporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Btn_FiltrarReporte.Location = New System.Drawing.Point(21, 296)
        Me.Btn_FiltrarReporte.Name = "Btn_FiltrarReporte"
        Me.Btn_FiltrarReporte.Size = New System.Drawing.Size(149, 47)
        Me.Btn_FiltrarReporte.TabIndex = 5
        Me.Btn_FiltrarReporte.Text = "F I L T R A R"
        Me.Btn_FiltrarReporte.UseVisualStyleBackColor = False
        '
        'LblEdadmax
        '
        Me.LblEdadmax.AutoSize = True
        Me.LblEdadmax.Location = New System.Drawing.Point(24, 163)
        Me.LblEdadmax.Name = "LblEdadmax"
        Me.LblEdadmax.Size = New System.Drawing.Size(142, 23)
        Me.LblEdadmax.TabIndex = 3
        Me.LblEdadmax.Text = "Edad maxima"
        '
        'LblEdadMin
        '
        Me.LblEdadMin.AutoSize = True
        Me.LblEdadMin.Location = New System.Drawing.Point(24, 60)
        Me.LblEdadMin.Name = "LblEdadMin"
        Me.LblEdadMin.Size = New System.Drawing.Size(134, 23)
        Me.LblEdadMin.TabIndex = 1
        Me.LblEdadMin.Text = "Edad minima"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 30.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(903, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 47)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Filtrado"
        '
        'FormularioReportePrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1154, 613)
        Me.Controls.Add(Me.PanelFiltrado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_reportePrincipal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblTituloReporte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(1170, 652)
        Me.MinimumSize = New System.Drawing.Size(1170, 652)
        Me.Name = "FormularioReportePrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_reportePrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltrado.ResumeLayout(False)
        Me.GroupBoxRangos.ResumeLayout(False)
        Me.GroupBoxRangos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTituloReporte As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DGV_reportePrincipal As DataGridView
    Friend WithEvents PanelFiltrado As Panel
    Friend WithEvents GroupBoxRangos As GroupBox
    Friend WithEvents Txt_edadMaxima As TextBox
    Friend WithEvents Txt_edadMinima As TextBox
    Friend WithEvents Btn_FiltrarReporte As Button
    Friend WithEvents LblEdadmax As Label
    Friend WithEvents LblEdadMin As Label
    Friend WithEvents Label1 As Label
End Class
