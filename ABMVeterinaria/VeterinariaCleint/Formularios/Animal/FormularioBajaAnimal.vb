Imports VeterinariaService.DAO

Public Class FormularioBajaAnimal

#Region "Eventos"

    '----------------------------------- EVENTO CLICK BAJA DE MASCOTA -----------------------------------'
    Private Sub Btn_bajaAnimal_Click(sender As Object, e As EventArgs) Handles Btn_bajaAnimal.Click
        'Tomamos el valor del TextBox'
        Dim idS = Txt_idBajaAnimal.Text

        'Valido que no haya campo vacios'
        If idS = "" Then
            MessageBox.Show("ERROR: Por favor, ingrese un numero")
            Return
        End If

        'Validamos que el valor del TextBox sea numerico'
        Dim id As Integer

        If Not Integer.TryParse(idS, id) Then
            MessageBox.Show("ERROR: Por favor, ingrese un valor numerico para ID")
            Return
        End If

        'Validamos que el ID no sea negativo'
        If id < 0 Then
            MessageBox.Show("ERROR: Por favor, ingrese un ID POSITIVO")
            Return
        End If

        Try

            'Creamos el DAO'
            Dim dao As New AnimalesDAO

            'Validamos que exista el Usuario'
            Dim mascota = dao.GetByID(id)

            If mascota IsNot Nothing Then

                'Validamos el ESTADO del usuario'
                If mascota.Estado = "Difunto" Then

                    'Si esta INACTIVO entonces muestro un mensaje'
                    MessageBox.Show($"La mascota {mascota.Nombre} ya fue dada de baja.")
                    Return
                End If

                'Realizo el Delete'
                dao.Delete(id)

                'Muestros los componentes de carga'
                T_BajaAnimal.Enabled = True
                LBL_descripcionBajaAnimal.Text = "Cargando..."
                LBL_descripcionBajaAnimal.Visible = True
                PB_cargaBajaAnimal.Visible = True

                'Mostramos un mensaje de exito y vaciamos el Textbox'
                MessageBox.Show($"La mascota {mascota.Nombre} fue dada de baja correctamente")

                'Limpiamos el TextBox'
                Txt_idBajaAnimal.Text = ""
                Return
            Else
                'Caso contrario, mostramos un mensaje de error'
                MessageBox.Show("No se encontro la mascota para dar de baja")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se pudo dar de baja a la mascota")
        End Try
    End Sub

#End Region


#Region "Timers"

    '----------------------------------- TICK TIMER BAJA USUARIO -----------------------------------'
    Private Sub T_BajaAnimal_Tick(sender As Object, e As EventArgs) Handles T_BajaAnimal.Tick

        'Valido el valor del componenete de barra de carga'
        If PB_cargaBajaAnimal.Value = PB_cargaBajaAnimal.Maximum Then
            LBL_descripcionBajaAnimal.Visible = False
            PB_cargaBajaAnimal.Visible = False
        Else
            Dim nuevoValor = PB_cargaBajaAnimal.Value + 10

            PB_cargaBajaAnimal.Value = Math.Min(nuevoValor, PB_cargaBajaAnimal.Maximum)

        End If
    End Sub
#End Region

End Class