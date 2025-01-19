using ProjetoIMC.Classes;

namespace ProjetoIMC
{
    public partial class FormIMC : Form
    {
        private Clinica clinica;
        public FormIMC() // Eu sou o construtor do form
        {
            InitializeComponent();
            clinica = new Clinica("Clínica de Controle de Peso Santa Cecília");
            lbTitulo.Text = clinica.Nome;
        }        
        private void limpa()
        {
            txtNome.Text = 
            txtAltura.Text = 
            txtPeso.Text = String.Empty;

            rbM.Checked = rbF.Checked = false;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            // TP DE HOJE
            // Fazer as consistências (Nome, Peso, Altura, Sexo)
            //     Nome não pode estar vazio
            //     Peso deve ser numero válido e ebtre 40 e 160kg
            //     Altura deve ser numérico e entre 1 e 2.10m
            //     Sexo: Deve ter pelo menos um selecionado (F ou M)
            // Instancia o IMC
            // Instancia o Paciente
            // Coloca na lista de Pacientes da Clínica
            // Mostra o relatório
            // Apaga os dados digitados da tela (Fazer o método limpa())
            // -----------------------------------------------------------
            // Assunto: IMC - Nome - RA
            // Enviar o código fonte apenas desta classe e a cópia
            // da tela em um docx, anexado ao e-mail
            // halrangel@yahoo.com.br

            // Peso entre 40kg e 160kg
            // Altura entre 1m e 2,10m

            if (txtNome.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Nome é obrigatório");
                txtNome.Focus(); // Coloca o cursor no componente
                return;
            }

            txRelatorio.Text = clinica.relatorio();
            limpa();
        }
    }
}