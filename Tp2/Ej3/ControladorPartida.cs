using System;
using System.Collections.Generic;

namespace Ej3
{
    class ControladorPartida
    {
        RepositorioPalabras iRepoPalabras;
        RepositorioPartidas iRepoPartidas;

        AdminsitradorPalabras iAdminPalabras;



        public ControladorPartida()
        {
            this.iRepoPalabras = new RepositorioPalabras();
            this.iRepoPartidas = new RepositorioPartidas();
            //this.iAdminPalabras = new AdminsitradorPalabras();

        }
        public List<Partida> ListadoDeMejoresPartidas(int pCantidad)
        {
            var partidas = this.iRepoPartidas.ObtenerTodas().OrderBy(Partida => Partida.TiempoEmpleado);
            return partidas.Take(pCantidad).ToList();
        }
    }
}