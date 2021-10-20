using System;
using Xunit;

namespace Ej3.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Nivel_HappyPath_OK()
        {
            //Arrange
            Nivel nivel = new Nivel(1,"Bla","Violeta");

            //Act
            var paciente = new Paciente("Juan");
            var paciente2 = new Paciente("Jorge");
            nivel.Agregar(paciente);
            nivel.Agregar(paciente2);

            //Assert
            var juancito = nivel.Obtener();
            Assert.Equal("Juan", juancito.Nombre);
            Assert.Equal(1, nivel.CantidadDeElementos());

            var jorgito = nivel.Obtener();
            Assert.Equal("Jorge", jorgito.Nombre);
            Assert.Equal(0, nivel.CantidadDeElementos());

        }
        [Fact]
         public void EstrategiaAtencionTriaje_HappyPath_OK()
        {
            
            
            //Arrange
            EstrategiaAtencionTriaje eTriaje = new EstrategiaAtencionTriaje();

            //Act
            var paciente = new PacienteEnEspera(new Paciente("Juan"),2);
            var paciente2 = new PacienteEnEspera(new Paciente("Jorge"),2);
            eTriaje.Agregar(paciente);
            eTriaje.Agregar(paciente2);

            //Assert
            var juancito = eTriaje.ObtenerPrioritario();
            Assert.Equal("Juan", juancito.Nombre);

            var jorgito = eTriaje.ObtenerPrioritario();
            Assert.Equal("Jorge", jorgito.Nombre);

            var nullcito = eTriaje.ObtenerPrioritario();
            Assert.Null(nullcito);


        }
         [Fact]
        public void EstrategiaAtencionFifo_HappyPath_OK()
        {
            //Arrange
            EstrategiaAtencionFifo eFifo = new EstrategiaAtencionFifo();
          
            //Act
            var paciente = new PacienteEnEspera(new Paciente("Juan"),2);
            var paciente2 = new PacienteEnEspera(new Paciente("Jorge"),2);
            eFifo.Agregar(paciente);
            eFifo.Agregar(paciente2);

            //Assert
            var juancito = eFifo.ObtenerPrioritario();
            Assert.Equal("Juan", juancito.Nombre);
            
            Assert.Equal(1,eFifo.CantidadPacientesEnEspera());
            var jorgito = eFifo.ObtenerPrioritario();
            Assert.Equal("Jorge", jorgito.Nombre);

            var nullcito = eFifo.ObtenerPrioritario();
            Assert.Null(nullcito);

        }


    }
}
