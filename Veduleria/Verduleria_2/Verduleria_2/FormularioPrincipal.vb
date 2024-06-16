﻿Public Class FormularioPrincipal

#Region "Dependencias"
    Private ventanaLista As FormularioListar
    Private ventanaAlta As FormularioAlta
#End Region

#Region "Eventos"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        'Le estamos diciendo que al hacer clic en la opcion SALIR del menu que me cierre el FormularioPrincipal'
        Me.Close()
    End Sub

    Private Sub AltaDeVerdurasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeVerdurasToolStripMenuItem.Click

        'Validamos si existe nuestra ventanaAlta'
        If ventanaAlta Is Nothing Then
            'Si no existe la creamos de tipo FormularioAlta'
            ventanaAlta = New FormularioAlta

            'Configuramos que ventaAlta, de tipo FormularioAlta, tenga como padre el FormularioPrincipal'
            ventanaAlta.MdiParent = Me

            'Definimos que ventaAlta, de tipo FormularioAlta, tenga como propiedad de ancho COMPLETO'
            ventanaAlta.WindowState = FormWindowState.Maximized
        End If

        'Una vez creado el objeto, mostramos el formulario con el métido Show()'
        ventanaAlta.Show()
    End Sub

    Private Sub ListarVerdurasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarVerdurasToolStripMenuItem.Click

        'Validamos si existe nuestra ventaLista'
        If ventanaLista Is Nothing Then

            'Si no existe la creamos de tipo FormularioLista'
            ventanaLista = New FormularioListar

            'Configuramos que ventaLista, de tipo FormularioLista, tenga como padre el FormularioPrincipal'
            ventanaLista.MdiParent = Me

            'Definimos que ventaAlta, de tipo FormularioLista, tenga como propiedad de ancho COMPLETO'
            ventanaLista.WindowState = FormWindowState.Maximized
        End If

        'Una vez creado el objeto, mostramos el formulario con el métido Show()'
        ventanaLista.Show()
    End Sub
#End Region

End Class
