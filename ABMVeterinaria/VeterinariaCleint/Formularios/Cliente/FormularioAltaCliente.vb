Imports System.Windows.Forms.VisualStyles
Imports VeterinariaService.DAO
Imports VeterinariaService.Modelos

Public Class FormularioAltaCliente

#Region "Acciones"

    '------------LIMPIEZA CAMPOS----------'
    Private Sub LimpiezaCampos()
        Txt_nombreClienteAlta.Text = ""
        Txt_DNIClienteAlta.Text = ""
    End Sub

#End Region

#Region "Eventos"

    '----------------------------------- Funcion - ALTA CLIENTES -----------------------------------'
    Private Sub Btn_altaCliente_Click(sender As Object, e As EventArgs) Handles Btn_altaCliente.Click

        'Tomamos los valores de los TextBox'
        Dim nombre = Txt_nombreClienteAlta.Text.ToLower
        Dim dniS = Txt_DNIClienteAlta.Text

        'Validacion - NO campos vacios'
        If nombre = "" Or dniS = "" Then
            MessageBox.Show("ERROR: No puede haber campos vacios")
            Return
        End If

        'Validacion - DNI debe ser numerico'
        Dim dni As Integer

        If Not Integer.TryParse(dniS, dni) Then
            MessageBox.Show("ERROR: Ingrese un valor numerico para DNI")
            Return
        End If

        'Validacion - DNI deber ser positivo'
        If dni < 0 Then
            MessageBox.Show("ERROR: EL DNI debe ser POSITIVO")
            Return
        End If

        'Inicio DAO'
        Dim dao As New ClientesDAO

        'Validadcion- NO DNI duplicado'
        Dim listaClientes = dao.GetAll()

        For Each cliente As Cliente In listaClientes
            If cliente.DNI = dni Then
                MessageBox.Show("ERROR: El DNI de cliente ya existe, intente otro")
                Return
            End If
        Next

        'Si paso la validacion prosigo con la inserccion'
        Dim nuevoCliente As New Cliente(nombre, dni)

        If dao.Insert(nuevoCliente) Then

            'Muestreo - Componentes de carga'
            PB_cargaAltaCliente.Visible = True
            T_altaCliente.Enabled = True
            LBL_descripcionAltaCliente.Visible = True
            LBL_descripcionAltaCliente.Text = "Cargando..."
            MessageBox.Show("Cliente cargado correctamente")

            'Limpieza - Limpio los campos de los TextBox'
            Me.LimpiezaCampos()
        End If
    End Sub


#End Region

#Region "Timers"

    '----------------------- Funcion TIMER ALTA CLIENTE -----------------------'
    Private Sub T_altaCliente_Tick(sender As Object, e As EventArgs) Handles T_altaCliente.Tick

        ' 'Validacion - Valor de la PB'
        If PB_cargaAltaCliente.Value = PB_cargaAltaCliente.Maximum Then

            'Limpieza - Ocultamos Texbox y PB de carga'
            PB_cargaAltaCliente.Visible = False
            LBL_descripcionAltaCliente.Visible = False
        Else

            'Caso contrario - Incrementamos el valor de la PB'
            Dim nuevoValor = PB_cargaAltaCliente.Value + 10
            PB_cargaAltaCliente.Value = Math.Min(nuevoValor, PB_cargaAltaCliente.Maximum)
        End If
    End Sub

#End Region

End Class