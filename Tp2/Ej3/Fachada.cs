using System;
using System.Collections.Generic;
using System.Linq;

namespace Ej3
{
    class Fachada
    {
        RepositorioPalabras iRepoPalabras;
        RepositorioPartida iRepoPartidas;

        AdministradorPalabras iAdminPalabras;

        public Fachada()
        {
            this.iRepoPalabras = new RepositorioPalabras();
            this.iRepoPartidas = new RepositorioPartida();
            //this.iAdminPalabras = new AdminsitradorPalabras();

        }
        public List<Partida> ListadoDeMejoresPartidas(int pCantidad)
        {
            var partidas = this.iRepoPartidas.ObtenerTodas().OrderBy(Partida => Partida.TiempoEmpleado);
            return partidas.Take(pCantidad).ToList();
        }

        public string ComenzarPartida(string NombreJugador, int EdadJugador)
        {
            string Id = Guid.NewGuid().ToString();
            string palabra = this.iRepoPalabras.ObtenerAleatoriamente();
            Partida partida = new Partida(NombreJugador, EdadJugador, Id, palabra);
            this.iRepoPartidas.Agregar(partida);
            return Id;
        }

        public void ValidarLetra(string pId, char pLetra)
        {
            Partida partida = this.iRepoPartidas.ObtenerPorId(pId);
            partida.VerificarLetra(pLetra);
        }

        public bool GanoPartida(string pId)
        {
            Partida partida = this.iRepoPartidas.ObtenerPorId(pId);
            return partida.VerificarSigano();
        }

        public void TerminarPartida(string pId, bool pResultado)
        {
            Partida partida = this.iRepoPartidas.ObtenerPorId(pId);
            partida.Finalizar(pResultado);
        }

        public int CantidadCaracteresPalabra(string pId)
        {
            Partida partida = this.iRepoPartidas.ObtenerPorId(pId);

        }
    }

}