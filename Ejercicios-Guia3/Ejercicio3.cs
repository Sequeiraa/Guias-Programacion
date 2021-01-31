using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x, r;

            Console.WriteLine("Digite el valor de r");
            r = Double.Parse(Console.ReadLine());

            x = (4 *Math.PI * Math.Pow(r, 2)) / 3;
            Console.WriteLine("Este es el valor de x " + x);

            Console.ReadKey();
        }
    }
}
