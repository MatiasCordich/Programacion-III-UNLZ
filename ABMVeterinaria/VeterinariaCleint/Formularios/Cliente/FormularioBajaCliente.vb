Imports VeterinariaService.DAO

Public Class FormularioBajaCliente

#Region "Eventos"

    '-------------------------------------- Funcion - BAJA CLIENTE -----------------------------------'
    Private Sub Btn_bajaCliente_Click(sender As Object, e As EventArgs) Handles Btn_bajaCliente.Click

        'Tomamos valor de txtbox'
        Dim ids = Txt_idBajaCliente.Text

        'Validacion - Campo vacio'
        If ids = "" Then
            MessageBox.Show("ERROR: Por favor, ingrese un numero")
            Return
        End If

        'Validacion - TextBox numerico'
        Dim id As Integer

        If Not Integer.TryParse(ids, id) Then
            MessageBox.Show("ERROR: Por favor, ingrese un valor numerico para ID")
            Return
        End If

        'Validacion - ID negativo'
        If id < 0 Then
            MessageBox.Show("ERROR: Por favor, ingrese un ID POSITIVO")
            Return
        End If

        '--------TRY CATCH Y CREACION DE DAO --------'
        Try

            Dim dao As New ClientesDAO
            Dim cliente = dao.GetByID(id)

            'Validacion - Estado del cliente'
            If cliente IsNot Nothing Then

                If cliente.Estado = "Inactivo" Then
                    'Alerta- cliente baja previa'
                    MessageBox.Show($"El cliente {cliente.Nombre} ya fue dado de baja previamente")
                    Return
                End If

                'Relacion - DAO DELETE'
                dao.Delete(id)

                'Muestreo - Componentes de carga'
                T_BajaCliente.Enabled = True
                LBL_descripcionBajaCliente.Text = "Cargando..."
                LBL_descripcionBajaCliente.Visible = True
                PB_cargaBajaCliente.Visible = True

                'Mensaje - Caso exitoso'
                MessageBox.Show($"El cliente {cliente.Nombre} fue dado de baja exitosamente")

                'Limpieza de campos'
                Txt_idBajaCliente.Text = ""
                Return
            Else

                'Mensaje - Caso fallido'
                MessageBox.Show("No se encontro el cliente para dar de baja")
                Return

            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se pudo dar de baja al Cliente")
        End Try

    End Sub

#End Region

#Region "Timer"

    '--------------------------------------Funcion - TIMER BAJA CLIENTE-----------------------------------'
    Private Sub T_BajaCliente_Tick(sender As Object, e As EventArgs) Handles T_BajaCliente.Tick

        'Validacion- Valor PB'
        If PB_cargaBajaCliente.Value = PB_cargaBajaCliente.Maximum Then
            LBL_descripcionBajaCliente.Visible = False
            PB_cargaBajaCliente.Visible = False
        Else
            Dim nuevoValorPB = PB_cargaBajaCliente.Value + 10
            PB_cargaBajaCliente.Value = Math.Min(nuevoValorPB, PB_cargaBajaCliente.Maximum)
        End If
    End Sub
#End Region

End Class