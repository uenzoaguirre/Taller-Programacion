using System;
using System.Collections.Generic;
using Aplication.LOG; 

namespace Aplication
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager.initialize();
            var filtros = new Dictionary<string, string>() { { "Nombre", "ROWLING" } };
            var autores = ServiceAutoresOpenLibrary.Buscar(filtros);
            LogManager.GetLogger().Info("Tamaños de lista: {0}", autores.Count);
            var filtrosEdiciones = new Dictionary<string, string>() { { "ISBN", "9780140328721" } };
            var edicion = ServiceEdicionesOpenLibrary.Buscar(filtrosEdiciones);
            LogManager.GetLogger().Info("Encontrado? : {0}", (edicion != null ? "Sí" : "No"));

            var filtrosObras = new Dictionary<string, string>() { { "Autor", "Brandon Sanderson" }, { "Titulo", "Mistborn" } };
            var obras = ServicesObrasOpenLibrary.Buscar(filtrosObras);
            LogManager.GetLogger().Info("Tamaños de lista: {0}", obras.Count);
            LogManager.shutdown();


        }

    }
}
