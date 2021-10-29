using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej1
{
    public class DivisionPorCeroException : Exception
    {   
        
        public DivisionPorCeroException(string pMensaje) : base(pMensaje)
        {

        }
        
    }
}