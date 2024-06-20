Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports VeterinariaService.DAO

Public Class FormularioBajaUsuario
    Private Sub Btn_bajaUsuario_Click(sender As Object, e As EventArgs) Handles Btn_bajaUsuario.Click
        'Tomamos el valor del TextBox'
        Dim idS = Txt_idBaja.Text

        'Valido que no haya campo vacios'
        If idS = "" Then
            MessageBox.Show("ERROR: Por favor, ingrese un numero")
            Return
        End If

        'Validamos que el valor del TextBox sea numerico'
        Dim id As Integer

        If Not Integer.TryParse(idS, id) Then
            MessageBox.Show("ERROR: Por favor, ingrese un valor numerico para ID")
            Return
        End If

        'Validamos que el ID no sea negativo'
        If id < 0 Then
            MessageBox.Show("ERROR: Por favor, ingrese un ID POSITIVO")
            Return
        End If

        Try

            'Creamos el DAO'
            Dim dao As New UsuariosDAO

            'Validamos que exista el Usuario'
            Dim usuario = dao.GetByID(id)

            If usuario IsNot Nothing Then

                'Realizo el Delete'
                dao.Delete(id)

                'Mostramos un mensaje de exito y vaciamos el Textbox'
                MessageBox.Show($"El usuario {usuario.NombreUsuario} fue dado de baja correctamente")
                Txt_idBaja.Text = ""
                Return
            Else
                'Caso contrario, mostramos un mensaje de error'
                MessageBox.Show("No se encontro al usuario para dar de baja")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR: No se pudo dar de baja al Usuario")
        End Try
    End Sub
End Class