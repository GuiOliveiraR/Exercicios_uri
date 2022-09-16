using System;
using System.Globalization;

namespace uri_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double sala = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double tv = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            //Fórmula
            double comissao = tv * 0.15;
            double salariofinal = sala + comissao;



            Console.WriteLine("TOTAL = R$ " + salariofinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
