using System;

namespace Ejercicio5
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

            if (A > 100)
            {
                Console.WriteLine(A + " es mayor a 100");

            }else if (B > 100)
            {
                Console.WriteLine(B + " es mayor a 100");

            }else if (C > 100)
            {
                Console.WriteLine(C + " es mayor a 100");

            }else if (D > 100)
            {
                Console.WriteLine(D + " es mayor a 100");
            }else
            {
                Console.WriteLine("Ninguno es mayor a 100");
            }
        }
    }
}
