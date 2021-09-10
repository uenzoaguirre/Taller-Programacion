using System;
using System.Collections.Generic;

namespace Ej3
{
    class RepositorioPartida
    {

        List<Partida> iListaPartidas;
        public RepositorioPartida()
        {
            this.iListaPartidas = new List<Partida>();
        }

        public void Agregar(Partida pPartida)
        {
            this.iListaPartidas.Add(pPartida);
        }

        public List<Partida> ObtenerTodas()
        {
            return this.iListaPartidas;
        }

        public void Eliminar (Partida pPartida)
        {
            this.iListaPartidas.Remove(pPartida); 
        }
    }
}