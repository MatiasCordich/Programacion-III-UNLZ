using ABM_Remeras.Models;
using ABM_Remeras.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABM_Remeras.Formularios
{
    public partial class FormBajaRemera : Form
    {
        private List<Remera> listaRemerasHijo;

        // -------------------- CONSTRUCTOR -------------------- //
        public FormBajaRemera(List<Remera> remeras)
        {
            InitializeComponent();

            // A la lista del hijo se le asigna como valor la lista del padre
            // No hace falta inicializarla porque le pasamos la lista del padre que ya fue inicializada
            this.listaRemerasHijo = remeras;

            // Inicializamos la DataGrid con lo que haya de informacion en la lista del Padre 
            Dgv_listaRemeras.DataSource = remeras;
        }

        // -------------------- METODOS -------------------- //
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
        private void FormBajaRemera_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void Btn_bajaRemera_Click(object sender, EventArgs e)
        {
            // Tomamos el valor del TextBox
            string codigo = Txt_codigoBaja.Text.ToUpper();
           
            // Validaciones 

            // Validamos que el valor del codigo no sea vacio
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("El campo ID no puede estar vacio");
                return;
            }


            // Validamos que el codigo ingresado exista
            Remera remeraEcontrada = listaRemerasHijo.Find(remera => remera.Codigo == codigo);

            if (remeraEcontrada == null)
            {
                MessageBox.Show("No se encontro la remera para eliminar");
                return;
            }

            // Agregamos la remera a la lista
            listaRemerasHijo.Remove(remeraEcontrada);

            // Limpiamos siempre la DataGrid para refrescar con la informacion nueva
            Dgv_listaRemeras.DataSource = null;

            // Volcamos la informacion en la DataGrid
            Dgv_listaRemeras.DataSource = listaRemerasHijo;

            MessageBox.Show("Remera eliminada exitosamente");

            // Volver a cargar los datos actuaizados
            this.CargarDatos();

            // Limpiamos el TextBox
            Txt_codigoBaja.Text = "";
        }

       
    }
}
