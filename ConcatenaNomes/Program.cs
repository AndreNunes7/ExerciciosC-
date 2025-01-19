
namespace Array
{
    public static class Array
    {
        public static int Main(string[] args)
        {

            Console.WriteLine("-------------------------");
         
            string[] nomeArray = { "Peterson ", "Andre ", "Kayky ", "Gabriel ", "Maria ", "Julia " };

            for (int i = 0; i < nomeArray.Length; i++)
            {
                Console.WriteLine("Os nomes são: " + nomeArray[i]);
            }

            Console.WriteLine("A concatenação dos nomes é: " + concatena(nomeArray));

            Console.WriteLine("-------------------------");
            return 0;
        }

        private static string concatena(String[] nomeArray)
        {
            string concatena_nomes = "";


            for (int i = 0; i < nomeArray.Length; i++)
            {

                concatena_nomes += nomeArray[i];

            }
            return concatena_nomes;
        }

    }

}

