using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Porcentaje de aciertos";
            int CantidadPreg, Contestadas, Porcentaje;

            Console.WriteLine("Digite la cantidad de preguntas ");
            CantidadPreg = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de preguntas contestadas ");
            Contestadas = int.Parse(Console.ReadLine());

            Porcentaje = (Contestadas * 100) / CantidadPreg;

            if (Porcentaje >= 90)
            {
                Console.WriteLine("\nTu nivel es máximo.");
                Console.WriteLine($"Tu porcentaje es del {Porcentaje}%"); 
            }
            else if (Porcentaje <= 75 && Porcentaje < 90)
            {
                Console.WriteLine("\nTu nivel es medio.");
                Console.WriteLine($"Tu porcentaje es del {Porcentaje}%");
            }
            else if (Porcentaje >= 50 && Porcentaje <75)
            {
                Console.WriteLine("\nTu nivel es regular.");
                Console.WriteLine($"Tu porcentaje es del {Porcentaje}%");
            }
            else if(Porcentaje < 50)
            {
                Console.WriteLine("\nFuera de nivel.");
                Console.WriteLine($"Tu porcentaje es del {Porcentaje}%");
            }
            Console.ReadKey();
        }
    }
}
