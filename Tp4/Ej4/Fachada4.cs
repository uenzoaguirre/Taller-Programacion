using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class Fachada
    {
        public bool EvaluadorEdad(SolicitudPrestamo pSolicitud)
        {
            return EvaluadorEdad.EsValida(pSolicitud);
        }
        public bool EvaluarPrestamo(SolicitudPrestamo pSolicitudPrestamo)
        {

        }
    }
}