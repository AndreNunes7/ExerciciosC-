namespace WinFormsApp1
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private bool valida()
        {
            double valor;

            bool retorno = true;

            if (!double.TryParse(txParcela1.Text, out valor))
            {
                retorno = false;
            }

            if (!double.TryParse(txParcela2.Text, out valor))
            {
                retorno = false;
            }

            if (!retorno)
            {
                lblResultado.Text = "Valores digitados inválidos!";
            }

            return retorno;
        }





        private void btMais_Click(object sender, EventArgs e)
        {
            // evento click

            //lbResultado.Text = "Clicaram";

            if (!valida()) return;

            double parcela1 = double.Parse(txParcela1.Text);
            double parcela2 = double.Parse(txParcela2.Text);

            lblResultado.Text = (parcela1 + parcela2).ToString();






        }

        private void btMenos_Click(object sender, EventArgs e)
        {
            if (!valida()) return;

            double parcela1 = double.Parse(txParcela1.Text);
            double parcela2 = double.Parse(txParcela2.Text);

            lblResultado.Text = (parcela1 - parcela2).ToString();
        }

        private void btVezes_Click(object sender, EventArgs e)
        {
            if (!valida()) return;

            double parcela1 = double.Parse(txParcela1.Text);
            double parcela2 = double.Parse(txParcela2.Text);

            lblResultado.Text = (parcela1 * parcela2).ToString();
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            if (!valida()) return;

            double parcela1 = double.Parse(txParcela1.Text);
            double parcela2 = double.Parse(txParcela2.Text);



            if (parcela1 == 0 || parcela2 == 0)
            {
                lblResultado.Text = "Divisao por zero é impossivel";
                return;
            }

            lblResultado.Text = (parcela1 / parcela2).ToString();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txParcela1.Text = txParcela2.Text = String.Empty;
            lblResultado.Text = "resultado";


        }
    }
}