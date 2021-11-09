using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class EvaluadorCantidadCuotas: IEvaluador
    {
        int iCantidadMaximaCuotas;
        public EvaluadorCantidadCuotas(int pCantidadMaxima)
        {
            this.iCantidadMaximaCuotas = pCantidadMaxima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return pSolicitud.CantidadCuotas <= this.iCantidadMaximaCuotas;
        }


    }
}