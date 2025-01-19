namespace LivroCaixa
{
    partial class frmFluxoCaixa
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
            this.lbFluxoDeCaixa = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.txData = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.txDescricao = new System.Windows.Forms.TextBox();
            this.lbData = new System.Windows.Forms.Label();
            this.cbResponsavel = new System.Windows.Forms.ComboBox();
            this.lbResponsavel = new System.Windows.Forms.Label();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.rbDebito = new System.Windows.Forms.RadioButton();
            this.lbValor = new System.Windows.Forms.Label();
            this.txValor = new System.Windows.Forms.TextBox();
            this.brOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFluxoDeCaixa
            // 
            this.lbFluxoDeCaixa.AutoSize = true;
            this.lbFluxoDeCaixa.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFluxoDeCaixa.Location = new System.Drawing.Point(265, 9);
            this.lbFluxoDeCaixa.Name = "lbFluxoDeCaixa";
            this.lbFluxoDeCaixa.Size = new System.Drawing.Size(203, 37);
            this.lbFluxoDeCaixa.TabIndex = 0;
            this.lbFluxoDeCaixa.Text = "Fluxo de Caixa";
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(713, 12);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 1;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // txData
            // 
            this.txData.Location = new System.Drawing.Point(26, 89);
            this.txData.Name = "txData";
            this.txData.Size = new System.Drawing.Size(65, 23);
            this.txData.TabIndex = 3;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDescricao.Location = new System.Drawing.Point(106, 72);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(71, 15);
            this.lbDescricao.TabIndex = 4;
            this.lbDescricao.Text = "Descrição";
            // 
            // txDescricao
            // 
            this.txDescricao.Location = new System.Drawing.Point(106, 90);
            this.txDescricao.Name = "txDescricao";
            this.txDescricao.Size = new System.Drawing.Size(284, 23);
            this.txDescricao.TabIndex = 5;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbData.Location = new System.Drawing.Point(26, 72);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(37, 15);
            this.lbData.TabIndex = 6;
            this.lbData.Text = "Data";
            // 
            // cbResponsavel
            // 
            this.cbResponsavel.DisplayMember = " pedro";
            this.cbResponsavel.FormattingEnabled = true;
            this.cbResponsavel.Location = new System.Drawing.Point(396, 90);
            this.cbResponsavel.Name = "cbResponsavel";
            this.cbResponsavel.Size = new System.Drawing.Size(121, 23);
            this.cbResponsavel.TabIndex = 7;
            // 
            // lbResponsavel
            // 
            this.lbResponsavel.AutoSize = true;
            this.lbResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbResponsavel.Location = new System.Drawing.Point(396, 72);
            this.lbResponsavel.Name = "lbResponsavel";
            this.lbResponsavel.Size = new System.Drawing.Size(89, 15);
            this.lbResponsavel.TabIndex = 8;
            this.lbResponsavel.Text = "Responsavel";
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCredito.Location = new System.Drawing.Point(532, 89);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(71, 19);
            this.rbCredito.TabIndex = 9;
            this.rbCredito.TabStop = true;
            this.rbCredito.Text = "Credito";
            this.rbCredito.UseVisualStyleBackColor = true;
            // 
            // rbDebito
            // 
            this.rbDebito.AutoSize = true;
            this.rbDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbDebito.Location = new System.Drawing.Point(532, 114);
            this.rbDebito.Name = "rbDebito";
            this.rbDebito.Size = new System.Drawing.Size(67, 19);
            this.rbDebito.TabIndex = 10;
            this.rbDebito.TabStop = true;
            this.rbDebito.Text = "Debito";
            this.rbDebito.UseVisualStyleBackColor = true;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(609, 73);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(33, 15);
            this.lbValor.TabIndex = 11;
            this.lbValor.Text = "Valor";
            // 
            // tbValor
            // 
            this.txValor.Location = new System.Drawing.Point(609, 91);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(80, 23);
            this.txValor.TabIndex = 12;
            // 
            // brOk
            // 
            this.brOk.Location = new System.Drawing.Point(713, 91);
            this.brOk.Name = "brOk";
            this.brOk.Size = new System.Drawing.Size(75, 23);
            this.brOk.TabIndex = 13;
            this.brOk.Text = "OK";
            this.brOk.UseVisualStyleBackColor = true;
            this.brOk.Click += new System.EventHandler(this.brOk_Click);
            // 
            // frmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brOk);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.rbDebito);
            this.Controls.Add(this.rbCredito);
            this.Controls.Add(this.lbResponsavel);
            this.Controls.Add(this.cbResponsavel);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.txDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.txData);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.lbFluxoDeCaixa);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "frmFluxoCaixa";
            this.Text = "Fluxo de Caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbFluxoDeCaixa;
        private Button btSair;
        private TextBox txData;
        private Label lbDescricao;
        private TextBox txDescricao;
        private Label lbData;
        private ComboBox cbResponsavel;
        private Label lbResponsavel;
        private RadioButton rbCredito;
        private RadioButton rbDebito;
        private Label lbValor;
        private TextBox txValor;
        private Button brOk;
    }
}