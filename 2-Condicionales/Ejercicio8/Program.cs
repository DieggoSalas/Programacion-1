using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int CPU, RAM, DR, total = 0;

            Console.WriteLine("Elija la opcion de procesador: ");
            CPU = int.Parse(Console.ReadLine());
            Console.WriteLine("Elija la opcion de memoria RAM: ");
            RAM = int.Parse(Console.ReadLine());
            Console.WriteLine("Desea ampliar el disco? ");
            DR = int.Parse(Console.ReadLine());

            switch (CPU)
            {   case 1:
                    switch (RAM)
                    {   case 1:
                         total = 800;
                        break;
                        case 2:
                         total = 900;
                        break;
                        case 3:
                         total = 1000;
                        break;    
                        default:
                        Console.WriteLine("Opcion Incorrecta.");
                        break;
                    }
                break;  
                case 2:
                    switch (RAM)
                    {   case 1:
                         total = 900;
                        break;
                        case 2:
                         total = 1000;
                        break;
                        case 3:
                         total = 1400;
                        break;    
                        default:
                        Console.WriteLine("Opcion Incorrecta.");
                        break;
                    }
                break;  
                case 3:
                    switch (RAM)
                    {   case 1:
                         total = 1200;
                        break;
                        case 2:
                         total = 1400;
                        break;
                        case 3:
                         total = 2000;
                        break;    
                        default:
                        Console.WriteLine("Opcion Incorrecta.");
                        break;
                    }
                break;
                default:
                Console.WriteLine("Opcion Incorrecta.");
                break; 
            }

            if (DR == 1)
            {
                total += 300;
            }

            Console.WriteLine("El monto total es: " + total);
        }
    }
}
