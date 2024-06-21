Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports VeterinariaService.DAO


Public Class FormularioAccionesUsuario

#Region "Acciones"
    Private Sub LimpiarCamposBusquedaID()
        Txt_idUsuario.Text = ""
    End Sub

    Private Sub LimpiarCamposEditarUsurios()
        Txt_editarID.Text = ""
        Txt_nombreEditar.Text = ""
        Txt_claveEditar.Text = ""
    End Sub

#End Region

#Region "Dependencias"
    '---------------------------------- LISTAR ---------------------------------- '
    Private Sub Btn_listarUsuarios_Click(sender As Object, e As EventArgs) Handles Btn_listarUsuarios.Click

        Dim dao As New UsuariosDAO

        Dim listaUsuarios = dao.GetAll

        DGV_listaUsuarios.DataSource = listaUsuarios
    End Sub

    '---------------------------------- BUSCAR USUARIO POR ID ---------------------------------- '
    Private Sub Btn_busquedaUsuario_Click(sender As Object, e As EventArgs) Handles Btn_busquedaUsuario.Click

        'Tomamos el valor del TextBox'
        Dim idS = Txt_idUsuario.Text

        'Validamos que no sea vacio'
        If idS = "" Then
            MessageBox.Show("ERROR: El campo ID no puede estar vacio")
            Return
        End If

        'Validamos que sea un numero'
        Dim id As Integer

        If Not Integer.TryParse(idS, id) Then
            MessageBox.Show("ERROR: Ingrese un valor numerico")
            Return
        End If

        'Validamos que el id no sea negativo'
        If id < 0 Then
            MessageBox.Show("ERROR: El numero de ID no puede ser negativo")
            Return
        End If


        Try

            'Creamos el DAO'
            Dim dao As New UsuariosDAO

            'Llamamos a la funcion GETBYID y le pasamos el ID obtenido del TextBox, el resultado lo guardamos en una variable'
            Dim usuario = dao.GetByID(id)

            'Validamos lo que obtuvimos con GetByID Y guardamos en la variable PRODUCTO'
            If usuario IsNot Nothing Then

                LBL_idDescripcion.Text = usuario.UsuarioID.ToString("#0")
                LBL_nombreDescripcion.Text = usuario.NombreUsuario.ToString
                LBL_descripcionEstado.Text = usuario.Estado.ToString.ToUpper

                If usuario.Estado = "Inactivo" Then
                    LBL_descripcionEstado.ForeColor = Color.Red
                Else
                    LBL_descripcionEstado.ForeColor = Color.Green
                End If

                Me.LimpiarCamposBusquedaID()

            Else
                'Caso contrario que se muestre un mensaje de error'
                MessageBox.Show("El usuario no existe")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se puedo buscar al usuario")
        End Try
    End Sub

    '---------------------------------- EDITAR USUARIO ---------------------------------- '
    Private Sub Btn_editarUsuario_Click(sender As Object, e As EventArgs) Handles Btn_editarUsuario.Click

        'Tomamos el valor del TextBox'
        Dim idS = Txt_editarID.Text
        Dim nombre = Txt_nombreEditar.Text
        Dim clave = Txt_claveEditar.Text

        'Validamos que no sea vacio'
        If idS = "" Then
            MessageBox.Show("ERROR: El campo ID no puede estar vacio")
            Return
        End If

        'Validamos que sea un numero'
        Dim id As Integer

        If Not Integer.TryParse(idS, id) Then
            MessageBox.Show("ERROR: Ingrese un valor numerico")
            Return
        End If

        'Validamos que el id no sea negativo'
        If id < 0 Then
            MessageBox.Show("ERROR: El numero de ID no puede ser negativo")
            Return
        End If

        'Validamos la consulta'
        Try

            'Creamos el DAO'
            Dim dao As New UsuariosDAO

            'Llamamos a la funcion GETBYID y le pasamos el ID obtenido del TextBox, el resultado lo guardamos en una variable'
            Dim usuario = dao.GetByID(id)

            'Validamos la existencia del Usuario'
            If usuario IsNot Nothing Then

                If usuario.Estado = "Inactivo" Then
                    'Mostramos un mensaje de exito y vaciamos los TextBox'
                    MessageBox.Show("No se pueden modificar usuarios INACTIVOS")
                    Return
                Else
                    dao.Update(id, nombre, clave)
                    Me.LimpiarCamposEditarUsurios()
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