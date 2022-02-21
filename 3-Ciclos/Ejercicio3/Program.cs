using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 0, con = 0, acu = 0, promedio;
            for (int x = 1; x <= 20; x ++)
            {
                Console.WriteLine("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());
                if (edad > 18)
                {
                    con ++;
                    acu += edad;
                }

            }
            promedio = acu / con;
            Console.WriteLine("El promedio de edades mayores a 18 es: " + promedio);
        }
    }
}
