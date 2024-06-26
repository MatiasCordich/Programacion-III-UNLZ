Imports System.Data.SqlClient
Imports VeterinariaService.DAO

Public Class FormularioReportePrincipal

#Region "Eventos"

    '-------------------------- FUNCION - MUESTREO REPORTE----------------------'
    Private Sub Btn_FiltrarReporte_Click(sender As Object, e As EventArgs) Handles Btn_FiltrarReporte.Click

        'Obtencion - Tomamos los valores de los TextBox'
        Dim edadMinS = Txt_edadMinima.Text
        Dim edadMaxS = Txt_edadMaxima.Text

        'Validacion - No campos vacios'
        If edadMaxS = "" Or edadMinS = "" Then
            MessageBox.Show("ERROR: Los campos no pueden estar vacios")
            Return
        End If

        'Validacion - Datos numericos'
        Dim edadMin As Integer
        Dim edadMax As Integer

        If Not Integer.TryParse(edadMinS, edadMin) Or Not Integer.TryParse(edadMaxS, edadMax) Then
            MessageBox.Show("ERROR: Los campos solo aceptan valores NUMERICOS")
            Return
        End If


        'Validacion - No valores negativos'
        If edadMin < 0 Or edadMax < 0 Then
            MessageBox.Show("ERROR: Los campos no aceptan valores negativos")
            Return
        End If

        'Validacion - Campo edadMinima menor a edadMaxima'
        If edadMin > edadMax Then
            MessageBox.Show("ERROR: La edad MINIMA debe ser menos a la MAXIMA")
            Return
        End If

        'Creacion del DAO y de la DataTable' 
        Dim dao As New AnimalesDAO
        Dim dt As New DataTable

        'Funcion - GetReportePrincipal() pasamos los valores TextBox y guardamos el resultado en la dt'
        dt = dao.GetReportePrincipal(edadMin, edadMax)

        'DataGrid - Llenamos la DataSource con la DataTable'
        DGV_reportePrincipal.DataSource = dt

        'Limpieza - Limpiamos los campos'
        Txt_edadMaxima.Text = ""
        Txt_edadMinima.Text = ""
    End Sub

#End Region


End Class