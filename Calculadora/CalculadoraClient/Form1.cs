using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraClient
{
    public partial class Form1 : Form
    {
        // Atributos de nuestra Aplicacion 
        private List<Operacion> historial;

        public Form1()
        {
            InitializeComponent();

            // Instanciamos el historial
            this.historial = new List<Operacion>();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            // Obtenemos los datos de los textBox
            string sNumeroA = this.textBoxNumA.Text;
            string sNumeroB = this.textBoxNumB.Text;

            // Parseamos los valores del textBox a int
            int numeroA = int.Parse(sNumeroA);
            int numeroB = int.Parse(sNumeroB);

            // Realizamos la suma 
            int resultado = numeroA + numeroB;

            // Creamos el objeto de tipo Operacion
            Operacion nuevaOperacion = new Operacion();

            // Para cada atributo del objeto le asigno los valores necesarios
            nuevaOperacion.a = numeroA;
            nuevaOperacion.b = numeroB;
            nuevaOperacion.tipo = '+';
            nuevaOperacion.resultado = resultado;

            // Agregamos dicha operacion al historial
            this.historial.Add(nuevaOperacion);

            // El resultado de la operacion lo mostramos en un label (parseamos a string la variable resultado)
            this.labelResultado.Text = resultado.ToString();

            // Mostramos el historial en el datGridView 
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.historial;
        }
    }
}
