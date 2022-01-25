using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class Ejemplar
    {
        public Ejemplar() { }

        public string CodigoInventario { get; set; }

        public DateTime FechaAlta { get; set; }

        public List<Prestamo> Prestamos { get; set; }
    }
}