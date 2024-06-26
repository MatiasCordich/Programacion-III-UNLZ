Imports VeterinariaService.DAO
Imports VeterinariaService.Modelos

Public Class FormularioAltaUsuario

#Region "Acciones"

    '------------LIMPIEZA CAMPOS----------'
    Private Sub LimpiarCampos()
        Txt_nombreAlta.Text = ""
        Txt_claveAlta.Text = ""
    End Sub
#End Region

#Region "Eventos"

    '----------------------------------- Funcion - ALTA USUARIOS -----------------------------------'
    Private Sub Btn_alta_Click(sender As Object, e As EventArgs) Handles Btn_alta.Click

        'Tomamos los valores de los TextBox'
        Dim nombre = Txt_nombreAlta.Text.ToLower
        Dim clave = Txt_claveAlta.Text

        'Validacion - NO campos vacios'
        If nombre = "" Or clave = "" Then
            MessageBox.Show("ERROR: No puede haber campos vacios")
            Return
        End If

        'Creamos el DAO'
        Dim dao As New UsuariosDAO

        'Validamos que el NOMBRE no este duplicado'
        Dim listaUsuarios = dao.GetAll

        For Each usuario As Usuario In listaUsuarios
            If usuario.NombreUsuario.ToLower = nombre Then
                'Que me muestre un mensaje de error'
                MessageBox.Show("ERROR: El NOMBRE de usuario ya existe, intente otro")
                Return
            End If
        Next

        'Si paso la validacion prosigo con la inserccion'
        Dim nuevoUsuario As New Usuario(nombre, clave)

        If dao.Insert(nuevoUsuario) Then

            'Muestreo - Componentes de carga'
            PB_cargaAlta.Visible = True
            T_Alta.Enabled = True
            LBL_descripcionAlta.Visible = True
            LBL_descripcionAlta.Text = "Cargando..."
            MessageBox.Show("Usuario cargado correctamente")

            'Limpieza - Limpio los campos de los TextBox'
            Me.LimpiarCampos()
        End If
    End Sub


#End Region

#Region "Timers"

    '----------------------- Funcion TIMER ALTA USUARIO -----------------------'
    Private Sub T_Alta_Tick(sender As Object, e As EventArgs) Handles T_Alta.Tick

        'Validacion - Valor de la PB'
        If PB_cargaAlta.Value = PB_cargaAlta.Maximum Then

            'Limpieza - Ocultamos Texbox y PB de carga'
            PB_cargaAlta.Visible = False
            LBL_descripcionAlta.Visible = False
        Else

            'Caso contrario - Incrementamos el valor de la PB'
            Dim nuevoValor = PB_cargaAlta.Value + 10
            PB_cargaAlta.Value = Math.Min(nuevoValor, PB_cargaAlta.Maximum)
        End If
    End Sub

#End Region

End Class