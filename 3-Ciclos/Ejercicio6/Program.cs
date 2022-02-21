using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int primos = 0;
            for (int x = 0; x < 10; x++)
            {
                int n = 0, con = 0;
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                for (int y = 1; y <= n; y++)
                {
                    if (n % y == 0)
                    {
                        con++;
                    }
                }
                if (con == 2)
                {
                    primos++; 
                }
            }
            Console.WriteLine(primos + " son los numeros primos de la lista.");
        }
    }
}
