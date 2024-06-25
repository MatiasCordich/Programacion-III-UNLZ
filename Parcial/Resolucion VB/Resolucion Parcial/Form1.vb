Public Class Form1

#Region "Dependencias"
    '----------------------- LA DATATABLE CON LA QUE VAMOS A TRABAJR -----------------------'
    Private dtPinturas As New DataTable
#End Region

#Region "Inicializar"

    '----------------------- FUNCION PARA CREAR LA DATATABLE -----------------------'
    Private Sub InicializarDataTable()
        Dim dt As New DataTable

        dt.Columns.Add("CODIGO")
        dt.Columns.Add("COLOR")
        dt.Columns.Add("LITROS")

        Me.SetDataTable(dt)
    End Sub
#End Region

#Region "Acciones"

    '----------------------- FUNCION PARA SETEAR LA DATATABLE CON LA QUE VAMOS A TRABAJAR CON EL DATAGRID -----------------------'
    Private Sub SetDataTable(dt As DataTable)
        Me.dtPinturas = dt
        dtgrid_Pinturas.DataSource = dt
    End Sub

    '----------------------- FUNCION CALCULAR TOTAL LITROS ROJO -----------------------'
    Private Sub CalcularTotalLitrosPinturaRoja()
        Dim acumuladorLitrosRojo As Double = 0

        For Each renglon As DataRow In Me.dtPinturas.Rows
            Dim color As String = renglon("COLOR")

            If color.ToUpper() = "ROJO" Or color.ToUpper() = "ROJA" Then
                acumuladorLitrosRojo += renglon("LITROS")
            End If
        Next

        lbl_litrosRojo.Text = acumuladorLitrosRojo.ToString("#0.00")
    End Sub

    '----------------------- FUNCION CALCULAR PROMEDIO LITROS AZUL -----------------------'
    Private Sub CalcularPromedioLitrosPinturaAzul()
        Dim acumuladorLitrosAzul As Double = 0
        Dim contadorPinturaAzul As Integer = 0

        For Each renglon As DataRow In Me.dtPinturas.Rows
            Dim color As String = renglon("COLOR")

            If color.ToUpper() = "AZUL" Then
                acumuladorLitrosAzul += renglon("LITROS")
                contadorPinturaAzul += 1
            End If
        Next

        Dim promedioLitrosAzul As Double = acumuladorLitrosAzul / contadorPinturaAzul

        If contadorPinturaAzul > 0 Then
            lbl_litrosAzul.Text = promedioLitrosAzul.ToString("#0.00")
        Else
            lbl_litrosAzul.Text = "0.00"
        End If


    End Sub

    '----------------------- FUNCION LIMIPIAR TEXTBOX -----------------------'
    Private Sub LimparTextBox()
        txt_codigo.Text = ""
        txt_color.Text = ""
        txt_litros.Text = ""
    End Sub
#End Region

#Region "Eventos"

    '----------------------- EVENTO LOAD CARGAR FORMULARIO -----------------------'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InicializarDataTable()
    End Sub

    '----------------------- EVENTO CLICK AGREGAR PINTURA -----------------------'
    Private Sub btn_agregarPintura_Click(sender As Object, e As EventArgs) Handles btn_agregarPintura.Click

        'Primero tomo los valores de los TextBoxes'
        Dim codigoS = txt_codigo.Text
        Dim color = txt_color.Text
        Dim litrosS = txt_litros.Text

        'PRIMERA VALIDACION: QUE NO HAYA CAMPOS VACIOS'
        If codigoS = "" Or color = "" Or litrosS = "" Then
            MessageBox.Show("ERROR: Algunos campos estan vacios")
            Return
        End If

        'SEGUNDA VALIDACION: QUE CODIGO Y LITROS SEAN VALORES NUMERICOS'
        Dim codigo As Integer
        Dim litros As Double

        If Not Integer.TryParse(codigoS, codigo) Or Not Double.TryParse(litrosS, litros) Then
            MessageBox.Show("ERROR: Los valores de CODIGO o LITROS deben ser NUMÉRICOS")
            Return
        End If

        'TERCERA VALIDACION: QUE CODIGO Y LITROS SEAN POSITIVOS'
        If codigo < 0 Or litros < 0 Then
            MessageBox.Show("ERROR: Número negativo, por favor ingrese valores POSITIVOS")
            Return
        End If

        'CUARTA VALIDACION: QUE NO HAYA CODIGO REPETIDO'
        For Each renglon As DataRow In Me.dtPinturas.Rows
            If renglon("CODIGO") = codigo Then
                MessageBox.Show("ERROR: Código repetido, por favor ingrese uno diferente")
                Return
            End If
        Next

        'Si pasaron todas las validaciones agrego una nueva fila a la DataTable con los valores de los TextBox'
        Me.dtPinturas.Rows.Add(codigo, color, litros)

        'Ejecuto las funciones dem i region Acciones'
        Me.CalcularTotalLitrosPinturaRoja()
        Me.CalcularPromedioLitrosPinturaAzul()
        Me.LimparTextBox()

    End Sub
#End Region


End Class
