﻿using Services.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resolucion_Parcial_C_
{
    public partial class Form1 : Form
    {
        #region Dependencias
        private DataTable dtPinturas;
        #endregion

        #region Inicializar
        private void InicializarDataTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("CODIGO", typeof(long));
            dt.Columns.Add("COLOR", typeof(string));
            dt.Columns.Add("LITROS", typeof(double));

            this.SetDataTable(dt);
        }

        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Acciones
        private void SetDataTable(DataTable dt)
        {
            this.dtPinturas = dt;
            dtGrid_Pinturas.DataSource = dt;
        }

        private void CalcularTotalLitrosPinturaRoja() {

            double acumuladorLitrosRojo = 0;

            foreach (DataRow renglon in this.dtPinturas.Rows)
            {
                string color = renglon["COLOR"].ToString();

                if (color.ToUpper() == "ROJO" ||  color.ToUpper() == "ROJA")
                {
                    acumuladorLitrosRojo += Convert.ToDouble(renglon["LITROS"]);
                }
            }

            lbl_totalRojo.Text = acumuladorLitrosRojo.ToString("#0.00");

        }

        private void CalcularPromedioLitrosPinturaAzul() {

            int contadorPinturaAzul = 0;
            double acumuladorLitrosAzul = 0;

            foreach (DataRow renglon in this.dtPinturas.Rows)
            {
                string color = renglon["COLOR"].ToString();

                if (color.ToUpper() == "AZUL")
                {
                    acumuladorLitrosAzul += Convert.ToDouble(renglon["LITROS"]);
                    contadorPinturaAzul++;
                }
            }

            double promedio = acumuladorLitrosAzul / contadorPinturaAzul;

            if (promedio > 0)
            {
                lbl_promedioAzul.Text = promedio.ToString("#0.00");
            } else
            {
                lbl_promedioAzul.Text = "0.00";
            }
        }

        private void LimpiarTextBox() {
            txt_Codigo.Text = "";
            txt_Color.Text = "";
            txt_Litros.Text = "";
        }


        #endregion

        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            this.InicializarDataTable();
        }

        private void btn_AgregarPintura_Click(object sender, EventArgs e)
        {
            // Primero tomo los valores de los TextBoxes
            string codigoS = txt_Codigo.Text;
            string color = txt_Color.Text;
            string litrosS = txt_Litros.Text;

            // PRIMERA VALIDACION: QUE NO HAYA CAMPOS VACIOS
            // La primera validacion es asegurarnos que no se haya ingresado ningun dato vacio en los TextBoxes
            if (codigoS.Equals("") || color.Equals("") || litrosS.Equals(""))
            {
                MessageBox.Show("ERROR: Algunos campos estan vacios");
                return;
            }

            // Si todos los TextBoxes tienen algun valor ahora hago la SEGUNDA validacion
            // SEGUNDA VALIDACION: TIPOS DE DATOS NUMERICOS
            // Valido que tanto CODIGO como LITROS tengan un valor numerico
            try
            {
                int codigo = int.Parse(codigoS);
                double litros = double.Parse(litrosS);

                // Si pasa la segunda validacion ahora hago la TERCERA validacion
                // TERCERA VALIDACION: CODIGO UNICO
                // Valido que el CODIGO no este repetido
                foreach (DataRow renglon in dtPinturas.Rows)
                {
                    if (renglon["CODIGO"].ToString() == codigo.ToString())
                    {
                        MessageBox.Show("ERROR: Codigo repetido, por favor ingrese uno diferente");
                        return;
                    }
                }

                // Si paso la tercera validacion ahora hago la CUARTA validacion
                // CUARTA VALIDACION: NUMEROS NEGATIVOS
                // Valido que tanto CODIGO como LITROS no sean numeros negativos
                if (codigo < 0 || litros < 0)
                {
                    MessageBox.Show("ERROR: Numero negativo, por favor ingrese valores POSITIVOS");
                    return;
                }

                // Si pasaron todas las validaciones creo un nuevo objeto de tipo Pintura
                Pintura nuevaPintura = new Pintura(codigo, color, litros);

                // Agregamos una FILA conlas propiedades del nuevo objeto
                this.dtPinturas.Rows.Add(nuevaPintura.codigo, nuevaPintura.color, nuevaPintura.litros);

                // Ejecuto las funciones de mi region Acciones
                this.CalcularTotalLitrosPinturaRoja();
                this.CalcularPromedioLitrosPinturaAzul();
                this.LimpiarTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Los valores de CODIGO o LITROS deben ser NUMERICOS");
            }
        }
        #endregion




    }
}
