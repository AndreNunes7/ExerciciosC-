namespace SomaImparesNaoMultiploDe5
{
    public class SomaImparesNaoMultiploDe5
    {
        public static int Main(String[] args)
        {
            int soma1 = somaImparesNaoMultiplosDe5();
            Console.WriteLine("Soma dos numeros não multiplos de 5 até 1000 é: " + soma1);
            

            return 0;
        }

        public static int somaImparesNaoMultiplosDe5()

        {
            int soma = 0;

            for (int i = 100; i <= 1000; i++)

            {
                if (i % 2 != 0 && i % 5 != 0)
                {

                    soma += i;

                }


            }
            return soma;
        }

    }

}
