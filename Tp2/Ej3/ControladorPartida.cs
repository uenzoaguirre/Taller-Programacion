using System;
using System.Collections.Generic;
using System.Linq;

namespace Ej3
{
    class ControladorPartida
    {
        RepositorioPalabras iRepoPalabras;
        RepositorioPartida iRepoPartidas;

        AdministradorPalabras iAdminPalabras;

        public ControladorPartida()
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
    }
}