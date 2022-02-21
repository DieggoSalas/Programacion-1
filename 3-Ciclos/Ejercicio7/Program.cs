using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int TN = 0, NI = 0,Gordn = 0,min = 0;
            double Porc = 0, max = 0,Gmax = 0;
            bool desor = true;
            
            for (int x = 0; x < 5; x++)
            {
                int n;
                Console.WriteLine("Ingrese un numero y/o finalize con un 0: ");
                n = int.Parse(Console.ReadLine());
                min = n;
                while (n != 0)
                {
                    TN++;
                    if (n % 2 != 0)
                    {
                        NI++;
                    }
                    if (n < min)
                    {
                        min = n;
                    }else
                    {
                        desor = false;
                    }
                    Console.WriteLine("Ingrese un numero y/o finalize con un 0: ");
                    n = int.Parse(Console.ReadLine());                     
                }
                Porc = NI * 100 / TN;
                if (Porc > max)
                {
                    max = Porc;
                    Gmax++;
                }
                if (desor)
                {
                    Gordn++;
                }
            }
            Console.WriteLine("El grupo Nº " + Gmax + " contiene el mayor porcentaje de nros impares.");
            Console.WriteLine(Gordn + " grupos estan formados por numeros de manera decreciente.");
        }
    }
}