using ABM_Remeras.Models;
using ABM_Remeras.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABM_Remeras.Formularios
{
    public partial class FormAltaRemeras : Form
    {
        private List<Remera> listaRemerasHijo;


        // -------------------- CONSTRUCTOR -------------------- //

        // El constructor del hijo recibe por parametro la lista del Formulario padre
        public FormAltaRemeras(List<Remera> remeras)
        {
            InitializeComponent();

            // A la lista del hijo se le asigna como valor la lista del padre
            // No hace falta inicializarla porque le pasamos la lista del padre que ya fue inicializada
            this.listaRemerasHijo = remeras;

            // Inicializamos la DataGrid con lo que haya de informacion en la lista del Padre 
            Dgv_listaRemeras.DataSource = listaRemerasHijo;
        }

        // -------------------- METODOS -------------------- //
        private void LimpiarCamposAlta()
        {
            Txt_codigoAlta.Text = "";
            Txt_detalleAlta.Text = "";
            Txt_precioAlta.Text = "";
            Cb_talleAlta.SelectedIndex = 0;
        }

        private void CargarDatos()
        {
            // Calcular el promedio de precio de las remeras con talle L
            double promedioPrecioL = RemeraService.CalcuarPromedioPrecioL(listaRemerasHijo);

            // Calcular la cantidad de remeras con talle Xl
            int cantidadTalleXL = RemeraService.CantidadRemerasXL(listaRemerasHijo);

            // Muestro los resultados en los lables
            Lbl_descripcionPromedio.Text = promedioPrecioL.ToString("#0.00");
            Lbl_descripcionCantidad.Text = cantidadTalleXL.ToString();
        }

        // -------------------- EVENTOS -------------------- //
        private void FormAltaRemeras_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void Btn_altaRemera_Click(object sender, EventArgs e)
        {
            // Tomamos los valores de los TextBox y ComboBox
            string codigo = Txt_codigoAlta.Text.ToUpper();
            string detalle = Txt_detalleAlta.Text;
            string precioS = Txt_precioAlta.Text;
            string talle = Cb_talleAlta.SelectedItem.ToString();

            // Validaciones 

            // Validamos que codigo, detalle y precio no sean valores vacios
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(detalle) || string.IsNullOrEmpty(precioS))  {
                MessageBox.Show("No puede haber campos vacios");
                return;
            }

            // Validamos que precio sea numerico y positivo
            if (!double.TryParse(precioS, out double precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un valor válido para el precio.");
                return;
            }

            // Validamos que el codigo ingresado sea unico
            if(listaRemerasHijo.Any(remera => remera.Codigo == codigo))
            {
                MessageBox.Show("El código ingresado ya existe. Ingrese un código único.");
                return;
            }

            // Si paso todas las validaciones creamos el nuevo objeto de tipo Remera
            Remera nuevaRemera = new Remera(codigo, detalle, precio, talle);

            // Agregamos la remera a la lista
            listaRemerasHijo.Add(nuevaRemera);

            // Limpiamos siempre la DataGrid para refrescar con la informacion nueva
            Dgv_listaRemeras.DataSource = null;

            // Volcamos la informacion en la DataGrid
            Dgv_listaRemeras.DataSource = listaRemerasHijo;

            // Cargo de vuelta los datos actualizados
            this.CargarDatos();
            
            // Limpiar campos
            LimpiarCamposAlta();

        }

        
    }
}
