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
        public class TipoDeLancamento : IComparable<TipoDeLancamento>
        {
            public String descricao { get; set; }
            public String sigla { get; set; }

            public TipoDeLancamento(string descricao, string sigla)
            {
                this.descricao = descricao;
                this.sigla = sigla;
            }
            public int CompareTo(TipoDeLancamento t)
            {
                return sigla.CompareTo(t.sigla);
            }
        }
        [Serializable]
        public class Responsavel : IComparable<Responsavel>
        {

            public String Nome { get;  set; }
            public char Tipo { get;  set; }

            public String E_Mail { get; set; }

            public String Telefone { get; set; }

            public Responsavel (string nome, char tipo, string e_mail, string telefone)
            {
                Nome = nome;
                Tipo = tipo;
                E_Mail = e_mail;    
                Telefone = telefone;
            }

            public Responsavel(string nome, char tipo)
            {
                Nome = nome;
                Tipo = tipo;
            }
            //public override string ToString()
            //{
            //    return String.Concat(Nome, ", ", Tipo);
            //}

            public int CompareTo(Responsavel x)
            {
                return E_Mail.CompareTo(x.E_Mail);
            }
        }

        [Serializable]
        public class Lancamento : IComparable<Lancamento>
        {
            public int CompareTo(Lancamento lancamento)
            {                
                return Data.CompareTo(lancamento.Data);
            }

            public TipoDeLancamento TipoLancamento { get; set; }
            public DateTime Data { get; private set; }
            public String Descricao { get; private set; } //Sempre declarar a propriedade em maiusculo
            public char Tipo { get; private set; }
            public Responsavel responsavel { get; private set; }
            public float Valor { get; private set; }
            public Lancamento(
                DateTime data, 
                String descricao, 
                char tipo, 
                Responsavel responsavel, 
                float valor,
                TipoDeLancamento tipoLancamento)
            {
                Data = data;
                Descricao = descricao;
                Tipo = tipo;
                Valor = valor;
                this.responsavel = responsavel; // O responsavel declarado com letra minuscula para nao confundir com a classe
                this.TipoLancamento = tipoLancamento;
            }

            public override string ToString()
            {
                return String.Concat(
                    "Data: ", Data.ToString("dd/MM/yy"), 
                    ", Descrição: ", Descricao, 
                    ", C/D: ", Tipo, // Crédito ou Débito
                    ", Responsável: ", responsavel.Nome, 
                    ", Valor: ", Valor ,
                    ", Tipo: ", TipoLancamento.descricao);
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
                lancamentos.Sort();
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

        [Serializable]
        public class Serializa
        {
            private static String fileCaixa = "Caixa2.bin";
            private static String fileResponsavel = "Responsavel.bin";
            private static String fileTipoLancamento = "TipoLancamento.bin";

            public static void saveTipoLancamento(List<TipoDeLancamento> lista)
            {
                try
                {
                    FileStream fs = new FileStream(fileTipoLancamento, FileMode.Create);
                    BinaryFormatter serializer = new BinaryFormatter();
                    lista.Sort();
                    serializer.Serialize(fs, lista);
                    fs.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public static void saveResponsavel(List<Responsavel> lista)
            {
                try
                {
                    FileStream fs = new FileStream(fileResponsavel, FileMode.Create);
                    BinaryFormatter serializer = new BinaryFormatter();
                    lista.Sort();
                    serializer.Serialize(fs, lista);
                    fs.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            public static void saveCaixa(Caixa caixa)
            {
                try
                {
                    FileStream fs = new FileStream(fileCaixa, FileMode.Create);
                    BinaryFormatter serializer = new BinaryFormatter();
                    serializer.Serialize(fs, caixa);
                    fs.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public static List<TipoDeLancamento>? loadTipoLancamento()
            {
                try
                {
                    if (!File.Exists(fileTipoLancamento)) return null;

                    FileStream fs = new FileStream(fileTipoLancamento, FileMode.Open);
                    BinaryFormatter formatter = new BinaryFormatter();
                    List<TipoDeLancamento> lista = (List<TipoDeLancamento>)
                        formatter.Deserialize(fs);
                    fs.Close();
                    return lista;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public static List<Responsavel>? loadResponsavel()
            {
                try
                {
                    if (!File.Exists(fileResponsavel)) return null;

                    FileStream fs = new FileStream(fileResponsavel, FileMode.Open);
                    BinaryFormatter formatter = new BinaryFormatter();
                    List<Responsavel> lista = (List<Responsavel>)formatter.Deserialize(fs);
                    fs.Close();
                    return lista;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            public static Caixa? loadCaixa()
            {
                try
                {
                    if (!File.Exists(fileCaixa)) return null;

                    FileStream fs = new FileStream(fileCaixa, FileMode.Open);
                    BinaryFormatter formatter = new BinaryFormatter();
                    Caixa caixa = (Caixa)formatter.Deserialize(fs);
                    fs.Close();
                    return caixa;

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
