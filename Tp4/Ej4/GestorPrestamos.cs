using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class GestorPrestamos

    {
        
        Dictionary<TipoCliente, List<IEvaluador>> iEvaluadoresPorCliente;
        public GestorPrestamos()
        {
            iEvaluadoresPorCliente = new Dictionary<TipoCliente, List<IEvaluador>>{
                                    {TipoCliente.NoCliente, new List<IEvaluador>
            {
                new EvaluadorAntiguedadLaboral(6),new EvaluadorCantidadCuotas(12), new EvaluadorEdad(18,75) ,
                new EvaluadorMonto(20000) , new EvaluadorSueldo(5000)

            }},{TipoCliente.Cliente,  new List<IEvaluador>
            {
                new EvaluadorAntiguedadLaboral(6),new EvaluadorCantidadCuotas(32), new EvaluadorEdad(18,75) ,
                new EvaluadorMonto(100000) , new EvaluadorSueldo(5000)

            }},{TipoCliente.ClienteGold,  new List<IEvaluador>
            {
                new EvaluadorAntiguedadLaboral(6),new EvaluadorCantidadCuotas(60), new EvaluadorEdad(18,75) ,
                new EvaluadorMonto(150000) , new EvaluadorSueldo(5000)
            }},{TipoCliente.ClientePlatinum,  new List<IEvaluador>
            {
                new EvaluadorAntiguedadLaboral(6),new EvaluadorCantidadCuotas(60), new EvaluadorEdad(18,75) ,
                new EvaluadorMonto(200000) , new EvaluadorSueldo(5000)
            }}};

        }

        public bool Esvalida(SolicitudPrestamo pSolicitud)
        {
            EvaluadorCompuesto eCompuesto = new EvaluadorCompuesto();
            List<IEvaluador> evaluadores = this.iEvaluadoresPorCliente[pSolicitud.Cliente.Tipo]; 

            foreach (IEvaluador item in evaluadores)
            {
                eCompuesto.AgregarEvaluador(item);

            }

            return eCompuesto.EsValida(pSolicitud);
        }
    }
}