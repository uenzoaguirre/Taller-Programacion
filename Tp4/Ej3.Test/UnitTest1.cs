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
            var repositorioUsuario = new RepositorioUsuarioMemoria();
            pUsuario.Codigo = "ABC";
            repositorioUsuario.Agregar(pUsuario);
            Usuario pUsuario1 = new Usuario();  
            pUsuario1.Codigo = "CBA";
            repositorioUsuario.Agregar(pUsuario1);
            var usuariosTodos = repositorioUsuario.ObtenerTodos();
            Assert.Equal (usuariosTodos.Count, 2); 
            Assert.True (usuariosTodos.Contains(pUsuario));
            Assert.True (usuariosTodos.Contains(pUsuario1));
        }
    }
}
