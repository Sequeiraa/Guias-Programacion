using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora de área de un triángulo";
            Double A, b, h;

            Console.WriteLine("Digite la base");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la altura");
            h = Double.Parse(Console.ReadLine());

            A = b * h / 2;
            Console.WriteLine("El area es: " + A);

            Console.ReadKey();
        }
    }
}
