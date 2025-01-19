namespace WinFormsApp1
{
    partial class FrmCalculadora
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
            lblParcela1 = new Label();
            lblParcela2 = new Label();
            txParcela1 = new TextBox();
            txParcela2 = new TextBox();
            btMais = new Button();
            btClear = new Button();
            btDivisao = new Button();
            btMenos = new Button();
            btVezes = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblParcela1
            // 
            lblParcela1.AutoSize = true;
            lblParcela1.BackColor = Color.Transparent;
            lblParcela1.Cursor = Cursors.Cross;
            lblParcela1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblParcela1.ForeColor = Color.Black;
            lblParcela1.Location = new Point(21, 34);
            lblParcela1.Name = "lblParcela1";
            lblParcela1.Size = new Size(124, 32);
            lblParcela1.TabIndex = 0;
            lblParcela1.Text = "Parcela 1:";
            // 
            // lblParcela2
            // 
            lblParcela2.AutoSize = true;
            lblParcela2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblParcela2.ForeColor = SystemColors.ControlText;
            lblParcela2.Location = new Point(21, 123);
            lblParcela2.Name = "lblParcela2";
            lblParcela2.Size = new Size(124, 32);
            lblParcela2.TabIndex = 1;
            lblParcela2.Text = "Parcela 2:";
            // 
            // txParcela1
            // 
            txParcela1.Location = new Point(178, 45);
            txParcela1.Name = "txParcela1";
            txParcela1.Size = new Size(100, 23);
            txParcela1.TabIndex = 2;
            // 
            // txParcela2
            // 
            txParcela2.Location = new Point(163, 134);
            txParcela2.Name = "txParcela2";
            txParcela2.Size = new Size(100, 23);
            txParcela2.TabIndex = 3;
            // 
            // btMais
            // 
            btMais.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btMais.ForeColor = Color.Red;
            btMais.Location = new Point(35, 179);
            btMais.Name = "btMais";
            btMais.Size = new Size(40, 34);
            btMais.TabIndex = 5;
            btMais.Text = "+";
            btMais.UseVisualStyleBackColor = true;
            btMais.Click += btMais_Click;
            // 
            // btClear
            // 
            btClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btClear.ForeColor = Color.Red;
            btClear.Location = new Point(278, 179);
            btClear.Name = "btClear";
            btClear.Size = new Size(40, 34);
            btClear.TabIndex = 7;
            btClear.Text = "C";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btDivisao
            // 
            btDivisao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btDivisao.ForeColor = Color.Red;
            btDivisao.Location = new Point(213, 179);
            btDivisao.Name = "btDivisao";
            btDivisao.Size = new Size(40, 34);
            btDivisao.TabIndex = 8;
            btDivisao.Text = "/";
            btDivisao.UseVisualStyleBackColor = true;
            btDivisao.Click += btDivisao_Click;
            // 
            // btMenos
            // 
            btMenos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btMenos.ForeColor = Color.Red;
            btMenos.Location = new Point(95, 179);
            btMenos.Name = "btMenos";
            btMenos.Size = new Size(40, 34);
            btMenos.TabIndex = 10;
            btMenos.Text = "-";
            btMenos.UseVisualStyleBackColor = true;
            btMenos.Click += btMenos_Click;
            // 
            // btVezes
            // 
            btVezes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btVezes.ForeColor = Color.Red;
            btVezes.Location = new Point(157, 179);
            btVezes.Name = "btVezes";
            btVezes.Size = new Size(40, 34);
            btVezes.TabIndex = 11;
            btVezes.Text = "*";
            btVezes.UseVisualStyleBackColor = true;
            btVezes.Click += btVezes_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(62, 262);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 12;
            lblResultado.Text = "Resultado";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 305);
            Controls.Add(lblResultado);
            Controls.Add(btVezes);
            Controls.Add(btMenos);
            Controls.Add(btDivisao);
            Controls.Add(btClear);
            Controls.Add(btMais);
            Controls.Add(txParcela2);
            Controls.Add(txParcela1);
            Controls.Add(lblParcela2);
            Controls.Add(lblParcela1);
            Name = "FrmCalculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblParcela1;
        private Label lblParcela2;
        private TextBox txParcela1;
        private TextBox txParcela2;
        private Button btMais;
        private Button btClear;
        private Button btDivisao;
        private Button btMenos;
        private Button btVezes;
        private Label lblResultado;
    }
}