namespace WindowForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            labelNumeroA = new Label();
            labelNumeroB = new Label();
            labelResultado = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnSuma = new Button();
            dataGridHistorial = new DataGridView();
            NumeroA = new DataGridViewTextBoxColumn();
            NumeroB = new DataGridViewTextBoxColumn();
            Resultado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridHistorial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(230, 54);
            label1.TabIndex = 0;
            label1.Text = "Calculadora";
            // 
            // labelNumeroA
            // 
            labelNumeroA.AutoSize = true;
            labelNumeroA.Font = new Font("Segoe UI", 15F);
            labelNumeroA.Location = new Point(33, 141);
            labelNumeroA.Name = "labelNumeroA";
            labelNumeroA.Size = new Size(102, 28);
            labelNumeroA.TabIndex = 1;
            labelNumeroA.Text = "Numero A";
            // 
            // labelNumeroB
            // 
            labelNumeroB.AutoSize = true;
            labelNumeroB.Font = new Font("Segoe UI", 15F);
            labelNumeroB.Location = new Point(33, 216);
            labelNumeroB.Name = "labelNumeroB";
            labelNumeroB.Size = new Size(100, 28);
            labelNumeroB.TabIndex = 2;
            labelNumeroB.Text = "Numero B";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 35F);
            labelResultado.Location = new Point(33, 296);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(275, 62);
            labelResultado.TabIndex = 3;
            labelResultado.Text = "RESULTADO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 221);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Segoe UI", 20F);
            btnSuma.Location = new Point(279, 172);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(129, 49);
            btnSuma.TabIndex = 6;
            btnSuma.Text = "Sumar";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // dataGridHistorial
            // 
            dataGridHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHistorial.Columns.AddRange(new DataGridViewColumn[] { NumeroA, NumeroB, Resultado });
            dataGridHistorial.Location = new Point(443, 12);
            dataGridHistorial.Name = "dataGridHistorial";
            dataGridHistorial.Size = new Size(345, 411);
            dataGridHistorial.TabIndex = 7;
            // 
            // NumeroA
            // 
            NumeroA.HeaderText = "NumeroA";
            NumeroA.Name = "NumeroA";
            // 
            // NumeroB
            // 
            NumeroB.HeaderText = "NumeroB";
            NumeroB.Name = "NumeroB";
            // 
            // Resultado
            // 
            Resultado.HeaderText = "Resultado";
            Resultado.Name = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridHistorial);
            Controls.Add(btnSuma);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelResultado);
            Controls.Add(labelNumeroB);
            Controls.Add(labelNumeroA);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelNumeroA;
        private Label labelNumeroB;
        private Label labelResultado;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnSuma;
        private DataGridView dataGridHistorial;
        private DataGridViewTextBoxColumn NumeroA;
        private DataGridViewTextBoxColumn NumeroB;
        private DataGridViewTextBoxColumn Resultado;
    }
}
