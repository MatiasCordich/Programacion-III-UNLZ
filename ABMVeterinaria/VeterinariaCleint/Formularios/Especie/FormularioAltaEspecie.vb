Imports VeterinariaService.DAO
Imports VeterinariaService.Modelos

Public Class FormularioAltaEspecie
#Region "Acciones"
    Private Sub LimpiarCampos()
        Txt_nombreEspecieAlta.Text = ""
        Txt_EdadEspecieAlta.Text = ""
        Txt_PesoEspecieAlta.Text = ""
    End Sub
#End Region

#Region "Eventos"

    '----------------------------------- CLICK ALTA ESPECIE -----------------------------------'
    Private Sub Btn_altaEspecie_Click(sender As Object, e As EventArgs) Handles Btn_altaEspecie.Click
        'Tomamos los valores de los TextBox'
        Dim nombre = Txt_nombreEspecieAlta.Text.ToLower
        Dim edadS = Txt_EdadEspecieAlta.Text
        Dim pesoS = Txt_PesoEspecieAlta.Text

        If nombre = "" Or edadS = "" Or pesoS = "" Then
            MessageBox.Show("ERROR: Los campos NOMBRE, EDAD y PESO no puede estar vacio")
            Return
        End If

        'Validamos que ID, EDAD y PESO sea un numero'
        Dim edad As Integer
        Dim peso As Integer

        If Not Integer.TryParse(edadS, edad) Or Not Integer.TryParse(pesoS, peso) Then
            MessageBox.Show("ERROR: Ingrese un valor numerico para EDAD y PESO")
            Return
        End If

        'Validamos que el ID, PESO o EDAD no sea negativo'
        If edad < 0 Or peso < 0 Then
            MessageBox.Show("ERROR: Los campos EDAD y PESO no pueden ser negativos")
            Return
        End If

        'Creamos el DAO'
        Dim dao As New EspeciesDAO

        'Si paso la validacion prosigo con la inserccion'
        Dim nuevaEspecie As New Especie(nombre, edad, peso)

        'Valido la accion'
        If dao.Insert(nuevaEspecie) Then
            PB_cargaAltaEspecie.Visible = True
            T_AltaEspecie.Enabled = True
            LBL_descripcionAltaEspecie.Visible = True
            LBL_descripcionAltaEspecie.Text = "Cargando..."
            MessageBox.Show("Especie cargada correctamente")
        End If
    End Sub



#End Region

#Region "Timers"
    Private Sub T_AltaEspecie_Tick(sender As Object, e As EventArgs) Handles T_AltaEspecie.Tick

        'Evaluamos el valor de la barra de carga'
        If PB_cargaAltaEspecie.Value = PB_cargaAltaEspecie.Maximum Then

            'Si es igual a su MAXIMO'

            'Limpiamos los Textbox y sacamos la barra de carga'
            Me.LimpiarCampos()
            PB_cargaAltaEspecie.Visible = False
            LBL_descripcionAltaEspecie.Visible = False
        Else

            'Caso contrario incrementamos el valor del a barra de carga'
            Dim nuevoValor = PB_cargaAltaEspecie.Value + 10
            PB_cargaAltaEspecie.Value = Math.Min(nuevoValor, PB_cargaAltaEspecie.Maximum)
        End If
    End Sub
#End Region
End Class