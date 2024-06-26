Imports VeterinariaService.DAO
Imports VeterinariaService.Modelos

Public Class FormularioAltaAnimal

#Region "Eventos"

    '----------------------------------- CLICK ALTA ANIMAL -----------------------------------'
    Private Sub Btn_altaAnimal_Click(sender As Object, e As EventArgs) Handles Btn_altaAnimal.Click

        'Tomamos los valores de los TextBox'
        Dim nombre = Txt_nombreAltaAnimal.Text.ToLower
        Dim pesoS = Txt_pesoAltaAnimal.Text
        Dim edadS = Txt_edadAltaAnimal.Text
        Dim clienteIDs = Txt_clienteIDAltaAnimal.Text
        Dim especieIDs = Txt_especieIDAltaAnimal.Text

        'Validamos que los campos ID, NOMBRE, PESO, EDAD, CLIENTE ID  no sean nulos'
        If nombre = "" Or pesoS = "" Or
            edadS = "" Or clienteIDs = "" Or
            especieIDs = "" Then
            MessageBox.Show("ERROR: Todos los campos son obligatorios.")
            Return
        End If

        'Validamos que ID, PESO, EDAD, CLIENTE ID sea numerico y positivo'
        Dim peso As Decimal
        Dim edad, clienteID, especieID As Integer


        If Not Decimal.TryParse(pesoS, peso) Or peso < 0 Or
            Not Integer.TryParse(edadS, edad) Or edad < 0 Or
            Not Integer.TryParse(clienteIDs, clienteID) Or clienteID < 0 Or
            Not Integer.TryParse(especieIDs, especieID) Or especieID < 0 Then
            MessageBox.Show("ERROR: Ingrese valores numericos positivos.")
            Return
        End If

        'Validacion - Existe el ClienteID' 
        Dim daoClientes As New ClientesDAO
        Dim listaClientes = daoClientes.GetAll()

        Dim clienteExiste As Boolean = False
        For Each cliente As Cliente In listaClientes
            If cliente.ClienteID = clienteID Then
                clienteExiste = True
                Exit For
            End If
        Next

        If Not clienteExiste Then
            MessageBox.Show("ERROR: El cliente no existe, por favor ingrese un cliente existente.")
            Return
        End If

        'Validacion - Existe la EspecieID'
        Dim daoEspecies As New EspeciesDAO
        Dim listaEspecies = daoEspecies.GetAll()

        Dim especieExiste As Boolean = False
        For Each especie As Especie In listaEspecies
            If especie.EspecieID = especieID Then
                especieExiste = True
                Exit For
            End If
        Next

        If Not especieExiste AndAlso especieID <> 0 Then
            MessageBox.Show("ERROR: No existe la especie, si no sabe la especie ingrese uno (1)")
            Return
        End If

        'Creamos el DAO'
        Dim dao As New AnimalesDAO

        'Si paso la validacion prosigo con la inserccion'
        Dim nuevoAnimal As New Animal(nombre, peso, edad, clienteID, especieID)

        'Valido la accion'
        If dao.Insert(nuevoAnimal) Then

            T_altaAnimal.Enabled = True
            PB_cargaAltaAnimal.Visible = True

            LBL_descripcionAltaAnimal.Visible = True
            LBL_descripcionAltaAnimal.Text = "Cargando..."
            MessageBox.Show("Mascota cargada correctamente")

            Txt_nombreAltaAnimal.Text = ""
            Txt_pesoAltaAnimal.Text = ""
            Txt_edadAltaAnimal.Text = ""
            Txt_clienteIDAltaAnimal.Text = ""
            Txt_especieIDAltaAnimal.Text = ""


        End If
    End Sub


#End Region

#Region "Timers"
    Private Sub T_altaAnimal_Tick(sender As Object, e As EventArgs) Handles T_altaAnimal.Tick

        'Evaluamos el valor de la barra de carga'
        If PB_cargaAltaAnimal.Value = PB_cargaAltaAnimal.Maximum Then

            'Si es igual a su MAXIMO'

            'Limpiamos los Textbox y sacamos la barra de carga'
            PB_cargaAltaAnimal.Visible = False
            LBL_descripcionAltaAnimal.Visible = False
        Else

            'Caso contrario incrementamos el valor del a barra de carga'
            Dim nuevoValor = PB_cargaAltaAnimal.Value + 10
            PB_cargaAltaAnimal.Value = Math.Min(nuevoValor, PB_cargaAltaAnimal.Maximum)
        End If
    End Sub
#End Region

End Class