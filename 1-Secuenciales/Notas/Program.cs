using System;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, profinal;

            Console.WriteLine("Ingrese la nota del 1er examen: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del 2do examen: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del 3er examen: ");
            nota3 = int.Parse(Console.ReadLine());

            profinal = nota1 + nota2 + nota3 / 3;

            Console.WriteLine("El promedio final es: " + profinal);
        }
    }
}
