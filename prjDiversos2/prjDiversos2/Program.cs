

public class Diversos
{
    // Enviar para halrangel@yahoo.com.br
    // Assunto: DIVERSOS - Nome - RA 
    public static int Main(String[] args)
    {
        // 01-) Descreva um programa que gere e
        // exiba no monitor os primeiros 100
        // números inteiros positivos.

        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(i);
        }

        return 0;
    }

    public static int EXDIV()
    {
        // Fazer um programa de divisão por subtração
        // O usuário dgita e numeros. Numerador e
        // denominador

        // Verificar se o numerador é maior que o
        // denominador. enquanto não for. repetir digitação

        int numerador, denominador;

        String? sNumerador, sDenominador;
        bool ok;
        do
        {
            ok = false;
            Console.Write("Digite Numerador: ");
            sNumerador = Console.ReadLine();

            Console.Write("Digite Denominador: ");
            sDenominador = Console.ReadLine();

            if (int.TryParse(sNumerador, out numerador) &&
                int.TryParse(sDenominador, out denominador) )
            {
                if (numerador >= denominador)
                {
                    Console.WriteLine("Resultado: " + numerador/denominador);
                    Console.WriteLine("Resto: " + numerador%denominador);


                    ok =true;

                    int resultado=0;

                    while (numerador >= denominador)
                    {
                       numerador -= denominador;
                       resultado++;
                    }

                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("Resto: " + numerador);
                }
            }  
            
            if (!ok)
            {
                Console.WriteLine("Digitação inválida; Favor digitar novamente");
            }

        } while (!ok);


        return 0;
    }

    public static int EX10()
    {
        // 10-) Calcule e exiba no monitor a soma e o
        // produto dos 123 primeiros termos da série:

        // 1/1 + 1/4 + 1/9 + 1/16 + 1/25...

        double soma = 0F;
        double produto = 1F;

        for (int i = 1; i <= 123; i++)
        {
            soma += 1F / (i * i);
            produto *= 1F / (i * i);
        }

        Console.WriteLine("Soma " + soma);
        Console.WriteLine("Produto: " + produto);

        return 0;

    }
    public static int Ex06 ()
    {
        // 06 Descreva um programa que exiba no monitor
        // a sequência de números: 10, 8, 6, 4, 2,0.

        int valor = 10;

        do
        {
            Console.WriteLine (valor);

            valor -= 2;

        } while (valor >= 0);

        return 0;
    }
    public static int EX04()
    {

        // 04) Descreva um programa que exiba no
        // monitor os 100 primeiros números inteiros,
        // positivos, múltiplos de 5 e não múltiplos de 3.

        int cont = 1;
        int num = 4;

        do
        {
            num++;
            if (num % 5 == 0 && num % 3 != 0)
            {
                Console.WriteLine(cont + ": " + num);
                cont++;
            }

        } while (cont <= 100);


        return 0;
    }
}