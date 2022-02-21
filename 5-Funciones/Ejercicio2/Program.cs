using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0,con = 0;
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                par(ref n);
                if (n == 1)
                {
                    con++;
                }
            }
            Console.WriteLine("De los 20 numeros solo " + con + " son pares.");
        }
        static int par(ref int n1)
        {
            if (n1 % 2 == 0)
            {
                n1 = 1;
            }else
            {
                n1 = 0;
            }
            return n1;
        }
    }
}
