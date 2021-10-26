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
        public Prestamo(int pId, DateTime pFechaPrestamo, DateTime pFechaVencimiento) {
            this.id = pId;
            this.fechaPrestamo = pFechaPrestamo;
            this.fechaVencimiento = pFechaVencimiento;
        }

        public DateTime FechaPrestamo { get { return fechaPrestamo; } }

        public DateTime? FechaDevolucion { get { return fechaDevolucion; } }

        public DateTime FechaVencimiento { get { return fechaVencimiento; } }

        int id;

        DateTime fechaPrestamo;

        DateTime? fechaDevolucion = null;

        DateTime fechaVencimiento;
    }
}