using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int art = 0, cant = 0, mt = 0;
            Console.WriteLine("Ingrese el precio del articulo: ");
            art = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cant = int.Parse(Console.ReadLine());
            mt = producto(art, cant);
            Console.WriteLine("El monto total a pagar es de: " + mt);
        }

        static int producto(int n1, int n2)
        {
            int r;
            r = n1 * n2;
            return r; 
        }
    }
}
