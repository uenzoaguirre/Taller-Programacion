using System;

namespace Ej_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese numero hasta el que quiera sumar: "); // Lo hacemos de esta forma a que al elegir un numero mayor va hacer mas preciso el resultado
            int Num = Convert.ToInt32(Console.ReadLine());

            //double numerador = 0;
            //double denominador = 0;
            double sumatoria = 0;
            for (int value = 0; value < Num; value++)
            {
               // numerador = Math.Pow(-1,value);
                // denominador = 2 * value + 1;
                sumatoria = (Math.Pow(-1, value) / (2 * value + 1)) + sumatoria;
            }
            Console.WriteLine("El numero pi: {0}", sumatoria*4);
        }
    }
}
