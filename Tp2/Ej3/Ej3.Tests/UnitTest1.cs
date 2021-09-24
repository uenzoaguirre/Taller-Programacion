using System;
using Xunit;


namespace Ej3.Tests
{
    public class PartidaTest
    {
        [Fact]
        public void Partida_HappyPath_OK()
        {
            //Arrange
            Partida partida = new Partida("Enzo", 12, "abc", "Matriz", 10);

            //Act
            var pNombre = partida.Nombre;
            var pEdad = partida.Edad;
            var pId = partida.Id;


            //Assert 
            Assert.Equal("Enzo", pNombre);
            Assert.Equal(12, pEdad);
            Assert.Equal("abc", pId);
        }

        [Fact]
        public void RepositorioPartidas_HappyPath_OK()
        {

            //Arange (Para el repositorio de las partidas)
            RepositorioPartidas iRepoPartidas = new RepositorioPartidas();
            Partida partida = new Partida("Enzo", 12, "abc", "Matriz", 10);

            //Act
            iRepoPartidas.Agregar(partida);
            var pPartidaObtenida = iRepoPartidas.ObtenerPorId(partida.Id);
            var pObtenidasTodas = iRepoPartidas.ObtenerTodas();

            //Assert    
            Assert.Equal("abc", pPartidaObtenida.Id);
            Assert.Equal("abc", pObtenidasTodas[0].Id);

        }
        [Fact]
        public void AdminPalabras_HappyPath_OK()
        {
            //Arrange 
            AdministradorPalabras iAdminPalabras = new AdministradorPalabras("h");

            //Act
            var pPalabraComparar = iAdminPalabras.VerificarLetra('h');

            //Assert
            Assert.Equal('h', pPalabraComparar[0].Caracter);
            Assert.Equal(0, pPalabraComparar[0].Indice);
            Assert.Equal(true, iAdminPalabras.VerificarSigano());

        }






    }

}
