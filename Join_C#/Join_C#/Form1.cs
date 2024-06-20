using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Join_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Generamos la URL de nuestra conexion 
            string connectionString = "server=MATIAS\\SQLEXPRESS01;Database=vecindario;Integrated Security=true";

            // Generamos la conexión 
            SqlConnection connection = new SqlConnection(connectionString);

            // Abrimos la conexion
            connection.Open();

            // Hacemos la query 
            string query = $"SELECT * FROM Personas as p JOIN Casas as c ON p.CasaID = c.ID";

            // Creamos el comando 
            var command = connection.CreateCommand();

            // Le agregamos el texto de la sentencia al comando
            command.CommandText = query;

            // En vez de un lector (redar) vamos a crear un ADAPTER que es de tipo SqlDataAdapter
            // Le pasamos el comando
            SqlDataAdapter adapt = new SqlDataAdapter(command);

            // Creamos la DataTable vacía
            DataTable dt = new DataTable();

            // Le llenamos al DataTable toda la informacion del ADAPTER
            adapt.Fill(dt);

            // Por ultimo le pasamos al dataGrid en el dataSource el DataTable
            dataGridView1.DataSource = dt;

         
        }
    }
}
