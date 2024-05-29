Public Class Form1
#Region "Dependencias"
    Dim dtClientes As New DataTable
#End Region

#Region "Inicializar"

    'Incializamos la DataTable con la estructura'
    Private Sub InicializarDataTable()
        Dim dt As New DataTable

        dt.Columns.Add("DNI")
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Apellido")
        dt.Columns.Add("Localidad")
        dt.Columns.Add("Edad")
        dt.Columns.Add("Plan")

        'Llamamos a la funcion SetDataTable para que apunte a la DataGrid'
        Me.SetDataTable(dt)
    End Sub
#End Region

#Region "Funciones"
    'Funcio que apunte la DataTable a la DataGrid'
    Private Sub SetDataTable(dt As DataTable)
        Me.dtClientes = dt
        dtGrid_Cliente.DataSource = dt
    End Sub

    'Funcion de calcular el promedio de edad'
    Private Sub CalcularPromedioEdad()

        'Variable acumuladora de la edad de los clientes'
        Dim acumuladorEdadClientes As Integer = 0

        'Recorremos el DataTable'
        For Each renglon As DataRow In Me.dtClientes.Rows

            'Sumamos las edades de cada Fila'
            acumuladorEdadClientes += renglon("Edad")
        Next

        'Sacamos el promedio de edad'
        Dim promedioEdad As Double = acumuladorEdadClientes / Me.dtClientes.Rows.Count

        'Visualizamos el promedio de edad en el label'
        lbl_promedioEdad.Text = promedioEdad.ToString("#0.00")

    End Sub

    'Calculamos la cantidad de cliente de Buenos Aires'
    Private Sub CalcularClientesDeBuenosAires()

        'Hacemos una variable acumuladora'
        Dim contadorClientesBuenosAires As Integer = 0

        'Recorremos el DataTable'
        For Each renglon As DataRow In Me.dtClientes.Rows

            'De cada RENGLON tomamos la Localidad'
            Dim localidad As String = renglon("Localidad")

            'Si la localidad es de BUENOS AIRES'
            If localidad.ToUpper().Contains("BUENOS AIRES") Then
                'Incrementa en uno el contador de clientes que son de Buenos Aires'
                contadorClientesBuenosAires += 1
            End If
        Next

        'Visualizamos el resultado del contador en el label'
        lbl_clientesBsAs.Text = contadorClientesBuenosAires.ToString()
    End Sub

    'Funcion para buscar al cliente mas joven'
    Private Sub BuscarClienteMasJoven()

        'Seteo la variable MIN dandole el valor entero mas grande'
        Dim edadClienteMasJoven As Integer = Integer.MaxValue

        'Vamos a tomar el dni del cliente mas joven y lo vamos a guardar en esta variable'
        Dim dniClienteMasJoven As Long

        'Recorremos la DataTable'
        For Each renglon As DataRow In Me.dtClientes.Rows

            'Por cada renglon tomamos la edad de turno'
            Dim edad As Integer = Convert.ToInt32(renglon("Edad"))

            'Comparamos la variable edad con la variable MIN de edadClienteMasJoven'
            If edad < edadClienteMasJoven Then

                'Si la edad de turno es mas chica que la edadClienteMasJoven entonces el nuevo valor de la variable MIN sera esa edad de turno'
                edadClienteMasJoven = edad

                'Tomamos el DNI del cliente mas joven del renglon de turno'
                dniClienteMasJoven = Convert.ToInt64(renglon("DNI"))
            End If
        Next

        'Visualizamos el DNI del cliente mas joven en el label'
        lbl_clienteJoven.Text = dniClienteMasJoven.ToString()
    End Sub

    'Funcion para buscar el cliente mas viejo'
    Private Sub BuscarClienteMasViejo()

        'Seteo la variable MAX dandole el valor del valor entero mas chico'
        Dim edadClienteMasViejo As Integer = Integer.MinValue

        'Vamos a tomar el dni del cliente mas joven y lo vamos a guardar en esta variable'
        Dim dniClienteMasViejo As Long

        'Recorremos la DataTable'
        For Each renglon As DataRow In Me.dtClientes.Rows

            'Por cada renglon tomamos la edad de turno'
            Dim edad As Integer = Convert.ToInt32(renglon("Edad"))

            'Comparamos la variable edad con la variable MAX de edadClienteMasViejo'
            If edad > edadClienteMasViejo Then
                'Si la edad de turno es mas grande que la edadClienteMasViejo entonces el nuevo valor de la variable MAX sera esa edad de turno'
                edadClienteMasViejo = edad

                'Tomamos el DNI del cliente mas viejo del renglon de turno'
                dniClienteMasViejo = Convert.ToInt64(renglon("DNI"))
            End If
        Next

        'Visualizamos el DNI del cliente mas viejo en el label'
        lbl_clienteViejo.Text = dniClienteMasViejo.ToString()
    End Sub

    'Funcion para actualizar las estadisticas de clientes adheridos a los planes' 
    Private Sub ActualizarEstadisticas()

        'Nuestaras contadoras'
        Dim contadorLite As Integer = 0
        Dim contadorBasic As Integer = 0
        Dim contadorPro As Integer = 0

        'Recorremos la DataTable'
        For Each renglon As DataRow In Me.dtClientes.Rows

            'Por cada renglon de turno tomamos el Plan'
            Dim plan As String = renglon("Plan")

            'Evaluamos que plan es de Turno'
            If plan.ToUpper().Contains("LITE") Then
                contadorLite += 1
            ElseIf plan.ToUpper().Contains("BASIC") Then
                contadorBasic += 1
            Else
                contadorPro += 1
            End If
        Next

        'Visualizamos los resultados de los contadores'
        lbl_Lite.Text = contadorLite.ToString()
        lbl_Basic.Text = contadorBasic.ToString()
        lbl_Pro.Text = contadorPro.ToString()
    End Sub

    'Funcion para limpiar los TextBoxes una vez agregado el cliente'
    Private Sub LimpiarTextBoxes()
        txt_DNI.Text = ""
        txt_Nombre.Text = ""
        txt_Apellido.Text = ""
        txt_Localidad.Text = ""
        txt_Edad.Text = ""
    End Sub


