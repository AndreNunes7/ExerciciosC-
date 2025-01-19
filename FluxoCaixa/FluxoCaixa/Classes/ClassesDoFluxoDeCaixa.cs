using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace neLivroCaixa02
{
    public class Responsavel
    {
        private static int baseId = 0;
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public char Perfil { get; private set; }
        public Responsavel(string nome, char perfil)
        {
            Id = ++baseId;
            Nome = nome;
            Perfil = perfil;
        }
        public override string ToString()
        {
            return String.Concat(Id, ", ", Nome, ", ", Perfil);
        }
    }

    public class LivroCaixa
    {
        private static int baseId = 0;
        public int Id { get; private set; }
        public string Periodo { get; private set; }

        private List<Lancamento> lancamentos;

        public LivroCaixa(String periodo)
        {
            Id = ++baseId;
            Periodo = periodo;
            lancamentos = new List<Lancamento>();
        }

        public void Add(Lancamento lancamento)
        {
            lancamentos.Add(lancamento);
        }

        // TP 02/10/2023
        // Criar um programa que:
        // a) Instanciar um objeto LivroCaixa
        // b) Criar 5 lançamentos, o primeiro de crédito
        // c) Mostrar na tela os lançamentos e o SALDO
        // Assunto: LIVRO-CAIXA - Nome - RA
        // Enviar para halrangel@yahoo.com.br

        public double saldo()
        {
            double sum = 0;
            foreach (Lancamento l in lancamentos)
            {
                sum += l.Tipo == 'C' ? l.Valor : -l.Valor;
            }
            return sum;
        }


        public String lista()
        {
            StringBuilder txt = new StringBuilder();
            foreach (Lancamento l in lancamentos)
            {
                txt.AppendLine(l.ToString());
            }
            return txt.ToString();
        }
    }
    public class Lancamento
    {
        private static int baseId = 0;
        public LivroCaixa Caixa { get; private set; }
        private int Id { get; set; }
        public DateTime Data { get; private set; }
        public String Descricao { get; private set; }
        public Responsavel Responsavel { get; private set; }
        public char Tipo { get; private set; }
        public float Valor { get; private set; }

        public Lancamento(LivroCaixa caixa,
                          DateTime data,
                          string descricao,
                          Responsavel responsavel,
                          char tipo,
                          float valor)
        {
            Id = ++baseId;
            Caixa = caixa;
            Data = data;
            Descricao = descricao;
            Responsavel = responsavel;
            Tipo = tipo;
            Valor = valor;
        }

        public override string ToString()
        {
            return String.Concat(Caixa.Periodo,
                            ", ", Data.ToString("dd/MM/yy"),
                            ", ", Responsavel,
                            ", ", Tipo,
                            ", ", Valor);
        }

    }
}
