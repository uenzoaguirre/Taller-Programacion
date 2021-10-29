using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej1
{
    public class Fachada
    {
        public double Dividir(int pDividendo , int pDivisor)
        {
            try
            {
                return Matematica.Dividir(pDividendo, pDivisor);
            }

            catch(DivisionPorCeroException excepcion)
            {
                throw new Exception(excepcion.Message);
            }
            
        }
}
}