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
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxDetalle = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.btnGuardarArticulo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelDetalle = new System.Windows.Forms.Label();
            this.labelTotalCarrito = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.btnSumarCarrito = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(18, 76);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(53, 21);
            this.labelPrecio.TabIndex = 1;
            this.labelPrecio.Text = "Precio";
            // 
            // textBoxDetalle
            // 
            this.textBoxDetalle.Location = new System.Drawing.Point(77, 29);
            this.textBoxDetalle.Name = "textBoxDetalle";
            this.textBoxDetalle.Size = new System.Drawing.Size(100, 20);
            this.textBoxDetalle.TabIndex = 2;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(77, 77);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 3;
            // 
            // btnGuardarArticulo
            // 
            this.btnGuardarArticulo.Location = new System.Drawing.Point(22, 127);
            this.btnGuardarArticulo.Name = "btnGuardarArticulo";
            this.btnGuardarArticulo.Size = new System.Drawing.Size(155, 44);
            this.btnGuardarArticulo.TabIndex = 4;
            this.btnGuardarArticulo.Text = "Guardar";
            this.btnGuardarArticulo.UseVisualStyleBackColor = true;
            this.btnGuardarArticulo.Click += new System.EventHandler(this.btnGuardarArticulo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(209, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 426);
            this.dataGridView1.TabIndex = 5;
            // 
            // labelDetalle
            // 
            this.labelDetalle.AutoSize = true;
            this.labelDetalle.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalle.Location = new System.Drawing.Point(18, 29);
            this.labelDetalle.Name = "labelDetalle";
            this.labelDetalle.Size = new System.Drawing.Size(55, 21);
            this.labelDetalle.TabIndex = 6;
            this.labelDetalle.Text = "Detalle";
            // 
            // labelTotalCarrito
            // 
            this.labelTotalCarrito.AutoSize = true;
            this.labelTotalCarrito.Font = new System.Drawing.Font("Segoe Fluent Icons", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCarrito.Location = new System.Drawing.Point(582, 50);
            this.labelTotalCarrito.Name = "labelTotalCarrito";
            this.labelTotalCarrito.Size = new System.Drawing.Size(181, 64);
            this.labelTotalCarrito.TabIndex = 7;
            this.labelTotalCarrito.Text = "TOTAL";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(623, 157);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 9;
            // 
            // btnSumarCarrito
            // 
            this.btnSumarCarrito.Location = new System.Drawing.Point(597, 191);
            this.btnSumarCarrito.Name = "btnSumarCarrito";
            this.btnSumarCarrito.Size = new System.Drawing.Size(126, 46);
            this.btnSumarCarrito.TabIndex = 10;
            this.btnSumarCarrito.Text = "Sumar";
            this.btnSumarCarrito.UseVisualStyleBackColor = true;
            this.btnSumarCarrito.Click += new System.EventHandler(this.btnSumarCarrito_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(591, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "id ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSumarCarrito);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelTotalCarrito);
            this.Controls.Add(this.labelDetalle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuardarArticulo);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxDetalle);
            this.Controls.Add(this.labelPrecio);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxDetalle;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Button btnGuardarArticulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelDetalle;
        private System.Windows.Forms.Label labelTotalCarrito;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button btnSumarCarrito;
        private System.Windows.Forms.Label label2;
    }
}

