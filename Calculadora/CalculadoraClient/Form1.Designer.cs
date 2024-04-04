namespace CalculadoraClient
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNumA = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelNumB = new System.Windows.Forms.Label();
            this.textBoxNumA = new System.Windows.Forms.TextBox();
            this.textBoxNumB = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 26);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(299, 42);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "CALCULADORA";
            // 
            // labelNumA
            // 
            this.labelNumA.AutoSize = true;
            this.labelNumA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumA.Location = new System.Drawing.Point(49, 122);
            this.labelNumA.Name = "labelNumA";
            this.labelNumA.Size = new System.Drawing.Size(119, 25);
            this.labelNumA.TabIndex = 1;
            this.labelNumA.Text = "Numero A: ";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelResultado.Location = new System.Drawing.Point(25, 329);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(249, 44);
            this.labelResultado.TabIndex = 2;
            this.labelResultado.Text = "RESULTADO";
            // 
            // labelNumB
            // 
            this.labelNumB.AutoSize = true;
            this.labelNumB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumB.Location = new System.Drawing.Point(49, 185);
            this.labelNumB.Name = "labelNumB";
            this.labelNumB.Size = new System.Drawing.Size(119, 25);
            this.labelNumB.TabIndex = 6;
            this.labelNumB.Text = "Numero B: ";
            // 
            // textBoxNumA
            // 
            this.textBoxNumA.Location = new System.Drawing.Point(174, 122);
            this.textBoxNumA.Name = "textBoxNumA";
            this.textBoxNumA.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumA.TabIndex = 7;
            // 
            // textBoxNumB
            // 
            this.textBoxNumB.Location = new System.Drawing.Point(174, 185);
            this.textBoxNumB.Name = "textBoxNumB";
            this.textBoxNumB.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumB.TabIndex = 8;
            // 
            // btnSumar
            // 
            this.btnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.Location = new System.Drawing.Point(54, 231);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(220, 65);
            this.btnSumar.TabIndex = 9;
            this.btnSumar.Text = "SUMAR";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(340, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 385);
            this.dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Historial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.textBoxNumB);
            this.Controls.Add(this.textBoxNumA);
            this.Controls.Add(this.labelNumB);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelNumA);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNumA;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelNumB;
        private System.Windows.Forms.TextBox textBoxNumA;
        private System.Windows.Forms.TextBox textBoxNumB;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}

