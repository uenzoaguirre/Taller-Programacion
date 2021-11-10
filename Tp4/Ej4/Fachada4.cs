using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class Fachada
    {
        EvaluadorAntiguedadLaboral eAntiguedadLaboral;
        EvaluadorCantidadCuotas eCantCuotas;
        EvaluadorEdad eEdad;

        EvaluadorMonto eMonto;
        EvaluadorSueldo eSueldo;
        public bool EvaluarEdad(SolicitudPrestamo pSolicitud)
        {
            return eEdad.EsValida(pSolicitud);
        }

        public bool EvaluarAntiguedadLaboral(SolicitudPrestamo pSolicitud)
        {
            return eAntiguedadLaboral.EsValida(pSolicitud);
        }

        public bool EvaluarCuotas(SolicitudPrestamo pSolicitud)
        {
            return eCantCuotas.EsValida(pSolicitud);
        }

        public bool EvaluarMonto(SolicitudPrestamo pSolicitud)
        {
            return eMonto.EsValida(pSolicitud);
        }

        public bool EvaluarSueldo(SolicitudPrestamo pSolicitud)
        {
            return eSueldo.EsValida(pSolicitud);
        }

        public bool EvaluarPrestamo(SolicitudPrestamo pSolicitud)
        {
            if  (EvaluarEdad(pSolicitud) && EvaluarAntiguedadLaboral(pSolicitud) && EvaluarCuotas(pSolicitud) && EvaluarMonto(pSolicitud) && EvaluarSueldo(pSolicitud))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
