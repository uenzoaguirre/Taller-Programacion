using System;
using Xunit;

namespace Ej4.test
{
    public class UnitTest1
    {
        [Fact]
        public void Suma_HappyPath_OK()
        {
           var Complejo1 = new Complejo (4,8);
           var Complejo2 = new Complejo (3,6);
           var Suma = Complejo1.Sumar(Complejo2);
           Assert.Equal(7,Suma.Real);
           Assert.Equal(14,Suma.Imaginario);
        }
        
        [Fact]  
         public void Resta_HappyPath_OK()
        {
           var Complejo1 = new Complejo (4,8);
           var Complejo2 = new Complejo (3,6);
           var Restar = Complejo1.Restar(Complejo2);
           Assert.Equal(1,Restar.Real);
           Assert.Equal(2,Restar.Imaginario);
        }

         [Fact]  
         public void Multiplicacion_HappyPath_OK()
        {
           var Complejo1 = new Complejo (4,8);
           var Complejo2 = new Complejo (3,6);
           var Multiplicacion = Complejo1.MultiplicarPor(Complejo2);
           Assert.Equal(12,Multiplicacion.Real);
           Assert.Equal(48,Multiplicacion.Imaginario);
        }

         [Fact]  
         public void Division_HappyPath_OK()
        {
           var Complejo1 = new Complejo (12,8);
           var Complejo2 = new Complejo (3,4);
           var Division = Complejo1.DividirPor(Complejo2);
           Assert.Equal(4,Division.Real);
           Assert.Equal(2,Division.Imaginario);
        }

          [Fact]  
         public void EsIgual_HappyPath_OK()
        {
            var Complejo1 = new Complejo (12,8);
            var Complejo2 = new Complejo (12,8);
            var Igual = Complejo1.EsIgual(Complejo2);
            Assert.True (Igual);            
        }
        [Fact]  
         public void EsIgual_HappyPath_False()
        {
            var Complejo1 = new Complejo (12,8);
            var Complejo2 = new Complejo (4,9);
            var Igual = Complejo1.EsIgual(Complejo2);
            Assert.False (Igual);            
        }

        [Fact]  
         public void EsIgualExplicit_HappyPath_OK()
        {
            var Complejo1 = new Complejo (12,8);
            var Igual = Complejo1.EsIgual(12,8);
            Assert.True (Igual);            
        }
         [Fact]  
         public void EsIgualExplicit_HappyPath_False()
        {
            var Complejo1 = new Complejo (12,8);
            var Igual = Complejo1.EsIgual(1,7);
            Assert.False (Igual);            
        }
        [Fact]  
         public void EsImaginario_HappyPath_OK()
        {
            var Complejo1 = new Complejo (12,4);
            var Imaginario = Complejo1.EsImaginario();
            Assert.True (Imaginario);            
        }
        [Fact]  
         public void EsImaginario_HappyPath_False()
        {
            var Complejo1 = new Complejo (12,0);
            var Imaginario = Complejo1.EsImaginario();
            Assert.False (Imaginario);            
        }
        [Fact]  
         public void EsReal_HappyPath_OK()
        {
            var Complejo1 = new Complejo (12,0);
            var Real = Complejo1.EsReal();
            Assert.True (Real);            
        }
        [Fact]  
         public void EsReal_HappyPath_False()
        {
            var Complejo1 = new Complejo (0,3);
            var Real = Complejo1.EsReal();
            Assert.False (Real);            
        }

         [Fact]  
         public void Magnitud_HappyPath_OK()
        {
            var Complejo1 = new Complejo (5,10);
            var Magnitud = Complejo1.Magnitud;
            var Esperado = Math.Sqrt( Math.Pow(5, 2) + Math.Pow(10,2));
            Assert.Equal (Esperado, Magnitud);            
        }

         [Fact]  
         public void Conjugado_HappyPath_OK()
        {
            var Complejo1 = new Complejo (5,10);
            var Conjugado = Complejo1.Conjugado;
            Assert.Equal (5, Conjugado.Real); 
            Assert.Equal (-10, Conjugado.Imaginario);            
        }
        
         [Fact]  
         public void Argumentos_HappyPath_OK()
        {
            var Real = 5;
            var Imaginario = 10;
            var Complejo1 = new Complejo (Real,Imaginario);
            var ArgumentosRadianes = Complejo1.ArgumentosEnRadianes;
            var ArgumentosGrados = Complejo1.ArgumentosEnGrados;
            var ArgumentoEsperado = Math.Atan(Imaginario/Real);  
            Assert.Equal(ArgumentoEsperado, ArgumentosRadianes);     
            Assert.Equal( ArgumentoEsperado*180/Math.PI, ArgumentosGrados); 
        }
         [Fact]  
         public void ImaginarioYReal_HappyPath_OK()
        {
            var Complejo1 = new Complejo (5,10);
            Assert.Equal (5, Complejo1.Real); 
            Assert.Equal (10, Complejo1.Imaginario);            
        }
        


    }
}
