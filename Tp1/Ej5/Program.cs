using System;

namespace Ej5
{
    class Program

    {
        /// <summary>
        /// Muestra la serie de nros de Fibonacci hasta el nro N ingresado
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // para mostrar el i-esimo nro sumamos i-2 con i-1
            Console.Write("Ingrese N (numero hasta el que quieras calcular): ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci: ");
            Console.WriteLine(0);
            Console.WriteLine(1);
            int valor1 = 0;
            int valor2 = 1;
            int fibonacci = 0;
            for (int valor = 0 ; valor < N ; valor++)
            {

                fibonacci = (valor1 + valor2);
                Console.WriteLine (fibonacci);
                valor1 = valor2;
                valor2 = fibonacci;
            }
        }
    }
}
