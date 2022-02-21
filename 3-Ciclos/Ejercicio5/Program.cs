using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, maxP = 0, minI = 0;
            int BP = 0, BI = 0;

            for (int x = 0; x < 20; x ++)
            {
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    BP++;
                    if (BP == 1)
                    {
                        maxP = n;
                    }else if (n > maxP)
                    {
                        maxP = n;
                    }
                }else
                {
                    BI++;
                    if (BI == 1)
                    {
                        minI = n;
                    }else if (n < minI)
                    {
                        minI = n;
                    }
                }
            }

            Console.WriteLine("El maximo de los numeros pares es: " + maxP);
            Console.WriteLine("Y el minimo de los numero impares es: " + minI);
            
        }
    }
}
