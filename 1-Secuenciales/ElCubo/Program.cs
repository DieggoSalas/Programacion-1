using System;

namespace ElCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            resultado = numero * numero * numero;

            Console.WriteLine("Su elevacion al cubo es: " + resultado);
        }
    }
}
