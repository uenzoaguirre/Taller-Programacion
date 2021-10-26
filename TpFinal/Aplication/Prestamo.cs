using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class Prestamo
    {
        // FIX:     1. pFechaDevolucion no va en el constructor
        //          2. fechaDevolcion inicializar en null en el diagrama
        //          3. Agregar el parametro ejemplar al ctor
        //          4. Agregar usuarioSolicitante al ctor del diagrama
        public Prestamo(int pId, DateTime pFechaPrestamo, DateTime pFechaVencimiento, Ejemplar pEjemplar, Usuario pUsuarioSolicitante)
        {
            this.id = pId;
            this.fechaPrestamo = pFechaPrestamo;
            this.fechaVencimiento = pFechaVencimiento;
            this.ejemplar = pEjemplar;
            this.usuarioSolicitante = pUsuarioSolicitante;
        }

        public DateTime FechaPrestamo { get { return fechaPrestamo; } }

        public DateTime? FechaDevolucion { get { return fechaDevolucion; } }

        public DateTime FechaVencimiento { get { return fechaVencimiento; } }

        public Usuario Solicitante { get { return usuarioSolicitante; } }

        int id;

        DateTime fechaPrestamo;

        DateTime? fechaDevolucion = null;

        DateTime fechaVencimiento;

        Ejemplar ejemplar;

        Usuario usuarioSolicitante;
    }
}