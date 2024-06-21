Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports VeterinariaService.DAO

Public Class FormularioBajaUsuario
#Region "Eventos"
    '----------------------------------- EVENTO CLIC BAJA USUARIO -----------------------------------'
    Private Sub Btn_bajaUsuario_Click(sender As Object, e As EventArgs) Handles Btn_bajaUsuario.Click
        'Tomamos el valor del TextBox'
        Dim idS = Txt_idBaja.Text

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

                'Validamos el ESTADO del usuario'
                If usuario.Estado = "Inactivo" Then

                    'Si esta INACTIVO entonces muestro un mensaje'
                    MessageBox.Show($"El usuario {usuario.NombreUsuario} ya fue dado de baja.")
                    Return
                End If

                'Realizo el Delete'
                dao.Delete(id)

                'Muestros los componentes de carga'
                T_Baja.Enabled = True
                LBL_descripcionBaja.Text = "Cargando..."
                LBL_descripcionBaja.Visible = True
                PB_cargaBaja.Visible = True

                'Mostramos un mensaje de exito y vaciamos el Textbox'
                MessageBox.Show($"El usuario {usuario.NombreUsuario} fue dado de baja correctamente")

                'Limpiamos el TextBox'
                Txt_idBaja.Text = ""
                Return
            Else
                'Caso contrario, mostramos un mensaje de error'
                MessageBox.Show("No se encontro al usuario para dar de baja")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se pudo dar de baja al Usuario")
        End Try
    End Sub
#End Region

#Region "Timers"

    '----------------------------------- TICK TIMER BAJA USUARIO -----------------------------------'
    Private Sub T_Baja_Tick(sender As Object, e As EventArgs) Handles T_Baja.Tick

        'Valido el valor del componenete de barra de carga'
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