Imports PokeServices.Containers
Imports PokeServices.Models

Public Class FormPokedex

    'Nuestra aplicacion precisa de una Pokedex'
    Private pokedex As New Pokedex

    'Actualizo la grilla'
    Private Sub actualizarGrilla()
        gridPokemones.DataSource = Me.pokedex.getPokemones()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'Toda nuestra logica la vmaos a poner en un try catch para manejar errores'

        Try
            'Tomamos los valores de los textBox y el comboBox'
            Dim numero As Long = txtNumero.Text
            Dim nombre As String = txtNombre.Text
            Dim tipo As New TipoPokemon("Fuego")

            'Creamos el pokemon con los valores obtenidos'
            Dim nuevoPokemon = New Pokemon(numero, nombre, tipo)

            'Agrego el pokemon'
            Dim seAgrego = Me.pokedex.agregarPokemon(nuevoPokemon)

            'Valido si se agrego o no'
            If seAgrego Then
                'Si se agrego muestroun mensaje'
                MessageBox.Show("Pokemon agregado correctamente")

                'Borro los valores de los textBox'
                txtNombre.Text = ""
                txtNumero.Text = ""

                'Actualizo la grilla'
                Me.actualizarGrilla()
            Else
                MessageBox.Show("El ID esta repetido")
            End If
            'Tomamos los valores de los textBox y el comboBox'
        Catch ex As Exception
            'Manejamos el error si ponemos un string en el textBox de txtNuemero en vez de un numero'
            MessageBox.Show("Error, no puedes poner letras en ID")
        End Try
    End Sub
End Class
