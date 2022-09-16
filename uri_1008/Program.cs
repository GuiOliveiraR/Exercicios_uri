using System;
using System.Globalization;

namespace uri_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double ht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //formula
            double salario = ht * valor;



            Console.WriteLine("NUMBER = " + n);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
