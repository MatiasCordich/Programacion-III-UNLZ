namespace ABM_Remeras
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ms_menuRemeras = new System.Windows.Forms.MenuStrip();
            this.maestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeRemeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeRemeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRemeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_menuRemeras.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ms_menuRemeras
            // 
            this.Ms_menuRemeras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ms_menuRemeras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maestrosToolStripMenuItem});
            this.Ms_menuRemeras.Location = new System.Drawing.Point(0, 0);
            this.Ms_menuRemeras.Name = "Ms_menuRemeras";
            this.Ms_menuRemeras.Size = new System.Drawing.Size(800, 29);
            this.Ms_menuRemeras.TabIndex = 1;
            this.Ms_menuRemeras.Text = "menuStrip1";
            // 
            // maestrosToolStripMenuItem
            // 
            this.maestrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeRemeraToolStripMenuItem,
            this.bajaDeRemeraToolStripMenuItem,
            this.editarRemeraToolStripMenuItem});
            this.maestrosToolStripMenuItem.Name = "maestrosToolStripMenuItem";
            this.maestrosToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.maestrosToolStripMenuItem.Text = "Maestros";
            
            // 
            // altaDeRemeraToolStripMenuItem
            // 
            this.altaDeRemeraToolStripMenuItem.Name = "altaDeRemeraToolStripMenuItem";
            this.altaDeRemeraToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.altaDeRemeraToolStripMenuItem.Text = "Alta de Remera";
            this.altaDeRemeraToolStripMenuItem.Click += new System.EventHandler(this.altaDeRemeraToolStripMenuItem_Click);
            // 
            // bajaDeRemeraToolStripMenuItem
            // 
            this.bajaDeRemeraToolStripMenuItem.Name = "bajaDeRemeraToolStripMenuItem";
            this.bajaDeRemeraToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.bajaDeRemeraToolStripMenuItem.Text = "Baja de Remera";
            this.bajaDeRemeraToolStripMenuItem.Click += new System.EventHandler(this.bajaDeRemeraToolStripMenuItem_Click);
            // 
            // editarRemeraToolStripMenuItem
            // 
            this.editarRemeraToolStripMenuItem.Name = "editarRemeraToolStripMenuItem";
            this.editarRemeraToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.editarRemeraToolStripMenuItem.Text = "Editar Remera";
            this.editarRemeraToolStripMenuItem.Click += new System.EventHandler(this.editarRemeraToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ms_menuRemeras);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Ms_menuRemeras;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Ms_menuRemeras.ResumeLayout(false);
            this.Ms_menuRemeras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Ms_menuRemeras;
        private System.Windows.Forms.ToolStripMenuItem maestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeRemeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeRemeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarRemeraToolStripMenuItem;
    }
}

