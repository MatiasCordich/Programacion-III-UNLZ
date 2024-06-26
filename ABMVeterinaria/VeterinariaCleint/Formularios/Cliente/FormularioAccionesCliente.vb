Imports VeterinariaService.DAO
Imports VeterinariaService.Modelos

Public Class FormularioAccionesCliente

#Region "Acciones"
    Private Sub LimpiarCamposBusquedaID()
        Txt_idCliente.Text = ""
    End Sub

    Private Sub LimpiarCamposEditarCliente()
        Txt_editarIDCliente.Text = ""
        Txt_nombreEditarCliente.Text = ""
        Txt_dniEditarCliente.Text = ""
    End Sub

#End Region

#Region "Eventos"

    '------------------- FUNCION - LISTAR CLIENTES ----------------------------'
    Private Sub Btn_listarClientes_Click(sender As Object, e As EventArgs) Handles Btn_listarClientes.Click

        'Declaracion - Dao y conexion a dataGridView'

        Dim dao As New ClientesDAO
        Dim listaClientes = dao.GetAll

        DGV_listaClientes.DataSource = listaClientes
    End Sub

    '------------------- FUNCION - BUSCAR CLIENTE POR ID ----------------------------'
    Private Sub Btn_busquedaCliente_Click(sender As Object, e As EventArgs) Handles Btn_busquedaCliente.Click

        'Tomamos el valor del TextBox'
        Dim IdS = Txt_idCliente.Text

        'Validacion - NO TextBox vacio'
        If IdS = "" Then
            MessageBox.Show("ERROR: El campo ID no puede estar vacio")
            Return
        End If

        'Validacion - TextBox numerico'
        Dim id As Integer

        If Not Integer.TryParse(IdS, id) Then
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

            Dim dao As New ClientesDAO

            'Funcion - GETBYID con ID obtenido de TextBox y guardamos el resultado en una variable'
            Dim cliente = dao.GetByID(id)

            'Validacion - Lo obtenido por el GetBydID'
            If cliente IsNot Nothing Then

                'Si el Cliente existe, entonces'
                'Muestreo - Labels de resultado'
                LBL_idDescripcionCliente.Text = cliente.ClienteID.ToString("#0")
                LBL_nombreDescripcionCliente.Text = cliente.Nombre.ToString()
                LBL_descripcionEstadoCliente.Text = cliente.Estado.ToString.ToUpper()
                LBL_dniCliente.Text = cliente.DNI.ToString()

                'Validacion - Estado del Usuario (cambio de color)'
                If cliente.Estado = "Inactivo" Then
                    LBL_descripcionEstadoCliente.ForeColor = Color.Red
                Else
                    LBL_descripcionEstadoCliente.ForeColor = Color.Green

                End If

                'Limpieza - Limpio el TextBox'
                Me.LimpiarCamposBusquedaID()
            Else

                'Caso contrario- Muestro mensaje de de error'
                MessageBox.Show("ERROR: El cliente no existe")
                Return

            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se pudo buscar al Cliente")
        End Try
    End Sub

    '------------------- FUNCION - EDITAR CLIENTE ----------------------------'
    Private Sub Btn_editarCliente_Click(sender As Object, e As EventArgs) Handles Btn_editarCliente.Click

        'Tomamos los valores de los TextBox'
        Dim IdS = Txt_editarIDCliente.Text
        Dim nombre = Txt_nombreEditarCliente.Text.ToLower
        Dim dniS = Txt_dniEditarCliente.Text

        'Validacion - NO campos nulos'
        If IdS = "" Or nombre = "" Or dniS = "" Then
            MessageBox.Show("ERROR: Ningun campo puede estar vacio")
            Return
        End If

        'Validacion - ID y DNI numerico'
        Dim id As Integer
        Dim dni As Integer

        If Not Integer.TryParse(IdS, id) Or Not Integer.TryParse(dniS, dni) Then
            MessageBox.Show("ERROR: Ingrese un valor numerico")
            Return
        End If

        'Validacion - ID y DNI numero positivo'
        If id < 0 Or dni < 0 Then
            MessageBox.Show("Error: Ingrese un valor positivo")
            Return
        End If

        'Validacion - consulta TRY CATCH'
        Try
            'Creacion del DAO'
            Dim dao As New ClientesDAO

            'Funcion - GETBYID, le pasamos el ID del TextBox y lo guardamos en una variable'
            Dim clienteEncontrado = dao.GetByID(id)

            'Validacion - Existencia Cliente'
            If clienteEncontrado IsNot Nothing Then

                'Validacion - Estado del Cliente'
                If clienteEncontrado.Estado = "Inactivo" Then

                    MessageBox.Show("No se pueden modificar clientes INACTIVOS")
                    Return
                Else

                    'Validacion - DNI unico excluyendo el DNI del cliente actual'
                    Dim listaClientes = dao.GetAll

                    For Each cliente As Cliente In listaClientes
                        If cliente.DNI = dni AndAlso cliente.ClienteID <> id Then
                            MessageBox.Show("ERROR: El DNI ingresado ya existe, por favor ingrese otro")
                            Return
                        End If
                    Next

                    'Caso contrario - Proseguimos con el UPDATE'
                    dao.Update(id, nombre, dni)

                    'Mensaje - Mostramos un mensaje de exito'
                    MessageBox.Show($"El cliente {clienteEncontrado.Nombre} ha sido modifcado correctamente")

                    'Limpieza - Limpiamos los campos de los TextBox'
                    Me.LimpiarCamposEditarCliente()
                    Return
                End If
            Else
                MessageBox.Show("No se ha encontrado el cliente para modificar")
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se puedo buscar el cliente")
        End Try
    End Sub

#End Region

End Class