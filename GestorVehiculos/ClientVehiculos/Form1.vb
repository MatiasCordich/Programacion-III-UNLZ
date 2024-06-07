Imports ServicesVehiculos.DAO
Imports ServicesVehiculos.Models

Public Class Form1
    Private Sub btn_cargarDatos_Click(sender As Object, e As EventArgs) Handles btn_cargarDatos.Click

        'Tomamos los datos de los TextBox'
        Dim patente = txt_patente.Text
        Dim tipo = txt_tipoID.Text
        Dim velocidad = txt_velocidad.Text

        'Creamos un objeto de objeto Vehiculo con los datos'
        Dim vehiculin As New Vehiculo(patente, tipo, velocidad)

        'Creamos el DAO'
        Dim dao As New VehiculosDAO

        'Con el dao creado llamamos a la funcion INSERT'
        dao.insert(vehiculin)
    End Sub

    Private Sub btn_mostrarDatos_Click(sender As Object, e As EventArgs) Handles btn_mostrarDatos.Click
        'Creamos el objeto DAO'
        Dim dao As New VehiculosDAO

        'Llamamos a la funcion GETALL para obtener todos los Vehiculos'
        Dim vehiculos = dao.getAll

        'Con lo obtenido lo pasamos a la DataGrid'
        dataG_vehiculos.DataSource = vehiculos
    End Sub
End Class
