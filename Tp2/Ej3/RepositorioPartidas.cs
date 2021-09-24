using System;
using System.Collections.Generic;

namespace Ej3
{
    class RepositorioPartidas
    {

        List<Partida> iListaPartidas;
        public RepositorioPartidas()
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

        public Partida ObtenerPorId(string pId)
        {
            return this.iListaPartidas.Find(partida => partida.Id == pId);
        }
    }
}