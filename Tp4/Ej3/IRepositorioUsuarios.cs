using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej3
{
    public interface IRepositorioUsuarios
    {
        void Agregar(Usuario pUsuario);
        void Actualizar(Usuario pUsuario);
        void Eliminar(string pCodigo);
        IList<Usuario> ObtenerTodos();
        Usuario ObtenerPorCodigo(string pCodigo);
        IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador);
        IList<Usuario> ObtenerOrdenadosPorCodigo();
        IList<Usuario> ObtenerOrdenadosPorNombreCompleto();
        IList<Usuario> ObtenerOrdenadosPorCorreo();
        IList<Usuario> ObtenerPorAproximacion(string codigo);
    }
    public class CompararUsuarioPorCodigo : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return x.Codigo.CompareTo(y.Codigo);
        }
    }
    public class CompararUsuarioPorNombreCompleto : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return x.NombreCompleto.CompareTo(y.NombreCompleto);
        }
    }
     public class CompararUsuarioPorCorreo : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return x.CorreoElectronico.CompareTo(y.CorreoElectronico);
        }
    }
}