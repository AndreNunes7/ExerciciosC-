namespace prjFluxoCaixa
{
    partial class cadTipoLancamento
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
            lbCadastroTipoLancamento = new Label();
            lbDescricao = new Label();
            txDescricao = new TextBox();
            lbSigla = new Label();
            txSigla = new TextBox();
            btSalvar = new Button();
            btExcluir = new Button();
            btLimpar = new Button();
            btBuscar = new Button();
            txBuscarSigla = new TextBox();
            lbBuscar = new Label();
            tbRelatorio = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tbRelatorio).BeginInit();
            SuspendLayout();
            // 
            // lbCadastroTipoLancamento
            // 
            lbCadastroTipoLancamento.AutoSize = true;
            lbCadastroTipoLancamento.BackColor = Color.Transparent;
            lbCadastroTipoLancamento.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbCadastroTipoLancamento.ForeColor = Color.Red;
            lbCadastroTipoLancamento.Location = new Point(127, 26);
            lbCadastroTipoLancamento.Name = "lbCadastroTipoLancamento";
            lbCadastroTipoLancamento.Size = new Size(327, 29);
            lbCadastroTipoLancamento.TabIndex = 0;
            lbCadastroTipoLancamento.Text = "Cadastro de Tipo de Lançamento";
            lbCadastroTipoLancamento.Click += lbCadastroTipoLancamento_Click;
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.BackColor = Color.Transparent;
            lbDescricao.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbDescricao.ForeColor = Color.Red;
            lbDescricao.Location = new Point(48, 65);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(88, 22);
            lbDescricao.TabIndex = 1;
            lbDescricao.Text = "Descrição";
            lbDescricao.Click += lbDescricao_Click;
            // 
            // txDescricao
            // 
            txDescricao.Location = new Point(48, 94);
            txDescricao.Name = "txDescricao";
            txDescricao.Size = new Size(313, 23);
            txDescricao.TabIndex = 2;
            // 
            // lbSigla
            // 
            lbSigla.AutoSize = true;
            lbSigla.BackColor = Color.Transparent;
            lbSigla.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbSigla.ForeColor = Color.Red;
            lbSigla.Location = new Point(46, 125);
            lbSigla.Name = "lbSigla";
            lbSigla.Size = new Size(49, 20);
            lbSigla.TabIndex = 3;
            lbSigla.Text = "Sigla";
            // 
            // txSigla
            // 
            txSigla.Location = new Point(48, 148);
            txSigla.Name = "txSigla";
            txSigla.Size = new Size(66, 23);
            txSigla.TabIndex = 4;
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.Lime;
            btSalvar.Location = new Point(392, 227);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(62, 23);
            btSalvar.TabIndex = 20;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += btSalvar_Click;
            // 
            // btExcluir
            // 
            btExcluir.BackColor = Color.Red;
            btExcluir.Enabled = false;
            btExcluir.Location = new Point(324, 227);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(62, 23);
            btExcluir.TabIndex = 19;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            btExcluir.Click += btExcluir_Click;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(483, 94);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(70, 23);
            btLimpar.TabIndex = 18;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(378, 94);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(62, 23);
            btBuscar.TabIndex = 17;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // txBuscarSigla
            // 
            txBuscarSigla.Location = new Point(48, 207);
            txBuscarSigla.Name = "txBuscarSigla";
            txBuscarSigla.Size = new Size(66, 23);
            txBuscarSigla.TabIndex = 16;
            // 
            // lbBuscar
            // 
            lbBuscar.AutoSize = true;
            lbBuscar.BackColor = Color.Transparent;
            lbBuscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbBuscar.ForeColor = Color.Red;
            lbBuscar.Location = new Point(46, 184);
            lbBuscar.Name = "lbBuscar";
            lbBuscar.Size = new Size(122, 20);
            lbBuscar.TabIndex = 15;
            lbBuscar.Text = "Buscar (Sigla)";
            // 
            // tbRelatorio
            // 
            tbRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbRelatorio.Location = new Point(103, 256);
            tbRelatorio.Name = "tbRelatorio";
            tbRelatorio.RowTemplate.Height = 25;
            tbRelatorio.Size = new Size(352, 144);
            tbRelatorio.TabIndex = 21;
            // 
            // cadTipoLancamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.minimalism_red_abstract_digital_art_wallpaper_preview;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(586, 412);
            Controls.Add(tbRelatorio);
            Controls.Add(btSalvar);
            Controls.Add(btExcluir);
            Controls.Add(btLimpar);
            Controls.Add(btBuscar);
            Controls.Add(txBuscarSigla);
            Controls.Add(lbBuscar);
            Controls.Add(txSigla);
            Controls.Add(lbSigla);
            Controls.Add(txDescricao);
            Controls.Add(lbDescricao);
            Controls.Add(lbCadastroTipoLancamento);
            Name = "cadTipoLancamento";
            Text = "cadTipoLancamento";
            Load += cadTipoLancamento_Load;
            ((System.ComponentModel.ISupportInitialize)tbRelatorio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCadastroTipoLancamento;
        private Label lbDescricao;
        private TextBox txDescricao;
        private Label lbSigla;
        private TextBox txSigla;
        private Button btSalvar;
        private Button btExcluir;
        private Button btLimpar;
        private Button btBuscar;
        private TextBox txBuscarSigla;
        private Label lbBuscar;
        private DataGridView tbRelatorio;
    }
}