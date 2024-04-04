using CarritoServices.Models;
using CarritoServices.Services;
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
        // Creamos el atributo para manejar el ID
        private long ID = 0;

        // Cremaos la lista para guardar los articulos 
        private readonly List<Articulo> listaArticulos;

        // Creamos el atributo Carrito 
        private readonly Carrito carrito;

        // Constructor
        public Form1()
        {
            InitializeComponent();

            // Instanciamos la lista de articulos
            this.listaArticulos = new List<Articulo>();

            // Intanciamos la clase carrito
            this.carrito = new Carrito();

        }

        // Funcion que me guarda los articulos y me los muestra
        private void btnGuardarArticulo_Click(object sender, EventArgs e)
        {
            // Obtenemos los valores de los textBox
            string detalle = textBoxDetalle.Text;
            string sPrecio = textBoxPrecio.Text;

            // Parseamos el precio 
            decimal precio = decimal.Parse(sPrecio);

            // Aumentamos el numero de ID 
            this.ID++;

            // Creamos el nuevo objeto de tipo Articulo
            Articulo nuevoArticulo = new Articulo(ID, detalle, precio);

            // Agregamos dicho objeot a la lista 
            this.listaArticulos.Add(nuevoArticulo);

            // Visualizamos el dataGridView con los articulos
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaArticulos;
        }

        // Funcion que me suma el monto total de mi carrito
        private void btnSumarCarrito_Click(object sender, EventArgs e)
        {
            // Obtengo el valor de mi textbox
            string sID = textBoxID.Text;

            // Parseo el valor de ID obtenido 
            long id = long.Parse(sID);

            // Recorro mi lista de Articulos
            foreach (Articulo articulo in listaArticulos)
            {
                // Por cada articulo quiero el id
                if (articulo.id == id)
                {
                    // Si el id del articulo de turno es igual al id que se paso por el texbox agregame dicho articulo a Carrito
                    carrito.agregar(articulo);
                    break;
                }
            }

            // Obtengo el monto total de Carrito con getTotal() y lo parseo a string
            string sTotalCarrito = carrito.getTotal().ToString();

            // Dicho total lo muestro en el labelTotalCarrito
            this.labelTotalCarrito.Text = sTotalCarrito;
        }
    }
}

