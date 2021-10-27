using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class Autor
    {
        string id;
        string nombre;
        List<string> nombresAlternativos;

        public string Id
        {
            get
            {
                return this.id;
            }
        }

        public string nombre
        {
            get 
            {
                return this.nombre;
            }
        }

        public List<string> nombresAlternativos
        {
            get
            {
                return this.nombresAlternativos;
            }
        }

    }
}