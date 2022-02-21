using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cadena = new char[50];
            char letra;
            int indice = 0;
            Console.WriteLine("Ingrese un caracter: ");
            letra = char.Parse(Console.ReadLine());
            while (letra != '.' && indice < 50)
            {
                cadena[indice] = letra;
                Console.WriteLine("Ingrese otro caracter: ");
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
            for (int x = 0; x < 50; x++)
            {
                if (cadena[x] == 'o')
                {
                    cadena[x] = 'i';
                } 
            }
            cadena[indice] = '\0';
            Console.WriteLine("La cadena final es: ");
            indice = 0;
            while (cadena[indice] != '\0')
            {
                 Console.Write(cadena[indice]);
                 indice++;
            }
        } 
    }
}
