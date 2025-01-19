using Aula01;
using System.Globalization;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;

            // classe: é a definição do tipo

            // Objeto: são instancias da classe

            x = new Triangulo();    // (new) serve para instanciar uma classe
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);  // atribuindo o campo X as determinadas propriedades (A, B, C) da classe Triangulo 
            x.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            // Calculos: 

            double areaX = x.Area();
            double areaY = y.Area();


            Console.WriteLine("Area de X = "+ areaX.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = "+ areaY.ToString("F4",CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}