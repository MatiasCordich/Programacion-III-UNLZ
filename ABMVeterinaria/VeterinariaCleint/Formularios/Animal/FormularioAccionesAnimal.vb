Imports VeterinariaService.DAO

Public Class FormularioAccionesAnimal

#Region "Acciones"
    Private Sub LimpiarCamposBusquedaID()
        Txt_idAnimal.Text = ""
    End Sub

    Private Sub LimpiarCamposEditarAnimal()
        Txt_editarAnimalID.Text = ""
        Txt_nombreEditar.Text = ""
        Txt_edadEditar.Text = ""
        Txt_pesoEditar.Text = ""
        Txt_clienteIDEditar.Text = ""
        Txt_especieIDEditar.Text = ""
    End Sub

#End Region

    '---------------------------------- LISTAR ---------------------------------- '
    Private Sub Btn_listarAnimales_Click(sender As Object, e As EventArgs) Handles Btn_listarAnimales.Click
        Dim dao As New AnimalesDAO

        Dim listaAnimales = dao.GetAll

        DGV_listaAnimales.DataSource = listaAnimales
    End Sub

    '---------------------------------- BUSCAR POR ID ---------------------------------- '
    Private Sub Btn_busquedaAnimal_Click(sender As Object, e As EventArgs) Handles Btn_busquedaAnimal.Click
        'Tomamos el valor del TextBox'
        Dim idS = Txt_idAnimal.Text

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
            Dim dao As New AnimalesDAO

            'Llamamos a la funcion GETBYID y le pasamos el ID obtenido del TextBox, el resultado lo guardamos en una variable'
            Dim animal = dao.GetByID(id)

            'Validamos lo que obtuvimos con GetByID Y guardamos en la variable PRODUCTO'
            If animal IsNot Nothing Then

                LBL_idAnimal.Text = animal.AnimalID.ToString("#0")
                LBL_nombreAnimal.Text = animal.Nombre.ToString
                LBL_edadAnimal.Text = animal.Edad.ToString("#0")
                LBL_clienteID.Text = animal.ClienteID.ToString("#0")
                LBL_pesoAnimal.Text = animal.Peso.ToString("#0.00")
                LBL_estadoAnimal.Text = animal.Estado.ToString.ToUpper

                If animal.EspecieID = 1 Then
                    LBL_especieAnimal.Text = "Sin especificar"
                Else
                    LBL_especieAnimal.Text = animal.EspecieID.ToString("#0")
                End If

                If animal.Estado = "Difunto" Then
                    LBL_estadoAnimal.ForeColor = Color.Red
                Else
                    LBL_estadoAnimal.ForeColor = Color.Green
                End If

                Me.LimpiarCamposBusquedaID()

            Else
                'Caso contrario que se muestre un mensaje de error'
                MessageBox.Show("El animal no existe")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show($"ERROR: {ex.Message}")
        End Try
    End Sub

    '---------------------------------- EDITAR ---------------------------------- '
    Private Sub Btn_editarAnimal_Click(sender As Object, e As EventArgs) Handles Btn_editarAnimal.Click
        'Tomamos el valor del TextBox'
        Dim idS = Txt_editarAnimalID.Text
        Dim nombre = Txt_nombreEditar.Text.ToLower
        Dim pesoS = Txt_pesoEditar.Text
        Dim edadS = Txt_edadEditar.Text
        Dim clienteIDs = Txt_clienteIDEditar.Text
        Dim especieIDs = Txt_especieIDEditar.Text

        'Validamos que los campos ID, NOMBRE, PESO, EDAD, CLIENTE ID  no sean nulos'
        If idS = "" Or nombre = "" Or pesoS = "" Or edadS = "" Or clienteIDs = "" Or especieIDs = "" Then
            MessageBox.Show("ERROR: Los campos ID, NOMBRE, PESO, EDAD, CLIENTE ID y ESPECIE ID no pueden estar vacios")
            Return
        End If

        'Validamos que ID, PESO, EDAD, CLIENTE ID y ESPECIE ID sea un numero'
        Dim id As Integer
        Dim peso As Decimal
        Dim edad As Integer
        Dim clienteID As Integer
        Dim especieID As Integer


        If Not Integer.TryParse(idS, id) Or Not Decimal.TryParse(pesoS, peso) Or Not Integer.TryParse(edadS, edad) Or Not Integer.TryParse(clienteIDs, clienteID) Or Not Integer.TryParse(especieIDs, especieID) Then
            MessageBox.Show("ERROR: Ingrese un valor numerico")
            Return
        End If

        'Validamos que el ID, PESO, EDAD, CLIENTE ID y ESPECIE ID no sea negativo'
        If id < 0 Or peso < 0 Or edad < 0 Or clienteID < 0 Or especieID < 0 Then
            MessageBox.Show("ERROR: Los campos ID, PESO, EDAD, CLIENTE ID y ESPECIE ID no pueden ser negativos")
            Return
        End If

        'Validamos la consulta'
        Try

            'Creamos el DAO'
            Dim dao As New AnimalesDAO

            'Llamamos a la funcion GETBYID y le pasamos el ID obtenido del TextBox, el resultado lo guardamos en una variable'
            Dim animal = dao.GetByID(id)

            'Validamos la existencia del Animal'
            If animal IsNot Nothing Then

                If animal.Estado = "Difunto" Then
                    'Mostramos un mensaje de exito y vaciamos los TextBox'
                    MessageBox.Show("No se pueden modificar animales DIFUNTOS")
                    Return
                Else
                    dao.Update(id, nombre, peso, edad, clienteID, especieID)
                    MessageBox.Show($"La mascota {animal.Nombre} ha sido modifcado correctamente")
                    Me.LimpiarCamposEditarAnimal()
                    Return
                End If
            Else
                MessageBox.Show("No se ha encontrado el animal para modificar")
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se pudo modificar la mascota")
        End Try
    End Sub


End Class