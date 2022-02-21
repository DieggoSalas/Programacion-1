using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            float litros;
            
            Console.WriteLine("Ingrese la cantidad de litros:");
            litros = float.Parse(Console.ReadLine());

            if (litros > 500)
            {
                litros *= 0.75f;
                Console.WriteLine("El importe total a pagar es de: " + litros);

            }else if (litros <= 500 && litros > 300)
            {
               litros *= 0.85f;
                Console.WriteLine("El importe total a pagar es de: " + litros);

            }else if (litros <= 300 && litros > 100)
            {
               litros *= 0.90f;
                Console.WriteLine("El importe total a pagar es de: " + litros);

            }else
            {
                Console.WriteLine("El importe total a pagar es de: " + litros);
            }
        }
    }
}
