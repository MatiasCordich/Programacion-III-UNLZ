Public Class Form1

    'En esta region estaran las dependencias necesarios para poder trabajar'
#Region "Dependencias"

    'Nuestra DataTable para que funcione el Programa'
    Private dtProductos As DataTable
#End Region

    'En esta region estan todas las funcioes para que funcione nuestra aplicacion de windows Forms' 
#Region "Acciones"

    'Esta funcion lo que hace es que la DataTable de Articulos APUNTE a nuestra DataGrid'
    Private Sub SetDataTableArticulos(dt As DataTable)

        'Nuestra DataTable (dtProductos) que creamos como dependencia va a recibir un objeto de tipo DataTable'
        Me.dtProductos = dt

        'A su vez nuestro componente DataGrid_Articulos va a recibir como DataSource nuestra DataTable de dependencia'
        dataGrid_Articulos.DataSource = dt
    End Sub

    'Esta funcion inicializa la DataTable con las COLUMNAS' 
    Private Sub InicializarDataTable()

        'Creamos el objeto de tipo DataTable' 
        Dim dt As New DataTable

        'Le definimos a nuestra DataTable las COLUMNAS'
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Precio")

        'A nuestra DataTable creada la seteamos con el DataGrid'
        Me.SetDataTableArticulos(dt)
    End Sub

    'Esta funcion me suma los productos'
    Private Sub OperacionesCarrito()

        'Variables para sumar el total de productos'
        Dim totalProductos As Double = 0

        'Variables para sumar el total de productos con la letra R'
        Dim totalProductosR As Double = 0

        'Variable contadora de productos con la letra R'
        Dim contadorProductosR = 0

        'Recorro mi DataTable de Productos (Por cada RENGLON, que es de tipo DataRow, de mis Filas de la DataTable de dtProductos HACE lo siguiente)' 
        For Each renglon As DataRow In Me.dtProductos.Rows

            'Hago la suma de total de los productos'
            totalProductos += renglon("Precio")

            'Obtengo el nombre de cada Renglon'
            Dim nombre As String = renglon("Nombre")

            'Si el nombre obtenido de renglon empieza con R (le pongo ToUpper para que siempre sea con Mayuscula y evitar el case sensitive) hago lo siguiente'
            If nombre.ToUpper().StartsWith("R") Then

                'Sumo los importes de los productos que empiecen con R en mi variable totalProductos'
                totalProductosR += renglon("Precio")

                'Incremento la cantidad de Productos con la letra R a 1'
                contadorProductosR += 1
            End If
        Next

        'Saco los promedios'
        Dim promedio = totalProductos / Me.dtProductos.Rows.Count 'Como es del total de productos de mi DataTable con usar Rows.Count se cuentan todas las columnas'
        Dim promedioR = totalProductosR / contadorProductosR

        'Visualizo los resultados de los acumuladores'
        lbl_Total.Text = totalProductos.ToString("#0.00")
        lbl_totalR.Text = totalProductosR.ToString("#0.00")

        'Visualizo los resultados de los promedios'
        lbl_Promedio.Text = promedio.ToString("#0.00")

        'En el caso de ProductosR para evitar la division con 0 creo un condicional'
        If contadorProductosR > 0 Then

            'Si el contador de productos con R es mayor a 0 entonces ahi muestro el promedio'
            lbl_PromedioR.Text = promedioR.ToString("#0.00")
        Else
            'Si es cero que solo muestre un 0.00'
            lbl_PromedioR.Text = "0.00"
        End If



    End Sub


#End Region

    'Esta region son para los eventos de nuestros componentes que van a funcionar con las funciones de la region anterior'
#Region "Eventos"

    'Cuando el Form se cargue, ahi inicializo la DataTable' 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Llamo a mi funcion IncializarDataTable que hace lo siguiente:
        ' - Crea la DataTable
        ' - Le define las COLUMNAS a la DataTable
        ' - Llama a la funcion SetDataTableArticulos que hace lo siguiente: 
        '     - Le pasamos nuestra DataTableCreada
        '     - Le DataTable que creamos como DEPENDENCIA tendra el valor de nuestra DataTableCreada y que le pasamos por parametro
        '     - A la DataGrid le asignamos nuestra DataTable creada en nuestro DataSource
        '     - De esta manera nuestra DataTable que creamos como DEPENDENCIA, dtProductos, tiene una DataTable con una estrectura de COLUMNAS y apunta a un DataGridView
        Me.InicializarDataTable()
    End Sub

    Private Sub btn_Agregar_Producto_Click(sender As Object, e As EventArgs) Handles btn_Agregar_Producto.Click

        'Tomamos el nombre y el precio de nuestros TextBoxes'
        Dim nombre = txt_Nombre.Text
        Dim precio = Double.Parse(txt_Precio.Text)

        'Agregamos una nueva FILA (Rows) a nuestra DataTable dtProductos con los valores obtenidos'
        Me.dtProductos.Rows.Add(nombre, precio)

        'Llamos a la funcion OperacionesCarrito, de la region ACCIONES, que hace las operaciones internas del Programa.'
        Me.OperacionesCarrito()
    End Sub


#End Region


End Class
