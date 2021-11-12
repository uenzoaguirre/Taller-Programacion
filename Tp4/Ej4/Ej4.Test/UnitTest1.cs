using System;
using Xunit;

namespace Ej4.Test
{
    public class tester
    {
        [Fact]
        public void EvaluadorCompuesto_Happy_Path_Ok()
        {
            Empleo pEmpleo1 = new Empleo(4500, 10 - 11 - 2021);
            Cliente cliente1 = new Cliente( Lihuen, Segovia, 30-12-2000 , pEmpleo1); 
            SolicitudPrestamo pSolicitud = new SolicitudPrestamo(Cliente1,200000,30);
            EvaluadorCompuesto eCompuesto = new EvaluadorCompuesto();
            Assert.Equal(false, eCompuesto.EsValida(pSolicitud));
        }
    }
}
