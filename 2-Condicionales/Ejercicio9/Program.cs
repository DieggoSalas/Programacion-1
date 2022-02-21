using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            
            Console.WriteLine("Ingrese el primer numero: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            C = int.Parse(Console.ReadLine());

            if (A + B > B * C)
            {
                Console.WriteLine("La operacion es valida!");
            }else
            {
                Console.WriteLine("La operacion es invalida.");
            }
        }
    }
}
