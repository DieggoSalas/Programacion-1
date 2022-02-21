using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero: ");
                vector[x] = int.Parse(Console.ReadLine());
            }
            int acu = 0, promedio = 0;
            for (int x = 0; x < 10; x++)
            {
                acu += vector[x];
            }
            promedio = acu / 10;
            Console.WriteLine("El promedio del vector es: " + promedio);
            for (int x = 0; x < 10; x++)
            {
                if (vector[x] > promedio)
                {
                    Console.WriteLine("El valor " + vector[x] + " es mayor al promedio.");
                }
            }
        }
    }
}
