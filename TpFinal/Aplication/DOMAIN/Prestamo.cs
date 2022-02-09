using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class Prestamo
    {
        public Prestamo() { }
    
        public int Id { get; set; }
        public DateTime FechaPrestamo { get; set; }

        public DateTime? FechaDevolucion { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public Usuario Solicitante { get; set; }

        public Ejemplar Ejemplar { get; set; }
    }
}