using ABM_Remeras.Models;
using ABM_Remeras.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABM_Remeras.Formularios
{
    public partial class FormEditarRemera : Form
    {
        private List<Remera> listaRemerasHijo;

        // -------------------- CONSTRUCTOR -------------------- //
        public FormEditarRemera(List<Remera> remeras)
        {
            InitializeComponent();

            // A la lista del hijo se le asigna como valor la lista del padre
            // No hace falta inicializarla porque le pasamos la lista del padre que ya fue inicializada
            this.listaRemerasHijo = remeras;

            // Inicializamos la DataGrid con lo que haya de informacion en la lista del Padre 
            Dgv_listaRemeras.DataSource = remeras;
        }

        // -------------------- METODOS -------------------- //
        private void LimpiarCamposEditar()
        {
            Txt_codigoEditar.Text = "";
            Txt_detalleEditar.Text = "";
            Txt_precioEditar.Text = "";
            Cb_talleEditar.SelectedIndex = 0;
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
        private void FormEditarRemera_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void Btn_editarRemera_Click(object sender, EventArgs e)
        {
        
            // Tomamos los valores de los TextBox y ComboBox
            string codigo = Txt_codigoEditar.Text.ToUpper();
            string detalle = Txt_detalleEditar.Text;
            string precioS = Txt_precioEditar.Text;
            string talle = Cb_talleEditar.SelectedItem.ToString();

            // Validaciones 

            // Validamos que codigo, detalle y precio no sean valores vacios
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(detalle) || string.IsNullOrEmpty(precioS))
            {
                MessageBox.Show("No puede haber campos vacios");
                return;
            }

            // Validamos que precio sea numerico y positivo
            if (!double.TryParse(precioS, out double precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un valor válido para el precio.");
                return;
            }

            // Validamos que el codigo ingresado exista
            Remera remeraEcontrada = listaRemerasHijo.Find(remera => remera.Codigo == codigo);
            
            if (remeraEcontrada == null) {
                MessageBox.Show("No se encontro la remera para editar");
                return;
            }

            // A la remera encontrada le asignamos los nuevos valores
            remeraEcontrada.Detalle = detalle;
            remeraEcontrada.Precio = precio;   
            remeraEcontrada.Talle = talle;

            MessageBox.Show("Remera editada");

            // Limpiamos siempre la DataGrid para refrescar con la informacion nueva
            Dgv_listaRemeras.DataSource = null;

            // Volcamos la informacion en la DataGrid
            Dgv_listaRemeras.DataSource = listaRemerasHijo;

            // Cargamos los devuelta con los datos actualizados
            this.CargarDatos();

            // Limpiar campos
            LimpiarCamposEditar();

        }

        
    }
}
