using System;
using Xunit;

namespace Ej4.Test
{
    public class tester
    {
        [Fact]
        public void EvaluadorMonto_Happy_Path_Ok()
        {
            
            Empleo pEmpleo1 = new Empleo(4500, new DateTime(2021,11,10));
            Cliente cliente1 = new Cliente( "Lihuen" , "Segovia" , new DateTime(2000,12,30) , pEmpleo1); 
            SolicitudPrestamo pSolicitud = new SolicitudPrestamo(cliente1,200000,30);
            EvaluadorMonto eMontoF = new EvaluadorMonto(20000);
            EvaluadorMonto eMontoT = new EvaluadorMonto(250000);
            Assert.False(eMontoF.EsValida(pSolicitud));
            Assert.True(eMontoT.EsValida(pSolicitud));
        
        }
        [Fact]
        public void EvaluadorAntLaboral_Happy_Path_Ok()
        {
            
            Empleo pEmpleo1 = new Empleo(4500, new DateTime(2020,11,10));
            Cliente cliente1 = new Cliente( "Lihuen" , "Segovia" , new DateTime(2000,12,30) , pEmpleo1); 
            SolicitudPrestamo pSolicitud = new SolicitudPrestamo(cliente1,200000,30);
            EvaluadorAntiguedadLaboral eAntiguedadT = new EvaluadorAntiguedadLaboral(6);
            EvaluadorAntiguedadLaboral eAntiguedadF = new EvaluadorAntiguedadLaboral(18);
            Assert.False(eAntiguedadF.EsValida(pSolicitud));
            Assert.True(eAntiguedadT.EsValida(pSolicitud));
        } 
        [Fact]
        public void EvaluadorCuotas_Happy_Path_Ok()
        {
            
            Empleo pEmpleo1 = new Empleo(4500, new DateTime(2020,11,10));
            Cliente cliente1 = new Cliente( "Lihuen" , "Segovia" , new DateTime(2000,12,30) , pEmpleo1); 
            SolicitudPrestamo pSolicitud = new SolicitudPrestamo(cliente1,200000,30);
            EvaluadorCantidadCuotas eCuotasT = new EvaluadorCantidadCuotas(50);
            EvaluadorCantidadCuotas eCuotasF = new EvaluadorCantidadCuotas(1);
            Assert.False(eCuotasF.EsValida(pSolicitud));
            Assert.True(eCuotasT.EsValida(pSolicitud));
        } 

        [Fact]
        public void EvaluadorSueldo_Happy_Path_Ok()
        {
            
            Empleo pEmpleo1 = new Empleo(4500, new DateTime(2020,11,10));
            Cliente cliente1 = new Cliente( "Lihuen" , "Segovia" , new DateTime(2000,12,30) , pEmpleo1); 
            SolicitudPrestamo pSolicitud = new SolicitudPrestamo(cliente1,200000,30);
            EvaluadorSueldo eSueldoT = new EvaluadorSueldo(3000);
            EvaluadorSueldo eSueldoF = new EvaluadorSueldo(8000);
            Assert.False(eSueldoF.EsValida(pSolicitud));
            Assert.True(eSueldoT.EsValida(pSolicitud));
        } 

        [Fact]
        public void EvaluadorEdad_Happy_Path_Ok()
        {
            
            Empleo pEmpleo1 = new Empleo(4500, new DateTime(2020,11,10));
            Cliente cliente1 = new Cliente( "Lihuen" , "Segovia" , new DateTime(2000,12,30) , pEmpleo1); 
            SolicitudPrestamo pSolicitud = new SolicitudPrestamo(cliente1,200000,30);
            EvaluadorEdad eEdadT = new EvaluadorEdad(18 , 40);
            EvaluadorEdad eEdadF = new EvaluadorEdad(50, 60);
            Assert.False(eEdadF.EsValida(pSolicitud));
            Assert.True(eEdadT.EsValida(pSolicitud));
        } 



    }
}
