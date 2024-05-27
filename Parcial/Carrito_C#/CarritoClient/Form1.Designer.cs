namespace CarritoClient
{
    partial class Form1
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
            this.label_descripcion = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.btn_GuardarProducto = new System.Windows.Forms.Button();
            this.data_grid_Articulos = new System.Windows.Forms.DataGridView();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_totalR = new System.Windows.Forms.Label();
            this.label_txt_total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_PromedioR_Title = new System.Windows.Forms.Label();
            this.lbl_Promedio_Title = new System.Windows.Forms.Label();
            this.lbl_PromedioR = new System.Windows.Forms.Label();
            this.lbl_Promedio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_Articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descripcion.Location = new System.Drawing.Point(12, 58);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(110, 24);
            this.label_descripcion.TabIndex = 0;
            this.label_descripcion.Text = "Descripcion";
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_precio.Location = new System.Drawing.Point(12, 105);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(64, 24);
            this.label_precio.TabIndex = 1;
            this.label_precio.Text = "Precio";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(128, 63);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(100, 20);
            this.txt_descripcion.TabIndex = 2;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(128, 105);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 3;
            // 
            // btn_GuardarProducto
            // 
            this.btn_GuardarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarProducto.Location = new System.Drawing.Point(64, 180);
            this.btn_GuardarProducto.Name = "btn_GuardarProducto";
            this.btn_GuardarProducto.Size = new System.Drawing.Size(140, 52);
            this.btn_GuardarProducto.TabIndex = 4;
            this.btn_GuardarProducto.Text = "Guardar";
            this.btn_GuardarProducto.UseVisualStyleBackColor = true;
            this.btn_GuardarProducto.Click += new System.EventHandler(this.btn_GuardarProducto_Click);
            // 
            // data_grid_Articulos
            // 
            this.data_grid_Articulos.AllowUserToAddRows = false;
            this.data_grid_Articulos.AllowUserToDeleteRows = false;
            this.data_grid_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_Articulos.Location = new System.Drawing.Point(264, 28);
            this.data_grid_Articulos.Name = "data_grid_Articulos";
            this.data_grid_Articulos.ReadOnly = true;
            this.data_grid_Articulos.Size = new System.Drawing.Size(524, 253);
            this.data_grid_Articulos.TabIndex = 5;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(239, 335);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(24, 25);
            this.lbl_Total.TabIndex = 6;
            this.lbl_Total.Text = "0";
            // 
            // lbl_totalR
            // 
            this.lbl_totalR.AutoSize = true;
            this.lbl_totalR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalR.Location = new System.Drawing.Point(259, 374);
            this.lbl_totalR.Name = "lbl_totalR";
            this.lbl_totalR.Size = new System.Drawing.Size(24, 25);
            this.lbl_totalR.TabIndex = 7;
            this.lbl_totalR.Text = "0";
            // 
            // label_txt_total
            // 
            this.label_txt_total.AutoSize = true;
            this.label_txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_txt_total.Location = new System.Drawing.Point(3, 335);
            this.label_txt_total.Name = "label_txt_total";
            this.label_txt_total.Size = new System.Drawing.Size(161, 25);
            this.label_txt_total.TabIndex = 8;
            this.label_txt_total.Text = "Total productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Productos con R";
            // 
            // lbl_PromedioR_Title
            // 
            this.lbl_PromedioR_Title.AutoSize = true;
            this.lbl_PromedioR_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PromedioR_Title.Location = new System.Drawing.Point(431, 374);
            this.lbl_PromedioR_Title.Name = "lbl_PromedioR_Title";
            this.lbl_PromedioR_Title.Size = new System.Drawing.Size(165, 25);
            this.lbl_PromedioR_Title.TabIndex = 13;
            this.lbl_PromedioR_Title.Text = "Promedio con R";
            // 
            // lbl_Promedio_Title
            // 
            this.lbl_Promedio_Title.AutoSize = true;
            this.lbl_Promedio_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Promedio_Title.Location = new System.Drawing.Point(431, 335);
            this.lbl_Promedio_Title.Name = "lbl_Promedio_Title";
            this.lbl_Promedio_Title.Size = new System.Drawing.Size(103, 25);
            this.lbl_Promedio_Title.TabIndex = 12;
            this.lbl_Promedio_Title.Text = "Promedio";
            // 
            // lbl_PromedioR
            // 
            this.lbl_PromedioR.AutoSize = true;
            this.lbl_PromedioR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PromedioR.Location = new System.Drawing.Point(687, 374);
            this.lbl_PromedioR.Name = "lbl_PromedioR";
            this.lbl_PromedioR.Size = new System.Drawing.Size(24, 25);
            this.lbl_PromedioR.TabIndex = 11;
            this.lbl_PromedioR.Text = "0";
            // 
            // lbl_Promedio
            // 
            this.lbl_Promedio.AutoSize = true;
            this.lbl_Promedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Promedio.Location = new System.Drawing.Point(667, 335);
            this.lbl_Promedio.Name = "lbl_Promedio";
            this.lbl_Promedio.Size = new System.Drawing.Size(24, 25);
            this.lbl_Promedio.TabIndex = 10;
            this.lbl_Promedio.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_PromedioR_Title);
            this.Controls.Add(this.lbl_Promedio_Title);
            this.Controls.Add(this.lbl_PromedioR);
            this.Controls.Add(this.lbl_Promedio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_txt_total);
            this.Controls.Add(this.lbl_totalR);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.data_grid_Articulos);
            this.Controls.Add(this.btn_GuardarProducto);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.label_descripcion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_Articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Button btn_GuardarProducto;
        private System.Windows.Forms.DataGridView data_grid_Articulos;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_totalR;
        private System.Windows.Forms.Label label_txt_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_PromedioR_Title;
        private System.Windows.Forms.Label lbl_Promedio_Title;
        private System.Windows.Forms.Label lbl_PromedioR;
        private System.Windows.Forms.Label lbl_Promedio;
    }
}

