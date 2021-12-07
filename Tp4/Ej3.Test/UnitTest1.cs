using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
         [Fact]
        public void DeberiaDeterminarSiExisteUsuario()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            Usuario pUsuario = new Usuario();  
            var repositorioUsuario = new RepositorioUsuarioMemoria();
            pUsuario.Codigo = "ABC";
            repositorioUsuario.Agregar(pUsuario);
          // Assert.Equal (pUsuario.Codigo, pUsuario.GetHashCode());

        }
    }
}
