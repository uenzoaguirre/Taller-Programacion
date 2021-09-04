using System;

namespace Tp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el radio para obtener el area del circulo y el perimetro de su cincurferencia: ");
            double R = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(R, 2);
            double perimetro = 2 * Math.PI * R;
            Console.WriteLine("Area del circulo: {0}", area);
            Console.WriteLine("Perimetro de circunferencia: {0}", perimetro);
        }
    }
}