//EXERCÍCIO 01:
//Fazer um programa para ler os valores da largura e altura de um retângulo. Em
//seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe
//como mostrado no projeto ao lado.
using System.Globalization;

using ExRetangulo;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            retangulo ret = new retangulo();

            Console.Write("Entre com a largura do cu do kayky: ");
            ret.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com a altura: ");
            ret.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area: " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}