using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            string NombreJugador = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingrese su edad: ");
            int EdadJugador = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Fachada fachada = new Fachada();
            string Id = fachada.ComenzarPartida(NombreJugador, EdadJugador);
            






        }
    }
}
