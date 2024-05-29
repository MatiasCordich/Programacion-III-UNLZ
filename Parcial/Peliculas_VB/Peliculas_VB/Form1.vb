Public Class Form1

    'Mis dependencias'
#Region "Dependencias"
    Private dtPeliculas As New DataTable
#End Region

    'Inicializar la DataTable'
#Region "Inicializar"

    'Funcion para Inicializar la DataTable'
    Private Sub InicializarDataTable()

        Dim dt As New DataTable

        dt.Columns.Add("Nombre")
        dt.Columns.Add("Genero")
        dt.Columns.Add("Duracion")

        Me.SetDataTable(dt)

    End Sub
#End Region

    'Funciones para que funciones el Windows Forms'
#Region "Funciones"

    'Apuntar la DataTable a la DataGrid'
    Private Sub SetDataTable(dt As DataTable)
        Me.dtPeliculas = dt
        dgrid_Peliculas.DataSource = dt
    End Sub

    'Funcion para sacar el total y el promedio de todas las peliculas'
    Private Sub AcumuladorYPromedioDuracion()

        'Variable acumuladora'
        Dim acumuladorDuracion As Integer = 0

        'Recorro la DataTable'
        For Each renglon As DataRow In Me.dtPeliculas.Rows

            'Por cada renglon de turno sumame la Duracion'
            acumuladorDuracion += renglon("Duracion")
        Next

        'Sacamos el promedio'
        Dim promedio As Double = acumuladorDuracion / Me.dtPeliculas.Rows.Count

        'Visualizamos el promedio y el total de duracion de todas las peliculas'
        lbl_PromedioDuracion.Text = promedio.ToString("#0")
        lbl_Duracion.Text = acumuladorDuracion.ToString()
    End Sub

    'Contador de peliculas de DRAMA'
    Private Sub ContadorPeliculasDrama()

        'Variable contadora'
        Dim contadorPeliculasDrama As Integer = 0

        'Recorremos la DataTable'
        For Each renglon As DataRow In Me.dtPeliculas.Rows

            'Por cada renglon tomamos el Genero y lo guardamos en una variable'
            Dim genero As String = renglon("Genero")

            'Si el genero de turno es DRAMA incrementa en 1 el contador'
            If genero.ToUpper().Contains("DRAMA") Then
                contadorPeliculasDrama += 1
            End If
        Next

        'Visualizo el resultado final del contador'
        lbl_CantDrama.Text = contadorPeliculasDrama.ToString()
    End Sub

    'Sacar el promedio de minutos de las pelicuasl de Terror'
    Private Sub PromedioMinutosTerror()

        'Mis variables contadora y acumuladora'
        Dim contadorPeliculasTerror As Integer = 0
        Dim acumuladorMinutosTerror As Double = 0

        'Recorro el DataTable'
        For Each renglon As DataRow In Me.dtPeliculas.Rows

            'Por cada renglon tomamos el Genero y lo guardamos en una variable'
            Dim genero As String = renglon("Genero")

            'Si el genero de turno es TERROR incrementa en 1 el contador y sumame los minutos de la duracion de turno del renglon'
            If genero.ToUpper().Contains("TERROR") Then
                contadorPeliculasTerror += 1
                acumuladorMinutosTerror += renglon("Duracion")
            End If
        Next

        'Sacamos el promedio'
        Dim promedioTerror As Double = acumuladorMinutosTerror / contadorPeliculasTerror

        'Validamos para evitar la division por cero 0'
        If contadorPeliculasTerror > 0 Then

            'Si el contador es mayor a cero que me muestre el Promedio de duracion'
            lbl_PromedioTerror.Text = promedioTerror.ToString("#0")
        Else

            'Caso contrario que muestre solo cero 0'
            lbl_PromedioTerror.Text = "0"
        End If

    End Sub

    Private Sub LimpiarTextBoxes()
        txt_Duracion.Text = ""
        txt_Nombre.Text = ""
    End Sub


#End Region

#Region "Eventos"

    'Evento Load para inicializar la DataTable'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InicializarDataTable()
    End Sub

    'Evento click para agregar la pelicula'
    Private Sub btn_agregarPelicula_Click(sender As Object, e As EventArgs) Handles btn_agregarPelicula.Click

        'Tomamos los valores de NOMBRE y GENERO'
        Dim nombre = txt_Nombre.Text
        Dim genero = cmbox_Plan.SelectedItem.ToString()

        'Validamos que ingresemos un valor numerico para DURACION'
        Try
            Dim duracion As Integer = Integer.Parse(txt_Duracion.Text)

            'Si salio bien, agregamos una FILA nueva con los valores ingresados'
            Me.dtPeliculas.Rows.Add(nombre, genero, duracion)

            'Llamamos a las funciones de la region FUNCIONES para que sea dinamico el Win Forms'
            Me.AcumuladorYPromedioDuracion()
            Me.ContadorPeliculasDrama()
            Me.PromedioMinutosTerror()
            Me.LimpiarTextBoxes()
        Catch ex As Exception

            'Caso contrario que muestre un valor Numero'
            MessageBox.Show("El valor debe ser NUMERICO")
        End Try
    End Sub

#End Region

End Class
