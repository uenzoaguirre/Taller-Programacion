using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Aplication
{
    public class IRepositorioPrestamo: IRepositorio<Prestamo>
    {
         List<Prestamo> iListaPrestamos;
        public IRepositorioPrestamo()
        {
            this.iListaPrestamos = new List<Prestamo>();
        }

        public void Agregar(Prestamo pPrestamo)
        {
            this.iListaPrestamos.Add(pPrestamo);
        }

        public Prestamo Obtener(int prestamoId)
        {
            return this.iListaPrestamos.Find(prestamo => prestamo.Id == prestamoId);
        }
        public IEnumerable<Prestamo> Encontrar(Expression< Func<Prestamo,bool> > predicado )
        {
            //return this.iListaPrestamos.Find(predicado=> iListaPrestamos.Predicado==predicado);
            throw new NotImplementedException();
        }
        public IEnumerable<Prestamo> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}