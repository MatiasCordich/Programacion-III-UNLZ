Imports VeterinariaService.DAO

Public Class FormularioReactivarUsuario

#Region "Eventos"

    '----------------------------------- CLICK REACTIVAR USUARIO -----------------------------------'
    Private Sub Btn_reactivarUsuario_Click(sender As Object, e As EventArgs) Handles Btn_reactivarUsuario.Click

        'Tomamos el valor del TextBox'
        Dim idS = Txt_idReactivar.Text

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
            Dim dao As New UsuariosDAO

            'Validamos que exista el Usuario'
            Dim usuario = dao.GetByID(id)

            If usuario IsNot Nothing Then

                'Valido el estado del Usuario'
                If usuario.Estado = "Activo" Then
                    'Si esta activo entonces muestro un mensaje'
                    MessageBox.Show($"El usuario {usuario.NombreUsuario} ya esta ACTIVO")
                    Return
                End If

                'Caso contrario sigo con la reactivacion del usuario'
                dao.ReactivarUsuario(id)

                T_Reactivar.Enabled = True
                LBL_descripcionReactivar.Text = "Cargando..."
                LBL_descripcionReactivar.Visible = True
                PB_cargaReactivar.Visible = True

                'Mostramos un mensaje de exito y vaciamos el Textbox'
                MessageBox.Show($"El usuario {usuario.NombreUsuario} fue reactivado correctamente")
                Txt_idReactivar.Text = ""
                Return
            Else
                'Caso contrario, mostramos un mensaje de error'
                MessageBox.Show("No se encontro al usuario para reactivar.")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se pudo dar de baja al Usuario")
        End Try
    End Sub
#End Region

#Region "Timers"

    '----------------------------------- TIMER TICK REACTIVAR USUARIO -----------------------------------'
    Private Sub T_Reactivar_Tick(sender As Object, e As EventArgs) Handles T_Reactivar.Tick
        If PB_cargaReactivar.Value = PB_cargaReactivar.Maximum Then
            LBL_descripcionReactivar.Visible = False
            PB_cargaReactivar.Visible = False
        Else
            Dim nuevoValor = PB_cargaReactivar.Value + 10

            PB_cargaReactivar.Value = Math.Min(nuevoValor, PB_cargaReactivar.Maximum)

        End If
    End Sub

#End Region

End Class