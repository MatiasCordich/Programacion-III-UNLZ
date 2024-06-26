Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports VeterinariaService.DAO

Public Class FormularioBajaUsuario
#Region "Eventos"

    '-------------------------------------- Funcion - BAJA USUARIO -----------------------------------'
    Private Sub Btn_bajaUsuario_Click(sender As Object, e As EventArgs) Handles Btn_bajaUsuario.Click

        'Tomamos el valor del TextBox'
        Dim idS = Txt_idBaja.Text

        'Validacion - Campo vacio'
        If idS = "" Then
            MessageBox.Show("ERROR: El campo no puede estar vacio, por favor ingrese un valor")
            Return
        End If

        'Validacion - TextBox numerico'
        Dim id As Integer

        If Not Integer.TryParse(idS, id) Then
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

            Dim dao As New UsuariosDAO

            'Validacion - Estado del Usuario'
            Dim usuario = dao.GetByID(id)

            If usuario IsNot Nothing Then

                'Validamos el ESTADO del usuario'
                If usuario.Estado = "Inactivo" Then

                    'Si esta INACTIVO entonces muestro un mensaje'
                    MessageBox.Show($"El usuario {usuario.NombreUsuario} ya fue dado de baja.")
                    Return
                End If

                'Relacion - DAO DELETE'
                dao.Delete(id)

                'Muestreo - Componentes de carga'
                T_Baja.Enabled = True
                LBL_descripcionBaja.Text = "Cargando..."
                LBL_descripcionBaja.Visible = True
                PB_cargaBaja.Visible = True

                'Mensaje - Caso exitoso'
                MessageBox.Show($"El usuario {usuario.NombreUsuario} fue dado de baja correctamente")

                'Limpieza de campos'
                Txt_idBaja.Text = ""
                Return
            Else
                'Mensaje - Caso fallido'
                MessageBox.Show("No se encontro al usuario para dar de baja")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se pudo dar de baja al Usuario")
        End Try
    End Sub
#End Region

#Region "Timers"

    '-------------------------------------- Funcion - TIMER BAJA CLIENTE -----------------------------------'
    Private Sub T_Baja_Tick(sender As Object, e As EventArgs) Handles T_Baja.Tick

        'Validacion- Valor PB'
        If PB_cargaBaja.Value = PB_cargaBaja.Maximum Then
            LBL_descripcionBaja.Visible = False
            PB_cargaBaja.Visible = False
        Else
            Dim nuevoValor = PB_cargaBaja.Value + 10

            PB_cargaBaja.Value = Math.Min(nuevoValor, PB_cargaBaja.Maximum)

        End If
    End Sub
#End Region

End Class