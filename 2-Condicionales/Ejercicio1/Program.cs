using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 10)
            {
                Console.WriteLine("Es mayor a 10");
                
            }else
            {
                Console.WriteLine("No es mayor a 10");
            }
        }
    }
}
