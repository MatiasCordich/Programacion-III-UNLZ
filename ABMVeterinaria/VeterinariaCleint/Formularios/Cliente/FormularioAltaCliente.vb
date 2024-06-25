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

    '----------Funcion ALTA CLIENTES----------------'
    Private Sub Btn_altaCliente_Click(sender As Object, e As EventArgs) Handles Btn_altaCliente.Click
        'Tomamos valores txtboxes'

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

        'Validadcion- NO nombre duplicado'
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
            PB_cargaAltaCliente.Visible = True
            T_AltaCliente.Enabled = True
            LBL_descripcionAltaCliente.Visible = True
            LBL_descripcionAltaCliente.Text = "Cargando..."
            MessageBox.Show("Cliente cargado correctamente")
        End If
    End Sub


#End Region

#Region "Timers"
    Private Sub T_altaCliente_Tick(sender As Object, e As EventArgs) Handles T_altaCliente.Tick
        'Evaluamos el valor de la barra de carga'
        If PB_cargaAltaCliente.Value = PB_cargaAltaCliente.Maximum Then

            'Si es igual a su MAXIMO'

            'Limpiamos los Textbox y sacamos la barra de carga'
            Me.LimpiezaCampos()
            PB_cargaAltaCliente.Visible = False
            LBL_descripcionAltaCliente.Visible = False
        Else

            'Caso contrario incrementamos el valor del a barra de carga'
            Dim nuevoValor = PB_cargaAltaCliente.Value + 10
            PB_cargaAltaCliente.Value = Math.Min(nuevoValor, PB_cargaAltaCliente.Maximum)
        End If
    End Sub

#End Region

End Class