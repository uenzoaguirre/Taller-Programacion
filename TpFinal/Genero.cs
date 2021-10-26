using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class Genero
    {
        string nombre;
        string id;
        string nombreIngles;

        public string Nombre
        {
            get
            {
                this.nombre;
            }
        }

        public string Id
        {
            get
            {
                this.id;
            }
        }

        public string NombreIngles
        {
            get
            {
                this.nombreIngles;
            }
        }

        public void Genero(string pNombre, string pId)
        {
            this.nombre = pNombre;
            this.id = pId;
        }

    }
}
