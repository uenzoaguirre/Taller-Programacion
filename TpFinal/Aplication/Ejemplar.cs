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

        public List<Prestamo> Prestamos { get { return prestamos; } }

        // FIX: Agregar el parametro pPrestamos al ctor
        public Ejemplar(string pCodInventario, DateTime pFechaAlta, List<Prestamo> pPrestamos)
        {
            this.codigoInventario = pCodInventario;
            this.fechaAlta = pFechaAlta;
            this.prestamos = pPrestamos;
        }

        string codigoInventario;

        DateTime fechaAlta;

        // FIX: Agregar al diagrama el nombre de la relacion
        List<Prestamo> prestamos;
    }
}