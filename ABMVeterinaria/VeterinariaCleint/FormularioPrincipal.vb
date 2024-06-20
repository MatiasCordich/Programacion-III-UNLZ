Imports System.Configuration
Imports VeterinariaService.DAO

Public Class FormularioPrincipal
#Region "Dependencias"
    Private ventanaAlta As FormularioAltaUsuario
    Private ventanaBaja As FormularioBajaUsuario
    Private ventanaAcciones As FormularioAccionesUsuario
#End Region

#Region "Eventos"

    '------------------------------ CLICK SALIR DE LA APP ------------------------------ 
    Private Sub Btn_salirApp_Click(sender As Object, e As EventArgs) Handles Btn_salirApp.Click
        Me.Close()
    End Sub

    '------------------------------ CLICK LOGIN ------------------------------
    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click

        'Tomamos los valores '
        Dim nombre = Txt_nombreLogin.Text
        Dim clave = Txt_claveLogin.Text

        'Validamos que no haya campos vacios en los TextBox'
        If nombre = "" Or clave = "" Then
            MessageBox.Show("ERROR: No puede haber campos vacios")
            Return
        End If

        'Creamos el DAO'
        Dim dao As New UsuariosDAO

        'Validamos si existe el usuario'
        Dim usuario = dao.GetUsuarioLogin(nombre, clave)



        If usuario Is Nothing Then
            MessageBox.Show("ERROR: Usuario no encontrado, intentelo otra vez")
            Return
        End If

        'Caso contrario prosigo con el ingreso'
        PB_barraLogin.Visible = True

        T_login.Enabled = True

        LBL_cargaBarra.Text = "Cargando..."

        LBL_cargaBarra.Visible = True

        LBL_nombreUsuario.Text = $"{usuario.NombreUsuario}"

    End Sub

    '------------------------------ CLICK MOSTRAR FORMULARIO ALTA ------------------------------
    Private Sub AltaDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeUsuarioToolStripMenuItem.Click

        'Validamos que exista la ventana de Alta de usuarios'
        If ventanaAlta Is Nothing Then

            'Creamos la nueva ventana'
            'Configuramos que la venta de alta sea hijo de del Form principal'
            ventanaAlta = New FormularioAltaUsuario With {
                .MdiParent = Me
            }

            'Manejamos el evento cuando se cierra el formulario de alta'
            AddHandler ventanaAlta.FormClosed, AddressOf FormularioAltaUsuario_FormClosed

            'Mostramos el formulario de alta de usuario'
            ventanaAlta.Show()

        End If
    End Sub

    '------------------------------ CLICK MOSTRAR FORMULARIO BAJA ------------------------------
    Private Sub BajaDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaDeUsuarioToolStripMenuItem.Click

        'Validamos que exista la ventana de Baja de usuarios'
        If ventanaBaja Is Nothing Then

            'Creamos la nueva ventana'
            'Configuramos que la venta de alta sea hijo de del Form principal'
            ventanaBaja = New FormularioBajaUsuario With {
                .MdiParent = Me
            }

            'Manejamos el evento cuando se cierra el formulario de alta'
            AddHandler ventanaBaja.FormClosed, AddressOf FormularioBajaUsuario_FormClosed

            'Mostramos el formulario de alta de usuario'
            ventanaBaja.Show()

        End If
    End Sub

    '------------------------------ CLICK MOSTRAR FORMULARIO ACCIONES ------------------------------
    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click

        'Validamos que exista la ventana de Baja de usuarios'
        If ventanaAcciones Is Nothing Then

            'Creamos la nueva ventana'
            'Configuramos que la venta de alta sea hijo de del Form principal'
            ventanaAcciones = New FormularioAccionesUsuario With {
                .MdiParent = Me
            }

            'Manejamos el evento cuando se cierra el formulario de alta'
            AddHandler ventanaAcciones.FormClosed, AddressOf FormularioAccionesUsuario_FormClosed

            'Mostramos el formulario de alta de usuario'
            ventanaAcciones.Show()

        End If
    End Sub

#End Region

#Region "Timers"
    '------------------------------ TICK TIMER LOGIN ------------------------------
    Private Sub T_login_Tick(sender As Object, e As EventArgs) Handles T_login.Tick

        'Evaluamos el valor de la barra de carga'
        If PB_barraLogin.Value = PB_barraLogin.Maximum Then

            'Si es igual a su MAXIMO entonces que me muestre y oculte ciertos componentes'
            MS_menuABM.Visible = True
            Btn_salirApp.Visible = True
            P_login.Visible = False
            LBL_nombreUsuario.Visible = True
        Else
            'Caso contrario incremento el valor de la barra con los ticks del timer'
            Dim nuevoValor = PB_barraLogin.Value + 10
            PB_barraLogin.Value = Math.Min(nuevoValor, PB_barraLogin.Maximum)
        End If
    End Sub

#End Region

#Region "Handler"

    '------------------------------ HANDLER ESTADO DE LA DEPENDENCIA VENTANALATA ------------------------------
    Private Sub FormularioAltaUsuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ventanaAlta = Nothing
    End Sub

    Private Sub FormularioBajaUsuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ventanaBaja = Nothing
    End Sub

    Private Sub FormularioAccionesUsuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ventanaAcciones = Nothing
    End Sub

#End Region

End Class
