using System;
using System.Globalization;

namespace uri_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int autonomia = 12;
            float horasPercorridas, velocidadeMedia, gastoCombustível;



            horasPercorridas = float.Parse(Console.ReadLine());
            velocidadeMedia = float.Parse(Console.ReadLine());



            gastoCombustível = (velocidadeMedia / autonomia) * horasPercorridas;



            Console.WriteLine(gastoCombustível.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
