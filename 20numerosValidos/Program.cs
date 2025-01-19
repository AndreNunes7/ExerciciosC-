using System;

namespace numerosAte20
{
    public static class Number
    {
        static void Main()
        {
            int[] p = new int[20];
            int[] n = new int[20];
            int c1 = 0;
            int c2 = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Digite um número: ");
                string sNum = Console.ReadLine();
                int num;

                if (int.TryParse(sNum, out num))
                {
                    if (num > 0)
                    {
                        p[c1] = num;
                        c1++;
                    }
                    else if (num < 0)
                    {
                        n[c2] = num;
                        c2++;
                    }
                    else
                    {
                        Console.WriteLine("Zero é um número neutro! Digite outro número.");
                        i--; 
                    }
                }
                else
                {
                    Console.WriteLine("Você não digitou um número válido!");
                    i--; 
                }
            }

            Console.WriteLine();
            Console.WriteLine("Quantidade de números positivos: " + c1);
            Console.WriteLine("Quantidade de números negativos: " + c2);
            Console.WriteLine("Números positivos digitados:");

            for (int i = 0; i < c1; i++)
            {
                Console.WriteLine(p[i]);
            }
        }
    }
}
