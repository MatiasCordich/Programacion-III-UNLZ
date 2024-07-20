Imports ABM_Remera_Services.Models
Imports ABM_Remera_Services.Services

Public Class FormAltaRemera

    Private listaRemerasHijo As List(Of Remera)


    '------------- CONSTRUCTOR -------------'
    Public Sub New(listaRemeras As List(Of Remera))

        ' Inicializamos el componente
        InitializeComponent()

        'A la lista del hijo se le asigna como valor la lista del padre
        'No hace falta inicializarla porque le pasamos la lista del padre que ya fue inicializada
        Me.listaRemerasHijo = listaRemeras

        'Inicializamos la DataGrid con lo que haya de informacion en la lista del Padre
        Dgv_listaRemeras.DataSource = listaRemerasHijo

    End Sub

    '------------- Metodos -------------'
    Private Sub LimpiarCamposAlta()
        Txt_codigoAlta.Text = ""
        Txt_detalleAlta.Text = ""
        Txt_precioAlta.Text = ""
        Cb_talleAlta.SelectedIndex = 0
    End Sub

    Private Sub CargarDatos()

        'Calculamos el precio promedio de la remeras con talle L'
        Dim promedioPrecioL As Double = RemeraServices.CalcuarPromedioPrecioL(listaRemerasHijo)

        'Calculamos el total de remeras con talle XL'
        Dim cantidadTalleXL As Integer = RemeraServices.CantidadRemerasXL(listaRemerasHijo)

        'Muestro los resultados en las tablas'
        Lbl_descripcionPromedio.Text = promedioPrecioL.ToString("#0.00")
        Lbl_descripcionCantidad.Text = cantidadTalleXL.ToString

    End Sub

    '------------- Alta de Remera -------------'
    Private Sub Btn_AltaRemera_Click(sender As Object, e As EventArgs) Handles Btn_AltaRemera.Click

        'Tomamos los valores de los TextBox y ComboBox'
        Dim codigo As String = Txt_codigoAlta.Text.ToUpper
        Dim detalle As String = Txt_detalleAlta.Text
        Dim precioS As String = Txt_precioAlta.Text
        Dim talle As String = Cb_talleAlta.SelectedItem.ToString

        'Validaciones'

        ' Validamos que codigo, detalle y precio no sean valores vacios
        If String.IsNullOrEmpty(codigo) OrElse String.IsNullOrEmpty(detalle) OrElse String.IsNullOrEmpty(precioS) Then
            MessageBox.Show("No puede haber campos vacios")
            Return
        End If

        ' Validamos que el codigo ingresado sea unico
        If listaRemerasHijo.Any(Function(remera) remera.Codigo = codigo) Then
            MessageBox.Show("El código ingresado ya existe. Ingrese un código único.")
            Return
        End If

        ' Validamos que precio sea numerico y positivo
        Dim precio As Double
        If Not Double.TryParse(precioS, precio) OrElse precio <= 0 Then
            MessageBox.Show("Ingrese un valor válido para el precio.")
            Return
        End If

        ' Validamos que el codigo ingresado sea unico
        If listaRemerasHijo.Any(Function(remera) remera.Codigo = codigo) Then
            MessageBox.Show("El código ingresado ya existe. Ingrese un código único.")
            Return
        End If

        ' Si paso todas las validaciones creamos el nuevo objeto de tipo Remera
        Dim nuevaRemera As New Remera(codigo, detalle, precio, talle)

        ' Agregamos la remera a la lista
        listaRemerasHijo.Add(nuevaRemera)

        ' Limpiamos siempre la DataGrid para refrescar con la informacion nueva
        Dgv_listaRemeras.DataSource = Nothing

        ' Volcamos la informacion en la DataGrid
        Dgv_listaRemeras.DataSource = listaRemerasHijo

        ' Cargo de vuelta los datos actualizados
        Me.CargarDatos()

        ' Limpiar campos
        LimpiarCamposAlta()


    End Sub
End Class