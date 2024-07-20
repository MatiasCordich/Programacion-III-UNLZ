namespace ABM_Remeras.Formularios
{
    partial class FormBajaRemera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gb_altaRemera = new System.Windows.Forms.GroupBox();
            this.Btn_bajaRemera = new System.Windows.Forms.Button();
            this.Txt_codigoBaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_listaRemeras = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_descripcionCantidad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_descripcionPromedio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Gb_altaRemera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_listaRemeras)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_altaRemera
            // 
            this.Gb_altaRemera.Controls.Add(this.Btn_bajaRemera);
            this.Gb_altaRemera.Controls.Add(this.Txt_codigoBaja);
            this.Gb_altaRemera.Controls.Add(this.label1);
            this.Gb_altaRemera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_altaRemera.Location = new System.Drawing.Point(12, 51);
            this.Gb_altaRemera.Name = "Gb_altaRemera";
            this.Gb_altaRemera.Size = new System.Drawing.Size(356, 202);
            this.Gb_altaRemera.TabIndex = 3;
            this.Gb_altaRemera.TabStop = false;
            this.Gb_altaRemera.Text = "Baja Remera";
            // 
            // Btn_bajaRemera
            // 
            this.Btn_bajaRemera.Location = new System.Drawing.Point(16, 110);
            this.Btn_bajaRemera.Name = "Btn_bajaRemera";
            this.Btn_bajaRemera.Size = new System.Drawing.Size(271, 59);
            this.Btn_bajaRemera.TabIndex = 8;
            this.Btn_bajaRemera.Text = "Eliminar";
            this.Btn_bajaRemera.UseVisualStyleBackColor = true;
            this.Btn_bajaRemera.Click += new System.EventHandler(this.Btn_bajaRemera_Click);
            // 
            // Txt_codigoBaja
            // 
            this.Txt_codigoBaja.Location = new System.Drawing.Point(106, 60);
            this.Txt_codigoBaja.Name = "Txt_codigoBaja";
            this.Txt_codigoBaja.Size = new System.Drawing.Size(151, 29);
            this.Txt_codigoBaja.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // Dgv_listaRemeras
            // 
            this.Dgv_listaRemeras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_listaRemeras.Location = new System.Drawing.Point(388, 12);
            this.Dgv_listaRemeras.Name = "Dgv_listaRemeras";
            this.Dgv_listaRemeras.Size = new System.Drawing.Size(400, 426);
            this.Dgv_listaRemeras.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_descripcionCantidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Lbl_descripcionPromedio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 143);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion";
            // 
            // Lbl_descripcionCantidad
            // 
            this.Lbl_descripcionCantidad.AutoSize = true;
            this.Lbl_descripcionCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcionCantidad.ForeColor = System.Drawing.Color.SeaGreen;
            this.Lbl_descripcionCantidad.Location = new System.Drawing.Point(175, 91);
            this.Lbl_descripcionCantidad.Name = "Lbl_descripcionCantidad";
            this.Lbl_descripcionCantidad.Size = new System.Drawing.Size(0, 20);
            this.Lbl_descripcionCantidad.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cantidad talle XL:";
            // 
            // Lbl_descripcionPromedio
            // 
            this.Lbl_descripcionPromedio.AutoSize = true;
            this.Lbl_descripcionPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcionPromedio.ForeColor = System.Drawing.Color.SeaGreen;
            this.Lbl_descripcionPromedio.Location = new System.Drawing.Point(209, 38);
            this.Lbl_descripcionPromedio.Name = "Lbl_descripcionPromedio";
            this.Lbl_descripcionPromedio.Size = new System.Drawing.Size(0, 20);
            this.Lbl_descripcionPromedio.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Precio promedio talle L:";
            // 
            // FormBajaRemera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dgv_listaRemeras);
            this.Controls.Add(this.Gb_altaRemera);
            this.Name = "FormBajaRemera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja Remera";
            this.Load += new System.EventHandler(this.FormBajaRemera_Load);
            this.Gb_altaRemera.ResumeLayout(false);
            this.Gb_altaRemera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_listaRemeras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_altaRemera;
        private System.Windows.Forms.Button Btn_bajaRemera;
        private System.Windows.Forms.TextBox Txt_codigoBaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_listaRemeras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_descripcionCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl_descripcionPromedio;
        private System.Windows.Forms.Label label5;
    }
}