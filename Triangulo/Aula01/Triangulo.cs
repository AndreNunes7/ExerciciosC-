using System;
namespace Aula01
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        // Public = serve para poder usar o metodo ou variavel em outro lugar



        // criando um metodo que calcula a area do Triangulo dentro da classe:

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
