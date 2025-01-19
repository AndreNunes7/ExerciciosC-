namespace ProjetoIMC
{
    partial class FormIMC
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lbPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.lbSexo = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txRelatorio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.ForeColor = System.Drawing.Color.Brown;
            this.lbTitulo.Location = new System.Drawing.Point(323, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(176, 32);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "TESTANDO";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(63, 49);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(105, 15);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome do Paciente";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(67, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(362, 23);
            this.txtNome.TabIndex = 2;
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(68, 113);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(152, 15);
            this.lbAltura.TabIndex = 3;
            this.lbAltura.Text = "Altura do Paciente (metros)";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(67, 131);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(56, 23);
            this.txtAltura.TabIndex = 4;
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Location = new System.Drawing.Point(235, 113);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(121, 15);
            this.lbPeso.TabIndex = 5;
            this.lbPeso.Text = "Peso do Paciente (kg)";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(234, 131);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(56, 23);
            this.txtPeso.TabIndex = 6;
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(380, 134);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(31, 19);
            this.rbF.TabIndex = 7;
            this.rbF.TabStop = true;
            this.rbF.Text = "F";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(417, 135);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(36, 19);
            this.rbM.TabIndex = 8;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(379, 116);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(32, 15);
            this.lbSexo.TabIndex = 9;
            this.lbSexo.Text = "Sexo";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(481, 99);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txRelatorio
            // 
            this.txRelatorio.Location = new System.Drawing.Point(63, 181);
            this.txRelatorio.Multiline = true;
            this.txRelatorio.Name = "txRelatorio";
            this.txRelatorio.Size = new System.Drawing.Size(693, 235);
            this.txRelatorio.TabIndex = 11;
            // 
            // FormIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txRelatorio);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.rbM);
            this.Controls.Add(this.rbF);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lbPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbTitulo);
            this.Name = "FormIMC";
            this.Text = "Projeto IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbTitulo;
        private Label lbNome;
        private TextBox txtNome;
        private Label lbAltura;
        private TextBox txtAltura;
        private Label lbPeso;
        private TextBox txtPeso;
        private RadioButton rbF;
        private RadioButton rbM;
        private Label lbSexo;
        private Button btnOK;
        private TextBox txRelatorio;
    }
}