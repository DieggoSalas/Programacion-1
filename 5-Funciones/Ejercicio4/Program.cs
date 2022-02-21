using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, tipo = 0;
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            PositivoNegativoCero(n, ref tipo);
            Console.WriteLine("El estado del numero es: " + tipo);
        }
        static void PositivoNegativoCero(int valor, ref int referencia)
        {
            if (valor > 0)
            {
                referencia = 1;
            }else if (valor == 0)
            {
                referencia = 0;
            }else
            {
                referencia = -1;
            }
        }
    }
}
