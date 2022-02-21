using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float importe, total;

            Console.WriteLine("Ingrese el importe: ");
            importe = float.Parse(Console.ReadLine());

            if (importe < 1000)
            {
                Console.WriteLine("El importe final es de: " + importe);

            }else if (importe >= 1000 && importe < 5000)
            {
                total = importe - (importe * 0.01f);
                Console.WriteLine("El importe final es de: " + total);

            }else if (importe >= 5000)
            {
                total = importe - (importe * 0.18f);
                Console.WriteLine("El importe final es de: " + total);
            }
                
        }
    }
}
