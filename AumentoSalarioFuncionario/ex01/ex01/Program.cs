using ex01;
using System.Runtime.CompilerServices;
using System.Globalization;

namespace Project {
    class Program
    {
        public static void Main(string[] args) 
        {

            Funcionario funcionario = new Funcionario();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("     Aumento do funcionario");
            Console.WriteLine("------------------------------------");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + funcionario);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);
            Console.WriteLine("Dados atualizados: " + funcionario);





        }
    }
}