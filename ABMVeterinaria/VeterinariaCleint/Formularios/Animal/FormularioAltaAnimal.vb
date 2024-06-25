Imports VeterinariaService.DAO
Imports VeterinariaService.Modelos

Public Class FormularioAltaAnimal

#Region "Acciones"
    Private Sub LimpiarCampos()
        Txt_nombreAltaAnimal.Text = ""
        Txt_pesoAltaAnimal.Text = ""
        Txt_edadAltaAnimal.Text = ""
        Txt_clienteIDAltaAnimal.Text = ""
        Txt_especieIDAltaAnimal.Text = ""
    End Sub
#End Region

#Region "Eventos"

    '----------------------------------- CLICK ALTA ANIMAL -----------------------------------'
    Private Sub Btn_altaAnimal_Click(sender As Object, e As EventArgs) Handles Btn_altaAnimal.Click

        'Tomamos los valores de los TextBox'
        Dim nombre = Txt_nombreAltaAnimal.Text
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

        'Validacion de especie'
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
            PB_cargaAltaAnimal.Visible = True

            LBL_descripcionAltaAnimal.Visible = True
            LBL_descripcionAltaAnimal.Text = "Cargando..."
            MessageBox.Show("Usuario cargado correctamente")
        End If
    End Sub
#End Region

End Class