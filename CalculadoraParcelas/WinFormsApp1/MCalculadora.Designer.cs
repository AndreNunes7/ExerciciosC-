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
            this.lblParcela1 = new System.Windows.Forms.Label();
            this.lblParcela2 = new System.Windows.Forms.Label();
            this.txParcela1 = new System.Windows.Forms.TextBox();
            this.txParcela2 = new System.Windows.Forms.TextBox();
            this.btMais = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btDivisao = new System.Windows.Forms.Button();
            this.btMenos = new System.Windows.Forms.Button();
            this.btVezes = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblParcela1
            // 
            this.lblParcela1.AutoSize = true;
            this.lblParcela1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblParcela1.Location = new System.Drawing.Point(21, 34);
            this.lblParcela1.Name = "lblParcela1";
            this.lblParcela1.Size = new System.Drawing.Size(124, 32);
            this.lblParcela1.TabIndex = 0;
            this.lblParcela1.Text = "Parcela 1:";
            // 
            // lblParcela2
            // 
            this.lblParcela2.AutoSize = true;
            this.lblParcela2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblParcela2.Location = new System.Drawing.Point(21, 123);
            this.lblParcela2.Name = "lblParcela2";
            this.lblParcela2.Size = new System.Drawing.Size(124, 32);
            this.lblParcela2.TabIndex = 1;
            this.lblParcela2.Text = "Parcela 2:";
            // 
            // txParcela1
            // 
            this.txParcela1.Location = new System.Drawing.Point(178, 45);
            this.txParcela1.Name = "txParcela1";
            this.txParcela1.Size = new System.Drawing.Size(100, 23);
            this.txParcela1.TabIndex = 2;
            // 
            // txParcela2
            // 
            this.txParcela2.Location = new System.Drawing.Point(163, 134);
            this.txParcela2.Name = "txParcela2";
            this.txParcela2.Size = new System.Drawing.Size(100, 23);
            this.txParcela2.TabIndex = 3;
            // 
            // btMais
            // 
            this.btMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btMais.ForeColor = System.Drawing.Color.Red;
            this.btMais.Location = new System.Drawing.Point(35, 179);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(40, 34);
            this.btMais.TabIndex = 5;
            this.btMais.Text = "+";
            this.btMais.UseVisualStyleBackColor = true;
            this.btMais.Click += new System.EventHandler(this.btMais_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btClear.ForeColor = System.Drawing.Color.Red;
            this.btClear.Location = new System.Drawing.Point(278, 179);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(40, 34);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "C";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btDivisao
            // 
            this.btDivisao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDivisao.ForeColor = System.Drawing.Color.Red;
            this.btDivisao.Location = new System.Drawing.Point(213, 179);
            this.btDivisao.Name = "btDivisao";
            this.btDivisao.Size = new System.Drawing.Size(40, 34);
            this.btDivisao.TabIndex = 8;
            this.btDivisao.Text = "/";
            this.btDivisao.UseVisualStyleBackColor = true;
            this.btDivisao.Click += new System.EventHandler(this.btDivisao_Click);
            // 
            // btMenos
            // 
            this.btMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btMenos.ForeColor = System.Drawing.Color.Red;
            this.btMenos.Location = new System.Drawing.Point(95, 179);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(40, 34);
            this.btMenos.TabIndex = 10;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = true;
            this.btMenos.Click += new System.EventHandler(this.btMenos_Click);
            // 
            // btVezes
            // 
            this.btVezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btVezes.ForeColor = System.Drawing.Color.Red;
            this.btVezes.Location = new System.Drawing.Point(157, 179);
            this.btVezes.Name = "btVezes";
            this.btVezes.Size = new System.Drawing.Size(40, 34);
            this.btVezes.TabIndex = 11;
            this.btVezes.Text = "*";
            this.btVezes.UseVisualStyleBackColor = true;
            this.btVezes.Click += new System.EventHandler(this.btVezes_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(62, 262);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(59, 15);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "Resultado";
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 305);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btVezes);
            this.Controls.Add(this.btMenos);
            this.Controls.Add(this.btDivisao);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btMais);
            this.Controls.Add(this.txParcela2);
            this.Controls.Add(this.txParcela1);
            this.Controls.Add(this.lblParcela2);
            this.Controls.Add(this.lblParcela1);
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

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