Public Class PantallaCarga

    'Funcion para hacer la carga mediante el Timer'
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles t_timer.Tick

        'Evaluamos el valor del ProgressBar'
        If pb_cargando.Value = pb_cargando.Maximum Then

            'Si es igual al MAXIMO entonces cerramos la PantallaCarga'
            Me.Close()
        Else

            'Caso contrario agregamos un valor de 10 al ProgressBarr'
            Dim nuevoValor = pb_cargando.Value + 10

            'El valor del ProgressBar sera siempre entre el nuevoValor y el Maximo (250)'
            pb_cargando.Value = Math.Min(nuevoValor, pb_cargando.Maximum)
        End If
    End Sub
End Class