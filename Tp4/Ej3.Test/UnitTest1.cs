using System;
using Xunit;

namespace Ej3.Test
{
    public class UnitTest1
    {
        [Fact]
        public void DeberiaObtenerTodos()
        {
            Usuario pUsuario = new Usuario();  
            Usuario pUsuario1 = new Usuario();  
            var repositorioUsuario = new RepositorioUsuarioMemoria();

            pUsuario.Codigo = "ABC";

            repositorioUsuario.Agregar(pUsuario);

            pUsuario1.Codigo = "CBA";

            repositorioUsuario.Agregar(pUsuario1);
            
            var usuariosTodos = repositorioUsuario.ObtenerTodos();
            Assert.Equal (2, usuariosTodos.Count); 
            Assert.True (usuariosTodos.Contains(pUsuario));
            Assert.True (usuariosTodos.Contains(pUsuario1));
        }

        [Fact]
        public void DeberiaObtenerOrdenadosPorCodigos()
        {
            Usuario pUsuario = new Usuario();  
            Usuario pUsuario1 = new Usuario();  
            var repositorioUsuario = new RepositorioUsuarioMemoria();
            
            pUsuario.Codigo = "ZBC";
            pUsuario1.Codigo = "CBA";
            
            repositorioUsuario.Agregar(pUsuario);
            repositorioUsuario.Agregar(pUsuario1);

            var ordenadosPorCodigos = repositorioUsuario.ObtenerOrdenadosPorCodigo();
            Assert.Equal (2, ordenadosPorCodigos.Count);
            Assert.Equal ("CBA", ordenadosPorCodigos[0].Codigo);
        }
    }
}
