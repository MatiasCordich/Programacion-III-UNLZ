Public Class Form1
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        'Creamos la DataTable'
        Dim dt As New DataTable

        'Insertamos las COLUMNAS de la DataTable'
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Apellido")

        'Insertamos una FILA'
        dt.Rows.Add("Chicho", "Serna")

        'Visualizamos la DataTable creada'
        Data_grid_Personas.DataSource = dt

    End Sub

    Private Sub btn_Agregar_2_Click(sender As Object, e As EventArgs) Handles btn_Agregar_2.Click
        'Accedemos a la DataTable creando un valor que sera el DataSource del DataGrid'
        Dim dt As DataTable = Data_grid_Personas.DataSource

        'En C# hubiesemos hecho lo siguiente'
        'DataTable dt = (DataTable) Data_grid_Personas.DataSource'

        'Tomamos el Nombre y Apellido de los TextBox'
        Dim nombre = txt_Nombre.Text
        Dim apellidos = txt_Apellidos.Text

        'Agregamos una fila en nuestro DataTable con los valors obtenidos de los TextBox'
        dt.Rows.Add(nombre, apellidos)
    End Sub
End Class
