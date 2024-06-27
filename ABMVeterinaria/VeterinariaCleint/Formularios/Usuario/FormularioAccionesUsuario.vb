Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports VeterinariaService.DAO


Public Class FormularioAccionesUsuario

#Region "Acciones"
    Private Sub LimpiarCamposBusquedaID()
        Txt_idUsuario.Text = ""
    End Sub

    Private Sub LimpiarCamposEditarUsuario()
        Txt_editarID.Text = ""
        Txt_nombreEditar.Text = ""
        Txt_claveEditar.Text = ""
    End Sub

#End Region

#Region "Eventos"

    '------------------- FUNCION - LISTAR USUARIOS ----------------------------'
    Private Sub Btn_listarUsuarios_Click(sender As Object, e As EventArgs) Handles Btn_listarUsuarios.Click

        'Declaracion - Dao y conexion a dataGridView'

        Dim dao As New UsuariosDAO

        Dim listaUsuarios = dao.GetAll

        DGV_listaUsuarios.DataSource = listaUsuarios

        DGV_listaUsuarios.Columns(2).Visible = False
    End Sub

    '------------------- FUNCION - BUSCAR USUARIO POR ID ----------------------------'
    Private Sub Btn_busquedaUsuario_Click(sender As Object, e As EventArgs) Handles Btn_busquedaUsuario.Click

        'Tomamos el valor del TextBox'
        Dim idS = Txt_idUsuario.Text

        'Validacion - NO TextBox vacio'
        If idS = "" Then
            MessageBox.Show("ERROR: El campo ID no puede estar vacio")
            Return
        End If

        'Validacion - TextBox numerico'
        Dim id As Integer

        If Not Integer.TryParse(idS, id) Then
            MessageBox.Show("ERROR: Ingrese un valor numerico")
            Return
        End If

        'Validacion - ID NO negativo'
        If id < 0 Then
            MessageBox.Show("ERROR: El numero de ID no puede ser negativo")
            Return
        End If

        '----------- CREACION DAO CON TRY CATCH -----------'

        Try

            'Creamos el DAO'
            Dim dao As New UsuariosDAO

            'Funcion - GETBYID con ID obtenido de TextBox y guardamos el resultado en una variable'
            Dim usuario = dao.GetByID(id)

            'Validacion - Lo obtenido por el GetBydID'
            If usuario IsNot Nothing Then

                'Si el Usuario existe, entonces'
                'Muestreo - Labels de resultado'
                LBL_idDescripcion.Text = usuario.UsuarioID.ToString("#0")
                LBL_nombreDescripcion.Text = usuario.NombreUsuario.ToString
                LBL_descripcionEstado.Text = usuario.Estado.ToString.ToUpper

                'Validacion - Estado del Usuario (cambio de color)'
                If usuario.Estado = "Inactivo" Then
                    LBL_descripcionEstado.ForeColor = Color.Red
                Else
                    LBL_descripcionEstado.ForeColor = Color.Green
                End If

                'Limpieza - Limpio el TextBox'
                Me.LimpiarCamposBusquedaID()

                'Inserccion - Los datos obtenidos lo implemento en los TextBox de EDITAR' 
                Txt_editarID.Text = usuario.UsuarioID.ToString("#0")
                Txt_nombreEditar.Text = usuario.NombreUsuario.ToString
                Txt_claveEditar.Text = usuario.Clave.ToString
            Else

                'Caso contrario- Muestro mensaje de de error'
                MessageBox.Show("ERROR: El usuario no existe")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se puedo buscar al usuario")
        End Try
    End Sub

    '------------------- FUNCION - EDITAR USUARIO ----------------------------'
    Private Sub Btn_editarUsuario_Click(sender As Object, e As EventArgs) Handles Btn_editarUsuario.Click

        'Tomamos los valores de los TextBox'
        Dim idS = Txt_editarID.Text
        Dim nombre = Txt_nombreEditar.Text
        Dim clave = Txt_claveEditar.Text

        'Validacion - NO campos nulos'
        If idS = "" Or nombre = "" Or clave = "" Then
            MessageBox.Show("ERROR: Los campos ID, NOMBRE y CLAVE no pueden estar vacios")
            Return
        End If

        'Validacion - ID numerico'
        Dim id As Integer

        If Not Integer.TryParse(idS, id) Then
            MessageBox.Show("ERROR: Ingrese un valor numerico")
            Return
        End If

        'Validacion - ID positivo'
        If id < 0 Then
            MessageBox.Show("ERROR: El numero de ID no puede ser negativo")
            Return
        End If

        'Validacion - consulta TRY CATCH'
        Try

            'Creamos el DAO'
            Dim dao As New UsuariosDAO

            'Funcion - GETBYID, le pasamos el ID del TextBox y lo guardamos en una variable'
            Dim usuario = dao.GetByID(id)

            'Validacion - Existencia Usuario'
            If usuario IsNot Nothing Then

                'Validacion - Estado del Usuario'
                If usuario.Estado = "Inactivo" Then
                    MessageBox.Show("No se pueden modificar usuarios INACTIVOS")
                    Return
                Else

                    'Caso contrario - Proseguimos con el UPDATE'
                    dao.Update(id, nombre, clave)

                    'Limpieza - Limpiamos los campos de los TextBox'
                    Me.LimpiarCamposEditarUsuario()

                    'Mensaje - Mostramos un mensaje de exito'
                    MessageBox.Show($"El usuario {usuario.NombreUsuario} ha sido modifcado correctamente")
                    Return
                End If
            Else
                MessageBox.Show("No se ha encontrado el usuario para modificar")
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se puedo buscar al usuario")
        End Try
    End Sub
#End Region

End Class