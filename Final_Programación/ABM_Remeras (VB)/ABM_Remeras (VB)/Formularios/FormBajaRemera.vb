Imports ABM_Remera_Services.Models

Public Class FormBajaRemera

    Private listaRemerasHijo As List(Of Remera)


    ' ------------- CONSTRUCTOR ------------- 
    Public Sub New(listaRemeras As List(Of Remera))

        ' Inicializamos el componente
        InitializeComponent()

        'A la lista del hijo se le asigna como valor la lista del padre
        'No hace falta inicializarla porque le pasamos la lista del padre que ya fue inicializada
        Me.listaRemerasHijo = listaRemeras

        'Inicializamos la DataGrid con lo que haya de informacion en la lista del Padre
        Dgv_listaRemeras.DataSource = listaRemerasHijo

    End Sub
    Private Sub Btn_bajaRemera_Click(sender As Object, e As EventArgs) Handles Btn_bajaRemera.Click

    End Sub
End Class