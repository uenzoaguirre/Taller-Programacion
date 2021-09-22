using System;
using System.Collections.Generic;
namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();
            int Opcion = 3;
            while (Opcion != 0)
            {
                Console.WriteLine("Ingrese una opcion: ");
                Console.WriteLine("1. Jugar una partida 2. Listado de las cinco mejores partidas 3. Presione 0 para salir");
                Opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (Opcion == 1)
                {
                    Jugar(fachada);
                }

                else if (Opcion == 2)
                {
                    Listar5Mejores(fachada);
                }
                Console.ReadLine();
            }


        }
        static void Listar5Mejores(Fachada fachada)
        {
            var ListaMejores = fachada.ListadoMejoresPartidas(5);
            foreach (var partida in ListaMejores)
            {
                Console.WriteLine("Nombre:{0} , Edad:{1} , Tiempo empleado:{2} , Errores Cometidos:{3} , Palabra:{4}", partida.Nombre, partida.Edad, partida.TiempoEmpleado, partida.Errores, partida.Palabra);

            }
        }
        static void Jugar(Fachada fachada)
        {
            bool Gano = false;
            bool Perdio = false;

            Console.WriteLine("Ingrese su nombre: ");
            string NombreJugador = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingrese su edad: ");
            int EdadJugador = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            string Id = fachada.ComenzarPartida(NombreJugador, EdadJugador, 10);
            string PalabraGuiones = new String('_', fachada.CantidadCaracteresPalabra(Id));
            List<CaracterIndice> Acertados = new List<CaracterIndice>();
            while (!Gano && !Perdio)
            {
                Console.WriteLine("Errores:{0}", fachada.Errores(Id));
                Console.WriteLine(PalabraGuiones);
                foreach (var CaracterIndice in Acertados)
                {
                    Console.SetCursorPosition(CaracterIndice.Indice, 1);
                    Console.Write(CaracterIndice.Caracter);
                }
                Console.WriteLine();
                Console.WriteLine("Ingrese una letra: ");
                string Letra = Console.ReadLine().ToLower();
                Console.Clear();
                if (Letra.Length > 0)
                {
                    Acertados = fachada.ValidarLetra(Id, Letra[0]);
                }
                Gano = fachada.GanoPartida(Id);
                Perdio = fachada.VerificarSiperdio(Id);
            }
            fachada.TerminarPartida(Id);
            if (Gano)
            {
                Console.WriteLine("Felicitaciones, Ganaste");
            }
            else
            {
                Console.WriteLine("Fracasaste! Volve a intentarlo");
            }
        }
    }
}
