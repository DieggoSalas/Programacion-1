using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, NG = 0;
            Console.WriteLine("Ingrese un numero de lista o finalize con un negativo: ");
            x = int.Parse(Console.ReadLine());
            while (x >= 0)
            {
                int n;
                Console.WriteLine("Ingrese un numero o finalize con un 0: ");
                n = int.Parse(Console.ReadLine());
                int u = 0;
                while (n != 0)
                {
                    u++;
                    Console.WriteLine("Ingrese un numero o finalize con un 0: ");
                    n = int.Parse(Console.ReadLine());
                }
                NG++;
                Console.WriteLine("La lista Nº " + NG + " tiene un total de: " + u + " numeros.");
                Console.WriteLine("Ahora ingrese otro numero para la siguiente lista o finalize con un negativo: ");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Programa finalizado correctamente.");
        }
    }
}
