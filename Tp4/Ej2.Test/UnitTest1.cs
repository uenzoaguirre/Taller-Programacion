using System;
using Xunit;
using System.Collections.Generic;

namespace Ej2.Test
{
    public class UnitTest1
    {
        [Fact]
        public void DeberiaAgregarUnUsuarioCorrectamente()
        {
            Usuario pUsuario = new Usuario();  
            var repositorioUsuario = new RepositorioUsuarioMemoria();
            pUsuario.Codigo = "ABC";
            repositorioUsuario.Agregar(pUsuario);
            var resultadoObtenido = repositorioUsuario.ObtenerPorCodigo("ABC");
            Assert.Equal("ABC",resultadoObtenido.Codigo); 
        }
        [Fact]
        public void DeberiaEliminarUnUsuarioCorrectamente()
        {
            Usuario pUsuario = new Usuario();  
            var repositorioUsuario = new RepositorioUsuarioMemoria();
            pUsuario.Codigo = "ABC";
            repositorioUsuario.Agregar(pUsuario);
            repositorioUsuario.Eliminar("ABC");
            Assert.Throws<KeyNotFoundException>(()=> repositorioUsuario.ObtenerPorCodigo("ABC"));
        }
    }
}
