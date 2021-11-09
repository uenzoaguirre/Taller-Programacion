using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public interface IServicesEdicion
    {
         List<DTOEdicion> Buscar (Dictionary<string,string> pFiltros);
    }
}