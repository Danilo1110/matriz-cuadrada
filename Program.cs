using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_cuadrada
{
    class Program
    {
        static void Main(string[] args)
        {
            int longitud;
            Console.Write("Ingresa el tamaño del arreglo: ");
            longitud = int.Parse(Console.ReadLine());

                if (longitud >= 1 && longitud <= 10)
                {

                    int[,] matriz = new int[longitud, longitud];
                    for (int f = 0; f < longitud; f++)
                    {
                        for (int c = 0; c < longitud; c++)
                        {
                            matriz[f, c] = f + c + 1;
                            Console.Write("\t" + matriz[f, c] + " ");
                        }
                        Console.WriteLine();
                    }
                }

                else
                {
                    Console.WriteLine("El tamaño de la matriz debe de estar entre los valores 1 y 10");
                }

            Console.WriteLine();
			Console.Write("Presione una tecla para finalizar el programa......");
			Console.ReadKey();

        }
    }
}
