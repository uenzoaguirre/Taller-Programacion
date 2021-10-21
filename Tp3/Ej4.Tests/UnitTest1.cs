using System;
using Xunit;

namespace Ej4.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void EncriptadorCesar_HappyPath_Ok()
        {
            //Arrange
            EncriptadorCesar Ecesar = new EncriptadorCesar(4);

            //Act
            string mensaje = "Lihuen esta desempleado";
            string encriptada = Ecesar.Encriptar(mensaje);
            string desencriptada = Ecesar.Desencriptar(encriptada);
            //Assert
            Assert.Equal(desencriptada, mensaje);
            
        }
    }
}
