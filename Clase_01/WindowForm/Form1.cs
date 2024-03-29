namespace WindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            // Obtengo los valores de los textBoxs
            string sNumeroA = this.textBox1.Text;
            string sNumeroB = this.textBox2.Text;

            // Transformo los dos strings que obtuve a enterios
            int numeroA = int.Parse(sNumeroA);
            int numeroB = int.Parse(sNumeroB);

            // Realizo la suma y guardo el valor en una variable
            int resultado = numeroA + numeroB;

            // El resultado ahora lo transformo en un string para que se muestre
            this.labelResultado.Text = resultado.ToString();

            // Agregar los datos de cada suma a la tabla Historial
            this.dataGridHistorial.Rows.Add(numeroA, numeroB, resultado);
        }

        
    }
}
