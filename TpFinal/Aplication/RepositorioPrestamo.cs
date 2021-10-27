using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class RepositorioPrestamo: IRepositorio<Prestamo>
    {
         List<Prestamo> iListaPrestamos;
        public RepositorioPrestamo()
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
        public Prestamo Encontrar(int predicado)
        {
            return this.iListaPrestamos.Find(predicado=> iListaPrestamos.Predicado==predicado);

        }

    }
}