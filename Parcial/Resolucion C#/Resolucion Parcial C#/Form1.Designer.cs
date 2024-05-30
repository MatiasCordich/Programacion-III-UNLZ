namespace Resolucion_Parcial_C_
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtGrid_Pinturas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Litros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AgregarPintura = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_totalRojo = new System.Windows.Forms.Label();
            this.lbl_promedioAzul = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Pinturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "PINTURIQUIO";
            // 
            // dtGrid_Pinturas
            // 
            this.dtGrid_Pinturas.AllowUserToAddRows = false;
            this.dtGrid_Pinturas.AllowUserToDeleteRows = false;
            this.dtGrid_Pinturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_Pinturas.Location = new System.Drawing.Point(12, 74);
            this.dtGrid_Pinturas.Name = "dtGrid_Pinturas";
            this.dtGrid_Pinturas.ReadOnly = true;
            this.dtGrid_Pinturas.Size = new System.Drawing.Size(370, 364);
            this.dtGrid_Pinturas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CODIGO";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(401, 97);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(360, 20);
            this.txt_Codigo.TabIndex = 3;
            // 
            // txt_Color
            // 
            this.txt_Color.Location = new System.Drawing.Point(401, 152);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(360, 20);
            this.txt_Color.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "COLOR";
            // 
            // txt_Litros
            // 
            this.txt_Litros.Location = new System.Drawing.Point(401, 208);
            this.txt_Litros.Name = "txt_Litros";
            this.txt_Litros.Size = new System.Drawing.Size(360, 20);
            this.txt_Litros.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "LITROS";
            // 
            // btn_AgregarPintura
            // 
            this.btn_AgregarPintura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarPintura.Location = new System.Drawing.Point(487, 243);
            this.btn_AgregarPintura.Name = "btn_AgregarPintura";
            this.btn_AgregarPintura.Size = new System.Drawing.Size(195, 48);
            this.btn_AgregarPintura.TabIndex = 8;
            this.btn_AgregarPintura.Text = "Agregar pintura";
            this.btn_AgregarPintura.UseVisualStyleBackColor = true;
            this.btn_AgregarPintura.Click += new System.EventHandler(this.btn_AgregarPintura_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total litros pintura ROJO:";
            // 
            // lbl_totalRojo
            // 
            this.lbl_totalRojo.AutoSize = true;
            this.lbl_totalRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalRojo.Location = new System.Drawing.Point(621, 316);
            this.lbl_totalRojo.Name = "lbl_totalRojo";
            this.lbl_totalRojo.Size = new System.Drawing.Size(20, 24);
            this.lbl_totalRojo.TabIndex = 10;
            this.lbl_totalRojo.Text = "0";
            // 
            // lbl_promedioAzul
            // 
            this.lbl_promedioAzul.AutoSize = true;
            this.lbl_promedioAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_promedioAzul.Location = new System.Drawing.Point(662, 350);
            this.lbl_promedioAzul.Name = "lbl_promedioAzul";
            this.lbl_promedioAzul.Size = new System.Drawing.Size(20, 24);
            this.lbl_promedioAzul.TabIndex = 12;
            this.lbl_promedioAzul.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(397, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Promedio litros pintura AZUL:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_promedioAzul);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_totalRojo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_AgregarPintura);
            this.Controls.Add(this.txt_Litros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Color);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtGrid_Pinturas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Pinturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGrid_Pinturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Litros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_AgregarPintura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_totalRojo;
        private System.Windows.Forms.Label lbl_promedioAzul;
        private System.Windows.Forms.Label label8;
    }
}

