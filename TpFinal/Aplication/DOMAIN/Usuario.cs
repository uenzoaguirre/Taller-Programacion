using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class Usuario
    {
        public bool EsAdministrador { get; set; }

        public int Id { get; set; }
        public int Dni
        {
            get; set;
        }

        public string NombreUsuario
        {
            get; set;

        }

        public string Password
        {
            get; set;

        }

        public string Mail
        {
            get; set;

        }
        public DateTime FechaRegistro
        {
            get; set;

        }

        public int Puntaje
        {
            get; set;
        }

        public List<Prestamo> Prestamos
        {
            get; set;
        }
    }
}