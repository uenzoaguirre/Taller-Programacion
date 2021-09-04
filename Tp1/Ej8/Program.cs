using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;

            Console.Clear();
            Console.Write("Ingrese la cantidad de filas: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            int[,] matriz = new int[cantidad + 1, cantidad + 1];

            // Calcular las filas
            for (int i = 1; i <= cantidad; i++)
            {
                for (int j = 1; j <= cantidad; j++)
                {
                    if ((j == 1) || (i == j))
                    {
                        matriz[i, j] = 1;
                    }
                    else
                    {
                        matriz[i, j] = matriz[i - 1, j] + matriz[i - 1, j - 1];
                    }
                }
            }

            // Mostrar matriz
            int fila = 2;
            for (int i = 1; i <= cantidad; i++)
            {
                int columna = 40 - (i * 2);
                for (int j = 1; j <= cantidad; j++)
                {
                    if (matriz[i, j] != 0)
                    {
                        Console.SetCursorPosition(columna, fila);
                        Console.Write(matriz[i, j]);
                        columna = columna + 4;
                    }
                }

                fila++;
                Console.WriteLine();
            }

        }
    }
}