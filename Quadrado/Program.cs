namespace Array
{
    public static class Array
    {
        public static int Main(string[] args)
        {
           
            
            Console.WriteLine("-----------------------------------");
            
            int[] num = { 1, 4, 55, 33, 23, 24, 42, };
            
            int[] u = quadrado(num);

            for (int y = 0; y < u.Length; y++)
            {
                Console.WriteLine("O quadrado do numero " + num[y] + " é: " + u[y]);
            }

            Console.WriteLine("-----------------------------------");


            return 0;
        }

        private static int[] quadrado(int[] num)
        {

            int[] quadradoConta = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                quadradoConta[i] = num[i] * num[i];
            }
            return quadradoConta;
        }

    }

}