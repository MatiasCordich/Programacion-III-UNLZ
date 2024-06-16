Public Class PantallaCarga

    'Dandole dinamismo a la ProgressBar con el Timer'
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Validamos el valor de la ProgressBar'
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            'Si el valor de la ProgressBar es igual al valor maximo entonces cerramos la ventana de carga'
            Me.Close()
        Else

            'Caso contrario rellenamos (acumulamos) la ProgressBarr hasta llegar a su final'

            'Tomamos el valor de la ProgressBar y le sumamos 10'
            Dim nuevoValor = ProgressBar1.Value + 10

            'Acumulamos el valor de la ProgressBar y con la funcion Min nos aseguramos que no se sobrepase'
            ProgressBar1.Value = Math.Min(nuevoValor, ProgressBar1.Maximum)

        End If
    End Sub
End Class