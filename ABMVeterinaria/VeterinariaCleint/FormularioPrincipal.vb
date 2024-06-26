Imports System.Configuration
Imports VeterinariaService.DAO

Public Class FormularioPrincipal
#Region "Dependencias"

    '--------------- USUARIO ---------------'
    Private ventanaAlta As FormularioAltaUsuario
    Private ventanaBaja As FormularioBajaUsuario
    Private ventanaAcciones As FormularioAccionesUsuario
    Private ventanaReactivar As FormularioReactivarUsuario

    '--------------- CLIENTE ---------------'
    Private ventanaAltaCliente As FormularioAltaCliente
    Private ventanaBajaCliente As FormularioBajaCliente
    Private ventanaAccionesCliente As FormularioAccionesCliente
    Private ventanaReactivarCliente As FormularioReactivarCliente

    '--------------- ANIMAL ---------------'
    Private ventanaAltaAnimal As FormularioAltaAnimal
    Private ventanaBajaAnimal As FormularioBajaAnimal
    Private ventanaAccionesAnimal As FormularioAccionesAnimal


    '--------------- ESPECIE ---------------'
    Private ventanaAltaEspecies As FormularioAltaEspecie
    Private ventanaAccionesEspecie As FormularioAccionesEspecie
#End Region

#Region "Eventos"

    '------------------------------ CLICK SALIR DE LA APP ------------------------------' 
    Private Sub Btn_salirApp_Click(sender As Object, e As EventArgs) Handles Btn_salirApp.Click
        Me.Close()
    End Sub

    '------------------------------ CLICK LOGIN ------------------------------'
    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click

        'Tomamos los valores '
        Dim nombre = Txt_nombreLogin.Text.ToLower
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

        'Validamos si el usuario existe'
        If usuario Is Nothing Then
            MessageBox.Show("ERROR: Usuario no encontrado, intentelo otra vez")
            Return
        End If

        'Validamos si el usuario ingresado esta Inactivo'
        If usuario.Estado = "Inactivo" Then
            'Si su estado es Inactivo entonces muestro un mensaje de que no puede ingresar'
            MessageBox.Show("Este usuario esta inactivo, no puede ingresar")
            Return
        End If

        'Caso contrario prosigo con el ingreso'
        PB_barraLogin.Visible = True

        T_login.Enabled = True

        LBL_cargaBarra.Text = "Cargando..."

        LBL_cargaBarra.Visible = True

        LBL_nombreUsuario.Text = $"{usuario.NombreUsuario}"

    End Sub

    '------------------------------ CLICK MOSTRAR FORMULARIO ALTA ------------------------------'
    Private Sub AltaDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeUsuarioToolStripMenuItem.Click

        'Validamos que exista la ventana'
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

    '------------------------------ CLICK MOSTRAR FORMULARIO BAJA ------------------------------'
    Private Sub BajaDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaDeUsuarioToolStripMenuItem.Click

        'Validamos que exista la ventana'
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

    '------------------------------ CLICK MOSTRAR FORMULARIO ACCIONES ------------------------------'
    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click

        'Validamos que exista la ventana'
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

    '------------------------------ CLICK MOSTRAR FORMULARIO REACTIVAR USUARIO ------------------------------'
    Private Sub ReactivarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReactivarUsuarioToolStripMenuItem.Click

        'Validamos que exista la ventana'
        If ventanaReactivar Is Nothing Then

            'Creamos la nueva ventana'
            'Configuramos que la venta de alta sea hijo de del Form principal'
            ventanaReactivar = New FormularioReactivarUsuario With {
                .MdiParent = Me
            }

            'Manejamos el evento cuando se cierra el formulario de alta'
            AddHandler ventanaReactivar.FormClosed, AddressOf FormularioReactivarUsuario_FormClosed

            'Mostramos el formulario de alta de usuario'
            ventanaReactivar.Show()

        End If
    End Sub

    '------------------------------ CLICK MOSTRAR FORMULARIO ALTA CLIENTE ------------------------------'
    Private Sub AltaDeClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeClienteToolStripMenuItem.Click

        'Validamos que exista la ventana'
        If ventanaAltaCliente Is Nothing Then

            'Creamos la nueva ventana'
            'Configuramos que la venta de alta sea hijo de del Form principal'
            ventanaAltaCliente = New FormularioAltaCliente With {
                .MdiParent = Me
            }

            'Manejamos el evento cuando se cierra el formulario de alta'
            AddHandler ventanaAltaCliente.FormClosed, AddressOf FormularioAltaCliente_FormClosed

            'Mostramos el formulario de alta de usuario'
            ventanaAltaCliente.Show()

        End If
    End Sub

    '------------------------------ CLICK MOSTRAR FORMULARIO BAJA CLIENTE ------------------------------'
    Private Sub BajaDeClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaDeClienteToolStripMenuItem.Click

        'Validamos que exista la ventana'
        If ventanaBajaCliente Is Nothing Then

            'Creamos la nueva ventana'
            'Configuramos que la venta de alta sea hijo de del Form principal'
            ventanaBajaCliente = New FormularioBajaCliente With {
                .MdiParent = Me
            }

            'Manejamos el evento cuando se cierra el formulario de alta'
            AddHandler ventanaBajaCliente.FormClosed, AddressOf FormularioBajaCliente_FormClosed

            'Mostramos el formulario de alta de usuario'
            ventanaBajaCliente.Show()

        End If
    End Sub

    '------------------------------ CLICK MOSTRAR FORMULARIO ACCIONES CLIENTE ------------------------------'
    Private Sub AccionesClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccionesClientesToolStripMenuItem.Click

        'Validamos que exista la ventana'
        If ventanaAccionesCliente Is Nothing Then

            'Creamos la nueva ventana'
            'Configuramos que la venta de alta sea hijo de del Form principal'
            ventanaAccionesCliente = New FormularioAccionesCliente With {
                .MdiParent = Me
            }

            'Manejamos el evento cuando se cierra el formulario de alta'
            AddHandler ventanaAccionesCliente.FormClosed, AddressOf FormularioAccionesCliente_FormClosed

            'Mostramos el formulario de alta de usuario'
            ventanaAccionesCliente.Show()

        End If
    End Sub

    '------------------------------ CLICK MOSTRAR FORMULARIO REACTIVAR CLIENTE ------------------------------'
    Private Sub ReactivarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReactivarClienteToolStripMenuItem.Click

        'Validamos que exista la ventana'
        If ventanaReactivarCliente Is Nothing Then

            'Creamos la nueva ventana'
            'Configuramos que la venta de alta sea hijo de del Form principal'
            ventanaReactivarCliente = New FormularioReactivarCliente With {
                .MdiParent = Me
            }

            'Manejamos el evento cuando se cierra el formulario de alta'
            AddHandler ventanaReactivarCliente.FormClosed, AddressOf FormularioReactivarCliente_FormClosed

            'Mostramos el formulario de alta de usuario'
            ventanaReactivarCliente.Show()

        End If
    End Sub

    '------------------------------ CLICK MOSTRAR FORMULARIO ALTA ESPECIES ------------------------------'
    Private Sub AltaDeEspecieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeEspecieToolStripMenuItem.Click

        'Validamos que exista la ventana'
        If ventanaAltaEspecies Is Nothing Then

            'Creamos la nueva ventana'
            'Configuramos que la venta de alta sea hijo de del Form principal'
            ventanaAltaEspecies = New FormularioAltaEspecie With {
                .MdiParent = Me
            }

            'Manejamos el evento cuando se cierra el formulario de alta'
            AddHandler ventanaAltaEspecies.FormClosed, AddressOf FormularioAltaEspecie_FormClosed

            'Mostramos el formulario de alta de usuario'
            ventanaAltaEspecies.Show()

        End If
    End Sub

    '------------------------------ CLICK MOSTRAR FORMULARIO ACCIONES ESPECIES ------------------------------'
    Private Sub AccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccionesToolStripMenuItem.Click

        'Validamos que exista la ventana'
        If ventanaAccionesEspecie Is Nothing Then

            'Creamos la nueva ventana'
            'Configuramos que la venta de alta sea hijo de del Form principal'
            ventanaAccionesEspecie = New FormularioAccionesEspecie With {
                .MdiParent = Me
            }

            'Manejamos el evento cuando se cierra el formulario de alta'
            AddHandler ventanaAccionesEspecie.FormClosed, AddressOf FormularioAccionesEspecie_FormClosed

            'Mostramos el formulario de alta de usuario'
            ventanaAccionesEspecie.Show()

        End If
    End Sub

    '------------------------------ CLICK MOSTRAR FORMULARIO ALTA ANIMAL ------------------------------'
    Private Sub AltaDeAnimalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeAnimalToolStripMenuItem.Click

        'Validamos que exista la ventana'
        If ventanaAltaAnimal Is Nothing Then

            'Creamos la nueva ventana'
            'Configuramos que la venta de alta sea hijo de del Form principal'
            ventanaAltaAnimal = New FormularioAltaAnimal With {
                .MdiParent = Me
            }

            'Manejamos el evento cuando se cierra el formulario de alta'
            AddHandler ventanaAltaAnimal.FormClosed, AddressOf FormularioAltaAnimal_FormClosed

            'Mostramos el formulario de alta de usuario'
            ventanaAltaAnimal.Show()

        End If
    End Sub

    '------------------------------ CLICK MOSTRAR FORMULARIO BAJA ANIMAL ------------------------------'
    Private Sub BajaDeAnimalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaDeAnimalToolStripMenuItem.Click

        'Validamos que exista la ventana'
        If ventanaBajaAnimal Is Nothing Then

            'Creamos la nueva ventana'
            'Configuramos que la venta de alta sea hijo de del Form principal'
            ventanaBajaAnimal = New FormularioBajaAnimal With {
                .MdiParent = Me
            }

            'Manejamos el evento cuando se cierra el formulario de alta'
            AddHandler ventanaBajaAnimal.FormClosed, AddressOf FormularioBajaAnimal_FormClosed

            'Mostramos el formulario de alta de usuario'
            ventanaBajaAnimal.Show()

        End If
    End Sub

    '------------------------------ CLICK MOSTRAR FORMULARIO ACCIONES ANIMAL ------------------------------'
    Private Sub AccionesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AccionesToolStripMenuItem1.Click

        'Validamos que exista la ventana'
        If ventanaAccionesAnimal Is Nothing Then

            'Creamos la nueva ventana'
            'Configuramos que la venta de alta sea hijo de del Form principal'
            ventanaAccionesAnimal = New FormularioAccionesAnimal With {
                .MdiParent = Me
            }

            'Manejamos el evento cuando se cierra el formulario de alta'
            AddHandler ventanaAccionesAnimal.FormClosed, AddressOf FormularioAccionesAnimal_FormClosed

            'Mostramos el formulario de alta de usuario'
            ventanaAccionesAnimal.Show()

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

    '------------------------------ HANDLER ESTADO DE LA DEPENDENCIA VENTANALATA ------------------------------'
    Private Sub FormularioAltaUsuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ventanaAlta = Nothing
    End Sub

    Private Sub FormularioBajaUsuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ventanaBaja = Nothing
    End Sub

    Private Sub FormularioAccionesUsuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ventanaAcciones = Nothing
    End Sub

    Private Sub FormularioReactivarUsuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ventanaReactivar = Nothing
    End Sub

    Private Sub FormularioAltaCliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ventanaAltaCliente = Nothing
    End Sub

    Private Sub FormularioBajaCliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ventanaBajaCliente = Nothing
    End Sub

    Private Sub FormularioAccionesCliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ventanaAccionesCliente = Nothing
    End Sub

    Private Sub FormularioReactivarCliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ventanaReactivarCliente = Nothing
    End Sub
    Private Sub FormularioAltaEspecie_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ventanaAltaEspecies = Nothing
    End Sub

    Private Sub FormularioAccionesEspecie_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ventanaAccionesEspecie = Nothing
    End Sub

    Private Sub FormularioAltaAnimal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ventanaAltaAnimal = Nothing
    End Sub

    Private Sub FormularioBajaAnimal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ventanaBajaAnimal = Nothing
    End Sub

    Private Sub FormularioAccionesAnimal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ventanaAccionesAnimal = Nothing
    End Sub



#End Region

End Class
