Imports ProductosService.DAO
Imports ProductosService.Models

Public Class Form1

#Region "Acciones"
    Private Sub EliminarCamposInsert()
        txt_nombreInsert.Text = ""
        txt_tipoInsert.Text = ""
        txt_precioInsert.Text = ""
    End Sub

    Private Sub EliminarCamposUpdate()
        txt_idUpdate.Text = ""
        txt_nombreUpdate.Text = ""
        txt_tipoUpdate.Text = ""
        txt_precioUpdate.Text = ""
    End Sub

    Private Sub EliminarCampoDelete()
        txt_idDelete.Text = ""
    End Sub

    Private Sub EliminarCampoBuscar()
        txt_getByID.Text = ""
    End Sub
#End Region


#Region "Eventos"

    'Evento clic para listar todos los productos'
    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        'Creamos el DAO'
        Dim dao As New ProductosDAO

        'Invocamos la funcion GETALL para obtener todos los datos'
        Dim productos = dao.GetAll

        'Con lo obtenido lo pasamos a la DataGrid'
        dtGrid_productos.DataSource = productos
    End Sub

    'Evento clic para buscar un prouducto por su ID'
    Private Sub btn_buscarPorID_Click(sender As Object, e As EventArgs) Handles btn_buscarPorID.Click

        'Tomamos el valor del TextBox'
        Dim idS = txt_getByID.Text

        'Validamos que no sea vacio'
        If idS = "" Then
            MessageBox.Show("ERROR: El campo ID no puede estar vacio")
            Return
        End If

        'Validamos que sea un numero'
        Try
            Dim id As Integer = txt_getByID.Text

            'Validamos que el id no sea negativo'
            If id < 0 Then
                MessageBox.Show("ERROR: El numero de ID no puede ser negativo")
                Return
            End If

            'Creamos el DAO'
            Dim dao As New ProductosDAO

            'Llamamos a la funcion GETBYID y le pasamos el ID obtenido del TextBox, el resultado lo guardamos en una variable'
            Dim producto = dao.GetByID(id)

            'Validamos lo que obtuvimos con GetByID Y guardamos en la variable PRODUCTO'
            If producto IsNot Nothing Then

                'Si existe un producto que lo muestre en los Labels'
                lbl_ID.Text = producto.id.ToString("#0")
                lbl_Nombre.Text = producto.nombre
                lbl_Tipo.Text = producto.tipoProducto_id.ToString("#0")
                lbl_Precio.Text = producto.precio.ToString("#0.00")

                'Vaciamos el TextBox'
                Me.EliminarCampoBuscar()
            Else
                'Caso contrario que se muestre un mensaje de error'
                MessageBox.Show("El producto no existe")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: Por favor, ingrese un valor numerico")
        End Try

    End Sub

    'Funcion para agregar un producto a la lista'
    Private Sub btn_agregarProducto_Click(sender As Object, e As EventArgs) Handles btn_agregarProducto.Click

        'Tomamos los valores de los TextBox'
        Dim nombre = txt_nombreInsert.Text
        Dim tipoS = txt_tipoInsert.Text
        Dim precioS = txt_precioInsert.Text

        'Valido que no haya campos vacios'
        If nombre = "" Or precioS = "" Then
            MessageBox.Show("ERROR: Los campos NOMBRE y PRECIO no pueden estar vacios")
            Return
        End If

        'Validamos que los valores de TIPO y PRECIO sean numericos'
        Try
            Dim tipo As Integer = txt_tipoInsert.Text
            Dim precio As Integer = txt_precioInsert.Text

            'Validamos que TIPO y PRECIO no sean negativos'
            If tipo < 0 Or precio < 0 Then
                MessageBox.Show("ERROR: Por favor, ingrese valores POSITIVOS")
                Return
            End If

            'Creamos el objeto de tipo Producto con los datos'
            Dim nuevoProducto As New Producto(nombre, tipo, precio)

            'Creamos el DAO'
            Dim dao As New ProductosDAO

            'Realizamos la consulta de insertar el nuevo producto'
            If dao.Insert(nuevoProducto) Then

                'Si todo salio bien, se muestra un mensaje de exito y se vacian los TextBox'
                MessageBox.Show("Producto agregado correctamente")
                Me.EliminarCamposInsert()
                Return
            Else
                'Caso contrario, se muestra un mensaje de error'
                MessageBox.Show("No se pudo agregar el producto")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: Por favor, ingrese valores numericos en TIPO y PRECIO")
        End Try

    End Sub

    'Evento clic para guardar los cambios a un producto'
    Private Sub btn_guardarCambios_Click(sender As Object, e As EventArgs) Handles btn_guardarCambios.Click

        'Tomamos los valores de los TextBox'
        Dim idS = txt_idUpdate.Text
        Dim nombre = txt_nombreUpdate.Text
        Dim tipoS = txt_tipoUpdate.Text
        Dim precioS = txt_precioUpdate.Text

        'Valido que no haya campos vacios'
        If idS = "" Or nombre = "" Or precioS = "" Then
            MessageBox.Show("ERROR: Los campos ID, NOMBRE y PRECIO no pueden estar vacios")
            Return
        End If

        'Validamos que los valores de ID, TIPO y PRECIO sean numericos'
        Try
            Dim id As Integer = txt_idUpdate.Text
            Dim tipo As Integer = txt_tipoUpdate.Text
            Dim precio As Integer = txt_precioUpdate.Text

            'Validamos que ID, TIPO y PRECIO no sean negativos'
            If id < 0 Or tipo < 0 Or precio < 0 Then
                MessageBox.Show("ERROR: Por favor, ingrese valores POSITIVOS")
                Return
            End If

            'Creamos el DAO'
            Dim dao As New ProductosDAO

            'Validamos que exista el Producto'
            Dim producto = dao.GetByID(id)

            If producto IsNot Nothing Then

                'Si el producto existe, entonces hacemos realizamos la llamada SQL'
                dao.Update(id, nombre, tipo, precio)

                'Mostramos un mensaje de exito y vaciamos los TextBox'
                MessageBox.Show("Producto modificado correctamente")
                Me.EliminarCamposUpdate()
                Return
            Else

                'Si el producto a modificar no se enconetro, lanzamos un mensaje'
                MessageBox.Show("No se encontro el producto a modificar")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: Por favor, ingrese valores numericos en ID, TIPO y PRECIO")
        End Try
    End Sub

    'Evento clic donde eliminamos un proudcto'
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        'Tomamos el valor del TextBox'
        Dim idS = txt_idDelete.Text

        'Valido que no haya campo vacios'
        If idS = "" Then
            MessageBox.Show("ERROR: Por favor, ingrese un numero")
            Return
        End If

        'Validamos que el valor del TextBox sea numerico'
        Try
            Dim id As Integer = txt_idDelete.Text

            'Validamos que el ID no sea negativo'
            If id < 0 Then
                MessageBox.Show("ERROR: Por favor, ingrese un ID POSITIVO")
                Return
            End If

            'Creamos el DAO'
            Dim dao As New ProductosDAO

            'Validamos que exista el Producto'
            Dim producto = dao.GetByID(id)

            If producto IsNot Nothing Then

                'Si el producto existe, entonces hacemos realizamos la llamada SQL'
                dao.Delete(id)

                'Mostramos un mensaje de exito y vaciamos el Textbox'
                MessageBox.Show("Producto eliminado correctamente")
                Me.EliminarCampoDelete()
                Return
            Else

                'Caso contrario, mostramos un mensaje de error'
                MessageBox.Show("No se encontro el producto a eliminar")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: Por favor, ingrese un valor NUMERICO")
        End Try
    End Sub
#End Region


End Class
