using System;
using System.Collections.Generic;

namespace Aplication
{
    class Program
    {
        static void Main(string[] args)
        {
           var filtros = new Dictionary<string,string>(){{"Nombre","ROWLING"}};
           var autores = ServiceAutoresOpenLibrary.Buscar(filtros);
           Console.WriteLine("Tamaños de lista: {0}",autores.Count);
           var filtrosEdiciones = new Dictionary<string, string>() { { "ISBN", "9780140328721" } };
           var ediciones = ServiceEdicionesOpenLibrary.Buscar(filtrosEdiciones);
           Console.WriteLine("Tamaños de lista: {0}",ediciones.Count);

            
        }

    }
}
