Imports VeterinariaService.DAO

Public Class FormularioReactivarCliente

#Region "Eventos"

    '-------------------------------------- Funcion - REACTIVAR CLIENTE-----------------------------------'
    Private Sub Btn_reactivarCliente_Click(sender As Object, e As EventArgs) Handles Btn_reactivarCliente.Click

        'Tomamos el valor del TextBox'
        Dim ids = Txt_idReactivarCliente.Text

        'Validacion - Campos vacios'
        If ids = "" Then
            MessageBox.Show("ERROR: Ingrese un numero en el campo ID")
            Return
        End If

        'Validacion - TextBox ID numerico'
        Dim id As Integer

        If Not Integer.TryParse(ids, id) Then
            MessageBox.Show("ERROR: Ingrese un valor numerico para ID")
            Return
        End If

        'Validacion - ID positivo'
        If id < 0 Then
            MessageBox.Show("ERROR: Ingrese un valor ID Positivo")
            Return
        End If


        'TRY CATCH & CREACION DAO'
        Try

            Dim dao As New ClientesDAO

            Dim cliente = dao.GetByID(id)

            If cliente IsNot Nothing Then

                'Condicional- Activacion de cliente segun estado'

                If cliente.Estado = "Activo" Then
                    MessageBox.Show($"El cliente {cliente.Nombre} ya esta ACTIVO")
                    Return
                End If

                'Caso fail- Reactivacion denuevo'

                dao.ReactivarCliente(id)

                T_ReactivarCliente.Enabled = True
                LBL_descripcionReactivarCliente.Text = "Cargando..."
                LBL_descripcionReactivarCliente.Visible = True
                PB_cargaReactivarCliente.Visible = True

                'Caso exitoso- msg reactivacion y limpieza de Textbox'
                MessageBox.Show($"El cliente {cliente.Nombre} fue reactivado correctamente")

                Txt_idReactivarCliente.Text = ""
                Return
            Else
                'Caso fail- msg error'
                MessageBox.Show("No se encontro al cliente para reactivar.")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se pudo reactivar al cliente")

        End Try
    End Sub

#End Region

#Region "Timers"

    '--------------------------------------Funcion - TIMER REACTIVAR CLIENTE-----------------------------------'
    Private Sub T_ReactivarCliente_Tick(sender As Object, e As EventArgs) Handles T_ReactivarCliente.Tick

        'Validacion- Valor PB'
        If PB_cargaReactivarCliente.Value = PB_cargaReactivarCliente.Maximum Then
            LBL_descripcionReactivarCliente.Visible = False
            PB_cargaReactivarCliente.Visible = False
        Else
            Dim nuevoValor = PB_cargaReactivarCliente.Value + 10

            PB_cargaReactivarCliente.Value = Math.Min(nuevoValor, PB_cargaReactivarCliente.Maximum)

        End If
    End Sub

#End Region

End Class