using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class EvaluadorSueldo : IEvaluador
    {
        double iSueldoMinimo;

        public EvaluadorSueldo(double pSueldoMinimo)
        {
            this.iSueldoMinimo = pSueldoMinimo;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return pSolicitud.Cliente.Empleo.Sueldo >= iSueldoMinimo;
        }
    }
}