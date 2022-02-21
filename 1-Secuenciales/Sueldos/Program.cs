using System;

namespace Sueldos
{
    class Program
    {
        static void Main(string[] args)
        {
            float facturacion, comision, sueldofinal;

            Console.WriteLine("Ingrese el total facturado: ");
            facturacion = float.Parse(Console.ReadLine());

            comision = facturacion * 0.05f;
            sueldofinal = comision + 15000;

            Console.WriteLine("Su sueldo final es: " + sueldofinal);
        }
    }
}
