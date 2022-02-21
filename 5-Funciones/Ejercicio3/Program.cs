using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float n = 0, con = 0, acu = 0, primos = 0;
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                if (primo(n))
                {
                    con++;
                    acu += n;
                }
                Console.WriteLine("Ingrese otro numero: ");
                n = int.Parse(Console.ReadLine());
            }
            primos = acu / con;
            Console.WriteLine("El promedio de numeros primos es de: " + primos);
        }
        static bool primo(float n1)
        {
            float con = 0;
            for (int x = 1; x <= n1; x ++)
            {
                if (n1 % x == 0)
                {
                    con ++;
                }
            }
            if (con == 2)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
