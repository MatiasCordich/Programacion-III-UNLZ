Imports VeterinariaService.DAO

Public Class FormularioAccionesEspecie

#Region "Acciones"
    Private Sub LimpiarCamposBusquedaID()
        Txt_idEspecie.Text = ""
    End Sub

    Private Sub LimpiarCamposEditarEspecie()
        Txt_editarID.Text = ""
        Txt_nombreEspecie.Text = ""
        Txt_edadEspecie.Text = ""
        Txt_pesoEspecie.Text = ""
    End Sub

#End Region

#Region "Eventos"
    '---------------------------------- LISTAR ---------------------------------- '

    Private Sub Btn_listarEspecies_Click(sender As Object, e As EventArgs) Handles Btn_listarEspecies.Click
        Dim dao As New EspeciesDAO

        Dim listaUsuarios = dao.GetAll

        DGV_listaEspecies.DataSource = listaUsuarios
    End Sub

    '---------------------------------- BUSCAR ESPECIE POR ID ---------------------------------- '
    Private Sub Btn_busquedaEspecie_Click(sender As Object, e As EventArgs) Handles Btn_busquedaEspecie.Click

        'Tomamos el valor del TextBox'
        Dim idS = Txt_idEspecie.Text

        'Validamos que no sea vacio'
        If idS = "" Then
            MessageBox.Show("ERROR: El campo ID no puede estar vacio")
            Return
        End If

        'Validamos ID que sea un numero'
        Dim id As Integer

        If Not Integer.TryParse(idS, id) Then
            MessageBox.Show("ERROR: Ingrese un valor numerico")
            Return
        End If

        'Validamos que el ID no sea negativo'
        If id < 0 Then
            MessageBox.Show("ERROR: El numero de ID no puede ser negativo")
            Return
        End If


        Try

            'Creamos el DAO'
            Dim dao As New EspeciesDAO

            'Llamamos a la funcion GETBYID y le pasamos el ID obtenido del TextBox, el resultado lo guardamos en una variable'
            Dim especie = dao.GetByID(id)

            'Validamos lo que obtuvimos con GetByID'
            If especie IsNot Nothing Then

                Dim texto As String = "Sin especificar"


                LBL_idEspecie.Text = especie.EspecieID.ToString("#0")
                LBL_nombreEspecie.Text = especie.NombreEspecie.ToString

                If especie.EdadMadurez.ToString = "NULL" Then
                    LBL_edadEspecie.Text = texto
                Else
                    LBL_edadEspecie.Text = especie.EdadMadurez.ToString("#0")
                End If

                If especie.PesoPromedio.ToString = "NULL" Then
                    LBL_pesoEspecie.Text = texto
                Else
                    LBL_pesoEspecie.Text = especie.PesoPromedio.ToString("#0")
                End If
                Me.LimpiarCamposBusquedaID()

            Else
                'Caso contrario que se muestre un mensaje de error'
                MessageBox.Show("La especie no existe")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se puedo buscar al usuario")
        End Try
    End Sub

    '---------------------------------- EDITAR ESPECIE ---------------------------------- '
    Private Sub Btn_editarEspecie_Click(sender As Object, e As EventArgs) Handles Btn_editarEspecie.Click

        'Tomamos el valor del TextBox'
        Dim idS = Txt_editarID.Text
        Dim nombre = Txt_nombreEspecie.Text
        Dim edadS = Txt_edadEspecie.Text
        Dim pesoS = Txt_pesoEspecie.Text

        'Validamos que los campos ID, NOMBRE no sean nulos'
        If idS = "" Or nombre = "" Then
            MessageBox.Show("ERROR: Los campos ID, NOMBRE no pueden estar vacios")
            Return
        End If

        'Validamos que ID, EDAD y PESO sea un numero'
        Dim id As Integer
        Dim edad As Integer
        Dim peso As Integer

        If Not Integer.TryParse(idS, id) Or Not Integer.TryParse(edadS, edad) Or Not Integer.TryParse(pesoS, peso) Then
            MessageBox.Show("ERROR: Ingrese un valor numerico")
            Return
        End If

        'Validamos que el ID, PESO o EDAD no sea negativo'
        If id < 0 Or edad < 0 Or peso < 0 Then
            MessageBox.Show("ERROR: Los campos ID, EDAD o PESO no pueden ser negativos")
            Return
        End If

        'Validamos la consulta'
        Try

            'Creamos el DAO'
            Dim dao As New EspeciesDAO

            'Llamamos a la funcion GETBYID y le pasamos el ID obtenido del TextBox, el resultado lo guardamos en una variable'
            Dim especie = dao.GetByID(id)

            'Validamos la existencia del Usuario'
            If especie IsNot Nothing Then

                dao.Update(id, nombre, edad, peso)

                Me.LimpiarCamposEditarEspecie()
                MessageBox.Show($"La especie {especie.NombreEspecie} ha sido modifcado correctamente")
                Return

            Else
                MessageBox.Show("No se ha encontrado la especie para modificar")
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se puedo buscar al usuario")
        End Try
    End Sub

#End Region
End Class