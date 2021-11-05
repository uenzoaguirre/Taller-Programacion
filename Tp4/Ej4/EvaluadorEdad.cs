using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class EvaluadorEdad : IEvaluador
    {
        int iEdadMinima;
        int iEdadMaxima;

        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            this.iEdadMaxima = pEdadMaxima;
            this.iEdadMinima = pEdadMinima;
        }



        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            var edad = DateTime.Today.Subtract(pSolicitud.Cliente.FechaNacimiento);
            var edadAnios = edad.TotalDays / 365;

            return edadAnios > this.iEdadMinima && edadAnios < this.iEdadMaxima; 
        }
    }
}