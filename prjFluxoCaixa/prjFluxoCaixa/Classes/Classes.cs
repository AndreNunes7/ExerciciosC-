using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace prjFluxoCaixa.Classes
{
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;

    namespace ClassesDoLivroCaixa
    {
        [Serializable]
        public class Familia : IComparable<Familia>
        {
            public string Nome {get;}
            public string Sigla {get;}

            public Familia(string nome,string sigla)
            {
                Nome = nome;    
                Sigla = sigla;
            }

            public int CompareTo(Familia f)
            {
                return Nome.CompareTo(f.Nome);
            }

        }

        #pragma warning disable SYSLIB0011
        [Serializable]
        public class Serializa
        {
            
            private static String file = "livroCaixaNovo.bin";

            public static void save(Caixa caixa)
            {
                try
                {
                    FileStream fs = new FileStream(file, FileMode.Create);
                    BinaryFormatter serializer = new BinaryFormatter();
                    serializer.Serialize(fs, caixa); // gravei tudo 
                    fs.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
           
            public static Caixa? load()
            {

                try
                {
                    if (!File.Exists(file)) return null;

                    FileStream fs = new FileStream(file, FileMode.Open);
                    BinaryFormatter formatter = new BinaryFormatter();
                    Caixa caixa = (Caixa)formatter.Deserialize(fs); // le o que salvou
                    fs.Close();

                    return caixa;

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        [Serializable]
        public class Responsavel : IComparable<Responsavel>
        {

            public String Nome { get; private set; }
            public char Tipo { get; private set; }

            public Responsavel(string nome, char tipo)
            {
                Nome = nome;
                Tipo = tipo;
            }
            public override string ToString()
            {
                return String.Concat(Nome, ", ", Tipo);
            }

            public int CompareTo(Responsavel x)     // se o compare to é igual ele retorna 0 , quando o primeiro é menor que o segundo ele retorna um numero menor que 0, quando o segundo é o maior ele retorna um numero maior que 0
            {
                return Nome.CompareTo(x.Nome);
            }
        }
        [Serializable]
        public class Lancamento : IComparable<Lancamento>
        {

            public int CompareTo(Lancamento l)
            {
                return Data.CompareTo(l.Data);  
            }


            public DateTime Data { get; private set; }
            public String Descricao { get; private set; } //Sempre declarar a propriedade em maiusculo
            public char Tipo { get; private set; }
            public Responsavel responsavel { get; private set; }
            public float Valor { get; private set; }
            public Familia familia { get; private set; }




            public Lancamento(DateTime data, String descricao, char tipo, Responsavel responsavel, float valor, Familia familia)
            {
                Data = data;
                Descricao = descricao;
                Tipo = tipo;
                Valor = valor;
                this.responsavel = responsavel; // O responsavel declarado com letra minuscula para nao confundir com a classe
                this.familia = familia;
            }

            public override string ToString()
            {
                return String.Concat(
                    "Data: ", Data.ToString("dd/MM/yy"), 
                    ", Descrição: ", Descricao, 
                    "Familia: ", (familia.Nome + "-" + familia.Sigla),
                    ", Tipo: ", Tipo, 
                    ", Responsável: ", responsavel.Nome, 
                    ", Valor: ", Valor);
            }
            

        }
        [Serializable]
        public class Caixa
        {
            public string MesAno { get; set; }
            public DateTime Fechamento { get; set; }
            public List<Lancamento> lancamentos;
            public Caixa(String mesAno)
            {
                lancamentos = new List<Lancamento>();
                MesAno = mesAno;
            }

            public void Add(Lancamento l)
            {
                lancamentos.Add(l);
            }
            public String relatorio()
            {
                StringBuilder txt = new StringBuilder();

                float saldo = 0;
                lancamentos.Sort();

                foreach (Lancamento l in lancamentos)
                {
                    saldo += l.Tipo == 'C' ? l.Valor : -l.Valor;
                    txt.AppendLine(l.ToString() + ", Saldo: " + saldo);
                }
                return txt.ToString();

            }

            public float saldo()
            {
                float saldo = 0;
                foreach (Lancamento l in lancamentos)
                {
                    saldo += l.Tipo == 'C' ? l.Valor : -l.Valor;                    
                }

                return saldo;
            }

        }
    }
}


//Serialização é um modo de banco de dados, mais simples

//buffer é uma area da memoria que usamos como rascunho