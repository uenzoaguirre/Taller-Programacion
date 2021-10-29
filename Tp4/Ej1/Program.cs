using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Fachada fachada = new Fachada();
            Console.WriteLine("Ingrese dividendo");
            int pDividendo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese divisor");
            int pDivisor = Convert.ToInt32(Console.ReadLine());
            try 
            {
                fachada.Dividir(pDividendo, pDivisor);
            }
            
            catch(Exception excepcion)
            {
                Console.WriteLine("Error:{0}",excepcion.Message);
            }
        }
    }
}
