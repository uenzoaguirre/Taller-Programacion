using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public interface IEvaluador
    {
        bool EsValida(SolicitudPrestamo pSolicitud);
    }
}