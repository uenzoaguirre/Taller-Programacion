using System;

namespace Ej_3
{
    class Program
    {
        /// <summary>
        /// Calcula el valor aproximado al nro pi con la fórmula de Leibniz
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Ingrese numero hasta el que quiera sumar: "); // Lo hacemos de esta forma a que al elegir un numero mayor va hacer mas preciso el resultado
            int Num = Convert.ToInt32(Console.ReadLine());
            double sumatoria = 0;
            for (int value = 0; value < Num; value++)
            {
                            sumatoria = (Math.Pow(-1, value) / (2 * value + 1)) + sumatoria;
            }
            Console.WriteLine("El numero pi: {0}", sumatoria*4);
        }
    }
}
