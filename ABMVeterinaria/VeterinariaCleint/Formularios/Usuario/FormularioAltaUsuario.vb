Imports VeterinariaService.DAO
Imports VeterinariaService.Modelos

Public Class FormularioAltaUsuario

#Region "Acciones"
    Private Sub LimpiarCampos()
        Txt_nombreAlta.Text = ""
        Txt_claveAlta.Text = ""
    End Sub
#End Region

#Region "Eventos"

    '----------------------------------- CLICK ALTA USUARIOS -----------------------------------'
    Private Sub Btn_alta_Click(sender As Object, e As EventArgs) Handles Btn_alta.Click

        'Tomamos los valores de los TextBox'
        Dim nombre = Txt_nombreAlta.Text
        Dim clave = Txt_claveAlta.Text

        If nombre = "" Or clave = "" Then
            MessageBox.Show("ERROR: No puede haber campos vacios")
            Return
        End If

        'Creamos el DAO'
        Dim dao As New UsuariosDAO

        'Validamos que el NOMBRE no este duplicado'
        Dim listaUsuarios = dao.GetAll

        For Each usuario As Usuario In listaUsuarios
            If usuario.NombreUsuario.ToUpper = nombre.ToUpper Then
                'Que me muestre un mensaje de error'
                MessageBox.Show("ERROR: El NOMBRE de usuario ya existe, intente otro")
                Return
            End If
        Next

        'Si paso la validacion prosigo con la inserccion'
        Dim nuevoUsuario As New Usuario(nombre, clave)

        'Valido la accion'
        If dao.Insert(nuevoUsuario) Then
            PB_cargaAlta.Visible = True
            T_Alta.Enabled = True
            LBL_descripcionAlta.Visible = True
            LBL_descripcionAlta.Text = "Cargando..."
            MessageBox.Show("Usuario cargado correctamente")
        End If
    End Sub

    '----------------------------------- TICK TIMER ALTA USUARIOS -----------------------------------'
    Private Sub T_Alta_Tick(sender As Object, e As EventArgs) Handles T_Alta.Tick
        'Evaluamos el valor de la barra de carga'
        If PB_cargaAlta.Value = PB_cargaAlta.Maximum Then

            'Si es igual a su MAXIMO'

            'Limpiamos los Textbox y sacamos la barra de carga'
            Me.LimpiarCampos()
            PB_cargaAlta.Visible = False
            LBL_descripcionAlta.Visible = False
        Else

            'Caso contrario incrementamos el valor del a barra de carga'
            Dim nuevoValor = PB_cargaAlta.Value + 10
            PB_cargaAlta.Value = Math.Min(nuevoValor, PB_cargaAlta.Maximum)
        End If
    End Sub
#End Region

End Class