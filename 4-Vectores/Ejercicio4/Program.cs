using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArtAcu = new int[15];
            int numArt = 0, cantventas = 0;
            for (int x = 0; x < 15; x++)
            {
                ArtAcu[x] = 0;
            }
            Console.WriteLine("Ingrese numero de articulo: ");
            numArt = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantventas = int.Parse(Console.ReadLine());
            while (numArt != 0)
            {
                ArtAcu[numArt - 1] += cantventas;
                Console.WriteLine("Ingrese numero de articulo: ");
                numArt = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida: ");
                cantventas = int.Parse(Console.ReadLine());    
            }
            int maxCant = ArtAcu[0], numMax = 1;
            for (int x = 0; x < 15; x++)
            {
                if (ArtAcu[x] > maxCant)
                {
                    maxCant = ArtAcu[x];
                    numMax = x + 1;
                }
            }
            Console.WriteLine("El producto mas vendido es el " + numArt + " con la cantidad de " + maxCant);
            for (int x = 0; x < 15; x++)
            {
                if (ArtAcu[x] == 0)
                {
                    Console.WriteLine("El producto " + (x + 1) + " no tubo ventas.");
                }
            }
            Console.WriteLine("La cantidad vendida del articulo 10 es " + ArtAcu[9]);
        }
    }
}
