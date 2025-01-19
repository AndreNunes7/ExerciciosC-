namespace Array
{
    public static class Array
    {
        public static int Main(string[] args)
        {
          

            Console.WriteLine("-------------------------");
            

            string[] nomes = { "Maria", "Pedro", "José", "Silvana", "Epaminondas", "Kaique" };

            Console.WriteLine("Maior 1:" + pesquisaMaiorNome(nomes));

            Console.WriteLine("-------------------------");

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i] + ", com " + nomes[i].Length + " letras!");

            }
            Console.WriteLine("-------------------------");

            return 0;
        }

        public static String pesquisaMaiorNome(String[] n)
        {
            String ret = "";

            for (int i = 0; i < n.Length; i++)


            {
                if (n[i].Length > ret.Length)
                {
                    ret = n[i];
                }
            }
            return ret;

        }

    }

}

