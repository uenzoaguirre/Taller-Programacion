using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class Ejemplar
    {
        public string CodigoInventario { get { return codigoInventario; } }

        public DateTime FechaAlta { get { return fechaAlta; } }

        public Ejemplar(string pCodInventario, DateTime pFechaAlta) {
            this.codigoInventario = pCodInventario;
            this.fechaAlta = pFechaAlta;
        }
        
        string codigoInventario;
        
        DateTime fechaAlta;

    }
}