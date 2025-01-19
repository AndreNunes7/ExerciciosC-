
using prjFluxoCaixa.Classes.ClassesDoLivroCaixa;

namespace prjFluxoCaixa
{
    public partial class frmLivroCaixa : Form
    {
        static private Caixa?caixa;
        static private List<Familia> familias = new List<Familia>();

        static private Responsavel[] res = {
                                            new Responsavel("Hélio Rangel", 'A'),
                                            new Responsavel("Maria Aparecida", 'A'),
                                            new Responsavel("Carlos",'U'),
                                            new Responsavel("José Américo",'U')
                                           };

        public frmLivroCaixa()
        {
            InitializeComponent();
        }
        private void dataRelatorio(Caixa ?caixa)
        {

            tbRelatorio.Columns.Clear();
            tbRelatorio.RowCount = 1;
            tbRelatorio.ColumnCount = 7;

            tbRelatorio.Columns[0].HeaderText = "Data";

            tbRelatorio.Columns[0].DefaultCellStyle.BackColor = Color.Yellow;



            tbRelatorio.Columns[1].HeaderText = "Descrição";
            tbRelatorio.Columns[1].Width = 180;
            tbRelatorio.Columns[2].HeaderText = "C/D";
            tbRelatorio.Columns[2].Width = 35;
            tbRelatorio.Columns[3].HeaderText = "Responsavel";
            tbRelatorio.Columns[4].HeaderText = "Valor";
            tbRelatorio.Columns[4].Width = 80;
            tbRelatorio.Columns[5].HeaderText = "Familia";
            tbRelatorio.Columns[6].HeaderText = "Saldo";
            tbRelatorio.Columns[6].Width = 80;
            float saldo = 0;
            //if (caixa.lancamentos != null)
            
            caixa.lancamentos.Sort();
            

            foreach (Lancamento l in  caixa.lancamentos)
            {
                int i = 0;
                saldo += l.Tipo == 'C' ? l.Valor : -l.Valor;
                tbRelatorio.Rows[i].Cells[0].Value = l.Data.ToString("dd/MM/yy");
                tbRelatorio.Rows[i].Cells[1].Value = l.Descricao;
                tbRelatorio.Rows[i].Cells[2].Value = l.Tipo;
                tbRelatorio.Rows[i].Cells[3].Value = l.responsavel.Nome;
                tbRelatorio.Rows[i].Cells[4].Value = l.Valor.ToString();
                tbRelatorio.Rows[i].Cells[5].Value = l.familia;
                tbRelatorio.Rows[i].Cells[6].Value = String.Format(saldo.ToString());
                

                i++;
            }
               

            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (caixa == null) // Primeira vez que roda o app 
            {

                caixa = Serializa.load();
                if (caixa == null) // foi la ler o arquivo e ainda nao existe
                {
                    caixa = new Caixa("Outubro/23"); //instancia o caixa
                    Serializa.save(caixa); //salva o caixa recem criado, agora vai ter


                    
                }
                dataRelatorio(caixa);
                //txRelatorio.Text = caixa.relatorio();

            }

    

            if (familias.Count == 0)
            {
                familias.Add(new Familia("Crédito", "CRE"));
                familias.Add(new Familia("Cartório", "CAR"));
                familias.Add(new Familia("Material escritório", "MAT"));
                familias.Add(new Familia("Refeição", "REF"));
                familias.Add(new Familia("Taxi", "Tax"));
                familias.Add(new Familia("Manutenção", "MANU"));
                familias.Add(new Familia("Aplicativo", "APL"));
                familias.Add(new Familia("Onibus", "ONI"));
                familias.Sort(); //só posso usar pq tem o IComparable
            }
            
            
            cbResponsavel.Items.Clear(); // Limpando o combo
            cbFamilia.Items.Clear();


            foreach (Responsavel r in res)
            {
                cbResponsavel.Items.Add(r.Nome);
            }

            foreach (Familia fam in familias)
            {
                cbFamilia.Items.Add(fam.Nome); 
            }


        }

        private void btOK_Click(object sender, EventArgs e)
        {
            DateTime data;

            if (!DateTime.TryParse(txData.Text, out data))
            {
                MessageBox.Show("Data digitada deve ser uma data válida!");
                txData.Focus();
                return;
            }

            if (data.CompareTo(DateTime.Now) > 0)
            {
                MessageBox.Show("Data futura é inválida!");
                txData.Focus();
                return;
            }

            if (txDescricao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Descrição do lançamento é obrigatória!");
                txDescricao.Focus();
                return;
            }

            if (cbResponsavel.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o responsável");
                cbResponsavel.Focus();
                return;
            }

            if (cbFamilia.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a familia");
                cbFamilia.Focus();
                return;
            }


            if (!rbCredito.Checked && !rbDebito.Checked)
            {
                MessageBox.Show("Selecione se crédito ou débito!");
                return;
            }

            float valor;

            if (!float.TryParse(txValor.Text, out valor) || valor <= 0)
            {
                MessageBox.Show("Valor digitado não é um valor válido!");
                return;
            }


            if (rbDebito.Checked && caixa.saldo() < valor)
            {
                MessageBox.Show("Valor digitado maior que o saldo; Saldo: " + caixa.saldo());
                return;
            }
            String? fam = cbFamilia.SelectedItem.ToString();
            Familia? selF = null;

            foreach(Familia f in familias)
            {
                if (fam == f.Nome)
                {
                    selF = f;
                    break;
                }
            }


            String ?sel = cbResponsavel.SelectedItem.ToString();
            Responsavel selec = null;
            foreach(Responsavel r in res)
            {
               if (sel == r.Nome)
                {
                    selec = r;
                    break;
                }
            }
            if (selF == null)
            {
                MessageBox.Show("Erro inesperado. Responsável não cadastrado!");
                return;
            }

            String? familiaSelecionada = cbFamilia.SelectedItem.ToString();
            Familia? famSel= null;
            foreach (Familia f in familias)
            {
                if (familiaSelecionada == f.Nome)
                {
                    famSel = f;
                    break;
                }
            }
            if (famSel == null)
            {
                MessageBox.Show("Erro inesperado. Familia não cadastrado!");
                return;
            }

            Lancamento l = new Lancamento(
                data,
                txDescricao.Text,
                rbCredito.Checked ? 'C' : 'D',
                selec,  // este éo responsavel que esta selecionado no combo
                valor,
                selF); // esta é a familia que esta selecionada no combo

            if (caixa != null)
            {
                caixa.Add(l);
                Serializa.save(caixa);
                //txRelatorio.Text = caixa.relatorio();

            }

            

        }

        
    }
}