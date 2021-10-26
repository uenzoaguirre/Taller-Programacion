using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class Editorial
    {
        string nombre;

        public void Nombre
        {
            get
            {
                this.nombre;
            }
        }

        public string Editorial(string pNombre) //Falto ctor. en el diagrama
        {
            this.nombre = pNombre;
        }
    }
}