using System;

namespace Ejercicio4
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

            if (A < B && A < C && A < D)
            {
                Console.WriteLine("El menor de ellos es: " + A);
            }else if (B < A && B < C && B < D)
            {
                Console.WriteLine("El menor de ellos es: " + B);
            }else if (C < A && C < B && C< D)
            {
                Console.WriteLine("El menor de ellos es: " + C);
            }else if (D < A && D < B && D < C)
            {
                Console.WriteLine("El menor de ellos es: " + D);
            }
        }
    }
}
