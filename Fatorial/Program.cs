namespace Fatorial
{
    public class Program
    {
        public static int Main(string[] args)
        {
            int num = 0;
            string sNum;
            Console.WriteLine("Digite o primeiro numero: ");
            sNum = Console.ReadLine();
            if (int.TryParse(sNum, out num))
            {
                int resultado = CalculoFatorial(num);
                Console.WriteLine($"O fatorial do numero {num} é {resultado}");

            }

            
            return 0;
        }



        static int CalculoFatorial(int num)
        {

            int f = 1;
            while (num > 1)
            {
                f *= num;
                num -= 1;
            }
            return f;

        }

    }


}
