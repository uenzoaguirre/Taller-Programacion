using System;

namespace Ej4
{
    class Program
    {
        /// <summary>
        /// Muestra los años bisiestos entre 1900 y 2021
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Los años bisiestos son: ");
            int inicio = 1900;
            int fin = 2021;
            //Otra forma de hacerlo, sumando cada 4 años
            /* for (int año = inicio; año <= fin; año = año+4)
             {
                 Console.WriteLine(año);
             }*/

            //Realiza el cálculo con el módulo de 4 
            for (int año = inicio; año <= fin; año++)
            {
                if (año % 4 == 0)
                {
                    Console.WriteLine(año);
                }
            }
        }
    }
}
