using System;

namespace Ejercicio1
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
            int max = vector[0], pos = 1;
            for (int x = 0; x < 10; x++)
            {
                if (vector[x] > max)
                {
                    max = vector[x];
                    pos = x + 1;
                }
            }
            Console.WriteLine("El numero maximo del vector es el " + max);
            Console.WriteLine("Y su posicion es el " + pos);
        }
    }
}
