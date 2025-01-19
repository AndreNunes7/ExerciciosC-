namespace ParOuImpar
{
    class program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int valor;

            Console.Write("Digite um numero: ");
            string? num = Console.ReadLine();
            valor = int.Parse(num);



            if (valor % 2 == 0)
            {
                Console.WriteLine("Valor é: Par");
            }
            else if (valor < 0)
            {
                Console.WriteLine("Digite um valor acima de Zero");
            }

            else
            {
                Console.WriteLine("Valor é: Impar");
            }
        }
    
    }
}
