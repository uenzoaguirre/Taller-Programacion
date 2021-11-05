using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej3
{
    public class RepositorioUsuarioMemoria : IRepositorioUsuarios
    {
        Dictionary<string,Usuario> iUsuarios = new Dictionary<string, Usuario>();
        public void Agregar (Usuario pUsuario)
        {
            iUsuarios.Add (pUsuario.Codigo, pUsuario);
        }
        public void Actualizar (Usuario pUsuario)
        {
           iUsuarios[pUsuario.Codigo] = pUsuario;
        }
        public void Eliminar (string pCodigo)
        {
            iUsuarios.Remove (pCodigo);
        }
        public IList<Usuario> ObtenerTodos ()
        {
            return new List<Usuario>(iUsuarios.Values);
        }
        public Usuario ObtenerPorCodigo (string pCodigo)
        {
            return iUsuarios[pCodigo]; 
        }
        public IList<Usuario> ObtenerOrdenadosPor (IComparer<Usuario> pComparador)
        {
            var usuarios = this.ObtenerTodos();
            ((List<Usuario>)usuarios).Sort(pComparador);
            return usuarios;
        }
        public IList<Usuario> ObtenerOrdenadosPorCodigo()
        {
            return this.ObtenerOrdenadosPor( new CompararUsuarioPorCodigo());
        }
         public IList<Usuario> ObtenerOrdenadosPorNombreCompleto()
        {
            return this.ObtenerOrdenadosPor( new CompararUsuarioPorNombreCompleto());
        }
        public IList<Usuario> ObtenerOrdenadosPorCorreo()
        {
            return this.ObtenerOrdenadosPor( new CompararUsuarioPorCorreo());
        }
        public IList<Usuario> ObtenerPorAproximacion (string codigo)
        {
            var obtenidos = this.ObtenerTodos();
            var filtrados = new List<Usuario>();
            foreach (var usuario in obtenidos)
            {
                if (usuario.Codigo.Contains(codigo))
                {
                    filtrados.Add(usuario);
                }
            }
            return filtrados;
        }
    }

}