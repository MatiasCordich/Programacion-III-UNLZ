﻿Imports VeterinariaService.DAO

Public Class FormularioReactivarUsuario

#Region "Eventos"

    '-------------------------------------- Funcion - REACTIVAR USUARIO -----------------------------------'
    Private Sub Btn_reactivarUsuario_Click(sender As Object, e As EventArgs) Handles Btn_reactivarUsuario.Click

        'Tomamos el valor del TextBox'
        Dim idS = Txt_idReactivar.Text

        'Validacion - Campos vacios'
        If idS = "" Then
            MessageBox.Show("ERROR: El campo ID no puede estar vacio.")
            Return
        End If

        'Validacion - TextBox ID numerico'
        Dim id As Integer

        If Not Integer.TryParse(idS, id) Then
            MessageBox.Show("ERROR: Por favor, ingrese un valor numerico para ID")
            Return
        End If

        'Validacion - ID positivo'
        If id < 0 Then
            MessageBox.Show("ERROR: Por favor, ingrese un ID POSITIVO")
            Return
        End If

        Try

            'Creamos el DAO'
            Dim dao As New UsuariosDAO

            'Validacion - Existencia de Usuario'
            Dim usuario = dao.GetByID(id)

            If usuario IsNot Nothing Then

                'Validacion - Estado de Usuario'
                If usuario.Estado = "Activo" Then
                    MessageBox.Show($"El usuario {usuario.NombreUsuario} ya esta ACTIVO")
                    Return
                End If

                'Caso fallido - Prosigo con la reactivacion'
                dao.ReactivarUsuario(id)

                T_Reactivar.Enabled = True
                LBL_descripcionReactivar.Text = "Cargando..."
                LBL_descripcionReactivar.Visible = True
                PB_cargaReactivar.Visible = True

                'Caso exitoso - Mensaje de reactivacion y limpieza de Textbox'
                MessageBox.Show($"El usuario {usuario.NombreUsuario} fue reactivado correctamente")
                Txt_idReactivar.Text = ""
                Return
            Else
                'Caso fail- Mensaje error: No se puedo encontrar el usuario'
                MessageBox.Show("No se encontro al usuario para reactivar.")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se pudo dar de baja al Usuario")
        End Try
    End Sub
#End Region

#Region "Timers"

    '-------------------------------------- Funcion - TIMER REACTIVAR CLIENTE-----------------------------------'
    Private Sub T_Reactivar_Tick(sender As Object, e As EventArgs) Handles T_Reactivar.Tick

        'Validacion- Valor PB'
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