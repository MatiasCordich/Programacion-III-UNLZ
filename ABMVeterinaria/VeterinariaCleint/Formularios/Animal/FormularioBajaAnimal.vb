Imports VeterinariaService.DAO

Public Class FormularioBajaAnimal
#Region "Eventos"

    '----------------------------------- Funcion - CLICK BAJA DE MASCOTA -----------------------------------'
    Private Sub Btn_bajaAnimal_Click(sender As Object, e As EventArgs) Handles Btn_bajaAnimal.Click

        'Obtencion- Valor TextBox ID'
        Dim idS = Txt_idBajaAnimal.Text

        'Validacion - Campo vacio'
        If idS = "" Then
            MessageBox.Show("ERROR: Por favor, ingrese un numero")
            Return
        End If

        'Validacion - TextBox numerico'
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

        '--------------- Creacion - TRY CATCH & DAO ---------------'
        Try

            'Creamos el DAO'
            Dim dao As New AnimalesDAO

            'Validamos que exista el Usuario'
            Dim mascota = dao.GetByID(id)

            If mascota IsNot Nothing Then

                'Validamos el ESTADO del usuario'
                If mascota.Estado = "Difunto" Then

                    'Alerta - Animal baja previa'
                    MessageBox.Show($"La mascota {mascota.Nombre} ya fue dada de baja.")
                    Return
                End If

                'Relacion - DAO DELETE'
                dao.Delete(id)

                'Muestreo - Componentes de carga'
                T_BajaAnimal.Enabled = True
                LBL_descripcionBajaAnimal.Text = "Cargando..."
                LBL_descripcionBajaAnimal.Visible = True
                PB_cargaBajaAnimal.Visible = True

                'Mensaje - Caso exitoso'
                MessageBox.Show($"La mascota {mascota.Nombre} fue dada de baja correctamente")

                'Limpiamos el TextBox'
                Txt_idBajaAnimal.Text = ""
                Return
            Else
                'Mensaje - Caso fallido'
                MessageBox.Show("No se encontro la mascota para dar de baja")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se pudo dar de baja a la mascota")
        End Try
    End Sub

#End Region


#Region "Timers"

    '----------------------------------- TICK TIMER BAJA ANIMAL -----------------------------------'
    Private Sub T_BajaAnimal_Tick(sender As Object, e As EventArgs) Handles T_BajaAnimal.Tick

        'Validacion - Valor PB'
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