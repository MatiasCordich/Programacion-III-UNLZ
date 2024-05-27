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
using System.Windows.Forms.VisualStyles;

namespace CarritoClient
{
    public partial class Form1 : Form
    {

        // Nuestras dependencias, en este caso solo tenemos dtArticulos que es de tipo DataTable
        #region Dependencias
        private DataTable dtArticulos;
        #endregion

        // Simplemente es nuestro Constructor
        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        // Nuestras acciones
        #region Acciones

        // Esta funcion va a apuntar nuestra DataTable a el DataGrid que tengamos en nuestra app de Windows Forms
        public void SetDataTableArticulos(DataTable dt)
        {
            this.dtArticulos = dt;
            data_grid_Articulos.DataSource = dt;
        }

        // Esta funcion crea la DataTable con su estructura 
        public void InicializarDataTable()
        {
            // Creamos un objeto de tipo DataTable
            DataTable dt = new DataTable();

            // Le creamos las columnas
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Precio", typeof(double));

            // La DataTable que creamos se la pasamos por parametro a la funcion setDataTableArticulos
            this.SetDataTableArticulos(dt);
        }

        // Esta funcion hace las operaciones del Carrito
        public void OperacionesCarrito()
        {
            // Variable para sacar el total de los Productos
            double totalProductos = 0;

            // Variable para sacar el total de los Productos que empiecen con R
            double totalProductosR = 0;

            // Variable para sacar la cantidad de Productos que emipiecen con R
            double contadorProductosR = 0;

            // Recorremos nuestra DataTable
            foreach (DataRow renglon in this.dtArticulos.Rows)
            {
                // Sumamos el total de los productos que se vayan agregando
                totalProductos += Convert.ToDouble(renglon["Precio"]);

                // Obtenemos el nombre de cada producto de nuestro Row (renglon)
                string nombre = renglon["Nombre"].ToString();

                // Si el nombre de nuestro renglon empieza con R hacemos lo siguiente
                if (nombre.ToUpper().StartsWith("R"))
                {
                    // Le sumamos a la variable totalProductosR  
                    totalProductosR += Convert.ToDouble(renglon["Precio"]);

                    // Incrementamos en 1 el contador de Productos que empiecen con R
                    contadorProductosR++;
                }
            }

            // Sacamos los promedios
            double promedio = totalProductos / this.dtArticulos.Rows.Count; // Como es sobre el total, al hacer Rows.Count contabilizamos la cantidad total de FILAS de nuestro DataTable
            double promedioR = totalProductosR / contadorProductosR;

            // Visualizamos los resultados de la suma de Totales
            lbl_Total.Text = totalProductos.ToString("#0.00");
            lbl_totalR.Text = totalProductosR.ToString("#0.00");

            // Visualizamos los resutlados de los promedios
            lbl_Promedio.Text = promedio.ToString("#0.00");

            // Para el promedio de los productos con R hacemos una condicion para evitar la division por cero 0
            if (contadorProductosR > 0) {

                // Si la cantidad es mayor a cero 0 que me muestre el promedio
                lbl_PromedioR.Text = promedioR.ToString("#0.00");
            } else
            {
                // Si es cero 0 que me muestre hardcodeado "0.00"
                lbl_PromedioR.Text = "0.00";
            }


        }
        #endregion

        // Region para los EVENTOS de cada componente
        #region Eventos

        // Evento click para guardar el producto, sumar los totales y promedios
        private void btn_GuardarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txt_descripcion.Text;
            string precioS = txt_precio.Text;

            double precio = Double.Parse(precioS);

            Articulo nuevoArticulo = new Articulo(nombre, precio);

            this.dtArticulos.Rows.Add(nuevoArticulo.description, nuevoArticulo.price);

            this.OperacionesCarrito();

        }

        // Evento load para inicializar la DataTable 
        /*
          Llamo a mi funcion IncializarDataTable que hace lo siguiente:
            - Crea la DataTable
            - Le define las COLUMNAS a la DataTable
            - Llama a la funcion SetDataTableArticulos que hace lo siguiente: 
                 - Le pasamos nuestra DataTableCreada
                 - La DataTable que creamos como DEPENDENCIA tendra el valor de nuestra DataTable creada y la pasamos por parametro
                 - A la DataGrid le asignamos nuestra DataTable creada en nuestro DataSource
                 - De esta manera nuestra DataTable que creamos como DEPENDENCIA, dtArticulos, tiene una DataTable con una estrectura de COLUMNAS y apunta a un DataGridView
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            this.InicializarDataTable();
        }

        #endregion



    }
}
