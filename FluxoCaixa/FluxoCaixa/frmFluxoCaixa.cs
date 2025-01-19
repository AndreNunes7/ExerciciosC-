using System.Text;
using neLivroCaixa02;
using LivroCaixa;


namespace LivroCaixa
{

    partial class frmFluxoCaixa : Form
    {

        private static List<Responsavel>Responsaveis = new List<Responsavel>();

        private static LivroCaixa caixa = new LivroCaixa("Outubro/23");

        public frmFluxoCaixa()

        {
            if (txDescricao.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Descrição não pode estar em branco");
            }


            if (Responsaveis.Count == 0)
            InitializeComponent();
            {
                Responsaveis.Add(new Responsavel("Manoel", 'A'));
                Responsaveis.Add(new Responsavel("Carlos", 'A'));
                Responsaveis.Add(new Responsavel("Maria", 'U'));
                Responsaveis.Add(new Responsavel("Aline", 'U'));

                cbResponsavel.Items.Clear();

                foreach (Responsavel r in Responsaveis)
                {
                    cbResponsavel.Items.Add(r.Nome);
                }

            }
            
        }

        private Responsavel? pegaResponsavel(String nome)
        {
            foreach(Responsavel responsavel in Responsaveis)
            {
                if (nome.Equals(responsavel.Nome))
                {
                    return responsavel;
                }
                
            }
            return null;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void brOk_Click(object sender, EventArgs e)
        {
            if (!rbDebito.Checked && !rbCredito.Checked)
            {
                MessageBox.Show("Selecione se é credito ou debito!");
                rbDebito.Focus();

                return;
            }
            DateTime data;
            if (!DateTime.TryParse(txData.Text, out data))
            {
                MessageBox.Show("Digite uma data valida!");
                txData.Focus();

                return;
            }

            if (data.CompareTo(DateTime.Now) > 0)
            {
                MessageBox.Show("Data futura é invaldia!");
                txData.Focus();
                return;
            }

            if (cbResponsavel.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um responsavel");
                cbResponsavel.Focus();
                return;
            }

            double valor;

            if (!Double.TryParse(txValor.Text, out valor))
            {
                MessageBox.Show("Valor digitado é invalido!");
                txValor.Focus();
                return;
            }

            if (valor < 0 )
            {
                MessageBox.Show("Valor preccisa ser positivo!");
                txValor.Focus();
                return;
            }

            if (rbDebito.Checked && valor > caixa.saldo())
            {
                MessageBox.Show(String.Concat("Saldo na caixa insuficiente (", caixa.saldo(), ")"));
                txValor.Focus();
                return;
            }

            

        }
    }
}



        
           

    