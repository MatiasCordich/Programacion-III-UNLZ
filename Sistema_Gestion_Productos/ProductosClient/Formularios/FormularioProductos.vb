Imports ProductosService.DAO

Public Class FormularioProductos
#Region "Eventos"
    Private Sub Btn_listarProductos_Click(sender As Object, e As EventArgs) Handles Btn_listarCategorias.Click
        Dim dao As New ProductosDAO

        Dim listaProductos = dao.GetAll

        DGV_listaProductos.DataSource = listaProductos
    End Sub
#End Region

End Class