using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej1
{
    public class Matematica
    {
        public static double Dividir(int pDividendo , int pDivisor)
        {
            if (pDivisor == 0)
            {
                throw new DivisionPorCeroException("No se puede dividir por cero");
            }
            return (pDividendo / pDivisor);
        }
    }
}