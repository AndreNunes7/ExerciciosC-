using System.Text;
namespace Program
{

    // Tp 02/10/23
    // Criar um programa que:
    // a) instacia um objeto LivroCaixa
    // b) Criar 5 lançamentos, o primeiro de credito
    // c) Mostrar na tela os lançamentos e o saldo 
    // Assunto: LIVRO-CAIXA - Nome - RA
    // Enviar para halrangel@yahoo.com.br

    public class Responsavel
    {
        private static int baseId = 0; // tudo que é static pertence a classe é nao ao objeto
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
        public static int baseId = 0;
        public int Id { get; private set; }
        public string Periodo { get; private set; }
        private List<Lancamento> lancamentos;

        public LivroCaixa(string periodo)
        {
            Id = ++baseId;
            Periodo = periodo;
            lancamentos = new List<Lancamento>();


        }

        public void Add(Lancamento lancamento)
        {
            lancamentos.Add(lancamento);
        }


        public String lista()
        {
            StringBuilder txt = new StringBuilder();
            float saldo = 0;
            foreach (Lancamento l in lancamentos)
            {
                txt.Append(l.ToString());
                saldo += l.Tipo == 'C' ? l.Valor : -l.Valor;
                txt.AppendLine(l.ToString() + ", " + saldo + "\n");

                if (saldo < 0)
                {
                    txt.Append("O valor não pode ser negativo");
                }

            }
            return txt.ToString();


        }

        public class Lancamento
        {
            private static int BaseId = 0;

            public LivroCaixa Caixa { get; private set; }

            private int Id { get; set; }
            public DateTime Data { get; private set; }

            public String Descricao { get; private set; }

            public Responsavel Responsavel { get; private set; }  // composição , quando declara uma classe dentro da outra

            public char Tipo { get; private set; }

            public float Valor { get; private set; }



            public Lancamento(LivroCaixa caixa, DateTime data, string descricao, Responsavel responsavel, char tipo, float valor)
            {

                Caixa = caixa;
                Id = ++BaseId;
                Data = data;
                Descricao = descricao;
                Responsavel = responsavel;
                Tipo = tipo;
                Valor = valor;


            }


            public override string ToString()
            {
                return String.Concat(Caixa.Periodo, ", ",
                    Data.ToString("dd/MM/yy"),
                    ", ", Responsavel,
                    ", ", Tipo,
                    ", ", Valor);

            }

        }



        public class teste
        {
            public static void Main(String[] args)
            {
                LivroCaixa caixa = new LivroCaixa("Outubro");
                Responsavel resp = new Responsavel("Rangel", 'A');

                Lancamento l1 = new Lancamento(caixa, new DateTime(2023, 10, 2), "Deposito", resp, 'C', 1000F);
                Lancamento l2 = new Lancamento(caixa, new DateTime(2023, 11, 3), "Peça", resp, 'D', 430F);
                Lancamento l3 = new Lancamento(caixa, new DateTime(2023, 12, 4), "Vaso", resp, 'D', 100F);
                Lancamento l4 = new Lancamento(caixa, new DateTime(2023, 09, 5), "Piso", resp, 'D', 240F);
                Lancamento l5 = new Lancamento(caixa, new DateTime(2023, 11, 6), "Deposito", resp, 'C', 500F);

                caixa.Add(l1);
                caixa.Add(l2);
                caixa.Add(l3);
                caixa.Add(l4);
                caixa.Add(l5);


                Console.WriteLine(caixa.lista());




            }
        }
    }
}