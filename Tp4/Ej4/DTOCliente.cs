using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class DTOCliente
    {   
        public string  Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int TipoCliente { get; set; }
        public double Sueldo { get; set; }
        public DateTime FechaIngreso { get; set; }
    
    }
}