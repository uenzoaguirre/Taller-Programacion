using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class DTOObra
    {
        public string Titulo { get; set; }
        public string Lccn { get; set; }
        public string Descripcion { get; set; }
        public List<string> Generos { get; set; }
        public string Autor { get; set; }
        public List<string> Ediciones { get; set; }

        
    }
}