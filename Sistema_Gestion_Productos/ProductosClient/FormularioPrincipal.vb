Public Class FormularioPrincipal

#Region "Dependencias"
    Private currentButton As Button
    Private actualForm As Form
#End Region

#Region "Metodos"
    Private Sub OpenChidlForm(childForm As Form)

        If actualForm IsNot Nothing Then actualForm.Close()

        actualForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Me.P_desktopPanel.Controls.Add(childForm)
        Me.P_desktopPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        LBL_descriptionPanel.Text = childForm.Text
        Btn_closeChildForm.Visible = True
    End Sub

    Private Sub Reset()
        LBL_descriptionPanel.Text = "Inicio"
        Btn_closeChildForm.Visible = False
    End Sub
#End Region

#Region "Eventos"
    Private Sub Btn_cerrar_Click(sender As Object, e As EventArgs) Handles Btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub Btn_minimizar_Click(sender As Object, e As EventArgs) Handles Btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btn_products_Click(sender As Object, e As EventArgs) Handles Btn_products.Click
        Me.OpenChidlForm(New FormularioProductos)
    End Sub

    Private Sub Btn_closeChildForm_Click(sender As Object, e As EventArgs) Handles Btn_closeChildForm.Click
        If (actualForm IsNot Nothing) Then
            actualForm.Close()
            Btn_closeChildForm.Visible = False
            Me.Reset()
        End If
    End Sub





#End Region

End Class
