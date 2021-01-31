using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Conversor de kilometros";
            Double Kilometros, metros, yardas, varas;


            Console.WriteLine("Digite la cantidad de kilometros que desea convertir: ");
            Kilometros = Double.Parse(Console.ReadLine());

            metros = Kilometros * 1000;
            yardas = metros * 1.09361;
            varas = metros * 1.1963;

            Console.WriteLine("Convertidos a metros: " + metros);
            Console.WriteLine("Convertidos a yardas: " + yardas);
            Console.WriteLine("Convertidos a varas: " + varas);
            Console.ReadKey();
        }
    }
}
