namespace ABM_Remeras.Formularios
{
    partial class FormAltaRemeras
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
            this.Dgv_listaRemeras = new System.Windows.Forms.DataGridView();
            this.Gb_altaRemera = new System.Windows.Forms.GroupBox();
            this.Btn_altaRemera = new System.Windows.Forms.Button();
            this.Cb_talleAlta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_precioAlta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_detalleAlta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_codigoAlta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_descripcionCantidad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_descripcionPromedio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_listaRemeras)).BeginInit();
            this.Gb_altaRemera.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_listaRemeras
            // 
            this.Dgv_listaRemeras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_listaRemeras.Location = new System.Drawing.Point(374, 12);
            this.Dgv_listaRemeras.Name = "Dgv_listaRemeras";
            this.Dgv_listaRemeras.Size = new System.Drawing.Size(414, 485);
            this.Dgv_listaRemeras.TabIndex = 0;
            // 
            // Gb_altaRemera
            // 
            this.Gb_altaRemera.Controls.Add(this.Btn_altaRemera);
            this.Gb_altaRemera.Controls.Add(this.Cb_talleAlta);
            this.Gb_altaRemera.Controls.Add(this.label4);
            this.Gb_altaRemera.Controls.Add(this.Txt_precioAlta);
            this.Gb_altaRemera.Controls.Add(this.label3);
            this.Gb_altaRemera.Controls.Add(this.Txt_detalleAlta);
            this.Gb_altaRemera.Controls.Add(this.label2);
            this.Gb_altaRemera.Controls.Add(this.Txt_codigoAlta);
            this.Gb_altaRemera.Controls.Add(this.label1);
            this.Gb_altaRemera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_altaRemera.Location = new System.Drawing.Point(12, 12);
            this.Gb_altaRemera.Name = "Gb_altaRemera";
            this.Gb_altaRemera.Size = new System.Drawing.Size(356, 336);
            this.Gb_altaRemera.TabIndex = 1;
            this.Gb_altaRemera.TabStop = false;
            this.Gb_altaRemera.Text = "Alta remera";
            // 
            // Btn_altaRemera
            // 
            this.Btn_altaRemera.Location = new System.Drawing.Point(36, 260);
            this.Btn_altaRemera.Name = "Btn_altaRemera";
            this.Btn_altaRemera.Size = new System.Drawing.Size(271, 59);
            this.Btn_altaRemera.TabIndex = 8;
            this.Btn_altaRemera.Text = "Agregar";
            this.Btn_altaRemera.UseVisualStyleBackColor = true;
            this.Btn_altaRemera.Click += new System.EventHandler(this.Btn_altaRemera_Click);
            // 
            // Cb_talleAlta
            // 
            this.Cb_talleAlta.FormattingEnabled = true;
            this.Cb_talleAlta.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.Cb_talleAlta.Location = new System.Drawing.Point(109, 209);
            this.Cb_talleAlta.Name = "Cb_talleAlta";
            this.Cb_talleAlta.Size = new System.Drawing.Size(85, 32);
            this.Cb_talleAlta.TabIndex = 7;
            this.Cb_talleAlta.Text = "S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Talle";
            // 
            // Txt_precioAlta
            // 
            this.Txt_precioAlta.Location = new System.Drawing.Point(109, 156);
            this.Txt_precioAlta.Name = "Txt_precioAlta";
            this.Txt_precioAlta.Size = new System.Drawing.Size(151, 29);
            this.Txt_precioAlta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // Txt_detalleAlta
            // 
            this.Txt_detalleAlta.Location = new System.Drawing.Point(109, 101);
            this.Txt_detalleAlta.Name = "Txt_detalleAlta";
            this.Txt_detalleAlta.Size = new System.Drawing.Size(151, 29);
            this.Txt_detalleAlta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detalle";
            // 
            // Txt_codigoAlta
            // 
            this.Txt_codigoAlta.Location = new System.Drawing.Point(109, 42);
            this.Txt_codigoAlta.Name = "Txt_codigoAlta";
            this.Txt_codigoAlta.Size = new System.Drawing.Size(151, 29);
            this.Txt_codigoAlta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_descripcionCantidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Lbl_descripcionPromedio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 143);
            this.groupBox1.TabIndex = 9;
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
            // FormAltaRemeras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gb_altaRemera);
            this.Controls.Add(this.Dgv_listaRemeras);
            this.Name = "FormAltaRemeras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Remera";
            this.Load += new System.EventHandler(this.FormAltaRemeras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_listaRemeras)).EndInit();
            this.Gb_altaRemera.ResumeLayout(false);
            this.Gb_altaRemera.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_listaRemeras;
        private System.Windows.Forms.GroupBox Gb_altaRemera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_precioAlta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_detalleAlta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_codigoAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_altaRemera;
        private System.Windows.Forms.ComboBox Cb_talleAlta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_descripcionPromedio;
        private System.Windows.Forms.Label Lbl_descripcionCantidad;
        private System.Windows.Forms.Label label7;
    }
}