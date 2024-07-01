Public Class FormularioPrincipal
    Private Sub Btn_cerrar_Click(sender As Object, e As EventArgs) Handles Btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub Btn_minimizar_Click(sender As Object, e As EventArgs) Handles Btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
