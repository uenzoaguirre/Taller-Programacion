using System;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los años bisiestos son: ");
            int inicio = 1900;
            int fin = 2021;
            /* for (int año = inicio; año <= fin; año = año+4)
             {
                 Console.WriteLine(año);
             }*/

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