#End Region

#Region "Eventos"

    'Evento Load donde se inicializa la DataTable'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InicializarDataTable()
    End Sub

    'Evento click donde agrego el cliente a la DataTable'
    Private Sub btn_AgregarCliente_Click(sender As Object, e As EventArgs) Handles btn_AgregarCliente.Click

        'Tomo los valores de los TextBoxes'
        Dim nombre = txt_Nombre.Text
        Dim apellido = txt_Apellido.Text
        Dim localidad = txt_Localidad.Text
        Dim plan = cmbox_Plan.SelectedItem.ToString()

        'Realizo algunas validaciones'
        Try

            'Valido que el DNI y la EDAD se le ingresen valores numericos'
            Dim dni As Long = Long.Parse(txt_DNI.Text)
            Dim edad As Integer = Integer.Parse(txt_Edad.Text)

            'Valido que el DNI ingresado sea UNICO'
            For Each renglon As DataRow In Me.dtClientes.Rows
                If renglon("DNI") = dni Then
                    MessageBox.Show("El DNI ya existe. Por favor, ingrese un DNI unico")
                    Return
                End If
            Next

            'Si todo salio bien, que me agregue una nueva FILA a la DataTable con los valores obtenidos'
            Me.dtClientes.Rows.Add(dni, nombre, apellido, localidad, edad, plan)

            'Llamo a las funciones de la otra region cuando haga click para mantener la APP actualizada y dinamica'
            Me.CalcularPromedioEdad()
            Me.CalcularClientesDeBuenosAires()
            Me.BuscarClienteMasJoven()
            Me.BuscarClienteMasViejo()
            Me.ActualizarEstadisticas()
            Me.LimpiarTextBoxes()
        Catch ex As Exception
            MessageBox.Show("El valor deber ser NUMERICO")
        End Try

    End Sub
#End Region
End Class
