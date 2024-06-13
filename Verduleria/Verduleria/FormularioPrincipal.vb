Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormularioPrincipal

#Region "Dependencias"
    'Aca estaran las dependencias de nuestro FormularioPrincipal'
    'Van a estar aca las demas ventanas de los formularios'

    Private ventanaAlta As New FormularioAlta
    Private ventanaListar As New FormularioListado
#End Region

#Region "Eventos"
    'Aca van a estar todas las funcionalidades de los componenentes al activarse con un evento'

    'Funcion para cerrar el FormularioPrincipal haciendo click en una de las opciones del MenuStrip'
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Funcion para redirigirse al Formulario de alta de verduras haciendo clic en una opcion del MenuStrip'
    Private Sub AltaDeVerdurasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeVerdurasToolStripMenuItem.Click

        'Validamos si existe un objetio de tipo FormularioAlta'
        If ventanaAlta Is Nothing Then

            'Si no existe lo creamos y se lo definimos a la dependencia ventanaAlta'
            ventanaAlta = New FormularioAlta

            'Definir que el formulario sera un MDI Child'
            'El padre de ventanaAlta (MDI hijo) es el FormularioPrincial (MDI Parent)'
            ventanaAlta.MdiParent = Me

            'Le definimos al formulario hijo la propiedad de Maximizado'
            ventanaAlta.WindowState = FormWindowState.Maximized
        End If

        'Mostramos la ventana'
        ventanaAlta.Show()
    End Sub

    'Funcion para redirigirse al Formulario de listado de verduras haciendo clic en una opcion del MenuStrip'
    Private Sub VerListadoVerdurasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerListadoVerdurasToolStripMenuItem.Click

        'Validamos si existe un objetio de tipo FormularioListado'
        If ventanaListar Is Nothing Then

            'Si no existe lo creamos y se lo definimos a la dependencia ventanaAlta'
            ventanaListar = New FormularioListado

            'Definir que el formulario sera un MDI Child'
            'El padre de ventanaListar (MDI hijo) es el FormularioPrincial (MDI Parent)'
            ventanaListar.MdiParent = Me

            'Le definimos al formulario hijo la propiedad de Maximizado'
            ventanaAlta.WindowState = FormWindowState.Maximized
        End If

        'Mostramos la ventana'
        ventanaListar.Show()
    End Sub

    'Funcion para loguerse haciendo clic en el boton de Login'
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click

        'Definimos algunas variables'

        'La variable password va a guardar el valor de la configuracion que hicimos del archivo App.config (el archivo XML)'
        Dim password = ConfigurationManager.AppSettings("password") 'Le pasamos como parametro el nombre de la configuracion (key) y va a tomar el valor (value)'

        'Variable mutable de mensaje'
        Dim mensaje = "Password incorrecta, ingrese 123"

        'Validamos el valor ingresado del password'
        If txt_loginPassword.Text = password Then

            'Metodo anterior donde tenemos una pantalla de carga

            'Dim pantallaCarga As New PantallaCarga

            'PantallaCarga.Show() aca se muestra la Pantalla Carga y ejecutara las funcionalidades que tenga'

            'Si la validacion es correcta activamos el Timer'
            TimerCarga.Enabled = True

            'El valor de la variable MENSAJE cambia'
            mensaje = "Cargando..."

        End If

        'Si el valor ingresado por el TextBox no es el mismo que la variable Password entonces'

        'Muestro el mensaje de error en el Label'
        lbl_labelInfo.Text = mensaje

        'Cambio la visibilidad del Label para que se vea el mensaje de error'
        lbl_labelInfo.Visible = True

    End Sub

    'Funcion para darle dinamismo a la ProgressBar con el Timer'
    Private Sub TimerCarga_Tick(sender As Object, e As EventArgs) Handles TimerCarga.Tick

        'Validamos el valor que tiene el componente ProgressBar'
        If pg_barraCargando.Value = pg_barraCargando.Maximum Then

            'Si el valor del componente es IGUAL a su MAXIMO'

            'Ocultamos el panel de Login'
            panel_Login.Hide()

            'Mostramos el MenuStrip'
            ms_MenuOpciones.Visible = True
        Else
            'Caso contrario'

            'Le sumamos un valor de 10 al valor de la ProgressBar'
            Dim nuevoValor = pg_barraCargando.Value + 10

            'El valor de la ProgressBarr va a oscilar entre el nuevo valor y el valor maximo que acepta el componente (100)'
            pg_barraCargando.Value = Math.Min(nuevoValor, pg_barraCargando.Maximum)
        End If
    End Sub

    'Funcio para cambiar el fondo hacinedo clic en uno de las opciones del MenuStrip'
    Private Sub CambiarFondoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarFondoToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()

        'OpenDialog es un componente que nos abre la ventana para buscar archivos'
        Dim rutaArchivo = OpenFileDialog1.FileName 'Mediante FileName buscamos el archivo en cuestion y lo guardamos en una variable'

        'Este messageBox nos va a mostrar el valor de rutaArchivo que es la ruta del archivo seleccionado'
        MessageBox.Show(rutaArchivo)

        'Creamos una variable llamada imagenFondo para crear la imagen'
        Dim imagenFondo = Image.FromFile(rutaArchivo) 'Mediante FromFile() le pasamos por parametro la variable rutaArchivo'

        'De nuestro Formulario Principal le cambiamos la propiedad BackgroundImage y de valor le pasamos la imagen creada y guardada com variable'
        Me.BackgroundImage = imagenFondo
    End Sub

    'Funcion para setear una imagen predefinida cuando se ejecuta el evento Load del Formulario'
    Private Sub FromPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Guardamos el valor de la configuracion cambia-fondo que se encuentra en el archivo XML'
        Dim cambiaFondo = ConfigurationManager.AppSettings("cambia-fondo")

        'Evaluamos que valor tiene la variable cambiaFondo'
        If cambiaFondo <> "S" Then
            'Si cambiaFondo es distinto de S entonces la opcion del MenuStrip para cambiar el fondo NO SERA VISIBLE '
            CambiarFondoToolStripMenuItem.Visible = False
        End If

    End Sub
#End Region

End Class
