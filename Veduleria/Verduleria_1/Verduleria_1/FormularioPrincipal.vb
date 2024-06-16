Public Class FormularioPrincipal
    Private Sub btn_listaFormulario_Click(sender As Object, e As EventArgs) Handles btn_listaFormulario.Click

        'Creamos una variable de tipo FormularioListar'
        Dim formu As New FormularioListar

        'Configuramos que FORMU de tipo FormularioListar tenga como padre el FormularioPrincipal'
        formu.MdiParent = Me

        'Una vez creado el objeto, mostramos el formulario con el métido Show()'
        formu.Show()
    End Sub

    Private Sub btn_altaFormulario_Click(sender As Object, e As EventArgs) Handles btn_altaFormulario.Click

        'Creamos una variable de tipo FormularioAlta'
        Dim formu As New FormularioAlta

        'Configuramos que FORMU de tipo FormularioAlta tenga como padre el FormularioPrincipal'
        formu.MdiParent = Me

        'Una vez creado el objeto, mostramos el formulario con el métido Show()'
        formu.Show()
    End Sub
End Class
