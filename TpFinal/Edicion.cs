using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class Edicion
    {
        string isbn;
        string edicion;
        string numeroPaginas;
        string portada;

        string fechaPublicacion;

        public string Isbn
        {
            get
            {
                return this.isbn;
            }
        }
        
        public string Edicion
        {
            get
            {
                return this.edicion;
            }
        }

        public string numeroPaginas
        {
            get
            {
                return this.numeroPaginas;
            }
        }

        public string Portada
        {
            get
            {
                return this.portada;
            }
        }

        public void Edicion(string pIsbn , string pEdicion , int pNumeroPaginas , string pPortada , date pFechaPublicacion) //Esta en el diag pero no va-> (List<Genero> generos )
        {
            this.isbn = pIsbn;
            this.edicion = pEdicion;
            this.numeroPaginas = pNumeroPaginas;
            this.portada = pPortada;
            this.fechaPublicacion = pFechaPublicacion;

        }

        



    }
}