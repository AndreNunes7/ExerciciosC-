namespace prjFluxoCaixa
{
    partial class frmLivroCaixa
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
            lbTitulo = new Label();
            lbData = new Label();
            txData = new TextBox();
            lbDescricao = new Label();
            txDescricao = new TextBox();
            rbCredito = new RadioButton();
            rbDebito = new RadioButton();
            cbResponsavel = new ComboBox();
            lbResponsavel = new Label();
            txValor = new TextBox();
            lbValor = new Label();
            btOK = new Button();
            cbTipoLancamento = new ComboBox();
            lbTipolancamento = new Label();
            tbRelatorio = new DataGridView();
            btCadResponsavel = new Button();
            btCadTipoLancamento = new Button();
            ((System.ComponentModel.ISupportInitialize)tbRelatorio).BeginInit();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = Color.Transparent;
            lbTitulo.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitulo.ForeColor = Color.Red;
            lbTitulo.Location = new Point(344, 18);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(234, 42);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Livro Caixa";
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.BackColor = Color.Transparent;
            lbData.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbData.ForeColor = Color.Red;
            lbData.Location = new Point(51, 127);
            lbData.Name = "lbData";
            lbData.Size = new Size(48, 22);
            lbData.TabIndex = 1;
            lbData.Text = "Data";
            // 
            // txData
            // 
            txData.Location = new Point(51, 148);
            txData.Name = "txData";
            txData.Size = new Size(86, 23);
            txData.TabIndex = 2;
           
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.BackColor = Color.Transparent;
            lbDescricao.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbDescricao.ForeColor = Color.Red;
            lbDescricao.Location = new Point(51, 76);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(88, 22);
            lbDescricao.TabIndex = 3;
            lbDescricao.Text = "Descrição";
            // 
            // txDescricao
            // 
            txDescricao.Location = new Point(51, 101);
            txDescricao.Name = "txDescricao";
            txDescricao.Size = new Size(288, 23);
            txDescricao.TabIndex = 4;
            // 
            // rbCredito
            // 
            rbCredito.AutoSize = true;
            rbCredito.BackColor = Color.Transparent;
            rbCredito.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbCredito.ForeColor = Color.Red;
            rbCredito.Location = new Point(775, 94);
            rbCredito.Name = "rbCredito";
            rbCredito.Size = new Size(89, 26);
            rbCredito.TabIndex = 5;
            rbCredito.TabStop = true;
            rbCredito.Text = "Crédito";
            rbCredito.UseVisualStyleBackColor = false;
            // 
            // rbDebito
            // 
            rbDebito.AutoSize = true;
            rbDebito.BackColor = Color.Transparent;
            rbDebito.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbDebito.ForeColor = Color.Red;
            rbDebito.Location = new Point(775, 123);
            rbDebito.Name = "rbDebito";
            rbDebito.Size = new Size(84, 26);
            rbDebito.TabIndex = 6;
            rbDebito.TabStop = true;
            rbDebito.Text = "Débito";
            rbDebito.UseVisualStyleBackColor = false;
            // 
            // cbResponsavel
            // 
            cbResponsavel.FormattingEnabled = true;
            cbResponsavel.Location = new Point(344, 101);
            cbResponsavel.Name = "cbResponsavel";
            cbResponsavel.Size = new Size(121, 23);
            cbResponsavel.TabIndex = 7;
            // 
            // lbResponsavel
            // 
            lbResponsavel.AutoSize = true;
            lbResponsavel.BackColor = Color.Transparent;
            lbResponsavel.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbResponsavel.ForeColor = Color.Red;
            lbResponsavel.Location = new Point(344, 76);
            lbResponsavel.Name = "lbResponsavel";
            lbResponsavel.Size = new Size(110, 22);
            lbResponsavel.TabIndex = 8;
            lbResponsavel.Text = "Responsável";
            // 
            // txValor
            // 
            txValor.Location = new Point(672, 101);
            txValor.Name = "txValor";
            txValor.Size = new Size(86, 23);
            txValor.TabIndex = 10;
            txValor.TextAlign = HorizontalAlignment.Right;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.BackColor = Color.Transparent;
            lbValor.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbValor.ForeColor = Color.Red;
            lbValor.Location = new Point(672, 76);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(53, 22);
            lbValor.TabIndex = 9;
            lbValor.Text = "Valor";
            // 
            // btOK
            // 
            btOK.BackColor = Color.FromArgb(168, 0, 0);
            btOK.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btOK.ForeColor = Color.Black;
            btOK.Location = new Point(51, 177);
            btOK.Name = "btOK";
            btOK.Size = new Size(883, 42);
            btOK.TabIndex = 11;
            btOK.Text = "Adicionar";
            btOK.UseVisualStyleBackColor = false;
            btOK.Click += btOK_Click;
            // 
            // cbTipoLancamento
            // 
            cbTipoLancamento.FormattingEnabled = true;
            cbTipoLancamento.Location = new Point(488, 101);
            cbTipoLancamento.Name = "cbTipoLancamento";
            cbTipoLancamento.Size = new Size(156, 23);
            cbTipoLancamento.TabIndex = 13;
            // 
            // lbTipolancamento
            // 
            lbTipolancamento.AutoSize = true;
            lbTipolancamento.BackColor = Color.Transparent;
            lbTipolancamento.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTipolancamento.ForeColor = Color.Red;
            lbTipolancamento.Location = new Point(488, 76);
            lbTipolancamento.Name = "lbTipolancamento";
            lbTipolancamento.Size = new Size(150, 22);
            lbTipolancamento.TabIndex = 14;
            lbTipolancamento.Text = "Tipo Lancamento";
            // 
            // tbRelatorio
            // 
            tbRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbRelatorio.Location = new Point(51, 225);
            tbRelatorio.Name = "tbRelatorio";
            tbRelatorio.ReadOnly = true;
            tbRelatorio.RowTemplate.Height = 25;
            tbRelatorio.Size = new Size(883, 256);
            tbRelatorio.TabIndex = 15;
            // 
            // btCadResponsavel
            // 
            btCadResponsavel.Location = new Point(2, 37);
            btCadResponsavel.Name = "btCadResponsavel";
            btCadResponsavel.Size = new Size(150, 23);
            btCadResponsavel.TabIndex = 16;
            btCadResponsavel.Text = "Cadastro de Responsavel";
            btCadResponsavel.UseVisualStyleBackColor = true;
            btCadResponsavel.Click += button1_Click;
            // 
            // btCadTipoLancamento
            // 
            btCadTipoLancamento.BackColor = Color.Transparent;
            btCadTipoLancamento.Location = new Point(2, 8);
            btCadTipoLancamento.Name = "btCadTipoLancamento";
            btCadTipoLancamento.Size = new Size(150, 23);
            btCadTipoLancamento.TabIndex = 17;
            btCadTipoLancamento.Text = "Cadastro de Tipo";
            btCadTipoLancamento.UseVisualStyleBackColor = false;
            btCadTipoLancamento.Click += btCadTipoLancamento_Click;
            // 
            // frmLivroCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_403115274_z14P5UiqhPQ14ZY2YERroLTjTQaEHuP7;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(956, 502);
            Controls.Add(btCadTipoLancamento);
            Controls.Add(btCadResponsavel);
            Controls.Add(tbRelatorio);
            Controls.Add(lbTipolancamento);
            Controls.Add(cbTipoLancamento);
            Controls.Add(btOK);
            Controls.Add(txValor);
            Controls.Add(lbValor);
            Controls.Add(lbResponsavel);
            Controls.Add(cbResponsavel);
            Controls.Add(rbDebito);
            Controls.Add(rbCredito);
            Controls.Add(txDescricao);
            Controls.Add(lbDescricao);
            Controls.Add(txData);
            Controls.Add(lbData);
            Controls.Add(lbTitulo);
            Name = "frmLivroCaixa";
            Text = "Livro Caixa Santa Cecilia";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tbRelatorio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private Label lbData;
        private TextBox txData;
        private Label lbDescricao;
        private TextBox txDescricao;
        private RadioButton rbCredito;
        private RadioButton rbDebito;
        private ComboBox cbResponsavel;
        private Label lbResponsavel;
        private TextBox txValor;
        private Label lbValor;
        private Button btOK;
        private ComboBox cbTipoLancamento;
        private Label lbTipolancamento;
        private DataGridView tbRelatorio;
        private Button btCadResponsavel;
        private Button btCadTipoLancamento;
    }
}