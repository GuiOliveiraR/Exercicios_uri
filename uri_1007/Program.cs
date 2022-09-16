using System;

namespace uri_1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());



            //Fórmula
            int dive = (A * B - C * D);



            Console.WriteLine("DIFERENCA = " + dive);

        }
    }
}
