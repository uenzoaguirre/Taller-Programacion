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
        [Fact]
        public void EncriptadorAES_HappyPath_OK()
        {
            //Arrange
            EncriptadorAES EAES = new EncriptadorAES();

            //Act
            string mensaje = "Lihuen esta desempleado";
            string encriptada = EAES.Encriptar(mensaje);
            Console.WriteLine("Esta es la cadena:{0}", encriptada);
            string desencriptada = EAES.Desencriptar(encriptada);
            //Assert
            Assert.Equal(desencriptada, mensaje);
        }

        [Fact]
        public void EncriptadorBlowFish_HappyPath_OK()
        {
            //Arrange
            EncriptadorBlowFish EBlowFish = new EncriptadorBlowFish();

            //Act
            string mensaje = "Lihuen esta desempleado";
            string encriptada = EBlowFish.Encriptar(mensaje);
            string desencriptada = EBlowFish.Desencriptar(encriptada);
            //Assert
            Assert.Equal(desencriptada, mensaje);
        }


        [Fact]
        public void EncriptadorDES_HappyPath_OK()
        {
            //Arrange
            EncriptadorDES EDES = new EncriptadorDES();

            //Act
            string mensaje = "Lihuen esta desempleado";
            string encriptada = EDES.Encriptar(mensaje);
            string desencriptada = EDES.Desencriptar(encriptada);
            //Assert
            Assert.Equal(desencriptada, mensaje);
        }
        [Fact]
        public void EncriptadorNulo_HappyPath_OK()
        {
            //Arrange
            EncriptadorNulo ENulo = new EncriptadorNulo();

            //Act
            string mensaje = "Lihuen esta desempleado";
            string encriptada = ENulo.Encriptar(mensaje);
            string desencriptada = ENulo.Desencriptar(encriptada);
            //Assert
            Assert.Equal(desencriptada, mensaje);
        }
            [Fact]
         public void FabricaEncriptadores_HappyPath_OK()
         {
             //Arrange
             FabricaEncriptadores eEncriptadores = FabricaEncriptadores.Instance;

            //Act
            EncriptadorCesar cesarcito = (EncriptadorCesar)eEncriptadores.GetEncriptador("Cesar");
            EncriptadorDES DEScito = (EncriptadorDES)eEncriptadores.GetEncriptador("DES");
            EncriptadorBlowFish blowFishcito = (EncriptadorBlowFish)eEncriptadores.GetEncriptador("BlowFish");
            EncriptadorNulo nulcito = (EncriptadorNulo)eEncriptadores.GetEncriptador("Null");
            EncriptadorAES AEScito = (EncriptadorAES)eEncriptadores.GetEncriptador("AES");


            //Assert
             Assert.Equal("Cesar",cesarcito.Nombre);
             Assert.Equal("DES",DEScito.Nombre);
             Assert.Equal("BlowFish",blowFishcito.Nombre);
             Assert.Equal("Null",nulcito.Nombre);
             Assert.Equal("AES",AEScito.Nombre);
         } 


    }
}
