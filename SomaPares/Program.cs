namespace Array
{
    public static class Array
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("-------------------------");
          
            int[] num = { 1, 4, 55, 33, 23, 24, 42, };

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {

                    Console.WriteLine("Os pares são: " + num[i]);

                }
                
            }

            Console.WriteLine("-------------------------");

            Console.WriteLine("A soma dos pares é: " + somaPares(num));
           
            Console.WriteLine("-------------------------");
            
            return 0;
        }

        private static int somaPares(int[] num)
        {
            int soma = 0;

            for (int i = 0; i < num.Length; i++)
            {

                if (num[i] % 2 == 0)
                {
                    soma += num[i];

                }
            }
            return soma;
        }
     
    }

}
