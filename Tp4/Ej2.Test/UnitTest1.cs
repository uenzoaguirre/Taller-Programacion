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

    [Fact]
        public void DeberiaActualizarUsuarioCorrectamente ()
        {
            Usuario pUsuario = new Usuario();  
            var repositorioUsuario = new RepositorioUsuarioMemoria();
            pUsuario.Codigo = "ABC";
            pUsuario.NombreCompleto = "Pablo";
            repositorioUsuario.Agregar(pUsuario);
            Usuario pUsuario1 = new Usuario(); 
            pUsuario1.Codigo = "ABC";
            pUsuario1.NombreCompleto = "Enzo";
            repositorioUsuario.Actualizar(pUsuario1);
            var usuarioEncontrado = repositorioUsuario.ObtenerPorCodigo("ABC");
            Assert.Equal ("Enzo",usuarioEncontrado.NombreCompleto);     
        }
        [Fact]
        public void DeberiaObtenerTodos()
        {
            Usuario pUsuario = new Usuario();  
            var repositorioUsuario = new RepositorioUsuarioMemoria();
            pUsuario.Codigo = "ABC";
            repositorioUsuario.Agregar(pUsuario);
            Usuario pUsuario1 = new Usuario();  
            pUsuario1.Codigo = "CBA";
            repositorioUsuario.Agregar(pUsuario1);
            var usuariosTodos = repositorioUsuario.ObtenerTodos();
            Assert.Equal (usuariosTodos.Count, 2);
        }
        [Fact]
        public void DeberiaObtenerOrdenadosPorCodigos()
        {
           Usuario pUsuario = new Usuario();  
            var repositorioUsuario = new RepositorioUsuarioMemoria();
            pUsuario.Codigo = "ZBC";
            repositorioUsuario.Agregar(pUsuario);
            Usuario pUsuario1 = new Usuario();  
            pUsuario1.Codigo = "CBA";
            repositorioUsuario.Agregar(pUsuario1);
            var ordenadosPorCodigos = repositorioUsuario.ObtenerOrdenadosPorCodigo();
            Assert.Equal (ordenadosPorCodigos.Count, 2);
            Assert.Equal (ordenadosPorCodigos[0].Codigo,"CBA");
        }
        
        
    }
}
