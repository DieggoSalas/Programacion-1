using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int max = 0;

            for (int x = 0; x < 10; x ++)
            {
                Console.WriteLine("Ingrese un numero: ");
                N = int.Parse(Console.ReadLine());

                if (N > max)
                {
                    max = N; 
                }
            }

            Console.WriteLine("El numero maximo es: " + max);
        }
    }
}
