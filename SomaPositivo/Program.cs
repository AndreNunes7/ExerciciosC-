namespace SomaPositivos
{
    public static class Program
    {
        public static int Main(string[] args)
        {

            int[] numerosArray = { 12, 3, 4, 5, 2, 3, };

            int soma = somaPositivos(numerosArray);

            

            for ( int i = 0; i < numerosArray.Length; i++ )
            {
                Console.WriteLine($"Os numeros são: {numerosArray[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("A soma dos numeros positivos é: " + soma);
            return 0;
        }

        private static int somaPositivos(int[] n)
        {
            int soma = 0;

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] > 0)
                {
                    soma += n[i];
                }
            }
            return soma;
     
        }
    }
 }
