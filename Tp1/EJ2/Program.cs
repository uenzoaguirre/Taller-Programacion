using System;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            CicloPara();
        }
        /// <summary>
        /// Solicita los límites sup e inf y luego calcula la sumatoria y el promedio
        /// entre los numeros del intervalo incluyendo los extremos
        /// </summary>
        static void CicloPara()
        {
            Console.Write("Ingrese limite inferior: ");
            int NumInf = Convert.ToInt32(Console.ReadLine()); //ToInt32 para convertir la cadena en nro entero
            Console.Write("Ingrese limite superior: ");
            int NumSup = Convert.ToInt32(Console.ReadLine());

            int suma = 0;
            decimal prom = (NumInf + NumSup) / 2m;
            for (int I = NumInf; I <= NumSup; I++ )
            {
                suma = suma + I;
            }
            Console.WriteLine("La suma entre el NumInf y NumSup es: {0}", suma);
            Console.WriteLine("El promedio es: {0}", prom);
            Console.WriteLine("El limite inferior es: {0}", NumInf);
            Console.WriteLine("El limite superior es: {0}", NumSup);
        }
        /// <summary>
        /// Solicita los límites sup e inf y luego calcula la sumatoria y el promedio
        /// entre los numeros del intervalo incluyendo los extremos
        /// </summary>
        static void CicloWhile()
        {
            Console.Write("Ingrese limite inferior: ");
            int NumInf = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese limite superior: ");
            int NumSup = Convert.ToInt32(Console.ReadLine());

            decimal prom = (NumInf + NumSup) / 2m; //La m es para tratar al 2 como decimal
            int I = NumInf;
            int suma = 0;
            while  (I <= NumSup)
            {
               suma = suma + I;
               I++;
            }
            Console.WriteLine("La suma entre el NumInf y NumSup es: {0}", suma);
            Console.WriteLine("El promedio es: {0}", prom);
            Console.WriteLine("El limite inferior es: {0}", NumInf);
            Console.WriteLine("El limite superior es: {0}", NumSup);

        }
    }
}
