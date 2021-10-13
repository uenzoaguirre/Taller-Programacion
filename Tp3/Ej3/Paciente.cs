using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej3
{
    public class Paciente
    {
        string nombre;
    public Paciente(string pNombre)
    {
        this.nombre = pNombre;
    }
        public string Nombre
        {get {return this.nombre;}

        }
        
    }

}