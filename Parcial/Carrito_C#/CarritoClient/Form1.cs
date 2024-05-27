using CarritoServices.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarritoClient
{
    public partial class Form1 : Form
    {
        private readonly DataTable dtArticulos;
        private double totalPrecio;
        private double totalPrecioR;
        private long nextId;
        public Form1()
        {
            InitializeComponent();

            // Inicializar el DataTable en el constructor para cumplir con readonly
            this.dtArticulos = new DataTable();
            InicialiarDataTable();

            // Enlazar el DataTable con el DataGridView
            data_grid_Articulos.DataSource = dtArticulos;

            // Inicializar el total de precios
            this.totalPrecio = 0.0;
            this.totalPrecioR = 0.0;

            // Inicializar el ID en 1
            this.nextId = 1;

        }

        // Funcion para inicializar la DataTable con sus CAMPOS
        private void InicialiarDataTable()
        {
            
            // Agregamos columnas
            this.dtArticulos.Columns.Add("ID", typeof(long));
            this.dtArticulos.Columns.Add("Nombre", typeof(string));
            this.dtArticulos.Columns.Add("Precio", typeof(double));

        }

        // Funcion para guardar el producto y sumar el total
        private void btn_GuardarProducto_Click(object sender, EventArgs e)
        {
            // Tomamos los valores del los TextBox
            string detalle = txt_descripcion.Text;
            string sPrecio = txt_precio.Text;

            // Parseamos el precio
            decimal precio = decimal.Parse(sPrecio);


            // Creamos un nuevo objeto de tipo Articulo
            Articulo nuevoArticulo = new Articulo(this.nextId++, detalle, precio);

            // Agregamos el nuevo articulo a la DataTable
            dtArticulos.Rows.Add(nuevoArticulo.id, nuevoArticulo.description, nuevoArticulo.price);

            // Calculamos el total 
            this.CalcularTotal();

            // Calculamos el total de los productos con R
            this.CalcularTotalR();

            // Limpiamos los TextBox
            txt_descripcion.Clear();
            txt_precio.Clear();

        }


        // Funcion que recorre el DataTable y suma el total
        private void CalcularTotal()
        {

            foreach (DataRow renglon in this.dtArticulos.Rows)
            {
                this.totalPrecio += Convert.ToDouble(renglon["Precio"]);
                ActualizarLabelTotal();


            }
        }

        private void CalcularTotalR()
        {
            foreach (DataRow renglon in this.dtArticulos.Rows)
            {

                if (renglon["Nombre"].ToString().StartsWith("R"))
                {
                    this.totalPrecioR += Convert.ToDouble(renglon["Precio"]);
                    ActuAlizarLabelTotalLetraR();
                }
            }
        }

        // Funcion que actualiza el Label del total de productos
        private void ActualizarLabelTotal()
        {
            label_Total.Text = totalPrecio.ToString("#0.00");
        }

        private void ActuAlizarLabelTotalLetraR()
        {
            label_txt_totalR.Text = totalPrecioR.ToString("#0.00");
        }
    }
}
