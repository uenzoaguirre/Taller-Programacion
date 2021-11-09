using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class EvaluadorAntiguedadLaboral: IEvaluador

    {
        int iAntiguedadMinima;
        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }


         public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            var antiguedad = DateTime.Today.Subtract(pSolicitud.Cliente.Empleo.FechaIngreso);
            var antiguedadMeses = antiguedad.TotalDays / 30;

            return antiguedadMeses > this.iAntiguedadMinima;
        }
   
    }
}