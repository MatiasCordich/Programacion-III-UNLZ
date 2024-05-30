Public Class Form1

#Region "Dependencias"
    Private dtPinturas As New DataTable
#End Region

#Region "Inicializar"
    Private Sub InicializarDataTable()
        Dim dt As New DataTable

        dt.Columns.Add("CODIGO")
        dt.Columns.Add("COLOR")
        dt.Columns.Add("LITROS")

        Me.SetDataTable(dt)
    End Sub
#End Region

#Region "Acciones"
    Private Sub SetDataTable(dt As DataTable)
        Me.dtPinturas = dt
        dtgrid_Pinturas.DataSource = dt
    End Sub

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

    Private Sub LimparTextBox()
        txt_codigo.Text = ""
        txt_color.Text = ""
        txt_litros.Text = ""
    End Sub
#End Region

#Region "Eventos"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InicializarDataTable()
    End Sub

    Private Sub btn_agregarPintura_Click(sender As Object, e As EventArgs) Handles btn_agregarPintura.Click

        'Primero tomo los valores de los TextBoxes'
        Dim codigoS = txt_codigo.Text
        Dim color = txt_color.Text
        Dim litrosS = txt_litros.Text

        'PRIMERA VALIDACION: QUE NO HAYA CAMPOS VACIOS'
        'La primera validacion es asegurarnos que no se haya ingresado ningun dato vacio en los TextBoxes'
        If codigoS = "" Or color = "" Or litrosS = "" Then
            MessageBox.Show("ERROR: Algunos campos estan vacios")
            Return
        End If

        'Si todos los TextBoxes tienen algun valor ahora hago la SEGUNDA validacion'

        'SEGUNDA VALIDACION: TIPOS DE DATOS NUMERICOS'
        'Valido que tanto CODIGO como LITROS tengan un valor numerico'
        Try

            Dim codigo As Integer = Integer.Parse(codigoS)
            Dim litros As Double = Double.Parse(litrosS)

            'Si pasa la segunda validacion ahora hago la TERCERA validacion'

            'TERCERA VALIDACION: CODIGO UNICO'
            'Valido que el CODIGO no este repetido'
            For Each renglon As DataRow In Me.dtPinturas.Rows
                If renglon("CODIGO") = codigo Then
                    MessageBox.Show("ERROR: Codigo repetido, por favor ingrese uno diferente")
                    Return
                End If
            Next

            'Si paso la tercera validacion ahora hago la CUARTA validacion'

            'CUARTA VALIDACION: NUMEROS NEGATIVOS'
            'Valido que tanto CODIGO como LITROS no sean numeros negativos'
            If codigo < 0 Or litros < 0 Then
                MessageBox.Show("ERROR: Numero negativo, por favor ingrese valores POSITIVOS")
                Return
            End If

            'Si pasaron todas las validaciones agrego una nueva fila a la DataTable con los valores de los TextBox'
            Me.dtPinturas.Rows.Add(codigo, color, litros)

            'Ejecuto las funciones dem i region Acciones'
            Me.CalcularTotalLitrosPinturaRoja()
            Me.CalcularPromedioLitrosPinturaAzul()
            Me.LimparTextBox()

        Catch ex As Exception
            MessageBox.Show("ERROR: Los valores de CODIGO o LITROS deben ser NUMERICOS")
        End Try
    End Sub
#End Region


End Class
