using System;
using System.Collections.Generic;

namespace Aplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var filtros = new Dictionary<string, string>() { { "Nombre", "ROWLING" } };
            var autores = ServiceAutoresOpenLibrary.Buscar(filtros);
            Console.WriteLine("Tamaños de lista: {0}", autores.Count);
            var filtrosEdiciones = new Dictionary<string, string>() { { "ISBN", "9780140328721" } };
            var edicion = ServiceEdicionesOpenLibrary.Buscar(filtrosEdiciones);
            Console.WriteLine("Encontrado? : {0}", (edicion != null ? "Sí" : "No"));

            var filtrosObras = new Dictionary<string, string>() { { "Autor", "Brandon Sanderson" }, { "Titulo", "Mistborn" } };
            var obras = ServicesObrasOpenLibrary.Buscar(filtrosObras);
            Console.WriteLine("Tamaños de lista: {0}", obras.Count);


        }

    }
}
