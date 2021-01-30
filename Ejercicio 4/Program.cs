using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x1, y1, x2, y2, p;

            Console.WriteLine("Digite el valor de x1");
            x1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de y1");
            y1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de x2");
            x2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de y2");
            y2 = Double.Parse(Console.ReadLine());

            p = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);

            Console.WriteLine("El resultado de la ecuación es: " + p);
            Console.ReadKey();
        }
    }
}
