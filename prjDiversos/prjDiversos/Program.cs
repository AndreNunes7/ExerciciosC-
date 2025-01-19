
//Descreva um programa que solicita que o
//usuário digite um número positivo e par.
//O programa deverá verificar a
//consistência do dado digitado e mostrar na
//tela a soma de todos os números pares entre
//zero e o número digitado inclusive!

// Descreva um programa que exiba no monitor os 100 primeiros
// números inteiros múltiplos de 5 e não múltiplos de 3;

// Enviar para dalrangel@yahoo.com.br
// Assunto: DIVERSOS - Nome - RA

public class Diversos
{
    public static int Main(String [] args)
    {
        int c = 0;
        int n = 0;
        do
        {
            n++;
            if (n % 5 == 0 && n % 3 != 0)
            {
              Console.WriteLine("Número: " + n);
              c++;
            }
           
        } while (c <= 100);

        return 0;
    }

    public static int DivisaoPorSubtracao()
    {
        int iNumerador=0;
        int iDenominador=0;

        String? sNumerador;
        String? sDenominador;

        bool ok = false;
        do
        {
            ok = false;
            Console.Write("Digite Numerador:  ");
            sNumerador = Console.ReadLine();
            Console.Write("Digite Denominador:  ");
            sDenominador = Console.ReadLine();

            if (int.TryParse(sNumerador, out iNumerador) &&
                int.TryParse(sDenominador, out iDenominador) &&
                iNumerador >= iDenominador)
            {
                ok=true;
            }           

            if(!ok)
            {
                Console.WriteLine("Dados inválidos");
            }

        } while (!ok);

        int c = 0;

        do 
        {
            iNumerador -= iDenominador;
            c++;
        }
        while (iNumerador >= iDenominador && c < 1000000000);

        Console.WriteLine("Resto: " + iNumerador);
        Console.WriteLine("Valor da divisão: " + c) ;

        return 0;
    }
    public static int EX01()
    {
        int numero = 0;
        String? sNum = "";
        bool ok = false; // ok é um flag.
        do
        {
            ok = false;
            Console.WriteLine("Digite um número positivo e par. Por favor!");
            sNum = Console.ReadLine();
            if (int.TryParse(sNum, out numero))
            {
                if (numero > 0 && numero % 2 == 0)
                {
                    ok = true;
                }
            }
            else
            {
                Console.WriteLine("\nO número digitado é inválido!");
            }
            if (!ok)
            {
                Console.WriteLine("\nO número digitado deve ser positivo e par!");
            }

        } while (!ok);

        int soma = 0;

        for (int i = 2; i <= numero ; i++)
        {
            if (i % 2 == 0) soma += i;
        }

        Console.WriteLine("Soma: " + soma);

        return 0;
    }






}