using ProjetoIMC.Classes;

namespace ProjetoIMC
{
    public partial class FormIMC : Form
    {
        private Clinica clinica;
        public FormIMC() // Eu sou o construtor do form
        {
            InitializeComponent();
            clinica = new Clinica("Cl�nica de Controle de Peso Santa Cec�lia");
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
            // Fazer as consist�ncias (Nome, Peso, Altura, Sexo)
            //     Nome n�o pode estar vazio
            //     Peso deve ser numero v�lido e ebtre 40 e 160kg
            //     Altura deve ser num�rico e entre 1 e 2.10m
            //     Sexo: Deve ter pelo menos um selecionado (F ou M)
            // Instancia o IMC
            // Instancia o Paciente
            // Coloca na lista de Pacientes da Cl�nica
            // Mostra o relat�rio
            // Apaga os dados digitados da tela (Fazer o m�todo limpa())
            // -----------------------------------------------------------
            // Assunto: IMC - Nome - RA
            // Enviar o c�digo fonte apenas desta classe e a c�pia
            // da tela em um docx, anexado ao e-mail
            // halrangel@yahoo.com.br

            // Peso entre 40kg e 160kg
            // Altura entre 1m e 2,10m

            if (txtNome.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Nome � obrigat�rio");
                txtNome.Focus(); // Coloca o cursor no componente
                return;
            }

            float peso;

            if (!float.TryParse(txtPeso.Text,out peso))
            {
                MessageBox.Show("Peso digitado inv�lido!");
                txtPeso.Focus();
                return;
            }

            if (peso < 40 || peso > 160)
            {
                MessageBox.Show("Peso deve estar entre 40 e 160kg!");
                txtPeso.Focus();
                return;
            }

            float altura;

            if (!float.TryParse(txtAltura.Text,out altura))
            {
                MessageBox.Show("Altura digitada inv�lida!");
                txtAltura.Focus();
                return;
            }

            if (altura < 1 || altura > 2.1)
            {
                MessageBox.Show("Altura deve estar entre 1 e 2,1m!");
                txtAltura.Focus();
                return;
            }

            if (!rbF.Checked && !rbM.Checked)
            {
                MessageBox.Show("Selecione o sexo do paciente!");
                return;
            }

            IMC imc = new IMC(peso,altura);

            Paciente p = new Paciente(txtNome.Text, rbF.Checked?'F':'M',imc);

            clinica.Add(p);

            txRelatorio.Text = clinica.relatorio();
            limpa();
        }
    }
}