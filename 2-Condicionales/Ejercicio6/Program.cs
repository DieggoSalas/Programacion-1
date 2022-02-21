using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, resultado;
            
            Console.WriteLine("Ingrese un numero: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            B = int.Parse(Console.ReadLine());

            if (A > B)
            {
                resultado = A - B;
                Console.WriteLine("El resultado es: " + resultado);
            }else if (A == B)
            {
                resultado = A + B;
                Console.WriteLine("El resultado es: " + resultado);
            }else
            {
                resultado = A * B;
                Console.WriteLine("El resultado es: " + resultado);
            }
        }
    }
}
