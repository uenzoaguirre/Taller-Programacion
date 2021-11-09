using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class DTOEdicion
    {
        public string Isbn { get; set; }
        public int  Edicion { get; set; }
        public int numeroPaginas { get; set; }
        public string Portada { get; set; }
        public DateTime FechaPublicacion { get; set; }
        
    }
}