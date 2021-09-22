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

        public string ComenzarPartida(string NombreJugador, int EdadJugador , int CantidadMaximaErrores)
        {
            string Id = Guid.NewGuid().ToString();
            string palabra = this.iRepoPalabras.ObtenerAleatoriamente();
            Partida partida = new Partida(NombreJugador, EdadJugador, Id, palabra, CantidadMaximaErrores);
            this.iRepoPartidas.Agregar(partida);
            return Id;

        }

        public List<CaracterIndice> ValidarLetra(string pId, char pLetra)
        {
            Partida partida = this.iRepoPartidas.ObtenerPorId(pId);
            return partida.VerificarLetra(pLetra);
            
        }

        public bool GanoPartida(string pId)
        {
            Partida partida = this.iRepoPartidas.ObtenerPorId(pId);
            return partida.VerificarSigano();
        }

        public void TerminarPartida(string pId)
        {
            Partida partida = this.iRepoPartidas.ObtenerPorId(pId);
            partida.Finalizar();
        }

        public int CantidadCaracteresPalabra(string pId)
        {
            Partida partida = this.iRepoPartidas.ObtenerPorId(pId);
            return partida.Palabra.Length;
        }

        public bool VerificarSiperdio(string pId)
        {
            Partida partida = this.iRepoPartidas.ObtenerPorId(pId);
            return partida.VerificarSiperdio();
        }

        public int Errores(string pId)
        {
            Partida partida = this.iRepoPartidas.ObtenerPorId(pId);
            return partida.Errores;
        }

        public List<Partida> ListadoMejoresPartidas(int pCantidad)
        {
            List<Partida> TodasPartidas = this.iRepoPartidas.ObtenerTodas();
            TodasPartidas = TodasPartidas.FindAll(Partida => Partida.HaGanado);
            TodasPartidas.Sort((p1, p2) => p1.TiempoEmpleado.CompareTo(p2.TiempoEmpleado));
            int Total = Math.Min(TodasPartidas.Count, pCantidad);
            return TodasPartidas.GetRange(0, Total); 

        }
    }

}