using System.Text;


// OBS: object classe generica

// tostring é um metodo da classe object que converte algo da classe object em string
namespace Figura2 {

    // construtor da super
    public abstract class Pessoa // classe abstrata não pode ser instanciada
    {
        private String nome;
        private DateTime dataNascimento;
        private String rg;
        private String cpf;
        private char sexo; // "F" e "m"


        private List<String> telefones = new List<string> (); // ---- lista

        public void AddTel(String tel)
        {
            telefones.Add (tel);    // adicionando o valor a lista
        }

        public String listaTel()
        {
            StringBuilder ret = new StringBuilder();
            foreach (String tel in telefones)
            {
                ret.AppendLine(tel);

                // outra forma ----> ret.append("\n");
            }
            return ret.ToString ();  
        }
        public String Nome
        {
            get { return nome; }
        }
        public DateTime DataNascimento
        {
            get { return dataNascimento; }

        }
        public String Cpf
        {
            get { return cpf; }
        }

        public String Rg
        {
            get { return rg; }
        }
        public char Sexo
        {
            get { return sexo; }
        }




        // propriedades privadas e metodos publicos!! 


        public Pessoa(string nome, DateTime dataNascimento, string rg, string cpf, char sexo)  // Construtor
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.rg = rg;
            this.cpf = cpf;
            this.sexo = sexo;



        }
        // sobrescrevendo 
        public override string ToString()     //  super classe pessoa
        {
            return String.Concat("\nNome: ", Nome, "\nNascimento: ", DataNascimento.ToString("dd/mm/yy"), "\nRG: ", Rg, "\nCPF: ", Cpf, "\nSexo: ", Sexo);  
        }

        
 
        }
    public class Professor : Pessoa
    {
        private String regFunc;
        private String formacao;



        public Professor(string nome, DateTime dataNascimento, string rg, string cpf, char sexo, String regFunc, String formacao) : base(nome, dataNascimento, rg, cpf, sexo)
        {
            this.regFunc = regFunc;
            this.formacao = formacao;
        }
        public string RegFunc
        {
            get { return regFunc; }
        }
        public string Formacao
        {
            get { return formacao; }
        }

        public override string ToString()
        {
            return String.Concat(base.ToString(), ", Reg. Func: ", RegFunc, "Formação", formacao);

        }

    }
    public class Aluno: Pessoa
    {
        private String ra;
        private String curso;


        public Aluno(string nome, DateTime dataNascimento, string rg, string cpf, char sexo, String ra, String curso) : base(nome, dataNascimento, rg, cpf, sexo)
        {
            this.ra = ra;
            this .curso = curso;
        }
        public String Ra
        {
            get { return ra; }
        }

        public String Curso
        {
            get { return curso; }
        }

        public override string ToString()
        {
          
            return String.Concat(base.ToString(), "\nCurso: ", curso, "\nRA: ", ra );    // Dados que estaão la na super classe Pessoa

        }

        


    }

    

    // main
    public class Programa
    {

        
        public static int Main(String [] args)
        {

            //DateTime dta1;

            //DateTime.TryParse("2004/02/12", out dta1);  <---- Melhor maneira


            Aluno a1 = new Aluno("Andre", new DateTime(2004, 02, 12), "42424242435", "332-321-313-1", 'M', "228290", "ADS");
            a1.AddTel("1399420425");
            
            Aluno a2 = new Aluno("Kayky", new DateTime(2003, 05, 15), "12304245255", "4492-4242-231", 'F', "330425", "Sistema da informação");
            a2.AddTel("1499420425");
            Aluno a3 = new Aluno("Peterson", new DateTime(2001, 01, 25), "15020424052", "7742852-52324", 'F', "220425", "Educação fisica");
            a3.AddTel("1699420525");
            Aluno a4 = new Aluno("Murilo", new DateTime(2002, 05, 23), "77432004222", "139942 42042", 'F', "210425", "ADS");
            a4.AddTel("1599424024");

            List<Aluno> list = new List<Aluno>();

            list.Add(a1);
            list.Add(a2);
            list.Add(a3);
            list.Add(a4);

            

            Professor prof1 = new("Rangel", new DateTime(1995, 01, 21), "552052525052", "13310202334", 'M', "32323223", "Engenharia Civil");
            prof1.AddTel("(13) 991424 3242");
            prof1.AddTel("(13) 992203 9975");
            prof1.AddTel("(13) 3394332022");



            Console.WriteLine("-------------------------------");
            Console.WriteLine("Professor:");
            Console.WriteLine("\nNome: " + prof1.Nome + "\n" + "Sexo: " + prof1.Sexo  + "\nReg. Func: " + prof1.RegFunc + "\nformação: " + prof1.Formacao + "\n" + "telefone: " + prof1.listaTel());
             
            Console.WriteLine("-------------------------------");
            
            
            foreach (Aluno a in list)
            {
                Console.WriteLine("Aluno:");
                Console.WriteLine(a);
                Console.WriteLine("Numero: " + a.listaTel());
                Console.WriteLine("---------------------------");
            }
            
            

            return 0;
        }
    }
}