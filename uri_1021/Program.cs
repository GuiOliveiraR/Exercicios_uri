using System;
using System.Globalization;

namespace uri_1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            int quociente, resto, nota, moeda;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            resto = (int)(N * 100 + 0.5);

            Console.WriteLine("NOTAS: ");

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " notas(s) de R$ " + nota + " .00");
            resto = resto % (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " notas(s) de R$ " + nota + " .00");
            resto = resto % (nota * 100);


            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " notas(s) de R$ " + nota + " .00");
            resto = resto % (nota * 100);


            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " notas(s) de R$ " + nota + " .00");
            resto = resto % (nota * 100);


            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " notas(s) de R$ " + nota + " .00");
            resto = resto % (nota * 100);


            nota = 1;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " notas(s) de R$ " + nota + " .00");
            resto = resto % (nota * 100);


            Console.WriteLine("MOEDAS: ");

            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$1.00 ");
            resto = resto % moeda;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$0.50 ");
            resto = resto % moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$0.50 ");
            resto = resto % moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$0.50 ");
            resto = resto % moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$0.50 ");
            resto = resto % moeda;

            moeda = 1;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$0.50 ");
            resto = resto % moeda;

        }
    }
}
