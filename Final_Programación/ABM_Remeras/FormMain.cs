using ABM_Remeras.Formularios;
using ABM_Remeras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ABM_Remeras
{
    public partial class FormMain : Form
    {

        // Creamos una lista de Remeras 
        private List<Remera> remeras;

        // Creamos los formularios hijos con los que vamos a trabajar
        private FormAltaRemeras formAlta;
        private FormEditarRemera formEditar;
        private FormBajaRemera formBaja;

        // ------------- CONSTRUCTOR ------------- //
        public FormMain()
        {
            InitializeComponent();

            // Inicializamos la lista del Formualario Principal
            this.remeras = new List<Remera>();
        }

        // ------------- EVENTOS ------------- //

        // Menu Alta de Remera
        private void altaDeRemeraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Verifica si hay un formulario de Alta
            if (formAlta == null)
            {

                // Si no lo hay lo instanciamos y le pasamos la Lista de remeras del Padri
                formAlta = new FormAltaRemeras(this.remeras);

                // Le definimos que el MdiParent es el FormMain
                formAlta.MdiParent = this;

                // Manejamos el cierre del formlario de alta
                formAlta.FormClosed += FormAltaRemeras_FormClosed;

                // Mostarmos el formulario de alta
                formAlta.Show();

            }

        }

        // Menu Editar Remera
        private void editarRemeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            if (formEditar == null)
            {

                // La lista que creamos aca en el Formulario principal se la pasamos al formulario hijo de Alta
                formEditar = new FormEditarRemera(this.remeras);

                formEditar.MdiParent = this;

                formEditar.FormClosed += FormEditarRemeras_FormClosed;

                formEditar.Show();

            }
        }

        // Menu Baja de Remera
        private void bajaDeRemeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formBaja == null)
            {

                // La lista que creamos aca en el Formulario principal se la pasamos al formulario hijo de Alta
                formBaja = new FormBajaRemera(this.remeras);

                formBaja.MdiParent = this;

                formBaja.FormClosed += FormBajaRemeras_FormClosed;

                formBaja.Show();

            }
        }

        // ------------- HANDLERS ------------- //
        private void FormAltaRemeras_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAlta = null;
        }

        private void FormEditarRemeras_FormClosed(object sender, FormClosedEventArgs e)
        {
            formEditar = null;
        }

        private void FormBajaRemeras_FormClosed(object sender, FormClosedEventArgs e)
        {
            formBaja = null;
        }

       
    }
}
