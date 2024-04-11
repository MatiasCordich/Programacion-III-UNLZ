Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Agregar un registro al dataGridView cuando se carge el Form'
        Me.gridProductos.Rows.Add("Hola", 0)
    End Sub

    'Funcion para agregar el producto a la lista, sumar y mostrar el total'
    Private Sub btnAgregar_MouseHover(sender As Object, e As EventArgs) Handles btnAgregar.MouseHover

        'Guardamos los valores de los textBox'
        Dim detalle As String = txtDetalle.Text

        'Vamos a validar que el valor que se guarda en txtPrecio sea un numero'
        Try
            'Tomo el valor de txtPrecio'
            Dim precio As Integer = txtPrecio.Text

            'Agrego los valores como un nuevo registro en la grilla'
            Me.gridProductos.Rows.Add(detalle, precio)
        Catch ex As Exception
            'Si la validacion fallo lanzo un mensaje de error'
            MessageBox.Show("El precio debe ser un numero")
        End Try

        'Sumar cada precio de los productos y hacerun total'
        Dim sumador As Integer = 0

        'Recorro la grilla'
        For Each fila As DataGridViewRow In Me.gridProductos.Rows
            sumador += fila.Cells("ColumnaPrecio").Value
        Next

        'Mostrar el total'
        Me.labelTotalPrecio.Text = sumador


    End Sub

    'Funcion para limpiar los textBox'
    Private Sub btnAgregar_MouseLeave(sender As Object, e As EventArgs) Handles btnAgregar.MouseLeave
        'Le asignamos a cada textBox un string vacio'
        Me.txtDetalle.Text = ""
        Me.txtPrecio.Text = ""
    End Sub
End Class
