using System.Runtime.CompilerServices;

namespace Figuras
{
    public class Figuras
    {
        private float area;
        private float perimetro;

        protected string nome = "";

        public string getNome()
        {
            return nome;
        }

        protected void setArea(float area) // set significa receber o valor
        {
            if (area > 0)
            {
                this.area = area; //This significa o objeto em questao
            }
            else
            {
                this.area = 0;
            }
        }

        protected void setPerimetro(float perimetro)
        {
            if (perimetro > 0)
            {
                this.perimetro = perimetro;
            }
            else
            {
                this.perimetro = 0;
            }


        }


        public float getArea()
        {
            return this.area;
        }

        public float getPerimetro()
        {
            return this.perimetro;
        }

    }
    public class Retangulo : Figuras // o metodo construtor tem o mesmo nome da classe (nesse caso é "retangulo") && segunda caracteristica é que nao tem retorno, ele retorna o objeto criado
    {
        private float ladoA; //tem que passar qual o valor do lado A e qual o valor do lado B
        private float ladoB;


        public Retangulo(float ladoA, float ladoB)
        {
            nome = "Retangulo";
            this.ladoA = ladoA;
            this.ladoB = ladoB;

            setArea(ladoA * ladoB);
            setPerimetro(2 * (ladoA + ladoB));

        }

        public float getladoA()
        {
            return this.ladoA;
        }

        public float getladoB()
        {
            return this.ladoB;
        }


        public float Diagonal()
        {

            return (float)Math.Sqrt(ladoA * ladoA + ladoB * ladoB);
        }

    }

    public class circulo : Figuras
    {
        private float raio;

        private float raioB;

        public circulo(float raio)
        {
            this.nome = "Circulo";
            this.raio = raio;
            setArea((float)Math.PI * raio + raio);  // poderia fazer tambem (Math.PI * Math.pow(raio,2));
            setPerimetro(2 * (float)Math.PI * raio);
        }

        public float getRaio()
        {
            return this.raio;
        }
    }


    public class quadrado : Retangulo
    {
        public quadrado(float lado) : base(lado, lado)
        {
            nome = "Quadrado";

        }
    }

    public class trianguloRetangulo
    {
        private Retangulo r;

        public trianguloRetangulo(float b, float h) //b de base e h de altura
        {

            r = new Retangulo(b, h);

        }
        public string getNome()
        {
            return "Trinagulo Retangulo";

        }

        public float getArea()
        {
            return r.getArea() / 2;
        }

        public float getPerimetro()
        {
            return r.getladoA() + r.getladoB() + r.Diagonal();
        }

        public float gethipotenusa()
        {
            return r.Diagonal();
        }




    }

    public class trianguloEquilatero : Figuras
    {
        private float lado;
        private float altura;

       public trianguloEquilatero(float lado)
        {
            nome = "Triangulo equilatero";
            this.lado = lado;
            setPerimetro(lado * 3);
            altura = (lado * (float)Math.Sqrt(3) / 2);
            setArea((lado * altura ) / 2);


        }

      

        public float getPerimetro()
        {
            return lado;
        }
        
        public float getAltura()
        {
            return altura;
        }
            
        
        


    }


    public class Programa
    {

        public static int Main(string[] args)
        {

            Retangulo r = new Retangulo(3, 4);

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("Figura: " + r.getNome() + "\n" + "Area: " + r.getArea() + "\n" + "Perimetro: " + r.getPerimetro() + "\n" + "Diagonal: " + r.Diagonal());

            Console.WriteLine("---------------------------------------------------------------------");
            circulo c = new circulo(1);

            Console.WriteLine("Figura: " + c.getNome() + "\n" + "Area: " + c.getArea() + "\n" + "Perimetro: " + c.getPerimetro());
            Console.WriteLine("---------------------------------------------------------------------");
            quadrado q = new quadrado(10);

            Console.WriteLine("Figura: " + q.getNome() + "\n" + "Area: " + q.getArea() + "\n" + "Perimetro: " + q.getPerimetro() + "\n" + "Diagonal:" + r.Diagonal());
            Console.WriteLine("---------------------------------------------------------------------");

            trianguloRetangulo tr = new trianguloRetangulo(3, 4);

            Console.WriteLine("Figura: " + tr.getNome() + "\n" + "Area: " + tr.getArea() + "\n" + "Perimetro: " + tr.getPerimetro() + "\n" + "Diagonal: " + tr.gethipotenusa());
            Console.WriteLine("---------------------------------------------------------------------");

            trianguloEquilatero t = new trianguloEquilatero(3);
            Console.WriteLine("Figura: " + t.getNome() + "\n" + "Area: " + t.getArea() + "\n" + "Perimetro: " + t.getPerimetro() + "\n" + "Altura: " + t.getAltura());
            Console.WriteLine("---------------------------------------------------------------------");

            return 0;
        }


    }
}
