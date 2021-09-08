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
            Console.Clear();
            Console.Write("Ingrese la cantidad de filas: ");
            int cantidad = int.Parse(Console.ReadLine());

            /* Triangulo de pascal con 0s
            *              0
            * 0.          0 0
            * 1.         0 1 0          
            * 2.        0 1 1 0         
            * 3.       0 1 2 1 0        <--- 3 numeros != 0
            * 4.      0 1 3 3 1 0       <--- 4 numeros != 0
            * 5.     0 1 4 6 4 1 0
            * 6.    0 1 5 10 10 5 1 0    <--- se desfasa por los dos 10
            * 7.   0 1 6 15 20 15 6 1 0

            * 8. 0 0 0 0 0 0 0 0 0 0
            */

            // filaAnterior guarda todos los numeros de la fila anterior
            // +2 porque tenemos un zero a la izquierda y otro a la derecha
            int[] filaAnterior = new int[cantidad + 2];

            // inicializar todos los numeros en 0
            for (int i = 0; i < cantidad + 2; i++)
            {
                filaAnterior[i] = 0;
            }

            // inicialmente la fila anterior es solamente un 1
            filaAnterior[1] = 1;

            // En la primer fila de la piramide tenemos solo 1 numero
            int cantidadNumerosEnFila = 1;
            for (int i = 0; i < cantidad; i++)
            {

                // imprimir los espacios a la izquierda de la fila
                // No tenemos en cuenta que hay numeros de mas de un digito
                for (int z = cantidadNumerosEnFila; z < cantidad * 2; z++)
                {
                    Console.Write(" ");
                }

                // Auxiliar que guarda el siguiente valor
                // ya que este va a ser remplazado
                int auxiliarRemplazado = 0;

                // sumar e imprimir los de la derecha
                for (int j = 0; j < cantidadNumerosEnFila - 1; j++)
                {
                    int res = auxiliarRemplazado + filaAnterior[j + 1];

                    // imprimir el numero
                    Console.Write(" ");
                    Console.Write(res);

                    // guardar en un auxiliar el numero siguiente que vamos a remplazar
                    // asi lo podes usar en la siguiente iteracion
                    auxiliarRemplazado = filaAnterior[j + 1];

                    // guardar el nuevo valor
                    filaAnterior[j + 1] = res;
                }

                Console.WriteLine();

                // Por cada fila que avanzamos se agrega un numero
                cantidadNumerosEnFila++;
            }
        }
    }
}