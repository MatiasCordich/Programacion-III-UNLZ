Imports VeterinariaService.DAO

Public Class FormularioReporteSecundario
    Private Sub FormularioReporteSecundario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Creacion del DAO y de la DataTable' 
        Dim dao As New AnimalesDAO
        Dim dt As New DataTable

        'Funcion - GetReportePrincipal() pasamos los valores TextBox y guardamos el resultado en la dt'
        dt = dao.GetReporteSecundario()

        'DataGrid - Llenamos la DataSource con la DataTable'
        DGV_ReporteSecundario.DataSource = dt
    End Sub
End Class