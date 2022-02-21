using System;

namespace Kilometros
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometros, velocidad, tiempo;

            Console.WriteLine("Ingrese los kilometros recorridos: ");
            kilometros = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad promedio del vehiculo: ");
            velocidad = int.Parse(Console.ReadLine());

            tiempo = kilometros / velocidad;

            Console.WriteLine("El tiempo aproximado del viaje fue de: " + tiempo);


        }
    }
}
