using System;

namespace Fibonacci
{
    public static class SequenciaFibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sequencia de Fibonacci");
            int n3 = 0;
            int n1 = 0;
            int i = 3;
            int n2 = 1;
            string Snum;
            int num;
            Console.WriteLine("Digite um numero: ");
            Snum = Console.ReadLine();
            if (int.TryParse(Snum, out num))
            {
                while (i <= num)
                {
                    n3 = n1 + n2;
                    n1 = n2;
                    n2 = n3;
                    i++;
                    Console.WriteLine($"{n3} -> {n2} -> {n1}");
                }
            }
        }
    }
}
