using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class EvaluadorCompuesto : IEvaluador
    {
        List<IEvaluador> iEvaluadores;
        public EvaluadorCompuesto()
        {
            iEvaluadores = new List<IEvaluador>();
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            foreach (var evaluador in iEvaluadores)
            {
                if (!evaluador.EsValida(pSolicitud))
                {
                    return false;
                }

            }
            return true;
        }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            iEvaluadores.Add(pEvaluador);
        }



    }
}