using System;

namespace uri_1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int PROD, a, b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            PROD = a * b;

            Console.WriteLine("PROD = " + PROD);
        }
    }
}
