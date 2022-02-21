using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            Console.WriteLine("Ingrese el 1er numero: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 2do numero: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 3er numero: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 4to numero: ");
            D = int.Parse(Console.ReadLine());

            if (A > B && B > C && C > D)
            {
                Console.WriteLine("Los numeros estan ordenados de manera decreciente.");
            }else
            {
                Console.WriteLine("Los numeros no estan ordenados.");
            }
        }
    }
}
