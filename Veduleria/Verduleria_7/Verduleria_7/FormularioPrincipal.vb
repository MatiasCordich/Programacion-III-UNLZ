Imports System.Configuration

Public Class FormularioPrincipal

#Region "Dependencias"
    Private ventanaLista As FormularioListar
    Private ventanaAlta As FormularioAlta
#End Region

#Region "Eventos"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        'Le estamos diciendo que al hacer clic en la opcion SALIR del menu que me cierre el FormularioPrincipal'
        Me.Close()
    End Sub

    Private Sub AltaDeVerdurasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeVerdurasToolStripMenuItem.Click

        'Validamos si existe nuestra ventanaAlta'
        If ventanaAlta Is Nothing Then
            'Si no existe la creamos de tipo FormularioAlta'
            ventanaAlta = New FormularioAlta

            'Configuramos que ventaAlta, de tipo FormularioAlta, tenga como padre el FormularioPrincipal'
            ventanaAlta.MdiParent = Me

            'Definimos que ventaAlta, de tipo FormularioAlta, tenga como propiedad de ancho COMPLETO'
            ventanaAlta.WindowState = FormWindowState.Maximized
        End If

        'Una vez creado el objeto, mostramos el formulario con el métido Show()'
        ventanaAlta.Show()
    End Sub

    Private Sub ListarVerdurasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarVerdurasToolStripMenuItem.Click

        'Validamos si existe nuestra ventaLista'
        If ventanaLista Is Nothing Then

            'Si no existe la creamos de tipo FormularioLista'
            ventanaLista = New FormularioListar

            'Configuramos que ventaLista, de tipo FormularioLista, tenga como padre el FormularioPrincipal'
            ventanaLista.MdiParent = Me

            'Definimos que ventaAlta, de tipo FormularioLista, tenga como propiedad de ancho COMPLETO'
            ventanaLista.WindowState = FormWindowState.Maximized
        End If

        'Una vez creado el objeto, mostramos el formulario con el métido Show()'
        ventanaLista.Show()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        'Levantamos el valor de la contraseña de nuestras configuraciones
        'Y lo guardamos en una variable
        Dim claveConfigurada = ConfigurationManager.AppSettings("password")


        'Hacemos una variable mutable'
        Dim mensaje = "CONTRASEÑA INCORRECTA: Ingrese 123"

        'Tomamos el valor del TextBox'
        Dim password = txt_password.Text

        'Validamos que el valor obtenido sea igual al valor definido en la configuracion'
        If password = claveConfigurada Then

            'Activamos el Timer'
            Timer1.Enabled = True

            'El mensaje del Label lo cambiamos'
            mensaje = "Cargando..."
        End If

        'En caso de no pasar la validacion el valor del Label sera el texto por defecto'
        lbl_descripcion.Text = mensaje

        'Mostramos el Label con el mensaje obtenido'
        lbl_descripcion.Visible = True


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Validamos el valor de la ProgressBar'
        If ProgressBar1.Value = ProgressBar1.Maximum Then

            'Si es igual a su MAXIMO entonces mostramos el MenuStrip'
            MenuStrip1.Visible = True

            'Tambien ocultamos el panel de Login'
            Panel1.Visible = False
        Else

            'Caso contrario rellenamos (acumulamos) la ProgressBarr hasta llegar a su final'

            'Tomamos el valor de la ProgressBar y le sumamos 10'
            Dim nuevoValor = ProgressBar1.Value + 10

            'Igualamos el valor de la ProgressBar con la funcion Min, así nos aseguramos que no se sobrepase'
            ProgressBar1.Value = Math.Min(nuevoValor, ProgressBar1.Maximum)
        End If
    End Sub

    Private Sub CambiarFondoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarFondoToolStripMenuItem.Click

        'Mostramos la ventana para buscar la imagen'
        OpenFileDialog1.ShowDialog()

        'Capturamos la ruta de la imagen'
        Dim rutaArchivo = OpenFileDialog1.FileName

        'Convertimos la ruta en una Imagen'
        Dim imagenFondo = Image.FromFile(rutaArchivo)

        'Cambiamos el fondo de nuestro Formulario Principal con la imagen'
        Me.BackgroundImage = imagenFondo

        'Con la propiedad BackgroundImageLayout podemos hacer que la imagen no se vea en mosaico'
        Me.BackgroundImageLayout = ImageLayout.Stretch

    End Sub

    Private Sub FormularioPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Obtenemos el valor de la configuracion'
        Dim imagenConfiguracion = ConfigurationManager.AppSettings("imagen-backgound")

        'Obtenemos el valor de la configuracion'
        Dim cambiaFondo = ConfigurationManager.AppSettings("cambia-fondo")

        'Evaluamos el valor que obtuvimos de la configuracion cambia-fondo'
        If cambiaFondo <> "S" Then
            'Si el valor es DISTINTO DE S entonces la opcion de cambiar fondo se oculta'
            CambiarFondoToolStripMenuItem.Visible = False
        End If

        'Convertimos el valor en imagen'
        Dim imagenFondo = Image.FromFile(imagenConfiguracion)

        'Le cambiamos el fondo al Formulario Principal'
        Me.BackgroundImage = imagenFondo
    End Sub

#End Region

End Class
