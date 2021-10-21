using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    
    public abstract class Encriptador
    {
        string iNombre;

        public Encriptador(string pNombre)
        {
            this.iNombre = pNombre;
        }    

        public string Nombre { get { return iNombre; } }

        public abstract string Encriptar(string pCadena);

        public abstract string Desencriptar(string pCadena);




    }


}