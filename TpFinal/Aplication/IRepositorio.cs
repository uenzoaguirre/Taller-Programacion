using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Aplication
{
    public interface IRepositorio<T> 
    {
        void Agregar(T pItem);
        
        IEnumerable<T> ObtenerTodos();


        IEnumerable<T> Encontrar(Expression< Func<T,bool> > predicado );
    }
}