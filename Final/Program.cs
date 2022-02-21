using System;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializo las variables.
            int N = 0, mayor = 0, cant = 0, menor = 0;
            bool BM = false, Bm = false;
            //Solicito un ingreso de datos. 
            Console.WriteLine("Ingrese un numero: ");
            N = int.Parse(Console.ReadLine());
            while (N != 0)
            {
                if (N % 2 == 0)//Discrimino los numeros por pares e impares.
                {
                    if (BM == false)
                    {
                        mayor = N;
                        BM = true;   
                    }else if (N > mayor)
                    {
                        mayor = N;//Guardo el mayor de los pares. 
                    }   
                }else
                {
                    cant++;//Guardo la cantidad de impares. 
                }
                Primos(ref N);
                if (Bm == false)
                {
                    menor = N;
                    Bm = true;    
                }else if (N < menor)
                {
                    menor = N;//Guardo el menor de los primos.
                }
                Console.WriteLine("Ingrese otro numero: ");
                N = int.Parse(Console.ReadLine());
            }
            //Finalmente se devuelven los resulados.
            Console.WriteLine("El mayor de los numeros pares es: " + mayor);
            Console.WriteLine("La cantidad de numeros impares son: " + cant);
            Console.WriteLine("Y el menor de los numeros primos es: " + menor);
        }
        //Aqui la funcion que evalua si un nro es primo o no.
        static bool Primos(ref int n)
        {
            int con = 0;
            for (int x = 1; x <= n; x++)
            {
                if (n % x == 0)
                {
                    con++;
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