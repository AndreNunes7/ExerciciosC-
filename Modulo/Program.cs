namespace Modulo
{
    public static class Program
    {
        public static int Main(string[] args)
        {

            
            int[] modulosArray = { -1, -2, -3, -14, -15, };

            int[] resp = modulo(modulosArray);

            for (int i = 0; i < resp.Length; i++)
            {
                Console.WriteLine($"O modulo de {modulosArray[i]} é {resp[i]}: ");
            }

            return 0;
        }
        private static int[] modulo(int[] n)
        {
            int[] resp = new int[n.Length];

            for (int i = 0; i < n.Length; i++)
            {
                resp[i] = n[i];
                if (n[i] < 0)
                {
                    resp[i] *= -1;

                }
            }



            return resp;

        }
    }
}